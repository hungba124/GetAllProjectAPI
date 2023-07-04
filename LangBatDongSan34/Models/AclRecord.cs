using System;
using System.Collections.Generic;

namespace LangBatDongSan34.Models;

public partial class AclRecord
{
    public int Id { get; set; }

    public string EntityName { get; set; } = null!;

    public int CustomerRoleId { get; set; }

    public int EntityId { get; set; }

    public virtual CustomerRole CustomerRole { get; set; } = null!;
}
