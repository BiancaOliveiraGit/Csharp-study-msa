using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Csharp
{
    public static class TaskExample
    {
        static public void SimpleTask()
        {
            Task t = Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    //Console.Write(i.ToString()); doing this really shows threads in action, running at different times
                    Console.Write("*");
                }
            });

            t.Wait();
        }

        static public void ContinueWithTask()
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;
            }).ContinueWith((i) =>
            {
                return i.Result * 2;
            });
            Console.WriteLine(t.Result);
        }

        static public void ChildWithTaskFactory()
        {
            Task<string[]> parent = Task.Run(() =>
            {
                var results = new string[3];

                TaskFactory tf = new TaskFactory(TaskCreationOptions.AttachedToParent, TaskContinuationOptions.ExecuteSynchronously);
                tf.StartNew(() => results[0] = "child 1"); //child 1
                tf.StartNew(() => results[1] = "child 2"); //child 2
                tf.StartNew(() => results[2] = "child 3"); //child 3
                return results;
            });

            var finalTask = parent.ContinueWith(
                parentTask =>
                {
                    foreach (string i in parentTask.Result)
                    {
                        Console.WriteLine(i);
                    }
                });

            finalTask.Wait();
        }
       
    }
}
