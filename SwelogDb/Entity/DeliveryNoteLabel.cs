using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DeliveryNoteLabel
{
    public int SerialNumber { get; set; }

    public string? DeliveryNoteNumber { get; set; }

    public string? CustomerId { get; set; }

    public string? CustomerName { get; set; }

    public string? OrderNumber { get; set; }

    public string? ItemNumber { get; set; }

    public string? PalletNumber { get; set; }

    public decimal? GrossWeight { get; set; }

    public string? WeightUom { get; set; }

    public decimal? NetWeight { get; set; }

    public int? QuantityPerPallet { get; set; }

    public decimal? TotalDeliveryQuantity { get; set; }

    public decimal? QuantityInThisPallet { get; set; }

    public int? NumberOfPallets { get; set; }

    public string? QuantityUom { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public int? PrimaryReceiverMailingAddressNo { get; set; }

    public string? SenderName { get; set; }

    public string? ConsigneeName { get; set; }

    public int? DeliveryAddressMailingAddressNo { get; set; }

    public int? SenderAddressMailingAddressNo { get; set; }

    public string? CustomersItemNumber { get; set; }

    public string? CustomersItemDescription { get; set; }

    public string? CustomersOrderNumber { get; set; }

    public string? TemplateFlag { get; set; }

    public string? Route { get; set; }
}
