using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CrmActivityInvitee
{
    public int ActivitySerialNumber { get; set; }

    public int InviteeSerialNumber { get; set; }

    public byte? InviteeType { get; set; }

    public int? CrmMasterSerialNumber { get; set; }

    public int? CrmContactSerialNumber { get; set; }

    public string? UserName { get; set; }

    public int? LinkedActivitySerial { get; set; }
}
