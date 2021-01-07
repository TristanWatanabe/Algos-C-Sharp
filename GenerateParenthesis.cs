using System;
using System.Collections.Generic;
using System.Text;

/**
 * MAIN: n
 *  Variables:
 *      result - list to hold all possible string combinations of n*2 length
 *  Call backtrack function to generate all combinations
 *  Return result
 *
 * BACKTRACK: currString, numOfOpenParens, numOfCloseParens, n, reference to result array
 *  Base Case: if valid combination, push currString to result
 *  Two recursive cases to form a valid combination that equals to n*2 length:
 *      If open is less than n, backtrack with currString + "(" and increment open
 *      If close is less than open, backtrack with currString + ")" and increment close
 */

namespace Algos_C_Sharp
{
    class GenerateParenthesis
    {
        public List<string> generateParenthesis(int n)
        {
            var results = new List<string> { };
            backTrack("", 0, 0, n, results);
            return results;
        }
        public void backTrack(string str, int open, int close, int n, IList<string> results)
        {
            if (open == n && close == n)
            {
                results.Add(str);
                return;
            }

            if (open < n)
            {
                backTrack(str + "(", open + 1, close, n, results);
            }

            if (close < open)
            {
                backTrack(str + ")", open, close + 1, n, results);
            }
        }
    }
}
