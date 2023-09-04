using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TrParameter
{
    public string CompanyId { get; set; } = null!;

    public int? InOutPurgeLimit { get; set; }

    public int? CalendarPurgeLimit { get; set; }

    public string? CompCompensationCode { get; set; }

    public string? CompAbsenceCode { get; set; }

    public string? DontShowCompAtfBalance { get; set; }

    public string? CompenstnBal { get; set; }

    public string? PieceworkWageType { get; set; }

    public string? IncludeUnattestedInBalance { get; set; }

    public string? FlexPlusWageType { get; set; }

    public string? FlexMinusWageType { get; set; }

    public bool? IncludeCodedFlexInFlexTotal { get; set; }

    public string? StopTimeAbsenceCode { get; set; }

    public decimal? CheckoutUndividedTimeLimit { get; set; }
}
