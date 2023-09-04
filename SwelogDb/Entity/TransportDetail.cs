using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TransportDetail
{
    public string DeliveryNote { get; set; } = null!;

    public short LineId { get; set; }

    public string? PackagingTypeCode { get; set; }

    public int? PackagesNumber { get; set; }

    public string? GoodsDescCode { get; set; }

    public decimal? NetWeight { get; set; }

    public decimal? GrossWeight { get; set; }

    public decimal? Volume { get; set; }

    public decimal? GoodsLength { get; set; }

    public string? AuditStamp { get; set; }

    public string? ProductGroupCode { get; set; }

    public string? GoodsMarking { get; set; }

    public decimal? LoadingMeasure { get; set; }

    public string TransportType { get; set; } = null!;

    public decimal? Width { get; set; }

    public decimal? Length { get; set; }

    public decimal? Height { get; set; }
}
