using System;
using System.Xml;

namespace CamadaDAL
{
	public class GetConnection
	{
		public string LoadConnectionString(string SourceXMLFile, string stringName)
		{
			XmlDocument doc = new XmlDocument();

			//--- Try open XML Document
			try
			{
				doc.Load(SourceXMLFile);
			}
			catch (Exception ex)
			{
				throw new Exception("Uma exceção ocorreu ao Ler o arquivo XML... \n" +
									ex.Message);
			}

			foreach (XmlNode node in doc.GetElementsByTagName("setting"))
			{
				if (node.Attributes["name"].Value == stringName)
				{
					return node.SelectSingleNode("value").InnerText;
				}
			}

			return null;
		}

		public bool SaveConnectionStringLocation(string SourceXMLFile, string stringName)
		{
			try
			{
				Properties.Settings.Default.ConexaoStringFile = SourceXMLFile;
				Properties.Settings.Default.ConexaoStringName = stringName;
				Properties.Settings.Default.Save();
				return true;
			}
			catch (Exception ex)
			{
				throw ex;
			}

		}
	}
}