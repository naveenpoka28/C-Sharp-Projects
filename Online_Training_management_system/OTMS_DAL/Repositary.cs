using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTMS_DAL
{
    public class Repositary
    {



        // To Verify Login Details Entered By User
        public Candidate Login(string emailid,string password)
        {
            OTSDBEntities db = new OTSDBEntities();
            Candidate cad = null;
            try
            {
                cad = db.Candidates.Where(c => c.EmailAddress == emailid && c.Password == password).FirstOrDefault();
            }
            catch
            {
                cad = null;
            }
            return cad;
        }






        //To Register Candidate Details Entered By The User
        public bool SignUp(Candidate user)
        {
            try
            {
                OTSDBEntities db = new OTSDBEntities();
                Candidate cad = new Candidate();
                db.Candidates.Add(user);
                db.SaveChanges();
                return true;
            }

            catch (Exception e)
            {
                throw e;
            }
        }





        
        //To Get All Trainings To Display 
        public List<Training> GetAllTrainings()
        {
            List<Training> result = new List<Training>();
            try
            {
                OTSDBEntities db = new OTSDBEntities();
                
                result = (from i in db.Trainings select i).ToList();
                
            }
            catch(Exception e)
            {
                throw e;
            }
            return result;
        }





        // To Get Training Details Based On Training Id
        public Training GetTrainingDetails(int trainingid)
        {
            try
            {
                Training training = new Training();
                OTSDBEntities db = new OTSDBEntities();
                training = db.Trainings.Find(trainingid);
                return training;
            }
            catch(Exception e)
            {
                throw e;
            }
        }





        //To Register For Training In Registration Table By The User
        public bool RegisterTraining(Registration reg)
        {
            try
            {
                OTSDBEntities db = new OTSDBEntities();
                db.Registrations.Add(reg);
                db.SaveChanges();
            }
            catch(Exception e)
            {
                throw e;
            }
            return true;
        }




        //To Edit Registration Details Entered By The User
        public bool EditRegistration(Registration reg)
        {
            try
            {
                OTSDBEntities db = new OTSDBEntities();
                var register = db.Registrations.Find(reg.RegistrationId);
                register.Status = reg.Status;
                db.SaveChanges();
            }
            catch(Exception e)
            {
                throw e;
            }
            return true;
        }




        //To List All The Registrations Done By The User
        public List<Registration> ViewRegistration()
        {
            List<Registration> result = new List<Registration>();
            try
            {
                OTSDBEntities db = new OTSDBEntities();
                
                result = (from i in db.Registrations select i).ToList();
            }
            catch(Exception e)
            {
                throw e;
            }
            return result;
        }






        //To Delete The Registertions Done By The User
        public bool DeleteRegistration(int regid)
        {
            try
            {
                OTSDBEntities db = new OTSDBEntities();
                var reg = db.Registrations.Find(regid);
                db.Registrations.Remove(reg);
                db.SaveChanges();
            }
            catch(Exception e)
            {
                throw e;
            }
            return true;
        }





        //To Get Registration Details Based On Registration Id
        public Registration GetRegistrationDetails(int registrationId)
        {
            try
            {
                OTSDBEntities db = new OTSDBEntities();
                var reg = db.Registrations.Find(registrationId);
                return reg;
            }
            catch(Exception e)
            {
                throw e;
            }
        }




    }
}
