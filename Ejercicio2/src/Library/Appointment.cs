using System;
using System.Text;

/* Por SRP hay que dividir la funcionalidad del programa en las clases pertinentes, la clase AppointmentService
que se da al comienzo contiene, como mencioné, toda la funcionalidad del programa en una misma clase. La clase que se define
a continuación toma el trabajo de validar la cita */
namespace Library
{
    public class Appointment
        {
            public string CreateAppointment(Patient patient, DateTime date)
            {
                return "Cita ordenada";
            }
        }
}