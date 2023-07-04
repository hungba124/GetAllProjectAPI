using System;
using System.Collections.Generic;

namespace LangBatDongSan34.Models;

public partial class RelatedProduct
{
    public int Id { get; set; }

    public int ProductId1 { get; set; }

    public int ProductId2 { get; set; }

    public int DisplayOrder { get; set; }
}
