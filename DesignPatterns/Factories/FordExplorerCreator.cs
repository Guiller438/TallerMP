using DesignPatterns.Infraestructure.FactoryMethod;
using DesignPatterns.Infraestructure.ModelBuilder;
using DesignPatterns.Models;

namespace DesignPatterns.Factories
{
    public class FordExplorerCreator : ICreate
    {
        public Vehicle Create()
        {
            var builder = new CarModelBuilder();
            return builder.setModel("Explorer").setColor("Black").Build();

        }
    }
}
