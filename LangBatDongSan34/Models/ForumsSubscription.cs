﻿using System;
using System.Collections.Generic;

namespace LangBatDongSan34.Models;

public partial class ForumsSubscription
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public Guid SubscriptionGuid { get; set; }

    public int ForumId { get; set; }

    public int TopicId { get; set; }

    public DateTime CreatedOn { get; set; }

    public virtual Customer Customer { get; set; } = null!;
}
