using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Logger
{
    private static Logger _instance;
    private string logFileName = "log.txt";

    private Logger()
    {
        // Ініціалізація логгера
    }

    public static Logger GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Logger();
        }
        return _instance;
    }

    public void Log(string message)
    {
        // Логування дій в файл
        using (StreamWriter writer = File.AppendText(logFileName))
        {
            writer.WriteLine(message);
        }
    }
}