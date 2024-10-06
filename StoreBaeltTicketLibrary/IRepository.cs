using TicketClassLibrary;

namespace StoreBaeltTicketLibrary;

internal interface IRepository
{
    void Add(Vehicle vehicle);
    IEnumerable<Vehicle> GetAll();
    IEnumerable<Vehicle> GetTicketsByLicenseplate(string licenseplate);
}