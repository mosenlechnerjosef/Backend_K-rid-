using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koridok
{
    public class Versenyzo
    {
        public Versenyzo(string csapat, string nev,int kor, string palya, TimeSpan korido, int kör)
        {
            Csapat = csapat;
            Nev = nev;
            Kor = kor;
            Palya = palya;
            Korido = korido;
            Kör = kör;
            
        }
        public string Csapat { get; set; }  
        public string Nev { get; set; }
        public int Kor { get; set; }
        public string Palya { get; set; }
        public TimeSpan Korido { get; set;}
        public int Kör { get; set;}

        
    }
}
