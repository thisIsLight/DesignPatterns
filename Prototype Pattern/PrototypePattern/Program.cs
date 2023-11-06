using PrototypePattern.CloneableObjectCopy;
using PrototypePattern.ConstructorObjectCopy;
using PrototypePattern.CustomInterfaceObjectClone;
using PrototypePattern.FaultyObjectClone;
using PrototypePattern.GenericInterfaceObjectCopy;
using PrototypePattern.SerializerObjectCopy;

namespace PrototypePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Why Prototype ?
            // Basically building an object from another object.
            // Motivation is deepCopy and shallow Copy
            // Without Prototype Pattern : 
            FaultyCopy.Init();

            //To resolve this we can introduce ICloneable Interface
            //Comes with a little headache since : 
            //Returns object so we need to keep typecasting it
            //Return a shallow clone sometimes.
            CloneableCopy.Init();

            //Copy Constructors : A C++ construct
            //We create a constructor that returns the object type itself
            //Not very prominent in C3 development community
            ConstructorCopy.Init();

            //Custom ICloneable Interface
            //Create own ICLoaneable and make it to do deep copy
            CustomInterfaceCopy.Init();
            //We can also use it for inheritance but the issue is that code repetition will be sen throughout the 
            //inheritance tree
            CustomInterfaceCopy.InitInheritance();

            //Custom ICloneable without code rewrite and generics
            GenericInterfaceCopy.Init();

            //Using Serialize Clone which is majorly used in industry
            SerializerCopy.Init();


        }
    }
}