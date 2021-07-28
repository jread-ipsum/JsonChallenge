using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Jordan";
            person.LastName = "Read";
            person.DOB = new DateTime(1989, 09, 15);
            person.FavoriteIceCreamFlavors = new List<string> { "Strawberry", "Cookie Dough" };

            string json = JsonConvert.SerializeObject(person);

            Console.WriteLine(json);

            Console.ReadKey();
        }
    }
}
