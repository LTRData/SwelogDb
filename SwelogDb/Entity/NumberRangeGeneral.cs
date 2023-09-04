using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class NumberRangeGeneral
{
    public string NumberRangeForCode { get; set; } = null!;

    public string SeriesId { get; set; } = null!;

    public short? SeriesNumber { get; set; }

    public string? NumberRangeDesc { get; set; }

    public int? NumberRangeDescTxtid { get; set; }

    public string? NumberRangeDescFlag { get; set; }

    public string? SeriesDescription { get; set; }

    public int? SeriesDescriptionTxtid { get; set; }

    public string? SeriesDescriptionFlag { get; set; }

    public string? SeriesPrefixCode { get; set; }

    public int? StartingSerialNumber { get; set; }

    public int? EndingSerialNumber { get; set; }

    public short? Step { get; set; }

    public int? LastSerialUsed { get; set; }

    public short? CheckDigitCode { get; set; }

    public DateTime? NewSeriesStartDate { get; set; }

    public string? NewSeriesPrefixCode { get; set; }

    public string? AuditStamp { get; set; }

    public string? NumberMask { get; set; }
}
