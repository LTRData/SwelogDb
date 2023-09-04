using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemPictureButtonsHdr
{
    public string PictureNumber { get; set; } = null!;

    public string? PictureName { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<ItemPictureButtonsDtl> ItemPictureButtonsDtls { get; } = new List<ItemPictureButtonsDtl>();
}
