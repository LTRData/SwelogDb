using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EquipmentWOffAmount
{
    public string CompanyNo { get; set; } = null!;

    public string EquipmentSeries { get; set; } = null!;

    public decimal EquipmentNo { get; set; }

    public decimal YearNo { get; set; }

    public decimal? WriteOffAmount { get; set; }

    public string? AuditStamp { get; set; }

    public decimal? FinancialYear { get; set; }

    public virtual Company CompanyNoNavigation { get; set; } = null!;

    public virtual Equipment Equipment { get; set; } = null!;
}
