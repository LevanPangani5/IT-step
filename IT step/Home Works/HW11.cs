using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Collections;

namespace IT_step.Home_Works
{
    internal class HW11
    {
        /*
         //BenchmarkRunner.Run(typeof(Program).BaseType);
         BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run();
         */

        [MemoryDiagnoser]
        public class GenVsObject
        {
            [Benchmark]
            public ArrayList RandObject()
            {

                ArrayList objList = new();
                Random rand = new();
                for (int i = 0; i < 1000; i++)
                {
                    objList.Add(rand.Next(1, 40000));
                }

                return objList;
            }

            [Benchmark]
            public List<int> RandGen()
            {

                List<int> genList = new();
                Random rand = new();
                for (int i = 0; i < 1000; i++)
                {
                    genList.Add(rand.Next(1, 40000));
                }

                return genList;
            }
        }
    }
}
