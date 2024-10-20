using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Pizza
    {
        public abstract string GetDescription();
        public abstract double GetCost();
    }

    // Concrete Component
    public class PlainPizza : Pizza
    {
        public override string GetDescription()
        {
            return "Plain Pizza";
        }

        public override double GetCost()
        {
            return 5.00; // Base cost of the plain pizza
        }
    }

    // Decorator Base Class
    public abstract class ToppingDecorator : Pizza
    {
        protected Pizza _pizza;

        public ToppingDecorator(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override string GetDescription()
        {
            return _pizza.GetDescription();
        }

        public override double GetCost()
        {
            return _pizza.GetCost();
        }
    }

    // Concrete Decorators
    public class CheeseDecorator : ToppingDecorator
    {
        public CheeseDecorator(Pizza pizza) : base(pizza) { }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Cheese";
        }

        public override double GetCost()
        {
            return base.GetCost() + 1.00; // Adding cost for cheese
        }
    }

    public class PepperoniDecorator : ToppingDecorator
    {
        public PepperoniDecorator(Pizza pizza) : base(pizza) { }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Pepperoni";
        }

        public override double GetCost()
        {
            return base.GetCost() + 1.50; // Adding cost for pepperoni
        }
    }

}
