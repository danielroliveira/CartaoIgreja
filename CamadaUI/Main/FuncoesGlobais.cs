﻿using CamadaDTO;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static CamadaUI.Utilidades;

namespace CamadaUI
{
	public enum DialogType { SIM_NAO, OK, OK_CANCELAR, SIM_NAO_CANCELAR }
	public enum DialogIcon { Question, Information, Exclamation, Warning }
	public enum DialogDefaultButton { First, Second, Third }
	public enum EnumFlagEstado { RegistroSalvo = 1, Alterado = 2, NovoRegistro = 3, RegistroBloqueado = 4 }
	public enum EnumDataTipo { PassadoOuFuturo = 0, Passado = 1, PassadoPresente = 2, Futuro = 3, FuturoPresente = 4 } // ENUM PARA frmDataInformar

	public static class FuncoesGlobais
	{
		public static string appDataSavePath = Environment.GetFolderPath(
			Environment.SpecialFolder.ApplicationData)
			+ "\\CartaoIgreja";

		// GET PATH OF DATABASE
		//==============================================================================================
		public static string DBPath()
		{
			// 1. check config database path
			var DBPathConfig = ObterDefault("DBPath");
			bool ExistsDefaultDBPath = false;

			if (!string.IsNullOrEmpty(DBPathConfig))
			{
				ExistsDefaultDBPath = true;

				if (Directory.Exists(DBPathConfig))
				{
					if (File.Exists(DBPathConfig + "\\CartaoIgrejaDB.mdb"))
					{
						return DBPathConfig + "\\CartaoIgrejaDB.mdb";
					}
				}
			}

			// 2. check default folder
			if (ExistsDefaultDBPath)
			{
				var resp = AbrirDialog("A pasta padrão do Banco de Dados está definida no Config, " +
								"porém não há um Banco de Dados válido na pasta...\n\n" +
								"Deseja copiar um Banco de Dados vazio para a pasta padrão?",
								"Não há Banco de Dados",
								DialogType.SIM_NAO,
								DialogIcon.Question, DialogDefaultButton.Second);

				// 3. copy original empty database
				if (resp == DialogResult.Yes)
				{
					//--- create directory
					Directory.CreateDirectory(DBPathConfig);

					var OriginalFile = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Database\\CartaoIgrejaDB.mdb";
					var DestFile = DBPathConfig + "\\CartaoIgrejaDB.mdb";

					File.Copy(OriginalFile, DestFile);

					return DestFile;
				}
			}
			else
			{
				AbrirDialog("Favor definir a pasta padrão do Banco de Dados no config Geral...",
					"Pasta do Banco de Dados", DialogType.OK, DialogIcon.Exclamation);
				throw new AppException("Banco de Dados Inválido...");
			}

			return null;
		}

		#region CONFIG CREATE | LOAD | CHANGE

