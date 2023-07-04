using System;
using System.Collections.Generic;

namespace LangBatDongSan34.Models;

public partial class Campaign
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Subject { get; set; } = null!;

    public string Body { get; set; } = null!;

    public int StoreId { get; set; }

    public int CustomerRoleId { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? DontSendBeforeDate { get; set; }
}
