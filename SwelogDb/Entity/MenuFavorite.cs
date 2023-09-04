using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MenuFavorite
{
    public string UserId { get; set; } = null!;

    public short SerialNo { get; set; }

    public string? MenuName { get; set; }

    public string? MenuText { get; set; }

    public string? PicturePath { get; set; }

    public string? Argument { get; set; }
}
