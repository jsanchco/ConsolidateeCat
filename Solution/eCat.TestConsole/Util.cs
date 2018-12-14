namespace eCat.TestConsole
{
    #region Using

    using Repository;
    using Service.Services;
    using Data.Entities;
    using System;

    #endregion

    public class Util
    {
        public static bool AddGeneroTerror()
        {
            Console.WriteLine("Add Genero -> 'Terror' ...");
            var serviceTGeneroes = new ServiceTGeneroes(new RepositoryTGeneroes());

            if (serviceTGeneroes.SaveTGenero(new TGenero {IdGenero = 25, Descripcion = "Terror"}) == null)
            {
                Console.WriteLine("Error!!!!");
                return false;
            }

            Console.WriteLine("OK");
            return true;
        } 
    }
}
