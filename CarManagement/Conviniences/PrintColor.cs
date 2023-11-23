
    public static class PrintColor
    {
        public static ConsoleColor colorStud;
        public static ConsoleColor colorSubj;
        static PrintColor()
        {
            DayOfWeek today = DateTime.Now.DayOfWeek;

            switch (today)
            {
                case DayOfWeek.Monday:
                    colorStud = ConsoleColor.Blue;
                    colorSubj = ConsoleColor.Green;
                    break;
                case DayOfWeek.Tuesday:
                    colorStud = ConsoleColor.Red;
                    colorSubj = ConsoleColor.Yellow;

                    break;
                case DayOfWeek.Wednesday:
                    colorStud = ConsoleColor.Red;
                    colorSubj = ConsoleColor.DarkBlue;

                    break;
                case DayOfWeek.Thursday:
                    colorStud = ConsoleColor.DarkYellow;
                    colorSubj = ConsoleColor.DarkMagenta;

                    break;
                case DayOfWeek.Friday:
                    colorStud = ConsoleColor.DarkBlue;
                    colorSubj = ConsoleColor.Yellow;

                    break;
                case DayOfWeek.Saturday:
                    colorStud = ConsoleColor.Gray;
                    colorSubj = ConsoleColor.Yellow;
                    break;
                case DayOfWeek.Sunday:
                    colorStud = ConsoleColor.Red;
                    colorSubj = ConsoleColor.Blue;
                    break;
            }
        }

    }

