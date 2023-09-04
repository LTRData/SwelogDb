using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Language
{
    public string LanguageCode { get; set; } = null!;

    public string? LanguageDescription { get; set; }

    public int? LanguageTxtid { get; set; }

    public string? LanguageFlag { get; set; }

    public string? AuditStamp { get; set; }

    public bool? UnicodeFlag { get; set; }

    public virtual ICollection<AccountText> AccountTexts { get; } = new List<AccountText>();

    public virtual ICollection<ContractOrderHeader> ContractOrderHeaders { get; } = new List<ContractOrderHeader>();

    public virtual ICollection<Country> Countries { get; } = new List<Country>();

    public virtual ICollection<CustomerOrderHeader> CustomerOrderHeaders { get; } = new List<CustomerOrderHeader>();

    public virtual ICollection<Customer> Customers { get; } = new List<Customer>();

    public virtual ICollection<DemandText> DemandTexts { get; } = new List<DemandText>();

    public virtual ICollection<IntInvText> IntInvTexts { get; } = new List<IntInvText>();

    public virtual ICollection<InvFooterRefText> InvFooterRefTexts { get; } = new List<InvFooterRefText>();

    public virtual ICollection<PayDemandCategory> PayDemandCategories { get; } = new List<PayDemandCategory>();

    public virtual ICollection<PaymentMode> PaymentModes { get; } = new List<PaymentMode>();

    public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; } = new List<PurchaseOrderHeader>();

    public virtual ICollection<Supplier> Suppliers { get; } = new List<Supplier>();

    public virtual ICollection<TextTable> TextTables { get; } = new List<TextTable>();
}
