using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CodeStrLangTextsGroup
{
    public short TextId { get; set; }

    public string GroupId { get; set; } = null!;

    public string LangCode { get; set; } = null!;

    public string? GroupText { get; set; }
}
