﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MultiParse.Default
{
    public class MPInt64Cast : MPOperator
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public MPInt64Cast()
            : base("(long)", PrecedenceUnary, false)
        {
        }

        /// <summary>
        /// Find byte cast
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="previousToken"></param>
        /// <returns></returns>
        public override int Match(string expression, object previousToken)
        {
            if (!IsUnary(previousToken))
                return -1;
            Match m = Regex.Match(expression, @"^\((long|Int64)\)");
            if (m.Success)
                return m.Length;
            return -1;
        }

        /// <summary>
        /// Execute byte cast
        /// </summary>
        /// <param name="output"></param>
        public override void Execute(Stack<object> output)
        {
            // Pop object from the stack
            object top = PopOrGet(output);
            TypeCode tc = Type.GetTypeCode(top.GetType());

            switch (tc)
            {
                case TypeCode.Byte: output.Push((long)(Byte)top); return;
                case TypeCode.Char: output.Push((long)(Char)top); return;
                case TypeCode.Decimal: output.Push((long)(Decimal)top); return;
                case TypeCode.Double: output.Push((long)(Double)top); return;
                case TypeCode.Int16: output.Push((long)(Int16)top); return;
                case TypeCode.Int32: output.Push((long)(Int32)top); return;
                case TypeCode.Int64: output.Push((long)(Int64)top); return;
                case TypeCode.SByte: output.Push((long)(SByte)top); return;
                case TypeCode.Single: output.Push((long)(Single)top); return;
                case TypeCode.UInt16: output.Push((long)(UInt16)top); return;
                case TypeCode.UInt32: output.Push((long)(UInt32)top); return;
                case TypeCode.UInt64: output.Push((long)(UInt64)top); return;
            }

            // Invalid operation
            throw new InvalidOperatorTypesException("(Int64)", top);
        }
    }
}
