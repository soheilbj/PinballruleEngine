
using PinballruleEngine.Evaluator.GardenPointLexer.AggregateFunctions;

namespace PinballruleEngine.Evaluator.GardenPointLexer
{
    public class CollectionNode : AbstractSyntaxTreeNode
    {
        public string Name { get; set; }

        public VariableNode Value { get; set; }

        public FilterNode filter;

        public FilterNode Filter
        {
            get { return filter; }
            set { filter = value; }
        }
        public AggregateNode AggregateFunction { get; set; }
    }
}
