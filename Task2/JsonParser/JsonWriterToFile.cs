using JsonParser.Interfaces;
using JsonParser.Models;
using System.Text.Json;

namespace JsonParser
{
    public class JsonWriterToFile : IJsonWriter
    {
        /// <summary>
        /// Массив отсортировочных данных
        /// </summary>
        private readonly List<Conflict> data;

        /// <summary>
        /// Путь сохранения файла
        /// </summary>
        private readonly string filePath = "myFile.json";

        public JsonWriterToFile(List<Conflict> data)
        {
            this.data = data;
        }

        /// <summary>
        /// Записывает полученные данные в json файл
        /// </summary>
        public void WriteData()
        {
            string conglictSerialized = JsonSerializer.Serialize(data);
            try
            {
                File.WriteAllText(filePath, conglictSerialized);
            }
            catch (Exception ex) 
            { 
                Console.WriteLine($"{ex}: Не удалось записать в файл"); 
            }

            Console.WriteLine("Данные успешно записаны");
        }
    }
}
