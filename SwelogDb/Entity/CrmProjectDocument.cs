using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CrmProjectDocument
{
    public int DocumentSerialNumber { get; set; }

    public int? ProjectSerialNumber { get; set; }

    public string? DocumentDescription { get; set; }

    public string? DocumentPath { get; set; }

    public string? DocumentFilename { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? TemplateSerialNumber { get; set; }
}
