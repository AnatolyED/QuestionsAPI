namespace QuestionsAPI.Contracts;

public record UpdateQuestionDto(string Title, string Body, Guid[] TagIds);