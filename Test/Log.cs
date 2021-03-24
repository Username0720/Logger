﻿using System;
using System.IO;
using System.Text;

namespace Test
{
    class Log : ILog
    {
        bool is_unique = false;
        bool is_warning = false;
        string errorpath = $".logs\\{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}\\error.txt";
        string infopath = $".logs\\{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}\\info.txt";
        void ILog.Fatal(string message)
        {
            using (StreamWriter wr = new StreamWriter(errorpath, true, Encoding.Default))
            {
                wr.WriteLine($"{DateTime.Now} Fatal: {message}");
            }
        }
        void ILog.Fatal(string message, Exception e)
        {
            using (StreamWriter wr = new StreamWriter(errorpath, true, Encoding.Default))
            {
                wr.WriteLine($"{DateTime.Now} Fatal: {message}, exception: {e}");
            }
        }
        void ILog.Error(string message)
        {
            using (StreamWriter wr = new StreamWriter(errorpath, true, Encoding.Default))
            {
                wr.WriteLine($"{DateTime.Now} error: {message}");
            }
            is_unique = true;
        }
        void ILog.Error(string message, Exception e)
        {
            using (StreamWriter wr = new StreamWriter(errorpath, true, Encoding.Default))
            {
                wr.WriteLine($"{DateTime.Now} error: {message}, exception: {e}");
            }
            is_unique = true;
        }
        void ILog.Error(Exception ex)
        {
            using (StreamWriter wr = new StreamWriter(errorpath, true, Encoding.Default))
            {
                wr.WriteLine($"{DateTime.Now} error exception: {ex}");
            }
            is_unique = true;
        }
        void ILog.ErrorUnique(string message, Exception e)
        {
            if (!is_unique)
            {
                using (StreamWriter wr = new StreamWriter(errorpath, true, Encoding.Default))
                {
                    wr.WriteLine($"{DateTime.Now} unique error: {message}, exception: {e}");
                }
            }
        }
        void ILog.Warning(string message)
        {
            using (StreamWriter wr = new StreamWriter(errorpath, true, Encoding.Default))
            {
                wr.WriteLine($"{DateTime.Now} warning: {message}");
            }
            is_warning = true;
        }
        void ILog.Warning(string message, Exception e)
        {
            using (StreamWriter wr = new StreamWriter(errorpath, true, Encoding.Default))
            {
                wr.WriteLine($"{DateTime.Now} warning: {message}, exception: {e}");
            }
            is_warning = true;
        }
        void ILog.WarningUnique(string message)
        {
            if (!is_warning)
                using (StreamWriter wr = new StreamWriter(errorpath, true, Encoding.Default))
                {
                    wr.WriteLine($"{DateTime.Now} unique warning: {message}");
                }
        }
        void ILog.Info(string message)
        {
            using (StreamWriter wr = new StreamWriter(infopath, true, Encoding.Default))
            {
                wr.WriteLine($"{DateTime.Now} info: {message}");
            }
        }
        void ILog.Info(string message, Exception e)
        {
            using (StreamWriter wr = new StreamWriter(infopath, true, Encoding.Default))
            {
                wr.WriteLine($"{DateTime.Now} info: {message}, exception: {e}");
            }
        }
        void ILog.Info(string message, params object[] args)
        {
            using (StreamWriter wr = new StreamWriter(infopath, true, Encoding.Default))
            {
                wr.WriteLine($"{DateTime.Now} info: {message}, {args}");
            }
        }
        void ILog.Debug(string message)
        {
            using (StreamWriter wr = new StreamWriter(errorpath, true, Encoding.Default))
            {
                wr.WriteLine($"{DateTime.Now} debug: {message}");
            }
        }
        void ILog.Debug(string message, Exception e)
        {
            using (StreamWriter wr = new StreamWriter(errorpath, true, Encoding.Default))
            {
                wr.WriteLine($"{DateTime.Now} debug: {message}, exception: {e}");
            }
        }
        void ILog.DebugFormat(string message, params object[] args)
        {
            using (StreamWriter wr = new StreamWriter(errorpath, true, Encoding.Default))
            {
                wr.WriteLine($"{DateTime.Now} debugformat: {message}, {args}");
            }
        }
        void ILog.SystemInfo(string message, System.Collections.Generic.Dictionary<object, object> properties)
        {
            using (StreamWriter wr = new StreamWriter(infopath, true, Encoding.Default))
            {
                wr.WriteLine($"{DateTime.Now} info: {message}, {properties}");
            }
        }
    }
}