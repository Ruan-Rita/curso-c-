using sharp_project.Model;
using sharp_project.Model.Context;

namespace sharp_project.Repository.Implementations
{
    public class PersonRepositoryImplementation : IPersonRepository
    {
        private volatile int count;
        private MysqlContext _context;
        public PersonRepositoryImplementation(MysqlContext context) {
            _context = context;
        }


        public Person Create(Person person)
        {
            try
            {
                _context.Add(person);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return person;
        }

        public void Delete(long id)
        {
            var result = _context.Persons.SingleOrDefault(p => p.Id == id);
            if (result != null)
            {
                try
                {
                    _context.Persons.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<Person> FindAll()
        {
            return _context.Persons.ToList();
        }

        public Person FindById(long id)
        {
            return _context.Persons.SingleOrDefault(p => p.Id == id);
        }

        public Person Update(Person person)
        {
            if (! Exists(person.Id))
            {
                return new Person();
            }
            
            var result = _context.Persons.FirstOrDefault(p => p.Id == person.Id);
            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(person);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return person;
        }

        public bool Exists(long id)
        {
            return _context.Persons.Any(p => p.Id == id);
        }


        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
