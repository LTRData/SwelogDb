using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CrmOrderLineNote
{
    public int SerialNumber { get; set; }

    public string? CrmTypeCode { get; set; }

    public string? OrderType { get; set; }

    public string? OrderNumber { get; set; }

    public short? OrderLineNumber { get; set; }

    public short? OrderLineNumberSub { get; set; }

    public string? Notes { get; set; }
}
