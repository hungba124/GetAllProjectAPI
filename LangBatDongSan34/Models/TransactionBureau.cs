using System;
using System.Collections.Generic;

namespace LangBatDongSan34.Models;

public partial class TransactionBureau
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? MetaKeywords { get; set; }

    public string? MetaTitle { get; set; }

    public string SeName { get; set; } = null!;

    public string? Abbreviation { get; set; }

    public string? Address { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public int BranchId { get; set; }

    public string? MetaDescription { get; set; }

    public string? Description { get; set; }

    public int? ProvinceId { get; set; }

    public int? DistrictId { get; set; }

    public int? CommuneId { get; set; }

    public bool Published { get; set; }

    public int DisplayOrder { get; set; }
}
