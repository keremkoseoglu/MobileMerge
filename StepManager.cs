using System;
using System.Data;

namespace MobexMerge
{
	/// <summary>
	/// Summary description for StepManager.
	/// </summary>
	public class StepManager
	{
		public int			step;
		public OutlookUtil	util;
		public Contact[]	contact;
		public int			contactCount;
		public int			selectedUserIndex;
		public int			selectedUserCount;

		public string		mailMessage	= "";
		public string		smsMessage	= "";
		public string		subject		= "";

		public StepManager()
		{
			step	= 0;
			util	= new OutlookUtil();
			contact	= new Contact[1000];
		}

		public void nextStep()
		{
			step++;
		}

		public void executeCurrentStep(System.Windows.Forms.CheckedListBox cl)
		{
			switch (step)
			{
				case 1:
					readOutlookContacts();
					break;
				case 2:
					break;
				case 3:
					break;
				case 4:
					mergeMessages(cl);
					break;
				case 5:
					break;
				case 6:
					sendMessages();
					break;
			}

			nextStep();
		}

		public void readOutlookContacts()
		{
			DataTable dt = util.readContacts();

			foreach(DataRow dr in dt.Rows)
			{
				contact[contactCount]				= new Contact();
				contact[contactCount].email			= dr["Email1Address"].ToString();
				contact[contactCount].name			= dr["FirstName"].ToString();
				contact[contactCount].surname		= dr["LastName"].ToString();
				contact[contactCount].phone			= dr["MobileTelephoneNumber"].ToString();
				contact[contactCount].smsMessage	= "";
				contact[contactCount].mailMessage	= "";
				contactCount++;
			}
		}

		public void mergeMessages(System.Windows.Forms.CheckedListBox cl)
		{
			selectedUserIndex = -1;
			for (int n = 0; n < cl.CheckedIndices.Count; n++)
			{
				int i = cl.CheckedIndices[n];

				if (contact[i].phone.Trim().Length > 0 || contact[i].email.Trim().Length > 0)
				{
					contact[i].selected		= true;
					contact[i].smsMessage	= smsMessage;
					contact[i].mailMessage	= mailMessage;
					contact[i].messageType	= Contact.MESSAGETYPE.SMS;
					if (contact[i].phone.Trim().Length == 0) contact[i].messageType = Contact.MESSAGETYPE.MAIL;
				
					mergeText(ref contact[i].smsMessage,	contact[i]);
					mergeText(ref contact[i].mailMessage,	contact[i]);

					if (selectedUserIndex < 0) selectedUserIndex = i;
					selectedUserCount++;
				}
			}
		}

		private void mergeText(ref string Text, Contact Con)
		{
			if (Text.Length <= 0) return;

			Text = Text.Replace("<<NAME>>",		Con.name);
			Text = Text.Replace("<<SURNAME>>",	Con.surname);
		}

		public void selectNextContact()
		{
			int newIndex = -1;

			for (int n = selectedUserIndex + 1; n < contactCount; n++)
			{
				if (newIndex < 0 && contact[n].selected) newIndex = n;
			}

			if (newIndex < 0)
			{
				for (int n = 0; n < contactCount; n++)
				{
					if (newIndex < 0 && contact[n].selected) newIndex = n;
				}
			}

			selectedUserIndex = newIndex;
		}

		public void selectPrevContact()
		{
			int newIndex = -1;

			for (int n = selectedUserIndex - 1; n > -1; n--)
			{
				if (newIndex < 0 && contact[n].selected) newIndex = n;
			}

			if (newIndex < 0)
			{
				for (int n = contactCount - 1; n > -1; n--)
				{
					if (newIndex < 0 && contact[n].selected) newIndex = n;
				}
			}

			selectedUserIndex = newIndex;
		}

		public void sendMessages()
		{
			for (int n = 0; n < contactCount; n++)
			{
				if (contact[n].selected)
				{
					switch (contact[n].messageType)
					{
						case Contact.MESSAGETYPE.MAIL:
							util.sendMail(contact[n].email, subject, contact[n].readMessage());
							break;
						case Contact.MESSAGETYPE.SMS:
							util.sendSms(contact[n].phone, subject, contact[n].readMessage());
							break;
					}
				}
			}
		}
	}
}
