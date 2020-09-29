using System;
using System.Collections.Generic;

namespace PinballruleEngine.RuleEngine
{
    public class Evaluator
    {
        public bool Evaluate<T>(string evaluationText, T objectValue)
        {
            ExpressionEvaluatorLexer expressionEvaluatorLexer = new ExpressionEvaluatorLexer(evaluationText, 1);
            ExpressionEvaluatorParser expressionEvaluatorParser = new ExpressionEvaluatorParser(expressionEvaluatorLexer);
            var AbstractSyntaxTreeNodeList = expressionEvaluatorParser.BuildParseTree();
            ExpressionEvaluatorExecutor expressionEvaluator = new ExpressionEvaluatorExecutor();
            var result = expressionEvaluator.Evaluate<T>(AbstractSyntaxTreeNodeList, expressionEvaluatorParser.SymbolTable, objectValue);
            return result;
        }

        public bool EvaluateDynamic(string evaluationText, dynamic objectValue)
        {
            ExpressionEvaluatorLexer expressionEvaluatorLexer = new ExpressionEvaluatorLexer(evaluationText, 1);
            ExpressionEvaluatorParser expressionEvaluatorParser = new ExpressionEvaluatorParser(expressionEvaluatorLexer);
            var AbstractSyntaxTreeNodeList = expressionEvaluatorParser.BuildParseTree();
            ExpressionEvaluatorExecutor expressionEvaluator = new ExpressionEvaluatorExecutor();
            var result = expressionEvaluator.EvaluateDynamic(AbstractSyntaxTreeNodeList, expressionEvaluatorParser.SymbolTable, objectValue);
            return result;
        }

        public bool EvaluateDynamic(string evaluationText, dynamic[] collection)
        {
            ExpressionEvaluatorLexer expressionEvaluatorLexer = new ExpressionEvaluatorLexer(evaluationText, 1);
            ExpressionEvaluatorParser expressionEvaluatorParser = new ExpressionEvaluatorParser(expressionEvaluatorLexer);
            var AbstractSyntaxTreeNodeList = expressionEvaluatorParser.BuildParseTree();
            ExpressionEvaluatorExecutor expressionEvaluator = new ExpressionEvaluatorExecutor();
            var result = expressionEvaluator.EvaluateDynamic(AbstractSyntaxTreeNodeList, expressionEvaluatorParser.SymbolTable, collection);
            return result;
        }

        public bool EvaluateDynamic(string evaluationText, dynamic objectValue, dynamic[] collection)
        {
            ExpressionEvaluatorLexer expressionEvaluatorLexer = new ExpressionEvaluatorLexer(evaluationText, 1);
            ExpressionEvaluatorParser expressionEvaluatorParser = new ExpressionEvaluatorParser(expressionEvaluatorLexer);
            var AbstractSyntaxTreeNodeList = expressionEvaluatorParser.BuildParseTree();
            ExpressionEvaluatorExecutor expressionEvaluator = new ExpressionEvaluatorExecutor();
            var result = expressionEvaluator.EvaluateDynamic(AbstractSyntaxTreeNodeList, expressionEvaluatorParser.SymbolTable, objectValue, collection);
            return result;
        }

        public bool EvaluateDynamic(string evaluationText, DynamicBaseClass objectValue)
        {
            ExpressionEvaluatorLexer expressionEvaluatorLexer = new ExpressionEvaluatorLexer(evaluationText, 1);
            ExpressionEvaluatorParser expressionEvaluatorParser = new ExpressionEvaluatorParser(expressionEvaluatorLexer);
            var AbstractSyntaxTreeNodeList = expressionEvaluatorParser.BuildParseTree();
            ExpressionEvaluatorExecutor expressionEvaluator = new ExpressionEvaluatorExecutor();
            var result = expressionEvaluator.EvaluateDynamic(AbstractSyntaxTreeNodeList, expressionEvaluatorParser.SymbolTable, objectValue);
            return result;
        }

