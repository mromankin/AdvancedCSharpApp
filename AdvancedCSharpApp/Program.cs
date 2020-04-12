using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpApp
{
    delegate char NoArgsdDelegate();

    class Program
    {

        class Base
        {
            public string text;
            private NoArgsdDelegate method;

            public NoArgsdDelegate Method
            {
                get { return method; }
            }

            public Base(string text_, bool flag_)
            {
                text = text_;

                if (flag_)
                {
                    method = delegate ()
                    {
                        if (!String.IsNullOrEmpty(text))
                        {
                            return text[0];
                        }
                        else
                        {
                            return '_';
                        }
                    };
                }
                else
                {
                    method = () => text[text.Length - 1];
                }
            }
        }

        static void Main(string[] args)
        {
            Base objA = new Base("Мама мыла раму", true);
            Console.WriteLine("objA.Method = {0}", objA.Method());
            Base objB = new Base("Мама мыла раму", false);
            Console.WriteLine("objB.Method = {0}", objB.Method());
        }
    }
}
