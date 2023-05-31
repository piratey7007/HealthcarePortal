using HealthcarePortal.Data.Models;
using HealthcarePortal.Data.Repositories;
namespace HealthcarePortal.Data.Services;

public class QuestionService
{
    private readonly IQuestionRepository _questionRepository;

    public QuestionService(IQuestionRepository questionRepository)
    {
        _questionRepository = questionRepository;
    }

    public Task<List<Question>> GetQuestionsAsync()
    {
        return _questionRepository.GetQuestionsAsync();
    }
}
