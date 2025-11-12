using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerCounterApp.Domain
{
    internal class Player
    {
        private string _name;
        private int _age;
        private static int _counter = 0;

        public Player(string name, int age)
        {
            _age = age;
            _name = name;
            _counter += 1;
        }

        public int Counter { 
        
          get  { return _counter; }
        }
        public int Age {
            get { 
             return _age;
            }
        
        }
        public string Name { 
            get { return _name; }
        
        }




    }
}
