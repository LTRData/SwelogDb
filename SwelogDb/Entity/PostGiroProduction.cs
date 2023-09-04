using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PostGiroProduction
{
    public string CompanyNo { get; set; } = null!;

    public DateTime PostGiroFileDate { get; set; }

    public byte? ProductionNo { get; set; }
}
