using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class FaParameter
{
    public string CompanyNo { get; set; } = null!;

    public decimal? CurrentFinancialYear { get; set; }

    public string? JournalSeries { get; set; }

    public string? AutoVouchSeries { get; set; }

    public string? AutoVouch3Series { get; set; }

    public string? TemplateSeries { get; set; }

    public string? BatchSeries { get; set; }

    public string? BatchJournalSeries { get; set; }

    public string? ClosingEntryJnlSeries { get; set; }

    public decimal? CurrentPeriodNo { get; set; }

    public string? Av3Generate { get; set; }

    public string ProfitLossAcc { get; set; } = null!;

    public string BalanceSheetAcc { get; set; } = null!;

    public string BalancedProfitLossAcc { get; set; } = null!;

    public string? AuditStamp { get; set; }

    public string? ApJournalSeries { get; set; }

    public string? ArJournalSeries { get; set; }

    public string? AaJournalSeries { get; set; }

    public string? MpsJournalSeries { get; set; }

    public string? OnlyAccWithBalInLedger { get; set; }

    public string? VouchersOnlyInLedger { get; set; }

    public string? BatchTransferJournalSeries { get; set; }

    public string VatAccForVoucher { get; set; } = null!;

    public string? PrintSelection { get; set; }

    public string? SieDirPath { get; set; }

    public string? NoRoundingInVatReport { get; set; }

    public string? PrintOnlyJournals { get; set; }

    public string? PrintJournalWhenTransferring { get; set; }

    public virtual FinancialYear? C { get; set; }

    public virtual Company CompanyNoNavigation { get; set; } = null!;
}
