using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceSwitch.Formatters
{
    public class XmlFormatter : IXmlFormatter
    {
        public ExportFormat Format { get; } = ExportFormat.Xml;
        public void Export(Report report)
        {
            Console.WriteLine($"XmlFormatter.Export: {report.Name}");
        }
    }

    public interface IXmlFormatter : IFormatter
    {

    }
}
