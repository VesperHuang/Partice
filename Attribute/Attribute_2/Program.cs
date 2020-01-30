using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribute_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //透過反射 抓取 Class Attribute 訊息
            HelpAttribute helpAttribute;

            foreach (var attr in typeof(AnyClass).GetCustomAttributes(true)) {
                helpAttribute = attr as HelpAttribute;

                if (helpAttribute != null) {
                    Console.WriteLine("AnyClass Description:{0}", helpAttribute.Description);
                }
            }
            Console.ReadLine();
        }
    }

    [AttributeUsage(AttributeTargets.Class,AllowMultiple = false,Inherited = false)]
    public class HelpAttribute : Attribute {

        protected string description;

        public HelpAttribute(string description_in) {
            this.description = description_in;
        }

        public string Description {
            get {
                return this.description;
            }
        }

        public string Name {
            get;
            set;
        }
    }

    // value type , System.Type,object,enum
    [Help("this is a do-nothing class",Name ="帶參數")]
    public class AnyClass {

    }
}
