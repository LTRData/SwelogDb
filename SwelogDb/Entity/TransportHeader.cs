using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TransportHeader
{
    public string DeliveryNote { get; set; } = null!;

    public string? FreightNote { get; set; }

    public string? AuditStamp { get; set; }

    public string? TransportMode { get; set; }

    public DateTime? PickupDate { get; set; }

    public string? RecieverMsg { get; set; }

    public string? Advice { get; set; }

    public string? DeliveryInstructions { get; set; }

    public string? DeliveryCondition { get; set; }

    public decimal? DeliveryPrice { get; set; }

    public string? DeliveryCurrency { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public string? TransportPayer { get; set; }

    public decimal? TransportPrice { get; set; }

    public string? TransportCurrency { get; set; }

    public string? AdviceContact { get; set; }

    public string? AdvicePhone { get; set; }

    public string? DeliveryReference { get; set; }

    public string? TransportPayerName { get; set; }

    public string? TransportPayerAddr1 { get; set; }

    public string? TransportPayerAddr2 { get; set; }

    public string? TransportPayerAddr3 { get; set; }

    public string? DeliveryAddressId { get; set; }

    public string? PrintoutNumber { get; set; }

    public string? CustomerSender { get; set; }

    public string? CargoParcel { get; set; }

    public string? FreightPayer { get; set; }

    public string? PalletNumber { get; set; }

    public string? TransportPayerAddr4 { get; set; }

    public string? AdviceFax { get; set; }

    public DateTime? AdviceDate { get; set; }

    public DateTime? AdviceTime { get; set; }

    public DateTime? DeliveryTime { get; set; }

    public string? TransportCompany { get; set; }

    public string? RegisterNo { get; set; }

    public string? CountryCode { get; set; }

    public string? EuTransportMode { get; set; }

    public string? FreightCollectAddress { get; set; }

    public string TransportType { get; set; } = null!;

    public string? AdviceDataManualUpdatedYn { get; set; }

    public string? UnifaunReturnSendingId { get; set; }

    public string? AdviceEmail { get; set; }

    public string? TransportService { get; set; }

    public string? PaidCustomerReturnYn { get; set; }

    public string? CustomerReturnLabelYn { get; set; }

    public string? AdviceEmailYn { get; set; }

    public string? AdviceSmsYn { get; set; }

    public string? AdvicePhoneYn { get; set; }

    public string? AdviceLetterYn { get; set; }

    public string? OrderKey { get; set; }

    public string? DeliveryWoReceiptYn { get; set; }

    public string? UnifaunDeliveryTermCode { get; set; }

    public string? PartnerKey { get; set; }
}
