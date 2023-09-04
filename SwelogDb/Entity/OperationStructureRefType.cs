using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OperationStructureRefType
{
    public string RefType { get; set; } = null!;

    public double? RefTypeDescriptionText { get; set; }

    public string? Ref1 { get; set; }

    public string? Ref2 { get; set; }

    public string? Ref3 { get; set; }

    public string? Ref4 { get; set; }

    public string? Ref5 { get; set; }

    public string? SwelogWindowParmTemplate { get; set; }

    public string? Template { get; set; }

    public string? DocIdTemplate { get; set; }

    public string? OperationRefYn { get; set; }

    public string? StructureRefYn { get; set; }

    public string? ActiveYn { get; set; }

    public string? MfgOrderNumberTemplate { get; set; }

    public string? MfgItemTemplate { get; set; }

    public string? MfgItemCopySource { get; set; }

    public double? MfgOrderType { get; set; }

    public string? AssetType { get; set; }

    public string? ProductionCase { get; set; }

    public string? AssetProductionSpecification { get; set; }

    public double? BasicDataRefs { get; set; }

    public string? NumberRangeGeneral { get; set; }

    public string? NumberRangeSeriesId { get; set; }

    public string? ItemVersionCode { get; set; }

    public string? BasicregRef { get; set; }

    public string? BasicregRefsub { get; set; }

    public string? MfgOrderNumber2 { get; set; }

    public string? NumberRangeGeneral2 { get; set; }

    public string? NumberRangeSeriesId2 { get; set; }

    public string? AuditStamp { get; set; }
}
