﻿using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CodeStrStockTotal
{
    public string CompanyNo { get; set; } = null!;

    public short YearNo { get; set; }

    public short TransId { get; set; }

    public string ProductCategory { get; set; } = null!;

    public string ProductType { get; set; } = null!;

    public string ProductGroupCode { get; set; } = null!;

    public string ProductAccountCode { get; set; } = null!;

    public string AccountNo { get; set; } = null!;

    public string? DepartmentNo { get; set; }

    public string? ProductNo { get; set; }

    public string? ProjectNo { get; set; }

    public string? FunctionNo { get; set; }

    public string? ANo { get; set; }

    public string? BNo { get; set; }

    public string? CNo { get; set; }

    public string? DNo { get; set; }

    public string? AuditStamp { get; set; }

    public string RefTranId { get; set; } = null!;

    public string CustomerAccountCode { get; set; } = null!;

    public string CountryCode { get; set; } = null!;
}
