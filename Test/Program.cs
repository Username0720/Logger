using System;
using System.IO;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!Directory.Exists(@".logs"))
                Directory.CreateDirectory(@".logs");//Test\Test\bin\Debug\net5.0

            string path = $"{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}";

            if (!Directory.Exists($".logs\\{path}"))
                Directory.CreateDirectory($".logs\\{path}");

            ILog log = new Log();
            log.Fatal("fatal");
            Exception e = new Exception("exception");
            log.Fatal("fatal", e);
            log.Error("error");
            log.Error("error", e);
            log.Error(e);
            log.ErrorUnique("error", e);
            log.Warning("warning");
            log.Warning("warning", e);
            log.WarningUnique("warning");
            log.Info("info");
            log.Info("info", e);
            log.Info("info", args);
            log.Debug("debug");
            log.Debug("debug", e);
            log.DebugFormat("debug", args);
            log.SystemInfo("info");
        }
    }
}
