using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Project
{
    public string CompanyNo { get; set; } = null!;

    public string ProjectNo { get; set; } = null!;

    public string? Description { get; set; }

    public string? Authoriser { get; set; }

    public decimal? Status { get; set; }

    public string? Comments { get; set; }

    public string? CustomerNo { get; set; }

    public string? InternalNo { get; set; }

    public DateTime? RegistrationDate { get; set; }

    public DateTime? ClosingDate { get; set; }

    public string? AuditStamp { get; set; }

    public string? DepartmentNo { get; set; }

    public DateTime? StartDateWOff { get; set; }

    public int? NoOfWOffPeriods { get; set; }

    public string? EquipmentSeries { get; set; }

    public decimal? EquipmentNo { get; set; }

    public string? ProjectType { get; set; }

    public int? YearlyBudget { get; set; }

    public DateTime? YearlyBudgetStartDate { get; set; }

    public int? DecidedBudget { get; set; }

    public DateTime? DecidedBudgetStartDate { get; set; }

    public int? ForecastedBudget { get; set; }

    public DateTime? ForecastedBudgetStartDate { get; set; }

    public string? MainCustomer { get; set; }

    public string? StoreLocation { get; set; }

    public string? StockPosition { get; set; }

    public string? MainCustomerItemNumbers { get; set; }

    public int? PartId { get; set; }

    public virtual ICollection<AutoVoucherDetail2> AutoVoucherDetail2s { get; } = new List<AutoVoucherDetail2>();

    public virtual ICollection<AutoVoucherDetail3> AutoVoucherDetail3s { get; } = new List<AutoVoucherDetail3>();

    public virtual ICollection<AutoVoucherHead1> AutoVoucherHead1s { get; } = new List<AutoVoucherHead1>();

    public virtual ICollection<AutoVoucherHead2> AutoVoucherHead2s { get; } = new List<AutoVoucherHead2>();

    public virtual ICollection<BudgetDtl> BudgetDtls { get; } = new List<BudgetDtl>();

    public virtual ICollection<BudgetHdr> BudgetHdrs { get; } = new List<BudgetHdr>();

    public virtual Company CompanyNoNavigation { get; set; } = null!;

    public virtual ICollection<CustInvJournal> CustInvJournals { get; } = new List<CustInvJournal>();

    public virtual ICollection<CustInvPayJournal> CustInvPayJournals { get; } = new List<CustInvPayJournal>();

    public virtual ICollection<CustInvoiceDtlCodeStr> CustInvoiceDtlCodeStrs { get; } = new List<CustInvoiceDtlCodeStr>();

    public virtual ICollection<CustInvoiceHdr> CustInvoiceHdrs { get; } = new List<CustInvoiceHdr>();

    public virtual ICollection<Equipment> Equipment { get; } = new List<Equipment>();

    public virtual ICollection<JournalDetail> JournalDetails { get; } = new List<JournalDetail>();

    public virtual ICollection<JournalOp> JournalOps { get; } = new List<JournalOp>();

    public virtual ICollection<MpsJournal> MpsJournals { get; } = new List<MpsJournal>();

    public virtual ICollection<ProjectDtl> ProjectDtls { get; } = new List<ProjectDtl>();

    public virtual ICollection<ProjectPeriodDecided> ProjectPeriodDecideds { get; } = new List<ProjectPeriodDecided>();

    public virtual ICollection<ProjectPeriodForecasted> ProjectPeriodForecasteds { get; } = new List<ProjectPeriodForecasted>();

    public virtual ICollection<ProjectPeriodInvClosed> ProjectPeriodInvCloseds { get; } = new List<ProjectPeriodInvClosed>();

    public virtual ICollection<ProjectPeriodInvOpen> ProjectPeriodInvOpens { get; } = new List<ProjectPeriodInvOpen>();

    public virtual ICollection<ProjectPeriodYearly> ProjectPeriodYearlies { get; } = new List<ProjectPeriodYearly>();

    public virtual ICollection<SuppInvJournal> SuppInvJournals { get; } = new List<SuppInvJournal>();

    public virtual ICollection<SuppInvPayJournal> SuppInvPayJournals { get; } = new List<SuppInvPayJournal>();

    public virtual ICollection<TransactionDetail> TransactionDetails { get; } = new List<TransactionDetail>();

    public virtual ICollection<VoucherTemplateDtl> VoucherTemplateDtls { get; } = new List<VoucherTemplateDtl>();
}
