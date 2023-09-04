using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpProcessWithdrawal
{
    public short ProcessId { get; set; }

    public int RowId { get; set; }

    public DateTime? ProcessDatetime { get; set; }

    public int? TranSerial { get; set; }

    public string? ParentItem { get; set; }

    public int? ParentLot { get; set; }

    public string? ComponentItem { get; set; }

    public string? Location { get; set; }

    public string? Position { get; set; }

    public string? PalletNo { get; set; }

    public decimal? WithdrawalQty { get; set; }

    public decimal? RejectionQty { get; set; }

    public string? FinalDelivery { get; set; }

    public string? PalletHandling { get; set; }

    public int? OperationNo { get; set; }

    public string? Userid { get; set; }

    public string? Workstation { get; set; }

    public string? NotAppPalletNo { get; set; }

    public string? DrawingPosition { get; set; }

    public int? IdReservation { get; set; }

    public int? WithdrawCase { get; set; }

    public string? AutomaticYn { get; set; }

    public decimal? OrderQuantity { get; set; }

    public DateTime? ReportDateTime { get; set; }
}
