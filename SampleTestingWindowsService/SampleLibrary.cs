using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTestingWindowsService
{
    public static class SampleLibrary 
    {

        public static void WriteErrorLog(Exception e)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\SampleLogFile.txt", true);
                sw.WriteLine(DateTime.Now.ToString() + ":" + e.Source.ToString().Trim() + "," + e.Message.ToString().Trim());
                sw.Flush();
                sw.Close();
            }
            catch (Exception)
            {

            }
        }


        public static void WriteErrorLog(string message)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\SampleLogFile.txt", true);
                sw.WriteLine(DateTime.Now.ToString() + ":" + message);

                /*string text = File.ReadAllText(@"C:\Users\imoshika\source\repos\SampleTestingWindowsService\SampleTestingWindowsService\bin\Debug\SampleLogFile.txt");
                text = text.Replace("some job", "new job");
                File.WriteAllText(@"C:\Users\imoshika\source\repos\SampleTestingWindowsService\SampleTestingWindowsService\bin\Debug\SampleLogFile.txt", text);*/
                sw.Flush();
                sw.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
