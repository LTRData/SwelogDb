using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Company
{
    public string CompanyNo { get; set; } = null!;

    public string? CompanyName { get; set; }

    public int? MailingNo { get; set; }

    public int? ElectronicNo { get; set; }

    public decimal? BankgiroNo { get; set; }

    public decimal? PostgiroNo { get; set; }

    public string? VatRegNo { get; set; }

    public string? AuditStamp { get; set; }

    public string? CurrencyCode { get; set; }

    public string? DefaultCompany { get; set; }

    public decimal? NoOfDays { get; set; }

    public string? OrganisationNo { get; set; }

    public string? Site { get; set; }

    public string? BmpPathName { get; set; }

    public string? CustomerToFactor { get; set; }

    public string? SwiftAddress { get; set; }

    public string? IbanNr { get; set; }

    public string? BankCode { get; set; }

    public string? BmpPathName24bit { get; set; }

    public string? BankAccountNo { get; set; }

    public string? EdiEan { get; set; }

    public int? BbsCustomerUnitId { get; set; }

    public int? BbsAgreementId { get; set; }

    public bool? TestDatabase { get; set; }

    public string? SepaAgreementId { get; set; }

    public decimal? BmpDimensionRatio { get; set; }

    public virtual AaParameter? AaParameter { get; set; }

    public virtual ICollection<AccountText> AccountTexts { get; } = new List<AccountText>();

    public virtual ICollection<AccountTranslation> AccountTranslations { get; } = new List<AccountTranslation>();

    public virtual ICollection<AccountType> AccountTypes { get; } = new List<AccountType>();

    public virtual ICollection<Account> Accounts { get; } = new List<Account>();

    public virtual ICollection<AllocationKeyDtl> AllocationKeyDtls { get; } = new List<AllocationKeyDtl>();

    public virtual ICollection<AllocationKeyHdr> AllocationKeyHdrs { get; } = new List<AllocationKeyHdr>();

    public virtual ApParameter? ApParameter { get; set; }

    public virtual ArParameter? ArParameter { get; set; }

    public virtual ICollection<A> As { get; } = new List<A>();

    public virtual ICollection<AutoVoucherHead1> AutoVoucherHead1s { get; } = new List<AutoVoucherHead1>();

    public virtual ICollection<AutoVoucherHead2> AutoVoucherHead2s { get; } = new List<AutoVoucherHead2>();

    public virtual ICollection<AutoVoucherHead3> AutoVoucherHead3s { get; } = new List<AutoVoucherHead3>();

    public virtual ICollection<B> Bs { get; } = new List<B>();

    public virtual ICollection<BudgetDtl> BudgetDtls { get; } = new List<BudgetDtl>();

    public virtual ICollection<BudgetHdr> BudgetHdrs { get; } = new List<BudgetHdr>();

    public virtual ICollection<CostAccount> CostAccounts { get; } = new List<CostAccount>();

    public virtual ICollection<C> Cs { get; } = new List<C>();

    public virtual CurrencyTable? CurrencyCodeNavigation { get; set; }

    public virtual ICollection<CustInvoiceDtlCodeStr> CustInvoiceDtlCodeStrs { get; } = new List<CustInvoiceDtlCodeStr>();

    public virtual ICollection<CustInvoiceDtl> CustInvoiceDtls { get; } = new List<CustInvoiceDtl>();

    public virtual ICollection<CustInvoiceHdr> CustInvoiceHdrs { get; } = new List<CustInvoiceHdr>();

    public virtual ICollection<CustomerStatistic> CustomerStatistics { get; } = new List<CustomerStatistic>();

    public virtual ICollection<Department> Departments { get; } = new List<Department>();

    public virtual ICollection<D> Ds { get; } = new List<D>();

    public virtual ElectronicAddress? ElectronicNoNavigation { get; set; }

    public virtual ICollection<Equipment> Equipment { get; } = new List<Equipment>();

    public virtual ICollection<EquipmentType> EquipmentTypes { get; } = new List<EquipmentType>();

    public virtual ICollection<EquipmentWOffAmount> EquipmentWOffAmounts { get; } = new List<EquipmentWOffAmount>();

    public virtual FaParameter? FaParameter { get; set; }

    public virtual ICollection<FinancialYear> FinancialYears { get; } = new List<FinancialYear>();

    public virtual ICollection<Function> Functions { get; } = new List<Function>();

    public virtual ICollection<IntInvText> IntInvTexts { get; } = new List<IntInvText>();

    public virtual ICollection<JournalClosing> JournalClosings { get; } = new List<JournalClosing>();

    public virtual ICollection<JournalHeader> JournalHeaders { get; } = new List<JournalHeader>();

    public virtual ICollection<JournalOp> JournalOps { get; } = new List<JournalOp>();

    public virtual ICollection<LiquidityDtlDtl> LiquidityDtlDtls { get; } = new List<LiquidityDtlDtl>();

    public virtual ICollection<LiquidityDtl> LiquidityDtls { get; } = new List<LiquidityDtl>();

    public virtual ICollection<LiquidityHdr> LiquidityHdrs { get; } = new List<LiquidityHdr>();

    public virtual MailingAddress? MailingNoNavigation { get; set; }

    public virtual ICollection<Product> Products { get; } = new List<Product>();

    public virtual ICollection<Project> Projects { get; } = new List<Project>();

    public virtual ICollection<Report> Reports { get; } = new List<Report>();

    public virtual ICollection<SuppInvPayBatch> SuppInvPayBatches { get; } = new List<SuppInvPayBatch>();

    public virtual ICollection<SupplierStatistic> SupplierStatistics { get; } = new List<SupplierStatistic>();

    public virtual SystemParameter? SystemParameter { get; set; }

    public virtual ICollection<VatReport2> VatReport2s { get; } = new List<VatReport2>();

    public virtual ICollection<VatReport3> VatReport3s { get; } = new List<VatReport3>();

    public virtual ICollection<VatReport5> VatReport5s { get; } = new List<VatReport5>();

    public virtual ICollection<VatReportResult2> VatReportResult2s { get; } = new List<VatReportResult2>();

    public virtual ICollection<VatReportResult3> VatReportResult3s { get; } = new List<VatReportResult3>();

    public virtual ICollection<VatReportResult5> VatReportResult5s { get; } = new List<VatReportResult5>();

    public virtual ICollection<VatReport> VatReports { get; } = new List<VatReport>();

    public virtual ICollection<VoucherTemplateHead> VoucherTemplateHeads { get; } = new List<VoucherTemplateHead>();
}
