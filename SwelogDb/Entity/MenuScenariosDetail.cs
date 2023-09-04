using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MenuScenariosDetail
{
    public int DetailSerialNumber { get; set; }

    public int HeaderSerialNumber { get; set; }

    public int SerialNumber { get; set; }

    public string? MenuText { get; set; }

    public string? SwelogMenuId { get; set; }

    public int? ParentSerialNumber { get; set; }

    public int? SortOrder { get; set; }

    public string? MenuType { get; set; }

    public string? SearchPath { get; set; }

    public int? PosX { get; set; }

    public int? PosY { get; set; }
}
