using APIBarDG1.Data;
using APIBarDG1.Model;
using System;
using System.Runtime.CompilerServices;
using APIBarDG1.Util.Enum;

namespace web_api_tests
{
    public static class DbContextExtensions
    {

        public static void SeedComanda(this ComandaContext dbContext)
        {
            // Add entities for DbContext instance

            dbContext.Comanda.Add(new Comanda
            {

                IdComanda = 1,
                IdComandaItens = 1,
                PromocaoAguaPedidos = 0,
                PromocaoAguaRestantes = 0
            }) ;

            dbContext.SaveChanges();
        }

        public static void SeedItemComanda(this ComandaItensContext dbContext)
        {
            dbContext.ComandaItens.Add(new ComandaItens
            {
                IdComanda = 2,
                NomeItem = EnumItens.Cerveja.ToString(),
                Precoitem = 5.00

            });

            dbContext.ComandaItens.Add(new ComandaItens
            {
                IdComanda = 2,
                NomeItem = EnumItens.Cerveja.ToString(),
                Precoitem = 5.00
            });

            dbContext.ComandaItens.Add(new ComandaItens
            {
                IdComanda = 2,
                NomeItem = EnumItens.Conhaque.ToString(),
                Precoitem = 20.00
            });

            dbContext.ComandaItens.Add(new ComandaItens
            {
                IdComanda = 2,
                NomeItem = EnumItens.Conhaque.ToString(),
                Precoitem = 20.00
            });

            dbContext.ComandaItens.Add(new ComandaItens
            {
                IdComanda = 2,
                NomeItem = EnumItens.Conhaque.ToString(),
                Precoitem = 20.00
            });

            dbContext.SaveChanges();
        }



    }

}