        public bool EvaluateDynamic(string evaluationText, DynamicBaseClass[] objectValues)
        {
            ExpressionEvaluatorLexer expressionEvaluatorLexer = new ExpressionEvaluatorLexer(evaluationText, 1);
            ExpressionEvaluatorParser expressionEvaluatorParser = new ExpressionEvaluatorParser(expressionEvaluatorLexer);
            var AbstractSyntaxTreeNodeList = expressionEvaluatorParser.BuildParseTree(objectValues);
            ExpressionEvaluatorExecutor expressionEvaluator = new ExpressionEvaluatorExecutor();
            var result = expressionEvaluator.EvaluateDynamicBaseClass(AbstractSyntaxTreeNodeList, expressionEvaluatorParser.SymbolTable, objectValues);
            return result;
        }

        public R EvaluateNonBoolean<T, R>(string evaluationText, T objectValue)
        {
            ExpressionEvaluatorLexer expressionEvaluatorLexer = new ExpressionEvaluatorLexer(evaluationText, 1);
            ExpressionEvaluatorParser expressionEvaluatorParser = new ExpressionEvaluatorParser(expressionEvaluatorLexer);
            var AbstractSyntaxTreeNodeList = expressionEvaluatorParser.BuildParseTree();
            ExpressionEvaluatorExecutor expressionEvaluator = new ExpressionEvaluatorExecutor();
            var result = expressionEvaluator.EvaluateNonBoolean<T, R>(AbstractSyntaxTreeNodeList, expressionEvaluatorParser.SymbolTable, objectValue);
            return result;
        }

        public R EvaluateNonBooleanDynamic<R>(string evaluationText, dynamic objectValue)
        {
            ExpressionEvaluatorLexer expressionEvaluatorLexer = new ExpressionEvaluatorLexer(evaluationText, 1);
            ExpressionEvaluatorParser expressionEvaluatorParser = new ExpressionEvaluatorParser(expressionEvaluatorLexer);
            var AbstractSyntaxTreeNodeList = expressionEvaluatorParser.BuildParseTree();
            ExpressionEvaluatorExecutor expressionEvaluator = new ExpressionEvaluatorExecutor();
            var result = expressionEvaluator.EvaluateNonBooleanDynamic<R>(AbstractSyntaxTreeNodeList, expressionEvaluatorParser.SymbolTable, objectValue);
            return result;
        }

        public R EvaluateNonBooleanDynamic<R>(string evaluationText, dynamic[] collection)
        {
            ExpressionEvaluatorLexer expressionEvaluatorLexer = new ExpressionEvaluatorLexer(evaluationText, 1);
            ExpressionEvaluatorParser expressionEvaluatorParser = new ExpressionEvaluatorParser(expressionEvaluatorLexer);
            var AbstractSyntaxTreeNodeList = expressionEvaluatorParser.BuildParseTree();
            ExpressionEvaluatorExecutor expressionEvaluator = new ExpressionEvaluatorExecutor();
            var result = expressionEvaluator.EvaluateNonBooleanDynamic<R>(AbstractSyntaxTreeNodeList, expressionEvaluatorParser.SymbolTable, collection);
            return result;
        }

        public R EvaluateNonBooleanDynamic<R>(string evaluationText, DynamicBaseClass objectValue)
        {
            ExpressionEvaluatorLexer expressionEvaluatorLexer = new ExpressionEvaluatorLexer(evaluationText, 1);
            ExpressionEvaluatorParser expressionEvaluatorParser = new ExpressionEvaluatorParser(expressionEvaluatorLexer);
            var AbstractSyntaxTreeNodeList = expressionEvaluatorParser.BuildParseTree();
            ExpressionEvaluatorExecutor expressionEvaluator = new ExpressionEvaluatorExecutor();
            var result = expressionEvaluator.EvaluateNonBooleanDynamic<R>(AbstractSyntaxTreeNodeList, expressionEvaluatorParser.SymbolTable, objectValue);
            return result;
        }

