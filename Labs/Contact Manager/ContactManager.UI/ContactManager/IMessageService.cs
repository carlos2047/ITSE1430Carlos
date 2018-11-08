// Carlos Fuentes
// 11/4/2018

using System.Collections.Generic;

namespace ContactManager
{
	/// <summary>Provides services for sending messages.</summary>
	public interface IMessageService
	{
		void Send (string emailAddress, string subject, string message);
	}
}
