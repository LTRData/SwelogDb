using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Cu168TemplateCreatedDoc
{
    public int SerialNumber { get; set; }

    public string? ItemNumber { get; set; }

    public int? SerialNumberBase { get; set; }

    public string? LanguageCode { get; set; }

    public string? FilePath { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }
}
