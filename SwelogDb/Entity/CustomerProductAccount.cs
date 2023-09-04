using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CustomerProductAccount
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public decimal RecordNumber { get; set; }

    public string? CountryGroupCode { get; set; }

    public string? ProductAccountCode { get; set; }

    public string? CustomerAccountCode { get; set; }

    public string? ProductGroupCode { get; set; }

    public string? ExpenseAccountCode { get; set; }

    public string? StockAccountCode { get; set; }

    public string? SalesAccountCode { get; set; }

    public string? ReceivableAccountCode { get; set; }

    public string? AcontoAccountCode { get; set; }

    public string? DiscountAccountCode { get; set; }

    public string? FreightAccountCode { get; set; }

    public string? PackagingAccountCode { get; set; }

    public string? PostalAccountCode { get; set; }

    public string? PostalTaxAccountCode { get; set; }

    public string? TaxCode { get; set; }

    public string? AdminChargeCode { get; set; }

    public string? AuditStamp { get; set; }
}
