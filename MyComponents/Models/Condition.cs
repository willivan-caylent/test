namespace DefaultNamespace;

/// <summary>
/// Condition to restrict the rows that will be affected
/// </summary>
public class Condition
{
    public String ColumnName { get; set; }
    
    public String ComparisonType { get; set; }
    
    public String ComparisonValue { get; set; }
    
    public String ComparisonValues { get; set; }
    
    public String DataType { get; set; }
}