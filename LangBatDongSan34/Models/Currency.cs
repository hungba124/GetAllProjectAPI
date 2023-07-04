using System;
using System.Collections.Generic;

namespace LangBatDongSan34.Models;

public partial class Currency
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string CurrencyCode { get; set; } = null!;

    public string? DisplayLocale { get; set; }

    public string? CustomFormatting { get; set; }

    public decimal Rate { get; set; }

    public bool Published { get; set; }

    public int DisplayOrder { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime UpdatedOn { get; set; }

    public int RoundingTypeId { get; set; }
}
