using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceSwitch
{
    public interface IReportProcessor
    {
        void Process(Report report);
    }
}
