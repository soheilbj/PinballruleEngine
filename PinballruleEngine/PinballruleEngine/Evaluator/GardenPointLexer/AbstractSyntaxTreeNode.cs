namespace PinballruleEngine.Evaluator.GardenPointLexer
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
