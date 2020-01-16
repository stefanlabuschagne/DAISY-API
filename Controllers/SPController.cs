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

            DE.CreateCaseWrite(

                name: CreateCaseNew.Name.ToString(),
                surname: CreateCaseNew.Name.ToString(),
                age: CreateCaseNew.Name.ToString(),
                sex: CreateCaseNew.Name.ToString(),
                race: CreateCaseNew.Name.ToString(),
                occupation: CreateCaseNew.Name.ToString(),
                medicalAid: CreateCaseNew.Name.ToString(),
                medication: CreateCaseNew.Name.ToString(),
                address: CreateCaseNew.Name.ToString(),
                city: CreateCaseNew.Name.ToString(),
                province: CreateCaseNew.Name.ToString(),
                postalCode: CreateCaseNew.Name.ToString(),
                telephone1: CreateCaseNew.Name.ToString(),
                telephone2: CreateCaseNew.Name.ToString(),
                emailAddress: CreateCaseNew.Name.ToString(),
                suburb: CreateCaseNew.Name.ToString(),
                dLLocation: CreateCaseNew.Name.ToString(),
                dLType: CreateCaseNew.Name.ToString(),
                dLSource: CreateCaseNew.Name.ToString(),
                dLStudentNumber: CreateCaseNew.Name.ToString(),
                counsellor: CreateCaseNew.Name.ToString(),
                Nullable < System.DateTime > callDate: CreateCaseNew.Name.ToString(),
                 reasonADHD: CreateCaseNew.Name.ToString(),
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
                helpLine: CreateCaseNew.Name.ToString(),
                 reasonOtherReason: CreateCaseNew.Name.ToString(),
                 reasonFollowUp: CreateCaseNew.Name.ToString(),
                 referUniversityStudentWellness: CreateCaseNew.Name.ToString(),
                 referSadagHelpLine: CreateCaseNew.Name.ToString(),
                 referSelfHelp: CreateCaseNew.Name.ToString(),
                 referUber: CreateCaseNew.Name.ToString(),
                dLCallTimeOfDay: CreateCaseNew.Name.ToString(),
                calledOnBehalfOf: CreateCaseNew.Name.ToString(),
                actionPoints: CreateCaseNew.Name.ToString(),
                 reasonRelationshipRomanticIssues: CreateCaseNew.Name.ToString(),
                 reasonRelationshipFamilyIssues: CreateCaseNew.Name.ToString(),
                 referCompanyEAP: CreateCaseNew.Name.ToString(),
                 referUniversitySupportServices: CreateCaseNew.Name.ToString(),
                Nullable<int> distressRatingBegining: CreateCaseNew.Name.ToString(),
                Nullable<int> distressRatingEnd: CreateCaseNew.Name.ToString(),
                 reasonAcademicStress: CreateCaseNew.reasonAcademicStress.ToString()

                );

            DE.SaveChanges();

            return Ok();

        }

    }
}
