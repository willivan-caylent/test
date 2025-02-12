namespace DefaultNamespace;

/// <summary>
/// Data action instruction class
/// </summary>
/// <remarks>
/// This class is used to determine which columns of which table is going to be changed, and the conditions where it should be changed
/// </remarks>
public class DataActionInstruction
{
    public String DataSource { get; set; }
    
    public String TableName { get; set; }
    
    public List<ColumnActionInstruction> ColumnActionInstructions { get; set; }
    
    public List<Condition> Conditions { get; set; }
    
}