

using System;

namespace WindowsForms
{
    public class Validation
    {
        public Validation() { }
        public bool Name(string s)
        {
            if (String.IsNullOrEmpty(s)) return false;
            else return true;
        }
        public bool Number(string s)
        {
            if (String.IsNullOrEmpty(s)) return false;
            try
            {
                int x = Convert.ToInt32(s);
                if (x <= 0) return false;
                else return true;
            }
            catch
            {
                return false;
            }
        }
    }
}