// ReSharper disable InconsistentNaming
namespace eCat.TestConsole
{
    #region Using

    using System;

    #endregion

    class Program
    {
        static void Main()
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("*         Process Migration         *");
            Console.WriteLine("*************************************");
            Console.WriteLine("");
            Console.WriteLine("Press any key to start ...");
            Console.ReadLine();

            var migrationToPCM = new MigrationToPCM();
            migrationToPCM.ProcessQ(4);

            migrationToPCM.Process(4);
            migrationToPCM.ProcessQ(4);

            //Util.AddGeneroTerror();
            //Util.CodificacionJerarquias();

            Console.WriteLine("");
            Console.WriteLine("Press any key to exit ...");
            Console.ReadLine();
        }
    }
}
