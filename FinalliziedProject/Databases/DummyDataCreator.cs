using System;
using System.Linq;
namespace FinalliziedProject.Databases
{
    public class DummyDataCreator
    {
        public void createDummyData(string dbName)
        {
            using (var dataContext = new SampleDBContext(dbName))
            {
                Console.WriteLine( "db created..." );
            }
        }

    }
}
