using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MosNotCompletedPallet
{
    public int SerialNo { get; set; }

    public string ItemNumber { get; set; } = null!;

    public string PalletNo { get; set; } = null!;
}
