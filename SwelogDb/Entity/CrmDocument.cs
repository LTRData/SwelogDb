using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CrmDocument
{
    public int DocumentSerialNumber { get; set; }

    public int? CrmMasterSerialNumber { get; set; }

    public string? DocumentDescription { get; set; }

    public string? DocumentPath { get; set; }

    public string? DocumentFilename { get; set; }

    public bool? IsShortcut { get; set; }

    public short? TemplateSerialNumber { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }
}
