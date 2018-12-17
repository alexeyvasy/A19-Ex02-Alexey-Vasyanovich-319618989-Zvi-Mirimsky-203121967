using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace DesignPatterns1
{
    public class AppSettings
    {

        public AppSettings()
        {
            initialize();
        }
       
        public void SaveToFile()
        {
            File.Delete(@"C:\Users\user\Documents\Visual Studio 2015\Projects\DesignPatterns1\appSettings.xml");
            using (Stream stream = new FileStream(@"C:\Users\user\Documents\Visual Studio 2015\Projects\DesignPatterns1\appSettings.xml", FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }

        public static AppSettings LoadFromFile()
        {
            AppSettings appSettings = null;
            if (File.Exists(@"C:\Users\user\Documents\Visual Studio 2015\Projects\DesignPatterns1\appSettings.xml"))
            {
                using (Stream stream = new FileStream(@"C:\Users\user\Documents\Visual Studio 2015\Projects\DesignPatterns1\appSettings.xml", FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    Object obj = serializer.Deserialize(stream);
                    appSettings = obj as AppSettings;
                }
            }
            else
            {
                appSettings = new AppSettings();
                appSettings.initialize();
            }

            return appSettings;
        }

        public Point m_LastWindowLocation { get; set; }
        public Size m_LastWindowSize { get; set; }
        public bool m_RememberUser { get; set; }
        public string m_LastAccessToke { get; set; }

         
        private void initialize()
        {
            m_LastWindowLocation = new Point(100, 100);
            m_LastWindowSize = new Size(600, 1000);
            m_RememberUser = false;
            m_LastAccessToke = String.Empty;
        }
    }

}
