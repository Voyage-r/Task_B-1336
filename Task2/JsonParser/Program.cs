using JsonParser;
using JsonParser.Models;
using Newtonsoft.Json;

/// <summary>
/// Список серийных номеров устройств
/// </summary>
List<string> serialNumvers = new List<string>();

/// <summary>
/// Список серийных номеров устройств
/// </summary>
List<Conflict> conflicts = new List<Conflict>();

//Логика определения групп приборов
//Считывание данных
var JsonData = new JsonReaderFromFile();
List<DeviceInfo> devices = JsonConvert.DeserializeObject<List<DeviceInfo>>(JsonData.ReadData());

//Сортировка устройств
foreach (var group in devices.GroupBy(d => d.Brigade.Code).Where(g => g.Count() > 1 && g.Any(y => y.Device.IsOnline)))
{
    foreach (var device in group)
    {
        serialNumvers.Add(device.Device.SerialNumber);
    }

    // Создание объекта Conflict для записи в файл
    Conflict conflict = new Conflict
    {
        BrigadeCode = group.Key,
        DevicesSerials = serialNumvers.ToArray()
    };
    conflicts.Add(conflict);
}

//Запись данных
var jsonWriteToFile = new JsonWriterToFile(conflicts);
jsonWriteToFile.WriteData();