using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Texnomic.NMap.Scanner.Extensions
{
    public static class Serialization
    {
        public static T Deserialize<T>(string Xml)
        {
            using (var Stream = new MemoryStream(Encoding.UTF8.GetBytes(Xml)))
            {
                return Deserialize<T>(Stream);
            }
        }

        public static T DeserializeFromFile<T>(string FilePath)
        {
            using (var Stream = new StreamReader(FilePath))
            {
                var Result = (T)new XmlSerializer(typeof(T), new XmlRootAttribute("nmaprun")).Deserialize(Stream);
                return Result;
            }
        }

        public static string Serialize<T>(this T Item)
        {
            return serialize(Item);
        }

        public static void SerializeToFile<T>(this T Item, string FilePath)
        {
            string Result = serialize(Item);
            File.WriteAllText(FilePath, Result);
        }

        private static T Deserialize<T>(Stream Stream)
        {
            var Result = (T)new XmlSerializer(typeof(T)).Deserialize(Stream);
            return Result;
        }

        private static string serialize<T>(T Item)
        {
            var Stream = new MemoryStream();
            using (var XmlWriter = new XmlTextWriter(Stream, Encoding.UTF8))
            {
                var Serializer = new XmlSerializer(typeof(T));
                Serializer.Serialize(XmlWriter, Item);
                Stream = (MemoryStream)XmlWriter.BaseStream;
            }
            var Result = new UTF8Encoding().GetString(Stream.ToArray());
            Stream.Dispose();
            return Result;
        }
    }
}