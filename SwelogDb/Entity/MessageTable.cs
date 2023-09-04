using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MessageTable
{
    public string LanguageCode { get; set; } = null!;

    public int MessageCode { get; set; }

    public string? MessageType { get; set; }

    public string? MessageDescription { get; set; }

    public int? MessageTxtid { get; set; }

    public string? MessageFlag { get; set; }

    public string? AuditStamp { get; set; }

    public string? HelpFileName { get; set; }
}
