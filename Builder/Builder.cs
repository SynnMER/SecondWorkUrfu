using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IBuilder
    {
        void BuildPartA();
        void BuildPartB();
        void BuildPartC();
        Product GetResult();
    }
    public class Product
    {
        private readonly List<string> wheels = new List<string>();

        public void Add(string wheel)
        {
            wheels.Add(wheel);
        }

        public void Show()
        {
            Console.WriteLine("\nProduct Wheels -------");
            foreach (string wheel in wheels)
                Console.WriteLine(wheel);
        }
    }
    public class Director
    {
        public void Construct(IBuilder _builder)
        {
            _builder.BuildPartA();
            _builder.BuildPartB();
            _builder.BuildPartC();
        }
    }
}
