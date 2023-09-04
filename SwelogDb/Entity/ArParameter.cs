using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ArParameter
{
    public string CompanyNo { get; set; } = null!;

    public string? InvNoSeries { get; set; }

    public string? IntInvNoSeries { get; set; }

    public string? CreditInvNoSeries { get; set; }

    public string? InvJnlSeries { get; set; }

    public string? InvPayJnlSeries { get; set; }

    public string? AdvPaySeries { get; set; }

    public string? RepaySeries { get; set; }

    public string? RevaluationSeries { get; set; }

    public string? BatchSeries { get; set; }

    public decimal? CurrentPeriodNo { get; set; }

    public decimal? CurrentYearNo { get; set; }

    public decimal? DelayIntPercent { get; set; }

    public string? UpdteLedgWithCustInvJnl { get; set; }

    public string? InvNoOrNameToText { get; set; }

    public double? MinIntAmt { get; set; }

    public double? AdmnFee { get; set; }

    public string? ShowCrInvInIntInv { get; set; }

    public string? AdmnChargeForIntInv { get; set; }

    public string? RoundOffIntInv { get; set; }

    public decimal? DiscountDays { get; set; }

    public string? AuditStamp { get; set; }

    public decimal? InvoicingCharge { get; set; }

    public decimal? InvoicingChargeLimit { get; set; }

    public string? AcontoAmountCode { get; set; }

    public string? AcontoInvNoSeries { get; set; }

    public string? AdmnChargeAccCode { get; set; }

    public string? InternalInvSeries { get; set; }

    public string? IntInvJnlSeries { get; set; }

    public decimal? RoundingAmtForFullyPaid { get; set; }

    public string? TomokuFilePath { get; set; }

    public decimal? MinIntAmtInv { get; set; }

    public string? DeptForInvoice { get; set; }

    public string? ChangePriceInOrder { get; set; }

    public string? CreateIntInvFor { get; set; }

    public string? CreateAv { get; set; }

    public string? CreditPeriodAmtFlag { get; set; }

    public string? IncludeServiceLinesInKvr { get; set; }

    public string? PerformaInvNoSeries { get; set; }

    public string? AdvanceInvNoSeries { get; set; }

    public string? AdvancePayAccountCode { get; set; }

    public decimal? AdmnFeeIntInv { get; set; }

    public string? ShowInvNoInJournal { get; set; }

    public string? ProtectArAccNo { get; set; }

    public string? IncludeServiceLinesInIntrastat { get; set; }

    public string? SetupCostCode { get; set; }

    public string? OcrNoMod1011 { get; set; }

    public short? NoOfDigitsForOcrNo { get; set; }

    public string? DefaultServiceCode { get; set; }

    public decimal? AdmnChargeForReminder { get; set; }

    public decimal? AdmnChargeForDebtCollector { get; set; }

    public string? TransSeries { get; set; }

    public string? TransJnlSeries { get; set; }

    public string? CreateInvLineInProject { get; set; }

    public decimal? RotWithdrawLimit { get; set; }

    public decimal? RotWithdrawPercent { get; set; }

    public string? DoNotShowPreviewForInv { get; set; }

    public string? ShowExtraDesc { get; set; }

    public virtual Company CompanyNoNavigation { get; set; } = null!;
}
