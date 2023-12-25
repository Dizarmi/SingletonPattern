using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DbManager
{
    private static DbManager _instance;

    private DbManager()
    {
        // Ініціалізація бази даних
    }

    public static DbManager GetInstance()
    {
        if (_instance == null)
        {
            _instance = new DbManager();
        }
        return _instance;
    }

    // Додаткові методи для роботи з базою даних
}