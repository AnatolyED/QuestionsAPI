namespace QuestionsAPI.Contracts;

public record GetQuestionsDto(string Search, Guid[] TagIds, int Page, int PageSiza);