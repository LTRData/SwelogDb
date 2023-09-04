using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ErrandModule
{
    public int IdErrandModule { get; set; }

    public string? ModuleDescription { get; set; }

    public string? AuditStamp { get; set; }
}
