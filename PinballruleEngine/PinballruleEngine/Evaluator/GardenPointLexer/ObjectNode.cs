using PinballruleEngine.Evaluator.GardenPointLexer.AggregateFunctions;

namespace PinballruleEngine.Evaluator.GardenPointLexer
{
    public class ObjectNode : AbstractSyntaxTreeNode
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private DynamicBaseClass objectValue;

        public DynamicBaseClass ObjectValue
        {
            get { return this.objectValue; }
            set { this.objectValue = value; }
        }

        private string propertyName;

        public string PropertyName
        {
            get { return propertyName; }
            set { propertyName = value; }
        }

        public FilterNode filter;

        public FilterNode Filter
        {
            get { return filter; }
            set { filter = value; }
        }

        private AggregateNode aggregateFunction;
        public AggregateNode AggregateFunction
        {
            get { return aggregateFunction; }
            set { aggregateFunction = value; }
        }
    }
}
