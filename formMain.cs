/*
 -------------------------------------------------------------------------------
 GrFinger Sample
 (c) 2005 - 2010 Griaule Biometrics Ltda.
 http://www.griaulebiometrics.com
 -------------------------------------------------------------------------------

 This sample is provided with "GrFinger Fingerprint Recognition Library" and
 can't run without it. It's provided just as an example of using GrFinger
 Fingerprint Recognition Library and should not be used as basis for any
 commercial product.

 Griaule Biometrics makes no representations concerning either the merchantability
 of this software or the suitability of this sample for any particular purpose.

 THIS SAMPLE IS PROVIDED BY THE AUTHOR "AS IS" AND ANY EXPRESS OR
 IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES
 OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED.
 IN NO EVENT SHALL GRIAULE BE LIABLE FOR ANY DIRECT, INDIRECT,
 INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT
 NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
 DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
 THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
 (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF
 THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

 You can download the trial version of GrFinger directly from Griaule website.
                                                                   
 These notices must be retained in any copies of any part of this
 documentation and/or sample.

 -------------------------------------------------------------------------------
*/

// -----------------------------------------------------------------------------------
// GUI routines: main form
// -----------------------------------------------------------------------------------

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using GrFingerXLib;

namespace GrFingerXSampleCS2005
{
	public class formMain : System.Windows.Forms.Form
	{
        private System.Windows.Forms.OpenFileDialog ofdImage;
        private System.Windows.Forms.SaveFileDialog sfdImage;
		private System.Windows.Forms.Button btEnroll;
        private System.Windows.Forms.PictureBox pbImg;
		private System.Windows.Forms.SaveFileDialog svPicture;
        private System.Windows.Forms.OpenFileDialog ldPicture;
        private IContainer components;
		private AxGrFingerXLib.AxGrFingerXCtrl axGrFingerXCtrl1;
        private Util myUtil;
        private System.Windows.Forms.ListBox lbLog;
		private formOption fopt;

		// Initializes the formMain.
		public formMain()
		{
			//Required for Windows Design Support
			InitializeComponent();

			//Create a formOption
			fopt = new formOption();
		}

		// Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.sfdImage = new System.Windows.Forms.SaveFileDialog();
            this.btEnroll = new System.Windows.Forms.Button();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.svPicture = new System.Windows.Forms.SaveFileDialog();
            this.ldPicture = new System.Windows.Forms.OpenFileDialog();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.axGrFingerXCtrl1 = new AxGrFingerXLib.AxGrFingerXCtrl();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axGrFingerXCtrl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ofdImage
            // 
            this.ofdImage.DefaultExt = "*.bmp";
            this.ofdImage.Filter = "Bitmap Files (*.bmp)|*.bmp|All Files (*.*)|*.*";
            // 
            // sfdImage
            // 
            this.sfdImage.DefaultExt = "*.bmp";
            this.sfdImage.Filter = "Bitmap Files (*.bmp)|*.bmp";
            // 
            // btEnroll
            // 
            this.btEnroll.Location = new System.Drawing.Point(416, 144);
            this.btEnroll.Name = "btEnroll";
            this.btEnroll.Size = new System.Drawing.Size(97, 24);
            this.btEnroll.TabIndex = 11;
            this.btEnroll.Text = "Start Enroll";
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
            this.axGrFingerXCtrl1.FingerUp += new AxGrFingerXLib._IGrFingerXCtrlEvents_FingerUpEventHandler(this.axGrFingerXCtrl1_FingerUp);
            this.axGrFingerXCtrl1.FingerDown += new AxGrFingerXLib._IGrFingerXCtrlEvents_FingerDownEventHandler(this.axGrFingerXCtrl1_FingerDown);
            this.axGrFingerXCtrl1.SensorUnplug += new AxGrFingerXLib._IGrFingerXCtrlEvents_SensorUnplugEventHandler(this.axGrFingerXCtrl1_SensorUnplug);
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
            this.Text = "GrFingerX - Sample application - C# 2005";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.Closed += new System.EventHandler(this.formMain_Closed);
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axGrFingerXCtrl1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		// The main entry point for the application.
		[STAThread]
		static void Main() 
		{
			Application.Run(new formMain());
		}

