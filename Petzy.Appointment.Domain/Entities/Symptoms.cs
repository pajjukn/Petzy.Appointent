using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzy.Appointment.Domain.Entities
{
    public class Symptoms
    {
        public int SymptomID { get; set; }
        public int AppointmentID { get; set; }
        public List<Symptoms> Symptom { get; set; }
    }
}
