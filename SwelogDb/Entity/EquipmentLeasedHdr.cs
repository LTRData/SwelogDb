using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EquipmentLeasedHdr
{
    public string CompanyNo { get; set; } = null!;

    public string LeasingNo { get; set; } = null!;

    public string? Description { get; set; }

    public string? SupplierId { get; set; }

    public DateTime? StartDate { get; set; }

    public string? Financier { get; set; }

    public string? ContractNumber { get; set; }

    public decimal? LeasingAmount { get; set; }

    public decimal? EnhancedFee { get; set; }

    public decimal? BalanceAmount { get; set; }

    public int? NoOfPeriods { get; set; }

    public decimal? MonthlyCost { get; set; }

    public string? DepartmentNo { get; set; }

    public DateTime? EndDate { get; set; }

    public string? AuditStamp { get; set; }

    public string? CurrencyCode { get; set; }

    public decimal? LeasingAmountFc { get; set; }

    public short? PaymentFrequency { get; set; }

    public decimal? ExchangeRate { get; set; }

    public string? AccountNo { get; set; }

    public byte? Status { get; set; }

    public virtual ICollection<EquipmentLeasedDtl> EquipmentLeasedDtls { get; } = new List<EquipmentLeasedDtl>();
}
