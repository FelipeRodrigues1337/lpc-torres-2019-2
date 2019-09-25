using System.Collections.Generic;

namespace crud_efcorePeople.Models
{
    public interface IPersonRepository
    {
         void Create(Person person);
         void Update(Person person);
         void Delete(int id);
        Person GetById(int id);
        List<Person> GetAll();
    }
}