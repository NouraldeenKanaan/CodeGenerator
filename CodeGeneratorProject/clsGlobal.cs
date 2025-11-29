using System;
using System.Windows.Forms;

namespace CodeGenerator
{
    public static class clsGlobal
    {
        public static string CurrentDatabaseName;
        public static string ConnectionString;
        public static void CurrentDatabase(string name)
        {
            CurrentDatabaseName = name;

            ConnectionString = $"Server=.;Database={name};User id=sa;password=sa12345";
        }

    }
}
