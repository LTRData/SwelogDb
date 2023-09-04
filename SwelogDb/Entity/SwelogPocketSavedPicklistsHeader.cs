using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SwelogPocketSavedPicklistsHeader
{
    public int SerialNumber { get; set; }

    public string? PicklistNumber { get; set; }

    public DateTime? LastSavedTimestamp { get; set; }

    public string? LastSavedUserid { get; set; }

    public virtual ICollection<SwelogPocketSavedPicklistsDetail> SwelogPocketSavedPicklistsDetails { get; } = new List<SwelogPocketSavedPicklistsDetail>();

    public virtual ICollection<SwelogPocketSavedPicklistsFinalDelv> SwelogPocketSavedPicklistsFinalDelvs { get; } = new List<SwelogPocketSavedPicklistsFinalDelv>();
}
