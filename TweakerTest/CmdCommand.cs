using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweakerTest
{
    internal class CmdWorker
    {
        static public void Execute(string cmdCommand) 
        {
            var test = new ProcessStartInfo();
            test.UseShellExecute = true;
            test.WorkingDirectory = @"C:\Windows\System32";
            test.FileName = @"C:\Windows\System32\cmd.exe";
            test.Verb = "";
            test.Arguments = "/c " + cmdCommand;
            test.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(test);
            return;
        }
        static public string WinGet(string appID)
        {
            string agreement = "--accept-package-agreements";
            string cmdComand = "winget install " + appID + " " + agreement;
            return cmdComand;
        }
    }
}
