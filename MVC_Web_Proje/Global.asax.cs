using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MVC_Web_Proje
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        /*
        Application_Start : Uygulama ilk kez çalıştırıldığında bir defaya mahsus olmak üzere çalışır.

        Application_Error : Uygulama içinde istenmeyen bir hata meydana geldiğinde çalışır.

        Application_BeginRequest : Serverden her istek yapıldığında çalışır.

        Application_EndRequest : Serverden her istek yapılıp sonlandıktan sonra çalışır.

        Application_PreSendRequestHeaders : Başlık bilgileri tarayıcıya gönderilmeden önce çalışır.

        Application_PreRequestContent : İçerik bilgileri tarayıcıya gönderilmeden önce çalışır.

        Application_AuthenticationRequest : Kullanıcı kimlik doğrulaması yapılmadan hemen önce çalışır.

        Application_AuthorizeRequest : Kullanıcı yetkilendirmesinden önce çalışır.
        */
    }
}
