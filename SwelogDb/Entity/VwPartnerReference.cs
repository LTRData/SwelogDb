using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwPartnerReference
{
    public string PartnerType { get; set; } = null!;

    public string? PartnerKey { get; set; }

    public string? PartnerReferenceKey { get; set; }

    public string PartnerId { get; set; } = null!;

    public string ReferenceId { get; set; } = null!;

    public string? ReferenceName { get; set; }

    public string? ReferenceType { get; set; }

    public string? OrganisationPosition { get; set; }

    public int? OrganisationPositionTxtid { get; set; }

    public string? OrganisationPositionFlag { get; set; }

    public int? MailingAddressNo { get; set; }

    public int? ElectronicAddressNo { get; set; }

    public string? AuditStamp { get; set; }

    public string? Active { get; set; }
}
