using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNLog.NetFramework
{
    class Worker
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public void DoStuff()
        {
            try
            {
                throw new Exception("Ongeldig beslagverzoek aangetroffen: bijlagen ontbreken. Laat Mark, Giel of Bas het maar oplossen...");
            }
            catch(Exception ex)
            {
                logger.Fatal(ex);

            }
        }
    }
}
