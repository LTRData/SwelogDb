using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class FreightCollectAddress
{
    public string FreightCollectAddress1 { get; set; } = null!;

    public string? ConsigneeName { get; set; }

    public int? MailingAddrNo { get; set; }

    public int? ElectronicAddrNo { get; set; }

    public string? StorageName { get; set; }

    public string? Route { get; set; }

    public string? UnloadingDescription { get; set; }

    public string? GanNo { get; set; }

    public string? PalletNumber { get; set; }

    public string? AuditStamp { get; set; }

    public string? DefaultAddress { get; set; }

    public string? MessageOnFreightnote { get; set; }

    public virtual MailingAddress? MailingAddrNoNavigation { get; set; }
}
