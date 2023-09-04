using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TrFunctionKey
{
    public string ModuleId { get; set; } = null!;

    public string PersonCatg { get; set; } = null!;

    public byte Context { get; set; }

    public string FunctionKey { get; set; } = null!;

    public string? TextOnKey { get; set; }

    public string? MainFunction { get; set; }

    public string? Parameters { get; set; }
}
