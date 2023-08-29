
namespace OSLibraryApp
{
    internal class DisplayOS
    {
        public string DetectAndDisplayOS()
        {
            string userFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            IOS? selectedOS = Identify(userFolder);
            return selectedOS.ShowOS();
        }
        public static IOS Identify(string userFolder)
        {
            if (userFolder.Contains("C:"))
            {
                return new Windows("Thomas Smidt");
            }
            else if (userFolder.Contains("/"))
            {
                return new Linux("Thomas Smidt");
            }
            return null;
        }
    }
}
