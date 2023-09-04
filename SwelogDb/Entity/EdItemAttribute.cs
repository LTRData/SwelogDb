using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EdItemAttribute
{
    public string ItemNumber { get; set; } = null!;

    public string KeyId { get; set; } = null!;

    public string? Label { get; set; }

    public string? Value { get; set; }

    public string? Display { get; set; }

    public int? PageNo { get; set; }

    public int? RowNo { get; set; }
}
