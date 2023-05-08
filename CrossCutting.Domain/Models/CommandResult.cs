namespace CrossCutting.Domain.Models
{
    public class CommandResult
    {
        public CommandResult() { }

        public CommandResult(bool sucess, Guid id)
        {
            Sucess = sucess;
            Id = id;
        }

        public Guid? Id { get; set; }
        public bool Sucess { get; set; }
    }
}
