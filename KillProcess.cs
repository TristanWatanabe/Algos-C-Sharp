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
    }
}
