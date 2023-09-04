using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwDeliveryHdrAttest
{
    public string? SelectFlag { get; set; }

    public string? DeliveryType { get; set; }

    public string? PartnerId { get; set; }

    public string DeliveryNoteNumber { get; set; } = null!;

    public string? FreightNote { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public string? SupplierNoInCo { get; set; }
}
