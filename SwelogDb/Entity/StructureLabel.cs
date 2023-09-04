using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class StructureLabel
{
    public string UserId { get; set; } = null!;

    public short SerialNumber { get; set; }

    public string? ComponentPart { get; set; }

    public string? ComponentDescription { get; set; }

    public string? ComponentExtraDescription { get; set; }

    public string? ComponentTextRow01 { get; set; }

    public string? ComponentTextRow02 { get; set; }

    public string? ComponentTextRow03 { get; set; }

    public string? ComponentTextRow04 { get; set; }

    public string? ComponentTextRow05 { get; set; }

    public string? ParentItem { get; set; }

    public string? ParentItemDrawingNo { get; set; }

    public string? ParentItemRevisionNo { get; set; }

    public decimal? QuantityOfComponent { get; set; }
}
