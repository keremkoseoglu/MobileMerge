using Microsoft.Office.Interop;
using System;
using System.Data;

namespace MobexMerge
{
	/// <summary>
	/// Summary description for Contact.
	/// </summary>
	public class OutlookUtil
	{
		private Microsoft.Office.Interop.Outlook.ApplicationClass   myApp;
		private Microsoft.Office.Interop.Outlook.NameSpace          myName;
 
		public OutlookUtil()
		{
			//
			// TODO: Add constructor logic here
			//
			myApp = new Microsoft.Office.Interop.Outlook.ApplicationClass();
			myName = myApp.GetNamespace("MAPI");
			myName.Logon("Outlook", "", false, true);
		}
 
		public DataTable readContacts()
		{
			DataTable   dtReturn    = new DataTable();
			DataRow		drReturn;
 
			dtReturn.Columns.Add("FirstName");
			dtReturn.Columns.Add("LastName");
			dtReturn.Columns.Add("MobileTelephoneNumber");
			dtReturn.Columns.Add("Body");
			dtReturn.Columns.Add("Email1Address");
 
			foreach(Microsoft.Office.Interop.Outlook.MAPIFolder curFolder in myName.Folders)

			{
				if (curFolder.Name == "Personal Folders")
				{
					foreach(Microsoft.Office.Interop.Outlook.MAPIFolder curSub1 in curFolder.Folders)
					{
						if (curSub1.Name == "Contacts")
						{
							foreach(Microsoft.Office.Interop.Outlook.ContactItem myContact in curSub1.Items)
							{
								drReturn = dtReturn.NewRow();
 
								drReturn["FirstName"]                   = myContact.FirstName;
								drReturn["LastName"]                    = myContact.LastName;
								drReturn["MobileTelephoneNumber"]		= myContact.MobileTelephoneNumber;
								drReturn["Email1Address"]               = myContact.Email1Address;
								drReturn["Body"]                        = myContact.Body;
								dtReturn.Rows.Add(drReturn);
							}
						}
					}
				}
			}
 
			myName.Logoff();
			//myApp.Quit();
 
			return dtReturn;
		}
 
		public void sendMail(string Recipient, string Subject, string Message)
		{
			Microsoft.Office.Interop.Outlook.MailItemClass myMail;
 
			myMail = (Microsoft.Office.Interop.Outlook.MailItemClass) myApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);
			myMail.Recipients.Add(Recipient);
			myMail.Subject = Subject;
			myMail.Body = Message;
			myMail.Save();
		}

		public void sendSms(string Recipient, string Subject, string Message)
		{
			Microsoft.Office.Interop.Outlook.MailItemClass myMail;
 
			myMail = (Microsoft.Office.Interop.Outlook.MailItemClass) myApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);
			myMail.Recipients.Add(Recipient);
			myMail.Subject = Subject;
			myMail.Body = Message;
			myMail.Save();
			
			foreach(Microsoft.Office.Interop.Outlook.MAPIFolder curFolder in myName.Folders)
			{
				if (curFolder.Name == "SMS")
				{
					foreach(Microsoft.Office.Interop.Outlook.MAPIFolder curSub1 in curFolder.Folders)
					{
						if (curSub1.Name == "Drafts")
						{
							myMail.Move(curSub1);
						}
					}
				}
			}
		}
	}

}
