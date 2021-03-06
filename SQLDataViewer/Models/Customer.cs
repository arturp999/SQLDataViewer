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
    using System.Collections.Generic;
    
    public partial class Customer
    {
        public string CustomerNbr { get; set; }
        public Nullable<int> NumberOfChildren { get; set; }
        public Nullable<int> NumberOfDependents { get; set; }
        public string HouseTypeCode { get; set; }
        public string HouseDate { get; set; }
        public string AddressPostalCode { get; set; }
        public string AddressLocality { get; set; }
        public string Address { get; set; }
        public string AddressDoor { get; set; }
        public string AddressFloor { get; set; }
        public string AddressSide { get; set; }
        public Nullable<bool> HasSameTaxAddress { get; set; }
        public string TaxAddressPostalCode { get; set; }
        public string TaxAddressLocality { get; set; }
        public string TaxAddress { get; set; }
        public string TaxAddressDoor { get; set; }
        public string TaxAddressFloor { get; set; }
        public string TaxAddressSide { get; set; }
        public string FixedLinePhoneNbr { get; set; }
        public string MobilePhoneNbr { get; set; }
        public string Email { get; set; }
        public string PhoneOwnershipCode { get; set; }
        public string IncomeLevelCode { get; set; }
        public string Income { get; set; }
        public string OtherIncome { get; set; }
        public string Pension { get; set; }
        public string HouseRentExpenses { get; set; }
        public string CarExpenses { get; set; }
        public string OtherExpenses { get; set; }
        public string ProfessionCode { get; set; }
        public string CompanyName { get; set; }
        public string ContractTypeCode { get; set; }
        public string ContractDate { get; set; }
        public Nullable<bool> HasWorkPhone { get; set; }
        public string WorkPhoneNbr { get; set; }
        public Nullable<bool> HasPoliticalRole { get; set; }
        public string PoliticalRoleStartDate { get; set; }
        public string PoliticalRoleEndDate { get; set; }
        public string PoliticalRoleLocation { get; set; }
        public string PoliticalRoleCode { get; set; }
        public Nullable<bool> HasPoliticalFamilyMember { get; set; }
        public string PoliticalRelationshipGradeCode { get; set; }
        public Nullable<bool> BankCardDataAutoCollected { get; set; }
        public string MaritalStatusCode { get; set; }
        public string IssueEntityCode { get; set; }
        public string NationalityCode { get; set; }
        public string CountryOfBirthCode { get; set; }
        public string NaturalityLocality { get; set; }
        public string OtherNationalityCode { get; set; }
        public string Gender { get; set; }
        public string IdNumber { get; set; }
        public Nullable<System.DateTime> IdDocExpiryDate { get; set; }
        public string EmbossedName { get; set; }
        public string FullName { get; set; }
    
        public  ContractType ContractType { get; set; }
        public  CountryOfBirth CountryOfBirth { get; set; }
        public  HouseType HouseType { get; set; }
        public  IncomeLevel IncomeLevel { get; set; }
        public  IssueEntity IssueEntity { get; set; }
        public  MaritalStatu MaritalStatu { get; set; }
        public  Nationality Nationality { get; set; }
        public  Nationality Nationality1 { get; set; }
        public  PhoneOwnership PhoneOwnership { get; set; }
        public  PoliticalRelationshipGrade PoliticalRelationshipGrade { get; set; }
        public  PoliticalRole PoliticalRole { get; set; }
        public  Profession Profession { get; set; }
    }
}
