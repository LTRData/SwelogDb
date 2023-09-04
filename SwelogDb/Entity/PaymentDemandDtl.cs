using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PaymentDemandDtl
{
    public string PaymentDemandCategory { get; set; } = null!;

    public short PaymentDemandNo { get; set; }

    public short? PaymentDemandDays { get; set; }

    public string? PaymentDemandText { get; set; }

    public int? PaymentDemandTxtid { get; set; }

    public string? PaymentDemandFlag { get; set; }

    public string? AuditStamp { get; set; }

    public int? PaymentDemandTextNo { get; set; }

    public virtual PayDemandCategory PaymentDemandCategoryNavigation { get; set; } = null!;
}
