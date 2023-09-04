using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ProjectHeader
{
    public string ProjectNumber { get; set; } = null!;

    public string? CustomerId { get; set; }

    public string? CustomerItemNumber { get; set; }

    public string? CustomerItemDescription { get; set; }

    public string? CustomerDrawingNo { get; set; }

    public string? CustomerRevisionNo { get; set; }

    public string? CustomerOrderNumber { get; set; }

    public string? ItemNumber { get; set; }

    public string? ChangeDescription { get; set; }

    public string? ProjectItemNumber { get; set; }

    public string? TemplateItemNumber { get; set; }

    public DateTime? OrderDate { get; set; }

    public string ProjectType { get; set; } = null!;

    public string? ConstructorId { get; set; }

    public int? BandWidth { get; set; }

    public int? FeedingLength { get; set; }

    public int? Thickness { get; set; }

    public DateTime? ConstructionEndDate { get; set; }

    public DateTime? ProductionEndDate { get; set; }

    public DateTime? TestResultDeliveryDate { get; set; }

    public decimal? ItemAnnualRequirement { get; set; }

    public string? FirstSeriesDeliveryYyww { get; set; }

    public int? AnnualQuantityYear1 { get; set; }

    public int? AnnualQuantityYear2 { get; set; }

    public int? LotQuantity { get; set; }

    public string? ToolProjectItemNumber { get; set; }

    public string? ToolProjectItemTemplate { get; set; }

    public string? ItemDescription { get; set; }

    public string? DrawingNo { get; set; }

    public string? RevisionNo { get; set; }

    public string? LanguageCode { get; set; }

    public byte? DocumentVersion { get; set; }

    public string? ProjectLeader { get; set; }

    public string? ProjectSupervisor { get; set; }

    public string? OrderNumber { get; set; }

    public string? FreeText1 { get; set; }

    public string? FreeText2 { get; set; }

    public string? FreeText3 { get; set; }

    public string? FreeText4 { get; set; }

    public string? DeliveryAddressId { get; set; }

    public string? ReferenceId { get; set; }

    public string? FixtureProjectItemNumber { get; set; }

    public string? FixtureProjectItemTemplate { get; set; }

    public string? EcnNumber { get; set; }

    public string? PfmeaIdVersion { get; set; }

    public virtual ICollection<ProjectAction> ProjectActions { get; } = new List<ProjectAction>();

    public virtual ICollection<ProjectToolAction> ProjectToolActions { get; } = new List<ProjectToolAction>();
}
