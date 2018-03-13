using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class Issuer
    {
        public Issuer()
        {
            InstrumentGuarantorIssuer = new HashSet<Instrument>();
            InstrumentIssuer = new HashSet<Instrument>();
            InverseParentIssuer = new HashSet<Issuer>();
            IssuerCreditRating = new HashSet<IssuerCreditRating>();
            IssuerUnderwritingAdjustment = new HashSet<IssuerUnderwritingAdjustment>();
            Sshentity = new HashSet<Sshentity>();
        }

        public int IssuerId { get; set; }
        public int? ParentIssuerId { get; set; }
        public string IssuerName { get; set; }
        public string IssuerCode { get; set; }
        public bool? AuthorisedBank { get; set; }
        public bool? Nzgovernment { get; set; }
        public string IdBb { get; set; }
        public string BloombergRef { get; set; }
        public bool? InActive { get; set; }
        public int? CounterPartyId { get; set; }
        public bool? Isda { get; set; }
        public bool? NzfmarepoSchedule { get; set; }
        public bool? MasterRepoAgreement { get; set; }
        public int? ExchangeId { get; set; }
        public decimal? MaximumShareholdingPercent { get; set; }
        public decimal? MaximumFreeFloatPercent { get; set; }
        public decimal? MaximumExtensionPercent { get; set; }
        public string Comment { get; set; }
        public decimal? CreditLimit { get; set; }
        public string CreditNotes { get; set; }
        public decimal? ExpectedLossLimit { get; set; }
        public bool? IsLocalAuthority { get; set; }
        public bool? IsRestricted { get; set; }
        public bool? IsInternal { get; set; }
        public string CountryOfDomicile { get; set; }
        public string AccCountryOfDomicile { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CompanyTicker { get; set; }

        public CounterParty CounterParty { get; set; }
        public Exchange Exchange { get; set; }
        public Issuer ParentIssuer { get; set; }
        public ICollection<Instrument> InstrumentGuarantorIssuer { get; set; }
        public ICollection<Instrument> InstrumentIssuer { get; set; }
        public ICollection<Issuer> InverseParentIssuer { get; set; }
        public ICollection<IssuerCreditRating> IssuerCreditRating { get; set; }
        public ICollection<IssuerUnderwritingAdjustment> IssuerUnderwritingAdjustment { get; set; }
        public ICollection<Sshentity> Sshentity { get; set; }
    }
}
