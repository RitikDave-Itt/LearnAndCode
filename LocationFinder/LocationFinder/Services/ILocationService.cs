using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocationFinder.Models;

namespace LocationFinder.Services
{
    public interface ILocationService
    {
        Task<LocationResult> FindLocationAsync(string query);
    }
}
