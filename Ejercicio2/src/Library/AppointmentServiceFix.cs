using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        private readonly AppointmentValidator validator;
        private readonly Appointment appointment;
        public AppointmentService()
        {
            validator = new AppointmentValidator();
            appointment = new Appointment();
        }

        public string CreateAndScheduleAppointment(Patient patient, DateTime date)
        {
            bool isValid = validator.Validate(patient);

            if (isValid)
            {
                return appointment.CreateAppointment(patient, date);
            }
            else
            {
                return "No se pudo agendar una cita debido a errores de validación";
            }
        }
    }
}
