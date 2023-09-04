using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CrmOption
{
    public int SerialNumber { get; set; }

    public string? OptionName { get; set; }

    public string? OptionValue { get; set; }
}
