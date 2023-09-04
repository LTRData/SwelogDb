using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CrmGroup
{
    public string GroupId { get; set; } = null!;

    public string? GroupDescription { get; set; }

    public bool? AdminFlag { get; set; }
}
