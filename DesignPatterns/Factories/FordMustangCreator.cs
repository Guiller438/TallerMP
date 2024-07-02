using DesignPatterns.Infraestructure.FactoryMethod;
using DesignPatterns.Infraestructure.ModelBuilder;
using DesignPatterns.Models;

namespace DesignPatterns.Factories
{
    public class FordMustangCreator  : ICreate
    {
        public Vehicle Create()
        {
            var builder = new CarModelBuilder();
            return builder.setModel("Ford").setBrand("Mustang").Build();

        }
    }
}
