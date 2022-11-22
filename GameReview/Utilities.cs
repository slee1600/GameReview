using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameReview
{
    public static class Utilities
    {
        public static void Log(string input)
        {
            string path = "C:\\TestOutput\\Logs\\";
            Directory.CreateDirectory(path);

            StringBuilder sb = new StringBuilder();
            sb.Append(Environment.NewLine);
            sb.Append(DateTime.Now.ToString());
            sb.Append(Environment.NewLine);
            sb.Append(input);
            File.AppendAllText(path + "log.txt", sb.ToString());
            sb.Clear();
        }
    }
}
