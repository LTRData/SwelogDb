using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwCrmDocument
{
    public string DocumentType { get; set; } = null!;

    public int DocumentSerialNumber { get; set; }

    public string? DocumentDescription { get; set; }

    public string? DocumentPath { get; set; }

    public string? DocumentFilename { get; set; }

    public int? CrmMasterSerialNumber { get; set; }

    public int? IsShortcut { get; set; }

    public int? TemplateSerialNumber { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? SourceSerialNumber { get; set; }
}
