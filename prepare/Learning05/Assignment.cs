using System;

public class  Assignment
{
private string _studentName = "";
private string _topic = "";

public Assignment()
{
    _studentName = "Oluwaseyi Makinde";
    _topic = "Multiplication";
}
public string GetSummary()
{
 return $"{_studentName} - {_topic}";
}
}