using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CrmUser
{
    public string GroupId { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public bool? AdminFlag { get; set; }
}
