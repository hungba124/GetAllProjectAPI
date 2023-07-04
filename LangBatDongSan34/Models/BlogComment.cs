using System;
using System.Collections.Generic;

namespace LangBatDongSan34.Models;

public partial class BlogComment
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public int BlogPostId { get; set; }

    public string? CommentText { get; set; }

    public bool IsApproved { get; set; }

    public DateTime CreatedOn { get; set; }

    public virtual BlogPost BlogPost { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;
}
