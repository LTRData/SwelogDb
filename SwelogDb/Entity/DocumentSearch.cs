using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DocumentSearch
{
    public int SearchId { get; set; }

    public string LanguageCode { get; set; } = null!;

    public string SearchString { get; set; } = null!;

    public int DocumentId { get; set; }

    public string? ModuleId { get; set; }
}
