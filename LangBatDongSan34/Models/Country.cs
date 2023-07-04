using System;
using System.Collections.Generic;

namespace LangBatDongSan34.Models;

public partial class Country
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? TwoLetterIsoCode { get; set; }

    public string? ThreeLetterIsoCode { get; set; }

    public int NumericIsoCode { get; set; }

    public bool Published { get; set; }

    public int DisplayOrder { get; set; }

    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();

    public virtual ICollection<Province> Provinces { get; set; } = new List<Province>();
}
