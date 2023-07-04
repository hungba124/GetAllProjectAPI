using System;
using System.Collections.Generic;

namespace LangBatDongSan34.Models;

public partial class NewsLetterSubscription
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public Guid NewsLetterSubscriptionGuid { get; set; }

    public bool Active { get; set; }

    public DateTime CreatedOn { get; set; }
}
