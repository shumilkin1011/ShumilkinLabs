﻿using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace MultiParse.Default
{
    public class MPAddition : MPOperator
    {

        /// <summary>
        /// Constructor
        /// </summary>
        public MPAddition()
            : base("+", PrecedenceAdditive, true)
        {
        }

        /// <summary>
        /// Returns -1 if the expression does not start with the operator.
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="previousToken"></param>
        /// <returns></returns>
        public override int Match(string expression, object previousToken)
        {
            // If the previous token was also an operator, then the operator is a unary operator
            if (IsUnary(previousToken))
                return -1;
            if (Regex.IsMatch(expression, @"^\+(?![\+\=])"))
                return 1;
            return -1;
        }

        /// <summary>
        /// Execute the operator
        /// </summary>
        /// <param name="output">The output stack</param>
        /// <returns></returns>
        public override void Execute(Stack<object> output)
        {
            // Pop two objects from the stack
            object right = PopOrGet(output);
            object left = PopOrGet(output);
            Add(output, left, right);
        }

        /// <summary>
        /// Standard implementation for two objects
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public void Add(Stack<object> output, object left, object right)
        {
            // Default implementation depends on the typecodes
            TypeCode tcl = Type.GetTypeCode(left.GetType());
            TypeCode tcr = Type.GetTypeCode(right.GetType());

            // Depending on the types, calculate the addition
            switch (tcl)
            {

                case TypeCode.Byte:
                    byte b = (Byte)left;
                    switch (tcr)
                    {
                        case TypeCode.Byte: output.Push(b + (Byte)right); return;
                        case TypeCode.Char: output.Push(b + (Char)right); return;
                        case TypeCode.Decimal: output.Push(b + (Decimal)right); return;
                        case TypeCode.Double: output.Push(b + (Double)right); return;
                        case TypeCode.Int16: output.Push(b + (Int16)right); return;
                        case TypeCode.Int32: output.Push(b + (Int32)right); return;
                        case TypeCode.Int64: output.Push(b + (Int64)right); return;
                        case TypeCode.SByte: output.Push(b + (SByte)right); return;
                        case TypeCode.Single: output.Push(b + (Single)right); return;
                        case TypeCode.String: output.Push(b + (String)right); return;
                        case TypeCode.UInt16: output.Push(b + (UInt16)right); return;
                        case TypeCode.UInt32: output.Push(b + (UInt32)right); return;
                        case TypeCode.UInt64: output.Push(b + (UInt64)right); return;
                    }
                    break;

                case TypeCode.Char:
                    char c = (Char)left;
                    switch (tcr)
                    {
                        case TypeCode.Byte: output.Push(c + (Byte)right); return;
                        case TypeCode.Char: output.Push(c + (Char)right); return;
                        case TypeCode.Decimal: output.Push(c + (Decimal)right); return;
                        case TypeCode.Double: output.Push(c + (Double)right); return;
                        case TypeCode.Int16: output.Push(c + (Int16)right); return;
                        case TypeCode.Int32: output.Push(c + (Int32)right); return;
                        case TypeCode.Int64: output.Push(c + (Int64)right); return;
                        case TypeCode.SByte: output.Push(c + (SByte)right); return;
                        case TypeCode.Single: output.Push(c + (Single)right); return;
                        case TypeCode.String: output.Push(c + (String)right); return;
                        case TypeCode.UInt16: output.Push(c + (UInt16)right); return;
                        case TypeCode.UInt32: output.Push(c + (UInt32)right); return;
                        case TypeCode.UInt64: output.Push(c + (UInt64)right); return;
                    }
                    break;

                case TypeCode.Decimal:
                    decimal d = (Decimal)left;
                    switch (tcr)
                    {
                        case TypeCode.Byte: output.Push(d + (Byte)right); return;
                        case TypeCode.Char: output.Push(d + (Char)right); return;
                        case TypeCode.Decimal: output.Push(d + (Decimal)right); return;
                        case TypeCode.Int16: output.Push(d + (Int16)right); return;
                        case TypeCode.Int32: output.Push(d + (Int32)right); return;
                        case TypeCode.Int64: output.Push(d + (Int64)right); return;
                        case TypeCode.SByte: output.Push(d + (SByte)right); return;
                        case TypeCode.String: output.Push(d + (String)right); return;
                        case TypeCode.UInt16: output.Push(d + (UInt16)right); return;
                        case TypeCode.UInt32: output.Push(d + (UInt32)right); return;
                        case TypeCode.UInt64: output.Push(d + (UInt64)right); return;
                    }
                    break;

                case TypeCode.Double:
                    double dbl = (Double)left;
                    switch (tcr)
                    {
                        case TypeCode.Byte: output.Push(dbl + (Byte)right); return;
                        case TypeCode.Char: output.Push(dbl + (Char)right); return;
                        case TypeCode.Double: output.Push(dbl + (Double)right); return;
                        case TypeCode.Int16: output.Push(dbl + (Int16)right); return;
                        case TypeCode.Int32: output.Push(dbl + (Int32)right); return;
                        case TypeCode.Int64: output.Push(dbl + (Int64)right); return;
                        case TypeCode.SByte: output.Push(dbl + (SByte)right); return;
                        case TypeCode.Single: output.Push(dbl + (Single)right); return;
                        case TypeCode.String: output.Push(dbl + (String)right); return;
                        case TypeCode.UInt16: output.Push(dbl + (UInt16)right); return;
                        case TypeCode.UInt32: output.Push(dbl + (UInt32)right); return;
                        case TypeCode.UInt64: output.Push(dbl + (UInt64)right); return;
                    }
                    break;

                case TypeCode.Int16:
                    short s = (Int16)left;
                    switch (tcr)
                    {
                        case TypeCode.Byte: output.Push(s + (Byte)right); return;
                        case TypeCode.Char: output.Push(s + (Char)right); return;
                        case TypeCode.Decimal: output.Push(s + (Decimal)right); return;
                        case TypeCode.Double: output.Push(s + (Double)right); return;
                        case TypeCode.Int16: output.Push(s + (Int16)right); return;
                        case TypeCode.Int32: output.Push(s + (Int32)right); return;
                        case TypeCode.Int64: output.Push(s + (Int64)right); return;
                        case TypeCode.SByte: output.Push(s + (SByte)right); return;
                        case TypeCode.Single: output.Push(s + (Single)right); return;
                        case TypeCode.String: output.Push(s + (String)right); return;
                        case TypeCode.UInt16: output.Push(s + (UInt16)right); return;
                        case TypeCode.UInt32: output.Push(s + (UInt32)right); return;
                    }
                    break;

                case TypeCode.Int32:
                    int i = (Int32)left;
                    switch (tcr)
                    {
                        case TypeCode.Byte: output.Push(i + (Byte)right); return;
                        case TypeCode.Char: output.Push(i + (Char)right); return;
                        case TypeCode.Decimal: output.Push(i + (Decimal)right); return;
                        case TypeCode.Double: output.Push(i + (Double)right); return;
                        case TypeCode.Int16: output.Push(i + (Int16)right); return;
                        case TypeCode.Int32: output.Push(i + (Int32)right); return;
                        case TypeCode.Int64: output.Push(i + (Int64)right); return;
                        case TypeCode.SByte: output.Push(i + (SByte)right); return;
                        case TypeCode.Single: output.Push(i + (Single)right); return;
                        case TypeCode.String: output.Push(i + (String)right); return;
                        case TypeCode.UInt16: output.Push(i + (UInt16)right); return;
                        case TypeCode.UInt32: output.Push(i + (UInt32)right); return;
                    }
                    break;

                case TypeCode.Int64:
                    long l = (Int64)left;
                    switch (tcr)
                    {
                        case TypeCode.Byte: output.Push(l + (Byte)right); return;
                        case TypeCode.Char: output.Push(l + (Char)right); return;
                        case TypeCode.Decimal: output.Push(l + (Decimal)right); return;
                        case TypeCode.Double: output.Push(l + (Double)right); return;
                        case TypeCode.Int16: output.Push(l + (Int16)right); return;
                        case TypeCode.Int32: output.Push(l + (Int32)right); return;
                        case TypeCode.Int64: output.Push(l + (Int64)right); return;
                        case TypeCode.SByte: output.Push(l + (SByte)right); return;
                        case TypeCode.Single: output.Push(l + (Single)right); return;
                        case TypeCode.String: output.Push(l + (String)right); return;
                        case TypeCode.UInt16: output.Push(l + (UInt16)right); return;
                        case TypeCode.UInt32: output.Push(l + (UInt32)right); return;
                    }
                    break;

                case TypeCode.SByte:
                    sbyte sb = (SByte)left;
                    switch (tcr)
                    {
                        case TypeCode.Byte: output.Push(sb + (Byte)right); return;
                        case TypeCode.Char: output.Push(sb + (Char)right); return;
                        case TypeCode.Decimal: output.Push(sb + (Decimal)right); return;
                        case TypeCode.Double: output.Push(sb + (Double)right); return;
                        case TypeCode.Int16: output.Push(sb + (Int16)right); return;
                        case TypeCode.Int32: output.Push(sb + (Int32)right); return;
                        case TypeCode.Int64: output.Push(sb + (Int64)right); return;
                        case TypeCode.SByte: output.Push(sb + (SByte)right); return;
                        case TypeCode.Single: output.Push(sb + (Single)right); return;
                        case TypeCode.String: output.Push(sb + (String)right); return;
                        case TypeCode.UInt16: output.Push(sb + (UInt16)right); return;
                        case TypeCode.UInt32: output.Push(sb + (UInt32)right); return;
                    }
                    break;

                case TypeCode.Single:
                    float f = (float)left;
                    switch (tcr)
                    {
                        case TypeCode.Byte: output.Push(f + (Byte)right); return;
                        case TypeCode.Char: output.Push(f + (Char)right); return;
                        case TypeCode.Double: output.Push(f + (Double)right); return;
                        case TypeCode.Int16: output.Push(f + (Int16)right); return;
                        case TypeCode.Int32: output.Push(f + (Int32)right); return;
                        case TypeCode.Int64: output.Push(f + (Int64)right); return;
                        case TypeCode.SByte: output.Push(f + (SByte)right); return;
                        case TypeCode.Single: output.Push(f + (Single)right); return;
                        case TypeCode.String: output.Push(f + (String)right); return;
                        case TypeCode.UInt16: output.Push(f + (UInt16)right); return;
                        case TypeCode.UInt32: output.Push(f + (UInt32)right); return;
                        case TypeCode.UInt64: output.Push(f + (UInt64)right); return;
                    }
                    break;

                case TypeCode.String:
                    string str = (String)left;
                    switch (tcr)
                    {
                        case TypeCode.Boolean: output.Push(str + (Boolean)right); return;
                        case TypeCode.Byte: output.Push(str + (Byte)right); return;
                        case TypeCode.Char: output.Push(str + (Char)right); return;
                        case TypeCode.DateTime: output.Push(str + (DateTime)right); return;
                        case TypeCode.Decimal: output.Push(str + (Decimal)right); return;
                        case TypeCode.Double: output.Push(str + (Double)right); return;
                        case TypeCode.Int16: output.Push(str + (Int16)right); return;
                        case TypeCode.Int32: output.Push(str + (Int32)right); return;
                        case TypeCode.Int64: output.Push(str + (Int64)right); return;
                        case TypeCode.SByte: output.Push(str + (SByte)right); return;
                        case TypeCode.Single: output.Push(str + (Single)right); return;
                        case TypeCode.String: output.Push(str + (String)right); return;
                        case TypeCode.UInt16: output.Push(str + (UInt16)right); return;
                        case TypeCode.UInt32: output.Push(str + (UInt32)right); return;
                        case TypeCode.UInt64: output.Push(str + (UInt64)right); return;
                    }
                    break;

                case TypeCode.UInt16:
                    ushort us = (UInt16)left;
                    switch (tcr)
                    {
                        case TypeCode.Byte: output.Push(us + (Byte)right); return;
                        case TypeCode.Char: output.Push(us + (Char)right); return;
                        case TypeCode.Decimal: output.Push(us + (Decimal)right); return;
                        case TypeCode.Double: output.Push(us + (Double)right); return;
                        case TypeCode.Int16: output.Push(us + (Int16)right); return;
                        case TypeCode.Int32: output.Push(us + (Int32)right); return;
                        case TypeCode.Int64: output.Push(us + (Int64)right); return;
                        case TypeCode.SByte: output.Push(us + (SByte)right); return;
                        case TypeCode.Single: output.Push(us + (Single)right); return;
                        case TypeCode.String: output.Push(us + (String)right); return;
                        case TypeCode.UInt16: output.Push(us + (UInt16)right); return;
                        case TypeCode.UInt32: output.Push(us + (UInt32)right); return;
                        case TypeCode.UInt64: output.Push(us + (UInt64)right); return;
                    }
                    break;

                case TypeCode.UInt32:
                    uint ui = (UInt32)left;
                    switch (tcr)
                    {
                        case TypeCode.Byte: output.Push(ui + (Byte)right); return;
                        case TypeCode.Char: output.Push(ui + (Char)right); return;
                        case TypeCode.Decimal: output.Push(ui + (Decimal)right); return;
                        case TypeCode.Double: output.Push(ui + (Double)right); return;
                        case TypeCode.Int16: output.Push(ui + (Int16)right); return;
                        case TypeCode.Int32: output.Push(ui + (Int32)right); return;
                        case TypeCode.Int64: output.Push(ui + (Int64)right); return;
                        case TypeCode.SByte: output.Push(ui + (SByte)right); return;
                        case TypeCode.Single: output.Push(ui + (Single)right); return;
                        case TypeCode.String: output.Push(ui + (String)right); return;
                        case TypeCode.UInt16: output.Push(ui + (UInt16)right); return;
                        case TypeCode.UInt32: output.Push(ui + (UInt32)right); return;
                        case TypeCode.UInt64: output.Push(ui + (UInt64)right); return;
                    }
                    break;

                case TypeCode.UInt64:
                    ulong ul = (UInt64)right;
                    switch (tcr)
                    {
                        case TypeCode.Byte: output.Push(ul + (Byte)right); return;
                        case TypeCode.Char: output.Push(ul + (Char)right); return;
                        case TypeCode.Decimal: output.Push(ul + (Decimal)right); return;
                        case TypeCode.Double: output.Push(ul + (Double)right); return;
                        case TypeCode.Single: output.Push(ul + (Single)right); return;
                        case TypeCode.String: output.Push(ul + (String)right); return;
                        case TypeCode.UInt16: output.Push(ul + (UInt16)right); return;
                        case TypeCode.UInt32: output.Push(ul + (UInt32)right); return;
                        case TypeCode.UInt64: output.Push(ul + (UInt64)right); return;
                    }
                    break;
            }

            // Invalid operation exception
            throw new InvalidOperatorTypesException("+", left, right);
        }
    }
}
