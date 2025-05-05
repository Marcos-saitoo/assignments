using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace Alunos.entities
{
    public class AlunoETEC (string name, int year,int hours)
    {
    public string Name {get; protected set;} = name;
    public int Year {get; protected set;} = year;
        
    public int Hours {get; protected set;} = hours;

 
    }
       public class AlunoAMS  : AlunoETEC 
       {
        public int hoursm = 200;
        public AlunoAMS (string name,int year, int hours) : base(name,year,hours){
        }
    
       }
    

}
