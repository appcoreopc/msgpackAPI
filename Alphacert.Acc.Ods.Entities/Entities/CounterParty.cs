using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class CounterParty
    {
        public CounterParty()
        {
            CounterPartyAlias = new HashSet<CounterPartyAlias>();
            Instrument = new HashSet<Instrument>();
            Issuer = new HashSet<Issuer>();
            OpenFfxposition = new HashSet<OpenFfxposition>();
            Ssi = new HashSet<Ssi>();
            Ssihistory = new HashSet<Ssihistory>();
            Trade = new HashSet<Trade>();
            TradeConfirmation = new HashSet<TradeConfirmation>();
            TradeConfirmationFx = new HashSet<TradeConfirmationFx>();
        }

        public int CounterPartyId { get; set; }
        public string CounterPartyName { get; set; }
        public string Code { get; set; }
        public string BrokerCode { get; set; }
        public int? BatchId { get; set; }
        public int? LoadId { get; set; }
        public DateTime? Created { get; set; }
        public bool? Inactive { get; set; }

        public ICollection<CounterPartyAlias> CounterPartyAlias { get; set; }
        public ICollection<Instrument> Instrument { get; set; }
        public ICollection<Issuer> Issuer { get; set; }
        public ICollection<OpenFfxposition> OpenFfxposition { get; set; }
        public ICollection<Ssi> Ssi { get; set; }
        public ICollection<Ssihistory> Ssihistory { get; set; }
        public ICollection<Trade> Trade { get; set; }
        public ICollection<TradeConfirmation> TradeConfirmation { get; set; }
        public ICollection<TradeConfirmationFx> TradeConfirmationFx { get; set; }
    }
}
