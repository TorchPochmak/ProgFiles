using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main(string[] args)
    {
        Context context = new Context();
        context.Vocabulary = 'a';
        context.Source = "aaa";
        var expression = new NonterminalExpression();
        expression.Interpret(context);

        Console.WriteLine(context.Result);
    }
}
class Context
{
    //Грамматика
    public string Source { get; set; } = String.Empty;
    public char Vocabulary { get; set; }
    public bool Result { get; set; }
    public int Position { get; set; }
}

abstract class AbstractExpression
{
    public abstract void Interpret(Context context);
}
class TerminalExpression : AbstractExpression
{
    public override void Interpret(Context context)
    {
        context.Result = context.Source[context.Position] == context.Vocabulary;
    }
}
class NonterminalExpression : AbstractExpression
{
    private AbstractExpression? _nonTerminalExpression;
    private AbstractExpression? _terminalExpression;

    public override void Interpret(Context context)
    {
        if(context.Position < context.Source.Length)
        {
            _terminalExpression = new TerminalExpression();
            _terminalExpression.Interpret(context);
            context.Position++;
            if(context.Result)
            {
                _nonTerminalExpression = new NonterminalExpression();
                _nonTerminalExpression.Interpret(context);
            }
        }
    }
}