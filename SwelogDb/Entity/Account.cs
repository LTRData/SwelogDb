using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Account
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public string AccountNo { get; set; } = null!;

    public string? AccountTypeNo { get; set; }

    public string? Description { get; set; }

    public string? DepartmentAccounting { get; set; }

    public string? ProductAccounting { get; set; }

    public string? ProjectAccounting { get; set; }

    public string? FunctionAccounting { get; set; }

    public string? AAccounting { get; set; }

    public string? BAccounting { get; set; }

    public string? CAccounting { get; set; }

    public string? DAccounting { get; set; }

    public string? AccountLocked { get; set; }

    public string? NormalSign { get; set; }

    public string? QuantityAccounting { get; set; }

    public string? UnitOfMeasure { get; set; }

    public string? FacilityAccounting { get; set; }

    public string? SruCode { get; set; }

    public string? AlternateSruCode { get; set; }

    public string? AuditStamp { get; set; }

    public string? DepartmentAccountingM { get; set; }

    public string? ProductAccountingM { get; set; }

    public string? ProjectAccountingM { get; set; }

    public string? FunctionAccountingM { get; set; }

    public string? AAccountingM { get; set; }

    public string? BAccountingM { get; set; }

    public string? CAccountingM { get; set; }

    public string? DAccountingM { get; set; }

    public string? CostAccount { get; set; }

    public string? PrintFlag { get; set; }

    public string? VatCode { get; set; }

    public string? ProtectAccNo { get; set; }

    public string? NotArAccNo { get; set; }

    public string? DoNotShowInResultanalys { get; set; }

    public string? AccountNo2 { get; set; }

    public string? AccountTypeNo2 { get; set; }

    public string? CannotEdit { get; set; }

    public string? BelongsToAccountNo { get; set; }

    public virtual AccountTranslation? AccountTranslation { get; set; }

    public virtual AccountType? AccountType { get; set; }

    public virtual ICollection<AutoVoucherDetail1> AutoVoucherDetail1s { get; } = new List<AutoVoucherDetail1>();

    public virtual ICollection<AutoVoucherHead1> AutoVoucherHead1s { get; } = new List<AutoVoucherHead1>();

    public virtual ICollection<AutoVoucherHead2> AutoVoucherHead2s { get; } = new List<AutoVoucherHead2>();

    public virtual ICollection<BudgetDtl> BudgetDtls { get; } = new List<BudgetDtl>();

    public virtual Company CompanyNoNavigation { get; set; } = null!;

    public virtual CostAccount? CostAccountNavigation { get; set; }

    public virtual ICollection<CustInvJournal> CustInvJournals { get; } = new List<CustInvJournal>();

    public virtual ICollection<CustInvPayJournal> CustInvPayJournals { get; } = new List<CustInvPayJournal>();

    public virtual ICollection<CustInvoiceDtlCodeStr> CustInvoiceDtlCodeStrs { get; } = new List<CustInvoiceDtlCodeStr>();

    public virtual FinancialYear FinancialYear { get; set; } = null!;

    public virtual ICollection<JournalClosing> JournalClosings { get; } = new List<JournalClosing>();

    public virtual ICollection<JournalDetail> JournalDetails { get; } = new List<JournalDetail>();

    public virtual ICollection<JournalOp> JournalOps { get; } = new List<JournalOp>();

    public virtual ICollection<SuppInvPayJournal> SuppInvPayJournals { get; } = new List<SuppInvPayJournal>();

    public virtual ICollection<TransactionDetail> TransactionDetails { get; } = new List<TransactionDetail>();

    public virtual UnitOfMeasure? UnitOfMeasureNavigation { get; set; }

    public virtual ICollection<VoucherTemplateDtl> VoucherTemplateDtls { get; } = new List<VoucherTemplateDtl>();
}
