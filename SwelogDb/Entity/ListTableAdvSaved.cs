using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ListTableAdvSaved
{
    public int SerialNumber { get; set; }

    public string? SearchIdentifier { get; set; }

    public string? SearchName { get; set; }

    public string? SearchDescription { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }
}
