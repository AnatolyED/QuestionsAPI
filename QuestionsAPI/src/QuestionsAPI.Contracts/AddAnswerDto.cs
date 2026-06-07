namespace QuestionsAPI.Contracts;

public record AddAnswerDto(Guid UserId, string Text);