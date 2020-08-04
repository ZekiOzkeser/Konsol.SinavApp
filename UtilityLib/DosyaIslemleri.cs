using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityLib
{
    public class DosyaIslemleri
    {
        public static void DosyaKaydet(string path, string msg)
        {//.Net Managed Code:.Netin bellek yönetimini bizim yerimeze yapmasıdır. 
            //Type Safety:tip güvenliği 
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Append))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.Write(msg);
                        fs.Flush();
                        sw.Close();
                        fs.Close();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

        }


    }
}
