using System.Configuration;

namespace ConsoleApplication12
{
    public class UrlsSection : ConfigurationSection
    {
        private const string NAME   = "name";
        private const string SIMPLE = "simple";
        private const string URLS   = "urls";

        [ConfigurationProperty("name", DefaultValue = "MyFavorites", IsRequired = true, IsKey = false)]
        [StringValidator(InvalidCharacters = " ~!@#$%^&*()[]{}/;'\"|\\", MinLength = 1, MaxLength = 60)]
        public string Name
        {
            get { return (string)this[NAME]; }
            set { this[NAME] = value; }
        }

        // Declare a collection element represented
        // in the configuration file by the sub-section
        // <urls> <add .../> </urls>
        // Note: the "IsDefaultCollection = false"
        // instructs the .NET Framework to build a nested
        // section like <urls> ...</urls>.
        [ConfigurationProperty(URLS, IsDefaultCollection = false)]
        public UrlsCollection Urls => (UrlsCollection)base[URLS];
    }
}
