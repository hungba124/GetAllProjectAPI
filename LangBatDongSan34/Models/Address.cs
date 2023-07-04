using System;
using System.Collections.Generic;

namespace LangBatDongSan34.Models;

public partial class Address
{
    public int Id { get; set; }

    public int? CountryId { get; set; }

    public int? ProvinceId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? Company { get; set; }

    public int? DistrictId { get; set; }

    public int? CommuneId { get; set; }

    public int? StreetId { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? ZipPostalCode { get; set; }

    public string? PhoneNumber { get; set; }

    public string? FaxNumber { get; set; }

    public string? CustomAttributes { get; set; }

    public DateTime CreatedOn { get; set; }

    public virtual ICollection<Affiliate> Affiliates { get; set; } = new List<Affiliate>();

    public virtual Country? Country { get; set; }

    public virtual ICollection<Customer> CustomerBillingAddresses { get; set; } = new List<Customer>();

    public virtual ICollection<Customer> CustomerShippingAddresses { get; set; } = new List<Customer>();

    public virtual Province? Province { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}
