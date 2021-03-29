using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Test
{
    class Log : ILog
    {
        List<string> error_name = new List<string>();
        List<string> warn_name = new List<string>();
        public Log()
        {

        }
        Writer wr = new Writer();
        void ILog.Fatal(string message)
        {
            wr.WriteLog("error", "фатальная ошибка", "непонятная ошибка");
        }
        void ILog.Fatal(string message, Exception e)
        {
            wr.WriteLog("error", "фатальная ошибка", "непонятная ошибка", e);
        }
        void ILog.Error(string message)
        {
            wr.WriteLog("error", "ошибка", "непонятная ошибка");
            error_name.Add(message);
        }
        void ILog.Error(string message, Exception e)
        {
            wr.WriteLog("error", "ошибка", "непонятная ошибка", e);
            error_name.Add(e.ToString());
        }
        void ILog.Error(Exception ex)
        {
            wr.WriteLog("error", "ошибка", "непонятная ошибка", ex);
            error_name.Add(ex.ToString());
        }
        void ILog.ErrorUnique(string message, Exception e)
        {
            if (!error_name.Contains(message))
            {
                wr.WriteLog("error", "фатальная ошибка", "непонятная ошибка");
            }
        }
        void ILog.Warning(string message)
        {
            wr.WriteLog("error", "фатальная ошибка", "непонятная ошибка");
            warn_name.Add(message);
        }
        void ILog.Warning(string message, Exception e)
        {
            wr.WriteLog("error", "фатальная ошибка", "непонятная ошибка", e);
            warn_name.Add(e.ToString());
        }
        void ILog.WarningUnique(string message)
        {
            if (!warn_name.Contains(message))
            {
                wr.WriteLog("error", "фатальная ошибка", "непонятная ошибка");
            }
        }
        void ILog.Info(string message)
        {
            wr.WriteLog("info", "info", "fajfhdaiuhsjkld;k");
        }
        void ILog.Info(string message, Exception e)
        {
            wr.WriteLog("info", "info", "fajfhdaiuhsjkld;k", e);
        }
        void ILog.Info(string message, params object[] args)
        {
            wr.WriteLog("info", "info", "fajfhdaiuhsjkld;k");
        }
        void ILog.Debug(string message)
        {
            wr.WriteLog("info", "info", "fajfhdaiuhsjkld;k");
        }
        void ILog.Debug(string message, Exception e)
        {
            wr.WriteLog("info", "info", "fajfhdaiuhsjkld;k");
        }
        void ILog.DebugFormat(string message, params object[] args)
        {
            wr.WriteLog("info", "info", "fajfhdaiuhsjkld;k");
        }
        void ILog.SystemInfo(string message, Dictionary<object, object> properties)
        {
            wr.WriteLog("info", "info", "fajfhdaiuhsjkld;k");
        }
    }
}
