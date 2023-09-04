using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DocumentObject
{
    public int SerialNumber { get; set; }

    public string? PrimaryObjectName { get; set; }

    public string? PreferredName { get; set; }

    public string? PrimaryTableName { get; set; }

    public string? RelatedTableNames { get; set; }

    public string? TableRelations { get; set; }
}
