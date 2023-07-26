using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;

namespace LangBatDongSan34.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : Controller
    {
        private readonly LangBatDongSan43Context _context;

        public NewsController(LangBatDongSan43Context context)
        {
            _context = context;
        }

        //public virtual IList<News> GetListNewsItems2(string link)
        [HttpGet("GetListNews")]
        public async Task<ActionResult<List<News>>> GetListNewsItems2(string link)
        {
            //Logging.Infor("Downloading news: " + link);
            List<News> lstNews = new List<News>();

            string xPathList = "//div[contains(@class, 'listchungkhoannew')]/div[contains(@class, 'tlitem box-category-item')]";
            string xPathDetail = "//div[contains(@class, 'detail-content afcbc-body')]/p";

            try
            {
                string[] splitLink = link.Split('/');
                string domain = string.Join("/", splitLink.Take(3));
                var web = new HtmlWeb();
                var hd = web.Load(link);
                string url = "";
                #region Get Last News
                HtmlNodeCollection nc = hd.DocumentNode.SelectNodes(xPathList);
                if (nc != null)
                {
                    foreach (HtmlNode item in nc)
                    {
                        //Thread.Sleep(6000);
                        News news = new News();
                        news.CreatedOn = DateTime.Now;

                        news.Title = item.ChildNodes[1].ChildNodes[1].InnerText.Trim();
                        news.SeName = news.Title;

                        if (!lstNews.Select(c => c.SeName).Contains(news.SeName))
                        {
                            if (!string.IsNullOrEmpty(news.Title))
                            {
                                var existNews = GetNewsBySeName(news.SeName);
                                if (existNews == null)
                                {
                                    //HuongND 26/10/2019 download image
                                    //string defaultPictureUrl = item.ChildNodes[1].ChildNodes[1].Attributes["src"].Value;
                                    //news.DefaultPicture = defaultPictureUrl;
                                    news.PictureId = 0;

                                    //news.MetaTitle = news.MetaTitle ?? news.Title.ReplaceSpecialChar();
                                    news.MetaTitle = news.MetaTitle ?? news.Title;

                                    //if (string.IsNullOrEmpty(news.MetaKeywords))
                                    //{
                                    //    string key1 = news.MetaTitle.ToLower().Replace(" ", ", ");
                                    //    while (key1.Contains(",,"))
                                    //        key1 = key1.Replace(",,", ",");
                                    //    //string key2 = news.Title.ToLower().ReplaceSpecialChar().ConvertToUnSign().Replace(" ", ", ");
                                    //    //while (key2.Contains(",,"))
                                    //    //    key2 = key2.Replace(",,", ",");
                                    //    news.MetaKeywords = string.Format(Constants.Constant.SEO_METAKEYWORDS, key1);
                                    //}
                                    news.MetaKeywords = "Constant.SEO_METAKEYWORDS";
                                    //if (string.IsNullOrEmpty(news.MetaDescription))
                                    //{
                                    //    news.MetaDescription = string.Format(Constants.Constant.SEO_METADESCRIPTION, news.MetaTitle.ToLower(), news.MetaTitle.ToLower());
                                    //}
                                    news.MetaDescription = "Constant.SEO_METADESCRIPTION";
                                    news.NewsTypeId = 1;
                                    news.Short = item.ChildNodes[3].ChildNodes[3].ChildNodes[3].InnerHtml;


                                    url = item.ChildNodes[1].ChildNodes[1].Attributes["href"].Value;

                                    if (!Uri.IsWellFormedUriString(url, UriKind.Absolute))
                                    {
                                        url = domain + url;
                                    }

                                    news = GetNewsDetail2(url, xPathDetail, news);
                                    
                                    news.LanguageId = 1;
                                    news.AllowComments = true;
                                    news.StartDate = null;
                                    news.EndDate = null;

                                    if (!string.IsNullOrEmpty(news.Full))
                                    {
                                        news.Published = true;
                                        //if (!string.IsNullOrEmpty(News.Contents))
                                        lstNews.Add(news);
                                    }
                                }

                            }
                        }
                    }
                }
                #endregion
            }
            catch (Exception ex)
            {
                //Logging.ErrorHandler("NewsController.GetListNewsItems2", ex);
            }

            return lstNews;
        }
    
        private News GetNewsBySeName(string title)
        {
            var result = _context.News
                    .Where(b => b.Title == title)
                    .FirstOrDefault();

            return result;
        }

        private News GetNewsDetail2(string url, string xPathDetail, News news)
        {
            try
            {
                var web = new HtmlWeb();
                var hd = web.Load(url);
                #region Get Detail News
                HtmlNodeCollection nc = hd.DocumentNode.SelectNodes(xPathDetail);

                if (nc != null)
                {
                    foreach (HtmlNode item in nc)
                    {
                        news.Full += item.InnerHtml + "\n";
                    }
                }
                #endregion
            }
            catch (Exception ex)
            {
                //Logging.ErrorHandler("NewsController.GetNewsDetail2", ex);
            }

            return news;
        }
    }
}
