using System;
using System.Collections.Generic;

namespace LangBatDongSan34.Models;

public partial class VendorNote
{
    public int Id { get; set; }

    public string Note { get; set; } = null!;

    public int VendorId { get; set; }

    public DateTime CreatedOn { get; set; }

    public virtual Vendor Vendor { get; set; } = null!;
}
