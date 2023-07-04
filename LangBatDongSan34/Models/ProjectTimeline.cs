using System;
using System.Collections.Generic;

namespace LangBatDongSan34.Models;

public partial class ProjectTimeline
{
    public int Id { get; set; }

    public int ProjectId { get; set; }

    public string? Description { get; set; }

    public string? ImagesUrl { get; set; }

    public DateTime UpdatedOn { get; set; }
}
