namespace OperationHav
{
    public class CommandWords
    {
        public List<string> ValidCommands { get; } = new List<string> { "north", "east", "south", "west", "look", "help", "back", "quit", "Hello people" };

        public bool IsValidCommand(string command)
        {
            return ValidCommands.Contains(command);
        }
    }

}
