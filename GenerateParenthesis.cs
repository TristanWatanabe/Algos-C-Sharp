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

    }
}
