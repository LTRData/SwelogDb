using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MenuRolesDetail
{
    public int DetailSerialNumber { get; set; }

    public int HeaderSerialNumber { get; set; }

    public int? ScenarioSerialNumber { get; set; }

    public int? SortOrder { get; set; }
}
