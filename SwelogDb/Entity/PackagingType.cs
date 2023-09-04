using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PackagingType
{
    public string PackagingTypeCode { get; set; } = null!;

    public string? PackagingDescription { get; set; }

    public int? PackagingTxtid { get; set; }

    public string? AuditStamp { get; set; }

    public string? DefaultInFreightnote { get; set; }

    public decimal? GrossWeight { get; set; }

    public decimal? Width { get; set; }

    public decimal? Length { get; set; }

    public decimal? Height { get; set; }
}
