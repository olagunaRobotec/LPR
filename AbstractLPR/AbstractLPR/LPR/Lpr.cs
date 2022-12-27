using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractLPR.LPR
{
    abstract class Lpr
    {
        public abstract void GetToken(string url, string token);
        public abstract void Authentication();
        public abstract void RecognizerPlate();
    }
    class Token : Lpr
    {
        public override void GetToken(string url, string token)
        {
            Console.WriteLine("hola Dayron su url es " + url + ",y su token es " + token);
        }
        public override void Authentication()
        {
            Console.WriteLine("hola Dayron Authentication");
        }
        public override void RecognizerPlate()
        {
            throw new NotImplementedException();
        }
    }
    class AuthenticationE : Lpr
    {
        public override void GetToken(string url, string token)
        {
            Console.WriteLine("Adios Dayron su url es " + url + ",y su token es " + token);
        }

        public override void Authentication()
        {
            Console.WriteLine("Adios Dayron Authentication hasta la vista baby");
        }

        public override void RecognizerPlate()
        {
            throw new NotImplementedException();
        }
    }
}
