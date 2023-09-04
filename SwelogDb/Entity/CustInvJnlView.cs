using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CustInvJnlView
{
    public string CompanyNo { get; set; } = null!;

    public string InvoiceType { get; set; } = null!;

    public string InvoiceSeries { get; set; } = null!;

    public decimal InvoiceNo { get; set; }

    public decimal LineNo { get; set; }

    public decimal? LineNo1 { get; set; }

    public decimal? YearNo { get; set; }

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

    public decimal? DebitAmount { get; set; }

    public decimal? CreditAmount { get; set; }

    public decimal? AmountFc { get; set; }

    public string? Text { get; set; }

    public string? Transferred { get; set; }

    public string? UnitOfMeasure { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? ExchangeRate { get; set; }

    public decimal? TransferJnlYearNo { get; set; }

    public string? TransferJnlSeries { get; set; }

    public decimal? TransferJnlVoucherNo { get; set; }

    public string? AccountJnlSeries { get; set; }

    public decimal? AccountJnlVouchNo { get; set; }

    public string? JnlType { get; set; }

    public DateTime? EventDate { get; set; }
}
