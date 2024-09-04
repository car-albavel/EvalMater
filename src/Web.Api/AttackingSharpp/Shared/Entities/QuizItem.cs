using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.Api.AttackingSharpp.Shared.Entities
{
    public class QuizItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public String Question { get; set; }
        public string[] Choices { get; set; }
        public int AnswerIndex { get; set; }
        public int Score { get; set; }

    }
}
