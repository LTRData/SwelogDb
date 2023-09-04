using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MenuScenariosHeader
{
    public int SerialNumber { get; set; }

    public string? ScenarioName { get; set; }

    public string? ScenarioDescription { get; set; }

    public int? WidthOfBox { get; set; }

    public int? ColorText { get; set; }

    public int? ColorMenu { get; set; }

    public int? ColorDocument { get; set; }

    public int? ColorBackground { get; set; }
}
