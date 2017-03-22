using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_AnonymousFunction_method
{
    class Program
    {

        public delegate int Mydelegate(int a);

        static void Main(string[] args)
        { // Mydelegate A = new Mydelegate( 
          //                                   this is inline your function delcaration - 
          //                                delegate (int a) 
          //                                {
          //                                    your method code 
          //                                        return a * a; 
          //                                 });
            Mydelegate A = new Mydelegate(
                                            delegate (int a) 
                                            {
                                                return a * a;
                                            });
            //call the delegate
            Console.WriteLine(A(3));
        }
    }
}
