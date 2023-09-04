using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ModuleTable
{
    public string ModuleId { get; set; } = null!;

    public string TableName { get; set; } = null!;
}
