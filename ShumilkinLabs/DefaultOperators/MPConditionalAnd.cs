﻿using System;
using System.Collections.Generic;

namespace MultiParse.Default
{
    public class MPConditionalAnd : MPOperator
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public MPConditionalAnd()
            : base("&&", PrecedenceConditionalAnd, true)
        {
        }

        /// <summary>
        /// Find conditional And
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="previousToken"></param>
        /// <returns></returns>
        public override int Match(string expression, object previousToken)
        {
            if (IsUnary(previousToken))
                return -1;
            if (expression.StartsWith("&&"))
                return 2;
            return -1;
        }

        /// <summary>
        /// Execute conditional And
        /// </summary>
        /// <param name="output"></param>
        public override void Execute(Stack<object> output)
        {
            // Pop two objects from the stack
            object right = PopOrGet(output);
            object left = PopOrGet(output);
            ConditionalAnd(output, left, right);
        }

        /// <summary>
        /// Conditional And
        /// </summary>
        /// <param name="output"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        public void ConditionalAnd(Stack<object> output, object left, object right)
        {
            if ((left is Boolean) && (right is Boolean))
            {
                output.Push((Boolean)left && (Boolean)right);
                return;
            }

            // Invalid operation
            throw new InvalidOperatorTypesException("&&", left, right);
        }
    }
}
