using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TextTable
{
    public string TextCode { get; set; } = null!;

    public string LanguageCode { get; set; } = null!;

    public string? TextDescription { get; set; }

    public string? AuditStamp { get; set; }

    public string? OrderConfirmation { get; set; }

    public string? Offer { get; set; }

    public string? Picklist { get; set; }

    public string? PicklistDelivery { get; set; }

    public string? DeliveryNote { get; set; }

    public string? Invoice { get; set; }

    public string? InterestInvoice { get; set; }

    public string? DemandNote { get; set; }

    public string? PurchaseOrder { get; set; }

    public string? Packlist { get; set; }

    public string? PurchOrderDeliveryReminder { get; set; }

    public string? SupplierComplaints { get; set; }

    public string? Jticket { get; set; }

    public virtual Language LanguageCodeNavigation { get; set; } = null!;
}
