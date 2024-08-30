using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweakerTest
{
    internal class Info
    {
        static public List<Tuple<string,string>> listInfo = new List<Tuple<string, string>>(); 

        static public void Initialize(ref List<Tuple<string, string>> listInfo)
        {
            
            string xd = TweakerTest.Properties.Resources.data;
            string temp2 = "";
            string tempMem1 = "";
            for (int i = 0; i < xd.Length; i++)
            {
                if (xd[i] != '\n' )
                {
                    if (xd[i] == ' ')
                    {
                        tempMem1 = temp2;
                        temp2 = "";
                    }
                    else
                        temp2 += xd[i];
                }
                else
                {
                    var tempTuple = new Tuple<string, string>(tempMem1, temp2);
                    listInfo.Add(tempTuple);
                    temp2 = "";
                    tempMem1 = "";
                }
            }
            var tempTuple1 = new Tuple<string, string>(tempMem1, temp2);
            listInfo.Add(tempTuple1);
            temp2 = "";
            tempMem1 = "";
        }

    }
}