		// Application startup code
		private void formMain_Load(object sender, System.EventArgs e)
		{
			int err;

			// initialize util class
			myUtil = new Util(lbLog, pbImg, btEnroll);

			// Initialize the GrFingerX Library
			err = myUtil.InitializeGrFinger(axGrFingerXCtrl1);
			// print the result in the log
			if (err < 0) 
			{
				myUtil.WriteError((GRConstants)err);
			} 
			else 
			{
				myUtil.WriteLog("**GrFingerX Initialized Successfull**");
			}

		}

		// Application finalization code
		private void formMain_Closed(object sender, System.EventArgs e)
		{
			myUtil.FinalizeUtil();
		}


		// Start/Stop enrollment
		private void btEnroll_Click(object sender, System.EventArgs e)
		{
            if(myUtil._isEnrolling)
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

		// Identify a fingerprint
		private void btIdentify_Click()
		{
			int ret, score;

			score = 0;
			// identify it
			ret = myUtil.Identify(ref score);
			// write the result to the log
			if (ret > 0) 
			{
				myUtil.WriteLog("Fingerprint identified. ID = " + ret + ". Score = " + score + ".");
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

		// Check a fingerprint
		private void btVerify_Click(object sender, System.EventArgs e)
		{
			int ret, score;

			// ask target fingerprint ID
			score = 0;
			InputBoxResult r = InputBox.Show("Enter the ID to verify","Verify","");
			if (r.ReturnCode == DialogResult.OK) 
			{
                if (!(r.Text == ""))
                {
                    // compare fingerprints
                    ret = myUtil.Verify(Convert.ToInt32(r.Text), ref score);
                    // write result to the log
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
                            // if they match, display matching minutiae/segments/directions
                            myUtil.PrintBiometricDisplay(true, GRConstants.GR_DEFAULT_CONTEXT);
                        }
                    }
                }
			}
		}

		// Extract a template from a fingerprint image
		private void btnExtract_Click()
		{
			int ret;

			// extract template
			ret = myUtil.ExtractTemplate();
			// write template quality to the log
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
				// if no error, display minutiae/segments/directions into image
				myUtil.PrintBiometricDisplay(true, GRConstants.GR_NO_CONTEXT);
				// enable operations we can do over extracted template
			} 
			else 
			{
				// write error to the log
				myUtil.WriteError((GRConstants)ret);
			}
		}

		// Clear database
		private void btClearDB_Click(object sender, System.EventArgs e)
		{
			// clear database
			myUtil._DB.clearDB();
			// write result to log
			myUtil.WriteLog("Database is clear...");
		}
		
		// Clear log
		private void btClearLog_Click(object sender, System.EventArgs e)
		{
			lbLog.Items.Clear();
		}

		// Save fingerprint image to a file
		private void mnImgSave_Click(object sender, System.EventArgs e)
		{
			// we need an image
			if (myUtil._raw.img == null){
				MessageBox.Show("There is no image to save.");
				return;
			}  
			// open "save" dialog
			sfdImage.Filter = "BMP files (*.bmp)|*.bmp|All files (*.*)|*.*";
			sfdImage.FilterIndex = 1;
			sfdImage.RestoreDirectory = true;
			if(sfdImage.ShowDialog() == DialogResult.OK) 
			{
				if (axGrFingerXCtrl1.CapSaveRawImageToFile(ref myUtil._raw.img, myUtil._raw.width, myUtil._raw.height, sfdImage.FileName, (int)GRConstants.GRCAP_IMAGE_FORMAT_BMP) != (int)GRConstants.GR_OK) 
				{
					myUtil.WriteLog("Fail to save the file.");
				}
			}
		}

