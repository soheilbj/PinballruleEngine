namespace PinballruleEngine.RuleEngine
{
    public abstract class AbstractSyntaxTreeNode
    {
        protected Token Token_ { get; set; }
        public AbstractSyntaxTreeNode()
        {
        
        }
        public AbstractSyntaxTreeNode(Token token)
        {
            Token_ = token;
        }
    }
}
