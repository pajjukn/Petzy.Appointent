using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Petzy.Appointment.Domain.Entities
{
    public class Appointments
    {
        public int AppointmentID { get; set; }
        public DateTime AppointmentTimeslot { get; set; }
        public Status AppointmentStatus { get; set; }
        public  String ReasonOfVisit { get; set; }
        public int PetID { get; set; }
        public int DoctorID { get; set; }
        //public List<PetIssueID> PetIssues { get; set; }

    }
    public enum Status
    {
        Confirmed=1,
        Cancelled,
        Closed

    }
}

