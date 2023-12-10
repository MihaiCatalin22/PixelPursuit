using Class_Library.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library.Interfaces
{
    public interface IBanManagement
    {
        public bool Create(Ban ban);
        public Ban[] ReadAll();
        public Ban[] ReadAllSearch(string search);
        public bool Update(Ban ban);
        public bool Delete(Ban ban);
        public bool IsUserCurrentlyBanned(int userId);
    }
}
