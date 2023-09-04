using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class AcNumberRangeGeneral
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public string NumberRangeForCode { get; set; } = null!;

    public string SeriesId { get; set; } = null!;

    public double? SeriesNumber { get; set; }

    public string? NumberRangeDesc { get; set; }

    public double? NumberRangeDescTxtid { get; set; }

    public string? NumberRangeDescFlag { get; set; }

    public string? SeriesDescription { get; set; }

    public double? SeriesDescriptionTxtid { get; set; }

    public string? SeriesDescriptionFlag { get; set; }

    public string? SeriesPrefixCode { get; set; }

    public double? StartingSerialNumber { get; set; }

    public double? EndingSerialNumber { get; set; }

    public double? Step { get; set; }

    public double? LastSerialUsed { get; set; }

    public double? CheckDigitCode { get; set; }

    public DateTime? NewSeriesStartDate { get; set; }

    public string? NewSeriesPrefixCode { get; set; }

    public string? AuditStamp { get; set; }

    public string? SeriesIdForSie { get; set; }

    public string? PdfFilePath { get; set; }
}
