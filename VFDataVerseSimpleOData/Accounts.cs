using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using System.Text.Json.Serialization;
using Edm = Microsoft.OData.Edm;

namespace VictoriFide.ODataDataSources.Microsoft.Dynamics.CRM
{
    // EntitySetName: accounts
    public partial class account : crmbaseentity
    {
        [JsonPropertyName("address2_line1")]
        public virtual string address2Line1 { get; set; }

        [JsonPropertyName("territorycode")]
        public virtual int? territorycode { get; set; }

        [Key]
        [JsonPropertyName("accountid")]
        public virtual Guid? accountid { get; set; } //PrimaryKey

        [JsonPropertyName("address1_telephone1")]
        public virtual string address1Telephone1 { get; set; }

        [JsonPropertyName("address1_postofficebox")]
        public virtual string address1Postofficebox { get; set; }

        [JsonPropertyName("marketcap")]
        public virtual decimal? marketcap { get; set; }

        [JsonPropertyName("emailaddress3")]
        public virtual string emailaddress3 { get; set; }

        [JsonPropertyName("address1_telephone3")]
        public virtual string address1Telephone3 { get; set; }

        [JsonPropertyName("address2_telephone1")]
        public virtual string address2Telephone1 { get; set; }

        [JsonPropertyName("createdon")]
        public virtual DateTimeOffset? createdon { get; } // ReadOnly

        [JsonPropertyName("adx_createdbyusername")]
        public virtual string adxCreatedbyusername { get; set; }

        [JsonPropertyName("numberofemployees")]
        public virtual int? numberofemployees { get; set; }

        [JsonPropertyName("address1_line2")]
        public virtual string address1Line2 { get; set; }

        [JsonPropertyName("_owningbusinessunit_value")]
        public virtual Guid? owningbusinessunitValue { get; } // ReadOnly

        [JsonPropertyName("timespentbymeonemailandmeetings")]
        public virtual string timespentbymeonemailandmeetings { get; } // ReadOnly

        [JsonPropertyName("yominame")]
        public virtual string yominame { get; set; }

        [JsonPropertyName("address2_longitude")]
        public virtual double? address2Longitude { get; set; }

        [JsonPropertyName("ownershipcode")]
        public virtual int? ownershipcode { get; set; }

        [JsonPropertyName("timezoneruleversionnumber")]
        public virtual int? timezoneruleversionnumber { get; set; }

        [JsonPropertyName("adx_modifiedbyipaddress")]
        public virtual string adxModifiedbyipaddress { get; set; }

        [JsonPropertyName("_ownerid_value")]
        public virtual Guid? owneridValue { get; set; }

        [JsonPropertyName("primarysatoriid")]
        public virtual string primarysatoriid { get; set; }

        [JsonPropertyName("overriddencreatedon")]
        public virtual DateTimeOffset? overriddencreatedon { get; set; }

        [JsonPropertyName("_masterid_value")]
        public virtual Guid? masteridValue { get; } // ReadOnly

        [JsonPropertyName("accountnumber")]
        public virtual string accountnumber { get; set; }

        [JsonPropertyName("address2_fax")]
        public virtual string address2Fax { get; set; }

        [JsonPropertyName("address1_country")]
        public virtual string address1Country { get; set; }

        [JsonPropertyName("aging60_base")]
        public virtual decimal? aging60Base { get; } // ReadOnly

        [JsonPropertyName("telephone1")]
        public virtual string telephone1 { get; set; }

        [JsonPropertyName("aging90")]
        public virtual decimal? aging90 { get; } // ReadOnly

        [JsonPropertyName("revenue")]
        public virtual decimal? revenue { get; set; }

        [JsonPropertyName("industrycode")]
        public virtual int? industrycode { get; set; }

        [JsonPropertyName("_msa_managingpartnerid_value")]
        public virtual Guid? msaManagingpartneridValue { get; } // ReadOnly

        [JsonPropertyName("emailaddress1")]
        public virtual string emailaddress1 { get; set; }

        [JsonPropertyName("address1_latitude")]
        public virtual double? address1Latitude { get; set; }

        [JsonPropertyName("tickersymbol")]
        public virtual string tickersymbol { get; set; }

