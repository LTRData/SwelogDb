using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwTemplateDispatchList
{
    public string? ItemNumber { get; set; }

    public int? LotNumber { get; set; }

    public int? OperationNumber { get; set; }

    public string? ItemDescription { get; set; }

    public string? OperationDescription { get; set; }

    public DateTime? MfgOperationStartTime { get; set; }

    public DateTime? MfgOperationEndTime { get; set; }

    public string? PriorOpnCheck { get; set; }

    public int? MfgOrderSerialKey { get; set; }

    public string? MaterialCheck { get; set; }

    public string? ToolCheck { get; set; }

    public string? ExecutionStatus { get; set; }

    public decimal? ResourceTime { get; set; }

    public int? Priority { get; set; }

    public string? CapacityCheck { get; set; }

    public DateTime? ActualStartDate { get; set; }

    public string? ResourceNumber { get; set; }

    public string? OperationStatus { get; set; }

    public string? MaterialCheckFlag { get; set; }

    public int? DummyPriority { get; set; }

    public string? MfgOrderNumber { get; set; }

    public string? StockingUnit { get; set; }

    public decimal? OrderedQuantity { get; set; }

    public decimal? RemainingQuantity { get; set; }

    public decimal? RemainingTime { get; set; }

    public string? ResourceDescription { get; set; }

    public int? PriorOperationNumber { get; set; }

    public decimal? DeliveryQuantity { get; set; }

    public DateTime? MfgOrderStartDate { get; set; }

    public int? UnitConversionFactor { get; set; }

    public decimal? QtyProduced { get; set; }

    public int? LastOperationNumber { get; set; }

    public string? OpnMessageReported { get; set; }

    public string? JtPrinted { get; set; }

    public string? OptMessageReported { get; set; }

    public string? ResourceOnService { get; set; }

    public string? CurrentResource { get; set; }

    public int? OperatorNumber { get; set; }

    public string? ToolNumber { get; set; }

    public string? OrderType { get; set; }

    public int? DocumentExists { get; set; }

    public int? OperationDescTxtid { get; set; }

    public string? OperationTextFlag { get; set; }

    public string? OperationPictureFlag { get; set; }

    public string? OperationShift { get; set; }

    public int? OrdersPerShift { get; set; }

    public string? PlanningMethod { get; set; }

    public string? MfgOrderText { get; set; }

    public string? MfgOrderType { get; set; }

    public int? StartDateCcyywwd { get; set; }

    public int? EndDateCcyywwd { get; set; }

    public int? ConnectedOperations { get; set; }

    public string? PartialPallet { get; set; }

    public string? OrderLine { get; set; }

    public string? ReservationItemNumber { get; set; }

    public string? CncProgramFlag { get; set; }

    public int? CncProgramQuantity { get; set; }

    public int? CncProgramQuantityOther { get; set; }

    public string? CustomerId { get; set; }

    public string? CustomerName { get; set; }

    public string? FreeCode1 { get; set; }

    public string? FreeCode2 { get; set; }

    public string? FreeCode3 { get; set; }

    public string? ProductGroup { get; set; }

    public decimal? RemainingOperationTime { get; set; }

    public string? NextOperationResource { get; set; }

    public int? ColorCode { get; set; }

    public DateTime? MfgOrderFinishDate { get; set; }

    public string? OperationComment { get; set; }

    public string? RevisionNo { get; set; }
}
