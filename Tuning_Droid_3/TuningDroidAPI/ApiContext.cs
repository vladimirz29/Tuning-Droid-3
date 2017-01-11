using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpdateService;

namespace TuningDroidAPI
{
    public static class ApiContext
    {
        public static bool CheckUpdates()
        {
            return UpdateService.TuningDroidUpdater.CheckForUpdates();
        }
    }
}
