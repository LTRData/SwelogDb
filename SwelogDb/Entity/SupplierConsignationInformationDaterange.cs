using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SupplierConsignationInformationDaterange
{
    public DateTime InfoTimestamp { get; set; }

    public DateTime? DaterangeStart { get; set; }

    public DateTime? DaterangeEnd { get; set; }
}
