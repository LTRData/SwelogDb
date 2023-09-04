using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TransactionHeader
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public string TransSeries { get; set; } = null!;

    public decimal TransNo { get; set; }

    public string? WriteOffCode { get; set; }

    public string? EquipmentSeries { get; set; }

    public decimal? EquipmentNo { get; set; }

    public DateTime? TransDate { get; set; }

    public string? Transferred { get; set; }

    public string? Active { get; set; }

    public DateTime? WOffDate { get; set; }

    public string? AuditStamp { get; set; }

    public virtual Equipment? Equipment { get; set; }

    public virtual ICollection<TransactionDetail> TransactionDetails { get; } = new List<TransactionDetail>();
}
