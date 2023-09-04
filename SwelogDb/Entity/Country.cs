using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Country
{
    public string CountryCode { get; set; } = null!;

    public string? EuCountryCode { get; set; }

    public string? CountryName { get; set; }

    public int? CountryNameTxtid { get; set; }

    public string? CountryNameFlag { get; set; }

    public string? CountryIsoCode { get; set; }

    public string? CountryIsdCode { get; set; }

    public string? DateFormat { get; set; }

    public string? CurrencyFormat { get; set; }

    public DateTime? Zone1TimeDiff { get; set; }

    public string? Zone1LagLeadIndicator { get; set; }

    public string? Zone1Description { get; set; }

    public int? Zone1Txtid { get; set; }

    public string? Zone1Flag { get; set; }

    public DateTime? Zone2TimeDiff { get; set; }

    public string? Zone2LagLeadIndicator { get; set; }

    public string? Zone2Description { get; set; }

    public int? Zone2Txtid { get; set; }

    public string? Zone2Flag { get; set; }

    public DateTime? Zone3TimeDiff { get; set; }

    public string? Zone3LagLeadIndicator { get; set; }

    public string? Zone3Description { get; set; }

    public int? Zone3Txtid { get; set; }

    public string? Zone3Flag { get; set; }

    public DateTime? Zone4TimeDiff { get; set; }

    public string? Zone4LagLeadIndicator { get; set; }

    public string? Zone4Description { get; set; }

    public int? Zone4Txtid { get; set; }

    public string? Zone4Flag { get; set; }

    public string? CountryAddrStructure { get; set; }

    public string? CountryPostBoxName { get; set; }

    public short? CountryPostCodeLength { get; set; }

    public string? CountryCurrencyCode { get; set; }

    public string? CountryBusinessLangCode { get; set; }

    public string? CountryStandardVatCode1 { get; set; }

    public string? CountryStandardVatCode2 { get; set; }

    public string? AuditStamp { get; set; }

    public string? CountryGroupCode { get; set; }

    public string? CountryCodeNumeric { get; set; }

    public string? CountryLabelLangCode { get; set; }

    public virtual ICollection<ChangeItem> ChangeItems { get; } = new List<ChangeItem>();

    public virtual Language? CountryBusinessLangCodeNavigation { get; set; }

    public virtual CurrencyTable? CountryCurrencyCodeNavigation { get; set; }

    public virtual Tax? CountryStandardVatCode1Navigation { get; set; }

    public virtual Tax? CountryStandardVatCode2Navigation { get; set; }

    public virtual ICollection<Item> Items { get; } = new List<Item>();

    public virtual ICollection<MailingAddress> MailingAddresses { get; } = new List<MailingAddress>();

    public virtual ICollection<SystemParameter> SystemParameters { get; } = new List<SystemParameter>();
}
