using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemAccumulatorValue
{
    public int SerialNo { get; set; }

    public string? ItemNumber { get; set; }

    public DateTime? TransactionDatetime { get; set; }

    public decimal? IssueQuantity { get; set; }

    public decimal? ReceiptQuantity { get; set; }

    public DateTime? LastIssueDatetime { get; set; }

    public DateTime? LastReceiptDatetime { get; set; }

    public short? YearNo { get; set; }

    public short? PeriodNo { get; set; }

    public decimal? ItemBalance { get; set; }

    public decimal? StockDifference { get; set; }
}
