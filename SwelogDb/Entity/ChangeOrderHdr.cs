using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ChangeOrderHdr
{
    public string ChangeOrderId { get; set; } = null!;

    public DateTime? ChangeOrderDate { get; set; }

    public string? ChangeOrderDescription { get; set; }

    public int? ChangeOrderDescTxtid { get; set; }

    public string? ChangeOrderDescFlag { get; set; }

    public string? ProjectNumber { get; set; }

    public string? ChangeOrderStatus { get; set; }

    public DateTime? ChangeOrderStatusDate { get; set; }

    public string? ResponsibleId { get; set; }

    public string? ChangeOrderType1 { get; set; }

    public string? ChangeOrderType2 { get; set; }

    public string? ChangeOrderType3 { get; set; }

    public string? ChangeOrderType4 { get; set; }

    public string? ChangeOrderType5 { get; set; }

    public DateTime? EffectFromDate { get; set; }

    public string? EffectFromProject { get; set; }

    public string? GeneralDistList { get; set; }

    public string? ActionForHdr { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ActionListHdr? ActionForHdrNavigation { get; set; }

    public virtual ItemStatus1? ChangeOrderStatusNavigation { get; set; }

    public virtual ChangeOrderType? ChangeOrderType1Navigation { get; set; }

    public virtual ChangeOrderType? ChangeOrderType2Navigation { get; set; }

    public virtual ChangeOrderType? ChangeOrderType3Navigation { get; set; }

    public virtual ChangeOrderType? ChangeOrderType4Navigation { get; set; }

    public virtual ChangeOrderType? ChangeOrderType5Navigation { get; set; }

    public virtual ICollection<EcoActionListForHdr> EcoActionListForHdrs { get; } = new List<EcoActionListForHdr>();

    public virtual DistributionListHdr? GeneralDistListNavigation { get; set; }
}
