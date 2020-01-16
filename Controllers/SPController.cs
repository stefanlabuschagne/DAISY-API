using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAISY_API.Models;
using DAISY_API.Models.DataModel;

namespace DAISY_API.Controllers
{

    // This updates the Daisy Database with the Data passed
    // Using a SP
    public class SPController : ApiController
    {

        //// GET: api/Counsellors
        //public IQueryable<Counsellor> GetCounsellors()
        //{
        //    // return db.Counsellors;           
        //}


        public IHttpActionResult AddCase(DaisyCaseNew CreateCaseNew)
        {

            // Calls The SP Here              
            DAISYEntities DE = new DAISYEntities();

            // Theres got to be a better way to do This??
            DE.CreateCaseWrite(
                name: CreateCaseNew.Name.ToString(),
                surname: CreateCaseNew.Surname.ToString(),
                age: CreateCaseNew.Age.ToString(),
                sex: CreateCaseNew.Sex.ToString(),
                race: CreateCaseNew.Race.ToString(),
                occupation: CreateCaseNew.Occupation.ToString(),
                medicalAid: CreateCaseNew.MedicalAid.ToString(),
                medication: CreateCaseNew.Medication.ToString(),
                address: CreateCaseNew.Address.ToString(),
                city: CreateCaseNew.City.ToString(),
                province: CreateCaseNew.Province.ToString(),
                postalCode: CreateCaseNew.PostalCode.ToString(),
                telephone1: CreateCaseNew.Telephone1.ToString(),
                telephone2: CreateCaseNew.Telephone2.ToString(),
                emailAddress: CreateCaseNew.EmailAddress.ToString(),
                suburb: CreateCaseNew.Suburb.ToString(),

                dLLocation: CreateCaseNew.dLLocation.ToString(),   
                dLType: CreateCaseNew.dLType.ToString(),      
                dLSource: CreateCaseNew.dLSource.ToString(),
                dLStudentNumber: CreateCaseNew.dLStudentNumber.ToString(),

                counsellor: CreateCaseNew.Counsellor.ToString(),

                Nullable < System.DateTime > callDate: CreateCaseNew.Name.ToString(),

                 reasonADHD: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),  
                 reasonAlzheimersDementia: CreateCaseNew.Name.ToString(),
                 reasonAnxiety: CreateCaseNew.Name.ToString(),
                 reasonBipolar: CreateCaseNew.Name.ToString(),
                 reasonDebtPovertyUnemployment: CreateCaseNew.Name.ToString(),
                 reasonDepression: CreateCaseNew.Name.ToString(),
                 reasonEatingDisoirder: CreateCaseNew.Name.ToString(),
                 reasonHIVAIDS: CreateCaseNew.Name.ToString(),
                 reasonInformation: CreateCaseNew.Name.ToString(),
                 reasonLossGriefLoneliness: CreateCaseNew.Name.ToString(),
                 reasonNone: CreateCaseNew.Name.ToString(),
                 reasonOCD: CreateCaseNew.Name.ToString(),
                 reasonOtherIllness: CreateCaseNew.Name.ToString(),
                 reasonPhysicalEmotionalAbuse: CreateCaseNew.Name.ToString(),
                 reasonPostNatalDepression: CreateCaseNew.Name.ToString(),
                 reasonPTSDTrauma: CreateCaseNew.Name.ToString(),
                 reasonReationshipDomesticAbuse: CreateCaseNew.Name.ToString(),
                 reasonSchizophrenia: CreateCaseNew.Name.ToString(),
                 reasonSelfMutilation: CreateCaseNew.Name.ToString(),
                 reasonSexualAbuseRape: CreateCaseNew.Name.ToString(),
                 reasonSleepingDisorder: CreateCaseNew.Name.ToString(),
                 reasonSocialPhobia: CreateCaseNew.Name.ToString(),
                 reasonStress: CreateCaseNew.Name.ToString(),
                 reasonSubstanceAbuse: CreateCaseNew.Name.ToString(),
                 reasonSuicide: CreateCaseNew.Name.ToString(),
                 referDASGFaceToFace: CreateCaseNew.Name.ToString(),
                 referGP: CreateCaseNew.Name.ToString(),
                 referGovHospital: CreateCaseNew.Name.ToString(),
                 referLiteratureWebsite: CreateCaseNew.Name.ToString(),
                 referNone: CreateCaseNew.Name.ToString(),
                 referOther: CreateCaseNew.Name.ToString(),
                 referOtherNGOHelpline: CreateCaseNew.Name.ToString(),
                 referPoliceStation: CreateCaseNew.Name.ToString(),
                 referPrivateHospital: CreateCaseNew.Name.ToString(),
                 referPsychiatrist: CreateCaseNew.Name.ToString(),
                 referPsychologist: CreateCaseNew.Name.ToString(),
                 referRapeCrisis: CreateCaseNew.Name.ToString(),
                 referShelter: CreateCaseNew.Name.ToString(),
                 referSocialWorker: CreateCaseNew.Name.ToString(),
                 referSupportGroup: CreateCaseNew.Name.ToString(),
                 referTraumaCentre: CreateCaseNew.Name.ToString(),
                 callSummary: CreateCaseNew.Name.ToString(),
                 reasonFrequentCaller: CreateCaseNew.Name.ToString(),
                 reasonBullying: CreateCaseNew.Name.ToString(),
                 reasonPregnancy: CreateCaseNew.Name.ToString(),
                 reasonSexuality: CreateCaseNew.Name.ToString(),
                 referRehabilitationCentre: CreateCaseNew.Name.ToString(),
                 reasonBorderlinePersonalityDisorder: CreateCaseNew.Name.ToString(),

                 helpLine: CreateCaseNew.HelpLine.ToString(),

                 reasonOtherReason: CreateCaseNew.Name.ToString(),
                 reasonFollowUp: CreateCaseNew.Name.ToString(),
                 referUniversityStudentWellness: CreateCaseNew.Name.ToString(),
                 referSadagHelpLine: CreateCaseNew.Name.ToString(),
                 referSelfHelp: CreateCaseNew.Name.ToString(),
                 referUber: CreateCaseNew.Name.ToString(),

                 dLCallTimeOfDay: CreateCaseNew.Name.ToString(),

                 calledOnBehalfOf: CreateCaseNew.CalledFor.ToString(),
                 actionPoints: CreateCaseNew.ActionPoints.ToString(),

                 reasonRelationshipRomanticIssues: CreateCaseNew.Name.ToString(),
                 reasonRelationshipFamilyIssues: CreateCaseNew.Name.ToString(),
                 referCompanyEAP: CreateCaseNew.Name.ToString(),
                 referUniversitySupportServices: CreateCaseNew.Name.ToString(),

                Nullable<int> distressRatingBegining: CreateCaseNew.Name.ToString(),
                Nullable<int> distressRatingEnd: CreateCaseNew.Name.ToString(),

                 reasonAcademicStress: CreateCaseNew.ReasonAcademicStress.ToString()

                );

            DE.SaveChanges();

            return Ok();

        }

    }
}
