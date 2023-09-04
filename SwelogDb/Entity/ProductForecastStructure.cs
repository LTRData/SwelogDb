using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ProductForecastStructure
{
    public string ForecastId { get; set; } = null!;

    public int SerialNumber { get; set; }

    public string? Product { get; set; }

    public string? ItemNumber { get; set; }

    public short? YearNumber { get; set; }

    public int? TotalVolume { get; set; }

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
}
