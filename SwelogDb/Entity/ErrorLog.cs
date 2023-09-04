using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ErrorLog
{
    public int IdErrorLog { get; set; }

    public DateTime? ErrorDatetime { get; set; }

    public int? ErrorNumber { get; set; }

    public int? ErrorSeverity { get; set; }

    public int? ErrorState { get; set; }

    public string? ErrorProcedure { get; set; }

    public int? ErrorLine { get; set; }

    public string? ErrorMessage { get; set; }

    public string? ProgramLog { get; set; }

    public int? Spid { get; set; }

    public string? OrigArchive { get; set; }

    public int? OrigIdErrorLog { get; set; }
}
