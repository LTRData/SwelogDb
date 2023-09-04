using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PdfGenerationSetting
{
    public int SerialNumber { get; set; }

    public string? DocumentType { get; set; }

    public bool? AddSecurity { get; set; }

    public byte? EncryptionLevel { get; set; }

    public string? UserPassword { get; set; }

    public string? MasterPassword { get; set; }

    public bool? DisallowPrinting { get; set; }

    public bool? DisallowModifyContents { get; set; }

    public bool? DisallowModifyAnnotations { get; set; }

    public bool? DisallowCopy { get; set; }

    public bool? AddBackground { get; set; }

    public string? BackgroundFile { get; set; }

    public bool? BackgroundOnlyOnFirstPage { get; set; }

    public bool? AddAuthor { get; set; }

    public string? SpecificAuthor { get; set; }

    public byte? AuthorUseridUsername { get; set; }

    public bool? AddTitle { get; set; }

    public string? SpecificTitle { get; set; }

    public bool? TitleDocumentDescription { get; set; }

    public bool? AddSubject { get; set; }

    public string? SpecificSubject { get; set; }

    public bool? SubjectDocumentDescription { get; set; }

    public bool? AddKeywords { get; set; }

    public string? SpecificKeywords { get; set; }

    public bool? AddCreator { get; set; }

    public string? SpecificCreator { get; set; }

    public byte? CreatorUseridUsername { get; set; }

    public bool? AddProducer { get; set; }

    public string? SpecificProducer { get; set; }

    public bool? ProducerCompanyname { get; set; }

    public int? LeftMargin { get; set; }

    public int? TopMargin { get; set; }

    public int? RightMargin { get; set; }

    public int? BottomMargin { get; set; }

    public byte? Scale { get; set; }

    public bool? IncludeCompanyLogo { get; set; }

    public bool? IncludeFooter { get; set; }
}
