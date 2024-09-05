using Artifacts.Schemas;
using Artifacts.Utils;
using System.CommandLine;
namespace Artifacts.Commands
{
    internal class Gather : Command
    {
        public Gather(string name, string? description = null) : base(name, description)
        {
            AddOption(Artifacts.Options.Character);
            AddOption(Artifacts.Options.Item);
            AddOption(Artifacts.Options.Quantity);



            this.SetHandler(async (character, item_code, quantity) =>
            {
                await this.Run(character, item_code, quantity);
            }, Artifacts.Options.Character, Artifacts.Options.Item, Artifacts.Options.Quantity);
        }

        public async Task Run(string character, string item_code, int quantity)
        {
            var client = ActionClient.Create();
            Console.WriteLine($"Gathering {quantity} {item_code}");

            int current_quantity = 0;

            while (current_quantity < quantity)
            {
                var skill_data = await client.Gather(character);
                writeDrop(skill_data);

                var item_code_drop = Array.Find(skill_data.Details.Items, drop => drop.Code == item_code);

                if (item_code_drop != null)
                {
                    current_quantity += item_code_drop.Quantity;
                    Console.WriteLine($"Gathering progress: {current_quantity}/{quantity}");
                }
                skill_data.WaitDisplay();
            }
        }

        private void writeDrop(SkillData skill_data)
        {
            if (skill_data.Details.Items.Length == 0)
            {
                Console.WriteLine($"Nothing was gathered");

            }
            else
            {
                Console.WriteLine($"Gathered:");
                foreach (var drop in skill_data.Details.Items)
                {
                    Console.WriteLine("\t Name: {0,-10} \t Quantity: {1,3}", drop.Code, drop.Quantity.ToString("D3"));
                }
            }
        }
    }
}