        [JsonPropertyName("address2_shippingmethodcode")]
        public virtual int? address2Shippingmethodcode { get; set; }

        [JsonPropertyName("customersizecode")]
        public virtual int? customersizecode { get; set; }

        [JsonPropertyName("address2_name")]
        public virtual string address2Name { get; set; }

        [JsonPropertyName("address1_line3")]
        public virtual string address1Line3 { get; set; }

        [JsonPropertyName("accountratingcode")]
        public virtual int? accountratingcode { get; set; }

        [JsonPropertyName("address1_line1")]
        public virtual string address1Line1 { get; set; }

        [JsonPropertyName("importsequencenumber")]
        public virtual int? importsequencenumber { get; set; }

        [JsonPropertyName("paymenttermscode")]
        public virtual int? paymenttermscode { get; set; }

        [JsonPropertyName("fax")]
        public virtual string fax { get; set; }

        [JsonPropertyName("traversedpath")]
        public virtual string traversedpath { get; set; }

        [JsonPropertyName("businesstypecode")]
        public virtual int? businesstypecode { get; set; }

        [JsonPropertyName("address2_utcoffset")]
        public virtual int? address2Utcoffset { get; set; }

        [JsonPropertyName("donotphone")]
        public virtual bool? donotphone { get; set; }

        [JsonPropertyName("exchangerate")]
        public virtual decimal? exchangerate { get; } // ReadOnly

        [JsonPropertyName("utcconversiontimezonecode")]
        public virtual int? utcconversiontimezonecode { get; set; }

        [JsonPropertyName("address1_stateorprovince")]
        public virtual string address1Stateorprovince { get; set; }

        [JsonPropertyName("ftpsiteurl")]
        public virtual string ftpsiteurl { get; set; }

        [JsonPropertyName("shippingmethodcode")]
        public virtual int? shippingmethodcode { get; set; }

        [JsonPropertyName("address2_telephone3")]
        public virtual string address2Telephone3 { get; set; }

        [JsonPropertyName("_owningteam_value")]
        public virtual Guid? owningteamValue { get; } // ReadOnly

        [JsonPropertyName("marketingonly")]
        public virtual bool? marketingonly { get; set; }

        [JsonPropertyName("participatesinworkflow")]
        public virtual bool? participatesinworkflow { get; set; }

        [JsonPropertyName("address2_addressid")]
        public virtual Guid? address2Addressid { get; set; }

        [JsonPropertyName("_slaid_value")]
        public virtual Guid? slaidValue { get; } // ReadOnly

        [JsonPropertyName("address2_addresstypecode")]
        public virtual int? address2Addresstypecode { get; set; }

        [JsonPropertyName("processid")]
        public virtual Guid? processid { get; set; }

        [JsonPropertyName("adx_createdbyipaddress")]
        public virtual string adxCreatedbyipaddress { get; set; }

        [JsonPropertyName("aging30")]
        public virtual decimal? aging30 { get; } // ReadOnly

        [JsonPropertyName("entityimage_url")]
        public virtual string entityimageUrl { get; } // ReadOnly

        [JsonPropertyName("sharesoutstanding")]
        public virtual int? sharesoutstanding { get; set; }

        [JsonPropertyName("address2_latitude")]
        public virtual double? address2Latitude { get; set; }

        [JsonPropertyName("_parentaccountid_value")]
        public virtual Guid? parentaccountidValue { get; } // ReadOnly

        [JsonPropertyName("stageid")]
        public virtual Guid? stageid { get; set; }

        [JsonPropertyName("versionnumber")]
        public virtual long? versionnumber { get; } // ReadOnly

        [JsonPropertyName("preferredappointmenttimecode")]
        public virtual int? preferredappointmenttimecode { get; set; }

        [JsonPropertyName("address2_composite")]
        public virtual string address2Composite { get; } // ReadOnly

        [JsonPropertyName("aging90_base")]
        public virtual decimal? aging90Base { get; } // ReadOnly

        [JsonPropertyName("address1_upszone")]
        public virtual string address1Upszone { get; set; }

        [JsonPropertyName("address1_county")]
        public virtual string address1County { get; set; }

