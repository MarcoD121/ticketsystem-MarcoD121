
using System.ComponentModel;
using TicketClassLibrary;

namespace StoreBaeltTicketLibrary;

class Repository : IRepository
{
    private static List<Vehicle> _instance;

    public void Add(Vehicle vehicle)
    {
        _instance.Add(vehicle);
    }

    public IEnumerable<Vehicle> GetAll()
    {
        return _instance;
    }

    public IEnumerable<Vehicle> GetTicketsByLicenseplate(string licenseplate)
    {
        return _instance.Where(v => v.Licenseplate == licenseplate);
    }

}
