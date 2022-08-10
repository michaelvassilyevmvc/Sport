using Domain;

namespace Persistence.Repository.IRepository
{
    public interface IPersonRepository : IRepository<Person>
    {
        void Update(Person obj);

    }
}