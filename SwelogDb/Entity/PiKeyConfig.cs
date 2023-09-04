using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PiKeyConfig
{
    public string KeyId { get; set; } = null!;

    public int KeyNumber { get; set; }
}
