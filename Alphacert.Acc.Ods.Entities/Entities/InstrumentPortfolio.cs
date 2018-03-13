using System;
using System.Collections.Generic;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class InstrumentPortfolio
    {
        public InstrumentPortfolio()
        {
            Holding = new HashSet<Holding>();
            Ifrshistory = new HashSet<Ifrshistory>();
            OpenFfxposition = new HashSet<OpenFfxposition>();
            Transaction = new HashSet<Transaction>();
            TransactionHistory = new HashSet<TransactionHistory>();
        }

        public int InstrumentId { get; set; }
        public int PortfolioId { get; set; }
        public bool? Inactive { get; set; }

        public Instrument Instrument { get; set; }
        public Portfolio Portfolio { get; set; }
        public ICollection<Holding> Holding { get; set; }
        public ICollection<Ifrshistory> Ifrshistory { get; set; }
        public ICollection<OpenFfxposition> OpenFfxposition { get; set; }
        public ICollection<Transaction> Transaction { get; set; }
        public ICollection<TransactionHistory> TransactionHistory { get; set; }
    }
}
