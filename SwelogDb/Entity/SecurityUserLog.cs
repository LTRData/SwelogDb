using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SecurityUserLog
{
    public int SerialNumber { get; set; }

    public string? UserId { get; set; }

    public DateTime? LogonTimestamp { get; set; }

    public string? WorkstationId { get; set; }

    public bool? UsingProdAttest { get; set; }

    public int? Spid { get; set; }

    public string? LanguageCode { get; set; }

    public string? SessionInfo { get; set; }

    public DateTime? ExpiryTimestamp { get; set; }
}
