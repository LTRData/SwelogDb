using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemDocumentsPath
{
    public string CompanyNo { get; set; } = null!;

    public string? DrawingFilePath { get; set; }

    public string? DrawingJobticket { get; set; }

    public string? DrawingPurchaseOrder { get; set; }

    public string? DrawingPicklist { get; set; }

    public string? DrawingFileExtn { get; set; }

    public string? PictureFilePath { get; set; }

    public string? PictureJobticket { get; set; }

    public string? PicturePurchaseOrder { get; set; }

    public string? PicturePicklist { get; set; }

    public string? PictureFileExtn { get; set; }

    public string? Text1FilePath { get; set; }

    public string? Text1Jobticket { get; set; }

    public string? Text1PurchaseOrder { get; set; }

    public string? Text1Picklist { get; set; }

    public string? Text1FileExtn { get; set; }

    public string? Text2FilePath { get; set; }

    public string? Text2Jobticket { get; set; }

    public string? Text2PurchaseOrder { get; set; }

    public string? Text2Picklist { get; set; }

    public string? Text2FileExtn { get; set; }

    public string? CalcnSheetFilePath { get; set; }

    public string? CalcnSheetJobticket { get; set; }

    public string? CalcnSheetPurchaseOrder { get; set; }

    public string? CalcnSheetPicklist { get; set; }

    public string? CalcnSheetFileExtn { get; set; }

    public string? AuditStamp { get; set; }
}
