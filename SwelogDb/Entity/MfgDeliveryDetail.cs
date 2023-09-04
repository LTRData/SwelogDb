using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MfgDeliveryDetail
{
    public string ItemNumber { get; set; } = null!;

    public int LotNumber { get; set; }

    public DateTime DeliveryDatetime { get; set; }

    public decimal? RawMaterialCost { get; set; }

    public decimal? RawMaterialOverhead { get; set; }

    public decimal? PurchaseItemCost { get; set; }

    public decimal? PurchaseFixedOrderCost { get; set; }

    public decimal? PurchaseOverheadCost { get; set; }

    public decimal? HiredOperationCost { get; set; }

    public decimal? OperatorCost { get; set; }

    public decimal? OperatorSetupCost { get; set; }

    public decimal? MfgOverheadCost { get; set; }

    public decimal? ComponentOperatorCost { get; set; }

    public decimal? ComponentOperatorSetupCost { get; set; }

    public decimal? ComponentMfgOverheadCost { get; set; }

    public decimal? CurrentTotalCost { get; set; }

    public decimal? DeliveryQuantity { get; set; }

    public string? FinalDeliveryFlag { get; set; }

    public string? AuditStamp { get; set; }

    public decimal? ComponentCurrentTotalCost { get; set; }

    public DateTime? EventDate { get; set; }

    public decimal? TransferJnlYearNo { get; set; }

    public string? TransferJnlSeries { get; set; }

    public decimal? TransferJnlVoucherNo { get; set; }

    public string? AccountJnlSeries { get; set; }

    public decimal? AccountJnlVoucherNo { get; set; }

    public DateTime? AccountingDate { get; set; }

    public int? TranSerial { get; set; }

    public int? IdMfgDeliveryHeader { get; set; }
}
