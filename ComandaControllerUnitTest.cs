using APIBarDG1.Controllers;
using APIBarDG1.Model;
using APIBarDG1.Service.ComandaService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace web_api_tests
{
    public class ComandaControllerUnitTest
    {

        [Fact]
        public async Task TestPostStockItemAsync()
        {
            var dbContext = DbContextMocker.GeComandaImportersDbContext(nameof(TestPostStockItemAsync));
            var controller = new ComandaController(dbContext, null);
            var request = new  Comanda
            {
                IdComanda = 100,
                IdComandaItens = 100,
                PromocaoAguaPedidos = 0,
                PromocaoAguaRestantes = 0
            };

            //ComandaController comandaController = new ComandaController(dbContext, icontrolaComanda);
            ComandaController comandaController = new ComandaController();

            Comanda comanda = new Comanda();
            comanda  = comandaController.RegistraItemComanda(1, "Cerveja", false);

            dbContext.Dispose();

            Assert.False(comanda.Equals(null));

        }


    }
}
