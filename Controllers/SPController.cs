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
                reasonAlzheimersDementia: Convert.ToBoolean(CreateCaseNew.ReasonAlzheimersDementia.ToString()),
                reasonAnxiety: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                reasonBipolar: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                reasonDebtPovertyUnemployment: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                reasonDepression: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                reasonEatingDisoirder: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                reasonHIVAIDS: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                reasonInformation: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                reasonLossGriefLoneliness: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                reasonNone: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                reasonOCD: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                reasonOtherIllness: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                reasonPhysicalEmotionalAbuse: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                reasonPostNatalDepression: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                reasonPTSDTrauma: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                reasonReationshipDomesticAbuse: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                reasonSchizophrenia: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                reasonSelfMutilation: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                reasonSexualAbuseRape: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                reasonSleepingDisorder: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                reasonSocialPhobia: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                reasonStress: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                reasonSubstanceAbuse: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                reasonSuicide: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                referDASGFaceToFace: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                referGP: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                referGovHospital: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                referLiteratureWebsite: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                referNone: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                referOther: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                referOtherNGOHelpline: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                referPoliceStation: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                referPrivateHospital: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                referPsychiatrist: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                referPsychologist: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                referRapeCrisis: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                referShelter: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                referSocialWorker: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                referSupportGroup: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                referTraumaCentre: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),

                 callSummary: CreateCaseNew.CallSummary.ToString(),

                reasonFrequentCaller: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                reasonBullying: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                reasonPregnancy: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                reasonSexuality: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                referRehabilitationCentre: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                reasonBorderlinePersonalityDisorder: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),

                 helpLine: CreateCaseNew.HelpLine.ToString(),

                reasonOtherReason: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                reasonFollowUp: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                referUniversityStudentWellness: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                referSadagHelpLine: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                referSelfHelp: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                referUber: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),

                 dLCallTimeOfDay: CreateCaseNew.Name.ToString(),

                 calledOnBehalfOf: CreateCaseNew.CalledFor.ToString(),
                 actionPoints: CreateCaseNew.ActionPoints.ToString(),

                reasonRelationshipRomanticIssues: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                reasonRelationshipFamilyIssues: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                referCompanyEAP: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),
                referUniversitySupportServices: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),

                Nullable<int> distressRatingBegining: CreateCaseNew.Name.ToString(),
                Nullable<int> distressRatingEnd: CreateCaseNew.Name.ToString(),

                reasonAcademicStress: CreateCaseNew.ReasonAcademicStress.ToString()

                );

            DE.SaveChanges();

            return Ok();

        }

    }
}
