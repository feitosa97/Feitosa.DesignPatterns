using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Feitosa.DesignPatterns2.Adapter
{
    public class XmlGenerator
    {
        public string Generate(object o) 
        {
            var serializer = new XmlSerializer(o.GetType());
            var writer = new StringWriter();
            serializer.Serialize(writer, o);
            return writer.ToString();
        }
    }
}
