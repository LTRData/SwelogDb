using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Pfmea
{
    public int IdPfmea { get; set; }

    public int VersionNumber { get; set; }

    public string? ProcessName { get; set; }

    public string? ProcessDescription { get; set; }

    public string? ProcessStatus { get; set; }

    public string? TfqAttest1Yn { get; set; }

    public string? TfqAttest1By { get; set; }

    public DateTime? TfqAttest1Date { get; set; }

    public string? TfqAttest2Yn { get; set; }

    public string? TfqAttest2By { get; set; }

    public DateTime? TfqAttest2Date { get; set; }

    public string? TfqAttest3Yn { get; set; }

    public string? TfqAttest3By { get; set; }

    public DateTime? TfqAttest3Date { get; set; }

    public string? AuditStamp { get; set; }

    public string? MainResponsible { get; set; }

    public int? LinkFuncpiIndex { get; set; }

    public virtual ICollection<PfmeaAction> PfmeaActions { get; } = new List<PfmeaAction>();
}
