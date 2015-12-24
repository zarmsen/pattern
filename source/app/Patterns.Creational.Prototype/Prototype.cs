using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Patterns.Creational.Prototype
{
    [Serializable]
    public abstract class Prototype<T> where T : class
    {
        public T Clone()
        {
            return (T)MemberwiseClone();
        }

        public T DeepCopy()
        {
            T copy;
            var formatter = new BinaryFormatter();
            using (var stream = new MemoryStream())
            {
                formatter.Serialize(stream, this);
                stream.Seek(0, SeekOrigin.Begin);
                copy = (T)formatter.Deserialize(stream);
                stream.Close();
            }
            return copy;
        }
    }
}