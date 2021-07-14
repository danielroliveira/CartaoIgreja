using CamadaDTO;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static CamadaUI.FuncoesGlobais;

namespace CamadaUI.Main
{
	public static class GDriveControl
	{
		private static UserCredential credential;
		private static DriveService driveService;
		private static string[] Scopes = { DriveService.Scope.Drive };

		private const string _ApplicationName = "Tesouraria Igreja";
		private const string _CredentialName = "credential.json";
		private const string _UserName = "User";

		#region AUTENTICAR GOOGLE DRIVE

		// CHECK ACTIVE CONNECTION
		//------------------------------------------------------------------------------------------------------------
		public static bool GoogleDriveConnection()
		{
			try
			{
				return (GetCredential($"{appDataSavePath}\\{_CredentialName}", _UserName) && CreateDriveService());
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// OBTER CREDENTIAL
		//------------------------------------------------------------------------------------------------------------
		private static bool GetCredential(string clientSecretPath, string userName)
		{
			if (credential != null) return true;

			string savePath = Path.Combine(appDataSavePath, Path.GetFileName(clientSecretPath));

			if (System.IO.File.Exists(savePath))
			{
				try
				{
					using (var stream = new FileStream(savePath, FileMode.Open, FileAccess.Read))
					{
						string credPath = Path.Combine(appDataSavePath, ".credentials");

						credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
							GoogleClientSecrets.FromStream(stream).Secrets,
							Scopes,
							"Drive-" + userName,
							CancellationToken.None,
							new FileDataStore(credPath, true)).Result;
					}
					return true;

				}
				catch (Exception exc)
				{
					//--- Write LOG FILE
					Gtools.writeToFile(frmPrincipal.errorLog, Environment.NewLine + DateTime.Now.ToString() +
							Environment.NewLine + exc.Message + " Get Credential Error.\n");
					//--- return
					return false;
				}
			}
			else
			{
				System.IO.File.Copy(clientSecretPath, Path.Combine(appDataSavePath, Path.GetFileName(clientSecretPath)));
				return GetCredential(clientSecretPath, userName);
			}

		}

		// INICIALIZA O SERVICO GOOGLE DRIVE
		//------------------------------------------------------------------------------------------------------------
		private static bool CreateDriveService()
		{
			if (driveService != null) return true;

			try
			{
				// Create Drive API service.
				driveService = new DriveService(new BaseClientService.Initializer()
				{
					HttpClientInitializer = credential,
					ApplicationName = _ApplicationName,
				});
				return true;
			}
			catch (Exception exc)
			{
				Gtools.writeToFile(frmPrincipal.errorLog, Environment.NewLine + DateTime.Now.ToString() +
							Environment.NewLine + exc.Message + " Create Drive Service Error.\n");
				return false;
			}

		}

		// DELETE CREDENTIAL FILE
		//------------------------------------------------------------------------------------------------------------
		public static void deleteCredFile(string savePath, string userName)
		{
			string[] files = Directory.GetFiles(Path.Combine(savePath, ".credentials"));
			foreach (string file in files)
			{
				if (userName == file.Split('-').Last())
				{
					System.IO.File.Delete(file);
				}
			}
		}

		#endregion // AUTENTICAR GOOGLE DRIVE --- END

		#region IMAGE / FOTOS GOOGLE DRIVE FUNCTIONS

		// RETORNA ID DA PASTA DE FOTOS
		//------------------------------------------------------------------------------------------------------------
		public static async Task<string> GetFotosFolderID()
		{
			try
			{
				//--- GET FotosImage Folder
				string FolderImageName = ObterDefault("FotosImageFolder");

				if (string.IsNullOrEmpty(FolderImageName))
				{
					throw new Exception("A pasta de Fotos no Google Drive não foi definida ainda na configuração...");
				}

				string[] ID = await ProcurarArquivoId(FolderImageName, "", false);

				if (ID != null && ID.Count() > 0)
				{
					return ID[0];
				}
				else
				{
					//--- find Membresia folder
					string[] IDParentArray = await ProcurarArquivoId("Membresia", "", false);
					string IDParent = (IDParentArray != null && IDParentArray.Count() > 0) ? IDParentArray[0] : string.Empty;

					if (string.IsNullOrEmpty(IDParent))
					{
						IDParent = CreateFolderToDrive("Membresia", "");
					}

					CreateFolderToDrive(FolderImageName, IDParent);
				}

				return string.Empty;
			}
			catch
			{
				throw;
			}
		}

		// RETORNA UMA IMAGEM DA PASTA DE FOTOS
		//------------------------------------------------------------------------------------------------------------
		public static async Task<Image> GetImageFromDrive(string nome)
		{
			try
			{
				if (!GoogleDriveConnection())
				{
					throw new Exception("Não conectado");
				}

				Image image = null;

				//--- check IMAGE FOLDER
				string IDFotoFolder = await GetFotosFolderID();

				if (IDFotoFolder == null)
				{
					throw new Exception("Não há pasta de Fotos no Drive...");
				}

				//--- check FILE ID
				string[] IDImageFile = await ProcurarArquivoId(nome, IDFotoFolder);

				if (IDImageFile != null && IDImageFile.Any())
				{
					var request = driveService.Files.Get(IDImageFile.First());

					//--- GET File by ID
					using (var stream = new MemoryStream())
					{
						request.Download(stream);
						image = Image.FromStream(stream);
					}
				}
				else
				{
					return null;
				}

				return image;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// SAVE IMAGE/FOTO IN DEFAULT DRIVE FOLDER AND RETURN NEW FILE ID
		//------------------------------------------------------------------------------------------------------------
		public async static Task<string> SaveFileInDriveImageFolder(string _caminhoArquivo, string _newName, Membros.frmMembro parent)
		{
			try
			{
				if (!GoogleDriveConnection())
				{
					throw new Exception("Não conectado");
				}

				//--- check IMAGE FOLDER
				string IDFotoFolder = await GetFotosFolderID();

				if (string.IsNullOrEmpty(IDFotoFolder))
				{
					throw new Exception("Não há pasta de Fotos no Drive...");
				}

				//--- Check file already exists in folder
				string[] OlderFileID = await ProcurarArquivoId(_newName, IDFotoFolder, false);

				//--- Define/Create file to UPLOAD
				var arquivo = new Google.Apis.Drive.v3.Data.File()
				{
					Name = _newName,
					MimeType = "image/jpeg",
					Parents = new List<string> { IDFotoFolder }
				};

				string newFileID;

				using (var stream = new FileStream(_caminhoArquivo, FileMode.Open, FileAccess.Read)) //new System.IO.MemoryStream(byteArray)) //new FileStream(_caminhoArquivo, FileMode.Open, FileAccess.Read))
				{
					if (OlderFileID == null || !OlderFileID.Any())
					{
						FilesResource.CreateMediaUpload request;
						request = driveService.Files.Create(arquivo, stream, arquivo.MimeType);
						request.Fields = "id";
						request.ChunkSize = Google.Apis.Upload.ResumableUpload.MinimumChunkSize;
						request.ProgressChanged += (IUploadProgress) => Request_ProgressChanged(IUploadProgress, parent);
						request.Upload();

						var file = request.ResponseBody;
						newFileID = file.Id;
					}
					else
					{
						// get File ID
						string FileID = OlderFileID.First();

						// clear Parents
						arquivo.Parents = null;

						// create request
						FilesResource.UpdateMediaUpload request;
						request = driveService.Files.Update(arquivo, FileID, stream, arquivo.MimeType);
						request.Fields = "id,md5Checksum"; ;
						request.ChunkSize = Google.Apis.Upload.ResumableUpload.MinimumChunkSize;  //262144;
						request.ProgressChanged += (IUploadProgress) => Request_ProgressChanged(IUploadProgress, parent);

						request.Upload();
						var file = request.ResponseBody;
						newFileID = file.Id;

					}

				}

				return newFileID;

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// REMOVE IMAGE/FOTO FROM GOOGLE DRIVE DEFAULT FOLDER
		//------------------------------------------------------------------------------------------------------------
		public async static Task<bool> RemoveImageFromDefaultFolder(string imageFileName)
		{
			try
			{
				//--- check Drive CONNECTION
				if (!GoogleDriveConnection())
				{
					throw new Exception("Não conectado");
				}

				//--- check IMAGE FOLDER
				string IDFotoFolder = await GetFotosFolderID();

				if (string.IsNullOrEmpty(IDFotoFolder))
				{
					throw new Exception("Não há pasta de Fotos no Drive...");
				}

				//--- Get FileID from FileName
				string[] IDImageFile = await ProcurarArquivoId(imageFileName, IDFotoFolder);

				if (IDImageFile == null || !IDImageFile.Any())
				{
					throw new Exception("Não há imagem/foto com esse nome...");
				}

				//--- Preserve one copy on Local Desktop Folder


				//--- Remove File From Drive
				RemoveFile(IDImageFile.First());

				//--- return
				return true;
			}
			catch
			{
				throw;
			}
		}

		// GET IMAGE/FOTO FILE AND DOWNLOAD IN FOLDER
		//------------------------------------------------------------------------------------------------------------
		public async static Task<string> DownloadImageAndSaveLocal(string ImageFileName, string FolderToSave)
		{
			try
			{
				//--- check Drive CONNECTION
				if (!GoogleDriveConnection())
				{
					throw new Exception("Não há nenhuma conexão com o Google Drive...");
				}

				//--- check IMAGE FOLDER
				string IDFotoFolder = await GetFotosFolderID();

				if (string.IsNullOrEmpty(IDFotoFolder))
				{
					throw new AppException("Não há pasta de Fotos no Drive...");
				}

				//--- Get FileID from FileName
				string[] IDImageFile = await ProcurarArquivoId(ImageFileName, IDFotoFolder);

				if (IDImageFile == null || !IDImageFile.Any())
				{
					throw new AppException("Não foi encontrada imagem/foto desse registro...");
				}

				//--- Download File
				await DownloadFromDrive(ImageFileName, IDImageFile[0], FolderToSave);

				//--- return
				return Path.Combine(FolderToSave, ImageFileName);

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		#endregion // IMAGE GOOGLE DRIVE FUNCTIONS --- END

		#region FUNCOES GOOGLE DRIVE

		// RETORNA FILE ID DO ARQUIVO GOOGLE DRIVE
		//------------------------------------------------------------------------------------------------------------
		public static async Task<string[]> ProcurarArquivoId(string nome, string IDFolderParent = "", bool procurarNaLixeira = false)
		{

			if (!GoogleDriveConnection())
			{
				throw new Exception("Não conectado");
			}

			var retorno = new List<string>();

			var request = driveService.Files.List(); // Files.List();    //.Files.List();

			request.Q = string.Format("name = '{0}'", nome);

			if (!string.IsNullOrEmpty(IDFolderParent))
			{
				request.Q += $" and '{IDFolderParent}' in parents";
			}

			if (!procurarNaLixeira)
			{
				request.Q += " and trashed = false";
			}

			request.Fields = "files(id, name)";

			var resultado = await request.ExecuteAsync();
			var arquivos = resultado.Files;

			if (arquivos != null && arquivos.Any())
			{
				foreach (var arquivo in arquivos)
				{
					retorno.Add(arquivo.Id);
				}
			}

			return retorno.ToArray();
		}

		// UPDATE PROGRESS
		//------------------------------------------------------------------------------------------------------------
		private static void Request_ProgressChanged(Google.Apis.Upload.IUploadProgress progress, Membros.frmMembro parent)
		{
			long totalSize = 100000;

			switch (progress.Status)
			{
				case Google.Apis.Upload.UploadStatus.Uploading:
					{
						parent.updateStatusBar((progress.BytesSent * 100) / totalSize, "Enviando...");
						break;
					}
				case Google.Apis.Upload.UploadStatus.Completed:
					{
						parent.updateStatusBar(100, "Envio Completo.");
						break;
					}
				case Google.Apis.Upload.UploadStatus.Failed:
					{
						parent.updateStatusBar(0, "Falha no Envio.");
						Gtools.writeToFile(frmPrincipal.errorLog, Environment.NewLine + DateTime.Now.ToString() +
									Environment.NewLine + "Falha no Envio.\n");
						break;
					}
			}
		}

		// GET ALL FILES FROM GOOGLE DRIVE AND RETURN LIST
		//------------------------------------------------------------------------------------------------------------
		public static IList<Google.Apis.Drive.v3.Data.File> ListDriveFilesOriginal(string fileName = null, string fileType = null, string parentID = null)
		{
			IList<Google.Apis.Drive.v3.Data.File> filesList = new List<Google.Apis.Drive.v3.Data.File>();

			try
			{
				if (!GoogleDriveConnection())
				{
					throw new Exception("Não conectado");
				}

				if (fileName == null && fileType == null && parentID == null)
				{
					FilesResource.ListRequest listRequest = driveService.Files.List();
					listRequest.PageSize = 1000;
					listRequest.Fields = "nextPageToken, files(mimeType, id, name, parents, size, modifiedTime, md5Checksum, webViewLink)";
					//listRequest.OrderBy = "mimeType";

					// List files.
					IList<Google.Apis.Drive.v3.Data.File> files = listRequest.Execute().Files;
					filesList.Clear();

					foreach (var item in files)
					{
						filesList.Add(item);
					}

					return filesList;

				}
				else
				{
					string pageToken = null;
					do
					{
						FilesResource.ListRequest request = driveService.Files.List();
						request.PageSize = 1000;
						//request.Q = "mimeType='image/jpeg'";
						request.Q = "name contains '" + fileName + "'";

						if (fileType != null)
						{
							request.Q += $"and (mimeType contains '{fileType}')";
						}

						if (!string.IsNullOrEmpty(parentID))
						{
							request.Q += $" and ('{parentID}' in parents)";
						}

						request.Q += " and trashed = false";

						request.Spaces = "drive";
						request.Fields = "nextPageToken, files(mimeType, id, name, parents, size, modifiedTime, md5Checksum, webViewLink)";
						request.PageToken = pageToken;
						var result = request.Execute();

						foreach (var file in result.Files)
						{
							filesList.Add(file);
						}

						pageToken = result.NextPageToken;

					} while (pageToken != null);

					return filesList;
				}
			}
			catch (Exception exc)
			{
				System.Diagnostics.Debug.WriteLine(exc.Message + " Drivefile list Error");
				Gtools.writeToFile(CamadaUI.Main.frmPrincipal.errorLog, Environment.NewLine + DateTime.Now.ToString() +
							Environment.NewLine + exc.Message + " Drivefile list Error.\n");
			}

			return filesList;
		}

		// DELETE / REMOVE FILE FROM GOOGLE DRIVE
		//------------------------------------------------------------------------------------------------------------
		public async static void RemoveFile(string fileID)
		{
			try
			{
				var request = driveService.Files.Delete(fileID);
				await request.ExecuteAsync();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// EXECUTE FILE DOWNLOAD
		//------------------------------------------------------------------------------------------------------------
		public async static Task DownloadFromDrive(string filename, string fileId, string savePath)
		{
			try
			{
				var request = driveService.Files.Get(fileId);
				var stream = new System.IO.MemoryStream();
				System.Diagnostics.Debug.WriteLine(fileId);
				await request.DownloadAsync(stream);
				ConvertMemoryStreamToFileStream(stream, savePath + @"\" + @filename);
				stream.Dispose();
			}
			catch (Exception exc)
			{
				System.Diagnostics.Debug.WriteLine(exc.Message + " Download From Drive Error");
				Gtools.writeToFile(frmPrincipal.errorLog, Environment.NewLine + DateTime.Now.ToString() +
					Environment.NewLine + exc.Message + " Download From Drive.\n");
			}
		}

		// CONVERT MEMORY STREAM TO FILE STREAM
		//------------------------------------------------------------------------------------------------------------
		private static void ConvertMemoryStreamToFileStream(MemoryStream stream, string savePath)
		{
			FileStream fileStream;
			using (fileStream = new System.IO.FileStream(savePath, FileMode.OpenOrCreate, FileAccess.Write))
			{
				try
				{
					// System.IO.File.Create(saveFile)
					stream.WriteTo(fileStream);
					fileStream.Close();
				}
				catch (Exception exc)
				{
					System.Diagnostics.Debug.WriteLine(exc.Message + " Convert Memory stream Error");
					Gtools.writeToFile(frmPrincipal.errorLog, Environment.NewLine + DateTime.Now.ToString() +
					Environment.NewLine + exc.Message + " Convert Memory stream Error.\n");
				}
			}
		}

		// CREATE FOLDER IN GOOLGE DRIVE
		//------------------------------------------------------------------------------------------------------------
		public static string CreateFolderToDrive(string folderName, string parentId)
		{
			try
			{
				var fileMetadata = new Google.Apis.Drive.v3.Data.File()
				{
					Name = folderName,
					MimeType = "application/vnd.google-apps.folder",

				};

				if (parentId != null && !string.IsNullOrEmpty(parentId))
				{
					fileMetadata.Parents = new List<string>
					{
						parentId
					};
				}

				var request = driveService.Files.Create(fileMetadata);
				request.Fields = "id";
				var file = request.Execute();
				System.Diagnostics.Debug.WriteLine("{0} {1}", file.Name, file.Id);
				return file.Id;
			}
			catch (Exception exc)
			{
				throw new Exception(exc.Message + " Create Folder to Drive Error");
			}
		}

		#endregion // FUNCOES GOOGLE DRIVE --- END

	}
}
