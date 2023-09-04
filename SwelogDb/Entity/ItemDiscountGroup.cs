using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemDiscountGroup
{
    public string ItemDiscountGroupCode { get; set; } = null!;

    public string? ItemGroupName { get; set; }

    public int? ItemDiscountGroupTxtid { get; set; }

    public string? ItemDiscountGroupFlag { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<ContractOrderItem> ContractOrderItems { get; } = new List<ContractOrderItem>();

    public virtual ICollection<CustomerOrderDtl> CustomerOrderDtls { get; } = new List<CustomerOrderDtl>();

    public virtual ICollection<PriceListMatrix> PriceListMatrices { get; } = new List<PriceListMatrix>();

    public virtual ICollection<PurchaseOrderDtl> PurchaseOrderDtls { get; } = new List<PurchaseOrderDtl>();

    public virtual ICollection<QtyDiscountStrucCustomer> QtyDiscountStrucCustomers { get; } = new List<QtyDiscountStrucCustomer>();

    public virtual ICollection<QtyDiscountStrucSupplier> QtyDiscountStrucSuppliers { get; } = new List<QtyDiscountStrucSupplier>();

    public virtual ICollection<ValDiscountStrucSupplier> ValDiscountStrucSuppliers { get; } = new List<ValDiscountStrucSupplier>();

    public virtual ICollection<ValueDiscountStrucCustomer> ValueDiscountStrucCustomers { get; } = new List<ValueDiscountStrucCustomer>();
}
