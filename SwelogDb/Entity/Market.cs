using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Market
{
    public string MarketCode { get; set; } = null!;

    public string? MarketDescription { get; set; }

    public int? MarketNameTxtid { get; set; }

    public string? MarketNameFlag { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<ContractOrderHeader> ContractOrderHeaders { get; } = new List<ContractOrderHeader>();

    public virtual ICollection<CustInvoiceHdr> CustInvoiceHdrs { get; } = new List<CustInvoiceHdr>();

    public virtual ICollection<CustomerOrderHeader> CustomerOrderHeaders { get; } = new List<CustomerOrderHeader>();

    public virtual ICollection<Customer> Customers { get; } = new List<Customer>();

    public virtual ICollection<ItemMarketPrice> ItemMarketPrices { get; } = new List<ItemMarketPrice>();

    public virtual ICollection<PriceListHdr> PriceListHdrs { get; } = new List<PriceListHdr>();

    public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; } = new List<PurchaseOrderHeader>();

    public virtual ICollection<SystemParameter> SystemParameters { get; } = new List<SystemParameter>();
}
