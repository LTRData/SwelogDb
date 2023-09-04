using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CustInvoiceHdr
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public string InvoiceType { get; set; } = null!;

    public string InvoiceSeries { get; set; } = null!;

    public decimal InvoiceNo { get; set; }

    public string? InvoiceSeriesRefToCredit { get; set; }

    public decimal? InvoiceNoRefToCredit { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public DateTime? DueDate { get; set; }

    public string? CustomerNo { get; set; }

    public string? InvoicePaymentTerm { get; set; }

    public string? DeliveryTermsCode { get; set; }

    public string? TransportModeCode { get; set; }

    public string? YourReference { get; set; }

    public string? YourOrderNo { get; set; }

    public string? OurReference { get; set; }

    public string? OrderType { get; set; }

    public string? OrderNumber { get; set; }

    public DateTime? OrderDate { get; set; }

    public string? DeliveryNoteNumber { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public decimal? VatPercentage { get; set; }

    public decimal? DisPercentage { get; set; }

    public string? CurrencyCode { get; set; }

    public decimal? OriginalRate { get; set; }

    public decimal? InvAmtFc { get; set; }

    public decimal? InvAmtBc { get; set; }

    public decimal? VatAmtFc { get; set; }

    public decimal? VatAmtBc { get; set; }

    public decimal? DisAmtFc { get; set; }

    public decimal? DisAmtBc { get; set; }

    public decimal? FreightAmtFc { get; set; }

    public decimal? FreightAmtBc { get; set; }

    public decimal? PackingAmtFc { get; set; }

    public decimal? PackingAmtBc { get; set; }

    public decimal? PostalAmtFc { get; set; }

    public decimal? PostalAmtBc { get; set; }

    public decimal? AdminAmtFc { get; set; }

    public decimal? AdminAmtBc { get; set; }

    public decimal? RoundingAmtFc { get; set; }

    public decimal? RoundingAmtBc { get; set; }

    public decimal? NetInvAmtFc { get; set; }

    public decimal? NetInvAmtBc { get; set; }

    public string? Printed { get; set; }

    public string? Transferred { get; set; }

    public string? Active { get; set; }

    public string? TransferredToAr { get; set; }

    public string? TransferredInvStatistics { get; set; }

    public string? SalesmanCode { get; set; }

    public string? MarketCode { get; set; }

    public string? TerritoryCode { get; set; }

    public string? CountryGroupCode { get; set; }

    public string? CustomerAccountCode { get; set; }

    public int? MailingAddrNo { get; set; }

    public int? ElectronicAddrNo { get; set; }

    public int? DelMailingAddrNo { get; set; }

    public int? DelElectronicAddrNo { get; set; }

    public string? LanguageCode { get; set; }

    public string? FreightTerms { get; set; }

    public string? GoodsReference { get; set; }

    public string? PartnerToFactor { get; set; }

    public string? DateFormat { get; set; }

    public string? AuditStamp { get; set; }

    public string? GoodsMarking { get; set; }

    public decimal? AcontoOrderAmtFc { get; set; }

    public decimal? AcontoInvoicedAmtFc { get; set; }

    public string? VatCode { get; set; }

    public string? PayMode { get; set; }

    public decimal? DelayIntPerc { get; set; }

    public string? ProjectNo { get; set; }

    public string? FreeDeliveryMonthFlag { get; set; }

    public string? EuLabourCode { get; set; }

    public string? EuTransportModeCode { get; set; }

    public string? Text { get; set; }

    public decimal? PortNo { get; set; }

    public string? FreightType { get; set; }

    public string? WaybillNo { get; set; }

    public DateTime? WaybillDate { get; set; }

    public string? Vessel { get; set; }

    public decimal? DisAmtFcTot { get; set; }

    public decimal? DisAmtBcTot { get; set; }

    public string? WhichType { get; set; }

    public string? OeTemplateId { get; set; }

    public string? TransferredToShb { get; set; }

    public string? Deleted { get; set; }

    public string? CustomerName { get; set; }

    public string? OcrNo { get; set; }

    public string? InvFooterRefTextId { get; set; }

    public string? CustInvReceiverName { get; set; }

    public string? CustInvReceiverNameExtra { get; set; }

    public string? CurrencyCode2 { get; set; }

    public decimal? ExchangeRate2 { get; set; }

    public decimal? DisAmtFcDc { get; set; }

    public decimal? DisAmtFcTotDc { get; set; }

    public decimal? RoundingAmtFcDc { get; set; }

    public decimal? NetInvAmtFcDc { get; set; }

    public string? YourInvoiceNo { get; set; }

    public decimal? CashDisPercentage { get; set; }

    public int? CashDisDays { get; set; }

    public DateTime? CashDisDate { get; set; }

    public string? TransferredToSgf { get; set; }

    public string? ReturnFromCust { get; set; }

    public string? TransferredToEdi { get; set; }

    public string? TransferredToNf { get; set; }

    public string? EdiWorkflowRefIc1 { get; set; }

    public string? EdiAccountPd1 { get; set; }

    public string? EdiPurchaserPd2 { get; set; }

    public string? EdiRefNr1 { get; set; }

    public string? EdiRefNr2 { get; set; }

    public string? VatInvoiceNo { get; set; }

    public virtual Company CompanyNoNavigation { get; set; } = null!;

    public virtual CurrencyTable? CurrencyCodeNavigation { get; set; }

    public virtual ICollection<CustInvoiceDtlCodeStr> CustInvoiceDtlCodeStrs { get; } = new List<CustInvoiceDtlCodeStr>();

    public virtual ICollection<CustInvoiceDtl> CustInvoiceDtls { get; } = new List<CustInvoiceDtl>();

    public virtual DeliveryTerm? DeliveryTermsCodeNavigation { get; set; }

    public virtual FreightTerm? FreightTermsNavigation { get; set; }

    public virtual InvoicePaymentTerm? InvoicePaymentTermNavigation { get; set; }

    public virtual Market? MarketCodeNavigation { get; set; }

    public virtual Project? Project { get; set; }

    public virtual Salesman? SalesmanCodeNavigation { get; set; }

    public virtual Territory? TerritoryCodeNavigation { get; set; }
}
