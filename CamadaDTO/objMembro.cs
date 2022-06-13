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
			internal int? _RGMembro;
			internal string _MembroNome;
			internal DateTime? _NascimentoData;
			internal byte _Sexo; // 1 : Masculino | 2 : Feminino
			internal DateTime? _MembresiaData;
			internal DateTime? _BatismoData;
			internal DateTime? _EmissaoData;
			internal DateTime? _ValidadeData;
			internal objEstadoCivil _EstadoCivil;
			//internal byte _IDEstadoCivil;
			//internal string _EstadoCivilM;
			//internal string _EstadoCivilF;
			internal byte? _IDCongregacao;
			internal string _Congregacao;
			internal objFuncao _Funcao;
			//internal byte _IDFuncao;
			//internal string _Funcao;
			//internal string _ImagemCartaoFrente;
			//internal string _ImagemCartaoVerso;
			//internal string _ImagemFoto;
			internal bool _Imprimir;
			internal bool _NaLista;
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
				_EstadoCivil = new objEstadoCivil() { IDEstadoCivil = 1, EstadoCivil = "Solteiro(a)" },
				_IDMembro = IDMembro,
				_MembroNome = "",
				_NascimentoData = DateTime.Today.AddYears(-10),
				_IDSituacao = 1,
				_Situacao = "Ativo",
				_Imprimir = true,
				_NaLista = false,
				_Funcao = new objFuncao() { IDFuncao = 2, Funcao = "Membro" },
				//_EmissaoData = DateTime.Today,
				_IDCongregacao = null,
				_MembresiaData = DateTime.Today,
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
			set => EditData._IDMembro = value;
		}

		// Property RGMembro
		//---------------------------------------------------------------
		public int? RGMembro
		{
			get => EditData._RGMembro;
			set
			{
				if (value != EditData._RGMembro)
				{
					EditData._RGMembro = value;
					NotifyPropertyChanged("RGMembro");
				}
			}
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

		// Property BatismoData
		//---------------------------------------------------------------
		public DateTime? BatismoData
		{
			get => EditData._BatismoData;
			set
			{
				if (value != EditData._BatismoData)
				{
					EditData._BatismoData = value;
					NotifyPropertyChanged("BatismoData");
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
			get => EditData._EstadoCivil.IDEstadoCivil;
			set
			{
				if (value != EditData._EstadoCivil.IDEstadoCivil)
				{
					EditData._EstadoCivil.IDEstadoCivil = value;
					NotifyPropertyChanged("IDEstadoCivil");
				}
			}
		}

		// Property EstadoCivil
		//---------------------------------------------------------------
		public string EstadoCivil
		{
			get => EditData._EstadoCivil.EstadoCivil;
			set
			{
				if (value != EditData._EstadoCivil.EstadoCivil)
				{
					EditData._EstadoCivil.EstadoCivil = value;
					NotifyPropertyChanged("EstadoCivil");
				}
			}
		}

		// Property EstadoCivilM
		//---------------------------------------------------------------
		public string EstadoCivilM
		{
			get => EditData._EstadoCivil.EstadoCivilM;
			set
			{
				if (value != EditData._EstadoCivil.EstadoCivilM)
				{
					EditData._EstadoCivil.EstadoCivilM = value;
					NotifyPropertyChanged("EstadoCivilM");
				}
			}
		}

		// Property EstadoCivilF
		//---------------------------------------------------------------
		public string EstadoCivilF
		{
			get => EditData._EstadoCivil.EstadoCivilF;
			set
			{
				if (value != EditData._EstadoCivil.EstadoCivilF)
				{
					EditData._EstadoCivil.EstadoCivilF = value;
					NotifyPropertyChanged("EstadoCivilF");
				}
			}
		}

		// Property IDCongregacao
		//---------------------------------------------------------------
		public byte? IDCongregacao
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
		public byte? IDFuncao
		{
			get => EditData._Funcao.IDFuncao;
			set
			{
				if (value != EditData._Funcao.IDFuncao)
				{
					EditData._Funcao.IDFuncao = value;
					NotifyPropertyChanged("IDFuncao");
				}
			}
		}

		// Property Funcao
		//---------------------------------------------------------------
		public string Funcao
		{
			get => EditData._Funcao.Funcao;
			set
			{
				if (value != EditData._Funcao.Funcao)
				{
					EditData._Funcao.Funcao = value;
					NotifyPropertyChanged("Funcao");
				}
			}
		}

		// Property ImagemCartaoFrente
		//---------------------------------------------------------------
		public string ImagemCartaoFrente
		{
			get => EditData._Funcao.ImagemCartaoFrente;
			set
			{
				if (value != EditData._Funcao.ImagemCartaoFrente)
				{
					EditData._Funcao.ImagemCartaoFrente = value;
					NotifyPropertyChanged("ImagemCartaoFrente");
				}
			}
		}

		// Property ImagemCartaoVerso
		//---------------------------------------------------------------
		public string ImagemCartaoVerso
		{
			get => EditData._Funcao.ImagemCartaoVerso;
			set
			{
				if (value != EditData._Funcao.ImagemCartaoVerso)
				{
					EditData._Funcao.ImagemCartaoVerso = value;
					NotifyPropertyChanged("ImagemCartaoVerso");
				}
			}
		}

		// Property ImagemFoto
		//---------------------------------------------------------------
		public string ImagemFoto { get; set; }

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

		// Property NaLista
		//---------------------------------------------------------------
		public bool NaLista
		{
			get => EditData._NaLista;
			set
			{
				if (value != EditData._NaLista)
				{
					EditData._NaLista = value;
					NotifyPropertyChanged("NaLista");
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

		//public Image CodBarras { get; set; }

		public string CodBarrasFile { get; set; }
	}
}
