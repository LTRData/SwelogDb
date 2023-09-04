using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CrmParameter
{
    public int SerialNumber { get; set; }

    public byte? FirstSearchScreen { get; set; }

    public byte? CrmLicenses { get; set; }
}
