using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MpsJournal
{
    public int RecNo { get; set; }

    public string? CompanyNo { get; set; }

    public decimal? YearNo { get; set; }

    public decimal? LineNo { get; set; }

    public string? AccountNo { get; set; }

    public string? DepartmentNo { get; set; }

    public string? ProductNo { get; set; }

    public string? ProjectNo { get; set; }

    public string? FunctionNo { get; set; }

    public string? ANo { get; set; }

    public string? BNo { get; set; }

    public string? CNo { get; set; }

    public string? DNo { get; set; }

    public string? CurrencyCode { get; set; }

    public decimal? AmountFc { get; set; }

    public decimal? AmountBc { get; set; }

    public string? UnitOfMeasure { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? ExchangeRate { get; set; }

    public string? Text { get; set; }

    public string? Transferred { get; set; }

    public decimal? TransferJnlYearNo { get; set; }

    public string? TransferJnlSeries { get; set; }

    public decimal? TransferJnlVoucherNo { get; set; }

    public string? AccountJnlSeries { get; set; }

    public decimal? AccountJnlVouchNo { get; set; }

    public string? JnlType { get; set; }

    public DateTime? EventDate { get; set; }

    public string? AuditStamp { get; set; }

    public virtual A? A { get; set; }

    public virtual B? B { get; set; }

    public virtual C? C { get; set; }

    public virtual CurrencyTable? CurrencyCodeNavigation { get; set; }

    public virtual D? D { get; set; }

    public virtual Department? Department { get; set; }

    public virtual Function? Function { get; set; }

    public virtual Product? Product { get; set; }

    public virtual Project? Project { get; set; }

    public virtual UnitOfMeasure? UnitOfMeasureNavigation { get; set; }
}
