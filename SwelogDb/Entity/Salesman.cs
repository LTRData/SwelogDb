using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Salesman
{
    public string SalesmanCode { get; set; } = null!;

    public string? SalesmanName { get; set; }

    public int? SalesmanNameTxtid { get; set; }

    public string? SalesmanNameFlag { get; set; }

    public int? EmploymentNumber { get; set; }

    public string? MarketCode { get; set; }

    public string? TerritoryCode { get; set; }

    public string? AuditStamp { get; set; }

    public string? CompanyNo { get; set; }

    public string? DepartmentNo { get; set; }

    public string? SalesmanType { get; set; }

    public virtual ICollection<CustInvoiceHdr> CustInvoiceHdrs { get; } = new List<CustInvoiceHdr>();

    public virtual ICollection<Customer> Customers { get; } = new List<Customer>();

    public virtual Department? Department { get; set; }

    public virtual ICollection<SystemParameter> SystemParameters { get; } = new List<SystemParameter>();
}
