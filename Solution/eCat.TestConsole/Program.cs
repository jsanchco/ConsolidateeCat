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
            Console.WriteLine("*****************************************");
            Console.WriteLine("*         Process Migration ARG         *");
            Console.WriteLine("*****************************************");
            Console.WriteLine("");
            Console.WriteLine("Press any key to start ...");
            Console.ReadLine();

            var migrationToPCM = new MigrationToPCM();
            migrationToPCM.ProcessARG();

            Console.WriteLine("");
            Console.WriteLine("Press any key to exit ...");
            Console.ReadLine();
        }
    }
}
