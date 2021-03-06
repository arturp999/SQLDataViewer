//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace portalSQL.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PCERuntimeEntities : DbContext
    {
        public PCERuntimeEntities()
            : base("name=PCERuntimeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AccountOwnership> AccountOwnerships { get; set; }
        public virtual DbSet<Anomaly> Anomalies { get; set; }
        public virtual DbSet<AnomalyTheme> AnomalyThemes { get; set; }
        public virtual DbSet<AnomalyType> AnomalyTypes { get; set; }
        public virtual DbSet<BankCard> BankCards { get; set; }
        public virtual DbSet<BizChannel> BizChannels { get; set; }
        public virtual DbSet<BizProcessType> BizProcessTypes { get; set; }
        public virtual DbSet<CardRequestMotive> CardRequestMotives { get; set; }
        public virtual DbSet<CitizenCard> CitizenCards { get; set; }
        public virtual DbSet<Citizenship> Citizenships { get; set; }
        public virtual DbSet<ComplaintMotive> ComplaintMotives { get; set; }
        public virtual DbSet<ComplaintOrigin> ComplaintOrigins { get; set; }
        public virtual DbSet<ComplaintSubMotive> ComplaintSubMotives { get; set; }
        public virtual DbSet<ContactChannel> ContactChannels { get; set; }
        public virtual DbSet<ContactType> ContactTypes { get; set; }
        public virtual DbSet<ContractBreach> ContractBreaches { get; set; }
        public virtual DbSet<ContractBreachMotive> ContractBreachMotives { get; set; }
        public virtual DbSet<ContractPhysicalStatu> ContractPhysicalStatus { get; set; }
        public virtual DbSet<ContractType> ContractTypes { get; set; }
        public virtual DbSet<CountryOfBirth> CountryOfBirths { get; set; }
        public virtual DbSet<CountryOfBirthTest> CountryOfBirthTests { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerContract> CustomerContracts { get; set; }
        public virtual DbSet<CustomerProfile> CustomerProfiles { get; set; }
        public virtual DbSet<DAProcess> DAProcesses { get; set; }
        public virtual DbSet<DAProcessAnomaly> DAProcessAnomalies { get; set; }
        public virtual DbSet<DAProcessDoc> DAProcessDocs { get; set; }
        public virtual DbSet<DAProcessDocHistory> DAProcessDocHistories { get; set; }
        public virtual DbSet<DAProcessDocStatu> DAProcessDocStatus { get; set; }
        public virtual DbSet<DAProcessHolder> DAProcessHolders { get; set; }
        public virtual DbSet<DAProcessOperation> DAProcessOperations { get; set; }
        public virtual DbSet<DAProcessPhysicalContract> DAProcessPhysicalContracts { get; set; }
        public virtual DbSet<DAProcessSignature> DAProcessSignatures { get; set; }
        public virtual DbSet<DAProcessSignatureStatu> DAProcessSignatureStatus { get; set; }
        public virtual DbSet<DAProcessWorkQueue> DAProcessWorkQueues { get; set; }
        public virtual DbSet<DAProcessWorkQueueHistory> DAProcessWorkQueueHistories { get; set; }
        public virtual DbSet<DeclarationRequest> DeclarationRequests { get; set; }
        public virtual DbSet<DeclarationType> DeclarationTypes { get; set; }
        public virtual DbSet<DeliveryArea> DeliveryAreas { get; set; }
        public virtual DbSet<DigitalRequest> DigitalRequests { get; set; }
        public virtual DbSet<DigitalRequestStatu> DigitalRequestStatus { get; set; }
        public virtual DbSet<DigitalRequestWorkQueue> DigitalRequestWorkQueues { get; set; }
        public virtual DbSet<DocArchiveStatu> DocArchiveStatus { get; set; }
        public virtual DbSet<DocIdentType> DocIdentTypes { get; set; }
        public virtual DbSet<dtproperty> dtproperties { get; set; }
        public virtual DbSet<EAIClientLog> EAIClientLogs { get; set; }
        public virtual DbSet<EmulatorData> EmulatorDatas { get; set; }
        public virtual DbSet<EmulatorRequestField> EmulatorRequestFields { get; set; }
        public virtual DbSet<EmulatorResponseField> EmulatorResponseFields { get; set; }
        public virtual DbSet<EnterpriseUnitGroupUser> EnterpriseUnitGroupUsers { get; set; }
        public virtual DbSet<EnterpriseUnitUser> EnterpriseUnitUsers { get; set; }
        public virtual DbSet<FilterType> FilterTypes { get; set; }
        public virtual DbSet<HolderDetachmentMotive> HolderDetachmentMotives { get; set; }
        public virtual DbSet<HolderRelationshipType> HolderRelationshipTypes { get; set; }
        public virtual DbSet<HouseType> HouseTypes { get; set; }
        public virtual DbSet<IncomeLevel> IncomeLevels { get; set; }
        public virtual DbSet<Insurance> Insurances { get; set; }
        public virtual DbSet<InsuranceProduct> InsuranceProducts { get; set; }
        public virtual DbSet<InsuranceVoid> InsuranceVoids { get; set; }
        public virtual DbSet<InsuranceVoidAction> InsuranceVoidActions { get; set; }
        public virtual DbSet<InsuranceVoidMotive> InsuranceVoidMotives { get; set; }
        public virtual DbSet<IssueEntity> IssueEntities { get; set; }
        public virtual DbSet<ManualProcessType> ManualProcessTypes { get; set; }
        public virtual DbSet<ManualProcessVolumeReg> ManualProcessVolumeRegs { get; set; }
        public virtual DbSet<ManualProcessVolumeRegHistory> ManualProcessVolumeRegHistories { get; set; }
        public virtual DbSet<MapTxnCode> MapTxnCodes { get; set; }
        public virtual DbSet<MaritalStatu> MaritalStatus { get; set; }
        public virtual DbSet<Nationality> Nationalities { get; set; }
        public virtual DbSet<OCRConfig> OCRConfigs { get; set; }
        public virtual DbSet<PaymentMode> PaymentModes { get; set; }
        public virtual DbSet<PhoneOwnership> PhoneOwnerships { get; set; }
        public virtual DbSet<PoliticalRelationshipGrade> PoliticalRelationshipGrades { get; set; }
        public virtual DbSet<PoliticalRole> PoliticalRoles { get; set; }
        public virtual DbSet<PoliticalRoleLocation> PoliticalRoleLocations { get; set; }
        public virtual DbSet<ProcessTemplate> ProcessTemplates { get; set; }
        public virtual DbSet<ProductAnnexTemplate> ProductAnnexTemplates { get; set; }
        public virtual DbSet<Profession> Professions { get; set; }
        public virtual DbSet<ProofDoc> ProofDocs { get; set; }
        public virtual DbSet<ProofType> ProofTypes { get; set; }
        public virtual DbSet<ProofTypeBizProcessType> ProofTypeBizProcessTypes { get; set; }
        public virtual DbSet<ProofTypeDoc> ProofTypeDocs { get; set; }
        public virtual DbSet<Proposal> Proposals { get; set; }
        public virtual DbSet<PurchaseDismissMode> PurchaseDismissModes { get; set; }
        public virtual DbSet<PurchaseMode> PurchaseModes { get; set; }
        public virtual DbSet<RegexFilter> RegexFilters { get; set; }
        public virtual DbSet<RelationGrade> RelationGrades { get; set; }
        public virtual DbSet<SelfCareUser> SelfCareUsers { get; set; }
        public virtual DbSet<SeqNbr> SeqNbrs { get; set; }
        public virtual DbSet<ShippingFormat> ShippingFormats { get; set; }
        public virtual DbSet<ShippingType> ShippingTypes { get; set; }
        public virtual DbSet<SignatureType> SignatureTypes { get; set; }
        public virtual DbSet<SimulationParam> SimulationParams { get; set; }
        public virtual DbSet<SimulationType> SimulationTypes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TransitionType> TransitionTypes { get; set; }
        public virtual DbSet<TxnSchedulingCtrl> TxnSchedulingCtrls { get; set; }
        public virtual DbSet<TxnSeqNbr> TxnSeqNbrs { get; set; }
        public virtual DbSet<UnitGroupDocument> UnitGroupDocuments { get; set; }
        public virtual DbSet<UnitGroupInsurance> UnitGroupInsurances { get; set; }
        public virtual DbSet<UserFilter> UserFilters { get; set; }
        public virtual DbSet<UserStatu> UserStatus { get; set; }
        public virtual DbSet<WorkContractType> WorkContractTypes { get; set; }
        public virtual DbSet<WorkQueue> WorkQueues { get; set; }
        public virtual DbSet<WorkQueueUser> WorkQueueUsers { get; set; }
        public virtual DbSet<RegexFilterGenericRule> RegexFilterGenericRules { get; set; }
        public virtual DbSet<SelfCareStatu> SelfCareStatus { get; set; }
        public virtual DbSet<TxnBranchCtrl> TxnBranchCtrls { get; set; }
        public virtual DbSet<TxnOperation> TxnOperations { get; set; }
        public virtual DbSet<TxnPagingSeqNbr> TxnPagingSeqNbrs { get; set; }
    }
}
