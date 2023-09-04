using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PayDemandCategory
{
    public string PaymentDemandCategory { get; set; } = null!;

    public string? DemandDesc { get; set; }

    public int? DemandDescTxtid { get; set; }

    public string? DemandDescFlag { get; set; }

    public string? AuditStamp { get; set; }

    public int? MaxNoOfDemand { get; set; }

    public string? LanguageCode { get; set; }

    public virtual Language? LanguageCodeNavigation { get; set; }

    public virtual ICollection<PaymentDemandDtl> PaymentDemandDtls { get; } = new List<PaymentDemandDtl>();
}
