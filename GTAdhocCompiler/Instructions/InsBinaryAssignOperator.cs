﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTAdhocCompiler.Instructions
{
    /// <summary>
    /// Represents a binary assignment operator instruction.
    /// </summary>
    public class InsBinaryAssignOperator : InstructionBase
    {
        public override AdhocInstructionType InstructionType => AdhocInstructionType.BINARY_ASSIGN_OPERATOR;

        public override string InstructionName => "BINARY_ASSIGN_OPERATOR";

        public AdhocSymbol Operator { get; set; }

        public InsBinaryAssignOperator(AdhocSymbol opSymbol)
        {
            Operator = opSymbol;
        }
    }
}