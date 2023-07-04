using System;
using System.Collections.Generic;

namespace LangBatDongSan34.Models;

public partial class CustomerPassword
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public string? Password { get; set; }

    public int PasswordFormatId { get; set; }

    public string? PasswordSalt { get; set; }

    public DateTime CreatedOn { get; set; }

    public virtual Customer Customer { get; set; } = null!;
}
