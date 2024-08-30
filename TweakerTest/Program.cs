using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TweakerTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Info.Initialize(ref Info.listInfo);
        MainMenu:
            UserInterface.FirstUI();
            int answ = Convert.ToInt32(Console.ReadLine());
            switch(answ)
            {
                case 0:
                    break;
                case 1:
                    UserInterface.WinGetUI();
                    goto MainMenu;
                default:
                    UserInterface.WrongAnsw();
                    goto MainMenu;
            }
            
        }
    }
}
