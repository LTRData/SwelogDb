using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CustomerDemandView
{
    public string CompanyNo { get; set; } = null!;

    public string InvoiceType { get; set; } = null!;

    public string InvoiceSeries { get; set; } = null!;

    public decimal InvoiceNo { get; set; }

    public string? CustomerNo { get; set; }

    public int DemandNum { get; set; }

    public int? NewDemandNum { get; set; }

    public DateTime? DueDate { get; set; }

    public string? PayDemdCatg { get; set; }

    public short DemandDays { get; set; }

    public short NewDemandDays { get; set; }
}
