using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CustomerCategoryChangedDate
{
    public int RecNo { get; set; }

    public string? CustomerId { get; set; }

    public string? CustomerCategory { get; set; }

    public string? Userid { get; set; }

    public DateTime? ChangedDate { get; set; }
}
