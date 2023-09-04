using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class GeneralTextHeader
{
    public string TextType { get; set; } = null!;

    public string TextKey { get; set; } = null!;

    public string OrderTextId { get; set; } = null!;

    public string LanguageCode { get; set; } = null!;

    public string? TextIndicator { get; set; }

    public byte[]? OrderLongText { get; set; }

    public string? AuditStamp { get; set; }

    public string? DocumentDesc { get; set; }

    public string? IntroductoryText { get; set; }

    public string? FinishingText { get; set; }

    public string? LongText { get; set; }

    public string? EmailText { get; set; }

    public string? PreliminaryCo { get; set; }

    public virtual ICollection<GeneralTextDetail> GeneralTextDetails { get; } = new List<GeneralTextDetail>();
}
