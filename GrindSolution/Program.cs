using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrindSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var iberdir = Environment.GetEnvironmentVariable("IBERDIR");
            var grindPath = Path.Combine(iberdir, "BIN", "GRIND.EXE");
            var dateFolder = DateTime.Today.AddDays(-1).ToString("yyyyMMdd");

            var grindProcess = new Process();
            try
            {
                grindProcess.StartInfo.UseShellExecute = false;
                grindProcess.StartInfo.FileName = grindPath;
                grindProcess.StartInfo.Arguments = $"/DATE {dateFolder}";
                grindProcess.StartInfo.CreateNoWindow = true;
                grindProcess.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
