using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Supplier
{
    public string SupplierId { get; set; } = null!;

    public string? SupplierName { get; set; }

    public int? SupplierNameTxtid { get; set; }

    public string? SupplierNameFlag { get; set; }

    public string? SupplierStatusCode { get; set; }

    public string? SupplierKey { get; set; }

    public string? SupplierSearchId { get; set; }

    public string? SupplierCategoryCode { get; set; }

    public string? SupplierClassCode { get; set; }

    public decimal? SupplierGrade { get; set; }

    public decimal? SupplierCreditLimit1 { get; set; }

    public decimal? SupplierCreditLimit2 { get; set; }

    public decimal? SupplierCreditLimit3 { get; set; }

    public decimal? SupplierCreditLimit4 { get; set; }

    public int? SuppMailingAddressNo { get; set; }

    public int? SuppElectronicAddressNo { get; set; }

    public string? OurReference { get; set; }

    public string? GoodsReference { get; set; }

    public string? InvoiceReference { get; set; }

    public string? SupplierReference { get; set; }

    public string? LanguageCode { get; set; }

    public string? CurrencyCode { get; set; }

    public string? EuCountryCode { get; set; }

    public string? EuLabourCode { get; set; }

    public string? VatRegistrationNumber { get; set; }

    public string? SupplierImportStatus { get; set; }

    public string? SuppDiscountGroupCode { get; set; }

    public decimal? DiscountPercentile { get; set; }

    public string? SupplierAccountCode { get; set; }

    public short? TransportTimeInDays { get; set; }

    public short? DeliveryTimeInDays { get; set; }

    public short? EarlyDeliveryDaysSupp { get; set; }

    public short? LateDeliveryDaysSupp { get; set; }

    public string? SupplierFactoring { get; set; }

    public string? SupplierToFactor { get; set; }

    public string? PaymentTermSuppInvoice { get; set; }

    public string? PaymentTermSuppIntInvoice { get; set; }

    public string? FreightTerms { get; set; }

    public string? SupplierCustomerNumber { get; set; }

    public string? ModeOfPayment { get; set; }

    public string? SupplierDeliveryAddressId { get; set; }

    public string? DeliveryTermsCode { get; set; }

    public string? TransportModeCode { get; set; }

    public string? EuTransportModeCode { get; set; }

    public decimal? SupplierOwnMark { get; set; }

    public string? DateFormat { get; set; }

    public DateTime? LastPurchaseDate { get; set; }

    public decimal? SupplierDebtAmount { get; set; }

    public decimal? PurchaseCurrentPeriod { get; set; }

    public decimal? PurchaseCurrentYear { get; set; }

    public decimal? LastYearTotalPurValue { get; set; }

    public decimal? PurchaseForLastYear { get; set; }

    public short? NoOfRegisteredInvoices { get; set; }

    public string? BankGiroService { get; set; }

    public string? PostalGiroService { get; set; }

    public string? SuppBankAccountForeignPay { get; set; }

    public string? Tk3pos74Lvt { get; set; }

    public string? Tk3pos78Lvt { get; set; }

    public string? Tk3pos79Lvt { get; set; }

    public string? Tk3pos80Lvt { get; set; }

    public string? Tk5pos65Lvt { get; set; }

    public string? Tk6pos65Lvt { get; set; }

    public string? Tk6pos80Lvt { get; set; }

    public string? AuditStamp { get; set; }

    public string? OrderTemplateId { get; set; }

    public decimal? VatPercentage { get; set; }

    public decimal? DelayIntPerc { get; set; }

    public short? PeriodNoOfInv { get; set; }

    public short? PeriodNoOfPaidInv { get; set; }

    public decimal? PeriodBuyAmount { get; set; }

    public short? PeriodNoOfDueDates { get; set; }

    public short? PeriodNoOfPayDates { get; set; }

    public decimal? PeriodInvIntAmt { get; set; }

    public short? NextPrdNoOfInv { get; set; }

    public short? NextPrdNoOfPaidInv { get; set; }

    public decimal? NextPrdBuyAmount { get; set; }

    public short? NextPrdNoOfDueDates { get; set; }

    public short? NextPrdNoOfPayDates { get; set; }

    public decimal? NextPrdInvIntAmt { get; set; }

    public short? LastYrNoOfInv { get; set; }

    public short? LastYrNoOfPaidInv { get; set; }

    public decimal? LastYrBuyAmount { get; set; }

    public short? LastYrNoOfDueDates { get; set; }

    public short? LastYrNoOfPayDates { get; set; }

    public decimal? LastYrNoInvIntAmt { get; set; }

    public short? YrBefLastNoOfInv { get; set; }

    public short? YrBefLastNoOfPaidInv { get; set; }

    public decimal? YrBefLastBuyAmount { get; set; }

    public short? YrBefLastOfDueDates { get; set; }

    public short? YrBefLastOfPayDates { get; set; }

    public decimal? YrBefLastInvIntAmt { get; set; }

    public short? ThisYrNoOfInv { get; set; }

    public short? ThisYrNoOfPaidInv { get; set; }

    public decimal? ThisYrBuyAmount { get; set; }

    public short? ThisYrOfDueDates { get; set; }

    public short? ThisYrOfPayDates { get; set; }

    public decimal? ThisYrInvIntAmt { get; set; }

    public DateTime? LastPaymentDate { get; set; }

    public decimal? CreditAmount { get; set; }

    public string? BankCode { get; set; }

    public string? SuppCodeOfBank { get; set; }

    public string? Tk7pos15Lvt { get; set; }

    public decimal? ReceivingId { get; set; }

    public string? OurCustNoAtSupplier { get; set; }

    public string? OrderConfirmationFlag { get; set; }

    public string? PersonNo { get; set; }

    public string? GradeAttributeScheme { get; set; }

    public string? PayBankgiroViaPostgiro { get; set; }

    public string? ActivateVmi { get; set; }

    public byte? PreferredDeliveryDay { get; set; }

    public string? FreeText { get; set; }

    public string? PayPostgiroViaBankgiro { get; set; }

    public string? VatCode { get; set; }

    public string? BankAccountNo { get; set; }

    public string? PackmatLocation { get; set; }

    public string? GradingText { get; set; }

    public string? ChangePriceInOrderAndInv { get; set; }

    public string? InternalGradingText { get; set; }

    public string? AttestCode { get; set; }

    public DateTime? LastChangedDate { get; set; }

    public string? LastChangedBy { get; set; }

    public string? ResourceNo { get; set; }

    public string? PurchaseRequestFlag { get; set; }

    public string? VatRegistrationNumber2 { get; set; }

    public string? PrelCostAccountNoSupp { get; set; }

    public string? MultipleInvPostsInSepa { get; set; }

    public string? Automotive { get; set; }

    public string? NotPublic { get; set; }

    public virtual ICollection<ChangeItemSupplier> ChangeItemSuppliers { get; } = new List<ChangeItemSupplier>();

    public virtual ICollection<ChangeItem> ChangeItems { get; } = new List<ChangeItem>();

    public virtual ICollection<ChangeSupplierItem> ChangeSupplierItems { get; } = new List<ChangeSupplierItem>();

    public virtual CurrencyTable? CurrencyCodeNavigation { get; set; }

    public virtual DeliveryTerm? DeliveryTermsCodeNavigation { get; set; }

    public virtual ICollection<Equipment> Equipment { get; } = new List<Equipment>();

    public virtual EuTransportCode? EuTransportModeCodeNavigation { get; set; }

    public virtual FreightTerm? FreightTermsNavigation { get; set; }

    public virtual ICollection<ItemSupplierText> ItemSupplierTexts { get; } = new List<ItemSupplierText>();

    public virtual ICollection<ItemSupplier> ItemSuppliers { get; } = new List<ItemSupplier>();

    public virtual ICollection<Item> Items { get; } = new List<Item>();

    public virtual Language? LanguageCodeNavigation { get; set; }

    public virtual PaymentMode? ModeOfPaymentNavigation { get; set; }

    public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; } = new List<PurchaseOrderHeader>();

    public virtual SupplierDiscountGroup? SuppDiscountGroupCodeNavigation { get; set; }

    public virtual ElectronicAddress? SuppElectronicAddressNoNavigation { get; set; }

    public virtual ICollection<SuppInvHdrDummyFa> SuppInvHdrDummyFas { get; } = new List<SuppInvHdrDummyFa>();

    public virtual ICollection<SuppInvHdr> SuppInvHdrs { get; } = new List<SuppInvHdr>();

    public virtual ICollection<SuppInvPay> SuppInvPays { get; } = new List<SuppInvPay>();

    public virtual MailingAddress? SuppMailingAddressNoNavigation { get; set; }

    public virtual ICollection<SupplierAssessment> SupplierAssessments { get; } = new List<SupplierAssessment>();

    public virtual SupplierCategory? SupplierCategoryCodeNavigation { get; set; }

    public virtual ICollection<SupplierItem> SupplierItems { get; } = new List<SupplierItem>();

    public virtual ICollection<SupplierReference> SupplierReferences { get; } = new List<SupplierReference>();

    public virtual ICollection<SupplierStatistic> SupplierStatistics { get; } = new List<SupplierStatistic>();

    public virtual SupplierStatus? SupplierStatusCodeNavigation { get; set; }
}
