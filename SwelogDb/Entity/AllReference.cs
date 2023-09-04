using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class AllReference
{
    public string OwnerType { get; set; } = null!;

    public string OwnerId { get; set; } = null!;

    public string ReferenceId { get; set; } = null!;

    public string? ReferenceName { get; set; }

    public int? ReferenceNameTxtid { get; set; }

    public string? ReferenceNameFlag { get; set; }

    public string? OrganisationPosition { get; set; }

    public int? MailingAddressNo { get; set; }

    public int? ElectronicAddressNo { get; set; }

    public string? AuditStamp { get; set; }
}
