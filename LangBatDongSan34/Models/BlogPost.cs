using System;
using System.Collections.Generic;

namespace LangBatDongSan34.Models;

public partial class BlogPost
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Body { get; set; } = null!;

    public string? MetaKeywords { get; set; }

    public string? MetaTitle { get; set; }

    public int LanguageId { get; set; }

    public bool IncludeInSitemap { get; set; }

    public string? BodyOverview { get; set; }

    public bool AllowComments { get; set; }

    public string? Tags { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? MetaDescription { get; set; }

    public DateTime CreatedOn { get; set; }

    public virtual ICollection<BlogComment> BlogComments { get; set; } = new List<BlogComment>();

    public virtual Language Language { get; set; } = null!;
}
