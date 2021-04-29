using API.BusinessObject;

namespace DAL.Repository
{
    public interface IReservationRepository : IGenericRepository<Reservation>, IPageableRepository<Reservation>
    {
    }
}
