using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwCu168ProduktSakerhetsDatum
{
    public string Artikelnummer { get; set; } = null!;

    public string? Artikelbenämning { get; set; }

    public string? EanProduktförpacking { get; set; }

    public decimal? AntalPerProduktförp { get; set; }

    public string? EanTransportlåda { get; set; }

    public decimal? AntalPerTranspLåda { get; set; }

    public DateTime? SkapadDatum { get; set; }

    public string? SkapadSignatur { get; set; }

    public DateTime? DataÄndrade { get; set; }

    public string? DataÄndradeSignatur { get; set; }

    public string? GodkTyp { get; set; }

    public string? FargArom { get; set; }

    public byte? Hållbarhet { get; set; }

    public string? Dosering { get; set; }

    public string? DoseringsEnhet { get; set; }

    public string? SpecDosering { get; set; }

    public string? Brandklass { get; set; }

    public string? StatusDeklaration { get; set; }

    public string? Utseende { get; set; }

    public string? AromIngredienser { get; set; }

    public string? ÖvrigaIngredienser { get; set; }

    public string? Ean { get; set; }

    public string? Info { get; set; }

    public string? Smakprofil { get; set; }

    public string? Doft { get; set; }

    public string? UtvecklatFör { get; set; }

    public string? Övrigt { get; set; }

    public string? ÖvrigtEtikett { get; set; }

    public string? ÖvrigtInfoOmProdukten { get; set; }

    public string? ENummer { get; set; }

    public string? Gmo { get; set; }

    public string? Vattenfri { get; set; }

    public string? Spritfri { get; set; }

    public string? Allergideklareras { get; set; }

    public string? AllergiDetaljer { get; set; }

    public string? BenamningEtikett1 { get; set; }

    public string? BenamningEtikett2 { get; set; }

    public string? BenamningEtikett3 { get; set; }

    public string? Refraktometerind { get; set; }

    public string? RefraktometerindTolerans { get; set; }

    public string? Densitet { get; set; }

    public string? DesitetTolerans { get; set; }

    public string? PhVarde { get; set; }

    public string? PhVardeTolerans { get; set; }

    public string? Flampunkt { get; set; }

    public string? PropHalt { get; set; }

    public string? Alkoholhalt { get; set; }

    public string? Riskfras { get; set; }

    public string? Skyddsfras { get; set; }

    public string? Adr { get; set; }

    public string? Kcal { get; set; }

    public string? Kj { get; set; }

    public string? Kolhydrat { get; set; }

    public string? Juicehalt { get; set; }

    public string? Brix { get; set; }

    public string? Sammansättning { get; set; }

    public string? Forvaring { get; set; }

    public string? GammaltReceptNr { get; set; }

    public string? UnNummer { get; set; }

    public string? UnNummerBeskrivning { get; set; }

    public string? Kundnr { get; set; }

    public string? Kundnamn { get; set; }

    public string? Kundensartikelnr { get; set; }

    public string? Artikelextrabenämning { get; set; }

    public string? Produktgrupp { get; set; }

    public string? ProduktgruppBeskrivning { get; set; }

    public string? Lagerenhet { get; set; }

    public string? LagerenhetBeskrivning { get; set; }

    public string? LagerenhetFormat { get; set; }

    public string? Typ { get; set; }

    public string? TypBeskrivning { get; set; }

    public string? Kategori { get; set; }

    public string? KategoriBeskrivning { get; set; }

    public string? Beredningsstatus { get; set; }

    public string? BeredningsstatusBeskrivning { get; set; }

    public string? Marknadsstatus { get; set; }

    public string? MarknadsstatusBeskrivning { get; set; }

    public decimal? Minkvantitet { get; set; }

    public string? Satskod { get; set; }

    public string? SatskodBeskrivning { get; set; }

    public decimal? Satsstorlek { get; set; }

    public string? Lagerställe { get; set; }

    public string? LagerställeBeskrivning { get; set; }

    public string? Lagerplats { get; set; }

    public string? LagerplatsBeskrivning { get; set; }

    public decimal? Vikt { get; set; }

    public string? Viktenhet { get; set; }

    public string? ViktenhetBeskrivning { get; set; }

    public string? ViktFormat { get; set; }

    public string? Statistisknummer { get; set; }

    public decimal? Kostpris { get; set; }

    public string? KostprisFormat { get; set; }

    public decimal? Försäljningspris { get; set; }

    public string? FörsäljningsprisFormat { get; set; }

    public short? Prisenhet { get; set; }

    public string? Datumformat { get; set; }

    public int? Användning { get; set; }

    public string? Ekologisk { get; set; }

    public string? EkologiskStatus { get; set; }

    public string? FärgarSlutprodukt { get; set; }

    public string? LeverantörsNamn { get; set; }

    public string? LeverantörsArtikelnr { get; set; }

    public string? LeverantörsArtikelnamn { get; set; }

    public string? Slutmärkning { get; set; }

    public string? Användaren { get; set; }

    public string? BrixVarde { get; set; }

    public string? BrixVardeTolerans { get; set; }

    public string? Signalord { get; set; }

    public string? KompletterandeFaroinformation { get; set; }

    public string? Mangdbegransade { get; set; }

    public string? Mangdbegransade2 { get; set; }

    public string? Naringsvarden { get; set; }

    public string? Allergi { get; set; }

    public string? Kosher { get; set; }

    public string? GrasInfo { get; set; }

    public string? Mikro { get; set; }

    public string? Vegan { get; set; }

    public string? Applikation { get; set; }

    public DateTime? SäkerhetsdataÄndrade { get; set; }

    public string? SäkerhetsdataÄndradeSignatur { get; set; }
}
