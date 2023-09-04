using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpProcessWithdrawalNotApproved
{
    public short ProcessId { get; set; }

    public int RowId { get; set; }

    public DateTime? ProcessDatetime { get; set; }

    public string? ComponentItem { get; set; }

    public string? PalletNo { get; set; }

    public string? NotApprovePalletNo { get; set; }

    public string? NotApproveCode { get; set; }

    public decimal? QtyNotApproved { get; set; }

    public string? Userid { get; set; }

    public string? Workstation { get; set; }
}
