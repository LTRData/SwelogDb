using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Equipment
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public string EquipmentSeries { get; set; } = null!;

    public decimal EquipmentNo { get; set; }

    public string? BelongsToEqpSer { get; set; }

    public decimal? BelongsToEqpNo { get; set; }

    public string? Completed { get; set; }

    public string? Description { get; set; }

    public string? Text1 { get; set; }

    public string? Text2 { get; set; }

    public string? Location { get; set; }

    public string? EquipmentTypeNo { get; set; }

    public string? SerialManufNo { get; set; }

    public string? MaintenanceNo { get; set; }

    public string? SupplierNo { get; set; }

    public string? SupplierInvoiceNo { get; set; }

    public DateTime? StartDateWOff { get; set; }

    public DateTime? CompletedWOff { get; set; }

    public DateTime? AcquisitionDate { get; set; }

    public string? NewOrUsed { get; set; }

    public decimal? AcquisitionPrice { get; set; }

    public decimal? ReplacementPrice { get; set; }

    public DateTime? InsuredDate { get; set; }

    public decimal? InsuredValue { get; set; }

    public string? PolicyNo { get; set; }

    public decimal? NoOfWOffYears { get; set; }

    public decimal? EquipDeprYearNo { get; set; }

    public string? WOffType { get; set; }

    public decimal? WOffPercent { get; set; }

    public decimal? WOffAmount { get; set; }

    public DateTime? LastWOffDate { get; set; }

    public decimal? AccuWOffAmount { get; set; }

    public decimal? WOffAmtCurrentYear { get; set; }

    public string? SoldDiscarded { get; set; }

    public DateTime? SoldDiscardedDate { get; set; }

    public decimal? SellingPrice { get; set; }

    public string? InvRejectionNo { get; set; }

    public string? DepartmentNo { get; set; }

    public string? ProductNo { get; set; }

    public string? ProjectNo { get; set; }

    public string? FunctionNo { get; set; }

    public string? ANo { get; set; }

    public string? BNo { get; set; }

    public string? CNo { get; set; }

    public string? DNo { get; set; }

    public string? AccountGroupNo { get; set; }

    public string? AuditStamp { get; set; }

    public string? WOffRule { get; set; }

    public decimal? OpBalCurrentYear { get; set; }

    public decimal? OriginalAcquisitionPrice { get; set; }

    public DateTime? WarrantyEndDate { get; set; }

    public decimal? OpBalPrevYear { get; set; }

    public decimal? AccuOverUnderWOffAmt { get; set; }

    public decimal? AccuOverUnderWOffAmtYr { get; set; }

    public string? VatCode { get; set; }

    public virtual A? A { get; set; }

    public virtual B? B { get; set; }

    public virtual C? C { get; set; }

    public virtual Company CompanyNoNavigation { get; set; } = null!;

    public virtual D? D { get; set; }

    public virtual Department? Department { get; set; }

    public virtual EquipmentType? EquipmentType { get; set; }

    public virtual ICollection<EquipmentWOffAmount> EquipmentWOffAmounts { get; } = new List<EquipmentWOffAmount>();

    public virtual Function? Function { get; set; }

    public virtual Product? Product { get; set; }

    public virtual Project? Project { get; set; }

    public virtual Supplier? SupplierNoNavigation { get; set; }

    public virtual ICollection<TransactionHeader> TransactionHeaders { get; } = new List<TransactionHeader>();
}
