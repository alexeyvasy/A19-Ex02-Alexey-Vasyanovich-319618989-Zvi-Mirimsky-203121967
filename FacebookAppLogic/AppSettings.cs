using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace FacebookAppLogic
{
    public class AppSettings
    {
        public static AppSettings LoadFromFile()
        {
            AppSettings appSettings = null;
            if (File.Exists(@"C:\Temp\appSettings.xml"))
            {
                using (Stream stream = new FileStream(@"C:\Temp\appSettings.xml", FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    object obj = serializer.Deserialize(stream);
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

        public string m_LastAccessToken { get; set; }

        public AppSettings()
        {
            initialize();
        }

        public void SaveToFile()
        {
            if (File.Exists(@"C:\Temp\appSettings.xml"))
            {
                File.Delete(@"C:\Temp\appSettings.xml");
            }

            using (Stream stream = new FileStream(@"C:\Temp\appSettings.xml", FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }

        private void initialize()
        {
            m_LastWindowLocation = new Point(100, 100);
            m_LastWindowSize = new Size(600, 1000);
            m_RememberUser = false;
            m_LastAccessToken = string.Empty;
        }
    }
}
