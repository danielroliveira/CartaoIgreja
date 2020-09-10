using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CamadaDTO
{
	public class objMembro : IEditableObject, INotifyPropertyChanged
	{
		// STRUCTURE
		//-------------------------------------------------------------------------------------------------
		struct StructMembro
		{
			internal int? _IDMembro;
			internal string _MembroNome;
			internal DateTime? _NascimentoData;
			internal byte _Sexo; // 1 : Masculino | 2 : Feminino
			internal DateTime? _MembresiaData;
			internal DateTime? _EmissaoData;
			internal DateTime? _ValidadeData;
			internal byte _IDEstadoCivil;
			internal string _EstadoCivilM;
			internal string _EstadoCivilF;
			internal byte _IDCongregacao;
			internal string _Congregacao;
			internal byte _IDFuncao;
			internal string _Funcao;
			internal bool _Imprimir;
			internal byte _IDSituacao;
			internal string _Situacao;
		}

		// VARIABLES | CONSTRUCTOR
		//-------------------------------------------------------------------------------------------------
		private StructMembro EditData;
		private StructMembro BackupData;
		private bool inTxn = false;

		public objMembro(int? IDMembro) : base()
		{
			EditData = new StructMembro()
			{
				_IDMembro = IDMembro,
				_MembroNome = "",
				_NascimentoData = null,
				_IDSituacao = 1,
				_Situacao = "Ativo",
				_Imprimir = true,
				_IDFuncao = 2,
				_Funcao = "Membro",
				_IDEstadoCivil = 1,
				_EmissaoData = DateTime.Today,
			};
		}

		// IEDITABLE OBJECT IMPLEMENTATION
		//-------------------------------------------------------------------------------------------------
		public void BeginEdit()
		{
			if (!inTxn)
			{
				BackupData = EditData;
				inTxn = true;
			}
		}

		public void CancelEdit()
		{
			if (inTxn)
			{
				EditData = BackupData;
				inTxn = false;
			}
		}

		public void EndEdit()
		{
			if (inTxn)
			{
				BackupData = new StructMembro();
				inTxn = false;
			}
		}

		// PROPERTY CHANGED
		//------------------------------------------------------------------------------------------------------------
		public event PropertyChangedEventHandler PropertyChanged;

		private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		public override string ToString()
		{
			return EditData._MembroNome;
		}

		public bool RegistroAlterado
		{
			get => inTxn;
		}

		//=================================================================================================
		// PROPERTIES
		//=================================================================================================
		public int? IDMembro
		{
			get => EditData._IDMembro;
		}

		// Property MembroNome
		//----------------------------------------------------------------
		public string MembroNome
		{
			get => EditData._MembroNome;
			set
			{
				if (value != EditData._MembroNome)
				{
					EditData._MembroNome = value;
					NotifyPropertyChanged("Membro");
				}
			}
		}

		// Property NascimentoData
		//---------------------------------------------------------------
		public DateTime? NascimentoData
		{
			get => EditData._NascimentoData;
			set
			{
				if (value != EditData._NascimentoData)
				{
					EditData._NascimentoData = value;
					NotifyPropertyChanged("NascimentoData");
				}
			}
		}

		// Property Sexo
		//---------------------------------------------------------------
		public byte Sexo
		{
			get => EditData._Sexo;
			set
			{
				if (value != EditData._Sexo)
				{
					EditData._Sexo = value;
					NotifyPropertyChanged("Sexo");
				}
			}
		}

		// Property MembresiaData
		//---------------------------------------------------------------
		public DateTime? MembresiaData
		{
			get => EditData._MembresiaData;
			set
			{
				if (value != EditData._MembresiaData)
				{
					EditData._MembresiaData = value;
					NotifyPropertyChanged("MembresiaData");
				}
			}
		}

		// Property EmissaoData
		//---------------------------------------------------------------
		public DateTime? EmissaoData
		{
			get => EditData._EmissaoData;
			set
			{
				if (value != EditData._EmissaoData)
				{
					EditData._EmissaoData = value;
					NotifyPropertyChanged("EmissaoData");
				}
			}
		}

		// Property ValidadeData
		//---------------------------------------------------------------
		public DateTime? ValidadeData
		{
			get => EditData._ValidadeData;
			set
			{
				if (value != EditData._ValidadeData)
				{
					EditData._ValidadeData = value;
					NotifyPropertyChanged("ValidadeData");
				}
			}
		}

		// Property IDEstadoCivil
		//---------------------------------------------------------------
		public byte IDEstadoCivil
		{
			get => EditData._IDEstadoCivil;
			set
			{
				if (value != EditData._IDEstadoCivil)
				{
					EditData._IDEstadoCivil = value;
					NotifyPropertyChanged("IDEstadoCivil");
				}
			}
		}

		// Property EstadoCivil
		//---------------------------------------------------------------
		public string EstadoCivil
		{
			get 
			{
				if (Sexo == 1)
				{
					return EditData._EstadoCivilM;
				}
				else if(Sexo == 2)
				{
					return EditData._EstadoCivilF;
				}
				else
				{
					return "";
				}
			}

			set
			{
				if (value != EditData._EstadoCivilM && value != EditData._EstadoCivilF)
				{

					if (Sexo == 1)
					{
						EditData._EstadoCivilM = value;
					}
					else if (Sexo == 2)
					{
						EditData._EstadoCivilF = value;
					}

					NotifyPropertyChanged("EstadoCivil");
				}
			}
		}

		// Property IDCongregacao
		//---------------------------------------------------------------
		public byte IDCongregacao
		{
			get => EditData._IDCongregacao;
			set
			{
				if (value != EditData._IDCongregacao)
				{
					EditData._IDCongregacao = value;
					NotifyPropertyChanged("IDCongregacao");
				}
			}
		}

		// Property Congregacao
		//---------------------------------------------------------------
		public string Congregacao
		{
			get => EditData._Congregacao;
			set
			{
				if (value != EditData._Congregacao)
				{
					EditData._Congregacao = value;
					NotifyPropertyChanged("Congregacao");
				}
			}
		}

		// Property IDFuncao
		//---------------------------------------------------------------
		public byte IDFuncao
		{
			get => EditData._IDFuncao;
			set
			{
				if (value != EditData._IDFuncao)
				{
					EditData._IDFuncao = value;
					NotifyPropertyChanged("IDFuncao");
				}
			}
		}

		// Property Funcao
		//---------------------------------------------------------------
		public string Funcao
		{
			get => EditData._Funcao;
			set
			{
				if (value != EditData._Funcao)
				{
					EditData._Funcao = value;
					NotifyPropertyChanged("Funcao");
				}
			}
		}

		// Property Imprimir
		//---------------------------------------------------------------
		public bool Imprimir
		{
			get => EditData._Imprimir;
			set
			{
				if (value != EditData._Imprimir)
				{
					EditData._Imprimir = value;
					NotifyPropertyChanged("Imprimir");
				}
			}
		}

		// Property IDSituacao
		//---------------------------------------------------------------
		public byte IDSituacao
		{
			get => EditData._IDSituacao;
			set
			{
				if (value != EditData._IDSituacao)
				{
					EditData._IDSituacao = value;
					NotifyPropertyChanged("IDSituacao");
				}
			}
		}

		// Property Situacao
		//---------------------------------------------------------------
		public string Situacao
		{
			get => EditData._Situacao;
			set
			{
				if (value != EditData._Situacao)
				{
					EditData._Situacao = value;
					NotifyPropertyChanged("Situacao");
				}
			}
		}

	}
}
