using System;
using System.Collections.Generic;

namespace LangBatDongSan34.Models;

public partial class GdprLog
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public int ConsentId { get; set; }

    public string? CustomerInfo { get; set; }

    public int RequestTypeId { get; set; }

    public string? RequestDetails { get; set; }

    public DateTime CreatedOn { get; set; }
}
