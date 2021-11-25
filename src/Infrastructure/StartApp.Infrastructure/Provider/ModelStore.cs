using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;

namespace StartApp.Infrastructure.Provider
{
    internal class ModelStore
    {
        private readonly Type[] _modelTypes;

        public ModelStore()
        {
            var domainAssembly = GetType().Assembly;

            _modelTypes = domainAssembly.GetExportedTypes()
                .Where(x => !x.IsInterface && x.GetCustomAttribute<TableAttribute>() != null)
                .ToArray();
        }

        public IEnumerable<Type> GetModels()
        {
            return _modelTypes;
        }
    }
}