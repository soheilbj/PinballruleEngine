using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinballruleEngine.Evaluator.GardenPointLexer
{
    public class ParseTree : AbstractSyntaxTree
    {
        public void AddChild(AbstractSyntaxTreeNode abstractSyntacTreeNode)
        {
            base.rootNodes.Add(abstractSyntacTreeNode);
        }
    }
}
