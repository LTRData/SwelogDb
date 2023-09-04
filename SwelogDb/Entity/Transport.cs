using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Transport
{
    public string TransportModeCode { get; set; } = null!;

    public string? TransportDescription { get; set; }

    public double? TransportDescTxtid { get; set; }

    public string? TransportDescFlag { get; set; }

    public string? AuditStamp { get; set; }

    public string? TransportContract { get; set; }

    public string? CustomerNo { get; set; }

    public string? GiroNo { get; set; }

    public string? AddressLabel { get; set; }

    public string? ExternalTransportCode { get; set; }

    public string? CountryCode { get; set; }

    public string? UnifaunParid { get; set; }

    public string? CarrierNo { get; set; }

    public string? AutoFreight { get; set; }
}