		// CHECK IF EXIST CONFIG
		//==============================================================================================
		public static bool VerificaConfigXML()
		{
			string FindXML = appDataSavePath + "\\Config.xml";

			try
			{
				if (File.Exists(FindXML))
				{
					return true;
				}
				else
				{
					CriarConfigXML();
					AbrirDialog("O arquivo de Configuração não foi encontrado...\n" +
						"Uma nova confirguração foi criada. Favor informar os dados necessários.",
						"Configuração", DialogType.OK, DialogIcon.Exclamation);
					return VerificaConfigXML();
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// CREATE CONFIG XML
		//==============================================================================================
		public static void CriarConfigXML()
		{
			try
			{
				new XDocument(
					new XElement("Configuracao",
						new XElement("DefaultValues",
							new XElement("IgrejaTitulo", ""),
							new XElement("CidadePadrao", ""),
							new XElement("UFPadrao", ""),
							new XElement("FotosImageFolder", ""),
							new XElement("DesignImageFolder", ""),
							new XElement("ValidadeAnos", "1"),
							new XElement("ImageOrigin"),
							new XElement("CredentialPath"),
							new XElement("DBPath")
						),
						new XElement("DadosIgreja",
							new XElement("RazaoSocial"),
							new XElement("CNPJ"),
							new XElement("TelefonePrincipal"),
							new XElement("TelefoneFinanceiro"),
							new XElement("ContatoFinanceiro"),
							new XElement("Endereco"),
							new XElement("Bairro"),
							new XElement("Cidade"),
							new XElement("UF"),
							new XElement("CEP")
						)
					)
				)
				.Save(appDataSavePath + "\\Config.xml");

			}
			catch (Exception ex)
			{
				AbrirDialog(ex.Message, "Exceção XML",
					DialogType.OK, DialogIcon.Exclamation);
			}
		}

		// GET CONFIG XML DEFAULT VALUE
		// =============================================================================
		public static string ObterDefault(string CampoDefault)
		{
			try
			{
				XmlDocument config = MyConfig();
				if (config != null)
				{
					return config.SelectSingleNode("Configuracao").SelectSingleNode("DefaultValues").SelectSingleNode(CampoDefault).InnerText;
				}
				else
				{
					return string.Empty;
				}
			}
			catch
			{
				return string.Empty;
			}
		}

		// GET CONFIG XML FILE
		// =============================================================================
		public static XmlDocument MyConfig()
		{
			if (VerificaConfigXML())
			{
				XmlDocument myXML = new XmlDocument();

				try
				{
					myXML.Load(appDataSavePath + "\\Config.xml");
					return myXML;
				}
				catch (Exception ex)
				{
					throw ex;
				}
			}
			else
			{
				return null;
			}
		}

		// OBTER VALOR DO NODE XML DO ARQUIVO CONFIGXML PELO NOME
		// =============================================================================
		public static string ObterConfigValorNode(string NodeName)
		{
			XmlNodeList elemList = MyConfig().GetElementsByTagName(NodeName);
			string myValor = "";

			for (int i = 0; i < elemList.Count; i++)
			{
				myValor = elemList[i].InnerXml;
			}

			return myValor;

		}

		// SAVE CONFIG XML DEFAULT VALUE
		// =============================================================================
		public static bool SaveDefault(string CampoDefault, string NewValorDefault)
		{
			try
			{
				XmlDocument xmlConfig = MyConfig();
				XmlNode myNode = xmlConfig.SelectSingleNode("/Configuracao/DefaultValues/" + CampoDefault);

				if (myNode != null)
				{
					myNode.InnerText = NewValorDefault;
					xmlConfig.Save(appDataSavePath + "\\Config.xml");
					return true;
				}
				else
				{
					throw new Exception("O XMLNode não foi encontrado...");
				}

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// SAVE CONFIG NODE VALOR CONFIGXML PELO NOME
		// =============================================================================
		public static bool SaveConfigValorNode(string NodeName, string NodeValue)
		{
			try
			{
				XmlDocument xmlConfig = MyConfig();

				if (xmlConfig == null)
				{
					CriarConfigXML();
					xmlConfig = MyConfig();
				}

				XmlNodeList elemList = xmlConfig.GetElementsByTagName(NodeName);

				if (elemList.Count > 0)
				{
					elemList[0].InnerXml = NodeValue;
					xmlConfig.Save(appDataSavePath + "\\Config.xml");
				}
				else
				{
					throw new AppException("O xmlNode não foi encontrado...");
				}

				return true;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// GET DADOS IGREJA
		//------------------------------------------------------------------------------------------------------------
		public static objDadosIgreja ObterDadosIgreja()
		{
			try
			{
				objDadosIgreja DadosEmpresa = new objDadosIgreja()
				{
					RazaoSocial = ObterConfigValorNode("RazaoSocial"),
					TelefoneFinanceiro = ObterConfigValorNode("TelefoneFinanceiro"),
					TelefonePrincipal = ObterConfigValorNode("TelefonePrincipal"),
					CNPJ = ObterConfigValorNode("CNPJ"),
					ContatoFinanceiro = ObterConfigValorNode("ContatoFinanceiro"),
					Endereco = ObterConfigValorNode("Endereco"),
					Bairro = ObterConfigValorNode("Bairro"),
					Cidade = ObterConfigValorNode("Cidade"),
					UF = ObterConfigValorNode("UF"),
					CEP = ObterConfigValorNode("CEP"),
					ArquivoLogoColor = ObterConfigValorNode("ArquivoLogoColor"),
					ArquivoLogoMono = ObterConfigValorNode("ArquivoLogoMono")
				};

				return DadosEmpresa;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		#endregion

		#region CHECK CONTROLS TO SAVE

		//=================================================================================================
		// BOOLEAN VERIFICA CONTROLES E RETORNA MENSAGEM
		//=================================================================================================
		public static bool VerificaControle(Control controle, string controleNome)
		{
			bool IsNullOrEmpty = false;

			switch (controle.GetType())
			{
				case Type textboxType when textboxType == typeof(TextBox):

					if (controle.Text.Trim().Length == 0) IsNullOrEmpty = true;
					break;

				case Type ComboBox when ComboBox == typeof(ComboBox):

					ComboBox combo = (ComboBox)controle;
					if (combo.SelectedValue == null) IsNullOrEmpty = true;
					break;

				case Type DTPickerType when DTPickerType == typeof(DateTimePicker):

					DateTimePicker dtPicker = (DateTimePicker)controle;
					if (dtPicker.Value == null) IsNullOrEmpty = true;
					break;

				default:
					break;
			}

			if (IsNullOrEmpty)
			{
				AbrirDialog("O campo: " + controleNome + "\nnão pode ficar vazio...\n" +
							"Favor preencher o campo informado.",
							"Campo Obrigatório", DialogType.OK, DialogIcon.Exclamation);
				controle.Focus();
				return false;
			}

			return true;
		}

		//=================================================================================================
		// FUNÇAO QUE VERIFICA OS DADOS DO CONTROLES/CAMPOS E RETORNA SE ESTA PREENCHIDO
		//=================================================================================================
		public static bool VerificaDadosClasse(Control control,
			string controlTexto,
			object minhaClasse,
			ErrorProvider errorProvider = null)
		{
			//--- GET O NOME DA PROPERTY
			string myPropertyName;

			if (control.DataBindings["text"] != null)
			{
				myPropertyName = control.DataBindings["text"].BindingMemberInfo.BindingField;
			}
			else if (control.DataBindings["SelectedValue"] != null)
			{
				myPropertyName = control.DataBindings["SelectedValue"].BindingMemberInfo.BindingField;
			}
			else if (control.DataBindings["Value"] != null)
			{
				myPropertyName = control.DataBindings["Value"].BindingMemberInfo.BindingField;
			}
			else
			{
				AbrirDialog("Um erro inesperado ocorreu ao verificar os controles...",
							"Erro Inseperado", DialogType.OK, DialogIcon.Exclamation);
				return false;
			}

			//--- GET PROPERTY
			PropertyInfo pInfo = minhaClasse.GetType().GetProperty(myPropertyName);
			var value = pInfo.GetValue(minhaClasse, null);

			//--- GET TYPE OF VALUE
			Type type = value?.GetType();

			//--- CHECK IF EMPTY OR NULL
			bool IsEmptyOrNull = false;

			if (type == typeof(string) && (string)value == "") IsEmptyOrNull = true;
			else if (value == null) IsEmptyOrNull = true;

			//--- VERIFY PROPERTY VALUE
			if (IsEmptyOrNull)
			{
				//--- MENSAGEM E ERROR PROVIDER
				AbrirDialog("O campo " + controlTexto.ToUpper() + " não pode ficar vazio;\n" +
							"Preencha esse campo antes de Salvar o registro por favor...",
							"Campo Vazio", DialogType.OK, DialogIcon.Warning);

				//--- CONTROLA O ERROR PROVIDER
				if (errorProvider == null)
				{
					ErrorProvider EP = new ErrorProvider();
					EP.SetError(control, "Preencha o valor desse campo!");
				}
				else
				{
					errorProvider.SetError(control, "Preencha o valor desse campo!");
				}

				//--- DEVOLVE O FOCO AO CONTROLE
				control.Focus();

				//--- RETORNA
				return false;
			}

			//--- RETORNA
			return true;
		}

		#endregion

		#region CONTROLE DO MENU

		//--- OCULTAR E REVELAR O MENU PRINCIPAL
		public static void OcultaMenuPrincipal()
		{
			Main.frmPrincipal frm = Application.OpenForms.OfType<Main.frmPrincipal>().First();
			frm.mnuPrincipal.Visible = false;
			frm.pnlTop.BackColor = Color.Gainsboro;
			frm.btnConfig.Enabled = false;
		}

		//--- REVELA MENU PRINCIPAL
		public static void MostraMenuPrincipal()
		{
			if (Application.OpenForms.Count == 0) return;
			Main.frmPrincipal frm = Application.OpenForms.OfType<Main.frmPrincipal>().First();
			frm.mnuPrincipal.Visible = true;
			frm.mnuPrincipal.Enabled = true;
			frm.pnlTop.BackColor = Color.SlateGray;
			frm.btnConfig.Enabled = true;
		}

		//--- DESABILITA MENU PRINCIPAL
		public static void DesativaMenuPrincipal()
		{
			OcultaMenuPrincipal();
			/*
			frmPrincipal frm = Application.OpenForms.OfType<frmPrincipal>().First();
			frm.mnuPrincipal.Enabled = false;
			frm.pnlTop.BackColor = Color.SlateGray;
			frm.btnConfig.Enabled = false;
			*/
		}

		#endregion

	}
}
