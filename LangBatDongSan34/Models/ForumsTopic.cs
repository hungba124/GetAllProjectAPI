using System;
using System.Collections.Generic;

namespace LangBatDongSan34.Models;

public partial class ForumsTopic
{
    public int Id { get; set; }

    public string Subject { get; set; } = null!;

    public int CustomerId { get; set; }

    public int ForumId { get; set; }

    public int TopicTypeId { get; set; }

    public int NumPosts { get; set; }

    public int Views { get; set; }

    public int LastPostId { get; set; }

    public int LastPostCustomerId { get; set; }

    public DateTime? LastPostTime { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime UpdatedOn { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual ForumsForum Forum { get; set; } = null!;

    public virtual ICollection<ForumsPost> ForumsPosts { get; set; } = new List<ForumsPost>();
}
