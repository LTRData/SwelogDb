using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Document
{
    public int DocumentLotNumber { get; set; }

    public int? PriorDocumentLotNumber { get; set; }

    public string DocType { get; set; } = null!;

    public string Ref1 { get; set; } = null!;

    public string Ref2 { get; set; } = null!;

    public string Ref3 { get; set; } = null!;

    public string Ref4 { get; set; } = null!;

    public string Ref5 { get; set; } = null!;

    public int DocVersion { get; set; }

    public int? PriorDocVersion { get; set; }

    public string? VersionDesc { get; set; }

    public DateTime? AttestDate { get; set; }

    public string? DocId { get; set; }

    public string? DocVersId { get; set; }

    public string? Editor { get; set; }

    public string? Path { get; set; }

    public string? FilesName { get; set; }

    public string? Fileextension { get; set; }

    public string? SwelogWindow { get; set; }

    public string? SwelogWindowParm { get; set; }

    public string? SwelogKey { get; set; }

    public string? AuditStamp { get; set; }

    public int DocumentId { get; set; }

    public int? PriorDocumentId { get; set; }

    public string? MfgOrderNumber { get; set; }

    public string? MfgOrderItem { get; set; }

    public int? MfgOrderLot { get; set; }
}
