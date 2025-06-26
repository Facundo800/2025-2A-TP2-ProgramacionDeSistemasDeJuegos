public class AliassesCommand : ICommand
{
    public void Execute(string parameter)
    {
        throw new System.NotImplementedException();
    }

    public string[] GetAliasses()
    {
        return new string[] 
        {
            "Aliass","Alias","Aliasses","Aliases"
        };
    }

    public string GetDescription()
    {
        return "Get Aliasses From A Command";
    }
}
