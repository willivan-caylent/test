namespace MyComponents.Interfaces;
using System.Thread;

/// <summary>
/// Interface responsible for creating a new component, a component port is responsible for allowing the user to connect
/// to a data source and execute an action
/// </summary>
public interface IDataComponentAction
{
    Task ExecuteAction(DataActionInstruction instruction);
}