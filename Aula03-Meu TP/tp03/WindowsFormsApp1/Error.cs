using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Error
    {
        private static bool error;
        private static String mens;

        public static void setError(bool _error) { error = _error; }
        public static void setError(String _mens) { error = true; mens = _mens; }
        public static bool getError() { return error; }
        public static String getMens() { return mens; }
    }
}

