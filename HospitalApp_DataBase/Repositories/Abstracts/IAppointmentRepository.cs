using HospitalApp_Model.Entities.Concretes;

namespace HospitalApp_DataBase.Repositories.Abstracts;

public interface IAppointmentRepository : IGenericRepository<Appointment>
{
    ICollection<Appointment> getUserAppo(User user);
    ICollection<Appointment> getDoctorAppo(Doctor doctor);


    ICollection<Appointment> getUserApponotc(User user);
    ICollection<Appointment> getDoctorApponotc(Doctor doctor);
}
