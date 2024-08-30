using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweakerTest
{
    public class UserInterface
    {
        static public void FirstUI()
        {
            Console.Clear();
            Console.WriteLine("Выбор пунктов меню:");
            Console.WriteLine("1 - Winget");
            Console.WriteLine("0 - Для выхода из программы");
            Console.Write("Введите номер пункта меню: ");
            return;
        }

        static public void WrongAnsw()
        {
            Console.Clear();
            Console.WriteLine("Такого пункта не существует,\nнажмите любую клавишу для возврата к предыдущему пункту меню...");
            Console.ReadKey();
            return;
        }


        static public void WinGetUI()
        {
        WinGetStart:
            Console.Clear();
            Console.WriteLine("0 - для выхода в предыдущее меню");
            for (int i = 0; i < Info.listInfo.Count; i++)
            {
                Console.Write((i+1) + " ");
                Console.WriteLine(Info.listInfo[i].Item1);
            }
            Console.Write("\nВыберите пакет для установки: ");
            int choise = Convert.ToInt32(Console.ReadLine());
            if (choise == 0)
                return;
            if (choise >= Info.listInfo.Count || choise < 0 )
                UserInterface.WrongAnsw();
            else
                CmdWorker.Execute(CmdWorker.WinGet(Info.listInfo[choise - 1].Item2));
            goto WinGetStart;

        }
    }
}
