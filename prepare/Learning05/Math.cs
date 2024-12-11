using System;

public class  Math : Assignment
{
private string _textbookSection = "";
private string _problem= "";

public Math():base()
{

}
public Math (string studentName, string topc, string textbookSection, string problem) : base(studentName, topic)
{
    _textbookSection = textbookSection;
    _problem = problem;
}

public string GetHomeworkList() 
{
return $"{_studentName} - {_topic},{_textbookSection} {_problem}";
}

}