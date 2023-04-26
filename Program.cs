 using System;  
using System.Linq;  
using System.Collections.Generic;  
  
class AA
{  
  
  
    static public void Main()  
    {  
   
        List<string> list = new List<string>()  
        {  
            " Hii JavaTpoint",  
            " Welcome to JavaTpoint ",  
            " The topic is LINQ ",  
            " Any Queries "  
  
        };  
          var k = list.Where(a=> a.Contains(" JavaTpoint "));  
          foreach(var i in k)  
        {  
            Console.WriteLine(i);  
        }  
        
        var r = from l in list  
                where l.Contains(" JavaTpoint")  
                select l;  
  

        foreach(var i in r)  
        {  
            Console.WriteLine(i);  
        }  
    }}


