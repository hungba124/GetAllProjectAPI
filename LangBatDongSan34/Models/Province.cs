using System;
using System.Collections.Generic;

namespace LangBatDongSan34.Models;

public partial class Province
{
    public int Id { get; set; }

    public int CountryId { get; set; }

    public string Name { get; set; } = null!;

    public string? SeName { get; set; }

    public string? Abbreviation { get; set; }

    public string? Location { get; set; }

    public string? GoogleMaps { get; set; }

    public int ProvinceTypeId { get; set; }

    public bool Published { get; set; }

    public int DisplayOrder { get; set; }

    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();

    public virtual Country Country { get; set; } = null!;

    public virtual ICollection<District> Districts { get; set; } = new List<District>();

    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();
}
