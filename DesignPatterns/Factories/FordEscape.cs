using DesignPatterns.Infraestructure.FactoryMethod;
using DesignPatterns.Infraestructure.ModelBuilder;
using DesignPatterns.Models;

namespace DesignPatterns.Factories
{
    public class FordEscape: ICreate
    {
        public Vehicle Create()
        {
            var builder = new CarModelBuilder();
            return builder.setModel("Escape").setBrand("Ford").setColor("Red").Build();
        }
    }
}
