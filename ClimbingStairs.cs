using System;
using System.Collections.Generic;
using System.Text;

/**
 * Variables:
 *      dp - list that holds results of subproblems
 *          - initialize with [0,1,2]
 *          - there's 0 ways to reach 0, there's 1 way to reach 1, and theres two ways (1+1, 2) to reach 2
 *          - building up from that there's 3 ways to reach 3 (dp[n-1] + dp[n-2]) and so on
 * Loop starting from 3
 *      - set dp at i to equal dp at i-1 plus dp at i-2
 * Return dp at index input n
 *
 */

namespace Algos_C_Sharp
{
    public class ClimbingStairs
    {
        public int ClimbStairs(int n)
        {
            var dp = new List<int> { 0, 1, 2 };

            for (int i = 3; i <= n; i++)
            {
                int numSteps = dp[i - 2] + dp[i - 1];
                dp.Add(numSteps);
            }

            return dp[n];
        }
    }
}
