using System;
using System.Collections.Generic;

namespace LangBatDongSan34.Models;

public partial class Poll
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int LanguageId { get; set; }

    public string? SystemKeyword { get; set; }

    public bool Published { get; set; }

    public bool ShowOnHomepage { get; set; }

    public bool AllowGuestsToVote { get; set; }

    public int DisplayOrder { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public virtual Language Language { get; set; } = null!;

    public virtual ICollection<PollAnswer> PollAnswers { get; set; } = new List<PollAnswer>();
}
