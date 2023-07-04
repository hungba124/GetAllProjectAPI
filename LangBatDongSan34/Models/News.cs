using System;
using System.Collections.Generic;

namespace LangBatDongSan34.Models;

public partial class News
{
    public int Id { get; set; }

    public int NewsTypeId { get; set; }

    public string Title { get; set; } = null!;

    public string Short { get; set; } = null!;

    public string Full { get; set; } = null!;

    public string? MetaKeywords { get; set; }

    public string? MetaDescription { get; set; }

    public string? MetaTitle { get; set; }

    public string? SeName { get; set; }

    public int PictureId { get; set; }

    public int LanguageId { get; set; }

    public bool AllowComments { get; set; }

    public bool Published { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public DateTime CreatedOn { get; set; }

    public virtual Language Language { get; set; } = null!;

    public virtual ICollection<NewsComment> NewsComments { get; set; } = new List<NewsComment>();
}
