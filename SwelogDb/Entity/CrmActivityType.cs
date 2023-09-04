using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CrmActivityType
{
    public short ActivityTypeCode { get; set; }

    public string? ActivityTypeDescription { get; set; }
}
