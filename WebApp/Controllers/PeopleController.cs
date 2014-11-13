using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{

    public class PeopleController : ApiController
    {
        private static IList<Person> _people = new List<Person>()
        {
            new Person(){
                id = 1,
                firstName = "Henrik",
                lastName = "Joreteg",
                coolnessFactor = 11
            },
            new Person(){
                id =  2,
                firstName =  "Bob",
                lastName =  "Saget",
                coolnessFactor =  2
            },
            new Person(){
                id =  3,
                firstName =  "Larry",
                lastName =  "King",
                coolnessFactor =  4
            },
            new Person(){
                id =  4,
                firstName =  "Diana",
                lastName =  "Ross",
                coolnessFactor =  6
            },
            new Person(){
                id =  5,
                firstName =  "Crazy",
                lastName =  "Dave",
                coolnessFactor =  8
            },
            new Person(){
                id =  6,
                firstName =  "Larry",
                lastName =  "Johannson",
                coolnessFactor =  4
            }

        };

        private static int _id = 7;

        public IEnumerable<Person> Get()
        {
            return _people;
        }

        // GET api/values/5
        public Person Get(int id)
        {
            var foundPerson = (from p in _people
                               where p.id == id
                               select p).FirstOrDefault();

            return foundPerson;
        }

        // POST api/values
        public Person Post([FromBody]Person person)
        {
            _id++;
            person.id = _id;
            _people.Add(person);

            return person;
        }

        // PUT api/values/5
        public Person Put([FromBody]Person person)
        {
            var foundPerson = (from p in _people
                               where p.id == person.id
                               select p).FirstOrDefault();

            var index = _people.IndexOf(foundPerson);
            _people[index] = person;

            return person;
        }

        // DELETE api/values/5
        public Person Delete(int id)
        {
            var foundPerson = (from p in _people
                               where p.id == id
                               select p).FirstOrDefault();
            _people.Remove(foundPerson);

            return foundPerson;
        }              

    }


}