using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Test
{
    class Writer//добавить конструкторы
    {
        /// <summary>
        /// путь для сохранения логов проверяется каждый раз при вызове метода WriteLog..
        /// </summary>
        /// <param name="errorname"></param>
        /// <returns></returns>
        public string CreateOrOpenPath(string errorname)
        {
            if (!Directory.Exists(@".logs"))
                Directory.CreateDirectory(@".logs");//Test\Test\bin\Debug\net5.0
            if (!Directory.Exists($".logs\\{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}"))
                Directory.CreateDirectory($".logs\\{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}");
            if(errorname == "error")
                return $".logs\\{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}\\error.txt";
            else return $".logs\\{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}\\info.txt";
        }

        public void WriteLog(string path, string message_type, string message = null, Exception e = null,
            Dictionary<object, object> properties = null)
        {
            using (StreamWriter wr = new StreamWriter(CreateOrOpenPath(path), true, Encoding.Default))
            {
                wr.WriteLine($"{DateTime.Now} {message_type}: {message}");
            }
        }
    }
}
