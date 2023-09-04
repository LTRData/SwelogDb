using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TransactionLog
{
    public int TransId { get; set; }

    public string? TransType { get; set; }

    public string? TransKey { get; set; }

    public DateTime? TransDateTime { get; set; }

    public string? Status { get; set; }

    public string? WorkstationId { get; set; }

    public string? UserId { get; set; }

    public string? ItemNumber { get; set; }

    public int? LotNumber { get; set; }

    public int? OperationNumber { get; set; }

    public short? StatusCode { get; set; }
}
