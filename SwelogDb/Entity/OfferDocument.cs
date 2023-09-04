using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OfferDocument
{
    public int IdOfferDocument { get; set; }

    public string? OfferNumber { get; set; }

    public string? DocType { get; set; }

    public string? DocId { get; set; }

    public string? DocumentDescription { get; set; }

    public string? DocumentPath { get; set; }

    public string? DocumentFilename { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? SourceRecId { get; set; }

    public virtual OfferHeader? OfferNumberNavigation { get; set; }
}
