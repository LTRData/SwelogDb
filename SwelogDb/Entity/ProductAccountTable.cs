using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ProductAccountTable
{
    public string ProductAccountNumber { get; set; } = null!;

    public string? StockAccountNo { get; set; }

    public string? CostAccountNo { get; set; }

    public string? DomesticSaleAccountNo { get; set; }

    public string? ExportSalesAccountNo { get; set; }

    public string? ReceivableAccount { get; set; }

    public decimal? AcontoSalesDomestic { get; set; }

    public decimal? AcontoSalesExport { get; set; }

    public string? AuditStamp { get; set; }
}
