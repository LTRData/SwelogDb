using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Cu168ProduktSakerhetsDatum
{
    public string ItemNumber { get; set; } = null!;

    public DateTime? SkapadDatum { get; set; }

    public string? SkapadSignatur { get; set; }

    public int? GodkTyp { get; set; }

    public int? FargArom { get; set; }

    public byte? Hallbarhet { get; set; }

    public string? Dosering { get; set; }

    public int? DoseringsEnhet { get; set; }

    public string? SpecDosering { get; set; }

    public int? StatusDeklaration { get; set; }

    public string? Utseende { get; set; }

    public string? AromIngredienser { get; set; }

    public string? OvrigaIngredienser { get; set; }

    public string? Ean { get; set; }

    public int? Info { get; set; }

    public string? Smakprofil { get; set; }

    public string? Doft { get; set; }

    public string? UtveckatFor { get; set; }

    public string? Ovrigt { get; set; }

    public string? OvrigtEtikett { get; set; }

    public string? OvrigtInfoOmProdukten { get; set; }

    public string? ENummer { get; set; }

    public string? Gmo { get; set; }

    public string? Vattenfri { get; set; }

    public string? Spritfri { get; set; }

    public string? Allergideklareras { get; set; }

    public string? AllergiDetaljer { get; set; }

    public string? BenamningEtikett1 { get; set; }

    public string? BenamningEtikett2 { get; set; }

    public string? BenamningEtikett3 { get; set; }

    public DateTime? SistaAndringsDatum { get; set; }

    public string? SistaAndringsSignatur { get; set; }

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

    public int? Adr { get; set; }

    public string? Kcal { get; set; }

    public string? Kj { get; set; }

    public string? Kolhydrat { get; set; }

    public string? Juicehalt { get; set; }

    public string? Brix { get; set; }

    public string? Sammansattning { get; set; }

    public int? Forvaring { get; set; }

    public string? GammaltReceptNr { get; set; }

    public int? UnNummer { get; set; }

    public int? Anvandning { get; set; }

    public string? Ekologisk { get; set; }

    public string? FargarSlutprodukt { get; set; }

    public string? Applikation { get; set; }

    public string? Slutmarkning { get; set; }

    public int? Brandklass { get; set; }

    public string? BrixVarde { get; set; }

    public string? BrixVardeTolerans { get; set; }

    public int? Signalord { get; set; }

    public string? KompletterandeFaroinformation { get; set; }

    public string? ENummerVarde { get; set; }

    public string? Mangdbegransade { get; set; }

    public string? MangdbegransadeVarde { get; set; }

    public string? Naringsvarden { get; set; }

    public string? NaringsvardenVarde { get; set; }

    public string? MangdbegransadeBeskrivning { get; set; }

    public string? NaringsvardenBeskrivning { get; set; }

    public string? AllergiDetaljerVarde { get; set; }

    public int? TemplateSerialNumber { get; set; }

    public string? Mangdbegransade2 { get; set; }

    public string? MangdbegransadeVarde2 { get; set; }

    public string? MangdbegransadeBeskrivning2 { get; set; }

    public string? Kosher { get; set; }

    public int? PdTemplateSerialNumber { get; set; }

    public bool? FastAlkoholhalt { get; set; }

    public DateTime? SistaAutoAndringsDatum { get; set; }

    public bool? FastNaringsvarde { get; set; }

    public string? GrasInfo { get; set; }

    public string? Mikro { get; set; }

    public string? Vegan { get; set; }

    public DateTime? SakerhetsdataAndringsDatum { get; set; }

    public string? SakehetsdataAndringsSignatur { get; set; }

    public string? FysikaliskForm { get; set; }

    public DateTime? SdsSenastReviderat { get; set; }

    public string? SdsKravsEj { get; set; }

    public string? FaroklassSerialList { get; set; }

    public int? EkologiskStatus { get; set; }
}
