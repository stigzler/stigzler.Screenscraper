using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace stigzler.Screenscraper.Extensions
{
    internal static class Xml
    {
        public static string TryGetElementValue(this XElement parentEl, string elementName, string defaultValue = null)
        {
            var foundEl = parentEl.Element(elementName);

            if (foundEl != null)
            {
                return foundEl.Value;
            }

            return defaultValue;
        }

        public static string TryGetAttributeValue(this XElement parentEl, string elementName, string defaultValue = null)
        {
            var foundEl = parentEl.Attribute(elementName);

            if (foundEl != null)
            {
                return foundEl.Value;
            }

            return defaultValue;
        }
    }
}
