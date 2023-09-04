using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class RptUtlevHeaderOutput
{
    public int SerialNumberIdentity { get; set; }

    public DateTime? ProcessDatetime { get; set; }

    public int? PageNumber { get; set; }

    public string? TextOnLine { get; set; }

    public string? Order01 { get; set; }

    public string? Order02 { get; set; }

    public string? Order03 { get; set; }

    public string? Order04 { get; set; }

    public string? Order05 { get; set; }

    public string? Order06 { get; set; }

    public string? OrderNumbersInPage { get; set; }

    public string? DeliveryDatesInPage { get; set; }
}
