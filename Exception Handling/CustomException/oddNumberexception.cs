using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace CustomException
{
    class oddNumberexception : Exception
    {
        public override string Message
        {
            get{ 
                return "Number is not odd";
            }
            
        }
    }
}
