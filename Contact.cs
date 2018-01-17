using System;

namespace MobexMerge
{
	/// <summary>
	/// Summary description for Contact.
	/// </summary>
	public class Contact
	{
		public enum MESSAGETYPE: long {MAIL, SMS};

		public string		name;
		public string		surname;
		public string		phone;
		public string		email;
		public string		mailMessage;
		public string		smsMessage;
		public MESSAGETYPE	messageType;
		public bool			selected;

		public Contact()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public string readMessage()
		{
			if (messageType == MESSAGETYPE.MAIL)
			{
				return mailMessage;
			}
			else
			{
				return smsMessage;
			}
		}
	}
}
