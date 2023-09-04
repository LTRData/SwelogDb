using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EuLabour
{
    public string EuLabourCode { get; set; } = null!;

    public string? EuLabourDescription { get; set; }

    public int? EuLabourDescriptionTxtid { get; set; }

    public string? EuLabourDescriptionFlag { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<ContractOrderHeader> ContractOrderHeaders { get; } = new List<ContractOrderHeader>();

    public virtual ICollection<CustomerOrderHeader> CustomerOrderHeaders { get; } = new List<CustomerOrderHeader>();
}
