using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Cu132InternOrder
{
    public int SerialNumber { get; set; }

    public DateTime? RegisteredDate { get; set; }

    public string? RegisteredBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public string? LastModifiedBy { get; set; }

    public string? CustomerId { get; set; }

    public string? CustomerContactId { get; set; }

    public string? EndCustomerId { get; set; }

    public string? EndContactId { get; set; }

    public string? DeliveryAddressId { get; set; }

    public string? CustomerOrderType { get; set; }

    public string? CustomerOrderNumber { get; set; }

    public string? MachineNumber { get; set; }

    public DateTime? OrderDate { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public decimal? MachineQuantity { get; set; }

    public string? CurrencyCode { get; set; }

    public decimal? SellingPrice { get; set; }

    public short? PriceUnitNum { get; set; }

    public string? PriceUnit { get; set; }

    public string? Installation { get; set; }

    public string? Notes { get; set; }

    public string? OtherNotes { get; set; }

    public string? InternalNotes { get; set; }

    public string? PackagingNotes { get; set; }

    public string? DeliveryTermsCode { get; set; }

    public string? FormatHastighet { get; set; }

    public int? KovaktTyp { get; set; }

    public int? Vantlage { get; set; }

    public string? Layout { get; set; }

    public int? Utmatningsriktning { get; set; }

    public string? Utmatningshojd { get; set; }

    public int? FargMaterial { get; set; }

    public int? Pneumatik { get; set; }

    public int? Linjarenhet { get; set; }

    public int? Applikator { get; set; }

    public int? Dispenser { get; set; }

    public int? TapeKontroll { get; set; }

    public int? Huvudspanning { get; set; }

    public int? Manoverspanning { get; set; }

    public int? Plc { get; set; }

    public int? Operatorspanel { get; set; }

    public int? LagArkniva { get; set; }

    public int? Matarmagasin { get; set; }

    public string? ManualLanguageCode { get; set; }

    public string? ElRegNr { get; set; }

    public string? PlcRegNr { get; set; }

    public string? ManualRegNr { get; set; }

    public string? OpTermRegNr { get; set; }

    public string? ManualInfo { get; set; }

    public int? MaskinTyp { get; set; }

    public string? Fat { get; set; }
}
