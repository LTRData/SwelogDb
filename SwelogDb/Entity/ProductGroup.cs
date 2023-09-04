using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ProductGroup
{
    public string ProductGroupCode { get; set; } = null!;

    public string? ProductGroupDescription { get; set; }

    public int? ProductGroupTxtid { get; set; }

    public string? ProductGroupFlag { get; set; }

    public string? AuditStamp { get; set; }

    public string? CompanyNo { get; set; }

    public string? ProductNo { get; set; }

    public string? VatCode { get; set; }

    public string? FreeText { get; set; }

    public string? ProductGroupType { get; set; }

    public int? OperationNumber { get; set; }

    public int? ShelfLifeMonths { get; set; }

    public virtual ICollection<ChangeItem> ChangeItems { get; } = new List<ChangeItem>();

    public virtual ICollection<Item> Items { get; } = new List<Item>();

    public virtual Product? Product { get; set; }
}
