using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class StocktakingSelection1
{
    public int IdStocktakingSelections { get; set; }

    public DateTime? SelectionDate { get; set; }

    public string? SwelogUser { get; set; }

    public string? SelectionLabel { get; set; }

    public string? SelectionString { get; set; }
}