        [JsonPropertyName("merged")]
        public virtual bool? merged { get; } // ReadOnly

        [JsonPropertyName("address1_city")]
        public virtual string address1City { get; set; }

        [JsonPropertyName("description")]
        public virtual string description { get; set; }

        [JsonPropertyName("entityimage")]
        public virtual byte[] entityimage { get; set; }

        [JsonPropertyName("donotemail")]
        public virtual bool? donotemail { get; set; }

        [JsonPropertyName("address2_stateorprovince")]
        public virtual string address2Stateorprovince { get; set; }

        [JsonPropertyName("donotfax")]
        public virtual bool? donotfax { get; set; }

        [JsonPropertyName("donotsendmm")]
        public virtual bool? donotsendmm { get; set; }

        [JsonPropertyName("adx_modifiedbyusername")]
        public virtual string adxModifiedbyusername { get; set; }

        [JsonPropertyName("emailaddress2")]
        public virtual string emailaddress2 { get; set; }

        [JsonPropertyName("address1_composite")]
        public virtual string address1Composite { get; } // ReadOnly

        [JsonPropertyName("address1_name")]
        public virtual string address1Name { get; set; }

        [JsonPropertyName("address1_primarycontactname")]
        public virtual string address1Primarycontactname { get; set; }

        [JsonPropertyName("address1_postalcode")]
        public virtual string address1Postalcode { get; set; }

        [JsonPropertyName("onholdtime")]
        public virtual int? onholdtime { get; } // ReadOnly

        [JsonPropertyName("creditonhold")]
        public virtual bool? creditonhold { get; set; }

        [JsonPropertyName("aging60")]
        public virtual decimal? aging60 { get; } // ReadOnly

        [JsonPropertyName("_createdbyexternalparty_value")]
        public virtual Guid? createdbyexternalpartyValue { get; } // ReadOnly

        [JsonPropertyName("statuscode")]
        public virtual int? statuscode { get; set; }

        [JsonPropertyName("_transactioncurrencyid_value")]
        public virtual Guid? transactioncurrencyidValue { get; } // ReadOnly

        [JsonPropertyName("address1_fax")]
        public virtual string address1Fax { get; set; }

        [JsonPropertyName("stockexchange")]
        public virtual string stockexchange { get; set; }

        [JsonPropertyName("_createdonbehalfby_value")]
        public virtual Guid? createdonbehalfbyValue { get; } // ReadOnly

        [JsonPropertyName("_modifiedbyexternalparty_value")]
        public virtual Guid? modifiedbyexternalpartyValue { get; } // ReadOnly

        [JsonPropertyName("address1_longitude")]
        public virtual double? address1Longitude { get; set; }

        [JsonPropertyName("address2_line3")]
        public virtual string address2Line3 { get; set; }

        [JsonPropertyName("donotpostalmail")]
        public virtual bool? donotpostalmail { get; set; }

        [JsonPropertyName("address2_postalcode")]
        public virtual string address2Postalcode { get; set; }

        [JsonPropertyName("_modifiedby_value")]
        public virtual Guid? modifiedbyValue { get; } // ReadOnly

        [JsonPropertyName("address1_shippingmethodcode")]
        public virtual int? address1Shippingmethodcode { get; set; }

        [JsonPropertyName("_createdby_value")]
        public virtual Guid? createdbyValue { get; } // ReadOnly

        [JsonPropertyName("entityimage_timestamp")]
        public virtual long? entityimageTimestamp { get; } // ReadOnly

        [JsonPropertyName("donotbulkemail")]
        public virtual bool? donotbulkemail { get; set; }

        [JsonPropertyName("address2_primarycontactname")]
        public virtual string address2Primarycontactname { get; set; }

        [JsonPropertyName("primarytwitterid")]
        public virtual string primarytwitterid { get; set; }

        [JsonPropertyName("customertypecode")]
        public virtual int? customertypecode { get; set; }

        [JsonPropertyName("sic")]
        public virtual string sic { get; set; }

        [JsonPropertyName("address2_postofficebox")]
        public virtual string address2Postofficebox { get; set; }

