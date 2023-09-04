using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ErrandSubModule
{
    public int IdErrandSubModule { get; set; }

    public int? ErrandModuleId { get; set; }

    public string? SubModuleDescription { get; set; }

    public string? AuditStamp { get; set; }
}
