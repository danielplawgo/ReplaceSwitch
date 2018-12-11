using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReplaceSwitch.Formatters;

namespace ReplaceSwitch
{
    public class ReportProcessorWithoutSwitch : IReportProcessor
    {
        private IEnumerable<IFormatter> _formatters;

        public ReportProcessorWithoutSwitch(IEnumerable<IFormatter> formatters)
        {
            _formatters = formatters;
        }

        public void Process(Report report)
        {
            var formatter = _formatters.FirstOrDefault(f => f.Format == report.ExportFormat);

            if (formatter == null)
            {
                throw new Exception("Not supported report formatter.");
            }

            formatter.Export(report);
        }
    }
}
