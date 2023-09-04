﻿using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ChangeItemSupplierItem
{
    public string ItemNumber { get; set; } = null!;

    public string SupplierId { get; set; } = null!;

    public string SupplierItemNumber { get; set; } = null!;

    public string? SupplierItemDescription { get; set; }

    public int? SupplierItemTxtid { get; set; }

    public string? SupplierItemFlag { get; set; }

    public string? SupplierUom { get; set; }

    public string? ArrivalControl { get; set; }

    public short? DeliveryTimeInDays { get; set; }

    public short? TransportTimeInDays { get; set; }

    public string? SupplierClassCode { get; set; }

    public string? SupplierItemDiscountCode { get; set; }

    public decimal? DiscountPercentile { get; set; }

    public string? SupplierHandler { get; set; }

    public short? EarlyDeliveryTolerance { get; set; }

    public short? LateDeliveryTolerance { get; set; }

    public decimal? QtyToleranceAllowed { get; set; }

    public decimal? SupplierGrade { get; set; }

    public string? AuditStamp { get; set; }

    public string? PreferedItem { get; set; }

    public decimal? RecalculateFactor { get; set; }

    public virtual ChangeItemSupplier ChangeItemSupplier { get; set; } = null!;
}
