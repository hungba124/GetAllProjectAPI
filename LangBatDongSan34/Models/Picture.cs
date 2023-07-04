using System;
using System.Collections.Generic;

namespace LangBatDongSan34.Models;

public partial class Picture
{
    public int Id { get; set; }

    public string MimeType { get; set; } = null!;

    public string? SeoFilename { get; set; }

    public string? AltAttribute { get; set; }

    public string? TitleAttribute { get; set; }

    public string? VirtualPath { get; set; }

    public string? Source { get; set; }

    public bool IsNew { get; set; }

    public virtual ICollection<PictureBinary> PictureBinaries { get; set; } = new List<PictureBinary>();

    public virtual ICollection<ProductPictureMapping> ProductPictureMappings { get; set; } = new List<ProductPictureMapping>();

    public virtual ICollection<ProjectPictureMapping> ProjectPictureMappings { get; set; } = new List<ProjectPictureMapping>();
}
