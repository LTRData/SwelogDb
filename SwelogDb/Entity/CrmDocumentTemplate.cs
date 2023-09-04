using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CrmDocumentTemplate
{
    public short TemplateSerialNumber { get; set; }

    public string? TemplateShortDescription { get; set; }

    public string? TemplatePath { get; set; }

    public string? TemplateFilename { get; set; }

    public string? TemplateLongDescription { get; set; }

    public string? TemplateIconFilename { get; set; }

    public string? OutputFolderName { get; set; }
}
