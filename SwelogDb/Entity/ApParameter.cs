using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ApParameter
{
    public string CompanyNo { get; set; } = null!;

    public string? ArrivalSeries { get; set; }

    public string? InvJournalSeries { get; set; }

    public string? PayJournalSeries { get; set; }

    public string? RevaluationSeries { get; set; }

    public string? BatchSeries { get; set; }

    public string? PayBatchSeries { get; set; }

    public string? AdvPaySeries { get; set; }

    public string? BankGiroCustNo { get; set; }

    public string? PostGiroCustNo { get; set; }

    public decimal? CurrentPeriodNo { get; set; }

    public decimal? CurrentYearNo { get; set; }

    public string? ArrivalNoOrNameToText { get; set; }

    public string? UsePrelCoding { get; set; }

    public string? UpdteLedgWithSuppInvJnl { get; set; }

    public string? AuditStamp { get; set; }

    public string? CreditInvSeries { get; set; }

    public string? PayOn { get; set; }

    public decimal? NoOfGuardDays { get; set; }

    public string? IntInvSeries { get; set; }

    public string? InvoiceRateAsPayRate { get; set; }

    public string? BankPostGiroDirPath { get; set; }

    public string? CreateAv { get; set; }

    public string? AuthorisedDefCoded { get; set; }

    public string? AuthorisedPrelCoded { get; set; }

    public string? AuthorisedForDefCoded { get; set; }

    public string? XmlInvSeries { get; set; }

    public string? CreateInvLineInProject { get; set; }

    public string? ShowArrivalNoInJournal { get; set; }

    public string? ShowLastSavedVchDateInSuppInv { get; set; }

    public string? ShowAllGoodsEntriesInSuppInv { get; set; }

    public string? BankAccountNoMod1011 { get; set; }

    public string? BankPostGiroCheck { get; set; }

    public string? SeparateAccForAlloySurcharge { get; set; }

    public string? TransSeries { get; set; }

    public string? TransJnlSeries { get; set; }

    public string? SepaPath { get; set; }

    public string? FinalAttestWithoutCodeStr { get; set; }

    public string? InvoiceDateAsVoucherDate { get; set; }

    public string? FileType { get; set; }

    public string? UnmarkAllAsDefaultInPrelPay { get; set; }

    public virtual Company CompanyNoNavigation { get; set; } = null!;
}
