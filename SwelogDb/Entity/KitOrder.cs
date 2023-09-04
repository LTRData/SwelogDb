using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class KitOrder
{
    public string KitId { get; set; } = null!;

    public string? KitDescription { get; set; }

    public int? KitDescriptionTxtid { get; set; }

    public string? KitDescriptionFlag { get; set; }

    public string? ItemQuantityFlag { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<KitItemTable> KitItemTables { get; } = new List<KitItemTable>();
}
