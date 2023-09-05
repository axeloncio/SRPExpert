using System;
using System.Text;

namespace Library
{
    // Por Expert proponemos que la clase Patient encapsule la información del paciente, las demás clases
    // van a operar con la clase Patient.
    public class Patient
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string PhoneNumber { get; set; }
        public string AppointmentPlace { get; set; }
        public string DoctorName { get; set; }
        public Patient(string name, string id, string phoneNumber, DateTime date, string appointmentPlace, string doctorName)
        {
            Name = name;
            Id = id;
            PhoneNumber = phoneNumber;
            AppointmentPlace = appointmentPlace;
            DoctorName = doctorName;
        }
    }
}