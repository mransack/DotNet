using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using System;


namespace Learning
{
    //internal class AutoMapper2
    //{
    //}
    /*The following program maps PersonDTO to Person class.
As you could see, the IsMinor property of Person is not set. Please add configuration to Automapper to set IsMinor to true if age <= 18 and set false otherwise.*/

class AutoMapper2
    {
        public static void TestAutoMapper()
        {
            // Setup AutoMapper configuration
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PersonDto, Person>().AfterMap((x, y) => y.IsMinor = y.Age < 18);
            });

            // Create mapper instance
            var mapper = new Mapper(config);

            // Create a person DTO
            var personDto = new PersonDto { Name = "John Doe", Age = 19 };

            // Map the person DTO to a person object
            var person = mapper.Map<PersonDto, Person>(personDto);

            // Print the mapped person details
            Console.WriteLine("Name: {0}", person.Name);
            Console.WriteLine("Age: {0}", person.Age);
            Console.WriteLine("Is Minor: {0}", person.IsMinor);
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsMinor { get; set; }
    }

    class PersonDto
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

}
