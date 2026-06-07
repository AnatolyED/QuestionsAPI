namespace QuestionsAPI.Contracts;

public record CreateQuestionDto(string Title,string Body, Guid userId, Guid[] TagIds);