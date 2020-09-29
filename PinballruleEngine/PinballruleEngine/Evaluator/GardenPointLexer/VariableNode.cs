
namespace PinballruleEngine.RuleEngine
{
    public class VariableNode : AbstractSyntaxTreeNode
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private object value;

        public object Value
        {
            get { return this.value; }
            set { this.value = value; }
        }
    }
}
