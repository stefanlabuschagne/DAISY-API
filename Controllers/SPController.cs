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

                callDate: Convert.ToDateTime(CreateCaseNew.CallDate.ToString()),

                reasonADHD: Convert.ToBoolean(CreateCaseNew.ReasonADHD.ToString()),  
                reasonAlzheimersDementia: Convert.ToBoolean(CreateCaseNew.ReasonAlzheimersDementia.ToString()),
                reasonAnxiety: Convert.ToBoolean(CreateCaseNew.ReasonAnxiety.ToString()),
                reasonBipolar: Convert.ToBoolean(CreateCaseNew.ReasonBipolar.ToString()),
                reasonDebtPovertyUnemployment: Convert.ToBoolean(CreateCaseNew.ReasonDebtPovertyUnemployment.ToString()),
                reasonDepression: Convert.ToBoolean(CreateCaseNew.ReasonDepression.ToString()),
                reasonEatingDisoirder: Convert.ToBoolean(CreateCaseNew.ReasonEatingDisoirder.ToString()),
                reasonHIVAIDS: Convert.ToBoolean(CreateCaseNew.ReasonHIVAIDS.ToString()),
                reasonInformation: Convert.ToBoolean(CreateCaseNew.ReasonInformation.ToString()),
                reasonLossGriefLoneliness: Convert.ToBoolean(CreateCaseNew.ReasonLossGriefLoneliness.ToString()),
                reasonNone: Convert.ToBoolean(CreateCaseNew.ReasonNone.ToString()),
                reasonOCD: Convert.ToBoolean(CreateCaseNew.ReasonOCD.ToString()),
                reasonOtherIllness: Convert.ToBoolean(CreateCaseNew.ReasonOtherIllness.ToString()),
                reasonPhysicalEmotionalAbuse: Convert.ToBoolean(CreateCaseNew.ReasonPhysicalEmotionalAbuse.ToString()),
                reasonPostNatalDepression: Convert.ToBoolean(CreateCaseNew.ReasonPostNatalDepression.ToString()),
                reasonPTSDTrauma: Convert.ToBoolean(CreateCaseNew.ReasonPTSDTrauma.ToString()),
                reasonReationshipDomesticAbuse: Convert.ToBoolean(CreateCaseNew.ReasonReationshipDomesticAbuse.ToString()),
                reasonSchizophrenia: Convert.ToBoolean(CreateCaseNew.ReasonSchizophrenia.ToString()),
                reasonSelfMutilation: Convert.ToBoolean(CreateCaseNew.ReasonSelfMutilation.ToString()),
                reasonSexualAbuseRape: Convert.ToBoolean(CreateCaseNew.ReasonSexualAbuseRape.ToString()),
                reasonSleepingDisorder: Convert.ToBoolean(CreateCaseNew.ReasonSleepingDisorder.ToString()),
                reasonSocialPhobia: Convert.ToBoolean(CreateCaseNew.ReasonSocialPhobia.ToString()),
                reasonStress: Convert.ToBoolean(CreateCaseNew.ReasonStress.ToString()),
                reasonSubstanceAbuse: Convert.ToBoolean(CreateCaseNew.ReasonSubstanceAbuse.ToString()),
                reasonSuicide: Convert.ToBoolean(CreateCaseNew.ReasonSuicide.ToString()),

                referDASGFaceToFace: Convert.ToBoolean(CreateCaseNew.ReferDASGFaceToFace.ToString()),
                referGP: Convert.ToBoolean(CreateCaseNew.ReferGP.ToString()),
                referGovHospital: Convert.ToBoolean(CreateCaseNew.ReferGovHospital.ToString()),
                referLiteratureWebsite: Convert.ToBoolean(CreateCaseNew.ReferLiteratureWebsite.ToString()),
                referNone: Convert.ToBoolean(CreateCaseNew.ReferNone.ToString()),
                referOther: Convert.ToBoolean(CreateCaseNew.ReferOther.ToString()),
                referOtherNGOHelpline: Convert.ToBoolean(CreateCaseNew.ReferOtherNGOHelpline.ToString()),
                referPoliceStation: Convert.ToBoolean(CreateCaseNew.ReferPoliceStation.ToString()),
                referPrivateHospital: Convert.ToBoolean(CreateCaseNew.ReferPrivateHospital.ToString()),
                referPsychiatrist: Convert.ToBoolean(CreateCaseNew.ReferPsychiatrist.ToString()),
                referPsychologist: Convert.ToBoolean(CreateCaseNew.ReferPsychologist.ToString()),
                referRapeCrisis: Convert.ToBoolean(CreateCaseNew.ReferRapeCrisis.ToString()),
                referShelter: Convert.ToBoolean(CreateCaseNew.ReferShelter.ToString()),
                referSocialWorker: Convert.ToBoolean(CreateCaseNew.ReferSocialWorker.ToString()),
                referSupportGroup: Convert.ToBoolean(CreateCaseNew.ReferSupportGroup.ToString()),
                referTraumaCentre: Convert.ToBoolean(CreateCaseNew.ReferTraumaCentre.ToString()),

                 callSummary: CreateCaseNew.CallSummary.ToString(),

                reasonFrequentCaller: Convert.ToBoolean(CreateCaseNew.ReasonFrequentCaller.ToString()),
                reasonBullying: Convert.ToBoolean(CreateCaseNew.ReasonBullying.ToString()),
                reasonPregnancy: Convert.ToBoolean(CreateCaseNew.ReasonPregnancy.ToString()),
                reasonSexuality: Convert.ToBoolean(CreateCaseNew.ReasonSexuality.ToString()),
                referRehabilitationCentre: Convert.ToBoolean(CreateCaseNew.ReferRehabilitationCentre.ToString()),
                reasonBorderlinePersonalityDisorder: Convert.ToBoolean(CreateCaseNew.ReasonBorderlinePersonalityDisorder.ToString()),

                helpLine: CreateCaseNew.HelpLine.ToString(),

                reasonOtherReason: Convert.ToBoolean(CreateCaseNew.ReasonOtherReason.ToString()),
                reasonFollowUp: Convert.ToBoolean(CreateCaseNew.ReasonFollowUp.ToString()),
                referUniversityStudentWellness: Convert.ToBoolean(CreateCaseNew.ReferUniversityStudentWellness.ToString()),
                referSadagHelpLine: Convert.ToBoolean(CreateCaseNew.ReferSadagHelpLine.ToString()),
                referSelfHelp: Convert.ToBoolean(CreateCaseNew.ReferSelfHelp.ToString()),
                referUber: Convert.ToBoolean(CreateCaseNew.ReferUber.ToString()),

                 dLCallTimeOfDay: CreateCaseNew.DLCallTimeOfDay.ToString(),

                 calledOnBehalfOf: CreateCaseNew.CalledFor.ToString(),
                 actionPoints: CreateCaseNew.ActionPoints.ToString(),

                reasonRelationshipRomanticIssues: Convert.ToBoolean(CreateCaseNew.ReasonRelationshipRomanticIssues.ToString()),
                reasonRelationshipFamilyIssues: Convert.ToBoolean(CreateCaseNew.ReasonRelationshipFamilyIssues.ToString()),
                referCompanyEAP: Convert.ToBoolean(CreateCaseNew.ReferCompanyEAP.ToString()),
                referUniversitySupportServices: Convert.ToBoolean(CreateCaseNew.ReferUniversitySupportServices.ToString()),

                distressRatingBegining: Convert.ToInt32(CreateCaseNew.Name.ToString()),
                distressRatingEnd: Convert.ToInt32(CreateCaseNew.Name.ToString()),

                reasonAcademicStress: Convert.ToBoolean(CreateCaseNew.ReasonAcademicStress.ToString())

                );

            DE.SaveChanges();

            return Ok();

        }

    }
}
