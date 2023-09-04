using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwCustomerDeliveryAddress
{
    public string CustomerId { get; set; } = null!;

    public string? CustomerName { get; set; }

    public string DeliveryAddressId { get; set; } = null!;

    public string? ConsigneeName { get; set; }

    public string? StorageName { get; set; }

    public string? Route { get; set; }

    public string? UnloadingDescription { get; set; }

    public string? GanNo { get; set; }

    public string? PalletNumber { get; set; }

    public string? DefaultAddress { get; set; }

    public string? HouseNumber { get; set; }

    public string? Street { get; set; }

    public string? ExtraLineForStreet { get; set; }

    public string? PostalName { get; set; }

    public string? PostBoxNo { get; set; }

    public string? ZipCode { get; set; }

    public string? City { get; set; }

    public string? StateCode { get; set; }

    public string? CountryName { get; set; }

    public string? MainTelephoneNumber { get; set; }

    public string? MainTelephoneExtension { get; set; }

    public string? MainTelefaxNumber { get; set; }

    public string? CompuserveId { get; set; }

    public string? InternetId { get; set; }

    public string? AlternateTelephoneNumber { get; set; }

    public string? AlternateTelephoneExtension { get; set; }

    public string? AlternateTelefaxNumber { get; set; }

    public string? ModemPhoneNumber { get; set; }
}
