using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SwelogPocketSavedPicklistsFinalDelv
{
    public int SerialNumber { get; set; }

    public int? HeaderSerialNumber { get; set; }

    public short? RowNumber { get; set; }

    public string? FinalDeliveryFlag { get; set; }

    public virtual SwelogPocketSavedPicklistsHeader? HeaderSerialNumberNavigation { get; set; }
}
