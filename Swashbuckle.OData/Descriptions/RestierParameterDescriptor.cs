using System;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Web.Http;
using System.Web.Http.Controllers;
using Swashbuckle.Swagger;

namespace Swashbuckle.OData.Descriptions
{
    internal class RestierParameterDescriptor : HttpParameterDescriptor
    {
        public RestierParameterDescriptor(Parameter parameter)
        {
            Contract.Requires(parameter != null);

            Parameter = parameter;
            DefaultValue = null;
            Prefix = null;
            ParameterName = parameter.name;
            IsOptional = !parameter.required ?? false;
            ParameterType = parameter.GetClrType();
        }

        public Parameter Parameter { get; }

        public override string ParameterName { get; }

        public override Type ParameterType { get; }

        public override bool IsOptional { get; }

        public override Collection<T> GetCustomAttributes<T>()
        {
            return null;
        }

        public override object DefaultValue { get; }

        public override string Prefix { get; }

        public override ParameterBindingAttribute ParameterBinderAttribute { get; set; }
    }
}