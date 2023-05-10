namespace CrossCutting.Domain.Models
{
    public class CommandResult
    {
        public CommandResult() { }

        public CommandResult(bool sucess, int id)
        {
            Sucess = sucess;
            Id = id;
        }

        public int? Id { get; set; }
        public bool Sucess { get; set; }
    }
}
