namespace CSCI2910_Lab4
{
    public class FileRoot
    {
        public static string Root => Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
    }
}
