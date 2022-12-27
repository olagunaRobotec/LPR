using AbstractLPR.LPR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractLPR
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://192.68.1.129";
            string token = "tokenvfvdgdbfhbdthr";

            Token T1 = new Token();
            T1.GetToken(url,token);
            T1.Authentication();

            AuthenticationE A1 = new AuthenticationE();
            string _url = "http://fjeshgdruhgiudh";
            string _token = "tokengkdogjdoxjgodbxdbtrdx";
            A1.GetToken(_url, _token);
            A1.Authentication();

            Console.ReadLine();
        }
    }
}
