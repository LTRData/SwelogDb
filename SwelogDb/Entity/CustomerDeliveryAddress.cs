using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CustomerDeliveryAddress
{
    public string CustomerId { get; set; } = null!;

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

    public string? DefaultAddress { get; set; }

    public string? MessageOnFreightnote { get; set; }

    public string? StoreLocation { get; set; }

    public string? CustomersDepartment { get; set; }

    public string? ConsigneeNameExtra { get; set; }

    public string? DeliveryRouteCode1 { get; set; }

    public string? DeliveryRouteCode2 { get; set; }

    public string? DeliveryRouteCode3 { get; set; }

    public string? EdiInvoice { get; set; }

    public string? DrwgRevNoInOdetteLabel { get; set; }

    public string? AvisFlag { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<CustomerArticle> CustomerArticles { get; } = new List<CustomerArticle>();

    public virtual MailingAddress? MailingAddrNoNavigation { get; set; }
}
