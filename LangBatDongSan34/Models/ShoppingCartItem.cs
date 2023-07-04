using System;
using System.Collections.Generic;

namespace LangBatDongSan34.Models;

public partial class ShoppingCartItem
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public int ProductId { get; set; }

    public int ShoppingCartTypeId { get; set; }

    public string? AttributesXml { get; set; }

    public decimal CustomerEnteredPrice { get; set; }

    public int Quantity { get; set; }

    public DateTime? RentalStartDate { get; set; }

    public DateTime? RentalEndDate { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime UpdatedOn { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
