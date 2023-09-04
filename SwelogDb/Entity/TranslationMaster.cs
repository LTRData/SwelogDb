using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TranslationMaster
{
    public string LanguageCode { get; set; } = null!;

    public string PrimaryObject { get; set; } = null!;

    public string SecondaryObject { get; set; } = null!;

    public string? TranslatedText { get; set; }

    public DateTime? TranslationDate { get; set; }

    public string? Classname { get; set; }

    public int? WindowIdentity { get; set; }
}
