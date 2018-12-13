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

        #region Constants
              
        private const string _FILE_MIGRATION_ARG = @"..\Migration\MigrationARG.csv";
        private const int _PAIS_ARG = 4;

        #endregion

        public MigrationToPCM()
        {
            _fichasBaseService = new ServiceFichasBase(new RepositoryFichasBase());
        }

        public void ProcessARG()
        {
            Console.WriteLine($"Init export to IdPais ({_PAIS_ARG}) ...");

            if (File.Exists(_FILE_MIGRATION_ARG))
                File.Delete(_FILE_MIGRATION_ARG);            

            var linesCSV = new List<string>();
            var listFichasBaseARG = _fichasBaseService.GetByIdPais(_PAIS_ARG, false).ToList();
            foreach (var fichaBase in listFichasBaseARG)
            {
                var vm_PCMFichasBase = new VM_PCMFichasBase(fichaBase);
                linesCSV.Add(vm_PCMFichasBase.ToCSV());
            }

            File.WriteAllLines(_FILE_MIGRATION_ARG, linesCSV);

            Console.WriteLine($"Export {linesCSV.Count} products to IdPais ({_PAIS_ARG})");
        }
    }
}
