using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CheckList
{
    public int CheckId { get; set; }

    public string ProjectType { get; set; } = null!;

    public string? CheckPoint { get; set; }

    public string? CheckListSort { get; set; }
}
