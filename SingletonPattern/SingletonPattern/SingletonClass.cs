using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class SingletonClass
    {
        public static int i=0;

        private static SingletonClass instance;
        private SingletonClass()
        {

        }

        public static SingletonClass getInstance()
        {

            if (instance == null) {

                instance = new SingletonClass();
                i = i + 1;

            }

            return instance;

        }

    }


}
