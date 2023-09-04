using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CustomerCreditSgFinan
{
    public string? S1Transaksjonstype { get; set; }

    public string S2DebitorNr { get; set; } = null!;

    public string? S3DebitorNavn { get; set; }

    public string? S4GjennomsnKredittid { get; set; }

    public string? S5SaldoTotalt { get; set; }

    public string? S6FortegnskodeForFeltS5 { get; set; }

    public string? S7SaldoIkkeForfallt { get; set; }

    public string? S8FortegnskodeForFeltS7 { get; set; }

    public string? S9SaldoForfaltMed115Dager { get; set; }

    public string? S10FortegnskodeForFeltS9 { get; set; }

    public string? S11SaldoForfaltMed1630Dager { get; set; }

    public string? S12FortegnskodeForFeltS11 { get; set; }

    public string? S13SaldoForfaltMed3160Dager { get; set; }

    public string? S14FortegnskodeForFeltS13 { get; set; }

    public string? S15SaldoForfaltMed6190Dager { get; set; }

    public string? S16FortegnskodeForFeltS15 { get; set; }

    public string? S17SaldoForfaltOver90Dager { get; set; }

    public string? S18FortegnskodeForFeltS17 { get; set; }

    public string? S19GjSnittBetalningstid { get; set; }

    public string? S20Kredittlimit { get; set; }

    public string? S21Sperrekode { get; set; }

    public string? S22SistePurredato { get; set; }

    public string? S23AntallP3 { get; set; }

    public string? S24AntallInkasso { get; set; }

    public string? S25Kredittrating { get; set; }

    public string? AuditStamp { get; set; }
}
