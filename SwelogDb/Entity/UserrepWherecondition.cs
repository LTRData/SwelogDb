using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class UserrepWherecondition
{
    public int SerialNumber { get; set; }

    public string? TableName1 { get; set; }

    public string? TableName2 { get; set; }

    public string? WhereCondition { get; set; }
}
