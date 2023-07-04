using System;
using System.Collections.Generic;

namespace LangBatDongSan34.Models;

public partial class ScheduleTask
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Type { get; set; } = null!;

    public int Seconds { get; set; }

    public bool Enabled { get; set; }

    public bool StopOnError { get; set; }

    public DateTime? LastStart { get; set; }

    public DateTime? LastEnd { get; set; }

    public DateTime? LastSuccess { get; set; }
}
