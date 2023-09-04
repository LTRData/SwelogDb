using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class AaParameter
{
    public string CompanyNo { get; set; } = null!;

    public string? EquipmentSeries { get; set; }

    public string? TransSeries { get; set; }

    public string? JournalSeries { get; set; }

    public string? BatchSeries { get; set; }

    public string? RoundOff { get; set; }

    public string? UpdtLedgWithTrans { get; set; }

    public DateTime? LastWOffDate { get; set; }

    public string? StdAccountGroup { get; set; }

    public decimal? CurrentYearNo { get; set; }

    public decimal? NoOfDays { get; set; }

    public string? AuditStamp { get; set; }

    public string? CreateAv { get; set; }

    public string? NumberSeriesFromAcquisitionDate { get; set; }

    public string? ShowEquipNoInJournal { get; set; }

    public virtual FinancialYear? C { get; set; }

    public virtual Company CompanyNoNavigation { get; set; } = null!;
}
