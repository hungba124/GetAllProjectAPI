using System;
using System.Collections.Generic;

namespace LangBatDongSan34.Models;

public partial class Manufacturer
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? MetaKeywords { get; set; }

    public string? MetaTitle { get; set; }

    public string? PriceRanges { get; set; }

    public string? PageSizeOptions { get; set; }

    public string? Description { get; set; }

    public int ManufacturerTemplateId { get; set; }

    public string? MetaDescription { get; set; }

    public int PictureId { get; set; }

    public int PageSize { get; set; }

    public bool AllowCustomersToSelectPageSize { get; set; }

    public bool SubjectToAcl { get; set; }

    public bool Published { get; set; }

    public bool Deleted { get; set; }

    public int DisplayOrder { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime UpdatedOn { get; set; }

    public virtual ICollection<ProductManufacturerMapping> ProductManufacturerMappings { get; set; } = new List<ProductManufacturerMapping>();
}
