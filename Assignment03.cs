using System;
using doit_study_homework_template.testcase;
using System.Collections.Generic;

namespace doit_study_homework_template
{
    public class Assignment03 : TestCase03, IAssignment
    {
        /* Dont Touch */
        public bool isRunning { get;  set; }
        public Assignment03(bool _isRunning){
            isRunning = _isRunning;
        }
        /********************/
         public void main(){
            var inputs = input();
            var results = new List<int>();

            foreach (TestCase data in inputs){
                var numArr = data.numArr;
                var res = numArr[0];

                for(int i=1;i<numArr.Length;i++){
                    if(res<numArr[i]){
                        res=numArr[i];
                    }
                }
                Console.Write(res);
                results.Add(res);
            }

            output(results.ToArray());
        }
    }
}