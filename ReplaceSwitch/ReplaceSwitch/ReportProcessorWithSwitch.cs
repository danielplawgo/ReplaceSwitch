using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReplaceSwitch.Formatters;

namespace ReplaceSwitch
{
    public class ReportProcessorWithSwitch : IReportProcessor
    {
        private IXmlFormatter _xmlFormatter;

        private ICsvFormatter _csvFormatter;

        public ReportProcessorWithSwitch(IXmlFormatter xmlFormatter,
            ICsvFormatter csvFormatter)
        {
            _xmlFormatter = xmlFormatter;
            _csvFormatter = csvFormatter;
        }

        public void Process(Report report)
        {
            switch (report.ExportFormat)
            {
                case ExportFormat.Xml:
                    _xmlFormatter.Export(report);
                    break;
                case ExportFormat.Csv:
                    _csvFormatter.Export(report);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
