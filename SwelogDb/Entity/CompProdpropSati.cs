using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CompProdpropSati
{
    public string ProdpropSet { get; set; } = null!;

    public string Compgroup { get; set; } = null!;

    public string Col1 { get; set; } = null!;

    public string Col2 { get; set; } = null!;

    public string Col3 { get; set; } = null!;

    public string Col4 { get; set; } = null!;

    public string Col5 { get; set; } = null!;

    public string Col6 { get; set; } = null!;

    public string Col7 { get; set; } = null!;

    public string Col8 { get; set; } = null!;

    public string Col9 { get; set; } = null!;

    public string Col10 { get; set; } = null!;

    public string? ChoosenItem { get; set; }

    public int? LineOrder { get; set; }

    public string? AuditStamp { get; set; }
}
