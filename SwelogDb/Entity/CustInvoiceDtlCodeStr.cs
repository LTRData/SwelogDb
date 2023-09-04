using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CustInvoiceDtlCodeStr
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public string InvoiceType { get; set; } = null!;

    public string InvoiceSeries { get; set; } = null!;

    public decimal InvoiceNo { get; set; }

    public decimal LineNo { get; set; }

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

    public decimal? TransferredJournalYearNo { get; set; }

    public string? TransferredJournalSeries { get; set; }

    public decimal? TransferredVoucherNo { get; set; }

    public DateTime? EventDate { get; set; }

    public string? AuditStamp { get; set; }

    public string? AccountJnlSeries { get; set; }

    public decimal? AccountJnlVouchNo { get; set; }

    public string? DepartmentFlag { get; set; }

    public string? ProductFlag { get; set; }

    public string? ProjectFlag { get; set; }

    public string? FunctionFlag { get; set; }

    public string? AFlag { get; set; }

    public string? BFlag { get; set; }

    public string? CFlag { get; set; }

    public string? DFlag { get; set; }

    public string? Text2 { get; set; }

    public string? VatCode { get; set; }

    public virtual A? A { get; set; }

    public virtual Account? Account { get; set; }

    public virtual B? B { get; set; }

    public virtual C? C { get; set; }

    public virtual Company CompanyNoNavigation { get; set; } = null!;

    public virtual CurrencyTable? CurrencyCodeNavigation { get; set; }

    public virtual CustInvoiceHdr CustInvoiceHdr { get; set; } = null!;

    public virtual D? D { get; set; }

    public virtual Department? Department { get; set; }

    public virtual Function? Function { get; set; }

    public virtual Product? Product { get; set; }

    public virtual Project? Project { get; set; }

    public virtual UnitOfMeasure? UnitOfMeasureNavigation { get; set; }
}
