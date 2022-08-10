using Domain;
using Persistence.Repository.IRepository;

namespace Persistence.Repository
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        private readonly ApplicationDbContext _db;

        public PersonRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Person obj)
        {
            _db.Update(obj);
        }
    }
}