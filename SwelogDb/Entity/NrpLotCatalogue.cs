using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class NrpLotCatalogue
{
    public DateTime NrpRunDate { get; set; }

    public string ItemNumber { get; set; } = null!;

    public short SerialNumber { get; set; }

    public string? NrpType { get; set; }

    public string? NrpId { get; set; }

    public int? NrpDay { get; set; }

    public decimal? NrpQuantity { get; set; }

    public string? AssetFlag { get; set; }
}
