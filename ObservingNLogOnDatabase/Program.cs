using NLog;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservingNLogOnDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Database Hazılanacak => SP // bu kodları proje dosyalarının içerisine koyacağım buradan bulabilirsin :D
             * App.Config (Database Yolu)
             * Nlog Paket Dosyaları
             * Nlog.Config
             * Loglama işlemini Test edeceğiz ...
             */
            
            
            // Bunu yapmamızın nedeni XML içerisinde kullanmak istememizden kaynaklanıyor :D
            string connectionString = ConfigurationManager.ConnectionStrings["Nlog"].ConnectionString;
            // Connection string içindeki {MachineName} ifadesini bilgisayar adı ile değiştir
            connectionString = connectionString.Replace("{MachineName}", Environment.MachineName);

            try
            {
                int sayi1 = 0;
                int sonuc = 10/sayi1;
            }
            catch (Exception ex)
            {
                Logger logger = LogManager.GetLogger("databaseLogger");
                logger.Error(ex.Message);
            }

        }
    }
}
