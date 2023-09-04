using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CrmHeirarchy
{
    public string ParentUserId { get; set; } = null!;

    public string ChildUserId { get; set; } = null!;
}
