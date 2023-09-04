using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ChangeOrderType
{
    public string ChangeOrderType1 { get; set; } = null!;

    public string? Description { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<ChangeOrderHdr> ChangeOrderHdrChangeOrderType1Navigations { get; } = new List<ChangeOrderHdr>();

    public virtual ICollection<ChangeOrderHdr> ChangeOrderHdrChangeOrderType2Navigations { get; } = new List<ChangeOrderHdr>();

    public virtual ICollection<ChangeOrderHdr> ChangeOrderHdrChangeOrderType3Navigations { get; } = new List<ChangeOrderHdr>();

    public virtual ICollection<ChangeOrderHdr> ChangeOrderHdrChangeOrderType4Navigations { get; } = new List<ChangeOrderHdr>();

    public virtual ICollection<ChangeOrderHdr> ChangeOrderHdrChangeOrderType5Navigations { get; } = new List<ChangeOrderHdr>();
}
