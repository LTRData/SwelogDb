using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CustomerInvoicePrint
{
    public string CompanyNo { get; set; } = null!;

    public string InvoiceType { get; set; } = null!;

    public decimal InvoiceNo { get; set; }

    public string InvoiceSeries { get; set; } = null!;

    public short LineSerial { get; set; }

    public string DeliveryNoteNo { get; set; } = null!;
}
