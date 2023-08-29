namespace OSLibraryApp
{
    public class OS : IOS
    {
        public string userFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        public string UserFullName { get; set; }
        public OS(string userFullName)
        {
        }
        public string ShowOS()
        {
            return "No OS Detected";
        }
    }
}