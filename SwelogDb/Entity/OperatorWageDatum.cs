using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OperatorWageDatum
{
    public int EmployeeNumber { get; set; }

    public string WorkplaceId { get; set; } = null!;

    public string ActivityInd { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public string ActivityNo { get; set; } = null!;

    public DateTime StartDateTime { get; set; }

    public DateTime ReportDateTime { get; set; }

    public DateTime ValidUpto { get; set; }

    public string ResourceNumber { get; set; } = null!;

    public string? ActivityType { get; set; }

    public string? ResourceActivityType { get; set; }

    public decimal? Finished { get; set; }

    public decimal? OperatorTime { get; set; }

    public decimal? ProducedQty { get; set; }

    public decimal? OperatorSetupTime { get; set; }

    public decimal? NoOfSetup { get; set; }

    public decimal? SetupPrice { get; set; }

    public decimal? SetupAmount { get; set; }

    public decimal? ProdAmount { get; set; }

    public string? PieceWorkTypeCode { get; set; }

    public decimal? PieceWorkRate { get; set; }

    public decimal? TimeWorkRate { get; set; }

    public short? ConvFactor { get; set; }

    public decimal? TimeRateFixedPart { get; set; }

    public string? WageType { get; set; }

    public DateTime MpcStartDate { get; set; }

    public DateTime? MpcEndDate { get; set; }

    public decimal? TotalAmount { get; set; }

    public string? WageTransOption { get; set; }

    public string? AuditStamp { get; set; }

    public decimal? AddSetupPrice { get; set; }

    public decimal? AddPieceWorkRate { get; set; }

    public decimal? AddTimeWorkRate { get; set; }

    public DateTime? ActivityStartDate { get; set; }

    public string? StartLimit { get; set; }

    public string? EndLimit { get; set; }

    public int? AttestedBy { get; set; }

    public string? AddDescription { get; set; }

    public string? AddType { get; set; }

    public string? AddIndActivityNo { get; set; }

    public decimal? AddProducedQty { get; set; }

    public decimal? AddNoOfSetup { get; set; }

    public string? CostCentre { get; set; }

    public string? ExtraDescription { get; set; }
}
