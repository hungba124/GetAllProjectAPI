﻿using System;
using System.Collections.Generic;

namespace LangBatDongSan34.Models;

public partial class Log
{
    public int Id { get; set; }

    public string ShortMessage { get; set; } = null!;

    public string? IpAddress { get; set; }

    public int? CustomerId { get; set; }

    public int LogLevelId { get; set; }

    public string? FullMessage { get; set; }

    public string? PageUrl { get; set; }

    public string? ReferrerUrl { get; set; }

    public DateTime CreatedOn { get; set; }

    public virtual Customer? Customer { get; set; }
}
