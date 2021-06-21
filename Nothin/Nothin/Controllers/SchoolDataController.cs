using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using GiphyDotNet.Manager;
using GiphyDotNet.Model.Parameters;
using Nothin.Models;
using UrbanDictionaryDex.Client;
using YahooFinance.NET;

namespace Nothin.Controllers
{
    public class SchoolDataController : ApiController
    {

        public static IList<Student> students = new List<Student> {
            new Student{StudentId = 1, Name = "Timmy", Age = 35, Hours = 15, Classes = new List<string>{ } },
            new Student{StudentId = 2, Name = "Sarah", Age = 27, Hours = 15, Classes = new List<string>{ } },
            new Student{StudentId = 3, Name = "Buck", Age = 80, Hours = 15, Classes = new List<string>{ } }
        };

        public static int studentAmount = students.Count;

        [HttpGet]
        [Route("api/studentid/{id}")]
        public async Task<IHttpActionResult> GetStudentID(int Id)
        {
            return Ok(students.Where(s => s.StudentId == Id));
        }

        [HttpGet]
        [Route("api/studentname/{Name}")]
        public async Task<IHttpActionResult> GetStudentName(string Name)
        {

            return Ok(students.Where(s => s.Name == Name).First());
        }

        [HttpGet]
        [Route("api/students/list")]
        public async Task<IHttpActionResult> GetStudents()
        {
            return Ok(students);
        }

        [HttpPost]
        [Route("api/student/{id}/change/{text}")]
        public async Task<IHttpActionResult> AddClass(int id, string text)
        {
            students.Where(s => s.StudentId == id).First().Classes.Add(text);
            return Ok(text);
        }

        [HttpGet]
        [Route("api/urbanword")]
        public async Task<IHttpActionResult> UrbanWord()
        {
            var client = new UrbanDictionaryClient();
            var results = await client.GetRandomTerm();
            return Ok(results.First());
        }

        [HttpPost]
        [Route("api/urbanword/{word}")]
        public async Task<IHttpActionResult> GetUrbanWord(string word)
        {
            var client = new UrbanDictionaryClient();
            var results = await client.SearchTerm(word);
            return Ok(results.First());
        }

        [HttpPost]
        [Route("api/urbanword/{word}/Full")]
        public async Task<IHttpActionResult> GetUrbanWordFull(string word)
        {
            var client = new UrbanDictionaryClient();
            var results = await client.SearchTerm(word);
            return Ok(results);
        }
    }
}
