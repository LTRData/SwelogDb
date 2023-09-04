using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CustomerDiscountGroup
{
    public string CustomerDiscountGroupCode { get; set; } = null!;

    public string? CustDiscGroupDesc { get; set; }

    public int? CustDiscGroupDescTxtid { get; set; }

    public string? CustDiscGroupDescFlag { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<ContractOrderHeader> ContractOrderHeaders { get; } = new List<ContractOrderHeader>();

    public virtual ICollection<CustomerOrderHeader> CustomerOrderHeaders { get; } = new List<CustomerOrderHeader>();

    public virtual ICollection<Customer> Customers { get; } = new List<Customer>();

    public virtual ICollection<PriceListMatrix> PriceListMatrices { get; } = new List<PriceListMatrix>();

    public virtual ICollection<QtyDiscountStrucCustomer> QtyDiscountStrucCustomers { get; } = new List<QtyDiscountStrucCustomer>();

    public virtual ICollection<ValueDiscountStrucCustomer> ValueDiscountStrucCustomers { get; } = new List<ValueDiscountStrucCustomer>();
}
