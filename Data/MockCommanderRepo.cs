using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{
                    Id=0, HowTo="How to genrate a migration", 
                    Line="dotnet ef migrations add <Name of Migration>", 
                    Platform=".Net Core EF"},
                new Command{
                    Id=1, HowTo="Run Migrations", 
                    Line="dotnet ef database update", 
                    Platform=".Net Core EF"},
                new Command{
                    Id=2, HowTo="List active migrations", 
                    Line="dotnet ef migrations list", 
                    Platform=".Net Core EF"}
            };

            return commands;
        }

         public Command GetCommandById(int id)
        {
            return new Command{
                Id=0, HowTo="How to genrate a migration", 
                Line="dotnet ef migrations add <Name of Migration>", 
                Platform=".Net Core EF"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}