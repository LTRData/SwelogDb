using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CurrencyTable
{
    public string CurrencyCode { get; set; } = null!;

    public string? CurrencyName { get; set; }

    public decimal? CurrencyUnits { get; set; }

    public string? CurrencyBase { get; set; }

    public DateTime? DateOfRate { get; set; }

    public decimal? CurrentExchangeRate { get; set; }

    public decimal? StandardExchangeRate { get; set; }

    public decimal? CurrencyPrecision { get; set; }

    public string? AuditStamp { get; set; }

    public decimal? BuyingRate { get; set; }

    public decimal? SellingRate { get; set; }

    public decimal? BudgetRate { get; set; }

    public decimal? AverageRate { get; set; }

    public byte? AverageRateMonths { get; set; }

    public decimal? CalculationRate { get; set; }

    public virtual ICollection<BudgetDtl> BudgetDtls { get; } = new List<BudgetDtl>();

    public virtual ICollection<Company> Companies { get; } = new List<Company>();

    public virtual ICollection<ContractOrderHeader> ContractOrderHeaders { get; } = new List<ContractOrderHeader>();

    public virtual ICollection<Country> Countries { get; } = new List<Country>();

    public virtual ICollection<CrossCurrency> CrossCurrencyCurrencyCodeNavigations { get; } = new List<CrossCurrency>();

    public virtual ICollection<CrossCurrency> CrossCurrencyXCurrencyCodeNavigations { get; } = new List<CrossCurrency>();

    public virtual ICollection<CustInvHdr> CustInvHdrs { get; } = new List<CustInvHdr>();

    public virtual ICollection<CustInvJournal> CustInvJournals { get; } = new List<CustInvJournal>();

    public virtual ICollection<CustInvPayJournal> CustInvPayJournals { get; } = new List<CustInvPayJournal>();

    public virtual ICollection<CustInvPay> CustInvPays { get; } = new List<CustInvPay>();

    public virtual ICollection<CustInvoiceDtlCodeStr> CustInvoiceDtlCodeStrs { get; } = new List<CustInvoiceDtlCodeStr>();

    public virtual ICollection<CustInvoiceDtl> CustInvoiceDtls { get; } = new List<CustInvoiceDtl>();

    public virtual ICollection<CustInvoiceHdr> CustInvoiceHdrs { get; } = new List<CustInvoiceHdr>();

    public virtual ICollection<CustomerOrderHeader> CustomerOrderHeaders { get; } = new List<CustomerOrderHeader>();

    public virtual ICollection<Customer> Customers { get; } = new List<Customer>();

    public virtual ICollection<ItemMarketPrice> ItemMarketPrices { get; } = new List<ItemMarketPrice>();

    public virtual ICollection<JournalDetail> JournalDetails { get; } = new List<JournalDetail>();

    public virtual ICollection<MpsJournal> MpsJournals { get; } = new List<MpsJournal>();

    public virtual ICollection<OrderTotalDiscountHdr> OrderTotalDiscountHdrs { get; } = new List<OrderTotalDiscountHdr>();

    public virtual ICollection<PaymentMode> PaymentModes { get; } = new List<PaymentMode>();

    public virtual ICollection<PriceListHdr> PriceListHdrs { get; } = new List<PriceListHdr>();

    public virtual ICollection<RoundingHdr> RoundingHdrs { get; } = new List<RoundingHdr>();

    public virtual ICollection<ServiceCharge> ServiceCharges { get; } = new List<ServiceCharge>();

    public virtual ICollection<SuppInvHdrDummyFa> SuppInvHdrDummyFas { get; } = new List<SuppInvHdrDummyFa>();

    public virtual ICollection<SuppInvHdr> SuppInvHdrs { get; } = new List<SuppInvHdr>();

    public virtual ICollection<SuppInvJournal> SuppInvJournals { get; } = new List<SuppInvJournal>();

    public virtual ICollection<SuppInvPayJournal> SuppInvPayJournals { get; } = new List<SuppInvPayJournal>();

    public virtual ICollection<SuppInvPay> SuppInvPays { get; } = new List<SuppInvPay>();

    public virtual ICollection<Supplier> Suppliers { get; } = new List<Supplier>();

    public virtual ICollection<SystemParameter> SystemParameters { get; } = new List<SystemParameter>();

    public virtual ICollection<VoucherTemplateDtl> VoucherTemplateDtls { get; } = new List<VoucherTemplateDtl>();
}
