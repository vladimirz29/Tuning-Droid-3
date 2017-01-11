using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpdateService
{
    public class TuningDroidUpdater
    {
        #region Variables
        public string UpdaterVersion = "1.0.0";
        public string UpdaterInfoFile = "FilePath";
        private string UpdateServer = "Server";
        #endregion

        public TuningDroidUpdater()
        {

        }

        /// <summary>
        /// Start Program Updating
        /// </summary>
        /// <param name="ApplicationContext">Application Context For Aplication Controlling</param>
        public void UpdateProgram(Application ApplicationContext)
        {

        }

        public bool CheckForUpdates()
        {
            return false;
        }
    }
}
