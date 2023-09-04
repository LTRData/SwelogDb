using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TextidTable
{
    public int TextId { get; set; }

    public string LanguageCode { get; set; } = null!;

    public string? ShortText { get; set; }

    public string? LongTextIndicator { get; set; }

    public string? AudioIndicator { get; set; }

    public string? VideoIndicator { get; set; }

    public string? DrawingIndicator { get; set; }

    public string? PictureIndicator { get; set; }

    public string? AudioFilename { get; set; }

    public string? VideoFilename { get; set; }

    public string? DrawingFilename { get; set; }

    public string? PictureFilename { get; set; }

    public string? AuditStamp { get; set; }

    public byte[]? LongTextObject { get; set; }

    public string? ExtraDescription { get; set; }

    public string? DocumentIndicator { get; set; }

    public string? DocumentFilename { get; set; }

    public string? LongTextString { get; set; }

    public bool? DontPrintLongTextOnDelTkt { get; set; }

    public decimal? PictureWhFactor { get; set; }
}
