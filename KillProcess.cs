using System;
using System.Collections.Generic;
using System.Text;

namespace Algos_C_Sharp
{
   /**
     * Variables:
     *      hash: hash table with key value pair of parent-children processes
     *      result: array to hold process id's that are killed
     *      processesToKill: stack to hold the process that need to be killed
     * Loop through from index 0 to ppid length
     *      - add parent key and it's children to hash
     * Loop through while there's still elements in processesToKill stack
     *      - pop from processesToKill stack
     *      - if the current process that was popped is a parent, push its children to processesToKill stack
     *      - push current process to result
     * Return result
    */
    class KillProcess
    {
        public IList<int> killProcess(IList<int> pid, IList<int> ppid, int kill)
        {
            var hash = new Dictionary<string, List<int>>() { };
            var result = new List<int> { };
            var processessToKill = new Stack<int>(new int[] { kill });

            for (int i = 0; i < ppid.Count; i++)
            {
                string parent = ppid[i].ToString();
                int child = pid[i];
                if (hash.ContainsKey(parent))
                {
                    hash[parent].Add(child);
                }
                else
                {
                    hash[parent] = new List<int> { child };
                }
            }


            while (processessToKill.Count > 0)
            {
                int toKill = processessToKill.Pop();
                string key = toKill.ToString();
                if (hash.ContainsKey(key))
                {
                    for (int i = 0; i < hash[key].Count; i++)
                    {
                        int child = hash[key][i];
                        processessToKill.Push(child);
                    }
                }
                result.Add(toKill);
            }
            return result;
        }
    }
}

/**
 * N - number of processes
 * Time Complexity: O(N)
 * Space Complexity: O(N)
 */
