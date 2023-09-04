using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class WebshopChangeRequest
{
    public int IdWebshopChangeRequest { get; set; }

    public DateTime? RequestDate { get; set; }

    public string? RequestType { get; set; }

    public string? CustomerId { get; set; }

    public string? HouseNumber { get; set; }

    public string? Street { get; set; }

    public string? ExtraLineForStreet { get; set; }

    public string? PostalName { get; set; }

    public string? PostBoxNo { get; set; }

    public string? City { get; set; }

    public string? StateCode { get; set; }

    public string? ZipCode { get; set; }

    public string? CountryCode { get; set; }

    public string? MainTelephoneNumber { get; set; }

    public string? AlternateTelephoneNumber { get; set; }

    public string? MainTelefaxNumber { get; set; }

    public string? AlternateTelefaxNumber { get; set; }

    public string? InternetId { get; set; }

    public string? CompuserveId { get; set; }

    public string? DeliveryAddressId { get; set; }

    public string? ConsigneeName { get; set; }

    public string? StorageName { get; set; }

    public string? Route { get; set; }

    public string? DefaultAddress { get; set; }

    public string? StoreLocation { get; set; }

    public string? ReferenceId { get; set; }

    public string? ReferenceName { get; set; }

    public string? ReferenceType { get; set; }

    public string? OrganisationPosition { get; set; }

    public string? Department { get; set; }

    public string? Active { get; set; }

    public DateTime? ActionDate { get; set; }

    public string? ActionType { get; set; }

    public string? ActionBy { get; set; }
}
