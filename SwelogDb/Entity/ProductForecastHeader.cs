using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ProductForecastHeader
{
    public string ForecastId { get; set; } = null!;

    public DateTime? RegistrationDate { get; set; }

    public string? OwnDescription { get; set; }

    public string? RegisteredBy { get; set; }

    public byte? MarketIndicator { get; set; }

    public byte? ProductIndicator { get; set; }

    public string? AnnualReqOrWithdrawal { get; set; }

    public string? PriceListId { get; set; }

    public string? CurrencyCode { get; set; }

    public decimal? BudgetRate { get; set; }

    public string? CurrencyYear1 { get; set; }

    public string? AlloyYear1 { get; set; }

    public string? ScrapYear1 { get; set; }

    public string? CurrencyYear2 { get; set; }

    public string? AlloyYear2 { get; set; }

    public string? ScrapYear2 { get; set; }

    public string? CurrencyYear3 { get; set; }

    public string? AlloyYear3 { get; set; }

    public string? ScrapYear3 { get; set; }

    public DateTime? LastCalculationDate { get; set; }

    public short? StartMonthYear1 { get; set; }

    public short? StartMonthYear2 { get; set; }

    public short? StartMonthYear3 { get; set; }

    public string? CustomerId { get; set; }

    public string? BudgetForecastYn { get; set; }
}
