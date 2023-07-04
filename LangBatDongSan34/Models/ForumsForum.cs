using System;
using System.Collections.Generic;

namespace LangBatDongSan34.Models;

public partial class ForumsForum
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int ForumGroupId { get; set; }

    public string? Description { get; set; }

    public int NumTopics { get; set; }

    public int NumPosts { get; set; }

    public int LastTopicId { get; set; }

    public int LastPostId { get; set; }

    public int LastPostCustomerId { get; set; }

    public DateTime? LastPostTime { get; set; }

    public int DisplayOrder { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime UpdatedOn { get; set; }

    public virtual ForumsGroup ForumGroup { get; set; } = null!;

    public virtual ICollection<ForumsTopic> ForumsTopics { get; set; } = new List<ForumsTopic>();
}
