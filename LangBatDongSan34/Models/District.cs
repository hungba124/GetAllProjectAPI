using System;
using System.Collections.Generic;

namespace LangBatDongSan34.Models;

public partial class District
{
    public int Id { get; set; }

    public int ProvinceId { get; set; }

    public string Name { get; set; } = null!;

    public string? SeName { get; set; }

    public string? Abbreviation { get; set; }

    public string? Location { get; set; }

    public string? GoogleMaps { get; set; }

    public int DistrictTypeId { get; set; }

    public bool Published { get; set; }

    public int DisplayOrder { get; set; }

    public virtual ICollection<Commune> Communes { get; set; } = new List<Commune>();

    public virtual Province Province { get; set; } = null!;

    public virtual ICollection<Street> Streets { get; set; } = new List<Street>();
}
