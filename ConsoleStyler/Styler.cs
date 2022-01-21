namespace ConsoleStyler
{
    public class Styler
    {
        /// <summary>
        /// Sets the background- and foreground color of your Console App. The strings are case sensitive.
        /// </summary>
        /// <param name="bgColor">Avalible background colors are: "Black", "Cyan", "Gray", "Green", "Magenta", "Red", "White" and "Yellow"</param>
        /// <param name="fgColor">Avalible foreground(text) color are: "Black", "Cyan", "Gray", "Green", "Magenta", "Red", "White" and "Yellow"</param>
        public static void Colors(string bgColor, string fgColor)
        {
            var bg = ConsoleColor.Black;
            var fg = ConsoleColor.White;    

            if (bgColor != "Black")
            {
                switch (bgColor)
                {
                    case "Blue":
                        bg = ConsoleColor.Blue;
                        break;
                    case "Cyan":
                        bg = ConsoleColor.Cyan;
                        break;
                    case "Gray":
                        bg = ConsoleColor.Gray;
                        break;
                    case "Green":
                        bg = ConsoleColor.Green;
                        break;
                    case "Magenta":
                        bg = ConsoleColor.Magenta;
                        break;
                    case "Red":
                        bg = ConsoleColor.Red;
                        break;
                    case "White":
                        bg = ConsoleColor.White;
                        break;
                    case "Yellow":
                        bg = ConsoleColor.Yellow;
                        break;
                    default:
                        bg = ConsoleColor.Black;
                        break;
                }
            }

            if (fgColor != "White")
            {
                switch (fgColor)
                {
                    case "Black":
                        fg = ConsoleColor.Black;
                        break;
                    case "Blue":
                        fg = ConsoleColor.Blue;
                        break;
                    case "Cyan":
                        fg = ConsoleColor.Cyan;
                        break;
                    case "Gray":
                        fg = ConsoleColor.Gray;
                        break;
                    case "Green":
                        fg = ConsoleColor.Green;
                        break;
                    case "Magenta":
                        fg = ConsoleColor.Magenta;
                        break;
                    case "Red":
                        fg = ConsoleColor.Red;
                        break;
                    case "White":
                        fg = ConsoleColor.White;
                        break;
                    case "Yellow":
                        fg = ConsoleColor.Yellow;
                        break;
                    default:
                        fg = ConsoleColor.White;
                        break;
                }
            }


            Console.BackgroundColor = bg;
            Console.Clear();
            Console.ForegroundColor = fg;

        }



        /// <summary>
        /// Choose a title for your console application.
        /// </summary>
        /// <param name="title">This is where you enter your title.</param>
        public static void Title(string title)
        {
            title = title.ToUpper();
            Console.Title = title;
        }



        /// <summary>
        /// This will create a perzonalized header for your console application.
        /// </summary>
        /// <param name="header">Write your header text here.</param>
        public static void Header(string header)
        {
            Console.WriteLine();
            Console.WriteLine("***************************************");
            Console.WriteLine();
            Console.WriteLine("  " + header);
            Console.WriteLine();
            Console.WriteLine("***************************************");
            Console.WriteLine();
        }
    }
}
