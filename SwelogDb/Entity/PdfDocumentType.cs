using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PdfDocumentType
{
    public int SerialNumber { get; set; }

    public string DocumentType { get; set; } = null!;

    public string? LanguageCode { get; set; }

    public string? DocumentDescription { get; set; }
}
