using PinballruleEngine.Enum;

namespace PinballruleEngine.Evaluator
{
    public class Token
    {
        public TokenType Type_ { get; set; }

        public string Text { get; set; }

        public Token(TokenType type, string text)
        {
            Type_ = type;
            Text = text;
        }

        public override string ToString()
        {
            return string.Format("<'{0}'>,{1}", Text, System.Enum.GetName(typeof(TokenType), Type_));
        }
    }
}
