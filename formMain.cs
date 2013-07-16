using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using GrFingerXLib;

namespace Panchita
{
	public class formMain : FormBase
	{
		private System.Windows.Forms.Button btEnroll;
        private System.Windows.Forms.PictureBox pbImg;
		private AxGrFingerXLib.AxGrFingerXCtrl axGrFingerXCtrl1;
        private static Util myUtil=null;
        private System.Windows.Forms.ListBox lbLog;
        public bool prepareEnroll=false;
        public int huellaID=0;
        private static formMain instance=null;
        public delegate void EnHuellaLeido(int id);

        public EnHuellaLeido enHuellaLeido;

		public formMain():base(true)
		{
			InitializeComponent();
		}

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

        private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.btEnroll = new System.Windows.Forms.Button();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.axGrFingerXCtrl1 = new AxGrFingerXLib.AxGrFingerXCtrl();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axGrFingerXCtrl1)).BeginInit();
            this.SuspendLayout();
            // 
            // btEnroll
            // 
            this.btEnroll.Location = new System.Drawing.Point(414, 46);
            this.btEnroll.Name = "btEnroll";
            this.btEnroll.Size = new System.Drawing.Size(97, 24);
            this.btEnroll.TabIndex = 11;
            this.btEnroll.Text = "Start Enroll";
            this.btEnroll.Visible = false;
            this.btEnroll.Click += new System.EventHandler(this.btEnroll_Click);
            // 
            // pbImg
            // 
            this.pbImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbImg.Location = new System.Drawing.Point(8, 8);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(400, 400);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImg.TabIndex = 9;
            this.pbImg.TabStop = false;
            // 
            // lbLog
            // 
            this.lbLog.Location = new System.Drawing.Point(8, 416);
            this.lbLog.Name = "lbLog";
            this.lbLog.ScrollAlwaysVisible = true;
            this.lbLog.Size = new System.Drawing.Size(496, 108);
            this.lbLog.TabIndex = 23;
            // 
            // axGrFingerXCtrl1
            // 
            this.axGrFingerXCtrl1.Enabled = true;
            this.axGrFingerXCtrl1.Location = new System.Drawing.Point(448, 8);
            this.axGrFingerXCtrl1.Name = "axGrFingerXCtrl1";
            this.axGrFingerXCtrl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGrFingerXCtrl1.OcxState")));
            this.axGrFingerXCtrl1.Size = new System.Drawing.Size(32, 32);
            this.axGrFingerXCtrl1.TabIndex = 22;
            this.axGrFingerXCtrl1.SensorPlug += new AxGrFingerXLib._IGrFingerXCtrlEvents_SensorPlugEventHandler(this.axGrFingerXCtrl1_SensorPlug);
            this.axGrFingerXCtrl1.SensorUnplug += new AxGrFingerXLib._IGrFingerXCtrlEvents_SensorUnplugEventHandler(this.axGrFingerXCtrl1_SensorUnplug);
            this.axGrFingerXCtrl1.FingerUp += new AxGrFingerXLib._IGrFingerXCtrlEvents_FingerUpEventHandler(this.axGrFingerXCtrl1_FingerUp);
            this.axGrFingerXCtrl1.FingerDown += new AxGrFingerXLib._IGrFingerXCtrlEvents_FingerDownEventHandler(this.axGrFingerXCtrl1_FingerDown);
            this.axGrFingerXCtrl1.ImageAcquired += new AxGrFingerXLib._IGrFingerXCtrlEvents_ImageAcquiredEventHandler(this.axGrFingerXCtrl1_ImageAcquired);
            // 
            // formMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(527, 534);
            this.Controls.Add(this.lbLog);
            this.Controls.Add(this.axGrFingerXCtrl1);
            this.Controls.Add(this.btEnroll);
            this.Controls.Add(this.pbImg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Personal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formMain_Closed);
            this.Load += new System.EventHandler(this.formMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axGrFingerXCtrl1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		

		private void formMain_Load(object sender, System.EventArgs e)
		{
    		int err;
            if (myUtil == null)
            {
                myUtil = new Util(lbLog, pbImg, btEnroll);

                err = myUtil.InitializeGrFinger(axGrFingerXCtrl1);
                if (err < 0)
                {
                    myUtil.WriteError((GRConstants)err);
                }
                else
                {
                    myUtil.WriteLog("**GrFingerX Initialized Successfull**");
                }
            }
		}


		private void formMain_Closed(object sender, FormClosedEventArgs e)
		{
            base.FormBase_FormClosed(sender,e);
			myUtil.FinalizeUtil();
		}


		private void btEnroll_Click(object sender, System.EventArgs e)
		{
            enroll();          
		}

        public void enroll()
        {
            if (myUtil._isEnrolling)
            {
                btEnroll.Text = "Start Enroll";
                myUtil._isEnrolling = false;
                myUtil.WriteLog("Enrollment stopped");
            }
            else
            {
                int ret = myUtil.StartEnroll();
                if (ret == (int)GRConstants.GR_OK)
                {
                    myUtil._numberOfConsolidated = 0;
                    btEnroll.Text = "Stop Enroll";
                    myUtil._isEnrolling = true;
                    myUtil.WriteLog("Enrollment started");
                }
                else
                {
                    myUtil.WriteError((GRConstants)ret);
                }

            }  
        }

		private void btIdentify_Click()
		{
			int ret, score;

			score = 0;
			ret = myUtil.Identify(ref score);
			if (ret > 0) 
			{
				myUtil.WriteLog("Fingerprint identified. ID = " + ret + ". Score = " + score + ".");
                notifyIcon.BalloonTipText = "Fingerprint identified. ID = " + ret + ". Score = " + score + ".";
                notifyIcon.ShowBalloonTip(50);
				myUtil.PrintBiometricDisplay(true, GRConstants.GR_DEFAULT_CONTEXT);
			} 
			else 
			{
				if (ret == 0) 
				{
					myUtil.WriteLog("Fingerprint not Found.");
				} 
				else 
				{
					myUtil.WriteError((GRConstants)ret);
				}
			}
		}

		private void btVerify_Click(object sender, System.EventArgs e)
		{
			int ret, score;

			score = 0;
			InputBoxResult r = InputBox.Show("Enter the ID to verify","Verify","");
			if (r.ReturnCode == DialogResult.OK) 
			{
                if (!(r.Text == ""))
                {
                    ret = myUtil.Verify(Convert.ToInt32(r.Text), ref score);
                    if (ret < 0)
                    {
                        myUtil.WriteError((GRConstants)ret);
                    }
                    else
                    {
                        if ((GRConstants)ret == GRConstants.GR_NOT_MATCH)
                        {
                            myUtil.WriteLog("Did not match with score = " + score);
                        }
                        else
                        {
                            myUtil.WriteLog("Matched with score = " + score);
                            myUtil.PrintBiometricDisplay(true, GRConstants.GR_DEFAULT_CONTEXT);
                        }
                    }
                }
			}
		}

		private void btnExtract_Click()
		{
			int ret;

			ret = myUtil.ExtractTemplate();
			if ((GRConstants)ret == GRConstants.GR_BAD_QUALITY) 
			{
				myUtil.WriteLog("Template extracted successfully. Bad quality.");
			} 
			else if ((GRConstants)ret == GRConstants.GR_MEDIUM_QUALITY) 
			{
				myUtil.WriteLog("Template extracted successfully. Medium quality.");
			} 
			else if ((GRConstants)ret == GRConstants.GR_HIGH_QUALITY) 
			{
				myUtil.WriteLog("Template extracted successfully. High quality.");
			}
			if (ret >= 0) 
			{
				myUtil.PrintBiometricDisplay(true, GRConstants.GR_NO_CONTEXT);
			} 
			else 
			{
				myUtil.WriteError((GRConstants)ret);
			}
		}

		private void btClearDB_Click(object sender, System.EventArgs e)
		{
			myUtil._DB.clearDB();
			myUtil.WriteLog("Database is clear...");
		}
		
		private void btClearLog_Click(object sender, System.EventArgs e)
		{
			lbLog.Items.Clear();
		}

		

		private void mnVersion_Click(object sender, System.EventArgs e)
		{
			myUtil.MessageVersion();
		}

		private void axGrFingerXCtrl1_SensorPlug(object sender, AxGrFingerXLib._IGrFingerXCtrlEvents_SensorPlugEvent e)
		{
			myUtil.WriteLog("Sensor: " + e.idSensor + ". Event: Plugged.");
			axGrFingerXCtrl1.CapStartCapture(e.idSensor);
		}

		private void axGrFingerXCtrl1_SensorUnplug(object sender, AxGrFingerXLib._IGrFingerXCtrlEvents_SensorUnplugEvent e)
		{
			myUtil.WriteLog("Sensor: " + e.idSensor + ". Event: Unplugged.");
			axGrFingerXCtrl1.CapStopCapture(e.idSensor);
		}

		private void axGrFingerXCtrl1_FingerDown(object sender, AxGrFingerXLib._IGrFingerXCtrlEvents_FingerDownEvent e)
		{
			myUtil.WriteLog("Sensor: " + e.idSensor + ". Event: Finger Placed.");
		}

		private void axGrFingerXCtrl1_FingerUp(object sender, AxGrFingerXLib._IGrFingerXCtrlEvents_FingerUpEvent e)
		{
			myUtil.WriteLog("Sensor: " + e.idSensor + ". Event: Finger removed.");
		}

		private void axGrFingerXCtrl1_ImageAcquired(object sender, AxGrFingerXLib._IGrFingerXCtrlEvents_ImageAcquiredEvent e)
		{
			myUtil._raw.img = e.rawImage;
			myUtil._raw.height = (int) e.height;
			myUtil._raw.width = (int) e.width;
			myUtil._raw.Res = e.res;

			myUtil.WriteLog("Sensor: " + e.idSensor + ". Event: Image captured.");
			try 
			{
				myUtil.PrintBiometricDisplay(false, GRConstants.GR_DEFAULT_CONTEXT);
			} 
			catch (Exception ex) 
			{
				myUtil.WriteLog(ex.Message);
			}
            if (!myUtil._isEnrolling)
            {
                btnExtract_Click();
                btIdentify_Click();
            }
            else
            {
                int ret = myUtil.Consolidate();
                if (ret < 0)
                    myUtil.WriteError((GRConstants)ret);
                else
                {
                    btnExtract_Click();
                    int id=0;
                    int score=0;
                    id = myUtil.Identify(ref score);
                    if (id > 0)
                    {
                        myUtil.WriteLog("Fingerprint identified. ID = " + id + ". Score = " + score + ".");
                        notifyIcon.BalloonTipText = "Fingerprint identified. ID = " + id + ". Score = " + score + ".";
                        notifyIcon.ShowBalloonTip(50);
                        myUtil.PrintBiometricDisplay(true, GRConstants.GR_DEFAULT_CONTEXT);
                        btEnroll.Text = "Start Enroll";
                        myUtil._isEnrolling = false;
                        myUtil.WriteLog("Enrollment stopped");
                        if (prepareEnroll)
                        {
                            this.huellaID = id;
                            this.Hide();
                            if (enHuellaLeido!=null) {
                                enHuellaLeido(huellaID);
                            }
                        } 
                    }
                    else
                    {
                        bool saveConsolidatedTemplate = false;
                        switch ((GRConstants)ret)
                        {
                            case GRConstants.GR_ENROLL_NOT_READY:
                                myUtil._numberOfConsolidated++;
                                myUtil.WriteLog("Enrollment not ready");
                                myUtil.WriteLog("Put you finger again.");
                                break;
                            case GRConstants.GR_ENROLL_SUFFICIENT:
                                myUtil._numberOfConsolidated++;
                                myUtil.WriteLog("Sufficient enrollment");
                                if (myUtil._numberOfConsolidated > 7)
                                    saveConsolidatedTemplate = true;
                                else
                                    myUtil.WriteLog("Put you finger again.");
                                break;
                            case GRConstants.GR_ENROLL_GOOD:
                                myUtil._numberOfConsolidated++;
                                saveConsolidatedTemplate = true;
                                myUtil.WriteLog("Good enrollment");
                                break;
                            case GRConstants.GR_ENROLL_VERY_GOOD:
                                myUtil._numberOfConsolidated++;
                                saveConsolidatedTemplate = true;
                                myUtil.WriteLog("Very good enrollment");
                                break;
                            case GRConstants.GR_ENROLL_MAX_LIMIT_REACHED:
                                saveConsolidatedTemplate = true;
                                break;
                        }
                        if (saveConsolidatedTemplate)
                        {
                            id = myUtil.Enroll();
                            if (id >= 0)
                            {
                                myUtil.WriteLog("Consolidated template enrolled with id = " + id);
                                notifyIcon.BalloonTipText = "Fingerprint identified. ID = " + id + ". Score = " + score + ".";
                                notifyIcon.ShowBalloonTip(50);
                                if (prepareEnroll)
                                {
                                    this.huellaID = id;
                                    this.Hide();
                                    if (enHuellaLeido != null)
                                    {
                                        enHuellaLeido(huellaID);
                                    }
                                }
                            }
                            else
                            {
                                myUtil.WriteLog("Error: Consolidated template not enrolled");
                            }
                            btEnroll.PerformClick();
                        }
                    }
                }
            }
            GC.Collect();
		}

        internal static formMain getInstance()
        {
            if(instance==null){
                instance = new formMain();
            }
            return instance;
        }

        private void formMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Visible = true;
            prepareEnroll = false;
            notifyIcon_DoubleClick(sender, e);
        }
    }
}