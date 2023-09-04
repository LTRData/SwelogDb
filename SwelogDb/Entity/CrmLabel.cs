using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CrmLabel
{
    public int SerialNumber { get; set; }

    public string? LabelName { get; set; }

    public decimal? WidthCm { get; set; }

    public decimal? HeightCm { get; set; }

    public int? NumberAcross { get; set; }

    public int? NumberDown { get; set; }

    public decimal? BetweenColumnsCm { get; set; }

    public decimal? BetweenRowsCm { get; set; }

    public decimal? LeftMarginCm { get; set; }

    public decimal? RightMarginCm { get; set; }

    public decimal? TopMarginCm { get; set; }

    public decimal? BottomMarginCm { get; set; }

    public byte? PaperOrientation { get; set; }

    public string? AttentionSalutation { get; set; }
}
