using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class BankProduction
{
    public string CompanyNo { get; set; } = null!;

    public DateTime BankFileDate { get; set; }

    public int? SequenceNo { get; set; }

    public int? SequenceControl { get; set; }
}
