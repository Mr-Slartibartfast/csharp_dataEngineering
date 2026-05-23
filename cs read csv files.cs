using CsvHelper;
using System.Globalization;

public class SalesRecord
{
    public int Id { get; set; }
    public string Product { get; set; }
    public decimal Amount { get; set; }
}

using var reader = new StreamReader("sales.csv");

using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

var records = csv.GetRecords<SalesRecord>();

foreach (var record in records)
{
    Console.WriteLine($"{record.Product} - {record.Amount}");
}