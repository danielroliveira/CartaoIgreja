using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDTO
{
	public class CommandResult
	{
		public CommandResult() { }

		public CommandResult(bool result, string message)
		{
			Result = result;
			Message = message;
			ResultObject = null;
		}

		public CommandResult(bool result, string message, object resultObject)
		{
			Result = result;
			Message = message;
			ResultObject = resultObject;
		}

		public bool Result { get; set; }
		public string Message { get; set; }
		public object ResultObject { get; set; }
	}
}
