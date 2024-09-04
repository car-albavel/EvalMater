using AttackingSharpp.Shared.Entities;

namespace Web.Api.Endpoints.Quiz
{

    public class GetQuestions
    {
        public void MapEndpoint(IEndpointRouteBuilder app)
        {
            app.MapGet("/api/quiz/questions", () =>
            {
                return new List<QuizItem> {
                new ()
                {
                    Question = "Which of the following is the name of a Leonardo da Vinci's masterpiece?",
                    Choices = {"Sunflowers", "Mona Lisa", "The Kiss"},
                    AnswerIndex = 1,
                    Score = 3
                },
                new() {
                    Question = "Which of the following novels was written by Miguel de Cervantes?",
                    Choices = {"The Ingenious Gentleman Don Quixote of La Mancia", "The Life of Gargantua and of Pantagruel", "One Hundred Years of Solitude"},
                    AnswerIndex = 0,
                    Score = 5
                }
                };
            });
        }
    }
}