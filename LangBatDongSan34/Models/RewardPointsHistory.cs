﻿using System;
using System.Collections.Generic;

namespace LangBatDongSan34.Models;

public partial class RewardPointsHistory
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public int StoreId { get; set; }

    public int Points { get; set; }

    public int? PointsBalance { get; set; }

    public decimal UsedAmount { get; set; }

    public string? Message { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? EndDate { get; set; }

    public int? ValidPoints { get; set; }

    public virtual Customer Customer { get; set; } = null!;
}
