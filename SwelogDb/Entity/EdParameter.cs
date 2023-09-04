using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EdParameter
{
    public int Id { get; set; }

    public string? TemplateItemNumberBody { get; set; }

    public string? TemplateItemNumberGlass { get; set; }

    public string? ProductGroupOdHinge { get; set; }

    public short? OpNoDecorMfg { get; set; }

    public short? OpNoImpreg { get; set; }

    public short? OpNoGroundPaint { get; set; }

    public short? OpNoDecorMont { get; set; }

    public short? OpNoGlassListOut { get; set; }

    public short? OpNoFrameMfg { get; set; }

    public short? OpNoPaint { get; set; }

    public short? OpNoFrameMounting { get; set; }

    public short? OpNoGlassMounting { get; set; }

    public short? OpNoGlassListIn { get; set; }

    public short? OpNoWeatherstrip { get; set; }

    public short? OpNoFinalMounting { get; set; }

    public short? OpNoLooseAcc { get; set; }

    public short? OpNoPacking { get; set; }

    public string? ModelPictureFilePath { get; set; }

    public string? TemplateItemNumberHdf { get; set; }

    public string? TemplateItemNumberMdf { get; set; }

    public string? FireDoorListItemNumber { get; set; }

    public string? ProductGroupLock { get; set; }

    public string? ProductGroupOtherAcc { get; set; }
}
