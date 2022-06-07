namespace RPG_Game
{
	internal class Player
	{
		private static Dictionary<string, int> items = new Dictionary<string, int>();
        private static int level = 0;

        public static void AddItem()
        {
            items.Add("Placeholder", 1);
        }
        public static void ListItems()
        {
            foreach (KeyValuePair<string, int> item in items)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
        }
	}
}