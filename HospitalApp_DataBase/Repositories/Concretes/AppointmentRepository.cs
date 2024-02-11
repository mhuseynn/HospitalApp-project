using HospitalApp_DataBase.Repositories.Abstracts;
using HospitalApp_Model.Entities.Concretes;
using System.Collections.ObjectModel;
using System.Numerics;

namespace HospitalApp_DataBase.Repositories.Concretes;

public class AppointmentRepository : GenericRepository<Appointment>, IAppointmentRepository
{
    public ICollection<Appointment> getDoctorAppo(Doctor doctor)
    {
        return _context!.Appointments!.Where(x=> x.DoctorId == doctor.Id && x.IsConfirmed==true).ToList();
    }

    public ICollection<Appointment> getDoctorApponotc(Doctor doctor)
    {
        return _context!.Appointments!.Where(x => x.DoctorId == doctor.Id && x.IsConfirmed==false).ToList();
    }
    //------------------------------------------------------------------------------------------------
    public ICollection<Appointment> getUserAppo(User user)
    {
        return _context!.Appointments!.Where(x => x.UserId == user.Id && x.IsConfirmed == true).ToList();
    }

    public ICollection<Appointment> getUserApponotc(User user)
    {
        return _context!.Appointments!.Where(x => x.UserId == user.Id && x.IsConfirmed==false).ToList();
    }
}
