﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTAdhocCompiler.Instructions
{
    public class InsLongConst : InstructionBase
    {
        public override AdhocInstructionType InstructionType => AdhocInstructionType.LONG_CONST;

        public override string InstructionName => "LONG_CONST";

        public long Value { get; set; }

        public InsLongConst(long value)
        {
            Value = value;
        }
    }
}
