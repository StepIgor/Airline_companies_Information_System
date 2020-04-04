using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inf_system_airline_companies
{
    

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login()); //начинаем с окна входа
        }

        //глобальные переменные
        public static string opened_file = "<sample>";  //путь открытого файла
        public static Boolean anything_was_changed = false; //флаг для проверки сохранения изменений
        public static Boolean is_admin = false; //проверка прав админа

    }

    
}
