using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CrmUserSetting
{
    public string UserId { get; set; } = null!;

    public string? TelephoneNumber1 { get; set; }

    public string? TelephoneNumber2 { get; set; }

    public string? FaxNumber { get; set; }

    public string? SignaturePath { get; set; }

    public string? SignatureFilename { get; set; }

    public string? EmailAddress { get; set; }

    public string? HomepageAddress { get; set; }

    public string? OwnSignature { get; set; }

    public string? OtherEmailLoginId { get; set; }

    public string? OtherEmailLoginPwd { get; set; }

    public string? UserTitle { get; set; }
}
