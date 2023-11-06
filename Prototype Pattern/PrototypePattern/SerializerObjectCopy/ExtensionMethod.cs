using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.SerializerObjectCopy
{
    public static class ExtensionMethod
    {
        public static T DeepSerializeClone<T>(this T self)
        {
            var stream = new MemoryStream();
            var formatter = new BinaryFormatter();
            formatter.Serialize(stream, self);
            stream.Position = 0;
            object ds = formatter.Deserialize(stream);
            stream.Close();
            return (T) ds;
        }
    }
}
