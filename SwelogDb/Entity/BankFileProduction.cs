using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class BankFileProduction
{
    public string CompanyNo { get; set; } = null!;

    public DateTime BankFileDate { get; set; }

    public int ProductionNo { get; set; }
}
