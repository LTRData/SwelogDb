using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CrmMaster
{
    public int SerialNumber { get; set; }

    public string? CrmId { get; set; }

    public string? CrmName { get; set; }

    public string? CrmKey { get; set; }

    public string? SearchId { get; set; }

    public string? CrmTypeCode { get; set; }

    public string? CrmBranchCode { get; set; }

    public string? CrmCategoryCode1 { get; set; }

    public string? CrmCategoryCode2 { get; set; }

    public string? CrmCategoryCode3 { get; set; }

    public string? CrmCategoryCode4 { get; set; }

    public string? CrmCategoryCode5 { get; set; }

    public string? OurReference { get; set; }

    public string? HouseNumber { get; set; }

    public string? Street { get; set; }

    public string? ExtraLineForStreet { get; set; }

    public string? City { get; set; }

    public string? StateCode { get; set; }

    public string? ZipCode { get; set; }

    public string? CountryCode { get; set; }

    public string? MainTelephoneNumber { get; set; }

    public string? MainTelefaxNumber { get; set; }

    public string? EmailAddress { get; set; }

    public string? HomepageAddress { get; set; }

    public string? OrganizationNumber { get; set; }

    public string? PostboxName { get; set; }

    public string? PostboxNumber { get; set; }

    public string? WatchOutFlag { get; set; }

    public string? CategoryCode { get; set; }

    public string? SalesmanCode { get; set; }

    public string? FreeText { get; set; }

    public string? ClassCode { get; set; }

    public decimal? Grade { get; set; }

    public string? PriorityCode { get; set; }

    public int? PictureSerialNumber { get; set; }

    public string? MarketCode { get; set; }

    public string? CustomersDepartments { get; set; }

    public string? CrmNameExtra { get; set; }

    public string? CrmStatus { get; set; }

    public string? TerritoryCode { get; set; }

    public decimal? CustomerCreditLimit1 { get; set; }

    public string? PurchaseRequestFlag { get; set; }

    public string? VatRegistrationNumber2 { get; set; }

    public string? PaymentTermCustInvoice { get; set; }

    public string? Emcs { get; set; }

    public string? PalletLabel { get; set; }

    public virtual Territory? TerritoryCodeNavigation { get; set; }
}
