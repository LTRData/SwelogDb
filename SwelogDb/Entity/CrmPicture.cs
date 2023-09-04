using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CrmPicture
{
    public int SerialNumber { get; set; }

    public string? PictureLabel { get; set; }

    public string? PictureFolderName { get; set; }

    public string? PictureFileName { get; set; }
}
