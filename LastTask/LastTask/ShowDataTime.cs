using System;

namespace LastTask
{
    class ShowDataTime
    {
        public void DTShow()
        {
            Type t = typeof(DateTime);
            foreach (var prop in t.GetProperties())
                Console.WriteLine(prop.Name);
            Console.ReadKey();
        }
    }
}
