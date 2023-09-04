using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CustomerStatus
{
    public string CustomerStatusCode { get; set; } = null!;

    public string? CustomerStatusDescription { get; set; }

    public int? CustomerStatusTxtid { get; set; }

    public string? CustomerStatusFlag { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<Customer> Customers { get; } = new List<Customer>();
}
