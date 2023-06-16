using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicExercises.ExercisesHelper
{
    public class Exercise1
    {

        public class Animal
        {
            public string? Name { get; set; }
            public List<string>? Habitats { get; set; }
        }

        public class GenericList<T>
        {
            public void DoSomething(T item)
            {
                if (item is double)
                    Console.WriteLine("Foo Number");
                else if (item is Animal)
                    Console.WriteLine("Foo Animal");
            }
        }
    }
}