        public R EvaluateNonBooleanDynamic<R>(string evaluationText, DynamicBaseClass[] collection)
        {
            ExpressionEvaluatorLexer expressionEvaluatorLexer = new ExpressionEvaluatorLexer(evaluationText, 1);
            ExpressionEvaluatorParser expressionEvaluatorParser = new ExpressionEvaluatorParser(expressionEvaluatorLexer);
            var AbstractSyntaxTreeNodeList = expressionEvaluatorParser.BuildParseTree();
            ExpressionEvaluatorExecutor expressionEvaluator = new ExpressionEvaluatorExecutor();
            var result = expressionEvaluator.EvaluateNonBooleanDynamic<R>(AbstractSyntaxTreeNodeList, expressionEvaluatorParser.SymbolTable, collection);
            return result;
        }

        public R EvaluateNonBooleanDynamic<R>(string evaluationText, dynamic objectValue, dynamic[] collection)
        {
            ExpressionEvaluatorLexer expressionEvaluatorLexer = new ExpressionEvaluatorLexer(evaluationText, 1);
            ExpressionEvaluatorParser expressionEvaluatorParser = new ExpressionEvaluatorParser(expressionEvaluatorLexer);
            var AbstractSyntaxTreeNodeList = expressionEvaluatorParser.BuildParseTree();
            ExpressionEvaluatorExecutor expressionEvaluator = new ExpressionEvaluatorExecutor();
            var result = expressionEvaluator.EvaluateNonBooleanDynamic<R>(AbstractSyntaxTreeNodeList, expressionEvaluatorParser.SymbolTable, objectValue, collection);
            return result;
        }

        public Tuple<List<AbstractSyntaxTreeNode>, Dictionary<string, AbstractSyntaxTreeNode>>
            PreEvaluate<T>(string evaluationText)
        {
            ExpressionEvaluatorLexer expressionEvaluatorLexer = new ExpressionEvaluatorLexer(evaluationText, 1);
            ExpressionEvaluatorParser expressionEvaluatorParser = new ExpressionEvaluatorParser(expressionEvaluatorLexer);
            var AbstractSyntaxTreeNodeList = expressionEvaluatorParser.BuildParseTree();
            ExpressionEvaluatorExecutor expressionEvaluator = new ExpressionEvaluatorExecutor();
            var symbolTable = expressionEvaluatorParser.SymbolTable;
            return new Tuple<List<AbstractSyntaxTreeNode>, Dictionary<string, AbstractSyntaxTreeNode>>(AbstractSyntaxTreeNodeList, symbolTable);
        }
        public Tuple<List<AbstractSyntaxTreeNode>, Dictionary<string, AbstractSyntaxTreeNode>>PreEvaluateDynamic(string evaluationText)
        {
            ExpressionEvaluatorLexer expressionEvaluatorLexer = new ExpressionEvaluatorLexer(evaluationText, 1);
            ExpressionEvaluatorParser expressionEvaluatorParser = new ExpressionEvaluatorParser(expressionEvaluatorLexer);
            var AbstractSyntaxTreeNodeList = expressionEvaluatorParser.BuildParseTree();
            ExpressionEvaluatorExecutor expressionEvaluator = new ExpressionEvaluatorExecutor();
            var symbolTable = expressionEvaluatorParser.SymbolTable;
            return new Tuple<List<AbstractSyntaxTreeNode>, Dictionary<string, AbstractSyntaxTreeNode>>(AbstractSyntaxTreeNodeList, symbolTable);
        }
        public bool ExecuteEvaluate<T>(Tuple<List<AbstractSyntaxTreeNode>,Dictionary<string, AbstractSyntaxTreeNode>> values, T objectValue)
        {
            ExpressionEvaluatorExecutor expressionEvaluator = new ExpressionEvaluatorExecutor();
            var result = expressionEvaluator.Evaluate<T>(values.Item1, values.Item2, objectValue);
            return result;
        }
        public bool ExecuteEvaluateDynamic<T>(Tuple<List<AbstractSyntaxTreeNode>,Dictionary<string, AbstractSyntaxTreeNode>> values, dynamic objectValue)
        {
            ExpressionEvaluatorExecutor expressionEvaluator = new ExpressionEvaluatorExecutor();
            var result = expressionEvaluator.EvaluateDynamic(values.Item1, values.Item2, objectValue);
            return result;
        }
    }
}
