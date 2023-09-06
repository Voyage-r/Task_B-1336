using JsonParser.Interfaces;

namespace JsonParser
{
    /// <summary>
    /// Класс считывающий с файла JSON в строку
    /// </summary>
    public class JsonReaderFromFile : IJsonReader
    {
        /// <summary>
        /// Путь файла с данными
        /// </summary>
        private readonly string filePath = "C:\\Users\\Volch\\source\\repos\\JsonParser\\JsonParser\\Devices.json";

        /// <summary>
        /// Считывает данные из json файла в строку
        /// </summary>
        public string ReadData()
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                return reader.ReadToEnd();
            }  
        }
    }
}
