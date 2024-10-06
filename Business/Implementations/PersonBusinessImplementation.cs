using sharp_project.Model;
using sharp_project.Model.Context;
using sharp_project.Repository;

namespace sharp_project.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        private volatile int count;
        private readonly IPersonRepository _repository;

        public PersonBusinessImplementation(IPersonRepository repository) {
            _repository = repository;
        }

        public Person Create(Person person)
        {
            return _repository.Create(person);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }

        public Person FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Person Update(Person person)
        {
            return _repository.Update(person);
        }
    }
}
