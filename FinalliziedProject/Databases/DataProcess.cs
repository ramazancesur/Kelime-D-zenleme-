using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalliziedProject.Databases
{
    class DataProcess
    {

        // Object orianted katili class  :))))))  
        public List<LibraryPasage> getAll()
        {
            using (var dataContext = new SampleDBContext("ceit436DB"))
            {
                var ptx = (from r in dataContext.Categories select r);
                return ptx.ToList();
            }
            
        }

        public LibraryPasage getLibraryData(int id)
        {
            using (var dataContext = new SampleDBContext("ceit436DB"))
            {
                LibraryPasage ptx = dataContext.Categories.Where(x => x.id == id).First();
                return ptx;
            }
        }


        public void save(LibraryPasage passage)
        {
            using (var dataContext = new SampleDBContext("ceit436DB"))
            {
                dataContext.Categories.Add(passage);
                dataContext.SaveChanges();
            }
        }

        public void update(LibraryPasage passage)
        {
            using (var dataContext = new SampleDBContext("ceit436DB"))
            {
                dataContext.Categories.Update(passage);
                dataContext.SaveChanges();
            }
        }

        public void remove(LibraryPasage passage)
        {
            using (var dataContext = new SampleDBContext("ceit436DB"))
            {
                dataContext.Categories.Remove(passage);
                dataContext.SaveChanges();
            }
        }

    }
}
