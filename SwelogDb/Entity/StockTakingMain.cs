using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class StockTakingMain
{
    public int StockTakingNo { get; set; }

    public DateTime? ListCreateDatetime { get; set; }

    public string? UserCriteria { get; set; }

    public string? SortOption { get; set; }

    public string? StockTakingLevel { get; set; }

    public string? ManualEntryFlag { get; set; }

    public string? ListPrintedFlag { get; set; }

    public string? AllApprovedFlag { get; set; }

    public string? NegativeBalanceFlag { get; set; }

    public string? ExceptionList { get; set; }

    public DateTime? ExceptionListDatetime { get; set; }

    public string? LeaveoutZeroBalanceFlag { get; set; }
}
