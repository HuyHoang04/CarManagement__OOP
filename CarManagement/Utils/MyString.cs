public static class MyString
{
        public static string UperCase(string name)
        {
            string[] subs = name.Split(' ');
            string fin = " ";
            foreach (string word in subs)
            {
                fin += word.Substring(0, 1).ToUpper() + word.Substring(1) + " ";
            }
            return fin;
        }

}