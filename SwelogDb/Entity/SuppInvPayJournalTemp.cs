using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SuppInvPayJournalTemp
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public string InvoiceType { get; set; } = null!;

    public string ArrivalSeries { get; set; } = null!;

    public decimal ArrivalNo { get; set; }

    public decimal LineNo { get; set; }

    public decimal LineNo1 { get; set; }

    public string? BatchNo { get; set; }

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

    public string? Text { get; set; }

    public decimal? ExchangeRate { get; set; }

    public string? Transferred { get; set; }

    public decimal? TransferJnlYearNo { get; set; }

    public string? TransferJnlSeries { get; set; }

    public decimal? TransferJnlVoucherNo { get; set; }

    public string? AccountJnlSeries { get; set; }

    public decimal? AccountJnlVouchNo { get; set; }

    public DateTime? EventDate { get; set; }

    public string? AuditStamp { get; set; }

    public decimal? DebitAmount { get; set; }

    public decimal? CreditAmount { get; set; }

    public string? ValidRecord { get; set; }

    public string? ApAccFlag { get; set; }

    public decimal? RateDifferenceGain { get; set; }

    public decimal? RateDifferenceLoss { get; set; }

    public string? RateDiffFlag { get; set; }

    public string? WorkstationId { get; set; }

    public string? DepartmentFlag { get; set; }

    public string? ProductFlag { get; set; }

    public string? ProjectFlag { get; set; }

    public string? FunctionFlag { get; set; }

    public string? AFlag { get; set; }

    public string? BFlag { get; set; }

    public string? CFlag { get; set; }

    public string? DFlag { get; set; }

    public string? VatCode { get; set; }
}
