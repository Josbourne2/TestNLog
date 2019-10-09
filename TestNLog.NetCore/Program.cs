using System;

namespace TestNLog.NetCore
{
    class Program
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public static void Main(string[] Args)
        {
            try
            {
                Logger.Info("Hello world");
                Logger.Debug("Hello debug world");
                Logger.Error("Hello error world");
                Logger.Fatal("Hello fatal world");


                //Worker w = new Worker();
                //w.DoStuff();




            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Goodbye cruel world");
            }

            System.Console.ReadKey();
        }
    }
}
