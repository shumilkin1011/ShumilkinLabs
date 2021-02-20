﻿using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace MultiParse.Default
{
    public class MPNegative : MPOperator
    {

        /// <summary>
        /// Constructor
        /// </summary>
        public MPNegative()
            : base("-", PrecedenceUnary, false)
        {
        }

        /// <summary>
        /// Find unary negative
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="previousToken"></param>
        /// <returns></returns>
        public override int Match(string expression, object previousToken)
        {
            if (!IsUnary(previousToken))
                return -1;
            if (Regex.IsMatch(expression, @"^-(?![-\=])"))
                return 1;
            return -1;
        }

        /// <summary>
        /// Execute unary negative
        /// </summary>
        /// <param name="output"></param>
        public override void Execute(Stack<object> output)
        {
            // Pop object from the stack
            object top = PopOrGet(output);
            Negative(output, top);
        }

        /// <summary>
        /// Negative
        /// </summary>
        /// <param name="output"></param>
        /// <param name="operand"></param>
        public void Negative(Stack<object> output, object operand)
        {
            TypeCode tc = Type.GetTypeCode(operand.GetType());
            switch (tc)
            {
                case TypeCode.Byte: output.Push(-(Byte)operand); return;
                case TypeCode.Char: output.Push(-(Char)operand); return;
                case TypeCode.Decimal: output.Push(-(Decimal)operand); return;
                case TypeCode.Double: output.Push(-(Double)operand); return;
                case TypeCode.Int16: output.Push(-(Int16)operand); return;
                case TypeCode.Int32: output.Push(-(Int32)operand); return;
                case TypeCode.Int64: output.Push(-(Int64)operand); return;
                case TypeCode.SByte: output.Push(-(SByte)operand); return;
                case TypeCode.Single: output.Push(-(Single)operand); return;
                case TypeCode.UInt16: output.Push(-(UInt16)operand); return;
                case TypeCode.UInt32: output.Push(-(UInt32)operand); return;
            }

            // Invalid operation
            throw new InvalidOperatorTypesException("-", operand);
        }
    }
}
