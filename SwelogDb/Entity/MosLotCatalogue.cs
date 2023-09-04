﻿using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MosLotCatalogue
{
    public DateTime NrpRunDate { get; set; }

    public string ItemNumber { get; set; } = null!;

    public int SerialNumber { get; set; }

    public string? NrpType { get; set; }

    public string? NrpId { get; set; }

    public int? NrpDay { get; set; }

    public decimal? NrpQuantity { get; set; }

    public string? AssetFlag { get; set; }

    public string? ItemDescription { get; set; }

    public string? NewChangedFlag { get; set; }
}
