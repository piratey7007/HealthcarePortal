namespace HealthcarePortal.Data.Models;

public class Question
{
    public Question(string? query, string? answer)
    {
        Query = query ?? throw new ArgumentNullException(nameof(query));
        Answer = answer ?? throw new ArgumentNullException(nameof(answer));
    }
    public string Query;
    public string Answer;
}