using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder;
namespace ConcreteBuilder
{
    public class ConcreteBuilder1 : IBuilder
    {
        private readonly Product _product = new Product();

        public void BuildPartA()
        {
            _product.Add("PartA");
        }

        public void BuildPartB()
        {
            _product.Add("PartB");
        }

        public void BuildPartC()
        {
            _product.Add("PartC");
        }


        public Product GetResult()
        {
            return _product;
        }
    }
    public class ConcreteBuilder2 : IBuilder
    {
        private readonly Product _product = new Product();

        public void BuildPartA()
        {
            _product.Add("PartX");
        }

        public void BuildPartB()
        {
            _product.Add("PartY");
        }

        public void BuildPartC()
        {
            _product.Add("PartZ");
        }

        public Product GetResult()
        {
            return _product;
        }
    }
}
