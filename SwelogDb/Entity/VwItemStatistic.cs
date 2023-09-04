using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwItemStatistic
{
    public string Artikelnr { get; set; } = null!;

    public string? ArtikelBenämning { get; set; }

    public string Kundnr { get; set; } = null!;

    public string? KundNamn { get; set; }

    public string? KundsArtikelnr { get; set; }

    public decimal? Säkerhetslager { get; set; }

    public decimal? PartiStorlek { get; set; }

    public decimal? AntalPerKolli { get; set; }

    public int? LedtidTillKund { get; set; }

    public string? ArtikelStatus { get; set; }

    public string? Packmatrialnr { get; set; }

    public DateTime? SenastUttag { get; set; }

    public decimal? AntalReserv { get; set; }

    public decimal? UttagÅretInnanSistaÅr { get; set; }

    public decimal? UttagSistaÅr { get; set; }

    public decimal? UttagDettaÅr { get; set; }

    public int? SenastReservationVecka { get; set; }

    public int? SenastReservationÅr { get; set; }

    public short? BehovIVeckor { get; set; }

    public string? SatsKod { get; set; }

    public decimal? LagerSaldo { get; set; }
}
