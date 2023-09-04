using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class AddressLabel
{
    public string? AddressLabelId { get; set; }

    public string? AddressLabelDescr { get; set; }

    public string? AuditStamp { get; set; }

    public double? AddressLabelTxtid { get; set; }
}
