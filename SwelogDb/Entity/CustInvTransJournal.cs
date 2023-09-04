using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CustInvTransJournal
{
    public string CompanyNo { get; set; } = null!;

    public decimal? YearNo { get; set; }

    public string TransType { get; set; } = null!;

    public string TransSeries { get; set; } = null!;

    public decimal TransNo { get; set; }

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

    public string? UnitOfMeasure { get; set; }

    public decimal? Quantity { get; set; }

    public string? Text { get; set; }

    public string? CurrencyCode { get; set; }

    public decimal? ExchangeRate { get; set; }

    public decimal? AmountFc { get; set; }

    public decimal? AmountBc { get; set; }

    public DateTime? EventDate { get; set; }

    public string? Text2 { get; set; }

    public string? Transferred { get; set; }

    public decimal? TransferJnlYearNo { get; set; }

    public string? TransferJnlSeries { get; set; }

    public decimal? TransferJnlVoucherNo { get; set; }

    public string? AccountJnlSeries { get; set; }

    public decimal? AccountJnlVouchNo { get; set; }

    public string? AuditStamp { get; set; }

    public string? VatCode { get; set; }

    public virtual CustInvTransHdr CustInvTransHdr { get; set; } = null!;
}
