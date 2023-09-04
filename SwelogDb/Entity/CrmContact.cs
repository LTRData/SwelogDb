using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CrmContact
{
    public int SerialNumber { get; set; }

    public int ContactSerialNumber { get; set; }

    public string? ContactId { get; set; }

    public string? ContactName { get; set; }

    public string? OrganisationPosition { get; set; }

    public string? Active { get; set; }

    public string? ContactNotes { get; set; }

    public string? HouseNumber { get; set; }

    public string? Street { get; set; }

    public string? ExtraLineForStreet { get; set; }

    public string? City { get; set; }

    public string? StateCode { get; set; }

    public string? ZipCode { get; set; }

    public string? CountryCode { get; set; }

    public string? MainTelephoneNumber { get; set; }

    public string? AlternateTelephoneNumber { get; set; }

    public string? EmailAddress { get; set; }

    public string? PostboxName { get; set; }

    public string? PostboxNumber { get; set; }

    public string? ReferenceType { get; set; }

    public string? Department { get; set; }

    public string? MainTelefaxNumber { get; set; }

    public string? HomepageAddress { get; set; }

    public DateTime? InactiveCreatedDate { get; set; }

    public string? InactiveMadeBy { get; set; }
}
