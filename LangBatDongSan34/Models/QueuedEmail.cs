﻿using System;
using System.Collections.Generic;

namespace LangBatDongSan34.Models;

public partial class QueuedEmail
{
    public int Id { get; set; }

    public string From { get; set; } = null!;

    public string? FromName { get; set; }

    public string To { get; set; } = null!;

    public string? ToName { get; set; }

    public string? ReplyTo { get; set; }

    public string? ReplyToName { get; set; }

    public string? Cc { get; set; }

    public string? Bcc { get; set; }

    public string? Subject { get; set; }

    public int EmailAccountId { get; set; }

    public int PriorityId { get; set; }

    public string? Body { get; set; }

    public string? AttachmentFilePath { get; set; }

    public string? AttachmentFileName { get; set; }

    public int AttachedDownloadId { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? DontSendBeforeDate { get; set; }

    public int SentTries { get; set; }

    public DateTime? SentOn { get; set; }

    public virtual EmailAccount EmailAccount { get; set; } = null!;
}
