using Xunit;
namespace Pyramid.Core;
    public class ClienteTests{
    [Fact]
        public void Cliente_Deve_Ter_Nome_Valido()
        {
            var cliente = new Cliente{ Nome = "João" };

            Assert.NotNull(cliente.Nome);
            Assert.NotEmpty(cliente.Nome);
        }

    }


