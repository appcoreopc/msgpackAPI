using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Alphacert.Acc.Ods.Entities.Views;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class IDS_ODSContext : DbContext
    {
        public virtual DbSet<AccadjustmentHistory> AccadjustmentHistory { get; set; }
        public virtual DbSet<AccadjustmentStatus> AccadjustmentStatus { get; set; }
        public virtual DbSet<AccethicalExclusions> AccethicalExclusions { get; set; }
        public virtual DbSet<AccountingBudget> AccountingBudget { get; set; }
        public virtual DbSet<AccountingBudgetGroup> AccountingBudgetGroup { get; set; }
        public virtual DbSet<AccprojectionAdjustment> AccprojectionAdjustment { get; set; }
        public virtual DbSet<AccprojectionApproval> AccprojectionApproval { get; set; }
        public virtual DbSet<AccprojectionTrades> AccprojectionTrades { get; set; }
        public virtual DbSet<AccprojectionVerificationRule> AccprojectionVerificationRule { get; set; }
        public virtual DbSet<AdditionalBenchmarkInstrument> AdditionalBenchmarkInstrument { get; set; }
        public virtual DbSet<AdminChangeLog> AdminChangeLog { get; set; }
        public virtual DbSet<AliasType> AliasType { get; set; }
        public virtual DbSet<ApprovalStatus> ApprovalStatus { get; set; }
        public virtual DbSet<AssetAllocation> AssetAllocation { get; set; }
        public virtual DbSet<AssetClass> AssetClass { get; set; }
        public virtual DbSet<AssetClassGroup> AssetClassGroup { get; set; }
        public virtual DbSet<AutoClassificationMapping> AutoClassificationMapping { get; set; }
        public virtual DbSet<BbaimaccountStatus> BbaimaccountStatus { get; set; }
        public virtual DbSet<BbaimsubTypeMapping> BbaimsubTypeMapping { get; set; }
        public virtual DbSet<BbaimswapMapping> BbaimswapMapping { get; set; }
        public virtual DbSet<BbcurrencyMapping> BbcurrencyMapping { get; set; }
        public virtual DbSet<Bbexchange> Bbexchange { get; set; }
        public virtual DbSet<BenchmarkComponent> BenchmarkComponent { get; set; }
        public virtual DbSet<BenchmarkComponentDetail> BenchmarkComponentDetail { get; set; }
        public virtual DbSet<CashAdjustmentSubType> CashAdjustmentSubType { get; set; }
        public virtual DbSet<CashAdjustmentType> CashAdjustmentType { get; set; }
        public virtual DbSet<ComplianceApproval> ComplianceApproval { get; set; }
        public virtual DbSet<ComplianceApprovalHistory> ComplianceApprovalHistory { get; set; }
        public virtual DbSet<ComplianceAuthorisationRule> ComplianceAuthorisationRule { get; set; }
        public virtual DbSet<ComplianceEditTest> ComplianceEditTest { get; set; }
        public virtual DbSet<ComplianceEditTestHistory> ComplianceEditTestHistory { get; set; }
        public virtual DbSet<CounterParty> CounterParty { get; set; }
        public virtual DbSet<CounterPartyAlias> CounterPartyAlias { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<CountrySector> CountrySector { get; set; }
        public virtual DbSet<CreditAgency> CreditAgency { get; set; }
        public virtual DbSet<CreditRating> CreditRating { get; set; }
        public virtual DbSet<CurrencyExposureUnhedgedBenchmark> CurrencyExposureUnhedgedBenchmark { get; set; }
        public virtual DbSet<CustodianGl> CustodianGl { get; set; }
        public virtual DbSet<CustodianGlhistory> CustodianGlhistory { get; set; }
        public virtual DbSet<CustodianGlmapping> CustodianGlmapping { get; set; }
        public virtual DbSet<DateType> DateType { get; set; }
        public virtual DbSet<Dbversion> Dbversion { get; set; }
        public virtual DbSet<DiscountConfig> DiscountConfig { get; set; }
        public virtual DbSet<DiscountFactors> DiscountFactors { get; set; }
        public virtual DbSet<EntityLink> EntityLink { get; set; }
        public virtual DbSet<EntityLinkType> EntityLinkType { get; set; }
        public virtual DbSet<EntityType> EntityType { get; set; }
        public virtual DbSet<EquityManagerPosition> EquityManagerPosition { get; set; }
        public virtual DbSet<EquityManagerTrade> EquityManagerTrade { get; set; }
        public virtual DbSet<Exchange> Exchange { get; set; }
        public virtual DbSet<Filter> Filter { get; set; }
        public virtual DbSet<Fimanager> Fimanager { get; set; }
        public virtual DbSet<FinancialCalendar> FinancialCalendar { get; set; }
        public virtual DbSet<FundingAccountAssetClassBenchmark> FundingAccountAssetClassBenchmark { get; set; }
        public virtual DbSet<FundingAccountAssetClassSplit> FundingAccountAssetClassSplit { get; set; }
        public virtual DbSet<FundingAccountPortfolioBenchmark> FundingAccountPortfolioBenchmark { get; set; }
        public virtual DbSet<FundingAccounts> FundingAccounts { get; set; }
        public virtual DbSet<FundingAllocations> FundingAllocations { get; set; }
        public virtual DbSet<FutureAccount> FutureAccount { get; set; }
        public virtual DbSet<FutureInstrument> FutureInstrument { get; set; }
        public virtual DbSet<FuturePosition> FuturePosition { get; set; }
        public virtual DbSet<FuturesBalance> FuturesBalance { get; set; }
        public virtual DbSet<FutureTrade> FutureTrade { get; set; }
        public virtual DbSet<Gics> Gics { get; set; }
        public virtual DbSet<Glstatus> Glstatus { get; set; }
        public virtual DbSet<GlstatusHistory> GlstatusHistory { get; set; }
        public virtual DbSet<Holding> Holding { get; set; }
        public virtual DbSet<Ifrshistory> Ifrshistory { get; set; }
        public virtual DbSet<Instrument> Instrument { get; set; }
        public virtual DbSet<InstrumentClassification> InstrumentClassification { get; set; }
        public virtual DbSet<InstrumentClassificationHistory> InstrumentClassificationHistory { get; set; }
        public virtual DbSet<InstrumentClassificationType> InstrumentClassificationType { get; set; }
        public virtual DbSet<InstrumentCouponHistory> InstrumentCouponHistory { get; set; }
        public virtual DbSet<InstrumentCreditRating> InstrumentCreditRating { get; set; }
        public virtual DbSet<InstrumentGroup> InstrumentGroup { get; set; }
        public virtual DbSet<InstrumentGroupProperty> InstrumentGroupProperty { get; set; }
        public virtual DbSet<InstrumentGroupType> InstrumentGroupType { get; set; }
        public virtual DbSet<InstrumentHistory> InstrumentHistory { get; set; }
        public virtual DbSet<InstrumentMarketData> InstrumentMarketData { get; set; }
        public virtual DbSet<InstrumentMarketDataArchive> InstrumentMarketDataArchive { get; set; }
        public virtual DbSet<InstrumentPortfolio> InstrumentPortfolio { get; set; }
        public virtual DbSet<InstrumentRelationship> InstrumentRelationship { get; set; }
        public virtual DbSet<InstrumentSubType> InstrumentSubType { get; set; }
        public virtual DbSet<InstrumentType> InstrumentType { get; set; }
        public virtual DbSet<InstrumentTypeTransactionType> InstrumentTypeTransactionType { get; set; }
        public virtual DbSet<Issuer> Issuer { get; set; }
        public virtual DbSet<IssuerCreditDowngrade> IssuerCreditDowngrade { get; set; }
        public virtual DbSet<IssuerCreditRating> IssuerCreditRating { get; set; }
        public virtual DbSet<IssuerUnderwritingAdjustment> IssuerUnderwritingAdjustment { get; set; }
        public virtual DbSet<JpmcashAdjustment> JpmcashAdjustment { get; set; }
        public virtual DbSet<JpmcashProjection> JpmcashProjection { get; set; }
        public virtual DbSet<JpmcategorySubTypeColumn> JpmcategorySubTypeColumn { get; set; }
        public virtual DbSet<Jpmcustody> Jpmcustody { get; set; }
        public virtual DbSet<JpmpostedCashBalance> JpmpostedCashBalance { get; set; }
        public virtual DbSet<JpmpostedCashDetail> JpmpostedCashDetail { get; set; }
        public virtual DbSet<JpmpostedCashSummary> JpmpostedCashSummary { get; set; }
        public virtual DbSet<JpmsubTypeMapping> JpmsubTypeMapping { get; set; }
        public virtual DbSet<ManagerHolding> ManagerHolding { get; set; }
        public virtual DbSet<MarketDataType> MarketDataType { get; set; }
        public virtual DbSet<Measure> Measure { get; set; }
        public virtual DbSet<MeasureDatasourceMapping> MeasureDatasourceMapping { get; set; }
        public virtual DbSet<Measurement> Measurement { get; set; }
        public virtual DbSet<MeasurementDependency> MeasurementDependency { get; set; }
        public virtual DbSet<MeasurementFilter> MeasurementFilter { get; set; }
        public virtual DbSet<MeasurementGrouping> MeasurementGrouping { get; set; }
        public virtual DbSet<MeasureType> MeasureType { get; set; }
        public virtual DbSet<MonthlyFaAssetClassSplit> MonthlyFaAssetClassSplit { get; set; }
        public virtual DbSet<NzinterestRateDerivative> NzinterestRateDerivative { get; set; }
        public virtual DbSet<OnCallCashAssignment> OnCallCashAssignment { get; set; }
        public virtual DbSet<OpenFfxposition> OpenFfxposition { get; set; }
        public virtual DbSet<OracleGl> OracleGl { get; set; }
        public virtual DbSet<PerformanceHistory> PerformanceHistory { get; set; }
        public virtual DbSet<PerformanceHistoryDetails> PerformanceHistoryDetails { get; set; }
        public virtual DbSet<PlaceOfSettlement> PlaceOfSettlement { get; set; }
        public virtual DbSet<Portfolio> Portfolio { get; set; }
        public virtual DbSet<PortfolioAssetClass> PortfolioAssetClass { get; set; }
        public virtual DbSet<PortfolioComponent> PortfolioComponent { get; set; }
        public virtual DbSet<Provider> Provider { get; set; }
        public virtual DbSet<ProviderDataSource> ProviderDataSource { get; set; }
        public virtual DbSet<ProviderRequest> ProviderRequest { get; set; }
        public virtual DbSet<ProviderRequestItem> ProviderRequestItem { get; set; }
        public virtual DbSet<Reconciliation> Reconciliation { get; set; }
        public virtual DbSet<ReconciliationCategory> ReconciliationCategory { get; set; }
        public virtual DbSet<ReconciliationCategoryReconciliation> ReconciliationCategoryReconciliation { get; set; }
        public virtual DbSet<ReconciliationDefinition> ReconciliationDefinition { get; set; }
        public virtual DbSet<ReconciliationDefinitionRun> ReconciliationDefinitionRun { get; set; }
        public virtual DbSet<ReconciliationRun> ReconciliationRun { get; set; }
        public virtual DbSet<ReconciliationUserGroup> ReconciliationUserGroup { get; set; }
        public virtual DbSet<ReconciliationValidation> ReconciliationValidation { get; set; }
        public virtual DbSet<ReconciliationValidationReconciliation> ReconciliationValidationReconciliation { get; set; }
        public virtual DbSet<ReconciliationValidationRun> ReconciliationValidationRun { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<RegionCountryMapping> RegionCountryMapping { get; set; }
        public virtual DbSet<RelatedType> RelatedType { get; set; }
        public virtual DbSet<ResourceFile> ResourceFile { get; set; }
        public virtual DbSet<ResourceFileVersion> ResourceFileVersion { get; set; }
        public virtual DbSet<RestrictedInstrumentExclusion> RestrictedInstrumentExclusion { get; set; }
        public virtual DbSet<Sshentity> Sshentity { get; set; }
        public virtual DbSet<Sshevent> Sshevent { get; set; }
        public virtual DbSet<SsheventType> SsheventType { get; set; }
        public virtual DbSet<Sshtest> Sshtest { get; set; }
        public virtual DbSet<Ssi> Ssi { get; set; }
        public virtual DbSet<Ssihistory> Ssihistory { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<SwapHolidayList> SwapHolidayList { get; set; }
        public virtual DbSet<SystemVariables> SystemVariables { get; set; }
        public virtual DbSet<Test> Test { get; set; }
        public virtual DbSet<TestDefinition> TestDefinition { get; set; }
        public virtual DbSet<TestGroup> TestGroup { get; set; }
        public virtual DbSet<TestRange> TestRange { get; set; }
        public virtual DbSet<TestRangeDynamic> TestRangeDynamic { get; set; }
        public virtual DbSet<TestRun> TestRun { get; set; }
        public virtual DbSet<TestRunGroup> TestRunGroup { get; set; }
        public virtual DbSet<TestRunItem> TestRunItem { get; set; }
        public virtual DbSet<TestRunItemRange> TestRunItemRange { get; set; }
        public virtual DbSet<TestRunItemStep> TestRunItemStep { get; set; }
        public virtual DbSet<TestRunStatus> TestRunStatus { get; set; }
        public virtual DbSet<TestRunType> TestRunType { get; set; }
        public virtual DbSet<TestStatus> TestStatus { get; set; }
        public virtual DbSet<TestStep> TestStep { get; set; }
        public virtual DbSet<TestStepType> TestStepType { get; set; }
        public virtual DbSet<TestType> TestType { get; set; }
        public virtual DbSet<TickerExchange> TickerExchange { get; set; }
        public virtual DbSet<TotalEquityWeightReported> TotalEquityWeightReported { get; set; }
        public virtual DbSet<TotalEquityWeightTestHistory> TotalEquityWeightTestHistory { get; set; }
        public virtual DbSet<Trade> Trade { get; set; }
        public virtual DbSet<TradeConfirmation> TradeConfirmation { get; set; }
        public virtual DbSet<TradeConfirmationFx> TradeConfirmationFx { get; set; }
        public virtual DbSet<TradeGroup> TradeGroup { get; set; }
        public virtual DbSet<TradeHistory> TradeHistory { get; set; }
        public virtual DbSet<TradeRelationshipType> TradeRelationshipType { get; set; }
        public virtual DbSet<TradeStatus> TradeStatus { get; set; }
        public virtual DbSet<Transaction> Transaction { get; set; }
        public virtual DbSet<TransactionHistory> TransactionHistory { get; set; }
        public virtual DbSet<TransactionLeg> TransactionLeg { get; set; }
        public virtual DbSet<TransactionLegHistory> TransactionLegHistory { get; set; }
        public virtual DbSet<TransactionType> TransactionType { get; set; }
        public virtual DbSet<TypeSettlementPlace> TypeSettlementPlace { get; set; }

       
        // Unable to generate entity type for table 'dbo.AssetClassGroupComponent'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FutureOptionPL'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FXManagerTrade'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SystemVariableReference'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FXRateHistory'. Please see the warning messages.


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccadjustmentHistory>(entity =>
            {
                entity.HasKey(e => e.AdjustmentHistoryId);

                entity.ToTable("ACCAdjustmentHistory");
                

                entity.Property(e => e.AdjustmentHistoryId).HasColumnName("AdjustmentHistoryID");

                entity.Property(e => e.AjustmentStatusId).HasColumnName("AjustmentStatusID");

                entity.Property(e => e.Comments).HasColumnType("nvarchar(1000)");

                entity.Property(e => e.HoldingId).HasColumnName("HoldingID");

                entity.Property(e => e.Ifrs).HasColumnName("IFRS");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.WhenCreated).HasColumnType("datetime");

                entity.Property(e => e.WhoChanged).HasMaxLength(255);

                entity.HasOne(d => d.AjustmentStatus)
                    .WithMany(p => p.AccadjustmentHistory)
                    .HasForeignKey(d => d.AjustmentStatusId)
                    .HasConstraintName("FK_AdjustmentHistory_AdjustmentStatus");

                entity.HasOne(d => d.Holding)
                    .WithMany(p => p.AccadjustmentHistory)
                    .HasForeignKey(d => d.HoldingId)
                    .HasConstraintName("FK_AdjustmentHistory_Holdings");
            });
            

            modelBuilder.Entity<VwValuations>(entity =>
            {
                entity.HasKey(e => e.InstrumentId);

                entity.ToTable("VwValuations");

                entity.Property(e => e.InstrumentId)
                                .HasColumnName("InstrumentId")
                                .HasMaxLength(50);
                
                entity.Property(e => e.Instrument_Name)
                                .HasColumnName("Instrument_Name")
                                .HasColumnType("nvarchar(4000)");

                entity.Property(e => e.Market_Value_Local_Discount)
                                .HasColumnName("Market_Value_Local_Discount")
                                .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PortfolioId)
                              .HasColumnName("PortfolioId")
                              .HasMaxLength(50);

                entity.Property(e => e.ValuationDate)
                              .HasColumnName("ValuationDate")
                              .HasColumnType("datetime");
                
            });



            modelBuilder.Entity<AccadjustmentStatus>(entity =>
            {
                entity.HasKey(e => e.AdjustmentStatusId);

                entity.ToTable("ACCAdjustmentStatus");

                entity.Property(e => e.AdjustmentStatusId).HasColumnName("AdjustmentStatusID");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusCode).HasMaxLength(50);
            });

            modelBuilder.Entity<AccethicalExclusions>(entity =>
            {
                entity.ToTable("ACCEthicalExclusions");

                entity.Property(e => e.AccethicalExclusionsId).HasColumnName("ACCEthicalExclusionsID");

                entity.Property(e => e.AntiPersonnelMines).HasDefaultValueSql("((0))");

                entity.Property(e => e.BbcompanyId)
                    .HasColumnName("BBCompanyID")
                    .HasMaxLength(50);

                entity.Property(e => e.BbglobalCompanyId)
                    .IsRequired()
                    .HasColumnName("BBGlobalCompanyID")
                    .HasMaxLength(50);

                entity.Property(e => e.ClusterMunitions).HasDefaultValueSql("((0))");

                entity.Property(e => e.CompanyName).IsRequired();

                entity.Property(e => e.CorporateBehavior).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.Isin)
                    .HasColumnName("ISIN")
                    .HasMaxLength(50);

                entity.Property(e => e.NuclearWeapons).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tobacco).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<AccountingBudget>(entity =>
            {
                entity.Property(e => e.AccountingBudgetId).HasColumnName("AccountingBudgetID");

                entity.Property(e => e.AccountingBudgetGroupId).HasColumnName("AccountingBudgetGroupID");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.Value).HasColumnType("decimal(18, 6)");

                entity.HasOne(d => d.AccountingBudgetGroup)
                    .WithMany(p => p.AccountingBudget)
                    .HasForeignKey(d => d.AccountingBudgetGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountingBudget_AccountingBudgetGroup");
            });

            modelBuilder.Entity<AccountingBudgetGroup>(entity =>
            {
                entity.Property(e => e.AccountingBudgetGroupId).HasColumnName("AccountingBudgetGroupID");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.UpdatedBy).IsRequired();

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.AccountingBudgetGroup)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountingBudgetGroup_Status");
            });

            modelBuilder.Entity<AccprojectionAdjustment>(entity =>
            {
                entity.ToTable("ACCProjectionAdjustment");

                entity.Property(e => e.AccprojectionAdjustmentId).HasColumnName("ACCProjectionAdjustmentID");

                entity.Property(e => e.AdjustmentDate).HasColumnType("date");

                entity.Property(e => e.BeneficiaryBankBic)
                    .HasColumnName("BeneficiaryBankBIC")
                    .HasMaxLength(255);

                entity.Property(e => e.ClientRef).HasMaxLength(50);

                entity.Property(e => e.CounterPartyName).HasMaxLength(255);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.InstrumentId).HasColumnName("InstrumentID");

                entity.Property(e => e.NationalClearingCode).HasMaxLength(255);

                entity.Property(e => e.PortfolioId).HasColumnName("PortfolioID");

                entity.Property(e => e.ProjectedDate).HasColumnType("date");

                entity.Property(e => e.TransactionType).HasMaxLength(50);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UltimateBeneficiary).HasMaxLength(255);

                entity.Property(e => e.UltimateBeneficiaryAccount).HasMaxLength(255);

                entity.Property(e => e.UltimateBeneficiaryBic)
                    .HasColumnName("UltimateBeneficiaryBIC")
                    .HasMaxLength(255);

                entity.Property(e => e.Value).HasColumnType("decimal(18, 6)");

                entity.HasOne(d => d.Instrument)
                    .WithMany(p => p.AccprojectionAdjustment)
                    .HasForeignKey(d => d.InstrumentId)
                    .HasConstraintName("FK_ACCProjectionAdjustment_Instrument");

                entity.HasOne(d => d.Portfolio)
                    .WithMany(p => p.AccprojectionAdjustment)
                    .HasForeignKey(d => d.PortfolioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACCProjectionAdjustment_Portfolio");
            });

            modelBuilder.Entity<AccprojectionApproval>(entity =>
            {
                entity.ToTable("ACCProjectionApproval");

                entity.Property(e => e.AccprojectionApprovalId).HasColumnName("ACCProjectionApprovalID");

                entity.Property(e => e.ApprovedBy).HasMaxLength(255);

                entity.Property(e => e.ApprovedDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.PostedDate).HasColumnType("date");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.AccprojectionApproval)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACCProjectionApproval_Status");
            });

            modelBuilder.Entity<AccprojectionTrades>(entity =>
            {
                entity.ToTable("ACCProjectionTrades");

                entity.Property(e => e.AccprojectionTradesId).HasColumnName("ACCProjectionTradesID");

                entity.Property(e => e.PostedDate).HasColumnType("date");

                entity.Property(e => e.TradeId).HasColumnName("TradeID");

                entity.HasOne(d => d.Trade)
                    .WithMany(p => p.AccprojectionTrades)
                    .HasForeignKey(d => d.TradeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACCProjectionTrades_Trades");
            });

            modelBuilder.Entity<AccprojectionVerificationRule>(entity =>
            {
                entity.ToTable("ACCProjectionVerificationRule");

                entity.Property(e => e.AccprojectionVerificationRuleId).HasColumnName("ACCProjectionVerificationRuleID");

                entity.Property(e => e.Currency).HasMaxLength(3);

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.PortfolioId).HasColumnName("PortfolioID");

                entity.Property(e => e.RuleType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Value).HasColumnType("decimal(18, 6)");

                entity.HasOne(d => d.Portfolio)
                    .WithMany(p => p.AccprojectionVerificationRule)
                    .HasForeignKey(d => d.PortfolioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACCProjectionVerificationRule_Portfolio");
            });

            modelBuilder.Entity<AdditionalBenchmarkInstrument>(entity =>
            {
                entity.HasKey(e => e.AddBmInsId);

                entity.Property(e => e.AddBmInsId).HasColumnName("AddBmInsID");

                entity.Property(e => e.InstrumentId).HasColumnName("InstrumentID");

                entity.Property(e => e.PortfolioId).HasColumnName("PortfolioID");

                entity.HasOne(d => d.Instrument)
                    .WithMany(p => p.AdditionalBenchmarkInstrument)
                    .HasForeignKey(d => d.InstrumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ABI_Instrument");

                entity.HasOne(d => d.Portfolio)
                    .WithMany(p => p.AdditionalBenchmarkInstrument)
                    .HasForeignKey(d => d.PortfolioId)
                    .HasConstraintName("FK_ABI_Portfolio");
            });

            modelBuilder.Entity<AdminChangeLog>(entity =>
            {
                entity.Property(e => e.AdminChangeLogId).HasColumnName("AdminChangeLogID");

                entity.Property(e => e.Column).IsRequired();

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.NewValue).IsRequired();

                entity.Property(e => e.OldValue).IsRequired();

                entity.Property(e => e.Table).IsRequired();

                entity.Property(e => e.TableKey).IsRequired();

                entity.Property(e => e.UserName).IsRequired();
            });

            modelBuilder.Entity<AliasType>(entity =>
            {
                entity.Property(e => e.AliasTypeCode).HasMaxLength(100);

                entity.Property(e => e.AliasTypeDesc).HasMaxLength(200);

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ApprovalStatus>(entity =>
            {
                entity.Property(e => e.ApprovalStatusId).HasColumnName("ApprovalStatusID");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusCode).HasMaxLength(50);
            });

            modelBuilder.Entity<AssetAllocation>(entity =>
            {
                entity.Property(e => e.AssetAllocationId).HasColumnName("AssetAllocationID");

                entity.Property(e => e.Comment).HasColumnType("nvarchar(1000)");

                entity.Property(e => e.DealtRates).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.Earners).HasColumnType("numeric(18, 10)");

                entity.Property(e => e.FromPortfolioId).HasColumnName("FromPortfolioID");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.MotorVehicle).HasColumnType("numeric(18, 10)");

                entity.Property(e => e.NewEmployers).HasColumnType("numeric(18, 10)");

                entity.Property(e => e.NonEarners).HasColumnType("numeric(18, 10)");

                entity.Property(e => e.RefNum)
                    .IsRequired()
                    .HasColumnType("nvarchar(1000)");

                entity.Property(e => e.ResidualEmployers).HasColumnType("numeric(18, 10)");

                entity.Property(e => e.RevalRates).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.SelfEmployed).HasColumnType("numeric(18, 10)");

                entity.Property(e => e.ToPortfolioId).HasColumnName("ToPortfolioID");

                entity.Property(e => e.TransferFrom).HasColumnType("nvarchar(1000)");

                entity.Property(e => e.TransferTo).HasColumnType("nvarchar(1000)");

                entity.Property(e => e.TreatmentInjury).HasColumnType("numeric(18, 10)");

                entity.Property(e => e.ValuationDate).HasColumnType("date");

                entity.HasOne(d => d.FromPortfolio)
                    .WithMany(p => p.AssetAllocationFromPortfolio)
                    .HasForeignKey(d => d.FromPortfolioId)
                    .HasConstraintName("FK_AssetAllocation_FromPortfolioID");

                entity.HasOne(d => d.ToPortfolio)
                    .WithMany(p => p.AssetAllocationToPortfolio)
                    .HasForeignKey(d => d.ToPortfolioId)
                    .HasConstraintName("FK_AssetAllocation_ToPortfolioID");
            });

            modelBuilder.Entity<AssetClass>(entity =>
            {
                entity.Property(e => e.AssetClassId).HasColumnName("AssetClassID");

                entity.Property(e => e.AssetClassName).HasColumnType("nvarchar(1000)");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<AssetClassGroup>(entity =>
            {
                entity.Property(e => e.AssetClassGroupId).HasColumnName("AssetClassGroupID");

                entity.Property(e => e.AssetClassGroupDesc)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.AssetClassGroupName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<AutoClassificationMapping>(entity =>
            {
                entity.Property(e => e.AutoClassificationMappingId).HasColumnName("AutoClassificationMappingID");

                entity.Property(e => e.Country)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InstrumentClassificationId).HasColumnName("InstrumentClassificationID");

                entity.Property(e => e.InstrumentSubTypeId).HasColumnName("InstrumentSubTypeID");

                entity.Property(e => e.InstrumentTypeId).HasColumnName("InstrumentTypeID");

                entity.HasOne(d => d.InstrumentClassification)
                    .WithMany(p => p.AutoClassificationMapping)
                    .HasForeignKey(d => d.InstrumentClassificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AutoClassificationMapping_InstrumentClassification");

                entity.HasOne(d => d.InstrumentSubType)
                    .WithMany(p => p.AutoClassificationMapping)
                    .HasForeignKey(d => d.InstrumentSubTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AutoClassificationMapping_InstrumentSubType");

                entity.HasOne(d => d.InstrumentType)
                    .WithMany(p => p.AutoClassificationMapping)
                    .HasForeignKey(d => d.InstrumentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AutoClassificationMapping_InstrumentType");
            });

            modelBuilder.Entity<BbaimaccountStatus>(entity =>
            {
                entity.HasKey(e => e.PortfolioId);

                entity.ToTable("BBAIMAccountStatus");

                entity.Property(e => e.PortfolioId)
                    .HasColumnName("PortfolioID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BbaimaccountCode)
                    .IsRequired()
                    .HasColumnName("BBAIMAccountCode")
                    .HasMaxLength(255);

                entity.Property(e => e.BbaimlastRefId)
                    .HasColumnName("BBAIMLastRefID")
                    .HasMaxLength(255);

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastProcessedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Portfolio)
                    .WithOne(p => p.BbaimaccountStatus)
                    .HasForeignKey<BbaimaccountStatus>(d => d.PortfolioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BBAIM_Portfolio");
            });

            modelBuilder.Entity<BbaimsubTypeMapping>(entity =>
            {
                entity.ToTable("BBAIMSubTypeMapping");

                entity.Property(e => e.BbaimsubTypeMappingId).HasColumnName("BBAIMSubTypeMappingID");

                entity.Property(e => e.BbSubflag)
                    .HasColumnName("BB_SUBFLAG")
                    .HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.InstrumentSubTypeId).HasColumnName("InstrumentSubTypeID");

                entity.Property(e => e.InstrumentTypeId).HasColumnName("InstrumentTypeID");

                entity.Property(e => e.MarketSector2)
                    .HasColumnName("MARKET_SECTOR2")
                    .HasMaxLength(255);

                entity.Property(e => e.SecurityTyp2)
                    .HasColumnName("SECURITY_TYP2")
                    .HasMaxLength(255);

                entity.HasOne(d => d.InstrumentSubType)
                    .WithMany(p => p.BbaimsubTypeMapping)
                    .HasForeignKey(d => d.InstrumentSubTypeId)
                    .HasConstraintName("FK_BBAIMSubTypeMapping_InstrumentSubType");

                entity.HasOne(d => d.InstrumentType)
                    .WithMany(p => p.BbaimsubTypeMapping)
                    .HasForeignKey(d => d.InstrumentTypeId)
                    .HasConstraintName("FK_BBAIMSubTypeMapping_InstrumentType");
            });

            modelBuilder.Entity<BbaimswapMapping>(entity =>
            {
                entity.ToTable("BBAIMSwapMapping");

                entity.Property(e => e.BbaimswapMappingId).HasColumnName("BBAIMSwapMappingID");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Idscode)
                    .HasColumnName("IDSCode")
                    .HasMaxLength(255);

                entity.Property(e => e.SwapConvention).HasMaxLength(255);

                entity.Property(e => e.SwapDayCount).HasMaxLength(255);

                entity.Property(e => e.SwapFixingName).HasMaxLength(255);

                entity.Property(e => e.SwapFrequency).HasMaxLength(255);

                entity.Property(e => e.SwapHolidayList).HasMaxLength(255);
            });

            modelBuilder.Entity<BbcurrencyMapping>(entity =>
            {
                entity.HasKey(e => e.BloombergCode);

                entity.ToTable("BBCurrencyMapping");

                entity.Property(e => e.BloombergCode)
                    .HasMaxLength(3)
                    .ValueGeneratedNever();

                entity.Property(e => e.CurrencyDescription).HasMaxLength(30);

                entity.Property(e => e.Isocode)
                    .IsRequired()
                    .HasColumnName("ISOCode")
                    .HasMaxLength(3);
            });

            modelBuilder.Entity<Bbexchange>(entity =>
            {
                entity.HasKey(e => e.Exch);

                entity.ToTable("BBExchange");

                entity.Property(e => e.Exch)
                    .HasColumnName("EXCH")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ExchangeId).HasColumnName("ExchangeID");

                entity.HasOne(d => d.Exchange)
                    .WithMany(p => p.Bbexchange)
                    .HasForeignKey(d => d.ExchangeId)
                    .HasConstraintName("FK_BBExchange");
            });

            modelBuilder.Entity<BenchmarkComponent>(entity =>
            {
                entity.Property(e => e.BenchmarkComponentId).HasColumnName("BenchmarkComponentID");

                entity.Property(e => e.ApprovedBy).HasMaxLength(255);

                entity.Property(e => e.ApprovedDateTime).HasColumnType("datetime");

                entity.Property(e => e.AssetClassId).HasColumnName("AssetClassID");

                entity.Property(e => e.BenchmarkType)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.EffectiveFrom).HasColumnType("date");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.PortfolioId).HasColumnName("PortfolioID");

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.AssetClass)
                    .WithMany(p => p.BenchmarkComponent)
                    .HasForeignKey(d => d.AssetClassId)
                    .HasConstraintName("FK_BenchmarkComponent_AssetClass");

                entity.HasOne(d => d.Portfolio)
                    .WithMany(p => p.BenchmarkComponent)
                    .HasForeignKey(d => d.PortfolioId)
                    .HasConstraintName("FK_BenchmarkComponent_Portfolio");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.BenchmarkComponent)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BenchmarkComponent_Status");
            });

            modelBuilder.Entity<BenchmarkComponentDetail>(entity =>
            {
                entity.Property(e => e.BenchmarkComponentDetailId).HasColumnName("BenchmarkComponentDetailID");

                entity.Property(e => e.AnnualisedMargin).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.BenchmarkComponentId).HasColumnName("BenchmarkComponentID");

                entity.Property(e => e.Currency).HasMaxLength(3);

                entity.Property(e => e.HedgingWeight).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.InstrumentId).HasColumnName("InstrumentID");

                entity.Property(e => e.InstrumentWeight).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ManagerLocalAud)
                    .HasColumnName("ManagerLocalAUD")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.BenchmarkComponent)
                    .WithMany(p => p.BenchmarkComponentDetail)
                    .HasForeignKey(d => d.BenchmarkComponentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BenchmarkComponentDetail_Benchmark");

                entity.HasOne(d => d.Instrument)
                    .WithMany(p => p.BenchmarkComponentDetail)
                    .HasForeignKey(d => d.InstrumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BenchmarkComponentDetail_Instrument");
            });

            modelBuilder.Entity<CashAdjustmentSubType>(entity =>
            {
                entity.Property(e => e.CashAdjustmentSubTypeId).HasColumnName("CashAdjustmentSubTypeID");

                entity.Property(e => e.CashAdjustmentSubTypeCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CashAdjustmentSubTypeDesc)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CashAdjustmentTypeId).HasColumnName("CashAdjustmentTypeID");

                entity.HasOne(d => d.CashAdjustmentType)
                    .WithMany(p => p.CashAdjustmentSubType)
                    .HasForeignKey(d => d.CashAdjustmentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CashAdjustmentSubType_CashAdjustmentType");
            });

            modelBuilder.Entity<CashAdjustmentType>(entity =>
            {
                entity.Property(e => e.CashAdjustmentTypeId).HasColumnName("CashAdjustmentTypeID");

                entity.Property(e => e.CashAdjustmentTypeCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CashAdjustmentTypeDesc)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ComplianceApproval>(entity =>
            {
                entity.HasKey(e => new { e.ValuationDate, e.Final });

                entity.Property(e => e.ValuationDate).HasColumnType("date");

                entity.Property(e => e.Final).HasDefaultValueSql("((0))");

                entity.Property(e => e.Approved).HasDefaultValueSql("((0))");

                entity.Property(e => e.Comment).IsRequired();

                entity.Property(e => e.TimeLastModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ComplianceApprovalHistory>(entity =>
            {
                entity.HasKey(e => new { e.ValuationDate, e.Final, e.Version });

                entity.Property(e => e.ValuationDate).HasColumnType("date");

                entity.Property(e => e.Final).HasDefaultValueSql("((0))");

                entity.Property(e => e.Approved).HasDefaultValueSql("((0))");

                entity.Property(e => e.Comment).IsRequired();

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.ComplianceApproval)
                    .WithMany(p => p.ComplianceApprovalHistory)
                    .HasForeignKey(d => new { d.ValuationDate, d.Final })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ComplianceApprovalHistory_ComplianceApproval");
            });

            modelBuilder.Entity<ComplianceAuthorisationRule>(entity =>
            {
                entity.Property(e => e.ComplianceAuthorisationRuleId).HasColumnName("ComplianceAuthorisationRuleID");

                entity.Property(e => e.Currency).HasMaxLength(3);

                entity.Property(e => e.ExchangeId).HasColumnName("ExchangeID");

                entity.Property(e => e.Exclude).HasDefaultValueSql("((0))");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.InstrumentSubTypeId).HasColumnName("InstrumentSubTypeID");

                entity.Property(e => e.InstrumentTypeId).HasColumnName("InstrumentTypeID");

                entity.Property(e => e.Isin)
                    .HasColumnName("ISIN")
                    .HasMaxLength(255);

                entity.Property(e => e.PortfolioId).HasColumnName("PortfolioID");

                entity.Property(e => e.Sedol).HasMaxLength(255);

                entity.HasOne(d => d.Exchange)
                    .WithMany(p => p.ComplianceAuthorisationRule)
                    .HasForeignKey(d => d.ExchangeId)
                    .HasConstraintName("FK_ComplianceAuthorisationRule_Exchange");

                entity.HasOne(d => d.InstrumentSubType)
                    .WithMany(p => p.ComplianceAuthorisationRule)
                    .HasForeignKey(d => d.InstrumentSubTypeId)
                    .HasConstraintName("FK_ComplianceAuthorisationRule_InstrumentSubType");

                entity.HasOne(d => d.InstrumentType)
                    .WithMany(p => p.ComplianceAuthorisationRule)
                    .HasForeignKey(d => d.InstrumentTypeId)
                    .HasConstraintName("FK_ComplianceAuthorisationRule_InstrumentType");

                entity.HasOne(d => d.Portfolio)
                    .WithMany(p => p.ComplianceAuthorisationRule)
                    .HasForeignKey(d => d.PortfolioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ComplianceAuthorisationRule_Portfolio");
            });

            modelBuilder.Entity<ComplianceEditTest>(entity =>
            {
                entity.Property(e => e.ComplianceEditTestId).HasColumnName("ComplianceEditTestID");

                entity.Property(e => e.Approved).HasDefaultValueSql("((0))");

                entity.Property(e => e.Comments).IsRequired();

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.Resolved).HasDefaultValueSql("((0))");

                entity.Property(e => e.TestAccreference)
                    .IsRequired()
                    .HasColumnName("TestACCReference");
            });

            modelBuilder.Entity<ComplianceEditTestHistory>(entity =>
            {
                entity.HasKey(e => new { e.EntryId, e.ComplianceEditTestId });

                entity.Property(e => e.EntryId).HasColumnName("EntryID");

                entity.Property(e => e.ComplianceEditTestId).HasColumnName("ComplianceEditTestID");

                entity.Property(e => e.Change).IsRequired();

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.ComplianceEditTest)
                    .WithMany(p => p.ComplianceEditTestHistory)
                    .HasForeignKey(d => d.ComplianceEditTestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ComplianceEditTestHistory_ComplianceEditTest");
            });

            modelBuilder.Entity<CounterParty>(entity =>
            {
                entity.Property(e => e.CounterPartyId).HasColumnName("CounterPartyID");

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.BrokerCode).HasMaxLength(50);

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CounterPartyName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.LoadId).HasColumnName("LoadID");
            });

            modelBuilder.Entity<CounterPartyAlias>(entity =>
            {
                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.LoadId).HasColumnName("LoadID");

                entity.HasOne(d => d.AliasType)
                    .WithMany(p => p.CounterPartyAlias)
                    .HasForeignKey(d => d.AliasTypeId);

                entity.HasOne(d => d.CounterParty)
                    .WithMany(p => p.CounterPartyAlias)
                    .HasForeignKey(d => d.CounterPartyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CounterPartyAlias_CounterParty_CounterPartyID");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Currency).HasMaxLength(3);

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.Iso2charCode)
                    .HasColumnName("ISO2CharCode")
                    .HasMaxLength(2);

                entity.Property(e => e.Iso3charCode)
                    .HasColumnName("ISO3CharCode")
                    .HasMaxLength(3);

                entity.Property(e => e.PrimaryCurrency).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<CountrySector>(entity =>
            {
                entity.Property(e => e.CountrySectorId).HasColumnName("CountrySectorID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.JpmsectorLevel4)
                    .HasColumnName("JPMSectorLevel4")
                    .HasMaxLength(255);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CountrySector)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_CountrySector_Country");
            });

            modelBuilder.Entity<CreditAgency>(entity =>
            {
                entity.Property(e => e.CreditAgencyId).HasColumnName("CreditAgencyID");

                entity.Property(e => e.CreditAgencyCode).HasMaxLength(10);

                entity.Property(e => e.CreditAgencyName).HasColumnType("nvarchar(1000)");

                entity.Property(e => e.InActive).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<CreditRating>(entity =>
            {
                entity.Property(e => e.CreditRatingId).HasColumnName("CreditRatingID");

                entity.Property(e => e.CreditAgencyId).HasColumnName("CreditAgencyID");

                entity.Property(e => e.CreditRatingCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CreditRatingType)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.InActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.SaPequivalentLongTermHighest)
                    .HasColumnName("SaPEquivalentLongTermHighest")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SaPequivalentLongTermRating).HasColumnName("SaPEquivalentLongTermRating");

                entity.Property(e => e.SaPequivalentRating).HasColumnName("SaPEquivalentRating");

                entity.HasOne(d => d.CreditAgency)
                    .WithMany(p => p.CreditRating)
                    .HasForeignKey(d => d.CreditAgencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CreditRating_CreditAgency");
            });

            modelBuilder.Entity<CurrencyExposureUnhedgedBenchmark>(entity =>
            {
                entity.HasKey(e => e.CurrencyExposureBenchmarkId);

                entity.Property(e => e.CurrencyExposureBenchmarkId).HasColumnName("CurrencyExposureBenchmarkID");

                entity.Property(e => e.AssetClassId).HasColumnName("AssetClassID");

                entity.Property(e => e.BenchmarkValue).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.EffectiveFrom).HasColumnType("date");

                entity.Property(e => e.FundingAccountId).HasColumnName("FundingAccountID");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.AssetClass)
                    .WithMany(p => p.CurrencyExposureUnhedgedBenchmark)
                    .HasForeignKey(d => d.AssetClassId)
                    .HasConstraintName("FK_CurrencyExposureBm_AssetClass");
            });

            modelBuilder.Entity<CustodianGl>(entity =>
            {
                entity.HasKey(e => e.Glid);

                entity.ToTable("CustodianGL");

                entity.Property(e => e.Glid).HasColumnName("GLID");

                entity.Property(e => e.AccountDesc).HasMaxLength(255);

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.Glaccount).HasColumnName("GLAccount");

                entity.Property(e => e.GlstatusHistoryId).HasColumnName("GLStatusHistoryID");

                entity.Property(e => e.InActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.LoadId).HasColumnName("LoadID");

                entity.Property(e => e.PortfolioId).HasColumnName("PortfolioID");

                entity.HasOne(d => d.GlstatusHistory)
                    .WithMany(p => p.CustodianGl)
                    .HasForeignKey(d => d.GlstatusHistoryId)
                    .HasConstraintName("FK_GL_StatusHistory");

                entity.HasOne(d => d.Portfolio)
                    .WithMany(p => p.CustodianGl)
                    .HasForeignKey(d => d.PortfolioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GL_Portfolio");
            });

            modelBuilder.Entity<CustodianGlhistory>(entity =>
            {
                entity.HasKey(e => e.GlhistoryId);

                entity.ToTable("CustodianGLHistory");

                entity.Property(e => e.GlhistoryId).HasColumnName("GLHistoryID");

                entity.Property(e => e.ApprovalStatusId).HasColumnName("ApprovalStatusID");

                entity.Property(e => e.Comments).HasColumnType("nvarchar(1000)");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.Glaccount).HasColumnName("GLAccount");

                entity.Property(e => e.Glid).HasColumnName("GLID");

                entity.Property(e => e.InActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.PortfolioId).HasColumnName("PortfolioID");

                entity.Property(e => e.WhenCreated).HasColumnType("datetime");

                entity.Property(e => e.WhoChanged).HasMaxLength(255);

                entity.HasOne(d => d.ApprovalStatus)
                    .WithMany(p => p.CustodianGlhistory)
                    .HasForeignKey(d => d.ApprovalStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustodianGLHistory_ApprovalStatus");

                entity.HasOne(d => d.Gl)
                    .WithMany(p => p.CustodianGlhistory)
                    .HasForeignKey(d => d.Glid)
                    .HasConstraintName("FK_CustodianGLHistory_CustodianGL");

                entity.HasOne(d => d.Portfolio)
                    .WithMany(p => p.CustodianGlhistory)
                    .HasForeignKey(d => d.PortfolioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GLHistory_Portfolio");
            });

            modelBuilder.Entity<CustodianGlmapping>(entity =>
            {
                entity.HasKey(e => e.Glaccount);

                entity.ToTable("CustodianGLMapping");

                entity.Property(e => e.Glaccount)
                    .HasColumnName("GLAccount")
                    .ValueGeneratedNever();

                entity.Property(e => e.InstrumentClassificationId).HasColumnName("InstrumentClassificationID");

                entity.HasOne(d => d.InstrumentClassification)
                    .WithMany(p => p.CustodianGlmapping)
                    .HasForeignKey(d => d.InstrumentClassificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustodianGLMapping_InstrumentClassification");
            });

            modelBuilder.Entity<DateType>(entity =>
            {
                entity.Property(e => e.DateTypeId).HasColumnName("DateTypeID");

                entity.Property(e => e.DateTypeCode)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.DateTypeDescription).HasMaxLength(255);

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Dbversion>(entity =>
            {
                entity.ToTable("DBVersion");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.VersionName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<DiscountConfig>(entity =>
            {
                entity.Property(e => e.DiscountConfigId).HasColumnName("DiscountConfigID");

                entity.Property(e => e.Exchange).HasMaxLength(255);

                entity.Property(e => e.Gicsprefix)
                    .HasColumnName("GICSPrefix")
                    .HasMaxLength(255);

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.Rounding).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Threshold).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<DiscountFactors>(entity =>
            {
                entity.HasIndex(e => e.BatchId)
                    .HasName("idxDiscountFactors_BatchID");

                entity.HasIndex(e => e.LoadId)
                    .HasName("idx_DiscountFactors_LoadId");

                entity.HasIndex(e => new { e.InstrumentId, e.ValuationDate, e.Inactive })
                    .HasName("idxDiscountFactors_InstrumentValuationInactive");

                entity.Property(e => e.DiscountFactorsId).HasColumnName("DiscountFactorsID");

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.DiscountConfigId).HasColumnName("DiscountConfigID");

                entity.Property(e => e.DiscountRate).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ExtraColumn).HasColumnType("nvarchar(1000)");

                entity.Property(e => e.HoldingPercent).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.InstrumentId).HasColumnName("InstrumentID");

                entity.Property(e => e.LoadId).HasColumnName("LoadID");

                entity.Property(e => e.StageRowId).HasColumnName("StageRowID");

                entity.Property(e => e.ValuationDate).HasColumnType("date");

                entity.HasOne(d => d.DiscountConfig)
                    .WithMany(p => p.DiscountFactors)
                    .HasForeignKey(d => d.DiscountConfigId)
                    .HasConstraintName("FK_DiscountFactors_DiscountConfig");

                entity.HasOne(d => d.Instrument)
                    .WithMany(p => p.DiscountFactors)
                    .HasForeignKey(d => d.InstrumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DiscountFactors_Instrument");
            });

            modelBuilder.Entity<EntityLink>(entity =>
            {
                entity.Property(e => e.EntityLinkId).HasColumnName("EntityLinkID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.EntityLinkTypeId).HasColumnName("EntityLinkTypeID");

                entity.Property(e => e.FromEntityId).HasColumnName("FromEntityID");

                entity.Property(e => e.FromEntityTypeId).HasColumnName("FromEntityTypeID");

                entity.Property(e => e.InActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.ToEntityId).HasColumnName("ToEntityID");

                entity.Property(e => e.ToEntityTypeId).HasColumnName("ToEntityTypeID");

                entity.HasOne(d => d.EntityLinkType)
                    .WithMany(p => p.EntityLink)
                    .HasForeignKey(d => d.EntityLinkTypeId)
                    .HasConstraintName("FK_EntityLink_EntityLinkType");

                entity.HasOne(d => d.FromEntityType)
                    .WithMany(p => p.EntityLinkFromEntityType)
                    .HasForeignKey(d => d.FromEntityTypeId)
                    .HasConstraintName("FK_EntityLink_EntityType_From");

                entity.HasOne(d => d.ToEntityType)
                    .WithMany(p => p.EntityLinkToEntityType)
                    .HasForeignKey(d => d.ToEntityTypeId)
                    .HasConstraintName("FK_EntityLink_EntityType_To");
            });

            modelBuilder.Entity<EntityLinkType>(entity =>
            {
                entity.Property(e => e.EntityLinkTypeId).HasColumnName("EntityLinkTypeID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.EntityLinkTypeName).HasMaxLength(255);

                entity.Property(e => e.InActive).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<EntityType>(entity =>
            {
                entity.Property(e => e.EntityTypeId).HasColumnName("EntityTypeID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.EntityTypeName).HasMaxLength(255);

                entity.Property(e => e.InActive).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<EquityManagerPosition>(entity =>
            {
                entity.HasKey(e => e.EquityMgrPositionId);

                entity.Property(e => e.EquityMgrPositionId).HasColumnName("EquityMgrPositionID");

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.Currency).HasMaxLength(3);

                entity.Property(e => e.InstrumentTypeId).HasColumnName("InstrumentTypeID");

                entity.Property(e => e.PortfolioId).HasColumnName("PortfolioID");

                entity.Property(e => e.Ticker).HasMaxLength(255);

                entity.Property(e => e.Units).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ValuationDate).HasColumnType("date");

                entity.HasOne(d => d.InstrumentType)
                    .WithMany(p => p.EquityManagerPosition)
                    .HasForeignKey(d => d.InstrumentTypeId)
                    .HasConstraintName("FK_EquityManagerPosition_InstrumentType");

                entity.HasOne(d => d.Portfolio)
                    .WithMany(p => p.EquityManagerPosition)
                    .HasForeignKey(d => d.PortfolioId)
                    .HasConstraintName("FK_EquityManagerPosition_Portfolio");
            });

            modelBuilder.Entity<EquityManagerTrade>(entity =>
            {
                entity.HasKey(e => e.EquityMgrTradeId);

                entity.Property(e => e.EquityMgrTradeId).HasColumnName("EquityMgrTradeID");

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.Broker).HasMaxLength(255);

                entity.Property(e => e.BrokerageCost).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.BrokerageRate).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.BuySell).HasMaxLength(255);

                entity.Property(e => e.DealDate).HasColumnType("date");

                entity.Property(e => e.PortfolioId).HasColumnName("PortfolioID");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Stock).HasMaxLength(255);

                entity.Property(e => e.TransactionValue).HasColumnType("decimal(18, 6)");

                entity.HasOne(d => d.Portfolio)
                    .WithMany(p => p.EquityManagerTrade)
                    .HasForeignKey(d => d.PortfolioId)
                    .HasConstraintName("FK_EquityManagerTrade_Portfolio");
            });

            modelBuilder.Entity<Exchange>(entity =>
            {
                entity.Property(e => e.ExchangeId).HasColumnName("ExchangeID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.ExchangeCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ExchangeName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.GroupByIssuer).HasDefaultValueSql("((0))");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sshincrement)
                    .HasColumnName("SSHIncrement")
                    .HasColumnType("decimal(18, 10)");

                entity.Property(e => e.SshmovementType).HasColumnName("SSHMovementType");

                entity.Property(e => e.Sshthreshold)
                    .HasColumnName("SSHThreshold")
                    .HasColumnType("decimal(18, 10)");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Exchange)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("Exchange_Country_FK");
            });

            modelBuilder.Entity<Filter>(entity =>
            {
                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.FilterName).HasMaxLength(255);

                entity.Property(e => e.FilterOperator).HasMaxLength(255);

                entity.Property(e => e.FilterProperty).HasMaxLength(255);

                entity.Property(e => e.FilterValue).HasMaxLength(2000);
            });

            modelBuilder.Entity<Fimanager>(entity =>
            {
                entity.ToTable("FIManager");

                entity.Property(e => e.FimanagerId).HasColumnName("FIManagerID");

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.CustodianCode)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FaceValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.InstrumentId).HasColumnName("InstrumentID");

                entity.Property(e => e.Isin)
                    .HasColumnName("ISIN")
                    .HasMaxLength(255);

                entity.Property(e => e.LoadId).HasColumnName("LoadID");

                entity.Property(e => e.PortfolioId).HasColumnName("PortfolioID");

                entity.Property(e => e.WhenCreated).HasColumnType("datetime");

                entity.HasOne(d => d.Instrument)
                    .WithMany(p => p.Fimanager)
                    .HasForeignKey(d => d.InstrumentId)
                    .HasConstraintName("FK_FIManager_Instrument");

                entity.HasOne(d => d.Portfolio)
                    .WithMany(p => p.Fimanager)
                    .HasForeignKey(d => d.PortfolioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FIManager_Portfolio");
            });

            modelBuilder.Entity<FinancialCalendar>(entity =>
            {
                entity.HasKey(e => e.CalendarId);

                entity.Property(e => e.CalendarId).HasColumnName("CalendarID");

                entity.Property(e => e.CalendarDate).HasColumnType("date");

                entity.Property(e => e.CountryCode).HasMaxLength(3);

                entity.Property(e => e.DateDescription)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DateTypeId).HasColumnName("DateTypeID");

                entity.Property(e => e.ExchangeCode).HasMaxLength(20);

                entity.Property(e => e.InstrumentTypeId).HasColumnName("InstrumentTypeID");

                entity.Property(e => e.Notes).HasMaxLength(1000);

                entity.HasOne(d => d.DateType)
                    .WithMany(p => p.FinancialCalendar)
                    .HasForeignKey(d => d.DateTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FinancialCalendar_DateType_FK");

                entity.HasOne(d => d.InstrumentType)
                    .WithMany(p => p.FinancialCalendar)
                    .HasForeignKey(d => d.InstrumentTypeId)
                    .HasConstraintName("FinancialCalendar_InstrumentType_FK");
            });

            modelBuilder.Entity<FundingAccountAssetClassBenchmark>(entity =>
            {
                entity.HasKey(e => e.AccountAssetClassBenchmarkId);

                entity.Property(e => e.AccountAssetClassBenchmarkId).HasColumnName("AccountAssetClassBenchmarkID");

                entity.Property(e => e.AssetClassId).HasColumnName("AssetClassID");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.FundingAccountId).HasColumnName("FundingAccountID");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.Value).HasColumnType("decimal(18, 12)");

                entity.HasOne(d => d.AssetClass)
                    .WithMany(p => p.FundingAccountAssetClassBenchmark)
                    .HasForeignKey(d => d.AssetClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountAssetClassBenchmark_AssetClass");

                entity.HasOne(d => d.FundingAccount)
                    .WithMany(p => p.FundingAccountAssetClassBenchmark)
                    .HasForeignKey(d => d.FundingAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountAssetClassBenchmark_FundingAccount");
            });

            modelBuilder.Entity<FundingAccountAssetClassSplit>(entity =>
            {
                entity.HasKey(e => e.AccountAssetClassSplitId);

                entity.Property(e => e.AccountAssetClassSplitId).HasColumnName("AccountAssetClassSplitID");

                entity.Property(e => e.AssetClassId).HasColumnName("AssetClassID");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.FundingAccountId).HasColumnName("FundingAccountID");

                entity.Property(e => e.FundingAccountValue).HasColumnType("decimal(20, 10)");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.Value).HasColumnType("decimal(18, 12)");

                entity.HasOne(d => d.AssetClass)
                    .WithMany(p => p.FundingAccountAssetClassSplit)
                    .HasForeignKey(d => d.AssetClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountAssetClassSplit_AssetClass");

                entity.HasOne(d => d.FundingAccount)
                    .WithMany(p => p.FundingAccountAssetClassSplit)
                    .HasForeignKey(d => d.FundingAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountAssetClassSplit_FundingAccount");
            });

            modelBuilder.Entity<FundingAccountPortfolioBenchmark>(entity =>
            {
                entity.Property(e => e.FundingAccountPortfolioBenchmarkId).HasColumnName("FundingAccountPortfolioBenchmarkID");

                entity.Property(e => e.EffectiveDate).HasColumnType("date");

                entity.Property(e => e.FundingAccountId).HasColumnName("FundingAccountID");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.PortfolioComponentId).HasColumnName("PortfolioComponentID");

                entity.Property(e => e.Value).HasColumnType("decimal(18, 6)");

                entity.HasOne(d => d.FundingAccount)
                    .WithMany(p => p.FundingAccountPortfolioBenchmark)
                    .HasForeignKey(d => d.FundingAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FundingAccountPortfolioBenchmark_FundingAccount");

                entity.HasOne(d => d.PortfolioComponent)
                    .WithMany(p => p.FundingAccountPortfolioBenchmark)
                    .HasForeignKey(d => d.PortfolioComponentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FundingAccountPortfolioBenchmark_PortfolioComponent");
            });

            modelBuilder.Entity<FundingAccounts>(entity =>
            {
                entity.HasKey(e => e.FundingAccountId);

                entity.Property(e => e.FundingAccountId).HasColumnName("FundingAccountID");

                entity.Property(e => e.FundingAccountCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.FundingAccountName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<FundingAllocations>(entity =>
            {
                entity.HasKey(e => new { e.TradeId, e.FundingAccountId });

                entity.Property(e => e.TradeId).HasColumnName("TradeID");

                entity.Property(e => e.FundingAccountId).HasColumnName("FundingAccountID");

                entity.Property(e => e.AllocationAmount)
                    .HasColumnType("decimal(24, 12)")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.FundingAccount)
                    .WithMany(p => p.FundingAllocations)
                    .HasForeignKey(d => d.FundingAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FundingAllocations_FundingAccount");

                entity.HasOne(d => d.Trade)
                    .WithMany(p => p.FundingAllocations)
                    .HasForeignKey(d => d.TradeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FundingAllocations_Trade");
            });

            modelBuilder.Entity<FutureAccount>(entity =>
            {
                entity.Property(e => e.FutureAccountId).HasColumnName("FutureAccountID");

                entity.Property(e => e.CustomAccount)
                    .IsRequired()
                    .HasColumnType("nvarchar(1000)");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.FundingAccount)
                    .WithMany(p => p.FutureAccount)
                    .HasForeignKey(d => d.FundingAccountId)
                    .HasConstraintName("FutureAccount_FK2");

                entity.HasOne(d => d.Portfolio)
                    .WithMany(p => p.FutureAccount)
                    .HasForeignKey(d => d.PortfolioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FutureAccount_FK1");
            });

            modelBuilder.Entity<FutureInstrument>(entity =>
            {
                entity.Property(e => e.FutureInstrumentId).HasColumnName("FutureInstrumentID");

                entity.Property(e => e.ContractCode)
                    .IsRequired()
                    .HasColumnName("contract_code")
                    .HasColumnType("nvarchar(1000)");

                entity.Property(e => e.IdstickerPrefix)
                    .IsRequired()
                    .HasColumnName("IDSTickerPrefix")
                    .HasColumnType("nvarchar(1000)");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<FuturePosition>(entity =>
            {
                entity.HasIndex(e => e.BatchId)
                    .HasName("idxFuturePosition_BatchID");

                entity.HasIndex(e => e.LoadId)
                    .HasName("idxFuturePosition_LoadID");

                entity.HasIndex(e => e.StatementDate)
                    .HasName("idxFuturePosition_Statement_Date");

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.BloombergTicker).HasMaxLength(255);

                entity.Property(e => e.ContractCode)
                    .HasColumnName("contract_code")
                    .HasMaxLength(10);

                entity.Property(e => e.CustomAccount)
                    .IsRequired()
                    .HasColumnName("Custom_Account")
                    .HasColumnType("nvarchar(1000)");

                entity.Property(e => e.DeltaFactor)
                    .HasColumnName("Delta_Factor")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.DeltaQuotient)
                    .HasColumnName("Delta_Quotient")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.InstrumentId).HasColumnName("InstrumentID");

                entity.Property(e => e.LoadId).HasColumnName("LoadID");

                entity.Property(e => e.LongPosition).HasColumnName("Long_Position");

                entity.Property(e => e.Month).HasColumnName("month");

                entity.Property(e => e.NetPosition).HasColumnName("Net_Position");

                entity.Property(e => e.OptionExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.PortfolioId).HasColumnName("PortfolioID");

                entity.Property(e => e.Sedol)
                    .HasColumnName("sedol")
                    .HasMaxLength(8);

                entity.Property(e => e.SettlementPrice).HasColumnName("Settlement_Price");

                entity.Property(e => e.ShortPosition).HasColumnName("Short_Position");

                entity.Property(e => e.StatementDate)
                    .HasColumnName("statement_date")
                    .HasColumnType("date");

                entity.Property(e => e.UnrealizedPL).HasColumnName("Unrealized_P&L");

                entity.Property(e => e.Year).HasColumnName("year");

                entity.HasOne(d => d.Instrument)
                    .WithMany(p => p.FuturePosition)
                    .HasForeignKey(d => d.InstrumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FuturePosition_FK2");

                entity.HasOne(d => d.Portfolio)
                    .WithMany(p => p.FuturePosition)
                    .HasForeignKey(d => d.PortfolioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FuturePosition_FK1");
            });

            modelBuilder.Entity<FuturesBalance>(entity =>
            {
                entity.HasKey(e => e.FutureBalanceId);

                entity.HasIndex(e => e.BatchId)
                    .HasName("idxFuturesBalance_BatchId");

                entity.HasIndex(e => e.LoadId)
                    .HasName("idxFuturesBalance_LoadId");

                entity.HasIndex(e => e.StatementDate)
                    .HasName("idxFuturesBalance_StatementDate");

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.CurrencyCode).HasMaxLength(3);

                entity.Property(e => e.CustomAccount)
                    .IsRequired()
                    .HasColumnType("nvarchar(1000)");

                entity.Property(e => e.InActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.InstrumentId).HasColumnName("InstrumentID");

                entity.Property(e => e.LoadId).HasColumnName("LoadID");

                entity.Property(e => e.PortfolioId).HasColumnName("PortfolioID");

                entity.Property(e => e.StatementDate).HasColumnType("date");

                entity.HasOne(d => d.Instrument)
                    .WithMany(p => p.FuturesBalance)
                    .HasForeignKey(d => d.InstrumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FutureBalances_FK2");

                entity.HasOne(d => d.Portfolio)
                    .WithMany(p => p.FuturesBalance)
                    .HasForeignKey(d => d.PortfolioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FutureBalances_FK1");
            });

            modelBuilder.Entity<FutureTrade>(entity =>
            {
                entity.HasIndex(e => e.BatchId)
                    .HasName("idxFutureTrade_BatchID");

                entity.HasIndex(e => e.LoadId)
                    .HasName("idxFutureTrade_LoadId");

                entity.HasIndex(e => e.StatementDate)
                    .HasName("idxFutureTrade_Statement_Date");

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.ClearingFees).HasColumnName("Clearing_Fees");

                entity.Property(e => e.ContractCode)
                    .HasColumnName("contract_code")
                    .HasMaxLength(10);

                entity.Property(e => e.CustomAccount)
                    .IsRequired()
                    .HasColumnName("Custom_Account")
                    .HasColumnType("nvarchar(1000)");

                entity.Property(e => e.ExecutingBroker)
                    .HasColumnName("Executing_Broker")
                    .HasColumnType("nvarchar(1000)");

                entity.Property(e => e.ExecutionFees).HasColumnName("Execution_Fees");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.InstrumentId).HasColumnName("InstrumentID");

                entity.Property(e => e.InstrumentType)
                    .HasColumnName("instrument_type")
                    .HasMaxLength(10);

                entity.Property(e => e.LoadId).HasColumnName("LoadID");

                entity.Property(e => e.Month).HasColumnName("month");

                entity.Property(e => e.NfaFees).HasColumnName("NFA_Fees");

                entity.Property(e => e.PortfolioId).HasColumnName("PortfolioID");

                entity.Property(e => e.Sedol).HasMaxLength(8);

                entity.Property(e => e.SettlementDate)
                    .HasColumnName("settlement_date")
                    .HasColumnType("nvarchar(1000)");

                entity.Property(e => e.StatementDate)
                    .HasColumnName("statement_date")
                    .HasColumnType("date");

                entity.Property(e => e.TotalFees).HasColumnName("Total_Fees");

                entity.Property(e => e.TradeDate)
                    .HasColumnName("Trade_Date")
                    .HasColumnType("date");

                entity.Property(e => e.TradePrice).HasColumnName("Trade_Price");

                entity.Property(e => e.Year).HasColumnName("year");

                entity.HasOne(d => d.Instrument)
                    .WithMany(p => p.FutureTrade)
                    .HasForeignKey(d => d.InstrumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FutureTrade_FK2");

                entity.HasOne(d => d.Portfolio)
                    .WithMany(p => p.FutureTrade)
                    .HasForeignKey(d => d.PortfolioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FutureTrade_FK1");
            });

            modelBuilder.Entity<Gics>(entity =>
            {
                entity.ToTable("GICS");

                entity.Property(e => e.Gicsid).HasColumnName("GICSID");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.IndustryCode).HasMaxLength(255);

                entity.Property(e => e.IndustryGroupCode).HasMaxLength(255);

                entity.Property(e => e.IndustryGroupName).HasMaxLength(255);

                entity.Property(e => e.IndustryName).HasMaxLength(255);

                entity.Property(e => e.SectorCode).HasMaxLength(255);

                entity.Property(e => e.SectorName).HasMaxLength(255);

                entity.Property(e => e.SubIndustryCode).HasMaxLength(255);

                entity.Property(e => e.SubIndustryName).HasMaxLength(255);
            });

            modelBuilder.Entity<Glstatus>(entity =>
            {
                entity.ToTable("GLStatus");

                entity.Property(e => e.GlstatusId).HasColumnName("GLStatusID");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusCode)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<GlstatusHistory>(entity =>
            {
                entity.ToTable("GLStatusHistory");

                entity.Property(e => e.GlstatusHistoryId).HasColumnName("GLStatusHistoryID");

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.Comment).HasMaxLength(500);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.GlstatusId)
                    .HasColumnName("GLStatusID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.PortfolioId).HasColumnName("PortfolioID");

                entity.Property(e => e.Verified).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Glstatus)
                    .WithMany(p => p.GlstatusHistory)
                    .HasForeignKey(d => d.GlstatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GL_Status");
            });

            modelBuilder.Entity<Holding>(entity =>
            {
                entity.HasIndex(e => e.BatchId)
                    .HasName("idxHolding_BatchID");

                entity.HasIndex(e => e.Inactive)
                    .HasName("idxHolding_InActive");

                entity.HasIndex(e => e.InstrumentId)
                    .HasName("idxHolding_InstrumentId");

                entity.HasIndex(e => e.LoadId)
                    .HasName("idxHolding_LoadId");

                entity.HasIndex(e => new { e.Inactive, e.PortfolioId })
                    .HasName("idxHolding_PortfolioID");

                entity.HasIndex(e => new { e.PortfolioId, e.InstrumentId, e.AccruedInterest, e.ExchangeRateLocalToPortfolio, e.MarketValueBase, e.BaseMarketValue, e.AccadjustmentDiscount, e.ValuationDate, e.Inactive })
                    .HasName("idxHolding_ValuationDateInactive");

                entity.Property(e => e.HoldingId).HasColumnName("HoldingID");

                entity.Property(e => e.AccadjustmentDiscount).HasColumnName("ACCAdjustmentDiscount");

                entity.Property(e => e.AccadjustmentIfrs).HasColumnName("ACCAdjustmentIFRS");

                entity.Property(e => e.AccadjustmentMarketValueBase).HasColumnName("ACCAdjustmentMarketValueBase");

                entity.Property(e => e.AccadjustmentStatusId).HasColumnName("ACCAdjustmentStatusID");

                entity.Property(e => e.AmortisationInPeriod).HasColumnType("nvarchar(1000)");

                entity.Property(e => e.BaseFairMarketValue).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.BaseHistoricCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.BaseMarketValue).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.BaseTotalValue).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.EarnedIncomeInPeriod).HasColumnType("nvarchar(1000)");

                entity.Property(e => e.ExchLclToPfMorDflag)
                    .HasColumnName("ExchLclToPfMorDFlag")
                    .HasMaxLength(1);

                entity.Property(e => e.ExchLclToUsdmorDflag)
                    .HasColumnName("ExchLclToUSDMorDFlag")
                    .HasMaxLength(1);

                entity.Property(e => e.ExchPfToUsdmorDflag)
                    .HasColumnName("ExchPfToUSDMorDFlag")
                    .HasMaxLength(1);

                entity.Property(e => e.ExchangeRateLocalToPortfolio).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.ExchangeRateLocalToUsd)
                    .HasColumnName("ExchangeRateLocalToUSD")
                    .HasColumnType("decimal(18, 10)");

                entity.Property(e => e.ExchangeRatePortfolioToUsd)
                    .HasColumnName("ExchangeRatePortfolioToUSD")
                    .HasColumnType("decimal(18, 10)");

                entity.Property(e => e.FuturesInitialMargin).HasColumnType("nvarchar(1000)");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.IncomeAccrued).HasDefaultValueSql("((0))");

                entity.Property(e => e.InstrumentId).HasColumnName("InstrumentID");

                entity.Property(e => e.LoadId).HasColumnName("LoadID");

                entity.Property(e => e.MarketValueBaseIfrs)
                    .HasColumnName("MarketValueBaseIFRS")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.NtAccruedIncomeBase).HasColumnName("NT_AccruedIncomeBase");

                entity.Property(e => e.NtBaseIncomeReceivable)
                    .HasColumnName("NT_BaseIncomeReceivable")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.NtMarketValueBase).HasColumnName("NT_MarketValueBase");

                entity.Property(e => e.NtTotalMarketValueBaseIfrs)
                    .HasColumnName("NT_TotalMarketValueBaseIFRS")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.OriginalFaceValue).HasColumnType("nvarchar(1000)");

                entity.Property(e => e.PortfolioCurrencyCode).HasColumnType("nvarchar(1000)");

                entity.Property(e => e.PortfolioId).HasColumnName("PortfolioID");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PriceLocalIfrs)
                    .HasColumnName("PriceLocalIFRS")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.PricingFactor).HasColumnType("numeric(18, 7)");

                entity.Property(e => e.PricingType).HasColumnType("nvarchar(1000)");

                entity.Property(e => e.SecurityMaturityDate).HasColumnType("date");

                entity.Property(e => e.StagingRowId).HasColumnName("StagingRowID");

                entity.Property(e => e.TotalMarketValueBaseIfrs)
                    .HasColumnName("TotalMarketValueBaseIFRS")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.TotalMarketValueLocalIfrs)
                    .HasColumnName("TotalMarketValueLocalIFRS")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.UnitHolding).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnrealisedProfitLossBaseIfrs)
                    .HasColumnName("UnrealisedProfitLossBaseIFRS")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ValuationDate).HasColumnType("date");

                entity.Property(e => e.ValuationRunDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.AccadjustmentStatus)
                    .WithMany(p => p.Holding)
                    .HasForeignKey(d => d.AccadjustmentStatusId)
                    .HasConstraintName("Holding_ACCAdjustmentStatus_FK");

                entity.HasOne(d => d.InstrumentPortfolio)
                    .WithMany(p => p.Holding)
                    .HasForeignKey(d => new { d.InstrumentId, d.PortfolioId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("InstrumentPortfolio_Holding_FK1");
            });

            modelBuilder.Entity<Ifrshistory>(entity =>
            {
                entity.HasKey(e => e.Identity);

                entity.ToTable("IFRSHistory");

                entity.HasIndex(e => e.BatchId)
                    .HasName("idxIFRSHistory_BatchID");

                entity.HasIndex(e => e.Inactive)
                    .HasName("idxIFRSHistory_Inactive");

                entity.HasIndex(e => e.InstrumentId)
                    .HasName("idxIFRSHistory_InstrumentID");

                entity.HasIndex(e => e.LoadId)
                    .HasName("idxIFRSHistory_LoadId");

                entity.HasIndex(e => e.PortfolioId)
                    .HasName("idxIFRSHistory_PortfolioId");

                entity.HasIndex(e => e.ValuationDate)
                    .HasName("idxIFRSHistory_ValuationDate");

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.CapitalUnrealizedProfitLoss).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Ccy)
                    .HasColumnName("CCY")
                    .HasMaxLength(20);

                entity.Property(e => e.GrossMarketValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.GrossUnrealizedProfitLoss).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.InstrumentId).HasColumnName("InstrumentID");

                entity.Property(e => e.LoadId).HasColumnName("LoadID");

                entity.Property(e => e.LocalPrice).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.LocalValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.NetUnrealizedProfitLoss).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.PortfolioCode).HasMaxLength(20);

                entity.Property(e => e.PortfolioId).HasColumnName("PortfolioID");

                entity.Property(e => e.Sedol).HasMaxLength(20);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ValuationDate).HasColumnType("date");

                entity.HasOne(d => d.InstrumentPortfolio)
                    .WithMany(p => p.Ifrshistory)
                    .HasForeignKey(d => new { d.InstrumentId, d.PortfolioId })
                    .HasConstraintName("FK_IFRSHistory_InstrumentPortfolio");
            });

            modelBuilder.Entity<Instrument>(entity =>
            {
                entity.HasIndex(e => e.Currency)
                    .HasName("idx_Instrument_Currency");

                entity.HasIndex(e => e.Isin)
                    .HasName("idxInstrument_ISIN");

                entity.HasIndex(e => e.IssuerId)
                    .HasName("idxInstrument_Issuer");

                entity.HasIndex(e => e.Sedol)
                    .HasName("idxInstrument_Sedol");

                entity.HasIndex(e => new { e.InstrumentId, e.Sedol, e.InActive })
                    .HasName("idx_Inactive_InstrumentId_SEDOL");

                entity.Property(e => e.InstrumentId).HasColumnName("InstrumentID");

                entity.Property(e => e.AuthorisedRepo).HasDefaultValueSql("((0))");

                entity.Property(e => e.BbIdentifier)
                    .HasColumnName("BB_Identifier")
                    .HasMaxLength(20);

                entity.Property(e => e.BloombergRef).HasMaxLength(255);

                entity.Property(e => e.BrokerName).HasColumnType("nvarchar(1000)");

                entity.Property(e => e.BuyCurrencyCode).HasMaxLength(3);

                entity.Property(e => e.CallPut).HasMaxLength(255);

                entity.Property(e => e.CollateralType).HasColumnType("nvarchar(1000)");

                entity.Property(e => e.Collateralised).HasMaxLength(255);

                entity.Property(e => e.ContractSize).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CounterPartyId).HasColumnName("CounterPartyID");

                entity.Property(e => e.CountryOfIssue).HasMaxLength(50);

                entity.Property(e => e.Coupon).HasMaxLength(255);

                entity.Property(e => e.CouponAmount).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CouponType).HasMaxLength(255);

                entity.Property(e => e.Currency).HasMaxLength(3);

                entity.Property(e => e.Cusip)
                    .HasColumnName("CUSIP")
                    .HasMaxLength(9);

                entity.Property(e => e.CustodianIdentifier).HasMaxLength(255);

                entity.Property(e => e.Exchange).HasMaxLength(255);

                entity.Property(e => e.ExchangeId).HasColumnName("ExchangeID");

                entity.Property(e => e.ExpectedListingDate).HasColumnType("date");

                entity.Property(e => e.FutureExpiryDate).HasColumnType("date");

                entity.Property(e => e.FuturesMarket).HasMaxLength(255);

                entity.Property(e => e.Gics)
                    .HasColumnName("GICS")
                    .HasMaxLength(8);

                entity.Property(e => e.Gldescription)
                    .HasColumnName("GLDescription")
                    .HasMaxLength(255);

                entity.Property(e => e.Glgroup)
                    .HasColumnName("GLGroup")
                    .HasMaxLength(255);

                entity.Property(e => e.GuarantorIssuerId).HasColumnName("GuarantorIssuerID");

                entity.Property(e => e.IdBbUnique)
                    .HasColumnName("ID_BB_UNIQUE")
                    .HasMaxLength(255);

                entity.Property(e => e.InActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.InitialInvestmentDate).HasColumnType("date");

                entity.Property(e => e.InstrumentInternalName).HasColumnType("nvarchar(1000)");

                entity.Property(e => e.InstrumentName).HasColumnType("nvarchar(1000)");

                entity.Property(e => e.InstrumentParentId).HasColumnName("InstrumentParentID");

                entity.Property(e => e.InstrumentSubTypeId).HasColumnName("InstrumentSubTypeID");

                entity.Property(e => e.InstrumentTypeId).HasColumnName("InstrumentTypeID");

                entity.Property(e => e.InternalReferenceNumber).HasMaxLength(255);

                entity.Property(e => e.InvestmentCommitteeApprovedDate).HasColumnType("date");

                entity.Property(e => e.IsCls).HasColumnName("IsCLS");

                entity.Property(e => e.IsRestricted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Isin)
                    .HasColumnName("ISIN")
                    .HasMaxLength(22);

                entity.Property(e => e.IssuerId).HasColumnName("IssuerID");

                entity.Property(e => e.JpmsectorLevel1)
                    .HasColumnName("JPMSectorLevel1")
                    .HasMaxLength(255);

                entity.Property(e => e.JpmsectorLevel2)
                    .HasColumnName("JPMSectorLevel2")
                    .HasMaxLength(255);

                entity.Property(e => e.JpmsectorLevel3)
                    .HasColumnName("JPMSectorLevel3")
                    .HasMaxLength(255);

                entity.Property(e => e.JpmsectorLevel4)
                    .HasColumnName("JPMSectorLevel4")
                    .HasMaxLength(255);

                entity.Property(e => e.JpmsectorLevel5)
                    .HasColumnName("JPMSectorLevel5")
                    .HasMaxLength(255);

                entity.Property(e => e.JpmsecurityCategoryCode)
                    .HasColumnName("JPMSecurityCategoryCode")
                    .HasMaxLength(50);

                entity.Property(e => e.JpmsecurityCategoryTypeCode)
                    .HasColumnName("JPMSecurityCategoryTypeCode")
                    .HasMaxLength(50);

                entity.Property(e => e.JpmsecurityId)
                    .HasColumnName("JPMSecurityID")
                    .HasMaxLength(255);

                entity.Property(e => e.Margin).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MaturityDate).HasColumnType("date");

                entity.Property(e => e.NotionalValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.NtcategoryCode)
                    .HasColumnName("NTCategoryCode")
                    .HasMaxLength(50);

                entity.Property(e => e.NtsecurityId)
                    .HasColumnName("NTSecurityID")
                    .HasMaxLength(255);

                entity.Property(e => e.NtsubCategoryCode)
                    .HasColumnName("NTSubCategoryCode")
                    .HasMaxLength(50);

                entity.Property(e => e.ProviderDataSourceId).HasColumnName("ProviderDataSourceID");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RepoInterest).HasColumnType("money");

                entity.Property(e => e.Rimescountry)
                    .HasColumnName("RIMESCountry")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SecurityType).HasMaxLength(255);

                entity.Property(e => e.Sedol).HasMaxLength(20);

                entity.Property(e => e.SellCurrencyCode).HasMaxLength(3);

                entity.Property(e => e.SharesOnIssue).HasMaxLength(255);

                entity.Property(e => e.SharesOutstanding).HasMaxLength(255);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.Strike).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SwapConvention).HasMaxLength(10);

                entity.Property(e => e.SwapDayCount).HasMaxLength(10);

                entity.Property(e => e.SwapFixingName).HasMaxLength(50);

                entity.Property(e => e.SwapFrequency).HasMaxLength(10);

                entity.Property(e => e.SwapHolidayList).HasMaxLength(255);

                entity.Property(e => e.SwapLegType).HasMaxLength(10);

                entity.Property(e => e.SwapNextPayDate).HasColumnType("date");

                entity.Property(e => e.SwapType).HasMaxLength(10);

                entity.Property(e => e.Term).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Ticker).HasMaxLength(255);

                entity.Property(e => e.Version).HasDefaultValueSql("((1))");

                entity.Property(e => e.WhenCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WhenLastChanged).HasColumnType("datetime");

                entity.Property(e => e.WhoLastChanged)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.HasOne(d => d.CounterParty)
                    .WithMany(p => p.Instrument)
                    .HasForeignKey(d => d.CounterPartyId)
                    .HasConstraintName("FK_Instrument_CounterParty");

                entity.HasOne(d => d.ExchangeNavigation)
                    .WithMany(p => p.Instrument)
                    .HasForeignKey(d => d.ExchangeId)
                    .HasConstraintName("FK_Instrument_Exchange");

                entity.HasOne(d => d.GuarantorIssuer)
                    .WithMany(p => p.InstrumentGuarantorIssuer)
                    .HasForeignKey(d => d.GuarantorIssuerId)
                    .HasConstraintName("FK_Instrument_Guarantor");

                entity.HasOne(d => d.InstrumentParent)
                    .WithMany(p => p.InverseInstrumentParent)
                    .HasForeignKey(d => d.InstrumentParentId)
                    .HasConstraintName("FK_Instrument_InstrumentParent");

                entity.HasOne(d => d.InstrumentSubType)
                    .WithMany(p => p.Instrument)
                    .HasForeignKey(d => d.InstrumentSubTypeId)
                    .HasConstraintName("FK_Instrument_InstrumentSubType");

                entity.HasOne(d => d.InstrumentType)
                    .WithMany(p => p.Instrument)
                    .HasForeignKey(d => d.InstrumentTypeId)
                    .HasConstraintName("FK_Instrument_InstrumentType");

                entity.HasOne(d => d.Issuer)
                    .WithMany(p => p.InstrumentIssuer)
                    .HasForeignKey(d => d.IssuerId)
                    .HasConstraintName("FK_Instrument_Issuer");

                entity.HasOne(d => d.ProviderDataSource)
                    .WithMany(p => p.Instrument)
                    .HasForeignKey(d => d.ProviderDataSourceId)
                    .HasConstraintName("FK_Instrument_ProviderDataSource");
            });

            modelBuilder.Entity<InstrumentClassification>(entity =>
            {
                entity.Property(e => e.InstrumentClassificationId).HasColumnName("InstrumentClassificationID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.InstrumentClassificationDesc)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.InstrumentClassificationTypeId).HasColumnName("InstrumentClassificationTypeID");

                entity.Property(e => e.ParentInstrumentClassificationId).HasColumnName("ParentInstrumentClassificationID");

                entity.HasOne(d => d.InstrumentClassificationType)
                    .WithMany(p => p.InstrumentClassification)
                    .HasForeignKey(d => d.InstrumentClassificationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InstrumentClassification_InstrumentClassificationType");

                entity.HasOne(d => d.ParentInstrumentClassification)
                    .WithMany(p => p.InverseParentInstrumentClassification)
                    .HasForeignKey(d => d.ParentInstrumentClassificationId)
                    .HasConstraintName("FK_InstrumentClassification_InstrumentClassification");
            });

            modelBuilder.Entity<InstrumentClassificationHistory>(entity =>
            {
                entity.Property(e => e.InstrumentClassificationHistoryId).HasColumnName("InstrumentClassificationHistoryID");

                entity.Property(e => e.ActiveFrom).HasColumnType("date");

                entity.Property(e => e.ActiveTo).HasColumnType("date");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.InstrumentClassificationId).HasColumnName("InstrumentClassificationID");

                entity.Property(e => e.InstrumentId).HasColumnName("InstrumentID");

                entity.Property(e => e.PreviousActiveTo).HasColumnType("date");

                entity.Property(e => e.WhoChanged).HasMaxLength(255);

                entity.Property(e => e.WhoChecked).HasMaxLength(255);

                entity.HasOne(d => d.ApprovalStatus)
                    .WithMany(p => p.InstrumentClassificationHistory)
                    .HasForeignKey(d => d.ApprovalStatusId)
                    .HasConstraintName("FK_InstrumentClassificationHistory_ApprovalStatusId");

                entity.HasOne(d => d.InstrumentClassification)
                    .WithMany(p => p.InstrumentClassificationHistory)
                    .HasForeignKey(d => d.InstrumentClassificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InstrumentClassificationHistroy_InstrumentClassification");

                entity.HasOne(d => d.Instrument)
                    .WithMany(p => p.InstrumentClassificationHistory)
                    .HasForeignKey(d => d.InstrumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InstrumentClassificationHistory_Instrument");
            });

            modelBuilder.Entity<InstrumentClassificationType>(entity =>
            {
                entity.Property(e => e.InstrumentClassificationTypeId).HasColumnName("InstrumentClassificationTypeID");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.InstrumentClassificationTypeDesc)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<InstrumentCouponHistory>(entity =>
            {
                entity.Property(e => e.InstrumentCouponHistoryId).HasColumnName("InstrumentCouponHistoryID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDatetime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InstrumentId).HasColumnName("InstrumentID");

                entity.Property(e => e.Rate)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ValuationDate).HasColumnType("date");

                entity.HasOne(d => d.Instrument)
                    .WithMany(p => p.InstrumentCouponHistory)
                    .HasForeignKey(d => d.InstrumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InstrumentCouponHistory_Instrument");
            });

            modelBuilder.Entity<InstrumentCreditRating>(entity =>
            {
                entity.Property(e => e.InstrumentCreditRatingId).HasColumnName("InstrumentCreditRatingID");

                entity.Property(e => e.CreditRatingId).HasColumnName("CreditRatingID");

                entity.Property(e => e.EffectiveFrom).HasColumnType("date");

                entity.Property(e => e.InActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.InstrumentId).HasColumnName("InstrumentID");

                entity.HasOne(d => d.CreditRating)
                    .WithMany(p => p.InstrumentCreditRating)
                    .HasForeignKey(d => d.CreditRatingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InstrumentCreditRating_CreditRating");

                entity.HasOne(d => d.Instrument)
                    .WithMany(p => p.InstrumentCreditRating)
                    .HasForeignKey(d => d.InstrumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InstrumentCreditRating_Instrument");
            });

            modelBuilder.Entity<InstrumentGroup>(entity =>
            {
                entity.Property(e => e.Cusip)
                    .HasColumnName("CUSIP")
                    .HasMaxLength(9);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EffectiveDate).HasColumnType("date");

                entity.Property(e => e.EffectiveTillDate).HasColumnType("date");

                entity.Property(e => e.GicssubIndustry)
                    .HasColumnName("GICSSubIndustry")
                    .HasMaxLength(255);

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.InstrumentGroupDescription).HasMaxLength(255);

                entity.Property(e => e.InstrumentSubTypeId).HasColumnName("InstrumentSubTypeID");

                entity.Property(e => e.InstrumentTypeId).HasColumnName("InstrumentTypeID");

                entity.Property(e => e.Isin)
                    .HasColumnName("ISIN")
                    .HasMaxLength(22);

                entity.Property(e => e.JpmsecurityId).HasColumnName("JPMSecurityID");

                entity.Property(e => e.NonCompliant).HasDefaultValueSql("((0))");

                entity.Property(e => e.NtsecurityId)
                    .HasColumnName("NTSecurityID")
                    .HasMaxLength(20);

                entity.Property(e => e.PropertyXml).HasColumnName("PropertyXML");

                entity.Property(e => e.Sedol).HasMaxLength(20);

                entity.Property(e => e.Ticker).HasMaxLength(255);

                entity.HasOne(d => d.InstrumentGroupType)
                    .WithMany(p => p.InstrumentGroup)
                    .HasForeignKey(d => d.InstrumentGroupTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InstrumentGroup_InstrumentGroupType");

                entity.HasOne(d => d.Instrument)
                    .WithMany(p => p.InstrumentGroup)
                    .HasForeignKey(d => d.InstrumentId)
                    .HasConstraintName("FK_InstrumentGroup_Instrument");

                entity.HasOne(d => d.InstrumentSubType)
                    .WithMany(p => p.InstrumentGroup)
                    .HasForeignKey(d => d.InstrumentSubTypeId)
                    .HasConstraintName("FK_InstrumentGroup_InstrumentSubType");

                entity.HasOne(d => d.InstrumentType)
                    .WithMany(p => p.InstrumentGroup)
                    .HasForeignKey(d => d.InstrumentTypeId)
                    .HasConstraintName("FK_InstrumentGroup_InstrumentType");
            });

            modelBuilder.Entity<InstrumentGroupProperty>(entity =>
            {
                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.InstrumentGroupPropertyDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyValue)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.InstrumentGroup)
                    .WithMany(p => p.InstrumentGroupProperty)
                    .HasForeignKey(d => d.InstrumentGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InstrumentGroupProperty_InstrumentGroup");
            });

            modelBuilder.Entity<InstrumentGroupType>(entity =>
            {
                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.InstrumentGroupCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InstrumentGroupDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InstrumentHistory>(entity =>
            {
                entity.HasKey(e => new { e.InstrumentId, e.Version });

                entity.Property(e => e.InstrumentId).HasColumnName("InstrumentID");

                entity.Property(e => e.BrokerName).HasColumnType("nvarchar(1000)");

                entity.Property(e => e.BuyCurrencyCode).HasMaxLength(3);

                entity.Property(e => e.Collateralised).HasMaxLength(255);

                entity.Property(e => e.CounterPartyId).HasColumnName("CounterPartyID");

                entity.Property(e => e.CountryOfIssue).HasMaxLength(50);

                entity.Property(e => e.Coupon).HasMaxLength(255);

                entity.Property(e => e.CouponAmount).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Currency).HasMaxLength(3);

                entity.Property(e => e.Cusip)
                    .HasColumnName("CUSIP")
                    .HasMaxLength(9);

                entity.Property(e => e.CustodianIdentifier).HasMaxLength(255);

                entity.Property(e => e.Exchange).HasMaxLength(255);

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.InstrumentInternalName).HasColumnType("nvarchar(1000)");

                entity.Property(e => e.InstrumentName).HasColumnType("nvarchar(1000)");

                entity.Property(e => e.InstrumentParentId).HasColumnName("InstrumentParentID");

                entity.Property(e => e.InstrumentSubTypeId).HasColumnName("InstrumentSubTypeID");

                entity.Property(e => e.InstrumentTypeId).HasColumnName("InstrumentTypeID");

                entity.Property(e => e.InternalReferenceNumber).HasMaxLength(255);

                entity.Property(e => e.IsCls).HasColumnName("IsCLS");

                entity.Property(e => e.Isin)
                    .HasColumnName("ISIN")
                    .HasMaxLength(22);

                entity.Property(e => e.IssuerId).HasColumnName("IssuerID");

                entity.Property(e => e.JpmsecurityCategoryCode)
                    .HasColumnName("JPMSecurityCategoryCode")
                    .HasMaxLength(50);

                entity.Property(e => e.JpmsecurityCategoryTypeCode)
                    .HasColumnName("JPMSecurityCategoryTypeCode")
                    .HasMaxLength(50);

                entity.Property(e => e.JpmsecurityId)
                    .HasColumnName("JPMSecurityID")
                    .HasMaxLength(255);

                entity.Property(e => e.Margin).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MaturityDate).HasColumnType("date");

                entity.Property(e => e.NotionalValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.NtcategoryCode)
                    .HasColumnName("NTCategoryCode")
                    .HasMaxLength(50);

                entity.Property(e => e.NtsecurityId)
                    .HasColumnName("NTSecurityID")
                    .HasMaxLength(20);

                entity.Property(e => e.NtsubCategoryCode)
                    .HasColumnName("NTSubCategoryCode")
                    .HasMaxLength(50);

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RepoInterest).HasColumnType("money");

                entity.Property(e => e.SecurityType).HasMaxLength(255);

                entity.Property(e => e.Sedol).HasMaxLength(8);

                entity.Property(e => e.SellCurrencyCode).HasMaxLength(3);

                entity.Property(e => e.SharesOnIssue).HasMaxLength(255);

                entity.Property(e => e.SharesOutstanding).HasMaxLength(255);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.SwapConvention).HasMaxLength(10);

                entity.Property(e => e.SwapDayCount).HasMaxLength(10);

                entity.Property(e => e.SwapFixingName).HasMaxLength(50);

                entity.Property(e => e.SwapFrequency).HasMaxLength(10);

                entity.Property(e => e.SwapHolidayList).HasMaxLength(255);

                entity.Property(e => e.SwapLegType).HasMaxLength(10);

                entity.Property(e => e.SwapNextPayDate).HasColumnType("date");

                entity.Property(e => e.SwapType).HasMaxLength(10);

                entity.Property(e => e.Term).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Ticker).HasMaxLength(255);

                entity.Property(e => e.WhenLastChanged).HasColumnType("datetime");

                entity.Property(e => e.WhoLastChanged)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.HasOne(d => d.Instrument)
                    .WithMany(p => p.InstrumentHistory)
                    .HasForeignKey(d => d.InstrumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InstrumentHistory_Instrument");
            });

            modelBuilder.Entity<InstrumentMarketData>(entity =>
            {
                entity.HasIndex(e => e.InstrumentId)
                    .HasName("idxInstrumentMarketData_Instrument");

                entity.HasIndex(e => e.MarketDataDate)
                    .HasName("idxInstrumentMarketData_MarketDataDate");

                entity.HasIndex(e => new { e.InstrumentId, e.MarketDataTypeId, e.MarketDataSource })
                    .HasName("idxInstrumentMarketData_InstAndType");

                entity.HasIndex(e => new { e.BenchmarkInstrumentId, e.InstrumentId, e.MarketDataTypeId, e.MarketDataDate })
                    .HasName("idx_BenchmarkInstrument_Type_Date");

                entity.HasIndex(e => new { e.InstrumentId, e.MarketDataTypeId, e.MarketDataDate, e.MarketDataSource })
                    .HasName("idxInstrumentMarketData_InstAndTypeAndDate");

                entity.HasIndex(e => new { e.InstrumentId, e.MarketDataValue, e.MarketDataDate, e.MarketDataTypeId, e.InActive })
                    .HasName("idx_IMD_InstrumentPerformance");

                entity.HasIndex(e => new { e.MarketDataSource, e.MarketDataValue, e.InstrumentId, e.MarketDataTypeId, e.InActive, e.MarketDataDate })
                    .HasName("idx_CoveringIndexForGetInstrumentMarketData");

                entity.Property(e => e.InstrumentMarketDataId).HasColumnName("InstrumentMarketDataID");

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.BenchmarkInstrumentId).HasColumnName("BenchmarkInstrumentID");

                entity.Property(e => e.Iiflag).HasColumnName("IIFlag");

                entity.Property(e => e.InActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.InstrumentId).HasColumnName("InstrumentID");

                entity.Property(e => e.MarketDataDate).HasColumnType("date");

                entity.Property(e => e.MarketDataSource).HasMaxLength(30);

                entity.Property(e => e.MarketDataTypeId).HasColumnName("MarketDataTypeID");

                entity.Property(e => e.MarketDataValue)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.HasOne(d => d.BenchmarkInstrument)
                    .WithMany(p => p.InstrumentMarketDataBenchmarkInstrument)
                    .HasForeignKey(d => d.BenchmarkInstrumentId)
                    .HasConstraintName("FK_InstrumentMarketData_BenchmarkInstrument");

                entity.HasOne(d => d.Instrument)
                    .WithMany(p => p.InstrumentMarketDataInstrument)
                    .HasForeignKey(d => d.InstrumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InstrumentMarketData_Instrument");

                entity.HasOne(d => d.MarketDataType)
                    .WithMany(p => p.InstrumentMarketData)
                    .HasForeignKey(d => d.MarketDataTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InstrumentMarketData_MarketDataType");
            });

            modelBuilder.Entity<InstrumentMarketDataArchive>(entity =>
            {
                entity.HasKey(e => e.InstrumentMarketDataId);

                entity.HasIndex(e => e.InstrumentId)
                    .HasName("idxIMDArchive_Instrument");

                entity.HasIndex(e => e.MarketDataDate)
                    .HasName("idxIMDArchive_MarketDataDate");

                entity.HasIndex(e => new { e.InstrumentId, e.MarketDataTypeId, e.MarketDataSource })
                    .HasName("idxIMDArchive_InstAndType");

                entity.HasIndex(e => new { e.InstrumentId, e.MarketDataTypeId, e.MarketDataDate, e.MarketDataSource })
                    .HasName("idxIMDArchive_InstAndTypeAndDate");

                entity.HasIndex(e => new { e.InstrumentId, e.MarketDataValue, e.MarketDataDate, e.MarketDataTypeId, e.InActive })
                    .HasName("idx_IMDA_InstrumentPerformance");

                entity.HasIndex(e => new { e.MarketDataSource, e.MarketDataValue, e.InstrumentId, e.MarketDataTypeId, e.InActive, e.MarketDataDate })
                    .HasName("idx_CoveringIndexForGetArchivedIMD");

                entity.Property(e => e.InstrumentMarketDataId)
                    .HasColumnName("InstrumentMarketDataID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.BenchmarkInstrumentId).HasColumnName("BenchmarkInstrumentID");

                entity.Property(e => e.Iiflag).HasColumnName("IIFlag");

                entity.Property(e => e.InstrumentId).HasColumnName("InstrumentID");

                entity.Property(e => e.MarketDataDate).HasColumnType("date");

                entity.Property(e => e.MarketDataSource).HasMaxLength(30);

                entity.Property(e => e.MarketDataTypeId).HasColumnName("MarketDataTypeID");

                entity.Property(e => e.MarketDataValue)
                    .IsRequired()
                    .HasMaxLength(2000);
            });

            modelBuilder.Entity<InstrumentPortfolio>(entity =>
            {
                entity.HasKey(e => new { e.InstrumentId, e.PortfolioId });

                entity.Property(e => e.InstrumentId).HasColumnName("InstrumentID");

                entity.Property(e => e.PortfolioId).HasColumnName("PortfolioID");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Instrument)
                    .WithMany(p => p.InstrumentPortfolio)
                    .HasForeignKey(d => d.InstrumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Instrument_InstrumentPortfolio_FK1");

                entity.HasOne(d => d.Portfolio)
                    .WithMany(p => p.InstrumentPortfolio)
                    .HasForeignKey(d => d.PortfolioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Portfolio_InstrumentPortfolio_FK1");
            });

            modelBuilder.Entity<InstrumentRelationship>(entity =>
            {
                entity.HasIndex(e => new { e.PrimaryInstrumentId, e.RelatedInstrumentId })
                    .HasName("idx_InstrumentRelationship");

                entity.Property(e => e.InstrumentRelationshipId).HasColumnName("InstrumentRelationshipID");

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrimaryInstrumentId).HasColumnName("PrimaryInstrumentID");

                entity.Property(e => e.RelatedInstrumentId).HasColumnName("RelatedInstrumentID");

                entity.Property(e => e.RelatedTypeId).HasColumnName("RelatedTypeID");

                entity.HasOne(d => d.PrimaryInstrument)
                    .WithMany(p => p.InstrumentRelationshipPrimaryInstrument)
                    .HasForeignKey(d => d.PrimaryInstrumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Instrument_InstrumentRelationshipPrimaryInstrument_FK1");

                entity.HasOne(d => d.RelatedInstrument)
                    .WithMany(p => p.InstrumentRelationshipRelatedInstrument)
                    .HasForeignKey(d => d.RelatedInstrumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Instrument_InstrumentRelationshipRelatedInstrument_FK1");

                entity.HasOne(d => d.RelatedType)
                    .WithMany(p => p.InstrumentRelationship)
                    .HasForeignKey(d => d.RelatedTypeId)
                    .HasConstraintName("InstrumentRelationship_RelatedType_FK1");
            });

            modelBuilder.Entity<InstrumentSubType>(entity =>
            {
                entity.Property(e => e.InstrumentSubTypeId).HasColumnName("InstrumentSubTypeID");

                entity.Property(e => e.CanTrade).HasDefaultValueSql("((0))");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.InstrumentSubTypeCode).HasMaxLength(100);

                entity.Property(e => e.InstrumentSubTypeDesc).HasMaxLength(100);

                entity.Property(e => e.InstrumentTypeId).HasColumnName("InstrumentTypeID");

                entity.HasOne(d => d.InstrumentType)
                    .WithMany(p => p.InstrumentSubType)
                    .HasForeignKey(d => d.InstrumentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("InstrumentType_InstrumentSubType_FK1");
            });

            modelBuilder.Entity<InstrumentType>(entity =>
            {
                entity.Property(e => e.InstrumentTypeId).HasColumnName("InstrumentTypeID");

                entity.Property(e => e.CanTrade).HasDefaultValueSql("((0))");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.InstrumentTypeDesc).HasMaxLength(100);
            });

            modelBuilder.Entity<InstrumentTypeTransactionType>(entity =>
            {
                entity.HasKey(e => new { e.InstrumentTypeId, e.TransactionTypeId });

                entity.Property(e => e.InstrumentTypeId).HasColumnName("InstrumentTypeID");

                entity.Property(e => e.TransactionTypeId).HasColumnName("TransactionTypeID");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.InstrumentType)
                    .WithMany(p => p.InstrumentTypeTransactionType)
                    .HasForeignKey(d => d.InstrumentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InstrumentTypeTransactionType_InstrumentType");

                entity.HasOne(d => d.TransactionType)
                    .WithMany(p => p.InstrumentTypeTransactionType)
                    .HasForeignKey(d => d.TransactionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InstrumentTypeTransactionType_TransactionType");
            });

            modelBuilder.Entity<Issuer>(entity =>
            {
                entity.Property(e => e.IssuerId).HasColumnName("IssuerID");

                entity.Property(e => e.AccCountryOfDomicile).HasMaxLength(10);

                entity.Property(e => e.AuthorisedBank).HasDefaultValueSql("((0))");

                entity.Property(e => e.BloombergRef).HasMaxLength(255);

                entity.Property(e => e.CompanyTicker).HasMaxLength(30);

                entity.Property(e => e.CountryOfDomicile).HasMaxLength(10);

                entity.Property(e => e.CreatedDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreditLimit).HasColumnType("money");

                entity.Property(e => e.CreditNotes).HasColumnType("nvarchar(1000)");

                entity.Property(e => e.ExchangeId).HasColumnName("ExchangeID");

                entity.Property(e => e.ExpectedLossLimit).HasColumnType("money");

                entity.Property(e => e.IdBb)
                    .HasColumnName("IdBB")
                    .HasMaxLength(255);

                entity.Property(e => e.InActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsInternal).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsLocalAuthority).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsRestricted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Isda)
                    .HasColumnName("ISDA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IssuerCode).HasMaxLength(255);

                entity.Property(e => e.IssuerName).HasColumnType("nvarchar(1000)");

                entity.Property(e => e.MasterRepoAgreement).HasDefaultValueSql("((0))");

                entity.Property(e => e.MaximumExtensionPercent).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MaximumFreeFloatPercent).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MaximumShareholdingPercent).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.NzfmarepoSchedule)
                    .HasColumnName("NZFMARepoSchedule")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Nzgovernment)
                    .HasColumnName("NZGovernment")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ParentIssuerId).HasColumnName("ParentIssuerID");

                entity.HasOne(d => d.CounterParty)
                    .WithMany(p => p.Issuer)
                    .HasForeignKey(d => d.CounterPartyId)
                    .HasConstraintName("FK_Issuer_CounterParty");

                entity.HasOne(d => d.Exchange)
                    .WithMany(p => p.Issuer)
                    .HasForeignKey(d => d.ExchangeId)
                    .HasConstraintName("FK_Issuer_Exchange");

                entity.HasOne(d => d.ParentIssuer)
                    .WithMany(p => p.InverseParentIssuer)
                    .HasForeignKey(d => d.ParentIssuerId)
                    .HasConstraintName("FK_ParentIssuer");
            });

            modelBuilder.Entity<IssuerCreditDowngrade>(entity =>
            {
                entity.Property(e => e.IssuerCreditDowngradeId).HasColumnName("IssuerCreditDowngradeID");

                entity.Property(e => e.CurrentIssuerCreditRatingId).HasColumnName("CurrentIssuerCreditRatingID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.InActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.IssuerId).HasColumnName("IssuerID");

                entity.Property(e => e.PreviousIssuerCreditRatingId).HasColumnName("PreviousIssuerCreditRatingID");

                entity.Property(e => e.ValuationDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<IssuerCreditRating>(entity =>
            {
                entity.Property(e => e.IssuerCreditRatingId).HasColumnName("IssuerCreditRatingID");

                entity.Property(e => e.CreditRatingId).HasColumnName("CreditRatingID");

                entity.Property(e => e.EffectiveFrom).HasColumnType("date");

                entity.Property(e => e.InActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.IssuerId).HasColumnName("IssuerID");

                entity.HasOne(d => d.CreditRating)
                    .WithMany(p => p.IssuerCreditRating)
                    .HasForeignKey(d => d.CreditRatingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IssuerCreditRating_CreditRating");

                entity.HasOne(d => d.Issuer)
                    .WithMany(p => p.IssuerCreditRating)
                    .HasForeignKey(d => d.IssuerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IssuerCreditRating_Issuer");
            });

            modelBuilder.Entity<IssuerUnderwritingAdjustment>(entity =>
            {
                entity.Property(e => e.IssuerUnderwritingAdjustmentId).HasColumnName("IssuerUnderwritingAdjustmentID");

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.EffectiveFrom).HasColumnType("datetime");

                entity.Property(e => e.EffectiveTo).HasColumnType("datetime");

                entity.Property(e => e.IssuerId).HasColumnName("IssuerID");

                entity.Property(e => e.ValueLocal).HasColumnType("money");

                entity.HasOne(d => d.Issuer)
                    .WithMany(p => p.IssuerUnderwritingAdjustment)
                    .HasForeignKey(d => d.IssuerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IssuerUnderwritingAdjustment_IssuerId");
            });

            modelBuilder.Entity<JpmcashAdjustment>(entity =>
            {
                entity.ToTable("JPMCashAdjustment");

                entity.Property(e => e.JpmcashAdjustmentId).HasColumnName("JPMCashAdjustmentID");

                entity.Property(e => e.AdjustmentDate).HasColumnType("date");

                entity.Property(e => e.ApprovedBy).HasMaxLength(255);

                entity.Property(e => e.ApprovedDateTime).HasColumnType("datetime");

                entity.Property(e => e.CashAdjustmentSubTypeId).HasColumnName("CashAdjustmentSubTypeID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.PortfolioId).HasColumnName("PortfolioID");

                entity.Property(e => e.ProjectedDate).HasColumnType("date");

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Table).HasMaxLength(255);

                entity.Property(e => e.TableId).HasColumnName("TableID");

                entity.Property(e => e.TransactionGroupDescription).HasMaxLength(255);

                entity.Property(e => e.Value).HasColumnType("decimal(18, 6)");

                entity.HasOne(d => d.CashAdjustmentSubType)
                    .WithMany(p => p.JpmcashAdjustment)
                    .HasForeignKey(d => d.CashAdjustmentSubTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JPMCashAdjustment_CashAdjustmentSubType");

                entity.HasOne(d => d.Portfolio)
                    .WithMany(p => p.JpmcashAdjustment)
                    .HasForeignKey(d => d.PortfolioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JPMCashAdjustment_Portfolio");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.JpmcashAdjustment)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JPMCashAdjustment_Status");
            });

            modelBuilder.Entity<JpmcashProjection>(entity =>
            {
                entity.ToTable("JPMCashProjection");

                entity.Property(e => e.JpmcashProjectionId).HasColumnName("JPMCashProjectionID");

                entity.Property(e => e.AccountNumber).HasMaxLength(255);

                entity.Property(e => e.AdditionalInformation).HasMaxLength(255);

                entity.Property(e => e.AssetTypeDescription).HasMaxLength(255);

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.ClearingBrokerName).HasMaxLength(255);

                entity.Property(e => e.ContractualSd)
                    .HasColumnName("ContractualSD")
                    .HasColumnType("date");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.Isin)
                    .HasColumnName("ISIN")
                    .HasMaxLength(22);

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.PortfolioId).HasColumnName("PortfolioID");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.ProjectedDate).HasColumnType("date");

                entity.Property(e => e.SecurityId)
                    .HasColumnName("SecurityID")
                    .HasMaxLength(255);

                entity.Property(e => e.SecurityName).HasMaxLength(255);

                entity.Property(e => e.StatementDate).HasColumnType("date");

                entity.Property(e => e.Ticker).HasMaxLength(255);

                entity.Property(e => e.TradeDate).HasColumnType("date");

                entity.Property(e => e.TransactionCategoryDescription).HasMaxLength(255);

                entity.Property(e => e.TransactionGroupDescription).HasMaxLength(255);

                entity.Property(e => e.TransactionNumber).HasMaxLength(20);

                entity.Property(e => e.TransactionStatusDescription).HasMaxLength(255);

                entity.Property(e => e.TransactionTypeDescription).HasMaxLength(255);

                entity.HasOne(d => d.Portfolio)
                    .WithMany(p => p.JpmcashProjection)
                    .HasForeignKey(d => d.PortfolioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JPMCashProjection_Portfolio");
            });

            modelBuilder.Entity<JpmcategorySubTypeColumn>(entity =>
            {
                entity.HasKey(e => e.JpmcatSubTypeColumnId);

                entity.ToTable("JPMCategorySubTypeColumn");

                entity.Property(e => e.JpmcatSubTypeColumnId).HasColumnName("JPMCatSubTypeColumnID");

                entity.Property(e => e.Column1).HasMaxLength(255);

                entity.Property(e => e.Column2).HasMaxLength(255);

                entity.Property(e => e.Column3).HasMaxLength(255);

                entity.Property(e => e.Column4).HasMaxLength(255);

                entity.Property(e => e.JpmsecurityCategoryCode)
                    .HasColumnName("JPMSecurityCategoryCode")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Jpmcustody>(entity =>
            {
                entity.ToTable("JPMCustody");

                entity.Property(e => e.JpmcustodyId).HasColumnName("JPMCustodyID");

                entity.Property(e => e.AwaitingDelivery).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.AwaitingReceipt).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.CountryCode).HasMaxLength(2);

                entity.Property(e => e.InstrumentId).HasColumnName("InstrumentID");

                entity.Property(e => e.Isin)
                    .HasColumnName("ISIN")
                    .HasMaxLength(255);

                entity.Property(e => e.PortfolioId).HasColumnName("PortfolioID");

                entity.Property(e => e.SecurityName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Sedol).HasMaxLength(255);

                entity.Property(e => e.Ticker).HasMaxLength(255);

                entity.Property(e => e.TotalUnits).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ValuationDate).HasColumnType("date");

                entity.HasOne(d => d.Instrument)
                    .WithMany(p => p.Jpmcustody)
                    .HasForeignKey(d => d.InstrumentId)
                    .HasConstraintName("FK_JPMCustody_Instrument");

                entity.HasOne(d => d.Portfolio)
                    .WithMany(p => p.Jpmcustody)
                    .HasForeignKey(d => d.PortfolioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JPMCustody_Portfolio");
            });

            modelBuilder.Entity<JpmpostedCashBalance>(entity =>
            {
                entity.ToTable("JPMPostedCashBalance");

                entity.Property(e => e.JpmpostedCashBalanceId).HasColumnName("JPMPostedCashBalanceID");

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.CashClosingBalance).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CashOpeningBalance).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.PortfolioId).HasColumnName("PortfolioID");

                entity.Property(e => e.PostedDate).HasColumnType("date");

                entity.HasOne(d => d.Portfolio)
                    .WithMany(p => p.JpmpostedCashBalance)
                    .HasForeignKey(d => d.PortfolioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JPMPostedCashBalance_PortfolioID");
            });

            modelBuilder.Entity<JpmpostedCashDetail>(entity =>
            {
                entity.ToTable("JPMPostedCashDetail");

                entity.Property(e => e.JpmpostedCashDetailId).HasColumnName("JPMPostedCashDetailID");

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.AdditionalInformation).HasMaxLength(255);

                entity.Property(e => e.AssetTypeDescription).HasMaxLength(255);

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.ClearingBrokerName).HasMaxLength(255);

                entity.Property(e => e.ContractualSd)
                    .HasColumnName("ContractualSD")
                    .HasColumnType("date");

                entity.Property(e => e.CurrencyCode).HasMaxLength(3);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.Isin)
                    .HasColumnName("ISIN")
                    .HasMaxLength(22);

                entity.Property(e => e.JpmpostedCashSummaryId).HasColumnName("JPMPostedCashSummaryID");

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.PortfolioId).HasColumnName("PortfolioID");

                entity.Property(e => e.PostedDate).HasColumnType("date");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.SecurityId)
                    .HasColumnName("SecurityID")
                    .HasMaxLength(255);

                entity.Property(e => e.SecurityName).HasMaxLength(255);

                entity.Property(e => e.Ticker).HasMaxLength(255);

                entity.Property(e => e.TradeDate).HasColumnType("date");

                entity.Property(e => e.TransactionGroupDescription).HasMaxLength(255);

                entity.Property(e => e.TransactionNumber).HasMaxLength(20);

                entity.Property(e => e.TransactionTypeDescription).HasMaxLength(255);

                entity.HasOne(d => d.JpmpostedCashSummary)
                    .WithMany(p => p.JpmpostedCashDetail)
                    .HasForeignKey(d => d.JpmpostedCashSummaryId)
                    .HasConstraintName("FK_JPMPostedCashDetail_SummaryID");

                entity.HasOne(d => d.Portfolio)
                    .WithMany(p => p.JpmpostedCashDetail)
                    .HasForeignKey(d => d.PortfolioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JPMPostedCashDetail_PortfolioID");
            });

            modelBuilder.Entity<JpmpostedCashSummary>(entity =>
            {
                entity.ToTable("JPMPostedCashSummary");

                entity.Property(e => e.JpmpostedCashSummaryId).HasColumnName("JPMPostedCashSummaryID");

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.PortfolioId).HasColumnName("PortfolioID");

                entity.Property(e => e.PostedDate).HasColumnType("date");

                entity.Property(e => e.TransactionGroupAmount).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TransactionGroupDescription).HasMaxLength(255);

                entity.HasOne(d => d.Portfolio)
                    .WithMany(p => p.JpmpostedCashSummary)
                    .HasForeignKey(d => d.PortfolioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JPMPostedCashSummary_PortfolioID");
            });

            modelBuilder.Entity<JpmsubTypeMapping>(entity =>
            {
                entity.ToTable("JPMSubTypeMapping");

                entity.Property(e => e.JpmsubTypeMappingId).HasColumnName("JPMSubTypeMappingID");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Gldescription)
                    .HasColumnName("GLDescription")
                    .HasMaxLength(255);

                entity.Property(e => e.InstrumentSubTypeId).HasColumnName("InstrumentSubTypeID");

                entity.Property(e => e.InstrumentTypeId).HasColumnName("InstrumentTypeID");

                entity.Property(e => e.JpmsectorLevel1)
                    .HasColumnName("JPMSectorLevel1")
                    .HasMaxLength(255);

                entity.Property(e => e.JpmsectorLevel4)
                    .HasColumnName("JPMSectorLevel4")
                    .HasMaxLength(255);

                entity.Property(e => e.JpmsecurityCategoryCode)
                    .HasColumnName("JPMSecurityCategoryCode")
                    .HasMaxLength(50);

                entity.Property(e => e.JpmsecurityCategoryTypeCode)
                    .HasColumnName("JPMSecurityCategoryTypeCode")
                    .HasMaxLength(50);

                entity.Property(e => e.SecurityType).HasMaxLength(255);

                entity.HasOne(d => d.InstrumentSubType)
                    .WithMany(p => p.JpmsubTypeMapping)
                    .HasForeignKey(d => d.InstrumentSubTypeId)
                    .HasConstraintName("FK_JPMSubTypeMapping_InstrumentSubType");

                entity.HasOne(d => d.InstrumentType)
                    .WithMany(p => p.JpmsubTypeMapping)
                    .HasForeignKey(d => d.InstrumentTypeId)
                    .HasConstraintName("FK_JPMSubTypeMapping_InstrumentType");
            });

            modelBuilder.Entity<ManagerHolding>(entity =>
            {
                entity.Property(e => e.ManagerHoldingId).HasColumnName("ManagerHoldingID");

                entity.Property(e => e.InstrumentId).HasColumnName("InstrumentID");

                entity.Property(e => e.IntDom)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.LoadId).HasColumnName("LoadID");

                entity.Property(e => e.PortfolioId).HasColumnName("PortfolioID");

                entity.Property(e => e.Sedol).HasMaxLength(255);

                entity.Property(e => e.Ticker)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Units).HasColumnType("decimal(18, 6)");

                entity.HasOne(d => d.Instrument)
                    .WithMany(p => p.ManagerHolding)
                    .HasForeignKey(d => d.InstrumentId)
                    .HasConstraintName("FK_MgrHolding_Instrument");

                entity.HasOne(d => d.Portfolio)
                    .WithMany(p => p.ManagerHolding)
                    .HasForeignKey(d => d.PortfolioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MgrHolding_Portfolio");
            });

            modelBuilder.Entity<MarketDataType>(entity =>
            {
                entity.Property(e => e.MarketDataTypeId).HasColumnName("MarketDataTypeID");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.MarketDataDatatype)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.MarketDataTypeCode)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.MarketDataTypeDesc).HasMaxLength(255);
            });

            modelBuilder.Entity<Measure>(entity =>
            {
                entity.Property(e => e.DataSource).HasMaxLength(1000);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.MeasureName).HasMaxLength(255);

                entity.HasOne(d => d.MeasureType)
                    .WithMany(p => p.Measure)
                    .HasForeignKey(d => d.MeasureTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Measure_MeasureTypeId");
            });

            modelBuilder.Entity<MeasureDatasourceMapping>(entity =>
            {
                entity.HasKey(e => e.MeasureName);

                entity.Property(e => e.MeasureName)
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.DatasourceName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DatasourceType)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DateFilter).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Measurement>(entity =>
            {
                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.MeasurementDomain).HasMaxLength(1000);

                entity.Property(e => e.MeasurementFunction).HasMaxLength(1000);

                entity.Property(e => e.MeasurementName).HasMaxLength(255);

                entity.HasOne(d => d.Measure)
                    .WithMany(p => p.Measurement)
                    .HasForeignKey(d => d.MeasureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Measurement_MeasureId");
            });

            modelBuilder.Entity<MeasurementDependency>(entity =>
            {
                entity.Property(e => e.MeasurementDependencyId).HasColumnName("MeasurementDependencyID");

                entity.Property(e => e.MeasurementName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TestAccreference)
                    .IsRequired()
                    .HasColumnName("TestACCReference")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<MeasurementFilter>(entity =>
            {
                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.HasOne(d => d.Filter)
                    .WithMany(p => p.MeasurementFilter)
                    .HasForeignKey(d => d.FilterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MeasurementFilter_FilterId");

                entity.HasOne(d => d.Measurement)
                    .WithMany(p => p.MeasurementFilter)
                    .HasForeignKey(d => d.MeasurementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MeasurementFilter_MeasurementId");
            });

            modelBuilder.Entity<MeasurementGrouping>(entity =>
            {
                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.GroupByColumn).HasMaxLength(255);

                entity.Property(e => e.MeasurementGroupingName).HasMaxLength(255);

                entity.HasOne(d => d.Measurement)
                    .WithMany(p => p.MeasurementGrouping)
                    .HasForeignKey(d => d.MeasurementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MeasurementGrouping_MeasurementId");
            });

            modelBuilder.Entity<MeasureType>(entity =>
            {
                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.MeasureTypeName).HasMaxLength(255);
            });

            modelBuilder.Entity<MonthlyFaAssetClassSplit>(entity =>
            {
                entity.Property(e => e.MonthlyFaAssetClassSplitId).HasColumnName("MonthlyFaAssetClassSplitID");

                entity.Property(e => e.AssetClassId).HasColumnName("AssetClassID");

                entity.Property(e => e.FundingAccountId).HasColumnName("FundingAccountID");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.MarketValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ValuationDate).HasColumnType("date");

                entity.Property(e => e.WhenCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.AssetClass)
                    .WithMany(p => p.MonthlyFaAssetClassSplit)
                    .HasForeignKey(d => d.AssetClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MonthlyFaAssetClassSplit_AssetClass");

                entity.HasOne(d => d.FundingAccount)
                    .WithMany(p => p.MonthlyFaAssetClassSplit)
                    .HasForeignKey(d => d.FundingAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MonthlyFaAssetClassSplit_FundingAccount");
            });

            modelBuilder.Entity<NzinterestRateDerivative>(entity =>
            {
                entity.ToTable("NZInterestRateDerivative");

                entity.Property(e => e.NzinterestRateDerivativeId).HasColumnName("NZInterestRateDerivativeID");

                entity.Property(e => e.EffectiveDate).HasColumnType("date");

                entity.Property(e => e.EffectiveExposure).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.EffectiveExposureEarners)
                    .HasColumnName("EffectiveExposure_Earners")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.EffectiveExposureMotorVehicle)
                    .HasColumnName("EffectiveExposure_MotorVehicle")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.EffectiveExposureNewEmployers)
                    .HasColumnName("EffectiveExposure_NewEmployers")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.EffectiveExposureNonEarners)
                    .HasColumnName("EffectiveExposure_NonEarners")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.EffectiveExposureResidualEmployers)
                    .HasColumnName("EffectiveExposure_ResidualEmployers")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.EffectiveExposureSelfEmployed)
                    .HasColumnName("EffectiveExposure_SelfEmployed")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.EffectiveExposureTreatmentInjury)
                    .HasColumnName("EffectiveExposure_TreatmentInjury")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.FaceValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.MarketValue).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<OnCallCashAssignment>(entity =>
            {
                entity.Property(e => e.OnCallCashAssignmentId).HasColumnName("OnCallCashAssignmentID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('NZD')");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.InstrumentId).HasColumnName("InstrumentID");

                entity.Property(e => e.PortfolioId).HasColumnName("PortfolioID");

                entity.Property(e => e.StatementDate).HasColumnType("date");

                entity.HasOne(d => d.Instrument)
                    .WithMany(p => p.OnCallCashAssignment)
                    .HasForeignKey(d => d.InstrumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OnCallCashAssignment_Instrument");

                entity.HasOne(d => d.Portfolio)
                    .WithMany(p => p.OnCallCashAssignment)
                    .HasForeignKey(d => d.PortfolioId)
                    .HasConstraintName("FK_OnCallCashAssignment_Portfolio");
            });

            modelBuilder.Entity<OpenFfxposition>(entity =>
            {
                entity.HasKey(e => e.OpenFfxid);

                entity.ToTable("OpenFFXPosition");

                entity.HasIndex(e => e.BatchId)
                    .HasName("idxOpenFFXPosition_BatchID");

                entity.HasIndex(e => e.ValuationDate)
                    .HasName("idxOpenFFXPosition_ValuationDate");

                entity.Property(e => e.OpenFfxid).HasColumnName("OpenFFXID");

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.ClientTradeId).HasColumnName("ClientTradeID");

                entity.Property(e => e.ContractFwdRate).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CounterPartyId).HasColumnName("CounterPartyID");

                entity.Property(e => e.CurrentFwdRate).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ExchBuyToPfMorDflag)
                    .HasColumnName("ExchBuyToPfMorDFlag")
                    .HasMaxLength(1);

                entity.Property(e => e.ExchSellToPfMorDflag)
                    .HasColumnName("ExchSellToPfMorDFlag")
                    .HasMaxLength(1);

                entity.Property(e => e.ExchangeRateBuyToPortfolio).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ExchangeRateSellToPortfolio).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.HiportTransactionId)
                    .IsRequired()
                    .HasColumnName("HiportTransactionID")
                    .HasMaxLength(255);

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.InstrumentId).HasColumnName("InstrumentID");

                entity.Property(e => e.LoadId).HasColumnName("LoadID");

                entity.Property(e => e.MaturityDate).HasColumnType("date");

                entity.Property(e => e.PortfolioCurrencyCode).HasMaxLength(3);

                entity.Property(e => e.PortfolioId).HasColumnName("PortfolioID");

                entity.Property(e => e.TradeDate).HasColumnType("date");

                entity.Property(e => e.UnrealisedFxgainLoss)
                    .HasColumnName("UnrealisedFXGainLoss")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ValuationDate).HasColumnType("date");

                entity.Property(e => e.ValuationRunDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.CounterParty)
                    .WithMany(p => p.OpenFfxposition)
                    .HasForeignKey(d => d.CounterPartyId)
                    .HasConstraintName("FK_OpenFFXPosition_CounterParty");

                entity.HasOne(d => d.InstrumentPortfolio)
                    .WithMany(p => p.OpenFfxposition)
                    .HasForeignKey(d => new { d.InstrumentId, d.PortfolioId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("OpenFFXPosition_InstrumentPortfolio_FK1");
            });

            modelBuilder.Entity<OracleGl>(entity =>
            {
                entity.ToTable("OracleGL");

                entity.Property(e => e.OracleGlid).HasColumnName("OracleGLID");

                entity.Property(e => e.AccountDesc).HasMaxLength(255);

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.CostCentre)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.PortfolioId).HasColumnName("PortfolioID");

                entity.HasOne(d => d.Portfolio)
                    .WithMany(p => p.OracleGl)
                    .HasForeignKey(d => d.PortfolioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OracleGL_Portfolio");
            });

            modelBuilder.Entity<PerformanceHistory>(entity =>
            {
                entity.Property(e => e.PerformanceHistoryId).HasColumnName("PerformanceHistoryID");

                entity.Property(e => e.ApprovedBy).HasMaxLength(50);

                entity.Property(e => e.ApprovedDatetime).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDatetime).HasColumnType("datetime");

                entity.Property(e => e.IsMonthly).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.ValuationDate).HasColumnType("date");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.PerformanceHistory)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PerformanceHistory_Status");
            });

            modelBuilder.Entity<PerformanceHistoryDetails>(entity =>
            {
                entity.Property(e => e.PerformanceHistoryDetailsId).HasColumnName("PerformanceHistoryDetailsID");

                entity.Property(e => e.AdjustmentAllocations).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.AdjustmentDailyFundingAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.AdjustmentNavdiscounted)
                    .HasColumnName("AdjustmentNAVDiscounted")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.AdjustmentNavdiscountedPrevious)
                    .HasColumnName("AdjustmentNAVDiscountedPrevious")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.AdjustmentNavlastPrice)
                    .HasColumnName("AdjustmentNAVLastPrice")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Allocations).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ApprovedBy).HasMaxLength(50);

                entity.Property(e => e.ApprovedDatetime).HasColumnType("datetime");

                entity.Property(e => e.AssetClassId).HasColumnName("AssetClassID");

                entity.Property(e => e.DailyFundingAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LastModifiedDatetime).HasColumnType("datetime");

                entity.Property(e => e.ManagerBenchmarkReturn).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.ManagerUnhedgedBenchmarkReturn).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Navdiscounted)
                    .HasColumnName("NAVDiscounted")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.NavdiscountedPrevious)
                    .HasColumnName("NAVDiscountedPrevious")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.NavlastPrice)
                    .HasColumnName("NAVLastPrice")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PerformanceHistoryId).HasColumnName("PerformanceHistoryID");

                entity.Property(e => e.PortfolioId).HasColumnName("PortfolioID");

                entity.Property(e => e.ReservesBenchmarkReturn).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.ReservesUnhedgedBenchmarkReturn).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.Return).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.AssetClass)
                    .WithMany(p => p.PerformanceHistoryDetails)
                    .HasForeignKey(d => d.AssetClassId)
                    .HasConstraintName("FK_PerformanceHistoryDetails_AssetClass");

                entity.HasOne(d => d.PerformanceHistory)
                    .WithMany(p => p.PerformanceHistoryDetails)
                    .HasForeignKey(d => d.PerformanceHistoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PerformanceHistoryDetails_PerformanceHistory");

                entity.HasOne(d => d.Portfolio)
                    .WithMany(p => p.PerformanceHistoryDetails)
                    .HasForeignKey(d => d.PortfolioId)
                    .HasConstraintName("FK_PerformanceHistoryDetails_Portfolio");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.PerformanceHistoryDetails)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PerformanceHistoryDetails_Status");
            });

            modelBuilder.Entity<PlaceOfSettlement>(entity =>
            {
                entity.HasKey(e => e.Psetid);

                entity.Property(e => e.Psetid).HasColumnName("PSETId");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.Psetbic)
                    .HasColumnName("PSETBIC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PsetclearingBkrPrimary)
                    .HasColumnName("PSETClearingBkrPrimary")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PsetclearingBkrSecondary)
                    .HasColumnName("PSETClearingBkrSecondary")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PsetclearingBkrTertiary)
                    .HasColumnName("PSETClearingBkrTertiary")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PsetcountryCode)
                    .HasColumnName("PSETCountryCode")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PsetexecutingBkrPrimary)
                    .HasColumnName("PSETExecutingBkrPrimary")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PsetexecutingBkrSecondary)
                    .HasColumnName("PSETExecutingBkrSecondary")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PsetexecutingBkrTertiary)
                    .HasColumnName("PSETExecutingBkrTertiary")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Psetname)
                    .HasColumnName("PSETName")
                    .HasMaxLength(300);
            });

            modelBuilder.Entity<Portfolio>(entity =>
            {
                entity.Property(e => e.PortfolioId).HasColumnName("PortfolioID");

                entity.Property(e => e.AccfundCode)
                    .HasColumnName("ACCFundCode")
                    .HasMaxLength(255);

                entity.Property(e => e.Analysis).HasMaxLength(255);

                entity.Property(e => e.Closed).HasDefaultValueSql("((0))");

                entity.Property(e => e.Custodian).HasMaxLength(50);

                entity.Property(e => e.CustodianCode).HasColumnType("nvarchar(1000)");

                entity.Property(e => e.CustodyAccount).HasMaxLength(255);

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.Managed).HasMaxLength(255);

                entity.Property(e => e.Name).HasColumnType("nvarchar(1000)");

                entity.Property(e => e.PortfolioEndDate).HasColumnType("date");

                entity.Property(e => e.PortfolioStartDate).HasColumnType("date");
            });

            modelBuilder.Entity<PortfolioAssetClass>(entity =>
            {
                entity.HasKey(e => new { e.PortfolioId, e.AssetClassId });

                entity.Property(e => e.PortfolioId).HasColumnName("PortfolioID");

                entity.Property(e => e.AssetClassId).HasColumnName("AssetClassID");

                entity.Property(e => e.EffectiveFrom).HasColumnType("date");

                entity.Property(e => e.EffectiveTo).HasColumnType("date");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.AssetClass)
                    .WithMany(p => p.PortfolioAssetClass)
                    .HasForeignKey(d => d.AssetClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAC_AssetClass");

                entity.HasOne(d => d.Portfolio)
                    .WithMany(p => p.PortfolioAssetClass)
                    .HasForeignKey(d => d.PortfolioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAC_Portfolio");
            });

            modelBuilder.Entity<PortfolioComponent>(entity =>
            {
                entity.Property(e => e.PortfolioComponentId).HasColumnName("PortfolioComponentID");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.PortfolioId).HasColumnName("PortfolioID");

                entity.HasOne(d => d.Portfolio)
                    .WithMany(p => p.PortfolioComponent)
                    .HasForeignKey(d => d.PortfolioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PortfolioComponent_Portfolio");
            });

            modelBuilder.Entity<Provider>(entity =>
            {
                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.Code).HasMaxLength(30);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ProviderDataSource>(entity =>
            {
                entity.Property(e => e.ProviderDataSourceId).HasColumnName("ProviderDataSourceID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.ProviderDataSource)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("FK_ProviderDataSource_Provider");
            });

            modelBuilder.Entity<ProviderRequest>(entity =>
            {
                entity.Property(e => e.ProviderRequestId).HasColumnName("ProviderRequestID");

                entity.Property(e => e.Created).HasColumnType("date");

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.ProviderRef)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RequestRawData).IsRequired();

                entity.Property(e => e.RequestSent).HasColumnType("date");

                entity.Property(e => e.ResponseReceived).HasColumnType("date");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.ProviderRequest)
                    .HasForeignKey(d => d.ProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK1_ProviderRequest_Provider");
            });

            modelBuilder.Entity<ProviderRequestItem>(entity =>
            {
                entity.Property(e => e.ProviderRequestItemId).HasColumnName("ProviderRequestItemID");

                entity.Property(e => e.Created).HasColumnType("date");

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.ProviderRequestId).HasColumnName("ProviderRequestID");

                entity.Property(e => e.RequestProviderId).HasColumnName("RequestProviderID");

                entity.Property(e => e.RequestTypeId).HasColumnName("RequestTypeID");

                entity.Property(e => e.SearchId)
                    .IsRequired()
                    .HasColumnName("SearchID")
                    .HasMaxLength(255);

                entity.Property(e => e.TableId).HasColumnName("TableID");

                entity.HasOne(d => d.ProviderRequest)
                    .WithMany(p => p.ProviderRequestItem)
                    .HasForeignKey(d => d.ProviderRequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProviderRequestItem_ProviderRequest");
            });

            modelBuilder.Entity<Reconciliation>(entity =>
            {
                entity.Property(e => e.ReconciliationId).HasColumnName("ReconciliationID");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ReconciliationCategory>(entity =>
            {
                entity.Property(e => e.ReconciliationCategoryId).HasColumnName("ReconciliationCategoryID");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ReconciliationCategoryReconciliation>(entity =>
            {
                entity.HasKey(e => new { e.ReconciliationCategoryId, e.ReconciliationId });

                entity.Property(e => e.ReconciliationCategoryId).HasColumnName("ReconciliationCategoryID");

                entity.Property(e => e.ReconciliationId).HasColumnName("ReconciliationID");

                entity.HasOne(d => d.ReconciliationCategory)
                    .WithMany(p => p.ReconciliationCategoryReconciliation)
                    .HasForeignKey(d => d.ReconciliationCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReconciliationCategoryReconciliation_ReconciliationCategory");

                entity.HasOne(d => d.Reconciliation)
                    .WithMany(p => p.ReconciliationCategoryReconciliation)
                    .HasForeignKey(d => d.ReconciliationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReconciliationCategoryReconciliation_Reconciliation");
            });

            modelBuilder.Entity<ReconciliationDefinition>(entity =>
            {
                entity.Property(e => e.ReconciliationDefinitionId).HasColumnName("ReconciliationDefinitionID");

                entity.Property(e => e.Definition).IsRequired();

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ReconciliationId).HasColumnName("ReconciliationID");

                entity.HasOne(d => d.Reconciliation)
                    .WithMany(p => p.ReconciliationDefinition)
                    .HasForeignKey(d => d.ReconciliationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReconciliationDefinition_Reconciliation");
            });

            modelBuilder.Entity<ReconciliationDefinitionRun>(entity =>
            {
                entity.Property(e => e.ReconciliationDefinitionRunId).HasColumnName("ReconciliationDefinitionRunID");

                entity.Property(e => e.ExecutionDateTime).HasColumnType("datetime");

                entity.Property(e => e.ReconciliationDefinitionId).HasColumnName("ReconciliationDefinitionID");

                entity.Property(e => e.ReconciliationRunId).HasColumnName("ReconciliationRunID");

                entity.Property(e => e.ResultXml).HasColumnName("ResultXML");

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.ReconciliationDefinition)
                    .WithMany(p => p.ReconciliationDefinitionRun)
                    .HasForeignKey(d => d.ReconciliationDefinitionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReconciliationDefinitionRun_ReconciliationDefinition");

                entity.HasOne(d => d.ReconciliationRun)
                    .WithMany(p => p.ReconciliationDefinitionRun)
                    .HasForeignKey(d => d.ReconciliationRunId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReconciliationDefinitionRun_ReconciliationRunID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ReconciliationDefinitionRun)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReconciliationDefinitionRun_TestRunStatus");
            });

            modelBuilder.Entity<ReconciliationRun>(entity =>
            {
                entity.Property(e => e.ReconciliationRunId).HasColumnName("ReconciliationRunID");

                entity.Property(e => e.ApprovedBy).HasMaxLength(50);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.ExecutionDateTime).HasColumnType("datetime");

                entity.Property(e => e.ReconciliationId).HasColumnName("ReconciliationID");

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ValuationDate).HasColumnType("date");

                entity.HasOne(d => d.Reconciliation)
                    .WithMany(p => p.ReconciliationRun)
                    .HasForeignKey(d => d.ReconciliationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReconciliationRun_Reconciliation");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ReconciliationRun)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReconciliationRun_TestRunStatus");
            });

            modelBuilder.Entity<ReconciliationUserGroup>(entity =>
            {
                entity.HasKey(e => new { e.ReconciliationId, e.RoleId });

                entity.Property(e => e.ReconciliationId).HasColumnName("ReconciliationID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.CanApprove).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Reconciliation)
                    .WithMany(p => p.ReconciliationUserGroup)
                    .HasForeignKey(d => d.ReconciliationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReconciliationUserGroup_Reconciliation");
            });

            modelBuilder.Entity<ReconciliationValidation>(entity =>
            {
                entity.Property(e => e.ReconciliationValidationId).HasColumnName("ReconciliationValidationID");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Validation).IsRequired();
            });

            modelBuilder.Entity<ReconciliationValidationReconciliation>(entity =>
            {
                entity.HasKey(e => new { e.ReconciliationValidationId, e.ReconciliationId });

                entity.Property(e => e.ReconciliationValidationId).HasColumnName("ReconciliationValidationID");

                entity.Property(e => e.ReconciliationId).HasColumnName("ReconciliationID");

                entity.HasOne(d => d.Reconciliation)
                    .WithMany(p => p.ReconciliationValidationReconciliation)
                    .HasForeignKey(d => d.ReconciliationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReconciliationValidationReconciliation_Reconciliation");

                entity.HasOne(d => d.ReconciliationValidation)
                    .WithMany(p => p.ReconciliationValidationReconciliation)
                    .HasForeignKey(d => d.ReconciliationValidationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReconciliationValidationReconciliation_ReconciliationCategory");
            });

            modelBuilder.Entity<ReconciliationValidationRun>(entity =>
            {
                entity.Property(e => e.ReconciliationValidationRunId).HasColumnName("ReconciliationValidationRunID");

                entity.Property(e => e.ExecutionDateTime).HasColumnType("datetime");

                entity.Property(e => e.ReconciliationValidationId).HasColumnName("ReconciliationValidationID");

                entity.Property(e => e.ResultXml).HasColumnName("ResultXML");

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ValuationDate).HasColumnType("datetime");

                entity.HasOne(d => d.ReconciliationValidation)
                    .WithMany(p => p.ReconciliationValidationRun)
                    .HasForeignKey(d => d.ReconciliationValidationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReconciliationValidationRun_ReconciliationValidation");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ReconciliationValidationRun)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReconciliationValidationRun_ReconciliationValidationStatus");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.CreatedBy).HasMaxLength(20);

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.RegionCode).HasMaxLength(50);

                entity.Property(e => e.RegionName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.RimesbenchmarkInstrumentId).HasColumnName("RIMESBenchmarkInstrumentID");

                entity.Property(e => e.WhenCreated).HasColumnType("datetime");
            });

            modelBuilder.Entity<RegionCountryMapping>(entity =>
            {
                entity.HasKey(e => new { e.RegionId, e.CountryId });

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.RegionCountryMapping)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RegionCountry_FKCountry");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.RegionCountryMapping)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RegionCountry_FKRegion");
            });

            modelBuilder.Entity<RelatedType>(entity =>
            {
                entity.Property(e => e.RelatedTypeId).HasColumnName("RelatedTypeID");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.RelatedTypeCode)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ResourceFile>(entity =>
            {
                entity.Property(e => e.ResourceFileId).HasColumnName("ResourceFileID");

                entity.Property(e => e.InActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<ResourceFileVersion>(entity =>
            {
                entity.Property(e => e.ResourceFileVersionId).HasColumnName("ResourceFileVersionID");

                entity.Property(e => e.ContentType)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EffectiveFrom)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EffectiveTo).HasColumnType("date");

                entity.Property(e => e.InActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.Path).IsRequired();

                entity.Property(e => e.ResourceFileId).HasColumnName("ResourceFileID");

                entity.HasOne(d => d.ResourceFile)
                    .WithMany(p => p.ResourceFileVersion)
                    .HasForeignKey(d => d.ResourceFileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResourceFileVersion_ResourceFile");
            });

            modelBuilder.Entity<RestrictedInstrumentExclusion>(entity =>
            {
                entity.HasKey(e => new { e.PortfolioId, e.InstrumentId });

                entity.Property(e => e.PortfolioId).HasColumnName("PortfolioID");

                entity.Property(e => e.InstrumentId).HasColumnName("InstrumentID");
            });

            modelBuilder.Entity<Sshentity>(entity =>
            {
                entity.ToTable("SSHEntity");

                entity.Property(e => e.SshentityId).HasColumnName("SSHEntityID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateNotified).HasColumnType("datetime");

                entity.Property(e => e.ExchangeId).HasColumnName("ExchangeID");

                entity.Property(e => e.InActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.SsheventTypeId).HasColumnName("SSHEventTypeID");

                entity.Property(e => e.SshtestId).HasColumnName("SSHTestID");

                entity.HasOne(d => d.Exchange)
                    .WithMany(p => p.Sshentity)
                    .HasForeignKey(d => d.ExchangeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SSHEntity_Exchange");

                entity.HasOne(d => d.Instrument)
                    .WithMany(p => p.Sshentity)
                    .HasForeignKey(d => d.InstrumentId)
                    .HasConstraintName("FK_SSHEntity_Instrument");

                entity.HasOne(d => d.InstrumentSubType)
                    .WithMany(p => p.Sshentity)
                    .HasForeignKey(d => d.InstrumentSubTypeId)
                    .HasConstraintName("FK_SSHEntity_InstrumentSubType");

                entity.HasOne(d => d.Issuer)
                    .WithMany(p => p.Sshentity)
                    .HasForeignKey(d => d.IssuerId)
                    .HasConstraintName("FK_SSHEntity_Issuer");

                entity.HasOne(d => d.SsheventType)
                    .WithMany(p => p.Sshentity)
                    .HasForeignKey(d => d.SsheventTypeId)
                    .HasConstraintName("FK_SSHEntity_SSHEventType");

                entity.HasOne(d => d.Sshtest)
                    .WithMany(p => p.Sshentity)
                    .HasForeignKey(d => d.SshtestId)
                    .HasConstraintName("FK_SSHEntity_SSHTest");
            });

            modelBuilder.Entity<Sshevent>(entity =>
            {
                entity.ToTable("SSHEvent");

                entity.Property(e => e.SsheventId).HasColumnName("SSHEventID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateNotified).HasColumnType("datetime");

                entity.Property(e => e.EventComment).HasColumnType("nvarchar(1000)");

                entity.Property(e => e.InActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.NotifiedBy).HasMaxLength(100);

                entity.Property(e => e.ShareholdingPercentage).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.Shares).HasColumnType("decimal(, 8)");

                entity.Property(e => e.SharesOnIssue).HasColumnType("decimal(, 8)");

                entity.Property(e => e.SshentityId).HasColumnName("SSHEntityID");

                entity.Property(e => e.SsheventTypeId).HasColumnName("SSHEventTypeID");

                entity.Property(e => e.SshtestId).HasColumnName("SSHTestID");

                entity.Property(e => e.ThresholdPercent).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.ValuationDate).HasColumnType("datetime");

                entity.HasOne(d => d.Sshentity)
                    .WithMany(p => p.Sshevent)
                    .HasForeignKey(d => d.SshentityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SSHEvent_SSHEntity");

                entity.HasOne(d => d.SsheventType)
                    .WithMany(p => p.Sshevent)
                    .HasForeignKey(d => d.SsheventTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SSHEvent_SSHEventType");

                entity.HasOne(d => d.Sshtest)
                    .WithMany(p => p.Sshevent)
                    .HasForeignKey(d => d.SshtestId)
                    .HasConstraintName("FK_SSHEvent_SSHTest");
            });

            modelBuilder.Entity<SsheventType>(entity =>
            {
                entity.ToTable("SSHEventType");

                entity.Property(e => e.SsheventTypeId).HasColumnName("SSHEventTypeID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.EventDescription).HasMaxLength(255);

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Sshtest>(entity =>
            {
                entity.ToTable("SSHTest");

                entity.Property(e => e.SshtestId).HasColumnName("SSHTestID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.InActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.ValuationDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Ssi>(entity =>
            {
                entity.ToTable("SSI");

                entity.Property(e => e.Ssiid).HasColumnName("SSIId");

                entity.Property(e => e.BeneficiaryAccountName).HasMaxLength(255);

                entity.Property(e => e.BeneficiaryAccountNumber).HasMaxLength(255);

                entity.Property(e => e.BeneficiaryBankBic)
                    .HasColumnName("BeneficiaryBankBIC")
                    .HasMaxLength(255);

                entity.Property(e => e.BeneficiaryBankName).HasMaxLength(255);

                entity.Property(e => e.ClearCode).HasMaxLength(50);

                entity.Property(e => e.ClearingBrokerPrimary)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClearingBrokerSecondary)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClearingBrokerTertiary)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustodianId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ExecutingBrokerNumber).HasMaxLength(255);

                entity.Property(e => e.ExecutingBrokerPrimary)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ExecutingBrokerSecondary)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ExecutingBrokerTertiary)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.IntermediaryBic)
                    .HasColumnName("IntermediaryBIC")
                    .HasMaxLength(255);

                entity.Property(e => e.IntermediaryName).HasMaxLength(255);

                entity.Property(e => e.JpmsecLendingId).HasColumnName("JPMSecLendingId");

                entity.Property(e => e.Psetid).HasColumnName("PSETId");

                entity.Property(e => e.SpecialAccountNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UltimateBeneficiaryBic)
                    .HasColumnName("UltimateBeneficiaryBIC")
                    .HasMaxLength(255);

                entity.HasOne(d => d.CounterParty)
                    .WithMany(p => p.Ssi)
                    .HasForeignKey(d => d.CounterPartyId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.InstrumentType)
                    .WithMany(p => p.Ssi)
                    .HasForeignKey(d => d.InstrumentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SSI_InstrumentType");

                entity.HasOne(d => d.Pset)
                    .WithMany(p => p.Ssi)
                    .HasForeignKey(d => d.Psetid);
            });

            modelBuilder.Entity<Ssihistory>(entity =>
            {
                entity.ToTable("SSIHistory");

                entity.Property(e => e.SsihistoryId).HasColumnName("SSIHistoryID");

                entity.Property(e => e.BeneficiaryAccountName).HasMaxLength(255);

                entity.Property(e => e.BeneficiaryAccountNumber).HasMaxLength(255);

                entity.Property(e => e.BeneficiaryBankBic)
                    .HasColumnName("BeneficiaryBankBIC")
                    .HasMaxLength(255);

                entity.Property(e => e.BeneficiaryBankName).HasMaxLength(255);

                entity.Property(e => e.ClearCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClearingBrokerPrimary)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClearingBrokerSecondary)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClearingBrokerTertiary)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Comments).HasColumnType("nvarchar(1000)");

                entity.Property(e => e.CustodianId)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ExecutingBrokerNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ExecutingBrokerPrimary)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ExecutingBrokerSecondary)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ExecutingBrokerTertiary)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.IntermediaryBic)
                    .HasColumnName("IntermediaryBIC")
                    .HasMaxLength(255);

                entity.Property(e => e.IntermediaryName).HasMaxLength(255);

                entity.Property(e => e.JpmsecLendingId).HasColumnName("JPMSecLendingId");

                entity.Property(e => e.Psetid).HasColumnName("PSETId");

                entity.Property(e => e.SpecialAccountNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ssiid).HasColumnName("SSIId");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.UltimateBeneficiaryBic)
                    .HasColumnName("UltimateBeneficiaryBIC")
                    .HasMaxLength(255);

                entity.Property(e => e.WhenCreated).HasColumnType("datetime");

                entity.Property(e => e.WhoChanged)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.CounterParty)
                    .WithMany(p => p.Ssihistory)
                    .HasForeignKey(d => d.CounterPartyId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.InstrumentType)
                    .WithMany(p => p.Ssihistory)
                    .HasForeignKey(d => d.InstrumentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SSIHisotry_InstrumentType");

                entity.HasOne(d => d.Pset)
                    .WithMany(p => p.Ssihistory)
                    .HasForeignKey(d => d.Psetid);

                entity.HasOne(d => d.Ssi)
                    .WithMany(p => p.Ssihistory)
                    .HasForeignKey(d => d.Ssiid)
                    .HasConstraintName("FK_SSIHistory_SSI");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Ssihistory)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_SSIHistory_Status");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.StatusName).HasMaxLength(255);
            });

            modelBuilder.Entity<SwapHolidayList>(entity =>
            {
                entity.Property(e => e.FrequentlyUsed).HasDefaultValueSql("((0))");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.SwapHolidayListCode).HasMaxLength(100);

                entity.Property(e => e.SwapHolidayListDesc).HasMaxLength(200);
            });

            modelBuilder.Entity<SystemVariables>(entity =>
            {
                entity.HasKey(e => e.VariableName);

                entity.Property(e => e.VariableName)
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.IsLocked).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.VariableValue).IsRequired();
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.TestDefinitionId).HasColumnName("TestDefinitionID");

                entity.Property(e => e.Version).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Test)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_Test_Status");

                entity.HasOne(d => d.TestDefinition)
                    .WithMany(p => p.Test)
                    .HasForeignKey(d => d.TestDefinitionId)
                    .HasConstraintName("FK_Test_TestDefinition");

                entity.HasOne(d => d.TestStep)
                    .WithMany(p => p.Test)
                    .HasForeignKey(d => d.TestStepId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Test_TestStep");
            });

            modelBuilder.Entity<TestDefinition>(entity =>
            {
                entity.Property(e => e.TestDefinitionId).HasColumnName("TestDefinitionID");

                entity.Property(e => e.BlockInterim).HasDefaultValueSql("((0))");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ignore).HasDefaultValueSql("((0))");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TestGroupId).HasColumnName("TestGroupID");

                entity.Property(e => e.TestTypeId).HasColumnName("TestTypeID");

                entity.HasOne(d => d.TestGroup)
                    .WithMany(p => p.TestDefinition)
                    .HasForeignKey(d => d.TestGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TestDefinition_TestGroup");

                entity.HasOne(d => d.TestType)
                    .WithMany(p => p.TestDefinition)
                    .HasForeignKey(d => d.TestTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TestDefinition_TestType");
            });

            modelBuilder.Entity<TestGroup>(entity =>
            {
                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.ExcludeFromAutoQueue).HasDefaultValueSql("((0))");

                entity.Property(e => e.TestGroupName).HasMaxLength(255);

                entity.HasOne(d => d.ParentTestGroup)
                    .WithMany(p => p.InverseParentTestGroup)
                    .HasForeignKey(d => d.ParentTestGroupId)
                    .HasConstraintName("FK_TestGroup_ParentTestGroupId");
            });

            modelBuilder.Entity<TestRange>(entity =>
            {
                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LowerLimit).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RangeType).HasMaxLength(20);

                entity.Property(e => e.TestRangeName).HasMaxLength(255);

                entity.Property(e => e.UpperLimit).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.Test)
                    .WithMany(p => p.TestRange)
                    .HasForeignKey(d => d.TestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TestRange_TestId");

                entity.HasOne(d => d.TestStatus)
                    .WithMany(p => p.TestRange)
                    .HasForeignKey(d => d.TestStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TestRange_TestStatusId");
            });

            modelBuilder.Entity<TestRangeDynamic>(entity =>
            {
                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LowerLimitPropertyName).HasMaxLength(255);

                entity.Property(e => e.RangeType).HasMaxLength(20);

                entity.Property(e => e.TestRangeDynamicName).HasMaxLength(255);

                entity.Property(e => e.UpperLimitPropertyName).HasMaxLength(255);

                entity.HasOne(d => d.Measurement)
                    .WithMany(p => p.TestRangeDynamic)
                    .HasForeignKey(d => d.MeasurementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TestRangeDynamic_Measurement");

                entity.HasOne(d => d.Test)
                    .WithMany(p => p.TestRangeDynamic)
                    .HasForeignKey(d => d.TestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TestRangeDynamic_TestId");

                entity.HasOne(d => d.TestStatus)
                    .WithMany(p => p.TestRangeDynamic)
                    .HasForeignKey(d => d.TestStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TestRangeDynamic_TestStatusId");
            });

            modelBuilder.Entity<TestRun>(entity =>
            {
                entity.HasIndex(e => e.ValuationDate);

                entity.Property(e => e.Approved).HasDefaultValueSql("((0))");

                entity.Property(e => e.ApprovedBy).HasMaxLength(20);

                entity.Property(e => e.Comment).HasColumnType("nvarchar(1000)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.ValuationDate).HasColumnType("datetime");

                entity.HasOne(d => d.OverrideTestStatus)
                    .WithMany(p => p.TestRunOverrideTestStatus)
                    .HasForeignKey(d => d.OverrideTestStatusId)
                    .HasConstraintName("FK_TestRun_OverrideTestStatus");

                entity.HasOne(d => d.TestRunStatus)
                    .WithMany(p => p.TestRun)
                    .HasForeignKey(d => d.TestRunStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TestRun_TestRunStatus");

                entity.HasOne(d => d.TestRunType)
                    .WithMany(p => p.TestRun)
                    .HasForeignKey(d => d.TestRunTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TestRun_TestRunType");

                entity.HasOne(d => d.TestStatus)
                    .WithMany(p => p.TestRunTestStatus)
                    .HasForeignKey(d => d.TestStatusId)
                    .HasConstraintName("FK_TestRun_TestStatus");

                entity.HasOne(d => d.TestType)
                    .WithMany(p => p.TestRun)
                    .HasForeignKey(d => d.TestTypeId)
                    .HasConstraintName("FK_TestRun_TestType");
            });

            modelBuilder.Entity<TestRunGroup>(entity =>
            {
                entity.HasIndex(e => e.TestRunId);

                entity.Property(e => e.Approved).HasDefaultValueSql("((0))");

                entity.Property(e => e.ApprovedBy).HasMaxLength(20);

                entity.Property(e => e.Comment).HasColumnType("nvarchar(1000)");

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.OverrideTestStatus)
                    .WithMany(p => p.TestRunGroupOverrideTestStatus)
                    .HasForeignKey(d => d.OverrideTestStatusId)
                    .HasConstraintName("FK_TestRunGroup_OverrideTestStatus");

                entity.HasOne(d => d.ParentTestRunGroup)
                    .WithMany(p => p.InverseParentTestRunGroup)
                    .HasForeignKey(d => d.ParentTestRunGroupId)
                    .HasConstraintName("FK_TestRunGroup_TestRunGroup");

                entity.HasOne(d => d.TestGroup)
                    .WithMany(p => p.TestRunGroup)
                    .HasForeignKey(d => d.TestGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TestRunGroup_TestGroup");

                entity.HasOne(d => d.TestRun)
                    .WithMany(p => p.TestRunGroup)
                    .HasForeignKey(d => d.TestRunId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TestRunGroup_TestRun");

                entity.HasOne(d => d.TestRunStatus)
                    .WithMany(p => p.TestRunGroup)
                    .HasForeignKey(d => d.TestRunStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TestRunGroup_TestRunStatus");

                entity.HasOne(d => d.TestStatus)
                    .WithMany(p => p.TestRunGroupTestStatus)
                    .HasForeignKey(d => d.TestStatusId)
                    .HasConstraintName("FK_TestRunGroup_TestStatus");
            });

            modelBuilder.Entity<TestRunItem>(entity =>
            {
                entity.HasIndex(e => e.TestId);

                entity.HasIndex(e => new { e.TestRunId, e.Sequence });

                entity.Property(e => e.Approved).HasDefaultValueSql("((0))");

                entity.Property(e => e.ApprovedBy).HasMaxLength(20);

                entity.Property(e => e.Comment).HasColumnType("nvarchar(1000)");

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.ExecutionDate).HasColumnType("datetime");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.OverrideTestStatus)
                    .WithMany(p => p.TestRunItemOverrideTestStatus)
                    .HasForeignKey(d => d.OverrideTestStatusId)
                    .HasConstraintName("FK_TestRunItem_OverrideTestStatus");

                entity.HasOne(d => d.TestGroup)
                    .WithMany(p => p.TestRunItem)
                    .HasForeignKey(d => d.TestGroupId)
                    .HasConstraintName("FK_TestRunItem_TestGroup");

                entity.HasOne(d => d.Test)
                    .WithMany(p => p.TestRunItem)
                    .HasForeignKey(d => d.TestId)
                    .HasConstraintName("FK_TestRunItem_Test");

                entity.HasOne(d => d.TestRunGroup)
                    .WithMany(p => p.TestRunItem)
                    .HasForeignKey(d => d.TestRunGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TestRunItem_TestRunGroup");

                entity.HasOne(d => d.TestRun)
                    .WithMany(p => p.TestRunItem)
                    .HasForeignKey(d => d.TestRunId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TestRunItem_TestRun");

                entity.HasOne(d => d.TestRunStatus)
                    .WithMany(p => p.TestRunItem)
                    .HasForeignKey(d => d.TestRunStatusId)
                    .HasConstraintName("FK_TestRunItem_TestRunStatus");

                entity.HasOne(d => d.TestStatus)
                    .WithMany(p => p.TestRunItemTestStatus)
                    .HasForeignKey(d => d.TestStatusId)
                    .HasConstraintName("FK_TestRunItem_TestStatus");
            });

            modelBuilder.Entity<TestRunItemRange>(entity =>
            {
                entity.HasIndex(e => e.TestRunItemStepId)
                    .HasName("IX_TestRunItemRange_TestRunItemStep");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.LowerLimit).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RangeType).HasMaxLength(20);

                entity.Property(e => e.RangeXml)
                    .HasColumnName("RangeXML")
                    .IsUnicode(false);

                entity.Property(e => e.UpperLimit).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.TestRangeDynamic)
                    .WithMany(p => p.TestRunItemRange)
                    .HasForeignKey(d => d.TestRangeDynamicId)
                    .HasConstraintName("FK_TestRunItemRange_TestRangeDynamic");

                entity.HasOne(d => d.TestRange)
                    .WithMany(p => p.TestRunItemRange)
                    .HasForeignKey(d => d.TestRangeId)
                    .HasConstraintName("FK_TestRunItemRange_TestRange");

                entity.HasOne(d => d.TestRunItemStep)
                    .WithMany(p => p.TestRunItemRange)
                    .HasForeignKey(d => d.TestRunItemStepId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TestRunItemRange_TestRunItemStep");

                entity.HasOne(d => d.TestStatus)
                    .WithMany(p => p.TestRunItemRange)
                    .HasForeignKey(d => d.TestStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TestRunItemRange_TestStatusId");
            });

            modelBuilder.Entity<TestRunItemStep>(entity =>
            {
                entity.HasIndex(e => e.TestId);

                entity.HasIndex(e => e.TestRunItemId);

                entity.HasIndex(e => e.TestStepId);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.OutputXml)
                    .HasColumnName("OutputXML")
                    .IsUnicode(false);

                entity.HasOne(d => d.Test)
                    .WithMany(p => p.TestRunItemStep)
                    .HasForeignKey(d => d.TestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TestRunResults_Test");

                entity.HasOne(d => d.TestRunItem)
                    .WithMany(p => p.TestRunItemStep)
                    .HasForeignKey(d => d.TestRunItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TestRunResults_TestRunItem");

                entity.HasOne(d => d.TestStep)
                    .WithMany(p => p.TestRunItemStep)
                    .HasForeignKey(d => d.TestStepId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TestRunResults_TestStep");
            });

            modelBuilder.Entity<TestRunStatus>(entity =>
            {
                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.TestRunStatusDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TestRunType>(entity =>
            {
                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.TestRunTypeDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TestStatus>(entity =>
            {
                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.TestStatusName).HasMaxLength(255);
            });

            modelBuilder.Entity<TestStep>(entity =>
            {
                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.ExpressionName).HasMaxLength(255);

                entity.Property(e => e.OperandAtestStepId).HasColumnName("OperandATestStepId");

                entity.Property(e => e.OperandBtestStepId).HasColumnName("OperandBTestSTepId");

                entity.Property(e => e.Operator).HasMaxLength(10);

                entity.Property(e => e.TestStepName).HasMaxLength(255);

                entity.HasOne(d => d.Measurement)
                    .WithMany(p => p.TestStep)
                    .HasForeignKey(d => d.MeasurementId)
                    .HasConstraintName("FK_TestStep_MeasurementId");

                entity.HasOne(d => d.OperandAtestStep)
                    .WithMany(p => p.InverseOperandAtestStep)
                    .HasForeignKey(d => d.OperandAtestStepId)
                    .HasConstraintName("FK_TestStep_OperandATestStepId");

                entity.HasOne(d => d.OperandBtestStep)
                    .WithMany(p => p.InverseOperandBtestStep)
                    .HasForeignKey(d => d.OperandBtestStepId)
                    .HasConstraintName("FK_TestStep_OperandBTestStepId");

                entity.HasOne(d => d.TestStepType)
                    .WithMany(p => p.TestStep)
                    .HasForeignKey(d => d.TestStepTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TestStep_TestStepTypeId");
            });

            modelBuilder.Entity<TestStepType>(entity =>
            {
                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.TestStepTypeName).HasMaxLength(255);
            });

            modelBuilder.Entity<TestType>(entity =>
            {
                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.TestTypeName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TickerExchange>(entity =>
            {
                entity.HasKey(e => e.TickerExchangeCode);

                entity.Property(e => e.TickerExchangeCode)
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.ExchangeId).HasColumnName("ExchangeID");

                entity.HasOne(d => d.Exchange)
                    .WithMany(p => p.TickerExchange)
                    .HasForeignKey(d => d.ExchangeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TickerExchange_Exchange");
            });

            modelBuilder.Entity<TotalEquityWeightReported>(entity =>
            {
                entity.Property(e => e.TotalEquityWeightReportedId).HasColumnName("TotalEquityWeightReportedID");

                entity.Property(e => e.EffectiveDate).HasColumnType("date");

                entity.Property(e => e.FundingAccountId).HasColumnName("FundingAccountID");

                entity.Property(e => e.Value).HasColumnType("decimal(18, 12)");

                entity.HasOne(d => d.FundingAccount)
                    .WithMany(p => p.TotalEquityWeightReported)
                    .HasForeignKey(d => d.FundingAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TotalEquityWeightReported_ToFundingAccount");
            });

            modelBuilder.Entity<TotalEquityWeightTestHistory>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.FundingAccountId).HasColumnName("FundingAccountID");

                entity.Property(e => e.RunId).HasColumnName("RunID");

                entity.Property(e => e.T1date)
                    .HasColumnName("T1Date")
                    .HasColumnType("date");

                entity.Property(e => e.T2date)
                    .HasColumnName("T2Date")
                    .HasColumnType("date");

                entity.Property(e => e.Tdate)
                    .HasColumnName("TDate")
                    .HasColumnType("date");

                entity.Property(e => e.TestName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.TestStatusId).HasColumnName("TestStatusID");

                entity.Property(e => e.ValuationDate).HasColumnType("date");

                entity.HasOne(d => d.FundingAccount)
                    .WithMany(p => p.TotalEquityWeightTestHistory)
                    .HasForeignKey(d => d.FundingAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TotalEquityWeightTestHistory_ToFundingAccount");

                entity.HasOne(d => d.TestStatus)
                    .WithMany(p => p.TotalEquityWeightTestHistory)
                    .HasForeignKey(d => d.TestStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TotalEquityWeightTestHistory_ToTestStatus");
            });

            modelBuilder.Entity<Trade>(entity =>
            {
                entity.HasIndex(e => e.InstrumentId)
                    .HasName("idxTrade_InstrumentId");

                entity.HasIndex(e => e.TradeDate)
                    .HasName("idxTrade_TradeDate");

                entity.Property(e => e.TradeId).HasColumnName("TradeID");

                entity.Property(e => e.Accrued).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.AdditionalCouponAmount).HasColumnType("money");

                entity.Property(e => e.AdditionalCouponDate).HasColumnType("date");

                entity.Property(e => e.BbeventReference)
                    .HasColumnName("BBEventReference")
                    .HasMaxLength(255);

                entity.Property(e => e.BboriginalTicketReference).HasColumnName("BBOriginalTicketReference");

                entity.Property(e => e.BbtransNum).HasColumnName("BBTransNum");

                entity.Property(e => e.BrokerId).HasColumnName("BrokerID");

                entity.Property(e => e.BrokerageRate).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.BrokerageUnits).HasMaxLength(255);

                entity.Property(e => e.BuyAmount).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CleanPrice).HasColumnType("money");

                entity.Property(e => e.CloseOutAmount).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CloseOutCurrency).HasMaxLength(50);

                entity.Property(e => e.CloseOutType).HasMaxLength(50);

                entity.Property(e => e.Collateralised).HasMaxLength(255);

                entity.Property(e => e.Comment).HasColumnType("nvarchar(1000)");

                entity.Property(e => e.Commission).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ExchangeCode).HasMaxLength(255);

                entity.Property(e => e.FaceValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Fees).HasColumnType("money");

                entity.Property(e => e.FeesLocalCurrency).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.FixedRate).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.GrossAmount).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.Instrument2Id).HasColumnName("Instrument2ID");

                entity.Property(e => e.InstrumentId).HasColumnName("InstrumentID");

                entity.Property(e => e.Interest).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.InterestAmountPaid).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.InterestAmountReceived).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.InternalRefNumber).HasMaxLength(255);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Margin).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Notes).HasColumnType("nvarchar(1000)");

                entity.Property(e => e.NumberOfShares).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.OpenFfxid).HasColumnName("OpenFFXID");

                entity.Property(e => e.OriginalSource).HasMaxLength(50);

                entity.Property(e => e.OtherCharges).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.PaymentDate).HasColumnType("date");

                entity.Property(e => e.PortfolioId).HasColumnName("PortfolioID");

                entity.Property(e => e.Price).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ReasonForCancellation).HasMaxLength(255);

                entity.Property(e => e.ReturnDate).HasColumnType("date");

                entity.Property(e => e.ReturnSecurityLendingId).HasColumnName("ReturnSecurityLendingID");

                entity.Property(e => e.SecurityLendingId).HasColumnName("SecurityLendingID");

                entity.Property(e => e.SellAmount).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SettlementAmount).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SettlementDate).HasColumnType("date");

                entity.Property(e => e.StampDuty).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.SwapType).HasMaxLength(50);

                entity.Property(e => e.TotalConsideration).HasColumnType("money");

                entity.Property(e => e.TradeDate).HasColumnType("date");

                entity.Property(e => e.TradeGroupId).HasColumnName("TradeGroupID");

                entity.Property(e => e.TradeStatusId).HasColumnName("TradeStatusID");

                entity.Property(e => e.TradeType).HasMaxLength(20);

                entity.Property(e => e.Transaction2Id).HasColumnName("Transaction2ID");

                entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

                entity.Property(e => e.TransactionTypeId).HasColumnName("TransactionTypeID");

                entity.Property(e => e.UpFrontFee).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Yield).HasColumnType("decimal(18, 6)");

                entity.HasOne(d => d.Broker)
                    .WithMany(p => p.Trade)
                    .HasForeignKey(d => d.BrokerId)
                    .HasConstraintName("FK_Trade_CounterParty");

                entity.HasOne(d => d.Instrument2)
                    .WithMany(p => p.TradeInstrument2)
                    .HasForeignKey(d => d.Instrument2Id)
                    .HasConstraintName("FK_Trade_Instrument1");

                entity.HasOne(d => d.Instrument)
                    .WithMany(p => p.TradeInstrument)
                    .HasForeignKey(d => d.InstrumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Trade_Instrument");

                entity.HasOne(d => d.OpenFfx)
                    .WithMany(p => p.Trade)
                    .HasForeignKey(d => d.OpenFfxid)
                    .HasConstraintName("FK_Trade_OpenFFXPosition");

                entity.HasOne(d => d.Portfolio)
                    .WithMany(p => p.Trade)
                    .HasForeignKey(d => d.PortfolioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Trade_Portfolio");

                entity.HasOne(d => d.TradeGroup)
                    .WithMany(p => p.Trade)
                    .HasForeignKey(d => d.TradeGroupId)
                    .HasConstraintName("FK_Trade_TradeGroup");

                entity.HasOne(d => d.TradeStatus)
                    .WithMany(p => p.Trade)
                    .HasForeignKey(d => d.TradeStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Trade_TradeStatus");

                entity.HasOne(d => d.Transaction2)
                    .WithMany(p => p.TradeTransaction2)
                    .HasForeignKey(d => d.Transaction2Id)
                    .HasConstraintName("FK_Trade_Transaction2");

                entity.HasOne(d => d.Transaction)
                    .WithMany(p => p.TradeTransaction)
                    .HasForeignKey(d => d.TransactionId)
                    .HasConstraintName("FK_Trade_Transaction");

                entity.HasOne(d => d.TransactionType)
                    .WithMany(p => p.Trade)
                    .HasForeignKey(d => d.TransactionTypeId)
                    .HasConstraintName("FK_Trade_TransactionType");
            });

            modelBuilder.Entity<TradeConfirmation>(entity =>
            {
                entity.Property(e => e.TradeConfirmationId).HasColumnName("TradeConfirmationID");

                entity.Property(e => e.Commision).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CounterPartyId).HasColumnName("CounterPartyID");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Fees).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.InActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.Isin)
                    .HasColumnName("ISIN")
                    .HasMaxLength(255);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Sedol).HasMaxLength(255);

                entity.Property(e => e.SettlementAmount).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SettlementDate).HasColumnType("date");

                entity.Property(e => e.Ticker).HasMaxLength(255);

                entity.Property(e => e.TradeDate).HasColumnType("date");

                entity.Property(e => e.TradeId).HasColumnName("TradeID");

                entity.Property(e => e.TransactionTypeId).HasColumnName("TransactionTypeID");

                entity.HasOne(d => d.CounterParty)
                    .WithMany(p => p.TradeConfirmation)
                    .HasForeignKey(d => d.CounterPartyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TradeConfirmation_CounterParty");

                entity.HasOne(d => d.Trade)
                    .WithMany(p => p.TradeConfirmation)
                    .HasForeignKey(d => d.TradeId)
                    .HasConstraintName("FK_TradeConfirmation_Trade");

                entity.HasOne(d => d.TransactionType)
                    .WithMany(p => p.TradeConfirmation)
                    .HasForeignKey(d => d.TransactionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TradeConfirmation_TransactionType");
            });

            modelBuilder.Entity<TradeConfirmationFx>(entity =>
            {
                entity.ToTable("TradeConfirmationFX");

                entity.Property(e => e.TradeConfirmationFxid).HasColumnName("TradeConfirmationFXID");

                entity.Property(e => e.AccountName).HasMaxLength(255);

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.BuyAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BuyCurrency)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.ContractNumber)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CounterPartyId).HasColumnName("CounterPartyID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.InActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.LoadId).HasColumnName("LoadID");

                entity.Property(e => e.ProductType).HasMaxLength(255);

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SellAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SellCurrency)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.SettlementDate).HasColumnType("date");

                entity.Property(e => e.SourceSystemTradeId)
                    .HasColumnName("SourceSystemTradeID")
                    .HasMaxLength(255);

                entity.Property(e => e.TradeDate).HasColumnType("date");

                entity.Property(e => e.TradeId).HasColumnName("TradeID");

                entity.HasOne(d => d.CounterParty)
                    .WithMany(p => p.TradeConfirmationFx)
                    .HasForeignKey(d => d.CounterPartyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TradeConfirmationFX_CounterParty");

                entity.HasOne(d => d.Trade)
                    .WithMany(p => p.TradeConfirmationFx)
                    .HasForeignKey(d => d.TradeId)
                    .HasConstraintName("FK_TradeConfirmationFX_Trade");
            });

            modelBuilder.Entity<TradeGroup>(entity =>
            {
                entity.Property(e => e.TradeGroupId).HasColumnName("TradeGroupID");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.TradeRelationshipTypeId).HasColumnName("TradeRelationshipTypeID");

                entity.HasOne(d => d.TradeRelationshipType)
                    .WithMany(p => p.TradeGroup)
                    .HasForeignKey(d => d.TradeRelationshipTypeId)
                    .HasConstraintName("FK_TradeGroup_TradeRelationshipType");
            });

            modelBuilder.Entity<TradeHistory>(entity =>
            {
                entity.Property(e => e.TradeHistoryId).HasColumnName("TradeHistoryID");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.TradeId).HasColumnName("TradeID");

                entity.Property(e => e.TradeStatusId).HasColumnName("TradeStatusID");

                entity.Property(e => e.WhenCreated).HasColumnType("datetime");

                entity.Property(e => e.WhoChanged)
                    .IsRequired()
                    .HasColumnType("nvarchar(1000)");

                entity.HasOne(d => d.Trade)
                    .WithMany(p => p.TradeHistory)
                    .HasForeignKey(d => d.TradeId)
                    .HasConstraintName("FK_TradeHistory_Trade");

                entity.HasOne(d => d.TradeStatus)
                    .WithMany(p => p.TradeHistory)
                    .HasForeignKey(d => d.TradeStatusId)
                    .HasConstraintName("FK_TradeHistory_TradeStatus");
            });

            modelBuilder.Entity<TradeRelationshipType>(entity =>
            {
                entity.Property(e => e.TradeRelationshipTypeId).HasColumnName("TradeRelationshipTypeID");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.TradeRelationshipDesc).HasMaxLength(255);
            });

            modelBuilder.Entity<TradeStatus>(entity =>
            {
                entity.Property(e => e.TradeStatusId).HasColumnName("TradeStatusID");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusCode)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.HasIndex(e => e.BatchId)
                    .HasName("idxTransaction_BatchID");

                entity.HasIndex(e => e.Inactive)
                    .HasName("idxTransaction_Inactive");

                entity.HasIndex(e => e.PortfolioId)
                    .HasName("idxTransaction_PortfolioId");

                entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.InstrumentId).HasColumnName("InstrumentID");

                entity.Property(e => e.JpmtransactionId).HasColumnName("JPMTransactionID");

                entity.Property(e => e.NtoriginalTransactionId)
                    .HasColumnName("NTOriginalTransactionID")
                    .HasMaxLength(20);

                entity.Property(e => e.PortfolioId).HasColumnName("PortfolioID");

                entity.Property(e => e.TradeDate).HasColumnType("date");

                entity.Property(e => e.TransactionTypeId).HasColumnName("TransactionTypeID");

                entity.HasOne(d => d.TransactionType)
                    .WithMany(p => p.Transaction)
                    .HasForeignKey(d => d.TransactionTypeId)
                    .HasConstraintName("TransactionType_Transaction_FK1");

                entity.HasOne(d => d.InstrumentPortfolio)
                    .WithMany(p => p.Transaction)
                    .HasForeignKey(d => new { d.InstrumentId, d.PortfolioId })
                    .HasConstraintName("InstrumentPortfolio_Transaction_FK1");
            });

            modelBuilder.Entity<TransactionHistory>(entity =>
            {
                entity.HasIndex(e => e.Inactive)
                    .HasName("idxTransactionHistory_Inactive");

                entity.HasIndex(e => e.PortfolioId)
                    .HasName("idxTransactionHistory_PortfolioId");

                entity.Property(e => e.TransactionHistoryId).HasColumnName("TransactionHistoryID");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.InstrumentId).HasColumnName("InstrumentID");

                entity.Property(e => e.JpmtransactionId).HasColumnName("JPMTransactionID");

                entity.Property(e => e.NtoriginalTransactionId)
                    .HasColumnName("NTOriginalTransactionID")
                    .HasMaxLength(20);

                entity.Property(e => e.PortfolioId).HasColumnName("PortfolioID");

                entity.Property(e => e.TradeDate).HasColumnType("date");

                entity.Property(e => e.TransactionTypeId).HasColumnName("TransactionTypeID");

                entity.HasOne(d => d.TransactionType)
                    .WithMany(p => p.TransactionHistory)
                    .HasForeignKey(d => d.TransactionTypeId)
                    .HasConstraintName("TransactionType_TransactionHistory_FK1");

                entity.HasOne(d => d.InstrumentPortfolio)
                    .WithMany(p => p.TransactionHistory)
                    .HasForeignKey(d => new { d.InstrumentId, d.PortfolioId })
                    .HasConstraintName("InstrumentPortfolio_TransactionHistory_FK1");
            });

            modelBuilder.Entity<TransactionLeg>(entity =>
            {
                entity.HasIndex(e => e.Inactive)
                    .HasName("idxTransactionLeg_Inactive");

                entity.HasIndex(e => e.TradeDate)
                    .HasName("idxTransactionLeg_TradeDate");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("idxTransactionLeg_TransactionId");

                entity.Property(e => e.TransactionLegId).HasColumnName("TransactionLegID");

                entity.Property(e => e.AccountingDate).HasColumnType("date");

                entity.Property(e => e.AccruedInterestBase).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ActualSettlementDate).HasColumnType("date");

                entity.Property(e => e.BankAccountType).HasMaxLength(255);

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.BrokerCommBase).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BrokerId).HasMaxLength(255);

                entity.Property(e => e.BrokerName).HasColumnType("nvarchar(1000)");

                entity.Property(e => e.BuyCurrency).HasMaxLength(255);

                entity.Property(e => e.BuyNominal).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ClearingBrokerId).HasMaxLength(20);

                entity.Property(e => e.ClearingBrokerName).HasMaxLength(100);

                entity.Property(e => e.ContractedForwardRate).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CreditRatingMoodys).HasMaxLength(20);

                entity.Property(e => e.CreditRatingSandP).HasMaxLength(20);

                entity.Property(e => e.DividendInterestRate).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.EntryDateTime).HasColumnType("datetime");

                entity.Property(e => e.ExDividendDate).HasColumnType("date");

                entity.Property(e => e.ExchLclToPfMorDflag)
                    .HasColumnName("ExchLclToPfMorDFlag")
                    .HasMaxLength(1);

                entity.Property(e => e.ExchPfToUsdmorDflag)
                    .HasColumnName("ExchPfToUSDMorDFlag")
                    .HasMaxLength(1);

                entity.Property(e => e.ExchangeGainLoass).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ExchangeRateForward).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ExchangeRateLocalToPortfolio).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ExchangeRatePortfolioToUsd)
                    .HasColumnName("ExchangeRatePortfolioToUSD")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ExchangeRateSpot).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ExternalReferenceCode).HasMaxLength(255);

                entity.Property(e => e.FfxgainLoss)
                    .HasColumnName("FFXGainLoss")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.FileDate).HasColumnType("date");

                entity.Property(e => e.FileRunDateTime).HasColumnType("datetime");

                entity.Property(e => e.ForwardCurrencyCode).HasMaxLength(3);

                entity.Property(e => e.ForwardPoints).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.FxtransactionId)
                    .HasColumnName("FXTransactionID")
                    .HasMaxLength(255);

                entity.Property(e => e.GrossAmountBase).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.GrossAmountLocal).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Gstexpense).HasColumnName("GSTExpense");

                entity.Property(e => e.Gstreclaim).HasColumnName("GSTReclaim");

                entity.Property(e => e.HiportTransactionSubTypeCode).HasColumnType("nvarchar(1000)");

                entity.Property(e => e.HiportTransactionTypeCode).HasColumnType("nvarchar(1000)");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.IncomeBase).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.InstrumentId).HasColumnName("InstrumentID");

                entity.Property(e => e.IsReversalFlag).HasMaxLength(20);

                entity.Property(e => e.JpmtransactionId).HasColumnName("JPMTransactionId");

                entity.Property(e => e.LoadId).HasColumnName("LoadID");

                entity.Property(e => e.NtassetCategoryCode)
                    .HasColumnName("NTAssetCategoryCode")
                    .HasMaxLength(20);

                entity.Property(e => e.NtassetCategorySubCode)
                    .HasColumnName("NTAssetCategorySubCode")
                    .HasMaxLength(100);

                entity.Property(e => e.NtassetId1)
                    .HasColumnName("NTAssetID1")
                    .HasMaxLength(20);

                entity.Property(e => e.NtassetId2)
                    .HasColumnName("NTAssetID2")
                    .HasMaxLength(20);

                entity.Property(e => e.NtassetId2type)
                    .HasColumnName("NTAssetID2Type")
                    .HasMaxLength(20);

                entity.Property(e => e.NtassetSubCategoryName)
                    .HasColumnName("NTAssetSubCategoryName")
                    .HasMaxLength(200);

                entity.Property(e => e.NtassetSuperCategoryName)
                    .HasColumnName("NTAssetSuperCategoryName")
                    .HasMaxLength(200);

                entity.Property(e => e.NtassetTicker1)
                    .HasColumnName("NTAssetTicker1")
                    .HasMaxLength(20);

                entity.Property(e => e.NtassetTicker2)
                    .HasColumnName("NTAssetTicker2")
                    .HasMaxLength(20);

                entity.Property(e => e.NtdataSource)
                    .HasColumnName("NTDataSource")
                    .HasMaxLength(20);

                entity.Property(e => e.NtdepartmentCode)
                    .HasColumnName("NTDepartmentCode")
                    .HasMaxLength(20);

                entity.Property(e => e.NtdepotCode)
                    .HasColumnName("NTDepotCode")
                    .HasMaxLength(100);

                entity.Property(e => e.NteconomicSectorCode)
                    .HasColumnName("NTEconomicSectorCode")
                    .HasMaxLength(100);

                entity.Property(e => e.NtfileFromDate)
                    .HasColumnName("NTFileFromDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.NtfileType)
                    .HasColumnName("NTFileType")
                    .HasMaxLength(20);

                entity.Property(e => e.NtindustryName)
                    .HasColumnName("NTIndustryName")
                    .HasMaxLength(100);

                entity.Property(e => e.NtindustrySectorName)
                    .HasColumnName("NTIndustrySectorName")
                    .HasMaxLength(50);

                entity.Property(e => e.NtinternalReference)
                    .HasColumnName("NTInternalReference")
                    .HasMaxLength(20);

                entity.Property(e => e.NtoriginalTransactionId)
                    .HasColumnName("NTOriginalTransactionId")
                    .HasMaxLength(20);

                entity.Property(e => e.NtrecordDate)
                    .HasColumnName("NTRecordDate")
                    .HasMaxLength(20);

                entity.Property(e => e.NtrecordFrom)
                    .HasColumnName("NTRecordFrom")
                    .HasColumnType("datetime");

                entity.Property(e => e.NtrecordUpdated)
                    .HasColumnName("NTRecordUpdated")
                    .HasColumnType("datetime");

                entity.Property(e => e.NtreportType)
                    .HasColumnName("NTReportType")
                    .HasMaxLength(20);

                entity.Property(e => e.NtrunDate)
                    .HasColumnName("NTRunDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.NtrunTime)
                    .HasColumnName("NTRunTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.NtsectorCode)
                    .HasColumnName("NTSectorCode")
                    .HasMaxLength(20);

                entity.Property(e => e.NtsubCategoryCode)
                    .HasColumnName("NTSubCategoryCode")
                    .HasMaxLength(20);

                entity.Property(e => e.NtsuperCategoryCode)
                    .HasColumnName("NTSuperCategoryCode")
                    .HasMaxLength(20);

                entity.Property(e => e.NttaxCode)
                    .HasColumnName("NTTaxCode")
                    .HasMaxLength(20);

                entity.Property(e => e.NttransactionCategoryCode1)
                    .HasColumnName("NTTransactionCategoryCode1")
                    .HasMaxLength(20);

                entity.Property(e => e.NttransactionCategoryCode2)
                    .HasColumnName("NTTransactionCategoryCode2")
                    .HasMaxLength(20);

                entity.Property(e => e.NttransactionCodeGroup)
                    .HasColumnName("NTTransactionCodeGroup")
                    .HasMaxLength(20);

                entity.Property(e => e.NttransactionId)
                    .HasColumnName("NTTransactionId")
                    .HasMaxLength(20);

                entity.Property(e => e.NttransactionStatus)
                    .HasColumnName("NTTransactionStatus")
                    .HasMaxLength(20);

                entity.Property(e => e.OtherChargeBase).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.OtherTradeCharges).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PortfolioCurrencyCode).HasMaxLength(20);

                entity.Property(e => e.PriceLocal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PrincipalIncomeSplit).HasMaxLength(20);

                entity.Property(e => e.ProfitLoss).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.RealisedGainLossBase).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.RealisedGainLossLocal).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.RelatedSecuritySedol).HasMaxLength(255);

                entity.Property(e => e.SellCurrency).HasMaxLength(255);

                entity.Property(e => e.SellNominal).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SettlementBase).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SettlementCurrencyCode).HasMaxLength(3);

                entity.Property(e => e.SettlementDate).HasColumnType("date");

                entity.Property(e => e.SpotForwardIndicator).HasMaxLength(255);

                entity.Property(e => e.StagingRowId).HasColumnName("StagingRowID");

                entity.Property(e => e.TradeDate).HasColumnType("date");

                entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

                entity.Property(e => e.TransactionSubTypeCode).HasColumnType("nvarchar(1000)");

                entity.Property(e => e.TransactionTypeCode).HasColumnType("nvarchar(1000)");

                entity.HasOne(d => d.Instrument)
                    .WithMany(p => p.TransactionLeg)
                    .HasForeignKey(d => d.InstrumentId)
                    .HasConstraintName("FK_TransactionLeg_Instrument");

                entity.HasOne(d => d.Transaction)
                    .WithMany(p => p.TransactionLeg)
                    .HasForeignKey(d => d.TransactionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Transaction_TransactionLeg_FK1");
            });

            modelBuilder.Entity<TransactionLegHistory>(entity =>
            {
                entity.HasIndex(e => e.Inactive)
                    .HasName("idxTransactionLegHistory_Inactive");

                entity.HasIndex(e => e.TradeDate)
                    .HasName("idxTransactionLegHistory_TradeDate");

                entity.HasIndex(e => e.TransactionHistoryId)
                    .HasName("idxTransactionLegHistory_TransactionId");

                entity.Property(e => e.TransactionLegHistoryId).HasColumnName("TransactionLegHistoryID");

                entity.Property(e => e.AccountingDate).HasColumnType("date");

                entity.Property(e => e.AccruedInterestBase).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ActualSettlementDate).HasColumnType("date");

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.BrokerCommBase).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BrokerId).HasMaxLength(255);

                entity.Property(e => e.BrokerName).HasColumnType("nvarchar(1000)");

                entity.Property(e => e.ClearingBrokerId).HasMaxLength(20);

                entity.Property(e => e.ClearingBrokerName).HasMaxLength(100);

                entity.Property(e => e.CreditRatingMoodys).HasMaxLength(20);

                entity.Property(e => e.CreditRatingSandP).HasMaxLength(20);

                entity.Property(e => e.DividendInterestRate).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.EntryDateTime).HasColumnType("datetime");

                entity.Property(e => e.ExchLclToPfMorDflag)
                    .HasColumnName("ExchLclToPfMorDFlag")
                    .HasMaxLength(1);

                entity.Property(e => e.ExchPfToUsdmorDflag)
                    .HasColumnName("ExchPfToUSDMorDFlag")
                    .HasMaxLength(1);

                entity.Property(e => e.ExchangeGainLoass).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ExchangeRateForward).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ExchangeRateLocalToPortfolio).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ExchangeRatePortfolioToUsd)
                    .HasColumnName("ExchangeRatePortfolioToUSD")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ExchangeRateSpot).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ExternalReferenceCode).HasMaxLength(255);

                entity.Property(e => e.FileDate).HasColumnType("date");

                entity.Property(e => e.FileRunDateTime).HasColumnType("datetime");

                entity.Property(e => e.ForwardCurrencyCode).HasMaxLength(3);

                entity.Property(e => e.ForwardPoints).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.GrossAmountBase).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.GrossAmountLocal).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Gstexpense).HasColumnName("GSTExpense");

                entity.Property(e => e.Gstreclaim).HasColumnName("GSTReclaim");

                entity.Property(e => e.HiportTransactionSubTypeCode).HasColumnType("nvarchar(1000)");

                entity.Property(e => e.HiportTransactionTypeCode).HasColumnType("nvarchar(1000)");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsReversalFlag).HasMaxLength(20);

                entity.Property(e => e.JpmtransactionId).HasColumnName("JPMTransactionId");

                entity.Property(e => e.LoadId).HasColumnName("LoadID");

                entity.Property(e => e.NtassetCategoryCode)
                    .HasColumnName("NTAssetCategoryCode")
                    .HasMaxLength(20);

                entity.Property(e => e.NtassetCategorySubCode)
                    .HasColumnName("NTAssetCategorySubCode")
                    .HasMaxLength(100);

                entity.Property(e => e.NtassetId1)
                    .HasColumnName("NTAssetID1")
                    .HasMaxLength(20);

                entity.Property(e => e.NtassetId2)
                    .HasColumnName("NTAssetID2")
                    .HasMaxLength(20);

                entity.Property(e => e.NtassetId2type)
                    .HasColumnName("NTAssetID2Type")
                    .HasMaxLength(20);

                entity.Property(e => e.NtassetSubCategoryName)
                    .HasColumnName("NTAssetSubCategoryName")
                    .HasMaxLength(200);

                entity.Property(e => e.NtassetSuperCategoryName)
                    .HasColumnName("NTAssetSuperCategoryName")
                    .HasMaxLength(200);

                entity.Property(e => e.NtassetTicker1)
                    .HasColumnName("NTAssetTicker1")
                    .HasMaxLength(20);

                entity.Property(e => e.NtassetTicker2)
                    .HasColumnName("NTAssetTicker2")
                    .HasMaxLength(20);

                entity.Property(e => e.NtdataSource)
                    .HasColumnName("NTDataSource")
                    .HasMaxLength(20);

                entity.Property(e => e.NtdepartmentCode)
                    .HasColumnName("NTDepartmentCode")
                    .HasMaxLength(20);

                entity.Property(e => e.NtdepotCode)
                    .HasColumnName("NTDepotCode")
                    .HasMaxLength(100);

                entity.Property(e => e.NteconomicSectorCode)
                    .HasColumnName("NTEconomicSectorCode")
                    .HasMaxLength(100);

                entity.Property(e => e.NtfileFromDate)
                    .HasColumnName("NTFileFromDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.NtfileType)
                    .HasColumnName("NTFileType")
                    .HasMaxLength(20);

                entity.Property(e => e.NtindustryName)
                    .HasColumnName("NTIndustryName")
                    .HasMaxLength(100);

                entity.Property(e => e.NtindustrySectorName)
                    .HasColumnName("NTIndustrySectorName")
                    .HasMaxLength(50);

                entity.Property(e => e.NtinternalReference)
                    .HasColumnName("NTInternalReference")
                    .HasMaxLength(20);

                entity.Property(e => e.NtoriginalTransactionId)
                    .HasColumnName("NTOriginalTransactionId")
                    .HasMaxLength(20);

                entity.Property(e => e.NtrecordDate)
                    .HasColumnName("NTRecordDate")
                    .HasMaxLength(20);

                entity.Property(e => e.NtrecordFrom)
                    .HasColumnName("NTRecordFrom")
                    .HasColumnType("datetime");

                entity.Property(e => e.NtrecordUpdated)
                    .HasColumnName("NTRecordUpdated")
                    .HasColumnType("datetime");

                entity.Property(e => e.NtreportType)
                    .HasColumnName("NTReportType")
                    .HasMaxLength(20);

                entity.Property(e => e.NtrunDate)
                    .HasColumnName("NTRunDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.NtrunTime)
                    .HasColumnName("NTRunTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.NtsectorCode)
                    .HasColumnName("NTSectorCode")
                    .HasMaxLength(20);

                entity.Property(e => e.NtsubCategoryCode)
                    .HasColumnName("NTSubCategoryCode")
                    .HasMaxLength(20);

                entity.Property(e => e.NtsuperCategoryCode)
                    .HasColumnName("NTSuperCategoryCode")
                    .HasMaxLength(20);

                entity.Property(e => e.NttaxCode)
                    .HasColumnName("NTTaxCode")
                    .HasMaxLength(20);

                entity.Property(e => e.NttransactionCategoryCode1)
                    .HasColumnName("NTTransactionCategoryCode1")
                    .HasMaxLength(20);

                entity.Property(e => e.NttransactionCategoryCode2)
                    .HasColumnName("NTTransactionCategoryCode2")
                    .HasMaxLength(20);

                entity.Property(e => e.NttransactionCodeGroup)
                    .HasColumnName("NTTransactionCodeGroup")
                    .HasMaxLength(20);

                entity.Property(e => e.NttransactionId)
                    .HasColumnName("NTTransactionId")
                    .HasMaxLength(20);

                entity.Property(e => e.NttransactionStatus)
                    .HasColumnName("NTTransactionStatus")
                    .HasMaxLength(20);

                entity.Property(e => e.OtherChargeBase).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.OtherTradeCharges).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PortfolioCurrencyCode).HasMaxLength(20);

                entity.Property(e => e.PrincipalIncomeSplit).HasMaxLength(20);

                entity.Property(e => e.RealisedGainLossBase).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.RealisedGainLossLocal).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.RelatedSecuritySedol).HasMaxLength(255);

                entity.Property(e => e.SettlementCurrencyCode).HasMaxLength(3);

                entity.Property(e => e.SettlementDate).HasColumnType("date");

                entity.Property(e => e.StagingRowId).HasColumnName("StagingRowID");

                entity.Property(e => e.TradeDate).HasColumnType("date");

                entity.Property(e => e.TransactionHistoryId).HasColumnName("TransactionHistoryID");

                entity.Property(e => e.TransactionSubTypeCode).HasColumnType("nvarchar(1000)");

                entity.Property(e => e.TransactionTypeCode).HasColumnType("nvarchar(1000)");

                entity.HasOne(d => d.TransactionHistory)
                    .WithMany(p => p.TransactionLegHistory)
                    .HasForeignKey(d => d.TransactionHistoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TransactionHistory_TransactionLegHistory_FK1");
            });

            modelBuilder.Entity<TransactionType>(entity =>
            {
                entity.Property(e => e.TransactionTypeId).HasColumnName("TransactionTypeID");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.TransactionTypeCode).HasMaxLength(255);

                entity.Property(e => e.TransactionTypeDesc).HasMaxLength(255);
            });

            modelBuilder.Entity<TypeSettlementPlace>(entity =>
            {
                entity.HasKey(e => e.Tspid);

                entity.Property(e => e.Tspid).HasColumnName("TSPId");

                entity.Property(e => e.InstrumentTypeId).HasColumnName("InstrumentTypeID");

                entity.Property(e => e.Psetid).HasColumnName("PSETId");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.TypeSettlementPlace)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TypeSettlementPlace_Country");

                entity.HasOne(d => d.InstrumentType)
                    .WithMany(p => p.TypeSettlementPlace)
                    .HasForeignKey(d => d.InstrumentTypeId)
                    .HasConstraintName("FK_TypeSettlementPlace_InsType");

                entity.HasOne(d => d.Pset)
                    .WithMany(p => p.TypeSettlementPlace)
                    .HasForeignKey(d => d.Psetid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TypeSettlementPlace_PSET");
            });

            modelBuilder.HasSequence("seqReportJpmStockLending_UniqueRecordNumber").StartsAt(6200);

            modelBuilder.HasSequence("swap_seq").StartsAt(40469);

            modelBuilder.HasSequence("trade_seq").StartsAt(7360);
        }
    }
}
