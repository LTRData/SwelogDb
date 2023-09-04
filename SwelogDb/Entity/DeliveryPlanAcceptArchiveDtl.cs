using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DeliveryPlanAcceptArchiveDtl
{
    public int IdDeliveryPlanAcceptArchiveDtl { get; set; }

    public int? IdDeliveryPlanAcceptArchiveHdr { get; set; }

    public string? OrderDateStr { get; set; }

    public string? DpArrivalDateStr { get; set; }

    public DateTime? OrderDate { get; set; }

    public DateTime? ArrivalDate { get; set; }

    public string? OrderNo { get; set; }

    public string? Supplier { get; set; }

    public string? ItemOwner { get; set; }

    public decimal? Receipt { get; set; }

    public decimal? Reserved { get; set; }

    public string? TransType { get; set; }

    public decimal? DispQty { get; set; }

    public DateTime? CalculationDate { get; set; }

    public string? Remark { get; set; }

    public int? Inserted { get; set; }

    public string? DpStatus { get; set; }

    public string? StockingUnit { get; set; }

    public string? DelAddr { get; set; }

    public int? ColorCode { get; set; }

    public string? OrderStatus { get; set; }

    public string? CostCentre { get; set; }
}
