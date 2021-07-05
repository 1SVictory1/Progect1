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
        public string getAuthForUser()
        {
            string fileName = @"C://Users/Alex Elll/source/repos/Progect/Progect/bin/Debug/auth_VK.txt";
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
        public string getAuthForGroups()
        {
            string fileName = @"C://Users/Alex Elll/source/repos/Progect/Progect/bin/Debug/auth_VK.txt";
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
