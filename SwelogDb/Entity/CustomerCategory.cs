using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CustomerCategory
{
    public string CustomerCategoryCode { get; set; } = null!;

    public string? CategoryDesc { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<ContractOrderHeader> ContractOrderHeaders { get; } = new List<ContractOrderHeader>();

    public virtual ICollection<CustomerOrderHeader> CustomerOrderHeaders { get; } = new List<CustomerOrderHeader>();

    public virtual ICollection<PriceListHdr> PriceListHdrs { get; } = new List<PriceListHdr>();

    public virtual ICollection<SystemParameter> SystemParameters { get; } = new List<SystemParameter>();

    public virtual ICollection<UserDefinedCharge> UserDefinedCharges { get; } = new List<UserDefinedCharge>();
}
