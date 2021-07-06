using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Progect
{
    class Autoriz
    {
        public static string getAuthForUser()
        {
            string fileName = @"C:/Users/alexa/source/repos/Git/Progect/auth_VK.txt";
            string token = "";
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    token = sr.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return token;
        }
        public static string getAuthForGroups()
        {
            string fileName = @"C:/Users/alexa/source/repos/Git/Progect/auth_VK.txt";
            string token = "";
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    sr.ReadLine();
                    token = sr.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return token;
        }
    }
}
