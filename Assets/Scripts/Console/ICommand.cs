using System;
public interface ICommand
{
    string [] GetAliasses();
    void Execute(string parameter);
    string GetDescription();
}
