using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAISY_API.Models
{
    
    // This is THE CLASS for passing the Data THROUGH the API to the SP
    // Should consist of all the fields that the SP needs.
    public class DaisyCaseNew
    {
        
        public string Counsellor { get; set; }
        ////  [Required, Display(Name = "Time of Day")]
        public string DLCallTimeOfDay { get; set; }
        //  //  [Required, Display(Name = "Helpline")]
        public string HelpLine { get; set; }
        //  [Required, Display(Name = "Called For")]
        public string CalledFor { get; set; }
        //  [Required, Display(Name = "Called Date")]
        public string CallDate { get; set; }

        //  [Required, Display(Name = "First Name")]
        public string Name { get; set; }
        //  [Required, Display(Name = "Surname")]
        public string Surname { get; set; }

        //  [Required, Display(Name = "Age Group")]
        public string Age { get; set; }
        //  [Required, Display(Name = "Gender")]
        public string Sex { get; set; }
        //  [Required, Display(Name = "Race")]
        public string Race { get; set; }
        //  [Required, Display(Name = "Occupation")]
        public string Occupation { get; set; }
        //  [Required, Display(Name = "Medical Aid")]
        public string MedicalAid { get; set; }
        //  [Required, Display(Name = "Medication")]
        public string Medication { get; set; }
        //  [Required, Display(Name = "Street / Box")]
        public string Address { get; set; }
        //  [Required, Display(Name = "Suburb")]
        public string Suburb { get; set; }
        //  [Required, Display(Name = "City")]
        public string City { get; set; }
        //  [Required, Display(Name = "Province")]
        public string Province { get; set; }
        //  [Required, Display(Name = "Postal Code")]
        public string PostalCode { get; set; }
        //  [Required, Display(Name = "Telephone 1")]
        public string Telephone1 { get; set; }
        //  [Required, Display(Name = "Telephone 2")]
        public string Telephone2 { get; set; }
        //  [Required, Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        //  [Required, Display(Name = "Academic Stress")]
        public Boolean ReasonAcademicStress { get; set; }
        //  [Required, Display(Name = "ADHD")]
        public Boolean ReasonADHD { get; set; }
        public Boolean ReasonAlzheimersDementia { get; set; }
        public Boolean ReasonAnxiety { get; set; }
        public Boolean ReasonBipolar { get; set; }
        public Boolean ReasonBorderlinePersonalityDisorder { get; set; }
        public Boolean ReasonBullying { get; set; }
        public Boolean ReasonDebtPovertyUnemployment { get; set; }
        public Boolean ReasonDepression { get; set; }
        public Boolean ReasonEatingDisoirder { get; set; }
        public Boolean ReasonHIVAIDS { get; set; }
        public Boolean ReasonInformation { get; set; }
        public Boolean ReasonLossGriefLoneliness { get; set; }
        public Boolean ReasonNone { get; set; }
        public Boolean ReasonOCD { get; set; }
        public Boolean ReasonOtherIllness { get; set; }
        public Boolean ReasonPhysicalEmotionalAbuse { get; set; }
        public Boolean ReasonPostNatalDepression { get; set; }
        public Boolean ReasonPregnancy { get; set; }
        public Boolean ReasonPTSDTrauma { get; set; }
        public Boolean ReasonReationshipDomesticAbuse { get; set; }
        public Boolean ReasonRelationshipFamilyIssues { get; set; }
        public Boolean ReasonRelationshipRomanticIssues { get; set; }
        public Boolean ReasonSchizophrenia { get; set; }
        public Boolean ReasonSelfMutilation { get; set; }
        public Boolean ReasonSexualAbuseRape { get; set; }
        public Boolean ReasonSleepingDisorder { get; set; }
        public Boolean ReasonSocialPhobia { get; set; }
        public Boolean ReasonStress { get; set; }
        public Boolean ReasonSubstanceAbuse { get; set; }
        public Boolean ReasonSuicide { get; set; }
        public Boolean ReasonFrequentCaller { get; set; }

        public Boolean ReferDASGFaceToFace { get; set; }
        public Boolean ReferCompanyEAP { get; set; }
        public Boolean ReferGP { get; set; }
        public Boolean ReferGovHospital { get; set; }
        public Boolean ReferLiteratureWebsite { get; set; }
        public Boolean ReferNone { get; set; }
        public Boolean ReferOther { get; set; }
        public Boolean ReferOtherNGOHelpline { get; set; }
        public Boolean ReferPoliceStation { get; set; }
        public Boolean ReferPrivateHospital { get; set; }
        public Boolean ReferPsychiatrist { get; set; }
        public Boolean ReferPsychologist { get; set; }

        public Boolean ReferRapeCrisis { get; set; }
        public Boolean ReferRehabilitationCentre { get; set; }
        public Boolean ReferShelter { get; set; }
        public Boolean ReferSocialWorker { get; set; }
        public Boolean ReferSupportGroup { get; set; }
        public Boolean ReferTraumaCentre { get; set; }
        public Boolean ReferUniversitySupportServices { get; set; }

        //  [Required, Range(1, 5), Display(Name = "Distress Rating Start of Call")]
        public int DistressRatingBegining { get; set; }
        //  [Required, Range(1, 5), Display(Name = "Distress Rating End of Call")]
        public int DistressRatingEnd { get; set; }

        //  [Required, MinLength(100), MaxLength(8000), Display(Name = "Call Summary")]
        public string CallSummary { get; set; }

        //  [Required, MinLength(100), MaxLength(8000), Display(Name = "Action Points")]
        public string ActionPoints { get; set; }



    }
}