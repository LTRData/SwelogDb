using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PaymentModeInText
{
    public string ModeOfPayment { get; set; } = null!;

    public string LanguageCode { get; set; } = null!;

    public string? DocumentText { get; set; }

    public string? AuditStamp { get; set; }

    public virtual PaymentModeIn ModeOfPaymentNavigation { get; set; } = null!;
}
