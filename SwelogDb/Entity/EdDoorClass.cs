using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EdDoorClass
{
    public string ClassCode { get; set; } = null!;

    public string ClassDescription { get; set; } = null!;

    public int? FrameThickness { get; set; }

    public int? GlassThickness { get; set; }

    public string? AuditStamp { get; set; }

    public short? SortOrder { get; set; }

    public string? LabelInfoGlassMid { get; set; }

    public string? LabelInfoGlassUp { get; set; }

    public string? LabelInfoNoGlassMid { get; set; }

    public string? LabelInfoNoGlassUp { get; set; }

    public string? ItemType { get; set; }

    public bool? IncludeFireList { get; set; }

    public string? FrameFreeCode4 { get; set; }

    public string? StructItemNumberFrame { get; set; }

    public string? StructItemNumberLeaf { get; set; }

    public bool? Vindlast3c { get; set; }

    public bool? VindlastNpd { get; set; }

    public bool? Regntathet7b { get; set; }

    public bool? RegntathetNpd { get; set; }

    public bool? VarmegenomgGl1012 { get; set; }

    public bool? VarmegenomgGlNpd { get; set; }

    public bool? VarmegenomgGl10 { get; set; }

    public bool? VarmegenomgGl0911 { get; set; }

    public bool? VarmegenomgGl1214 { get; set; }

    public bool? VarmegenomgOgl08 { get; set; }

    public bool? VarmegenomgOglNpd { get; set; }

    public bool? VarmegenomgOgl09 { get; set; }

    public bool? LufttathetKlass4 { get; set; }

    public bool? LufttathetNpd { get; set; }

    public bool? LjudisoleringGl2633 { get; set; }

    public bool? LjudisoleringGl2914 { get; set; }

    public bool? LjudisoleringGl2945 { get; set; }

    public bool? LjudisoleringGl3111 { get; set; }

    public bool? LjudisoleringGl3313 { get; set; }

    public bool? LjudisoleringGl4325 { get; set; }

    public bool? LjudisoleringGlNpd { get; set; }

    public bool? LjudisoleringOgl2633 { get; set; }

    public bool? LjudisoleringOgl2845 { get; set; }

    public bool? LjudisoleringOgl2914 { get; set; }

    public bool? LjudisoleringOgl3034 { get; set; }

    public bool? LjudisoleringOgl3313 { get; set; }

    public bool? LjudisoleringOgl4014 { get; set; }

    public bool? LjudisoleringOgl4313 { get; set; }

    public bool? LjudisoleringOglNpd { get; set; }

    public bool? BrandklassGlEi230 { get; set; }

    public bool? BrandklassGlNpd { get; set; }

    public bool? BrandklassOglEi230 { get; set; }

    public bool? BrandklassOglNpd { get; set; }

    public bool? RokgastathetSaS200 { get; set; }

    public bool? RokgastathetNpd { get; set; }

    public bool? InbrottssakerhetRc2 { get; set; }

    public bool? InbrottssakerhetRc3 { get; set; }

    public bool? InbrottssakerhetNpd { get; set; }
}
