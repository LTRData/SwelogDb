using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemPictureButtonsDtl
{
    public string PictureNumber { get; set; } = null!;

    public short ButtonNumber { get; set; }

    public string? ButtonName { get; set; }

    public string? ItemNumber { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ItemPictureButtonsHdr PictureNumberNavigation { get; set; } = null!;
}
