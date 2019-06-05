/* Disclaimer: The examples and comments from this program are from
   C#7 in a Nutshell and are written for learning purposes only. */
/* WARNING: Please do not compile this code. The visibility member 
 is not supported on console, and code will generate errors. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// THE USING NAMESPACE
/* The using directive imports a namespace, allowing you to refer to types
 without their fully qualified names. The following imports the 
 Outer.Middle.Inner example below. */
using Outer.Middle.Inner;

// USING STATIC (C#6)
/* You can import not just a namespace, but a specific type, with the
 using static directive. All static members of that type can then be used
 without being qualified with the type name. For example: */
using static System.Console;
/*The using static directive imports all accessible static members of the 
 type, including fields, properties, and nested types (CH.3) . You can also
 apply this directive to enum types (CH.3), in which case their members 
 are imported. For Example: */

 // FOLLOWING CODE DOESN'T WORK ON CONSOLE.
using static System.Windows.Visibility;
// We can specify Hidden instead of Visibility.Hidden:
var textBox = new TextBox { Visibility.Hidden }; //XAML-style
/*Should an ambiguity arise between multiple static imports, the C# compiler
 is not smart enough to infer the correct type from the context, and will
 generate an error. */

namespace Namespaces
{
    class Program
    {
        static void Main()
        {
            // NAMESPACES
            /* A namespace is a domain for type names. Types are typically
             organized into hierarchical namespaces, making them easier to
             find and avoiding conflicts. For example, the RSA type that
             handles public key encryption is defined within the following
             namespace: System.Security.Cryptography */
            /* A namespace forms an integral part of a type's name. The
             following code calls RSA's create method: */
            System.Security.Cryptography.RSA rsa =
              System.Security.Cryptography.RSA.Create();
            /* Namespaces are independent of assemblies, which are units
             of deployment such as an .exe or .dll. Namespaces also have 
             no impact on member visibility-public, internal, private,
             and so on. */

            // USING EXAMPLE
            Class1 c;   // Doesn't need fully qualified name.

            // USING STATIC EXAMPLE
            WriteLine("Hello"); // Doesn't need Console.
        }
    }
}
/* The namespace keyword defines a namespace for types within
   that block. For example: */
namespace Outer.Middle.Inner
{
    class Class1 { }
    class Class2 { }
}
/* The dots in the namespace indicate a hierarchy of nested namespaces.
  You can refer to a type with its fully qualified name, which includes 
  all namespaces from the outermost to the innermost. For example,
  we could refer to Class1 in the preceding example as 
  Outer.Middle.Inner.Class1. Types not defined in any namespace are said 
  to reside in the global namespace. The global namespace also includes
  top-level namespaces, such as Outer in our example. */

