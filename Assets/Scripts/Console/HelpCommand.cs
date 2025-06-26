public class HelpCommand : ICommand
{
    public void Execute(string parameter)
    {
        throw new System.NotImplementedException();
    }

    public string[] GetAliasses()
    {
        return new string[]
        {
            "Help","H",
        };
    }

    public string GetDescription()
    {
        return "Get Description From A Command";
    }
}
