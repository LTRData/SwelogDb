using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TextidTableFilepath
{
    public int SerialNumber { get; set; }

    public int? TextId { get; set; }

    public string? FilePath { get; set; }

    public string? OwnName { get; set; }

    public bool? PrintAtJticket { get; set; }

    public string? OrderLineDocument { get; set; }

    public int? DocumentYear { get; set; }

    public string? SupplierId { get; set; }
}
