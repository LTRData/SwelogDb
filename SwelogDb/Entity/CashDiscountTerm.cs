using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CashDiscountTerm
{
    public string CashDiscountTerm1 { get; set; } = null!;

    public string? CashDiscountDesc { get; set; }

    public int? CashDiscountDescTxtid { get; set; }

    public string? CashDiscountDescFlag { get; set; }

    public short? CashDiscountDays1 { get; set; }

    public decimal? CashDiscountPercent1 { get; set; }

    public short? CashDiscountDays2 { get; set; }

    public decimal? CashDiscountPercent2 { get; set; }

    public short? CashDiscountDays3 { get; set; }

    public decimal? CashDiscountPercent3 { get; set; }

    public short? CashDiscountDays4 { get; set; }

    public decimal? CashDiscountPercent4 { get; set; }

    public short? CashDiscountDaysIn { get; set; }

    public short? CashDiscountDaysOut { get; set; }

    public string? AuditStamp { get; set; }
}
