using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SecurityUserLogSpid
{
    public int Spid { get; set; }

    public string UserId { get; set; } = null!;

    public string? LanguageCode { get; set; }

    public DateTime? LoginDateTime { get; set; }

    public bool? Jticket { get; set; }
}
