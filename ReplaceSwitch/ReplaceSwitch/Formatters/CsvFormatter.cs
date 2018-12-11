using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceSwitch.Formatters
{
    public class CsvFormatter : ICsvFormatter
    {
        public ExportFormat Format { get; } = ExportFormat.Csv;

        public void Export(Report report)
        {
            Console.WriteLine($"CsvFormatter.Export: {report.Name}");
        }
    }

    public interface ICsvFormatter : IFormatter
    {
    }
}
