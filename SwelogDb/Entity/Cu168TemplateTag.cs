using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Cu168TemplateTag
{
    public int SerialNumber { get; set; }

    public string? FieldName { get; set; }

    public string? FieldTag { get; set; }

    public bool? BarcodeFlag { get; set; }

    public byte? BarcodeFormat { get; set; }
}
