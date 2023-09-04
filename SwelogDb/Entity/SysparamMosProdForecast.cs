using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SysparamMosProdForecast
{
    public int SerialNumber { get; set; }

    public string? ForecastId { get; set; }

    public DateTime? IgnoreDateFrom { get; set; }

    public DateTime? IgnoreDateTo { get; set; }
}
