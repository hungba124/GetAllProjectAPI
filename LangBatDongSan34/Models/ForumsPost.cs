using System;
using System.Collections.Generic;

namespace LangBatDongSan34.Models;

public partial class ForumsPost
{
    public int Id { get; set; }

    public string Text { get; set; } = null!;

    public string? Ipaddress { get; set; }

    public int CustomerId { get; set; }

    public int TopicId { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime UpdatedOn { get; set; }

    public int VoteCount { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<ForumsPostVote> ForumsPostVotes { get; set; } = new List<ForumsPostVote>();

    public virtual ForumsTopic Topic { get; set; } = null!;
}