		// Load a fingerprint image from a file
		private void mnImgLoad_Click(object sender, System.EventArgs e)
		{
			// open "load" dialog
			sfdImage.Filter = "BMP files (*.bmp)|*.bmp|All files (*.*)|*.*";
			sfdImage.FilterIndex = 1;
			sfdImage.RestoreDirectory = true;

			// load image
			if (ofdImage.ShowDialog() == DialogResult.OK) 
			{
				// Getting resolution.
				String res = InputBox.Show("What is the image resolution?", "Resolution", "").Text;
				if (!res.Equals("")) 
				{
					int resolution = Convert.ToInt32(res);
					// Checking if action was canceled or an invalid value was entered.
					if (resolution != 0) 
					{
						if (axGrFingerXCtrl1.CapLoadImageFromFile(ofdImage.FileName, resolution) != (int)GRConstants.GR_OK) 
						{
							myUtil.WriteLog("Fail to load the file.");
						}
					}
				}
			}
		}

		// Open "Options" window
		private void mnOptions_Click(object sender, System.EventArgs e)
		{
			int ret, thresholdId = 0, rotationMaxId = 0;
			int thresholdVr = 0, rotationMaxVr = 0;
			int minutiaeColor = 0, minutiaeMatchColor = 0;
			int segmentsColor = 0, segmentsMatchColor = 0;
			int directionsColor = 0, directionsMatchColor = 0;
			bool ok;

			for (;;) 
			{
				// get current identification/verification parameters
				axGrFingerXCtrl1.GetIdentifyParameters(ref thresholdId, ref rotationMaxId, (int)GRConstants.GR_DEFAULT_CONTEXT);
				axGrFingerXCtrl1.GetVerifyParameters(ref thresholdVr, ref rotationMaxVr, (int)GRConstants.GR_DEFAULT_CONTEXT);
				// set current identification/verification parameters on options form
				fopt.setParameters(thresholdId, rotationMaxId, thresholdVr, rotationMaxVr);

				// show form with match options and biometric display options
				if (fopt.ShowDialog() != DialogResult.OK) return;
				ok = true;
				// get parameters 
				fopt.getParameters(ref thresholdId, ref rotationMaxId, ref thresholdVr, ref rotationMaxVr,
					ref minutiaeColor, ref minutiaeMatchColor, ref segmentsColor, ref segmentsMatchColor,
					ref directionsColor, ref directionsMatchColor);
				if ((thresholdId < (int)GRConstants.GR_MIN_THRESHOLD) || (thresholdId > (int)GRConstants.GR_MAX_THRESHOLD) ||
					(rotationMaxId < (int)GRConstants.GR_ROT_MIN) || (rotationMaxId > (int)GRConstants.GR_ROT_MAX)) 
				{
					MessageBox.Show("Invalid identify parameters values!");
					ok = false;
				}
				if ((thresholdVr < (int)GRConstants.GR_MIN_THRESHOLD) || (thresholdVr > (int)GRConstants.GR_MAX_THRESHOLD) ||
					(rotationMaxVr < (int)GRConstants.GR_ROT_MIN) || (rotationMaxVr > (int)GRConstants.GR_ROT_MAX)) 
				{
					MessageBox.Show("Invalid verify parameters values!");
					ok = false;
				}
				// set new identification parameters
				if (ok) 
				{
					ret = axGrFingerXCtrl1.SetIdentifyParameters(thresholdId, rotationMaxId, (int)GRConstants.GR_DEFAULT_CONTEXT);
					// error?
					if ((GRConstants)ret == GRConstants.GR_DEFAULT_USED) 
					{
						MessageBox.Show("Invalid identify parameters values. Default values will be used.");
						ok = false;
					}
					// set new verification parameters
					ret = axGrFingerXCtrl1.SetVerifyParameters(thresholdVr, rotationMaxVr, (int)GRConstants.GR_DEFAULT_CONTEXT);
					// error?
					if ((GRConstants)ret == GRConstants.GR_DEFAULT_USED) 
					{
						MessageBox.Show("Invalid verify parameters values. Default values will be used.");
						ok = false;
					}
					// if everything ok
					if (ok) 
					{
						// accept new parameters
						fopt.acceptChanges();
						// set new colors
						axGrFingerXCtrl1.SetBiometricDisplayColors(minutiaeColor, minutiaeMatchColor, segmentsColor, segmentsMatchColor, directionsColor, directionsMatchColor);
						return;
					}
				}
			}
		}

