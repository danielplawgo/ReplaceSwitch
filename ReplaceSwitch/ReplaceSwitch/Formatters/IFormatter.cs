using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceSwitch.Formatters
{
    public interface IFormatter
    {
        ExportFormat Format { get; }

        void Export(Report report);
    }
}
