using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CustomParameter
{
    public int Id { get; set; }

    public string? TemplateItemNumber { get; set; }

    public string? ProductGroupColor { get; set; }

    public decimal? HourlyCostMixing { get; set; }

    public string? ProductionGroupColoring { get; set; }

    public string? NotificationRecepient { get; set; }

    public bool? DbReadPreProcessedData { get; set; }

    public DateTime? DbCalculationDate { get; set; }

    public string? DbResourceList { get; set; }

    public int? DbDefConfig { get; set; }

    public string? TestObjectName { get; set; }
}
