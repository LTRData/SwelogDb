using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ContainerType
{
    public string ContainerType1 { get; set; } = null!;

    public string? ContainerDescription { get; set; }

    public int? ContainerDescriptionTxtid { get; set; }

    public decimal? CapacityWeight { get; set; }

    public string? WeightUom { get; set; }

    public decimal? CapacityVolume { get; set; }

    public string? VolumeUom { get; set; }

    public decimal? TareWeight { get; set; }

    public decimal? TareVolume { get; set; }

    public string? AuditStamp { get; set; }
}
