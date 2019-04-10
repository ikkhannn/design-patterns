using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory obj = new Factory();
            ICarDealer car=obj.createCars(0);
            car.getCar();
            ICarDealer car2 = obj.createCars(1);
            car2.getCar();
            Console.ReadKey();

        }
    }


    class Factory
    {


        int code;

      public  ICarDealer createCars(int code)
        {
            if (code ==0) {

                ICarDealer obj = new Honda();

                return obj;
            }
            if (code ==1)
            {
                ICarDealer obj = new Dodge();
                return obj;
            }

            return null;

        }


    }

    interface ICarDealer
    {
        string type
        {
            get;
        }

        void getCar();

    }

    class Honda : ICarDealer
    {
       public string type
        {
            get
            {
                return "regular";
            }
        }

        public void getCar()
        {
            Console.WriteLine("Honda");
        }
        



    }

    class Dodge : ICarDealer
    {
        public string type
        {
            get
            {
                return "sports";
            }
        }

        public void getCar()
        {
            Console.WriteLine("Dodge");
        }



    }





}
