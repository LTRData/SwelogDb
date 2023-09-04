using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CrmSecurityUserGroup
{
    public int SerialNumber { get; set; }

    public string? GroupId { get; set; }

    public string? UserId { get; set; }

    public string? OptionName { get; set; }

    public bool? AllowedFlag { get; set; }
}
