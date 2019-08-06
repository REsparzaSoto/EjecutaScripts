using System.Diagnostics;

namespace EjecutaScripts
{
    public class EjecutaScript
    {
        private ProcessStartInfo infoSqlCmd;

        public int Error { get; private set; }

        public EjecutaScript()
        {
            infoSqlCmd = new ProcessStartInfo()
            {
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                FileName = Literales.SqlCmd
            };
        }

        public void EjecutaSqlCmd(string argumentos)
        {
            infoSqlCmd.Arguments = argumentos;

            using (Process process = Process.Start(infoSqlCmd))
            {
                process.WaitForExit();
                Error = process.ExitCode;
            }
        }
    }
}
