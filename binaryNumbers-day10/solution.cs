using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        List<int> list = new List<int>();
        int maxCount = 0;
        int counter = 0;
        
        for(int i=0; n>0; i++)      
        {  
         list.Add(n%2);            
         n= n/2;    
        }   
        
        int[] arr = list.ToArray();
        Array.Reverse(arr);
        
        
        for(int i=0 ; i<arr.Length ; i++)
        {
            if(arr[i]==1)
                counter +=1;
            else if (arr[i]==0)
            {
                if(counter>=maxCount)
                maxCount = counter;
                counter = 0;
            }
            
        }   
        
        Console.WriteLine(maxCount);   
    }
    
   
}
