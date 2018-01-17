using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace MobexMerge
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox gbStep;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.ImageList ilMain;
		private System.Windows.Forms.GroupBox gbCont;
		private System.Windows.Forms.GroupBox gbMess;
		private System.Windows.Forms.CheckedListBox lbCont;
		private System.Windows.Forms.TextBox txtMess;
		private System.Windows.Forms.RadioButton radSms;
		private System.Windows.Forms.RadioButton radEmail;
		private System.Windows.Forms.GroupBox gbType;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnPrev;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Button btnAll;
		private System.Windows.Forms.Button btnNone;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnName;
		private System.Windows.Forms.Button btnSurname;

		private StepManager step;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtSubject;
		private bool		typeChangeProgram;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			this.Text = Application.ProductName + " " + Application.ProductVersion.Substring(0, 3) + " - written by Kerem Koseoglu";
			step = new StepManager();
			step.nextStep();
			setScreen();
		}

		private void setScreen()
		{
			button1.Enabled		= step.step == 1;
			button2.Enabled		= step.step == 2;
			button3.Enabled		= step.step == 3;
			button4.Enabled		= step.step == 4;
			button5.Enabled		= step.step == 5;
			button6.Enabled		= step.step == 6;

			lbCont.Enabled		= step.step == 2;
			btnAll.Enabled		= lbCont.Enabled;
			btnNone.Enabled		= lbCont.Enabled;
			txtMess.Enabled		= ((step.step == 3) || (step.step == 5));
			txtSubject.Enabled	= step.step == 3;
			btnName.Enabled		= txtMess.Enabled;
			btnSurname.Enabled	= txtMess.Enabled;
			gbType.Enabled		= ((step.step == 3) || (step.step == 5));
			btnPrev.Enabled		= step.step == 5;
			btnNext.Enabled		= step.step == 5;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.gbStep = new System.Windows.Forms.GroupBox();
			this.button6 = new System.Windows.Forms.Button();
			this.ilMain = new System.Windows.Forms.ImageList(this.components);
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.gbCont = new System.Windows.Forms.GroupBox();
			this.btnNone = new System.Windows.Forms.Button();
			this.btnAll = new System.Windows.Forms.Button();
			this.lbCont = new System.Windows.Forms.CheckedListBox();
			this.gbMess = new System.Windows.Forms.GroupBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnSurname = new System.Windows.Forms.Button();
			this.btnName = new System.Windows.Forms.Button();
			this.btnPrev = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.gbType = new System.Windows.Forms.GroupBox();
			this.radSms = new System.Windows.Forms.RadioButton();
			this.radEmail = new System.Windows.Forms.RadioButton();
			this.txtMess = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtSubject = new System.Windows.Forms.TextBox();
			this.gbStep.SuspendLayout();
			this.gbCont.SuspendLayout();
			this.gbMess.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.gbType.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbStep
			// 
			this.gbStep.Controls.Add(this.button6);
			this.gbStep.Controls.Add(this.button5);
			this.gbStep.Controls.Add(this.button4);
			this.gbStep.Controls.Add(this.button3);
			this.gbStep.Controls.Add(this.button2);
			this.gbStep.Controls.Add(this.button1);
			this.gbStep.Location = new System.Drawing.Point(8, 8);
			this.gbStep.Name = "gbStep";
			this.gbStep.Size = new System.Drawing.Size(144, 320);
			this.gbStep.TabIndex = 0;
			this.gbStep.TabStop = false;
			this.gbStep.Text = "Steps";
			// 
			// button6
			// 
			this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button6.ImageIndex = 5;
			this.button6.ImageList = this.ilMain;
			this.button6.Location = new System.Drawing.Point(8, 264);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(128, 43);
			this.button6.TabIndex = 5;
			this.button6.Text = "Send";
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// ilMain
			// 
			this.ilMain.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
			this.ilMain.ImageSize = new System.Drawing.Size(16, 16);
			this.ilMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilMain.ImageStream")));
			this.ilMain.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// button5
			// 
			this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button5.ImageIndex = 4;
			this.button5.ImageList = this.ilMain;
			this.button5.Location = new System.Drawing.Point(8, 216);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(128, 43);
			this.button5.TabIndex = 4;
			this.button5.Text = "Edit Messages";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button4
			// 
			this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button4.ImageIndex = 3;
			this.button4.ImageList = this.ilMain;
			this.button4.Location = new System.Drawing.Point(8, 168);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(128, 43);
			this.button4.TabIndex = 3;
			this.button4.Text = "Merge Messages";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button3.ImageIndex = 2;
			this.button3.ImageList = this.ilMain;
			this.button3.Location = new System.Drawing.Point(8, 120);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(128, 43);
			this.button3.TabIndex = 2;
			this.button3.Text = "Write Messages";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.ImageIndex = 1;
			this.button2.ImageList = this.ilMain;
			this.button2.Location = new System.Drawing.Point(8, 72);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(128, 43);
			this.button2.TabIndex = 1;
			this.button2.Text = "Select Contacts";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.ImageIndex = 0;
			this.button1.ImageList = this.ilMain;
			this.button1.Location = new System.Drawing.Point(8, 24);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(128, 43);
			this.button1.TabIndex = 0;
			this.button1.Text = "Read Contacts";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// gbCont
			// 
			this.gbCont.Controls.Add(this.btnNone);
			this.gbCont.Controls.Add(this.btnAll);
			this.gbCont.Controls.Add(this.lbCont);
			this.gbCont.Location = new System.Drawing.Point(160, 8);
			this.gbCont.Name = "gbCont";
			this.gbCont.Size = new System.Drawing.Size(224, 264);
			this.gbCont.TabIndex = 1;
			this.gbCont.TabStop = false;
			this.gbCont.Text = "Contacts";
			// 
			// btnNone
			// 
			this.btnNone.Location = new System.Drawing.Point(176, 208);
			this.btnNone.Name = "btnNone";
			this.btnNone.Size = new System.Drawing.Size(40, 32);
			this.btnNone.TabIndex = 7;
			this.btnNone.Text = "None";
			this.btnNone.Click += new System.EventHandler(this.btnNone_Click);
			// 
			// btnAll
			// 
			this.btnAll.Location = new System.Drawing.Point(128, 208);
			this.btnAll.Name = "btnAll";
			this.btnAll.Size = new System.Drawing.Size(40, 32);
			this.btnAll.TabIndex = 6;
			this.btnAll.Text = "All";
			this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
			// 
			// lbCont
			// 
			this.lbCont.CheckOnClick = true;
			this.lbCont.Location = new System.Drawing.Point(8, 24);
			this.lbCont.Name = "lbCont";
			this.lbCont.Size = new System.Drawing.Size(208, 169);
			this.lbCont.TabIndex = 0;
			// 
			// gbMess
			// 
			this.gbMess.Controls.Add(this.groupBox1);
			this.gbMess.Controls.Add(this.btnPrev);
			this.gbMess.Controls.Add(this.btnNext);
			this.gbMess.Controls.Add(this.gbType);
			this.gbMess.Controls.Add(this.txtMess);
			this.gbMess.Location = new System.Drawing.Point(392, 8);
			this.gbMess.Name = "gbMess";
			this.gbMess.Size = new System.Drawing.Size(224, 320);
			this.gbMess.TabIndex = 2;
			this.gbMess.TabStop = false;
			this.gbMess.Text = "Message";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnSurname);
			this.groupBox1.Controls.Add(this.btnName);
			this.groupBox1.Location = new System.Drawing.Point(8, 200);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(208, 64);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Special Fields";
			// 
			// btnSurname
			// 
			this.btnSurname.Location = new System.Drawing.Point(112, 24);
			this.btnSurname.Name = "btnSurname";
			this.btnSurname.Size = new System.Drawing.Size(88, 24);
			this.btnSurname.TabIndex = 8;
			this.btnSurname.Text = "Surname";
			this.btnSurname.Click += new System.EventHandler(this.btnSurname_Click);
			// 
			// btnName
			// 
			this.btnName.Location = new System.Drawing.Point(8, 24);
			this.btnName.Name = "btnName";
			this.btnName.Size = new System.Drawing.Size(96, 24);
			this.btnName.TabIndex = 7;
			this.btnName.Text = "Name";
			this.btnName.Click += new System.EventHandler(this.btnName_Click);
			// 
			// btnPrev
			// 
			this.btnPrev.Location = new System.Drawing.Point(160, 280);
			this.btnPrev.Name = "btnPrev";
			this.btnPrev.Size = new System.Drawing.Size(24, 32);
			this.btnPrev.TabIndex = 5;
			this.btnPrev.Text = "<-";
			this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(192, 280);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(24, 32);
			this.btnNext.TabIndex = 4;
			this.btnNext.Text = "->";
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// gbType
			// 
			this.gbType.Controls.Add(this.radSms);
			this.gbType.Controls.Add(this.radEmail);
			this.gbType.Location = new System.Drawing.Point(8, 272);
			this.gbType.Name = "gbType";
			this.gbType.Size = new System.Drawing.Size(128, 40);
			this.gbType.TabIndex = 3;
			this.gbType.TabStop = false;
			this.gbType.Text = "Type";
			// 
			// radSms
			// 
			this.radSms.Checked = true;
			this.radSms.Location = new System.Drawing.Point(8, 16);
			this.radSms.Name = "radSms";
			this.radSms.Size = new System.Drawing.Size(48, 16);
			this.radSms.TabIndex = 1;
			this.radSms.TabStop = true;
			this.radSms.Text = "SMS";
			this.radSms.CheckedChanged += new System.EventHandler(this.radSms_CheckedChanged);
			// 
			// radEmail
			// 
			this.radEmail.Location = new System.Drawing.Point(64, 16);
			this.radEmail.Name = "radEmail";
			this.radEmail.Size = new System.Drawing.Size(56, 16);
			this.radEmail.TabIndex = 2;
			this.radEmail.Text = "E-Mail";
			this.radEmail.CheckedChanged += new System.EventHandler(this.radEmail_CheckedChanged);
			// 
			// txtMess
			// 
			this.txtMess.Location = new System.Drawing.Point(8, 24);
			this.txtMess.Multiline = true;
			this.txtMess.Name = "txtMess";
			this.txtMess.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtMess.Size = new System.Drawing.Size(208, 168);
			this.txtMess.TabIndex = 0;
			this.txtMess.Text = "";
			this.txtMess.TextChanged += new System.EventHandler(this.txtMess_TextChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtSubject);
			this.groupBox2.Location = new System.Drawing.Point(160, 280);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(224, 48);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Subject";
			// 
			// txtSubject
			// 
			this.txtSubject.Location = new System.Drawing.Point(8, 16);
			this.txtSubject.Name = "txtSubject";
			this.txtSubject.Size = new System.Drawing.Size(208, 20);
			this.txtSubject.TabIndex = 0;
			this.txtSubject.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(624, 335);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.gbCont);
			this.Controls.Add(this.gbStep);
			this.Controls.Add(this.gbMess);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "MobexMerge";
			this.gbStep.ResumeLayout(false);
			this.gbCont.ResumeLayout(false);
			this.gbMess.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.gbType.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}


		private void btnAll_Click(object sender, System.EventArgs e)
		{
			for (int n = 0; n < lbCont.Items.Count; n++)
			{
				lbCont.SetItemChecked(n, true);
			}
		}

		private void btnNone_Click(object sender, System.EventArgs e)
		{
			for (int n = 0; n < lbCont.Items.Count; n++)
			{
				lbCont.SetItemChecked(n, false);
			}		
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			step.executeCurrentStep(lbCont);

			for (int n = 0; n < step.contactCount; n++)
			{
				string x = "";
				if (step.contact[n].email.Length > 0) x += " e";
				if (step.contact[n].phone.Length > 0) x += " p";
				x += " ";
				lbCont.Items.Add(step.contact[n].name + " " + step.contact[n].surname + " (" + x + ")");

			}

			setScreen();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			step.executeCurrentStep(lbCont);
			setScreen();
		}

		private void btnName_Click(object sender, System.EventArgs e)
		{
			txtMess.Text += "<<NAME>>";
		}

		private void btnSurname_Click(object sender, System.EventArgs e)
		{
			txtMess.Text += "<<SURNAME>>";
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			step.subject = txtSubject.Text;
			step.executeCurrentStep(lbCont);
			setScreen();
		}

		private void setStandardText()
		{
			switch (step.step)
			{
				case 3:
					if (radEmail.Checked)
					{
						step.smsMessage		= txtMess.Text;
						txtMess.Text		= step.mailMessage;
					}
					else
					{
						step.mailMessage	= txtMess.Text;
						txtMess.Text		= step.smsMessage;
					}
					break;
				case 5:
					if (typeChangeProgram) return;
					if (radEmail.Checked)
					{
						step.contact[step.selectedUserIndex].messageType = Contact.MESSAGETYPE.MAIL;
					}
					else
					{
						step.contact[step.selectedUserIndex].messageType = Contact.MESSAGETYPE.SMS;
					}
					displayCurrentText();
					break;
			}
		}

		private void radSms_CheckedChanged(object sender, System.EventArgs e)
		{
			setStandardText();
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			setStandardText();
			step.executeCurrentStep(lbCont);
			setScreen();

			displayCurrentText();
		}

		private void radEmail_CheckedChanged(object sender, System.EventArgs e)
		{
			//setStandardText();
		}

		private void btnPrev_Click(object sender, System.EventArgs e)
		{
			step.selectPrevContact();
			displayCurrentText();
		}

		private void btnNext_Click(object sender, System.EventArgs e)
		{
			step.selectNextContact();
			displayCurrentText();
		}

		private void displayCurrentText()
		{
			typeChangeProgram	= true;
			radSms.Enabled		= step.contact[step.selectedUserIndex].phone.Trim().Length > 0;
			radSms.Checked		= step.contact[step.selectedUserIndex].messageType == Contact.MESSAGETYPE.SMS;
			radEmail.Enabled	= step.contact[step.selectedUserIndex].email.Trim().Length > 0;
			radEmail.Checked	= step.contact[step.selectedUserIndex].messageType == Contact.MESSAGETYPE.MAIL;
			typeChangeProgram	= false;

			txtMess.Text = step.contact[step.selectedUserIndex].readMessage();
			focusCurrentContact();
		}

		private void txtMess_TextChanged(object sender, System.EventArgs e)
		{
			if (step.step != 5) return;

			if (radSms.Checked)
			{
				step.contact[step.selectedUserIndex].smsMessage = txtMess.Text;
			}
			else
			{
				step.contact[step.selectedUserIndex].mailMessage = txtMess.Text;
			}
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			step.executeCurrentStep(lbCont);
			setScreen();		
		}

		private void button6_Click(object sender, System.EventArgs e)
		{
			step.executeCurrentStep(lbCont);
			setScreen();	
			Application.Exit();
		}

		private void focusCurrentContact()
		{
			lbCont.SelectedIndex = step.selectedUserIndex;
		}

	}
}
