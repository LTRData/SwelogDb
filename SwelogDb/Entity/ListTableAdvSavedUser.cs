using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ListTableAdvSavedUser
{
    public int SerialNumber { get; set; }

    public int? HeaderSerialNumber { get; set; }

    public string? UserOrGroupName { get; set; }

    public byte? UserType { get; set; }
}
