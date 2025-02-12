namespace DefaultNamespace;

/// <summary>
/// Class responsible for providing instructions on what to do with a column data
/// </summary>
public class ColumnActionInstruction
{
    public String ColumnName { get; set; }
    
    public ActionType ActionType { get; set; }
    
    public String Value { get; set; }
}