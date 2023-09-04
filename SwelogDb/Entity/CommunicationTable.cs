using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CommunicationTable
{
    public string ReferenceId { get; set; } = null!;

    public string ModuleId { get; set; } = null!;

    public string? OrderPaperFlag { get; set; }

    public string? OrderFaxFlag { get; set; }

    public string? OrderMailFlag { get; set; }

    public string? OrderEdiFlag { get; set; }

    public string? DelPaperFlag { get; set; }

    public string? DelFaxFlag { get; set; }

    public string? DelMailFlag { get; set; }

    public string? DelEdiFlag { get; set; }

    public string? AvisPaperFlag { get; set; }

    public string? AvisFaxFlag { get; set; }

    public string? AvisMailFlag { get; set; }

    public string? AvisEdiFlag { get; set; }

    public string? InvPaperFlag { get; set; }

    public string? InvFaxFlag { get; set; }

    public string? InvMailFlag { get; set; }

    public string? InvEdiFlag { get; set; }

    public short? OrderPaperCopies { get; set; }

    public string? OrderFaxNo { get; set; }

    public string? OrderMailId { get; set; }

    public string? OrderEdiText { get; set; }

    public short? DelPaperCopies { get; set; }

    public string? DelFaxNo { get; set; }

    public string? DelMailId { get; set; }

    public string? DelEdiText { get; set; }

    public short? AvisPaperCopies { get; set; }

    public string? AvisFaxNo { get; set; }

    public string? AvisMailId { get; set; }

    public string? AvisEdiText { get; set; }

    public short? InvPaperCopies { get; set; }

    public string? InvFaxNo { get; set; }

    public string? InvMailId { get; set; }

    public string? InvEdiText { get; set; }

    public string? AuditStamp { get; set; }

    public string? OfferPaperFlag { get; set; }

    public string? OfferFaxFlag { get; set; }

    public string? OfferMailFlag { get; set; }

    public string? OfferEdiFlag { get; set; }

    public short? OfferPaperCopies { get; set; }

    public string? OfferFaxNo { get; set; }

    public string? OfferMailId { get; set; }

    public string? OfferEdiText { get; set; }

    public string? SuppconsigrepPaperFlag { get; set; }

    public string? SuppconsigrepFaxFlag { get; set; }

    public string? SuppconsigrepMailFlag { get; set; }

    public string? SuppconsigrepEdiFlag { get; set; }

    public short? SuppconsigrepPaperCopies { get; set; }

    public string? SuppconsigrepFaxNo { get; set; }

    public string? SuppconsigrepMailId { get; set; }

    public string? SuppconsigrepEdiText { get; set; }

    public string? InvEfaktFlag { get; set; }

    public string? OrderYourRefMailFlag { get; set; }

    public string? FactoringCustPaperFlag { get; set; }

    public string? FactoringCustFaxFlag { get; set; }

    public string? FactoringCustMailFlag { get; set; }

    public string? FactoringCustEdiFlag { get; set; }

    public short? FactoringCustPaperCopies { get; set; }

    public string? FactoringCustFaxNo { get; set; }

    public string? FactoringCustMailId { get; set; }

    public string? FactoringCustEdiText { get; set; }

    public string? DelCertificateMailFlag { get; set; }

    public string? DelCertificateMailId { get; set; }

    public string? DelCocFlag { get; set; }

    public string? InvEmailPerInvoice { get; set; }

    public short? DemandNotePaperCopies { get; set; }

    public string? OrderScaniaFlag { get; set; }

    public string? OfferYourRefMailFlag { get; set; }

    public string? DemandNotePaperFlag { get; set; }

    public string? DemandNoteFaxFlag { get; set; }

    public string? DemandNoteMailFlag { get; set; }

    public string? DemandNoteEdiFlag { get; set; }

    public string? DemandNoteEfaktFlag { get; set; }

    public string? DemandNoteEmailPerDn { get; set; }

    public string? DemandNoteFaxNo { get; set; }

    public string? DemandNoteMailId { get; set; }

    public string? DemandNoteEdiText { get; set; }

    public string? IntInvPaperFlag { get; set; }

    public string? IntInvFaxFlag { get; set; }

    public string? IntInvMailFlag { get; set; }

    public string? IntInvEdiFlag { get; set; }

    public string? IntInvEfaktFlag { get; set; }

    public string? IntInvEmailPerInv { get; set; }

    public short? IntInvPaperCopies { get; set; }

    public string? IntInvFaxNo { get; set; }

    public string? IntInvMailId { get; set; }

    public string? IntInvEdiText { get; set; }

    public string? OrderXmlFlag { get; set; }
}
