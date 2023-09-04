using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PurchaseDeliveryDatum
{
    public string GoodsentryNumber { get; set; } = null!;

    public string SupplierId { get; set; } = null!;

    public string? PurchaseOrderNumber { get; set; }

    public short? OrderLineNumber { get; set; }

    public short? OrderLineNumberSub { get; set; }

    public string? OrderLineType { get; set; }

    public DateTime? ArrivalDate { get; set; }

    public string? ItemNumber { get; set; }

    public string? ItemDescription { get; set; }

    public short? OperationNumber { get; set; }

    public decimal? DeliveredQuantity { get; set; }

    public decimal? ApprovedQuantity { get; set; }

    public string? UnitOfMeasure { get; set; }

    public decimal? PurchasePrice { get; set; }

    public string? CurrencyCode { get; set; }

    public short? PriceUnit { get; set; }

    public decimal? OrderLineDiscount { get; set; }

    public decimal? OrderDiscount { get; set; }

    public decimal? VatPercentage { get; set; }

    public decimal? SetupCost { get; set; }

    public string? DeliveryNoteNumber { get; set; }

    public decimal? CostPrice { get; set; }

    public string? ProductGroup { get; set; }

    public string? ProductAccountCode { get; set; }

    public string? CostAccountCode { get; set; }

    public string? DepartmentNo { get; set; }

    public string? ProductNo { get; set; }

    public string? ProjectNo { get; set; }

    public string? FunctionNo { get; set; }

    public string? ArrivalSeries { get; set; }

    public decimal? ArrivalNumber { get; set; }

    public string? Status { get; set; }

    public string? AuditStamp { get; set; }

    public decimal? PurchasePriceFc { get; set; }

    public decimal? SetupCostFc { get; set; }

    public decimal? BalanceBeforeGoodsentry { get; set; }

    public decimal? CostpriceAfterGoodsentry { get; set; }

    public string? StockYard { get; set; }

    public string? ANo { get; set; }

    public string? BNo { get; set; }

    public string? CNo { get; set; }

    public string? DNo { get; set; }

    public string? CreateCodeStrFromOrder { get; set; }

    public string? StockPosition { get; set; }

    public string? VatCode { get; set; }

    public decimal? AlloySurchargeFc { get; set; }

    public decimal? AlloySurchargeBc { get; set; }

    public string? CreateInternCodeStr { get; set; }

    public string? OurReference { get; set; }

    public string? PalletArray { get; set; }

    public decimal? InvoiceValueDifference { get; set; }

    public decimal? OtherCostsFc { get; set; }

    public decimal? OtherCostsBc { get; set; }

    public string? OtherCostsFlag { get; set; }

    public string? AttestConnectedArrivalSeries { get; set; }

    public decimal? AttestConnectedArrivalNo { get; set; }

    public decimal? InvoicedQty { get; set; }

    public decimal? CostpriceAfterInvoice { get; set; }
}
