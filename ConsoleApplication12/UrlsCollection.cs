using System.Configuration;

namespace ConsoleApplication12
{
    public class UrlsCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new UrlConfigElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((UrlConfigElement)element).Name;
        }
    }
}
