using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DocType
{
    public string DocType1 { get; set; } = null!;

    public string? DocTypeDesc { get; set; }

    public string Ref1 { get; set; } = null!;

    public string Ref2 { get; set; } = null!;

    public string Ref3 { get; set; } = null!;

    public string Ref4 { get; set; } = null!;

    public string Ref5 { get; set; } = null!;

    public string? DocIdTemplate { get; set; }

    public string? DocVersIdTemplate { get; set; }

    public string? PathTemplate { get; set; }

    public string? FilenameTemplate { get; set; }

    public string? FileextensionTemplate { get; set; }

    public string? DefaultEditor { get; set; }

    public string? SwelogWindow { get; set; }

    public string? SwelogWindowParm { get; set; }

    public string? AuditStamp { get; set; }

    public string? DocTemplateFile { get; set; }

    public string? TemplateDocLot { get; set; }
}