        [JsonPropertyName("statecode")]
        public virtual int? statecode { get; set; }

        [JsonPropertyName("address2_city")]
        public virtual string address2City { get; set; }

        [JsonPropertyName("_primarycontactid_value")]
        public virtual Guid? primarycontactidValue { get; } // ReadOnly

        [JsonPropertyName("address1_freighttermscode")]
        public virtual int? address1Freighttermscode { get; set; }

        [JsonPropertyName("revenue_base")]
        public virtual decimal? revenueBase { get; } // ReadOnly

        [JsonPropertyName("address1_addresstypecode")]
        public virtual int? address1Addresstypecode { get; set; }

        [JsonPropertyName("donotbulkpostalmail")]
        public virtual bool? donotbulkpostalmail { get; set; }

        [JsonPropertyName("_preferredsystemuserid_value")]
        public virtual Guid? preferredsystemuseridValue { get; } // ReadOnly

        [JsonPropertyName("accountcategorycode")]
        public virtual int? accountcategorycode { get; set; }

        [JsonPropertyName("creditlimit_base")]
        public virtual decimal? creditlimitBase { get; } // ReadOnly

        [JsonPropertyName("telephone3")]
        public virtual string telephone3 { get; set; }

        [JsonPropertyName("address1_addressid")]
        public virtual Guid? address1Addressid { get; set; }

        [JsonPropertyName("preferredappointmentdaycode")]
        public virtual int? preferredappointmentdaycode { get; set; }

        [JsonPropertyName("websiteurl")]
        public virtual string websiteurl { get; set; }

        [JsonPropertyName("_modifiedonbehalfby_value")]
        public virtual Guid? modifiedonbehalfbyValue { get; } // ReadOnly

        [JsonPropertyName("accountclassificationcode")]
        public virtual int? accountclassificationcode { get; set; }

        [JsonPropertyName("_slainvokedid_value")]
        public virtual Guid? slainvokedidValue { get; } // ReadOnly

        [JsonPropertyName("name")]
        public virtual string name { get; set; }

        [JsonPropertyName("creditlimit")]
        public virtual decimal? creditlimit { get; set; }

        [JsonPropertyName("lastonholdtime")]
        public virtual DateTimeOffset? lastonholdtime { get; set; }

        [JsonPropertyName("telephone2")]
        public virtual string telephone2 { get; set; }

        [JsonPropertyName("address2_line2")]
        public virtual string address2Line2 { get; set; }

        [JsonPropertyName("lastusedincampaign")]
        public virtual DateTimeOffset? lastusedincampaign { get; set; }

        [JsonPropertyName("aging30_base")]
        public virtual decimal? aging30Base { get; } // ReadOnly

        [JsonPropertyName("followemail")]
        public virtual bool? followemail { get; set; }

        [JsonPropertyName("address2_county")]
        public virtual string address2County { get; set; }

        [JsonPropertyName("modifiedon")]
        public virtual DateTimeOffset? modifiedon { get; } // ReadOnly

        [JsonPropertyName("entityimageid")]
        public virtual Guid? entityimageid { get; } // ReadOnly

        [JsonPropertyName("marketcap_base")]
        public virtual decimal? marketcapBase { get; } // ReadOnly

        [JsonPropertyName("address2_upszone")]
        public virtual string address2Upszone { get; set; }

        [JsonPropertyName("address2_country")]
        public virtual string address2Country { get; set; }

        [JsonPropertyName("address1_telephone2")]
        public virtual string address1Telephone2 { get; set; }

        [JsonPropertyName("address2_freighttermscode")]
        public virtual int? address2Freighttermscode { get; set; }

        [JsonPropertyName("address1_utcoffset")]
        public virtual int? address1Utcoffset { get; set; }

        [JsonPropertyName("_owninguser_value")]
        public virtual Guid? owninguserValue { get; } // ReadOnly

        [JsonPropertyName("preferredcontactmethodcode")]
        public virtual int? preferredcontactmethodcode { get; set; }

        [JsonPropertyName("address2_telephone2")]
        public virtual string address2Telephone2 { get; set; }

