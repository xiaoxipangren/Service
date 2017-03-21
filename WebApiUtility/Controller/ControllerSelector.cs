using GenericController.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;

namespace WebApiUtility.Controller
{
    public class ControllerSelector: DefaultHttpControllerSelector
    {
        private readonly HttpConfiguration configuration;
        private Dictionary<string, Type> entityMap;

        public ControllerSelector(HttpConfiguration configuration)
            : base(configuration)
        {
            this.configuration = configuration;
            entityMap = new Dictionary<string, Type>() { { "user",typeof(User)}, { "order",typeof(Order)} };

        }

        public override HttpControllerDescriptor SelectController(HttpRequestMessage request)
        {
            var controllerName = base.GetControllerName(request);

            Type entityType = null;
            if (!entityMap.TryGetValue(controllerName.ToLower(), out entityType))
            {
                return base.SelectController(request);
            }

            return new HttpControllerDescriptor(configuration, controllerName, typeof(Controllers.GenericController<>).MakeGenericType(entityType));
        }

    }
}