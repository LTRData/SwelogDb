using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TransactionDetail
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public string TransSeries { get; set; } = null!;

    public decimal TransNo { get; set; }

    public decimal LineNo { get; set; }

    public DateTime? TransDate { get; set; }

    public string? WriteOffCode { get; set; }

    public string? AccountNo { get; set; }

    public string? DepartmentNo { get; set; }

    public string? ProductNo { get; set; }

    public string? ProjectNo { get; set; }

    public string? FunctionNo { get; set; }

    public string? ANo { get; set; }

    public string? BNo { get; set; }

    public string? CNo { get; set; }

    public string? DNo { get; set; }

    public decimal? Amount { get; set; }

    public string? Text { get; set; }

    public string? Transferred { get; set; }

    public decimal? TransferJnlYearNo { get; set; }

    public string? TransferJnlSeries { get; set; }

    public decimal? TransferJnlVoucherNo { get; set; }

    public string? AccountJnlSeries { get; set; }

    public decimal? AccountJnlVouchNo { get; set; }

    public string? AuditStamp { get; set; }

    public string? Text2 { get; set; }

    public string? VatCode { get; set; }

    public virtual A? A { get; set; }

    public virtual Account? Account { get; set; }

    public virtual B? B { get; set; }

    public virtual C? C { get; set; }

    public virtual D? D { get; set; }

    public virtual Department? Department { get; set; }

    public virtual Function? Function { get; set; }

    public virtual Product? Product { get; set; }

    public virtual Project? Project { get; set; }

    public virtual TransactionHeader TransactionHeader { get; set; } = null!;
}
