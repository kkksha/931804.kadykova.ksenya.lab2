using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Class
    {        
        public int first { get; set; }
        public int second { get; set; }

        public Class(){
            Random rnd = new Random();
            first = rnd.Next(0, 10);
            second = rnd.Next(0, 10);
        }

        public int Add() { return first + second; }
        public int Sub() { return first - second; }
        public int Mult() { return first * second; }

        public int Div(){
            if (second == 0) return 0; 
            else return first / second;
        }
    }
}
