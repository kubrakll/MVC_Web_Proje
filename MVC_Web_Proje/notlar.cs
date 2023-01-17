using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Web_Proje
{
    public class notlar
    {
        /*
        Layaut Nedir ?
        MVC projelerinde sayfa içerisinde bulunan belirli kısımların sabitlenmesi Mastar Page yapısını kurmak için kullanılan yapıya Layout adı verilmektedir. Views/Shared içerisindedir.
        */

        /*
        Master Page Nedir ?
        Bir Master Page birden çok web formu barındıran bir şablondur aslında yani bir templatedir. Örneğin bir master page, her web sayfasında olan header, footer, navigation bar gibi elementleri barındırabilir ve bunu daha sonra tüm sayfalarımızda kullanabilmek için bize kolaylık sağlayabilir.
        */

        /*
        AssemblyInfo nedir?
        AssemblyInfo.cs , oluşturduğunuz uygulama hakkında genel bilgiler içerir, bu bilgilerden bazıları uygulamanızın başlığını, telif hakkını vb.içerir, örneğin uygulamanızın başlığı "MyApplication" ise, şöyle bir şey görmelisiniz: [assembly: AssemblyTitle("Uygulamam")]. Properties/AssemblyInfo.cs
        */
        /*
        App_Data Nedir ?
        App_Data, veritabanı dosyaları( .mdf ve xml dosyaları) olarak kullanılabilen dosyaları depolamak için kullanılır.
        */

        /*
        RouteConfig.cs dosyası, uygulama için yönlendirmeyi ayarlamak için kullanılır.
        FilterConfig.cs dosyası, bir eylem yöntemi yürütülmeden önce veya sonra yürütülecek özel mantık yazabileceğiniz özel bir sınıftır. Filtreler, bir eylem yöntemine veya denetleyiciye bildirimsel veya programlı bir şekilde uygulanabilir.
        BundleConfig.cs dosyası, performans isteği yükleme süresini iyileştirebiliriz . Küçültme, beyaz boşlukların kaldırılması, yorumların kaldırılması, büyük değişken adlarının küçüğe dönüştürülmesi vb. gibi gereksiz verilerin işlevselliğini değiştirmeden çıkarılması işlemidir
        */

        /*
        favicon.io
        Tarayıcıların bir tarayıcı sekmesinde bir sayfanın başlığının yanında reklamını yaptığı kısayol simgesidir.
        */

        /*
        Global.asax
        Global.asax dosyası tıpkı web.config dosyası gibi özel bir dosyadır ve sadece server üzerinde çalıştırılır yani dışarıdan çağrıldığında herhangi bir sayfa görüntülenmez. Örneğin, uygulamamız ilk çalıştırıldığında ya da server restart edildikten sonra ilk çalışan Application_Start yordamıdır.Uygulama ilk yüklendiğinde Application_Start yordamının çalışması Global.asax’da tanımlanmıştır. Yine en çok sık kullanılan yordamlardan Application_Error, herhangi bir istenmeyen bir hata meydana geldiğinde çalışır ve yine Global.asax’da tanımlıdır. 
        */

        /*
        Web.config
        Web.config dosyası aslında bir XML dosyasıdır ve içinde çeşitli yapılandırma ayarlarını barındırır.

        </entityFramework>
	    <connectionStrings>
		<add name="Context" connectionString="data source=PC1;initial catalog=nowhealthDB;integrated security=True;" providerName="System.Data.SqlClient" />
	    </connectionStrings>
    </configuration>
        */

    }
}