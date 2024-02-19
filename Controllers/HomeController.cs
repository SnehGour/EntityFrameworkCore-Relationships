using EFcore.RelationShips.Migrations;
using EFcore.RelationShips.Models;
using EFcore.RelationShips.Models.Dto;
using EFCore.RelationShips.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EFcore.RelationShips.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public HomeController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [Route("Person")]
        public ActionResult<IEnumerable<Person>> Get()
        {
            List<PersonDto> personDto = [];
            var persons = context.Persons.Include(a=>a.Phones).ToList();
            return persons;
            /*foreach(Person person in persons)
            {       
                personDto.Add(new PersonDto
                {
                    Age = person.Age,
                    Name = person.Name,
                    PersonId = person.PersonId,
                });
            }
            return personDto;*/
        }

        [HttpGet]
        [Route("PhoneNumber")]
        public ActionResult<IEnumerable<PhoneNumber>> GetAllPhoneNumbers()
        {
            List<PhoneNumberDto> phoneDto = [];
            var phones = context.PhoneNumbers.Include("Person")
            .ToList();

            return phones;
            /*foreach (PhoneNumber phone in phones)
            {
                phoneDto.Add(new PhoneNumberDto
                {
                    PhoneNumberId = phone.PhoneNumberId,
                    Phone = phone.Phone,
                    PersonId = phone.PersonId,
                });
            }

            return phoneDto;*/
        }

        [HttpPost]
        [Route("PhoneNumber")]
        public ActionResult<PhoneNumber> Create(PhoneNumberDto phoneNumber)
        {
            /*var person = context.Persons.FirstOrDefault(person => person.PersonId == phoneNumber.PersonId);
            phoneNumber.Person = person;*/

            var phone = new PhoneNumber
            {                
                PersonId = phoneNumber.PersonId,
                Phone = phoneNumber.Phone,
            };
            context.PhoneNumbers.Add(phone);
            context.SaveChanges();
            return RedirectToAction("GetAllPhoneNumbers");
        }

        [HttpPost]
        [Route("Person")]
        public ActionResult<Person> Create(PersonDto personDto)
        {
            var person = new Person
            {
                Age = personDto.Age,
                Name = personDto.Name,
            };
            context.Persons.Add(person);
            context.SaveChanges();
            return RedirectToAction("Get");
        }
    }
}
