using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DelplanAutodeductPeggedReservationsWarning
{
    public string? ItemNumber { get; set; }

    public string? CustomerId { get; set; }

    public string? DeladdrId { get; set; }

    public string? OrderNo { get; set; }

    public string? PacklistNumber { get; set; }

    public string? PacklistValidYn { get; set; }

    public decimal? Quantity { get; set; }

    public DateTime? RequiredDate { get; set; }

    public int? IdReservation { get; set; }

    public string? DeliveryPlanId { get; set; }

    public int? IdNewDeliveryPlanDtlImport { get; set; }

    public int? IdDelplanAutodeductDeliveryNotesHdr { get; set; }

    public int IdDelplanAutodeductPeggedReservationsWarning { get; set; }

    public short? PicklistDtlLineNo { get; set; }
}
