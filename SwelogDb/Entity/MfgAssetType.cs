using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MfgAssetType
{
    public string MfgAssetType1 { get; set; } = null!;

    public int? MfgAssetTypeDescriptionText { get; set; }

    public string? ActiveYn { get; set; }
}
