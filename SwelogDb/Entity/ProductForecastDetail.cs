using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ProductForecastDetail
{
    public string ForecastId { get; set; } = null!;

    public int SerialNumber { get; set; }

    public string? Market { get; set; }

    public string? Product { get; set; }

    public short? YearNumber { get; set; }

    public int? TotalVolume { get; set; }

    public byte? StartMonth { get; set; }

    public int? VolumeMonth1 { get; set; }

    public int? VolumeMonth2 { get; set; }

    public int? VolumeMonth3 { get; set; }

    public int? VolumeMonth4 { get; set; }

    public int? VolumeMonth5 { get; set; }

    public int? VolumeMonth6 { get; set; }

    public int? VolumeMonth7 { get; set; }

    public int? VolumeMonth8 { get; set; }

    public int? VolumeMonth9 { get; set; }

    public int? VolumeMonth10 { get; set; }

    public int? VolumeMonth11 { get; set; }

    public int? VolumeMonth12 { get; set; }

    public int? SetupsPerYear { get; set; }

    public string? SourceMonth1 { get; set; }

    public string? SourceMonth2 { get; set; }

    public string? SourceMonth3 { get; set; }

    public string? SourceMonth4 { get; set; }

    public string? SourceMonth5 { get; set; }

    public string? SourceMonth6 { get; set; }

    public string? SourceMonth7 { get; set; }

    public string? SourceMonth8 { get; set; }

    public string? SourceMonth9 { get; set; }

    public string? SourceMonth10 { get; set; }

    public string? SourceMonth11 { get; set; }

    public string? SourceMonth12 { get; set; }
}
