using System;
using System.Collections.Generic;

namespace LangBatDongSan34.Models;

public partial class Store
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Url { get; set; } = null!;

    public string? Hosts { get; set; }

    public string? CompanyName { get; set; }

    public string? CompanyAddress { get; set; }

    public string? CompanyPhoneNumber { get; set; }

    public string? CompanyVat { get; set; }

    public bool SslEnabled { get; set; }

    public int DefaultLanguageId { get; set; }

    public int DisplayOrder { get; set; }

    public virtual ICollection<ProductReview> ProductReviews { get; set; } = new List<ProductReview>();
}
