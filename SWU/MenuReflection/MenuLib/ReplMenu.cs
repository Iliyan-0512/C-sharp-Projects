using System.Reflection;
using System.Text;

namespace MenuReflection
{
    public class MenuItem
    {
        public string Caption { get; set; }
        public int SortOrder { get; set; }

        public bool EndRepl { get; set; }

        public Action Action { get; set; }
    }
    /// <summary>
    /// Menu based on methods marked with the MenuItem attribute.
    /// </summary>
    public class ReplMenu
    {
        private List<MenuItem> menu;
        public ReplMenu(Type program)
        {
            menu = program.GetMethods()
                .Where(m => m.GetCustomAttributes(typeof(MenuItemAttribute), false).Any())
                .Select(x => new MenuItem
                {
                    Caption = ((MenuItemAttribute)(x.GetCustomAttributes(typeof(MenuItemAttribute))).First()).Caption,
                    SortOrder = ((MenuItemAttribute)(x.GetCustomAttributes(typeof(MenuItemAttribute))).First()).SortOrder,
                    EndRepl = ((MenuItemAttribute)(x.GetCustomAttributes(typeof(MenuItemAttribute))).First()).EndRepl,
                    Action = (Action)Delegate.CreateDelegate(typeof(Action), x)


                }).OrderBy(m => m.SortOrder).ToList();


        }
        /// <summary>
        /// Starts the menu and allows selecting an option.
        /// </summary>
        public void Run()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("=======================");
                foreach (var mi in menu)
                {
                    Console.WriteLine($"{mi.SortOrder} {mi.Caption}");
                }
                Console.WriteLine("========================");
                Console.WriteLine("Enter your choice");
                var choice = Console.ReadLine();
                if (!int.TryParse(choice, out int choiceValue) || !menu.Any(mi => mi.SortOrder == choiceValue))
                {
                    Console.WriteLine("Not valid menu option! press any key");
                    _ = Console.ReadKey();
                    continue;
                }
                var itemToInvoke = menu.First(mi => mi.SortOrder == choiceValue);
                itemToInvoke.Action();
                if (itemToInvoke.EndRepl) break;
                Console.WriteLine("Press any to continue");
                _ = Console.ReadKey();


            } while (true);
        }



    }
}
