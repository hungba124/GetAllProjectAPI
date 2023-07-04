using System;
using System.Collections.Generic;

namespace LangBatDongSan34.Models;

public partial class Commune
{
    public int Id { get; set; }

    public int DistrictId { get; set; }

    public string Name { get; set; } = null!;

    public string? SeName { get; set; }

    public string? Abbreviation { get; set; }

    public string? Location { get; set; }

    public string? GoogleMaps { get; set; }

    public int CommuneTypeId { get; set; }

    public bool Published { get; set; }

    public int DisplayOrder { get; set; }

    public virtual District District { get; set; } = null!;
}
