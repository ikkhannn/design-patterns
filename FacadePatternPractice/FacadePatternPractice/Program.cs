using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();
            facade.completeCar();
            Console.ReadKey();
        }
    }

    public class Engine
    {
       public void setEngine()
        {
            Console.WriteLine("Engine");
        }
    }
    
    public class Body
    {
        public void setBody() {
            Console.WriteLine("Body");
        }
    }

    public class Accessories
    {
        public void setAccessories()
        {
            Console.WriteLine("Accessories");
        }
    }



    public class Facade
    {

        public void completeCar()
        {
            Accessories accessories = new Accessories();
            Body body = new Body();
            Engine engine = new Engine();

            accessories.setAccessories();
            body.setBody();
            engine.setEngine();
        }



    }

}


