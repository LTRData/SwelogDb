using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Tax
{
    public string TaxCode { get; set; } = null!;

    public string? TaxName { get; set; }

    public int? TaxNameTxtid { get; set; }

    public string? TaxNameFlag { get; set; }

    public decimal? TaxPercentage { get; set; }

    public string? TaxScheduleIndicator { get; set; }

    public string? AuditStamp { get; set; }

    public string? ReverseVat { get; set; }

    public virtual ICollection<ContractOrderHeader> ContractOrderHeaders { get; } = new List<ContractOrderHeader>();

    public virtual ICollection<Country> CountryCountryStandardVatCode1Navigations { get; } = new List<Country>();

    public virtual ICollection<Country> CountryCountryStandardVatCode2Navigations { get; } = new List<Country>();

    public virtual ICollection<CustomerOrderHeader> CustomerOrderHeaders { get; } = new List<CustomerOrderHeader>();

    public virtual ICollection<Customer> Customers { get; } = new List<Customer>();

    public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; } = new List<PurchaseOrderHeader>();

    public virtual ICollection<SystemParameter> SystemParameters { get; } = new List<SystemParameter>();

    public virtual ICollection<UserDefinedCharge> UserDefinedCharges { get; } = new List<UserDefinedCharge>();
}
