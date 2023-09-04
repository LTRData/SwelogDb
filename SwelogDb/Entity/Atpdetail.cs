using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Atpdetail
{
    public DateTime? OrderDate { get; set; }

    public int? OrderDateCcyywwd { get; set; }

    public string TransType { get; set; } = null!;

    public string? OrderNo { get; set; }

    public string? Customer { get; set; }

    public string? CustomerName { get; set; }

    public string? Supplier { get; set; }

    public string? SupplierName { get; set; }

    public string? ItemOwner { get; set; }

    public decimal? Receipt { get; set; }

    public decimal? Reserved { get; set; }

    public string? Item { get; set; }

    public DateTime? CalculationDate { get; set; }

    public string DelAddr { get; set; } = null!;

    public string? OrderStatus { get; set; }

    public string? CostCentre { get; set; }

    public int? RecordId { get; set; }

    public decimal? ReceiptTotal { get; set; }

    public decimal? ReservedTotal { get; set; }

    public int ColorCode { get; set; }

    public decimal? PurchOprQuantity { get; set; }

    public string? OrderNumber { get; set; }

    public string? PacklistNumber { get; set; }

    public decimal? PeggedQty { get; set; }

    public int? PicklistDtlLineNo { get; set; }

    public string? AdvancePaymentFlag { get; set; }
}
