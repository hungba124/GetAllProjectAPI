using System;
using System.Collections.Generic;

namespace LangBatDongSan34.Models;

public partial class ProjectType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? SeName { get; set; }

    public string? MetaKeywords { get; set; }

    public string? MetaTitle { get; set; }

    public string? Description { get; set; }

    public string? MetaDescription { get; set; }

    public int PictureId { get; set; }

    public int PageSize { get; set; }

    public bool AllowCustomersToSelectPageSize { get; set; }

    public string? PageSizeOptions { get; set; }

    public string? PriceRanges { get; set; }

    public bool ShowOnHomePage { get; set; }

    public int MaxPageDownload { get; set; }

    public int NumberOfViews { get; set; }

    public int PostFb { get; set; }

    public bool Published { get; set; }

    public int DisplayOrder { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime UpdatedOn { get; set; }

    public bool Deleted { get; set; }

    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();
}
