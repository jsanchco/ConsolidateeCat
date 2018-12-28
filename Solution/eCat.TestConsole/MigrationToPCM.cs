// ReSharper disable InconsistentNaming
namespace eCat.TestConsole
{
    #region Using

    using Repository;
    using Service.Services;
    using System.IO;
    using System.Collections.Generic;
    using Data.VMEntities;
    using System;
    using System.Diagnostics;
    using Data.Entities;

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

            var stopWatch = new Stopwatch();
            stopWatch.Start();
            var linesCSV = new List<string>();
            var listFichasBaseARG = _fichasBaseService.GetByIdPais(country, true, false);
            foreach (var fichaBase in listFichasBaseARG)
            {
                var vm_PCMFichasBase = new VM_PCMFichasBase(fichaBase);

                if (!string.IsNullOrEmpty(vm_PCMFichasBase.LineaDeProducto))
                {
                    var serviceE2Lineasproductos = new ServiceE2Lineasproductos(new RepositoryE2Lineasproductos());
                    vm_PCMFichasBase.LineaDeProducto = serviceE2Lineasproductos
                        .GetByCOD_LineaP(vm_PCMFichasBase.LineaDeProducto).IdLineaP.ToString();
                }

                linesCSV.Add(vm_PCMFichasBase.ToCSV());
            }
            stopWatch.Stop();

            File.WriteAllLines(nameFile, linesCSV);

            var ts = stopWatch.Elapsed;
            Console.WriteLine($"Export {linesCSV.Count} products to IdPais ({country}) [{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}.{ts.Milliseconds / 10:00}]");
        }

        public void ProcessQ(short country)
        {
            var nameFile = $"..\\Migration\\Migration_{country}.csv";
            Console.WriteLine($"Init export to IdPais ({country}) ...");

            if (File.Exists(nameFile))
                File.Delete(nameFile);

            var stopWatch = new Stopwatch();
            stopWatch.Start();
            var linesCSV = new List<string>();
            var listFichasBaseARG = _fichasBaseService.GetByIdPaisQ(country, true, false);
            foreach (FichasBase fichaBase in listFichasBaseARG)
            {
                var vm_PCMFichasBase = new VM_PCMFichasBase(fichaBase);

                if (!string.IsNullOrEmpty(vm_PCMFichasBase.LineaDeProducto))
                {
                    var serviceE2Lineasproductos = new ServiceE2Lineasproductos(new RepositoryE2Lineasproductos());
                    vm_PCMFichasBase.LineaDeProducto = serviceE2Lineasproductos
                        .GetByCOD_LineaP(vm_PCMFichasBase.LineaDeProducto).IdLineaP.ToString();
                }

                linesCSV.Add(vm_PCMFichasBase.ToCSV());
            }
            stopWatch.Stop();

            File.WriteAllLines(nameFile, linesCSV);

            var ts = stopWatch.Elapsed;
            Console.WriteLine($"Export {linesCSV.Count} products to IdPais ({country}) [{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}.{ts.Milliseconds / 10:00}]");           
        }
    }
}
