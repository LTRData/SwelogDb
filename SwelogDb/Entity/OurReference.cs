using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OurReference
{
    public string OwnerId { get; set; } = null!;

    public string ReferenceId { get; set; } = null!;

    public string? ReferenceName { get; set; }

    public string? ReferenceType { get; set; }

    public string? OrganisationPosition { get; set; }

    public int? OrganisationPositionTxtid { get; set; }

    public string? OrganisationPositionFlag { get; set; }

    public int? MailingAddressNo { get; set; }

    public int? ElectronicAddressNo { get; set; }

    public string? AuditStamp { get; set; }

    public string? Userid { get; set; }

    public string? UpdateSuppInv { get; set; }

    public string? CreateEdiCustomerOrder { get; set; }

    public virtual MailingAddress? MailingAddressNoNavigation { get; set; }

    public virtual ReferenceType? ReferenceTypeNavigation { get; set; }
}
