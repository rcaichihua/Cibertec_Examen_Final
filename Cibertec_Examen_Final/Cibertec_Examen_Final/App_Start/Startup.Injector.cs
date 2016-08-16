using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using LightInject;

namespace Cibertec_Examen_Final
{
    public partial class Startup
    {
        public void ConfigInjector()
        {
            var container = new ServiceContainer();
            container.RegisterAssembly(Assembly.GetExecutingAssembly());
            container.RegisterAssembly("WebDeveloper.DataAccess*.dll");
            container.RegisterAssembly("WebDeveloper.Model*.dll");
            //container.RegisterControllers();
            //container.EnableMvc();
        }
    }
}