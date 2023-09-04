using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class FinancialYear
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public decimal NoOfPeriods { get; set; }

    public string? AuditStamp { get; set; }

    public string? YearClosed { get; set; }

    public string? PrelYearClosing { get; set; }

    public virtual ICollection<AaParameter> AaParameters { get; } = new List<AaParameter>();

    public virtual ICollection<AccountTranslation> AccountTranslationFinancialYearNavigations { get; } = new List<AccountTranslation>();

    public virtual ICollection<AccountTranslation> AccountTranslationFinancialYears { get; } = new List<AccountTranslation>();

    public virtual ICollection<Account> Accounts { get; } = new List<Account>();

    public virtual ICollection<AutoVoucherHead1> AutoVoucherHead1s { get; } = new List<AutoVoucherHead1>();

    public virtual ICollection<AutoVoucherHead2> AutoVoucherHead2s { get; } = new List<AutoVoucherHead2>();

    public virtual ICollection<BudgetHdr> BudgetHdrs { get; } = new List<BudgetHdr>();

    public virtual Company CompanyNoNavigation { get; set; } = null!;

    public virtual ICollection<CostAccount> CostAccounts { get; } = new List<CostAccount>();

    public virtual ICollection<CustomerStatistic> CustomerStatistics { get; } = new List<CustomerStatistic>();

    public virtual ICollection<FaParameter> FaParameters { get; } = new List<FaParameter>();

    public virtual ICollection<FinancialPeriod> FinancialPeriods { get; } = new List<FinancialPeriod>();

    public virtual ICollection<JournalClosing> JournalClosings { get; } = new List<JournalClosing>();

    public virtual ICollection<JournalHeader> JournalHeaders { get; } = new List<JournalHeader>();

    public virtual ICollection<JournalOp> JournalOps { get; } = new List<JournalOp>();

    public virtual ICollection<LiquidityDtlDtl> LiquidityDtlDtls { get; } = new List<LiquidityDtlDtl>();

    public virtual ICollection<LiquidityDtl> LiquidityDtls { get; } = new List<LiquidityDtl>();

    public virtual ICollection<LiquidityHdr> LiquidityHdrs { get; } = new List<LiquidityHdr>();

    public virtual ICollection<SupplierStatistic> SupplierStatistics { get; } = new List<SupplierStatistic>();

    public virtual ICollection<VoucherTemplateHead> VoucherTemplateHeads { get; } = new List<VoucherTemplateHead>();
}
