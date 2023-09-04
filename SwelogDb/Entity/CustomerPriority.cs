using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CustomerPriority
{
    public string PriorityCode { get; set; } = null!;

    public string? PriorityDescription { get; set; }

    public int? PriorityDescriptionTxtid { get; set; }

    public string? PriorityDescriptionFlag { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<ContractOrderHeader> ContractOrderHeaders { get; } = new List<ContractOrderHeader>();

    public virtual ICollection<CustomerOrderHeader> CustomerOrderHeaders { get; } = new List<CustomerOrderHeader>();

    public virtual ICollection<Customer> Customers { get; } = new List<Customer>();
}