        [JsonPropertyName("account_principalobjectattributeaccess")]
        public virtual List<principalobjectattributeaccess> accountPrincipalobjectattributeaccess { get; set; }

        [JsonPropertyName("ownerid")]
        public virtual principal ownerid { get; set; }

        [JsonPropertyName("Account_ActivityPointers")]
        public virtual List<activitypointer> accountActivityPointers { get; set; }

        [JsonPropertyName("Account_SyncErrors")]
        public virtual List<syncerror> accountSyncErrors { get; set; }

        [JsonPropertyName("createdby")]
        public virtual systemuser createdby { get; } // ReadOnly

        [JsonPropertyName("Account_Email_SendersAccount")]
        public virtual List<email> accountEmailSendersAccount { get; set; }

        [JsonPropertyName("Account_Email_EmailSender")]
        public virtual List<email> accountEmailEmailSender { get; set; }

        [JsonPropertyName("Account_Annotation")]
        public virtual List<annotation> accountAnnotation { get; set; }

        [JsonPropertyName("Account_SharepointDocumentLocation")]
        public virtual List<sharepointdocumentlocation> accountSharepointDocumentLocation { get; set; }

        [JsonPropertyName("sla_account_sla")]
        public virtual sla slaAccountSla { get; set; }

        [JsonPropertyName("account_connections2")]
        public virtual List<connection> accountConnections2 { get; set; }

        [JsonPropertyName("modifiedby")]
        public virtual systemuser modifiedby { get; } // ReadOnly

        [JsonPropertyName("account_PostFollows")]
        public virtual List<postfollow> accountPostFollows { get; set; }

        [JsonPropertyName("account_PostRegardings")]
        public virtual List<postregarding> accountPostRegardings { get; set; }

        [JsonPropertyName("Account_ProcessSessions")]
        public virtual List<processsession> accountProcessSessions { get; set; }

        [JsonPropertyName("Account_Faxes")]
        public virtual List<fax> accountFaxes { get; set; }

        [JsonPropertyName("masterid")]
        public virtual account masterid { get; } // ReadOnly

        [JsonPropertyName("account_master_account")]
        public virtual List<account> accountMasterAccount { get; set; }

        [JsonPropertyName("owningbusinessunit")]
        public virtual businessunit owningbusinessunit { get; } // ReadOnly

        [JsonPropertyName("Account_AsyncOperations")]
        public virtual List<asyncoperation> accountAsyncOperations { get; set; }

        [JsonPropertyName("transactioncurrencyid")]
        public virtual transactioncurrency transactioncurrencyid { get; set; }

        [JsonPropertyName("Account_DuplicateBaseRecord")]
        public virtual List<duplicaterecord> accountDuplicateBaseRecord { get; set; }

        [JsonPropertyName("preferredsystemuserid")]
        public virtual systemuser preferredsystemuserid { get; set; }

        [JsonPropertyName("createdonbehalfby")]
        public virtual systemuser createdonbehalfby { get; } // ReadOnly

        [JsonPropertyName("Account_RecurringAppointmentMasters")]
        public virtual List<recurringappointmentmaster> accountRecurringAppointmentMasters { get; set; }

        [JsonPropertyName("Account_Phonecalls")]
        public virtual List<phonecall> accountPhonecalls { get; set; }

        [JsonPropertyName("primarycontactid")]
        public virtual contact primarycontactid { get; set; }

        [JsonPropertyName("Account_SocialActivities")]
        public virtual List<socialactivity> accountSocialActivities { get; set; }

        [JsonPropertyName("Account_MailboxTrackingFolder")]
        public virtual List<mailboxtrackingfolder> accountMailboxTrackingFolder { get; set; }

        [JsonPropertyName("SocialActivity_PostAuthorAccount_accounts")]
        public virtual List<socialactivity> socialActivityPostAuthorAccountAccounts { get; set; }

        [JsonPropertyName("Account_CustomerAddress")]
        public virtual List<customeraddress> accountCustomerAddress { get; set; }

        [JsonPropertyName("slakpiinstance_account")]
        public virtual List<slakpiinstance> slakpiinstanceAccount { get; set; }

        [JsonPropertyName("Account_Tasks")]
        public virtual List<task> accountTasks { get; set; }

