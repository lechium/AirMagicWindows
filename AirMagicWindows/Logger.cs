using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


    class Logger
    {
      //  public static StreamWriter science = new StreamWriter("log.txt", true);

        public void WriteLine(string theLine)
        {
            using (FileStream fs = new FileStream("Resources\\log.txt", FileMode.Append, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                Console.WriteLine(theLine);
                sw.BaseStream.Seek(0, SeekOrigin.End);
                sw.WriteLine(theLine);
            }

            //science.WriteLine(theLine);
        }

        public void WriteLine(string theLine, bool toConsole)
        {
            using (FileStream fs = new FileStream("log.txt", FileMode.Append, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                if (toConsole == true)
                {
                    Console.WriteLine(theLine);
                }
                sw.BaseStream.Seek(0, SeekOrigin.End);
                sw.WriteLine(theLine);
            }

            //science.WriteLine(theLine);
        }
    }
