using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ResourceDeviation
{
    public int SerialNumber { get; set; }

    public string? ResourceNumber { get; set; }

    public DateTime? DeviationDate { get; set; }

    public short? NumberOfResourceUnits { get; set; }

    public short? NumberOfShifts { get; set; }

    public decimal? Manning { get; set; }

    public string? DeviationNotes { get; set; }
}
