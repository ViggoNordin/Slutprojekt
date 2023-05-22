using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



class PersonR
{
 
    private float hpPoäng;
   
    private float merit_värde;


    private string universitet;
    private string ämnen;
   
    public PersonR ( string u, string ä, int m_v, int h_p )
    {
           
     hpPoäng = h_p;
     universitet = u;
     ämnen = ä;
     merit_värde = m_v;






    }






   


 
    public float HpPoäng
    {
        get
         {
            return hpPoäng;
         }
        set
        {
            if (value <= 0 || value >= 2.0f )
            {
                hpPoäng = value;
                Console.WriteLine("Talet måste vara mellan 0 och 2");
            }


           Console.WriteLine("Talet måste vara mellan 0 och 2");
        }


    }


    public float Merit_värde
    {
        get
        {
            return merit_värde;
        }
        set
        {
              if (value <= 0 || value >= 22.5f  )
              {
                Console.WriteLine("Dit meritvärde kan bara vara mellan 0 och 22.5");
              }


              else
               value = merit_värde;
        }
   
    }


    public string  Universitet
    {
       
        get
        {
            return universitet;
        }


        set
        {
             
            universitet = value;
        }
    }




   public string Ämnen
   {
     get
        {
            return ämnen;
        }


    set
    {
        ämnen = value;
    }
   }
 
       


    }




class Personlista
  {


    private List<PersonR> personlista = new List<PersonR>();




    public void nyPersonR()
    {


      string nyttUniversitet;
      float nyMerit;
       float nyHp_Poäng;
       string nyttämne;


 Console.Write("vad är dina högskolepoäng: ");
        float nyHp_Poäng = float.Parse(Console.ReadLine());


Console.Write("Vilka är dina favorti ämnen av dessa: Kemi, Ekonomi, Kultur, Teknologi, Designe, Samhällsvetenskap, Juridik, Matematik, Biologi, Fysik, Geograf, Språk");
        string nyttämnen = Console.ReadLine();


Console.WriteLine("Vilket universite vill du studera på av dessa: Uppsala Universitet, Lunds Universitet, Chalmers, Göteborsg Universitet, Kungliga Tekniska Högskolan, Stockholms Univervistet, Umeå Universitet, Linköpings Universitet, Karolinska institutet, Luleå Tekniska Högskola, Karlstads Universitet, Linnéuniversitet, Örebro Universitet, Mittuniversitet, Malmö Universitet, Märladalens Universitet, Sveriges Landbruksuniversitet" );
        string nyttUniveristet2 = Console.ReadLine();


Console.WriteLine("Vad är ditt merit värde?");
         float nymerit = float.Console.ReadLine();
 
    }
  }
 








 
