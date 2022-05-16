using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    /// <summary>
    /// Customer is An class wheather declare a methods property and Constructors
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Gets or Sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or Sets the Name.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Name
        {
            get;
            set;
        }

        ///<summery>
        /// <see cref="Reflection.Customer"/>
        /// </summery>
        /// <param name="id">The identifie</param>>
        /// <param name="name">The identifie</param>>
        public Customer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        ///<summary>
        ///prints the identifier.
        ///</summary>
        public void PrintId()
        { 
        Console.WriteLine("Id is "+this.Id);
        }
        ///<summary>
        ///prints the name.
        ///</summary>
        public void PrintName()
        {
            Console.WriteLine("Name is :->" + this.Name);
        }
        public static void Test()
        { 
        Type type = Type.GetType("Reflection.Customer");
            Console.WriteLine("FullName is :" +type.FullName);
            Console.WriteLine("class Name is :" + type.Name);
            Console.WriteLine("Methods in Customer Class");
            ////storing the number of methods in an Array which ifs of method info class.
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            { 
            Console.WriteLine(method.ReturnType.Name+" "+method.Name);
            }
            Console.WriteLine("properties in customer class");
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo propertie in properties)
            {
                Console.WriteLine(propertie.PropertyType.Name + " " + propertie.Name);
            }
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            { 
            Console.WriteLine(constructor.ToString());
            }

        }
    }
}
