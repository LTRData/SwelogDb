using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PackingItemsForDelivery
{
    public int RecNo { get; set; }

    public string? OrderType { get; set; }

    public string? OrderNumber { get; set; }

    public short? OrderLineNumber { get; set; }

    public short? OrderLineNumberSub { get; set; }

    public string? ItemNumber { get; set; }

    public string? PackingItemNumber { get; set; }

    public string? PacklistNumber { get; set; }

    public string? PicklistNumber { get; set; }

    public string? DeliveryNote { get; set; }

    public decimal? OrderQuantity { get; set; }

    public string? UnitOfSale { get; set; }

    public string? CurrencyCode { get; set; }

    public decimal? SellingPrice { get; set; }

    public decimal? PriceUnit { get; set; }

    public DateTime? DemandDate { get; set; }

    public decimal? OrderedAmount { get; set; }

    public string? Delivered { get; set; }

    public short? PicklistDtlLineNo { get; set; }

    public string? AuditStamp { get; set; }

    public string? PackMtrlFlag { get; set; }

    public string? PackMtrlStoreLoc { get; set; }

    public virtual PacklistHeader? PacklistNumberNavigation { get; set; }
}
