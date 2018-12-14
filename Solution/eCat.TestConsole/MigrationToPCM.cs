// ReSharper disable InconsistentNaming
namespace eCat.TestConsole
{
    #region Using

    using System.Linq;
    using Repository;
    using Service.Services;
    using System.IO;
    using System.Collections.Generic;
    using Data.VMEntities;
    using System;

    #endregion

    public class MigrationToPCM
    {
        private readonly ServiceFichasBase _fichasBaseService;        

        public MigrationToPCM()
        {
            _fichasBaseService = new ServiceFichasBase(new RepositoryFichasBase());
        }

        public void Process(short country)
        {
            var nameFile = $"..\\Migration\\Migration_{country}.csv";
            Console.WriteLine($"Init export to IdPais ({country}) ...");

            if (File.Exists(nameFile))
                File.Delete(nameFile);            

            var linesCSV = new List<string>();
            var listFichasBaseARG = _fichasBaseService.GetByIdPais(country, false).ToList();
            foreach (var fichaBase in listFichasBaseARG)
            {
                var vm_PCMFichasBase = new VM_PCMFichasBase(fichaBase);
                linesCSV.Add(vm_PCMFichasBase.ToCSV());
            }

            File.WriteAllLines(nameFile, linesCSV);

            Console.WriteLine($"Export {linesCSV.Count} products to IdPais ({country})");
        }
    }
}
