using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LogToFile.Classes;
using LogToFile.Extensions;
using LogToFile.Models;

namespace LogToFile
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Operations.DemonstrationLoggingTask();
        }

        private static async Task iteratePeopleTask()
        {
            var people = await Operations.PeopleTask();

            foreach (var person in people)
            {
                Console.WriteLine(person.FullName);
            }

        }
        private static async Task PeopleJsonTask()
        {
            var people = await Operations.PeopleTask();
            people.ModeListToJson("people.json");
        }
    }
}
