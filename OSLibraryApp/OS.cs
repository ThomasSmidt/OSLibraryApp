namespace OSLibraryApp
{
    public class OS : IOS
    {
        public string UserFullName { get; set; }
        public OS(string userFullName)
        {
            UserFullName = userFullName;
        }
        public virtual string ShowOS()
        {
            return "No valid operating system detected";
        }
    }
}