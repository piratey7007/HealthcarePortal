using HealthcarePortal.Data.Models;

namespace HealthcarePortal.Data.Repositories;

public interface IQuestionRepository
{
    Task<List<Question>> GetQuestionsAsync();
}

public class QuestionRepository : IQuestionRepository
{
    public Task<List<Question>> GetQuestionsAsync()
    {
        return Task.FromResult(new List<Question>());
    }
}