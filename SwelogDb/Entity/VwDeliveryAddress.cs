using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwDeliveryAddress
{
    public string PartnerType { get; set; } = null!;

    public string? PartnerId { get; set; }

    public string? DeliveryAddressId { get; set; }

    public string? PartnerKey { get; set; }

    public string? DeliveryAddressKey { get; set; }

    public string OurId { get; set; } = null!;

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

    public string? AvisFlag { get; set; }

    public int? MailingAddressNumber { get; set; }

    public string? HouseNumber { get; set; }

    public string? Street { get; set; }

    public string? ExtraLineForStreet { get; set; }

    public string? PostalName { get; set; }

    public string? PostBoxNo { get; set; }

    public string? City { get; set; }

    public string? StateCode { get; set; }

    public string? ZipCode { get; set; }

    public string? CountryCode { get; set; }

    public int? ElectronicAddressNumber { get; set; }

    public string? MainTelephoneNumber { get; set; }

    public string? MainTelephoneExtension { get; set; }

    public string? AlternateTelephoneNumber { get; set; }

    public string? AlternateTelephoneExtension { get; set; }

    public string? MainTelefaxNumber { get; set; }

    public string? AlternateTelefaxNumber { get; set; }

    public string? ModemPhoneNumber { get; set; }

    public string? CompuserveId { get; set; }

    public string? InternetId { get; set; }

    public string? PassWord { get; set; }
}
