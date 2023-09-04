using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ViaForwardImportHdr
{
    public int IdViaForwardImportHdr { get; set; }

    public DateTime? ImportDate { get; set; }

    public decimal? XfrId { get; set; }

    public string? EdiOrderNo { get; set; }

    public string? EdiCustomerId { get; set; }

    public string? EdiItemNo { get; set; }

    public string? EdiDelnoteNo { get; set; }

    public string? SwelogOrderNo { get; set; }

    public string? SwelogCustomerId { get; set; }

    public string? SwelogItemNo { get; set; }

    public string? SwelogPicklistNo { get; set; }

    public string? SwelogDelnoteNo { get; set; }

    public decimal? DeliveredQty { get; set; }

    public string? ItemUnitFormat { get; set; }

    public string? SwelogOrderType { get; set; }
}
