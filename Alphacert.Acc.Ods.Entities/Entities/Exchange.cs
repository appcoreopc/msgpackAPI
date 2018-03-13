using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class Exchange
    {
        public Exchange()
        {
            Bbexchange = new HashSet<Bbexchange>();
            ComplianceAuthorisationRule = new HashSet<ComplianceAuthorisationRule>();
            Instrument = new HashSet<Instrument>();
            Issuer = new HashSet<Issuer>();
            Sshentity = new HashSet<Sshentity>();
            TickerExchange = new HashSet<TickerExchange>();
        }

        public int ExchangeId { get; set; }
        public string ExchangeCode { get; set; }
        public string ExchangeName { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? Sshthreshold { get; set; }
        public decimal? Sshincrement { get; set; }
        public int? SshmovementType { get; set; }
        public bool? GroupByIssuer { get; set; }
        public DateTime DateCreated { get; set; }
        public bool? Inactive { get; set; }
        public int? CountryId { get; set; }

        public Country Country { get; set; }
        public ICollection<Bbexchange> Bbexchange { get; set; }
        public ICollection<ComplianceAuthorisationRule> ComplianceAuthorisationRule { get; set; }
        public ICollection<Instrument> Instrument { get; set; }
        public ICollection<Issuer> Issuer { get; set; }
        public ICollection<Sshentity> Sshentity { get; set; }
        public ICollection<TickerExchange> TickerExchange { get; set; }
    }
}
