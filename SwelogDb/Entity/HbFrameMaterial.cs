using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class HbFrameMaterial
{
    public string MaterialId { get; set; } = null!;

    public string MaterialDescription { get; set; } = null!;

    public string Prefix { get; set; } = null!;

    public string? ValidFrameThickness { get; set; }

    public string PrefixInDescription { get; set; } = null!;

    public string ProductGroupOuterPart { get; set; } = null!;

    public string ProductGroupInnerPart { get; set; } = null!;

    public int? OperationNumberOuterPartStd { get; set; }

    public int? OperationNumberOuterPartSpl { get; set; }

    public int? OperationNumberMounting { get; set; }

    public int? OperationNumberMountingBig { get; set; }

    public string? AuditStamp { get; set; }

    public string? PictureFilePath { get; set; }

    public string? SpecItemNumberOuterPart { get; set; }

    public string? SpecItemNumberInnerPart { get; set; }

    public int? OperationNumberInnerPartStd { get; set; }

    public int? OperationNumberInnerPartSpl { get; set; }

    public int? OperationNumberMountingSpl { get; set; }

    public int? OperationNumberMountingThin { get; set; }

    public short? ReductionInnerPartStd { get; set; }

    public short? ReductionInnerPartSpl { get; set; }

    public short? ReductionPocket { get; set; }
}
