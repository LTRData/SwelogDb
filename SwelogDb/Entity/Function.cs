using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Function
{
    public string CompanyNo { get; set; } = null!;

    public string FunctionNo { get; set; } = null!;

    public string? Description { get; set; }

    public string? AuditStamp { get; set; }

    public string? Group1 { get; set; }

    public string? Active { get; set; }

    public virtual ICollection<AutoVoucherDetail2> AutoVoucherDetail2s { get; } = new List<AutoVoucherDetail2>();

    public virtual ICollection<AutoVoucherDetail3> AutoVoucherDetail3s { get; } = new List<AutoVoucherDetail3>();

    public virtual ICollection<AutoVoucherHead1> AutoVoucherHead1s { get; } = new List<AutoVoucherHead1>();

    public virtual ICollection<AutoVoucherHead2> AutoVoucherHead2s { get; } = new List<AutoVoucherHead2>();

    public virtual ICollection<BudgetDtl> BudgetDtls { get; } = new List<BudgetDtl>();

    public virtual Company CompanyNoNavigation { get; set; } = null!;

    public virtual ICollection<CustInvJournal> CustInvJournals { get; } = new List<CustInvJournal>();

    public virtual ICollection<CustInvPayJournal> CustInvPayJournals { get; } = new List<CustInvPayJournal>();

    public virtual ICollection<CustInvoiceDtlCodeStr> CustInvoiceDtlCodeStrs { get; } = new List<CustInvoiceDtlCodeStr>();

    public virtual ICollection<Equipment> Equipment { get; } = new List<Equipment>();

    public virtual ICollection<FunctionGroup> FunctionGroups { get; } = new List<FunctionGroup>();

    public virtual ICollection<JournalDetail> JournalDetails { get; } = new List<JournalDetail>();

    public virtual ICollection<JournalOp> JournalOps { get; } = new List<JournalOp>();

    public virtual ICollection<MpsJournal> MpsJournals { get; } = new List<MpsJournal>();

    public virtual ICollection<SuppInvJournal> SuppInvJournals { get; } = new List<SuppInvJournal>();

    public virtual ICollection<SuppInvPayJournal> SuppInvPayJournals { get; } = new List<SuppInvPayJournal>();

    public virtual ICollection<TransactionDetail> TransactionDetails { get; } = new List<TransactionDetail>();

    public virtual ICollection<VoucherTemplateDtl> VoucherTemplateDtls { get; } = new List<VoucherTemplateDtl>();
}
