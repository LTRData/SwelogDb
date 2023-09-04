using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Cu168Naringsvarden
{
    public int SerialNumber { get; set; }

    public string? NaringsvardenKod { get; set; }

    public string? NaringsvardenBeskrivning { get; set; }
}
