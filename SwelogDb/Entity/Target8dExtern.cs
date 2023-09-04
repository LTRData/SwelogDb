using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Target8dExtern
{
    public int Yyyymm { get; set; }

    public string CustomerId { get; set; } = null!;

    public decimal? DeliveryQty { get; set; }

    public decimal? ErrorQty { get; set; }

    public decimal? Ppm { get; set; }

    public decimal? DeliveryQty3mr { get; set; }

    public decimal? ErrorQty3mr { get; set; }

    public decimal? Ppm3mr { get; set; }

    public decimal? DeliveryQty12mr { get; set; }

    public decimal? ErrorQty12mr { get; set; }

    public decimal? Ppm12mr { get; set; }
}
