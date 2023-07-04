using System;
using System.Collections.Generic;

namespace LangBatDongSan34.Models;

public partial class Investor
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Address { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public string? Website { get; set; }

    public string? LogoUrl { get; set; }

    public string? MetaKeywords { get; set; }

    public string? MetaDescription { get; set; }

    public string? MetaTitle { get; set; }

    public string? SeName { get; set; }

    public string? Description { get; set; }

    public int PictureId { get; set; }

    public bool Published { get; set; }

    public int DisplayOrder { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime UpdatedOn { get; set; }

    public bool Deleted { get; set; }

    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();
}
