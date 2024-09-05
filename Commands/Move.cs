using Artifacts.Utils;
using System.CommandLine;
namespace Artifacts.Commands
{
    internal class Move : Command
    {
        public Move(string name, string? description = null) : base(name, description)
        {
            Artifacts.Options.Position.IsRequired = true;

            AddOption(Artifacts.Options.Character);
            AddOption(Artifacts.Options.Position);

            this.SetHandler(async (character, position) =>
            {
                await this.Run(character, position!.Value);
            }, Artifacts.Options.Character, Artifacts.Options.Position);
        }

        public async Task Run(string character, Position position)
        {
            var client = ActionClient.Create();
            var move = await client.move(character, position);
            Console.WriteLine($"Moved {character} at {position}");
            move.WaitDisplay();
        }
    }
}
