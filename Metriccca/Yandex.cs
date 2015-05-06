using System;
using System.Windows.Forms;
using System.Xml;


namespace Metriccca
{
    class Yandex
    {
        public static string visits_var, page_views_var, visitors_var;

        public static void Request()
        {
            try
            {
                Properties.Settings ps = Properties.Settings.Default;
                String xmlUrl = "http://api-metrika.yandex.ru/stat/traffic/summary?id=" + ps.CounterID + "&date1=" +
                                ps.Date1 + "&date2=" + ps.Date2 + "&oauth_token=" + ps.YaTocen;

                var xmlReader = XmlReader.Create(xmlUrl);
                XmlDocument xml = new XmlDocument();

                xml.Load(xmlReader);
                XmlWorker(xml);
            }
            catch (Exception)
            {

                MessageBox.Show("Сервіс недоступний \nВнутрішня помилка сервера! \nПеревірте з'єднання з мережею", "Сталась помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static void XmlWorker(XmlDocument xml)
        {
            XmlNode xmlNode = xml.GetElementsByTagName("totals").Item(0);

            if (xmlNode != null)
                foreach (XmlNode node in xmlNode.ChildNodes)
                {

                    switch (node.Name)
                    {
                        case "visits":
                            visits_var = node.InnerText;
                            break;
                        case "page_views":
                            page_views_var = node.InnerText;
                            break;
                        case "visitors":
                            visitors_var = node.InnerText;
                            break;
                    }

                }
        }
    }
}
