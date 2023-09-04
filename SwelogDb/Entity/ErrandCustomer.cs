using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ErrandCustomer
{
    public int IdErrand { get; set; }

    public string CustomerId { get; set; } = null!;
}
