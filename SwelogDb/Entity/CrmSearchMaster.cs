using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CrmSearchMaster
{
    public int SerialNumber { get; set; }

    public string? CrmId { get; set; }

    public int? SearchOrder { get; set; }

    public string? UserId { get; set; }
}
