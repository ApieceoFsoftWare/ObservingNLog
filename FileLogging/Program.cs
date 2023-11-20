using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLogging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Logger = NLog.LogManager.GetCurrentClassLogger();
            // Config'deki event'ımız Info idi o yüzden burada info olarak çağırıyoruz...
            Logger.Log(LogLevel.Info, $"Proje Başladı {DateTime.Now.ToString("dd.MM.yyyy hh:ss")}"); 
            
            Logger.Log(LogLevel.Warn, $"Proje Uyarı Mesajı"); 
            
            Logger.Log(LogLevel.Info, $"Proje Bitti {DateTime.Now.ToString("dd.MM.yyyy hh:ss")}"); 

            /*
             * Bu şekilde log'lama işlemi yapmış olduk... 
             * Bu log dosyalarını bu projenin exe'sini bulunduğu dizinde logs klasörü altında bulabilirsin.
             * NLog Config'de sen de kendi loglarını ayarlamak için denemeler yapabilirsin...
             */
        }
    }
}
