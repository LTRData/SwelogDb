using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ElementLangDependentExtn
{
    public int ElementNo { get; set; }

    public string LanguageCode { get; set; } = null!;

    public string? UsualElementName { get; set; }

    public string? ElementInputFormat { get; set; }

    public string? ElementDisplayFormat { get; set; }

    public string? ElementReportHeading { get; set; }

    public int? ElementReportHeadingWidth { get; set; }

    public string? ElementScreenLabel { get; set; }

    public int? ElementScreenLabelWidth { get; set; }

    public string? ElementMicrohelp { get; set; }

    public string? ElementComputedHeading { get; set; }

    public string? AuditStamp { get; set; }
}
