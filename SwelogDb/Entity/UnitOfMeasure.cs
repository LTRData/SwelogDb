using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class UnitOfMeasure
{
    public string UnitMeasureCode { get; set; } = null!;

    public string? UomDescription { get; set; }

    public int? UomDescriptionTxtid { get; set; }

    public string? UomDescriptionFlag { get; set; }

    public string? AuditStamp { get; set; }

    public decimal? UomPrecision { get; set; }

    public string? UnitType { get; set; }

    public string? Oddc25 { get; set; }

    public decimal? ScrapRounding { get; set; }

    public virtual ICollection<Account> Accounts { get; } = new List<Account>();

    public virtual ICollection<BudgetDtl> BudgetDtls { get; } = new List<BudgetDtl>();

    public virtual ICollection<ChangeCustomerArticle> ChangeCustomerArticles { get; } = new List<ChangeCustomerArticle>();

    public virtual ICollection<ChangeItem> ChangeItemPriceUnitNavigations { get; } = new List<ChangeItem>();

    public virtual ICollection<ChangeItem> ChangeItemStockingUnitNavigations { get; } = new List<ChangeItem>();

    public virtual ICollection<ChangeItem> ChangeItemVolumeUomNavigations { get; } = new List<ChangeItem>();

    public virtual ICollection<ChangeItem> ChangeItemWeightUomNavigations { get; } = new List<ChangeItem>();

    public virtual ICollection<ChangeOperationDtl> ChangeOperationDtls { get; } = new List<ChangeOperationDtl>();

    public virtual ICollection<ChangeProductStructureDtl> ChangeProductStructureDtls { get; } = new List<ChangeProductStructureDtl>();

    public virtual ICollection<ChangeProductStructureHdr> ChangeProductStructureHdrs { get; } = new List<ChangeProductStructureHdr>();

    public virtual ICollection<CrossUnitMeasure> CrossUnitMeasureUnitMeasureCodeNavigations { get; } = new List<CrossUnitMeasure>();

    public virtual ICollection<CrossUnitMeasure> CrossUnitMeasureXUnitMeasureNavigations { get; } = new List<CrossUnitMeasure>();

    public virtual ICollection<CustInvJournal> CustInvJournals { get; } = new List<CustInvJournal>();

    public virtual ICollection<CustInvPayJournal> CustInvPayJournals { get; } = new List<CustInvPayJournal>();

    public virtual ICollection<CustInvoiceDtlCodeStr> CustInvoiceDtlCodeStrs { get; } = new List<CustInvoiceDtlCodeStr>();

    public virtual ICollection<CustInvoiceDtl> CustInvoiceDtlUnitOfSaleNavigations { get; } = new List<CustInvoiceDtl>();

    public virtual ICollection<CustInvoiceDtl> CustInvoiceDtlUnitOfStockNavigations { get; } = new List<CustInvoiceDtl>();

    public virtual ICollection<CustomerArticle> CustomerArticles { get; } = new List<CustomerArticle>();

    public virtual ICollection<InspectionOperDtl> InspectionOperDtls { get; } = new List<InspectionOperDtl>();

    public virtual ICollection<ItemMarketPrice> ItemMarketPrices { get; } = new List<ItemMarketPrice>();

    public virtual ICollection<Item> ItemPriceUnitNavigations { get; } = new List<Item>();

    public virtual ICollection<Item> ItemStockingUnitNavigations { get; } = new List<Item>();

    public virtual ICollection<ItemUnitMeasure> ItemUnitMeasureAlternateUnitNavigations { get; } = new List<ItemUnitMeasure>();

    public virtual ICollection<ItemUnitMeasure> ItemUnitMeasureStockingUnitNavigations { get; } = new List<ItemUnitMeasure>();

    public virtual ICollection<Item> ItemVolumeUomNavigations { get; } = new List<Item>();

    public virtual ICollection<Item> ItemWeightUomNavigations { get; } = new List<Item>();

    public virtual ICollection<JournalDetail> JournalDetails { get; } = new List<JournalDetail>();

    public virtual ICollection<KitItemTable> KitItemTables { get; } = new List<KitItemTable>();

    public virtual ICollection<ManufacturingProgramDtl> ManufacturingProgramDtls { get; } = new List<ManufacturingProgramDtl>();

    public virtual ICollection<MaterialEstimate> MaterialEstimates { get; } = new List<MaterialEstimate>();

    public virtual ICollection<MpsJournal> MpsJournals { get; } = new List<MpsJournal>();

    public virtual ICollection<OperationDtl> OperationDtls { get; } = new List<OperationDtl>();

    public virtual ICollection<PriceListDetail> PriceListDetails { get; } = new List<PriceListDetail>();

    public virtual ICollection<ProductStructureDtl> ProductStructureDtls { get; } = new List<ProductStructureDtl>();

    public virtual ICollection<ProductStructureHdr> ProductStructureHdrs { get; } = new List<ProductStructureHdr>();

    public virtual ICollection<QtyDiscountStrucCustomer> QtyDiscountStrucCustomers { get; } = new List<QtyDiscountStrucCustomer>();

    public virtual ICollection<QtyDiscountStrucSupplier> QtyDiscountStrucSuppliers { get; } = new List<QtyDiscountStrucSupplier>();

    public virtual ICollection<Service> Services { get; } = new List<Service>();

    public virtual ICollection<SuppInvJournal> SuppInvJournals { get; } = new List<SuppInvJournal>();

    public virtual ICollection<SuppInvPayJournal> SuppInvPayJournals { get; } = new List<SuppInvPayJournal>();

    public virtual UnitType? UnitTypeNavigation { get; set; }

    public virtual ICollection<VoucherTemplateDtl> VoucherTemplateDtls { get; } = new List<VoucherTemplateDtl>();
}