        [JsonPropertyName("slainvokedid_account_sla")]
        public virtual sla slainvokedidAccountSla { get; } // ReadOnly

        [JsonPropertyName("Account_BulkDeleteFailures")]
        public virtual List<bulkdeletefailure> accountBulkDeleteFailures { get; set; }

        [JsonPropertyName("SocialActivity_PostAuthor_accounts")]
        public virtual List<socialactivity> socialActivityPostAuthorAccounts { get; set; }

        [JsonPropertyName("contact_customer_accounts")]
        public virtual List<contact> contactCustomerAccounts { get; set; }

        [JsonPropertyName("Account_Appointments")]
        public virtual List<appointment> accountAppointments { get; set; }

        [JsonPropertyName("Account_Emails")]
        public virtual List<email> accountEmails { get; set; }

        [JsonPropertyName("parentaccountid")]
        public virtual account parentaccountid { get; set; }

        [JsonPropertyName("account_parent_account")]
        public virtual List<account> accountParentAccount { get; set; }

        [JsonPropertyName("Socialprofile_customer_accounts")]
        public virtual List<socialprofile> socialprofileCustomerAccounts { get; set; }

        [JsonPropertyName("Account_DuplicateMatchingRecord")]
        public virtual List<duplicaterecord> accountDuplicateMatchingRecord { get; set; }

        [JsonPropertyName("account_activity_parties")]
        public virtual List<activityparty> accountActivityParties { get; set; }

        [JsonPropertyName("account_connections1")]
        public virtual List<connection> accountConnections1 { get; set; }

        [JsonPropertyName("owningteam")]
        public virtual team owningteam { get; } // ReadOnly

        [JsonPropertyName("account_actioncard")]
        public virtual List<actioncard> accountActioncard { get; set; }

        [JsonPropertyName("owninguser")]
        public virtual systemuser owninguser { get; } // ReadOnly

        [JsonPropertyName("Account_Letters")]
        public virtual List<letter> accountLetters { get; set; }

        [JsonPropertyName("stageid_processstage")]
        public virtual processstage stageidProcessstage { get; set; }

        [JsonPropertyName("modifiedonbehalfby")]
        public virtual systemuser modifiedonbehalfby { get; } // ReadOnly

        [JsonPropertyName("account_bookableresource_AccountId")]
        public virtual List<bookableresource> accountBookableresourceAccountId { get; set; }

        [JsonPropertyName("account_msdyn_bookingalerts")]
        public virtual List<msdynBookingalert> accountMsdynBookingalerts { get; set; }

        [JsonPropertyName("account_chats")]
        public virtual List<chat> accountChats { get; set; }

        [JsonPropertyName("account_msfp_alerts")]
        public virtual List<msfpAlert> accountMsfpAlerts { get; set; }

        [JsonPropertyName("account_msfp_surveyinvites")]
        public virtual List<msfpSurveyinvite> accountMsfpSurveyinvites { get; set; }

        [JsonPropertyName("account_msfp_surveyresponses")]
        public virtual List<msfpSurveyresponse> accountMsfpSurveyresponses { get; set; }

        [JsonPropertyName("msa_managingpartnerid")]
        public virtual account msaManagingpartnerid { get; set; }

        [JsonPropertyName("msa_account_managingpartner")]
        public virtual List<account> msaAccountManagingpartner { get; set; }

        [JsonPropertyName("msa_contact_managingpartner")]
        public virtual List<contact> msaContactManagingpartner { get; set; }

        [JsonPropertyName("account_adx_inviteredemptions")]
        public virtual List<adxInviteredemption> accountAdxInviteredemptions { get; set; }

        [JsonPropertyName("account_adx_portalcomments")]
        public virtual List<adxPortalcomment> accountAdxPortalcomments { get; set; }

        [JsonPropertyName("adx_invitation_assigntoaccount")]
        public virtual List<adxInvitation> adxInvitationAssigntoaccount { get; set; }

        [JsonPropertyName("powerpagecomponent_mspp_webrole_account")]
        public virtual List<powerpagecomponent> powerpagecomponentMsppWebroleAccount { get; set; }
    }
}
