using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Cu168CasMaster
{
    public string CasNumber { get; set; } = null!;

    public string? SubstanceDescription { get; set; }

    public string? EinecsNo { get; set; }

    public string? IndexNo { get; set; }

    public string? Riskfras { get; set; }

    public string? FaroklassSerialList { get; set; }

    public string? HgvYear { get; set; }

    public string? HgvNgvPpm { get; set; }

    public string? HgvNgvMgm3 { get; set; }

    public string? HgvKgvPpm { get; set; }

    public string? HgvKgvMgm3 { get; set; }

    public string? HgvRemarks { get; set; }

    public string? HgvNotes { get; set; }

    public string? PrioDatabase { get; set; }

    public string? CandidateList { get; set; }

    public string? ReachAnnex14 { get; set; }

    public string? ReachAnnex17 { get; set; }

    public string? AuditStamp { get; set; }
}
