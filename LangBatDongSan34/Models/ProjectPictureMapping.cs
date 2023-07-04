using System;
using System.Collections.Generic;

namespace LangBatDongSan34.Models;

public partial class ProjectPictureMapping
{
    public int Id { get; set; }

    public int PictureId { get; set; }

    public int ProjectId { get; set; }

    public int DisplayOrder { get; set; }

    public virtual Picture Picture { get; set; } = null!;

    public virtual Project Project { get; set; } = null!;
}
