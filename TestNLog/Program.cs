using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TestNLog.NetFramework
{
    class Program
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public static void Main(string[] Args)
        {
            try
            {
                Logger.Info("Hello info world");
               // Thread.Sleep(1500);
                Logger.Debug("Hello debug world");
               // Thread.Sleep(1500);
                Logger.Error("Hello error world");
               // Thread.Sleep(1500);
                Logger.Fatal("Hello fatal world");
               // Thread.Sleep(1500);


                Worker w = new Worker();
                w.DoStuff();



                
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Goodbye cruel world");
            }

            System.Console.ReadKey();
        }
    }
}
