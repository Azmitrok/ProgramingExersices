using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExersicesConsoleApp
{
    public class CSharp6
    {
        //Read-only auto-properties
        public string Name { get; }

        //Auto-property initializers
        public List<int> List1 { get; } = new List<int>();

        //Expression-bodied function members
        public string FullName => $"Name: {Name}";


        public void Method()
        {
            try
            {
                //Null - conditional operators
                string s = this?.Name;

                //String interpolation
                s = $"{this.Name} - name";

                var varName = nameof(s);
            }
            //Exception filters
            catch (Exception exc) when (exc.Message.Contains("some_word"))
            {
                throw;
            }
            catch (Exception exc)
            {
                var err = exc.Message;
            }
        }



    }
}