		// Display GrFinger version
		private void mnVersion_Click(object sender, System.EventArgs e)
		{
			myUtil.MessageVersion();
		}

		// -----------------------------------------------------------------------------------
		// GrFingerX events
		// -----------------------------------------------------------------------------------

		// A fingerprint reader was plugged on system
		private void axGrFingerXCtrl1_SensorPlug(object sender, AxGrFingerXLib._IGrFingerXCtrlEvents_SensorPlugEvent e)
		{
			myUtil.WriteLog("Sensor: " + e.idSensor + ". Event: Plugged.");
			axGrFingerXCtrl1.CapStartCapture(e.idSensor);
		}

		// A fingerprint reader was unplugged from system
		private void axGrFingerXCtrl1_SensorUnplug(object sender, AxGrFingerXLib._IGrFingerXCtrlEvents_SensorUnplugEvent e)
		{
			myUtil.WriteLog("Sensor: " + e.idSensor + ". Event: Unplugged.");
			axGrFingerXCtrl1.CapStopCapture(e.idSensor);
		}

		// A finger was placed on reader
		private void axGrFingerXCtrl1_FingerDown(object sender, AxGrFingerXLib._IGrFingerXCtrlEvents_FingerDownEvent e)
		{
			myUtil.WriteLog("Sensor: " + e.idSensor + ". Event: Finger Placed.");
		}

		// A finger was removed from reader
		private void axGrFingerXCtrl1_FingerUp(object sender, AxGrFingerXLib._IGrFingerXCtrlEvents_FingerUpEvent e)
		{
			myUtil.WriteLog("Sensor: " + e.idSensor + ". Event: Finger removed.");
		}

		// An image was acquired from reader
		private void axGrFingerXCtrl1_ImageAcquired(object sender, AxGrFingerXLib._IGrFingerXCtrlEvents_ImageAcquiredEvent e)
		{
			// Copying aquired image
			myUtil._raw.img = e.rawImage;
			myUtil._raw.height = (int) e.height;
			myUtil._raw.width = (int) e.width;
			myUtil._raw.Res = e.res;

			// Signaling that an Image Event occurred.
			myUtil.WriteLog("Sensor: " + e.idSensor + ". Event: Image captured.");
			try 
			{
				// display fingerprint image
				myUtil.PrintBiometricDisplay(false, GRConstants.GR_DEFAULT_CONTEXT);
			} 
			catch (Exception ex) 
			{
				myUtil.WriteLog(ex.Message);
			}
			// now we have a fingerprint, so we can extract the template
            if (!myUtil._isEnrolling)
            {

                // extracting template from the image
                btnExtract_Click();
                // identify fingerprint
                btIdentify_Click();
            }
            else // the enrollment is started
            {
                int ret = myUtil.Consolidate();
                if (ret < 0)
                    myUtil.WriteError((GRConstants)ret);
                else
                {
                    //display minutiae/segments/directions of the current image
                    btnExtract_Click();

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
                            //if we consolidated at least 8 templates and did not reach GR_ENROLL_GOOD, 
                            //we stop consolidation and save the current consolidated template
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
                            // no more templates can be consolidated
                            // save the current consolidated template
                            saveConsolidatedTemplate = true;                            
                            break;
                    }
                    if(saveConsolidatedTemplate)
                    {
                        int id;

                        // add fingerprint
                        id = myUtil.Enroll();
                        // write the result to the log
                        if (id >= 0)
                        {
                            myUtil.WriteLog("Consolidated template enrolled with id = " + id);
                        }
                        else
                        {
                            myUtil.WriteLog("Error: Consolidated template not enrolled");
                        }                        
                        btEnroll.PerformClick(); //stop consolidation
                    }
                }
            }
            GC.Collect();
		}

	}
}
