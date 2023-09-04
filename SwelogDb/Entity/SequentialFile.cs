using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SequentialFile
{
    public string CompanyId { get; set; } = null!;

    public string? NewDelplan { get; set; }

    public string? NewCalloff { get; set; }

    public string? Orders { get; set; }

    public string? ConnectionDamaps { get; set; }

    public string? OrderAck { get; set; }

    public string? Avisering { get; set; }

    public string? Invoices { get; set; }

    public string? FreightDocuments { get; set; }

    public string? PurchaseOrders { get; set; }

    public string? DelplanSupplier { get; set; }

    public string? AuditStamp { get; set; }

    public string? Timekeyin { get; set; }

    public string? Timekeyut { get; set; }

    public string? AviexpReadPath { get; set; }

    public string? AviexpWritePath { get; set; }
}
