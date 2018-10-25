using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pat_02_01_Template_method
{
    interface ILogSaver
    {
        void UploadLogEnties(IEnumerable<LogEntry> logEntries);
        void UploadExceptions(IEnumerable<ExceptionLogEntry> exceptions);
    }
}
