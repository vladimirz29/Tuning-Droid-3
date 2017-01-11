using System.Windows.Forms;

namespace UpdateService
{
    public static class TuningDroidUpdater
    {
        #region Variables
        public static string UpdaterVersion = "1.0.0";
        public static string UpdaterInfoFile = "FilePath";
        private static string UpdateServer = "Server";
        #endregion
        
        /// <summary>
        /// Start Program Updating
        /// </summary>
        /// <param name="ApplicationContext">Application Context For Aplication Controlling</param>
        public static void UpdateProgram(Application ApplicationContext)
        {

        }

        public static bool CheckForUpdates()
        {
            //td controls need
            return false;
        }
    }
}
