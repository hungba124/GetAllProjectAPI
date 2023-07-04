using System;
using System.Collections.Generic;

namespace LangBatDongSan34.Models;

public partial class ProductWarehouseInventory
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int WarehouseId { get; set; }

    public int StockQuantity { get; set; }

    public int ReservedQuantity { get; set; }
}
