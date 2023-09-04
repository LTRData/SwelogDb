using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SysparamCustomisation
{
    public int CustomisationId { get; set; }

    public string? Description { get; set; }

    public string? ActivationFlag { get; set; }

    public string? ModuleName { get; set; }

    public DateTime? ValidUpto { get; set; }

    public string? Specification { get; set; }
}
