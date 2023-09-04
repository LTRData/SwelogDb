using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class WebshopHbCustomerRequestArchive
{
    public int SerialNumber { get; set; }

    public string CustomerId { get; set; } = null!;

    public string? PartnerOwnOrderNo { get; set; }

    public string? OrderType { get; set; }

    public DateTime? RequestDate { get; set; }

    public string? YourReference { get; set; }

    public string? SalesmanCode { get; set; }

    public string? CustomersRefTelphone { get; set; }

    public string? CustomersRefEmailId { get; set; }

    public string? CustomersText { get; set; }

    public DateTime? DesiredDeliveryDate { get; set; }

    public string? ConsigneeName { get; set; }

    public string? ConsigneeNameExtra { get; set; }

    public string? HouseNumber { get; set; }

    public string? Street { get; set; }

    public string? ExtraLineForStreet { get; set; }

    public string? ZipCode { get; set; }

    public string? City { get; set; }

    public string? DeliveryTelephoneNumber { get; set; }

    public string? AvisFlag { get; set; }

    public string? DeliveryAddressId { get; set; }

    public string? ActualOrderNumber { get; set; }

    public string? CompleteRequest { get; set; }

    public string? NewOrCopiedOrder { get; set; }

    public string? AuditStamp { get; set; }

    public string? ConsigneeNameDefault { get; set; }

    public string? ConsigneeNameExtraDefault { get; set; }

    public string? HouseNumberDefault { get; set; }

    public string? StreetDefault { get; set; }

    public string? ExtraLineForStreetDefault { get; set; }

    public string? ZipCodeDefault { get; set; }

    public string? CityDefault { get; set; }

    public string? DeliveryTelephoneNumberDefault { get; set; }

    public string? CountryCode { get; set; }

    public string? CountryCodeDefault { get; set; }

    public string? DeliveryEmailId { get; set; }

    public string? TransportModeCode { get; set; }

    public string? WebshopUser { get; set; }

    public string? UpdateOrder { get; set; }

    public virtual ICollection<WebshopHbCustomerRequestLineArchive> WebshopHbCustomerRequestLineArchives { get; } = new List<WebshopHbCustomerRequestLineArchive>();
}
