﻿using System;
using System.Collections.Generic;

namespace LangBatDongSan34.Models;

public partial class SearchTerm
{
    public int Id { get; set; }

    public string? Keyword { get; set; }

    public int StoreId { get; set; }

    public int Count { get; set; }
}
