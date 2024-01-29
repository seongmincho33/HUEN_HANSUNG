using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RegistryViewer2023
{
    // Custom attribute to mark a property as the primary key
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class PrimaryKeyAttribute : Attribute
    {
    }

    // Custom attribute to mark a property as unique
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class UniqueAttribute : Attribute
    {
    }

    public static class DataTableFactory
    {
        public static DataTable CreateFromModel<T>() where T : class, new()
        {
            DataTable table = new DataTable(typeof(T).Name);
            DataColumn[] primaryKeys;
            var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var primaryKeyList = new List<DataColumn>();

            foreach (var prop in properties)
            {
                Type columnType = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
                DataColumn column = new DataColumn(prop.Name, columnType)
                {
                    AllowDBNull = prop.GetCustomAttribute<RequiredAttribute>() == null,
                    Unique = prop.GetCustomAttribute<UniqueAttribute>() != null
                };

                table.Columns.Add(column);

                // Check if this property is marked with the PrimaryKey attribute
                if (prop.GetCustomAttribute<PrimaryKeyAttribute>() != null)
                {
                    primaryKeyList.Add(column);
                }
            }

            primaryKeys = primaryKeyList.ToArray();
            if (primaryKeys.Length > 0)
            {
                table.PrimaryKey = primaryKeys;
            }

            return table;
        }
    }

}
