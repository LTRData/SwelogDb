using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OurDeliveryAddress
{
    public string OurId { get; set; } = null!;

    public string DeliveryAddressId { get; set; } = null!;

    public string? ConsigneeName { get; set; }

    public int? MailingAddrNo { get; set; }

    public int? ElectronicAddrNo { get; set; }

    public string? StorageName { get; set; }

    public string? Route { get; set; }

    public string? UnloadingDescription { get; set; }

    public string? GanNo { get; set; }

    public string? PalletNumber { get; set; }

    public string? AuditStamp { get; set; }

    public string? DefaultDeliveryAddress { get; set; }

    public string? CompanyNo { get; set; }

    public string? CostCentre { get; set; }

    public string? ExternalDeladdrKey { get; set; }
}
