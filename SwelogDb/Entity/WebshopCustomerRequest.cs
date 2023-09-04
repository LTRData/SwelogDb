using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class WebshopCustomerRequest
{
    public string CustomerId { get; set; } = null!;

    public string RequestNumber { get; set; } = null!;

    public string? PartnerOrderNo { get; set; }

    public string? OrderType { get; set; }

    public string? OrderNumber { get; set; }

    public DateTime? OrderDate { get; set; }

    public decimal? OrderAmount { get; set; }

    public int RequestStatus { get; set; }

    public string? AuditStamp { get; set; }

    public string? CustomersRefName { get; set; }

    public string? CustomersRefTelphone { get; set; }

    public string? CustomersRefMailaddress { get; set; }

    public string? CustomersText { get; set; }
}
