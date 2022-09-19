using System;
using System.Collections.Generic;
using System.Text;

namespace IOC_DI.ConsoleApp
{
    interface IDAL
    {
        //  Dependency Inversion Principle DIP : (Bağımlılığı Tersine Çevirme İlkesi) 
        // Amaç : Uygulamamızdaki DAL ve BL classlarının arasına IDAL atarak DAL ve BL yi soyutladık.

        // IDAL oluşturularak BL ve DAL arasındaki bağımlılık azaltılmış oldu.
        // Biz IDAL üzerinden izin verdiğimiz ölçüde BL nin DAL dan haberi olacaktır.
        // Şimdilik sadece GetProducts metodunu bilmesini istedik bunu da IDAL üzerinde tanımladık bu kadarını biliyor.
        // DAL daki Hesapla metodunu bilemiyor çünkü IDAL da tanımlı değil.
        List<Product> GetProducts();

    }
}
