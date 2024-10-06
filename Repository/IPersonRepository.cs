using Microsoft.EntityFrameworkCore;
using sharp_project.Model;

namespace sharp_project.Repository
{
    public interface IPersonRepository
    {
        Person Create(Person person);

        Person Update(Person person);

        Person FindById(long id);

        List<Person> FindAll();

        void Delete(long id);

        bool Exists(long id);
    }
}
