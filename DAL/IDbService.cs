using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pjatk_wyklad3_webApi.Controllers;
using Pjatk_wyklad3_webApi.Models;

namespace Pjatk_wyklad3_webApi.DAL
{
    public interface IDbService
    {
        public IEnumerable<Students> GetStudents();
    }
}
