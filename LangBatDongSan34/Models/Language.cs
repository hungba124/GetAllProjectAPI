﻿using System;
using System.Collections.Generic;

namespace LangBatDongSan34.Models;

public partial class Language
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string LanguageCulture { get; set; } = null!;

    public string? UniqueSeoCode { get; set; }

    public string? FlagImageFileName { get; set; }

    public bool Rtl { get; set; }

    public int DefaultCurrencyId { get; set; }

    public bool Published { get; set; }

    public int DisplayOrder { get; set; }

    public virtual ICollection<BlogPost> BlogPosts { get; set; } = new List<BlogPost>();

    public virtual ICollection<LocaleStringResource> LocaleStringResources { get; set; } = new List<LocaleStringResource>();

    public virtual ICollection<LocalizedProperty> LocalizedProperties { get; set; } = new List<LocalizedProperty>();

    public virtual ICollection<News> News { get; set; } = new List<News>();

    public virtual ICollection<Poll> Polls { get; set; } = new List<Poll>();
}
