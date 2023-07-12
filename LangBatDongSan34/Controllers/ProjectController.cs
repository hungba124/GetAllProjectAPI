using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System.Xml;

namespace LangBatDongSan34.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : Controller
    {
        private readonly LangBatDongSan43Context _context;

        public ProjectController(LangBatDongSan43Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Project>>> GetProjects()
        {
            return Ok(await _context.Projects.ToListAsync());
        }

        [HttpGet("WithStoreProcedure")]
        public async Task<ActionResult<List<Project>>> GetAllProjectsWithSP(
            string typeIds = "",
            decimal priceMin = 0,
            decimal priceMax = 0,
            int isPublished = 1,
            int status = 0,
            int investorId = 0,
            int provinceId = 0,
            int districtId = 0,
            int communeId = 0,
            int orderBy = 0,
            int pageIndex = 0,
            int pageSize = 15
        )
        {
            try
            {
                var result = await _context.Projects
                    .FromSqlRaw(
                        $"huongnd.GetAllProject {(typeIds == "" ? "null" : ("'" + typeIds + "'"))}, " +
                        $"{(priceMin == 0 ? "null" : priceMin)}, " +
                        $"{(priceMax == 0 ? "null" : priceMax)}, " +
                        $"{isPublished}, {status}, " +
                        $"{investorId}, {provinceId}, {districtId}, {communeId}, " +
                        $"{orderBy}, {pageIndex}, {pageSize}"
                    )
                    .ToListAsync();

                return Ok(result);
            }
            catch (Exception ex)
            {
                throw new Exception($"Params error: {ex.Message}");
            }
        }

        public virtual IList<Core.Entities.News> GetListNewsItems2(string link)
        {
            //Logging.Infor("Downloading news: " + link);
            List<Core.Entities.News> lstNews = new List<Core.Entities.News>();

            string xPathList = "//ul[contains(@class, 'list_news_topcate list_news_subcate')]/li";
            string xPathDetail = "";

            try
            {
                //TestRequest(link);

                //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(link);
                //WebProxy myProxy = new WebProxy();              
                //request.Proxy = myProxy;
                //request.Timeout = 30000;
                //request.ReadWriteTimeout = 30000;

                //request.Accept = "*/*";
                ////request.UserAgent = "Mozilla/24.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.2.3) Gecko/20100401 Firefox/3.6.3 (.NET CLR 3.5.30729)";
                //request.UserAgent = @"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/51.0.2704.106 Safari/537.36";
                //request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8";
                //request.Headers.Add(HttpRequestHeader.AcceptEncoding, "gzip,deflate");
                //request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                ////request.UseDefaultCredentials = true;
                //request.KeepAlive = false;
                //request.Method = "GET";

                //HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                //Stream stream = response.GetResponseStream();
                //StreamReader readStream = new StreamReader(stream, Encoding.UTF8);

                //string str = readStream.ReadToEnd();

                //readStream.Close();
                //HtmlDocument hd = new HtmlDocument();
                //str = str.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty).Replace("  ", string.Empty);
                //hd.LoadHtml(str.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty));


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
                        Core.Entities.News news = new Core.Entities.News();
                        news.CreatedOn = DateTime.Now;

                        news.Title = item.ChildNodes[3].ChildNodes[1].InnerText.Trim();
                        news.SeName = news.Title.GetSeName();
                        if (!lstNews.Select(c => c.SeName).Contains(news.SeName))
                        {
                            if (!string.IsNullOrEmpty(news.Title))
                            {
                                var existNews = GetNewsBySeName(news.SeName);
                                if (existNews == null)
                                {
                                    //HuongND 26/10/2019 download image
                                    string defaultPictureUrl = item.ChildNodes[1].ChildNodes[1].Attributes["src"].Value;

                                    news.DefaultPicture = defaultPictureUrl;

                                    news.MetaTitle = news.MetaTitle ?? news.Title.ReplaceSpecialChar();
                                    if (string.IsNullOrEmpty(news.MetaKeywords))
                                    {
                                        string key1 = news.MetaTitle.ToLower().Replace(" ", ", ");
                                        while (key1.Contains(",,"))
                                            key1 = key1.Replace(",,", ",");
                                        //string key2 = news.Title.ToLower().ReplaceSpecialChar().ConvertToUnSign().Replace(" ", ", ");
                                        //while (key2.Contains(",,"))
                                        //    key2 = key2.Replace(",,", ",");
                                        news.MetaKeywords = string.Format(Constants.Constant.SEO_METAKEYWORDS, key1);
                                    }
                                    if (string.IsNullOrEmpty(news.MetaDescription))
                                    {
                                        news.MetaDescription = string.Format(Constants.Constant.SEO_METADESCRIPTION, news.MetaTitle.ToLower(), news.MetaTitle.ToLower());
                                    }
                                    news.NewsTypeId = 1;
                                    url = item.ChildNodes[1].Attributes["href"].Value;

                                    news = GetNewsDetail2(url, xPathDetail, news);
                                    if (!string.IsNullOrEmpty(news.Full))
                                    {
                                        news.Published = true;
                                        news.CreatedBy = news.UpdatedBy = "admin"; //workContext.CurrentCustomer.Username;
                                        news.UpdatedOn = DateTime.Now;
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
                Logging.ErrorHandler("NewsController.GetListNewsItems", ex);
            }

            return lstNews;
        }
    }
}
