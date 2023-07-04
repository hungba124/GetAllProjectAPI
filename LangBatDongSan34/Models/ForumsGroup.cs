using System;
using System.Collections.Generic;

namespace LangBatDongSan34.Models;

public partial class ForumsGroup
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int DisplayOrder { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime UpdatedOn { get; set; }

    public virtual ICollection<ForumsForum> ForumsForums { get; set; } = new List<ForumsForum>();
}
