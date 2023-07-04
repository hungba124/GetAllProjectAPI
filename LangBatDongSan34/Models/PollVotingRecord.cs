using System;
using System.Collections.Generic;

namespace LangBatDongSan34.Models;

public partial class PollVotingRecord
{
    public int Id { get; set; }

    public int PollAnswerId { get; set; }

    public int CustomerId { get; set; }

    public DateTime CreatedOn { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual PollAnswer PollAnswer { get; set; } = null!;
}
