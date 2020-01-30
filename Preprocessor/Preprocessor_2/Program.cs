#define DEBUG


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preprocessor_2
{
#pragma warning disable 414,3021
    [CLSCompliant(false)]
    class Program
    {
        static void Main(string[] args)
        {

//#if DEBUG
//#warning DEBUG is defined
//#line 200 "Special" //行號 文件名
//            //#error Error !
//#endif

//#line default //恢復到默認行數
//#warning I'm not happy

//#pragma checksum "filename" "{guid}" "check bytes"
        }
    }

#pragma warning restore 3021
    [CLSCompliant(false)]
    public class D {
        int i = 1;
        public static void M() {

        }
    }
}
