using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PinballruleEngine.RuleEngine
{
    public class BooleanNode : AbstractSyntaxTreeNode
    {
        public bool Value { get; set; }
    }
}
