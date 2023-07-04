using System;
using System.Collections.Generic;

namespace LangBatDongSan34.Models;

public partial class Broker
{
    public int Id { get; set; }

    public string? FullName { get; set; }

    public string? MobilePhone { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public string? WebSite { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Description { get; set; }

    public bool IsPersonal { get; set; }

    public int? CustomerId { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime UpdatedOn { get; set; }
}
