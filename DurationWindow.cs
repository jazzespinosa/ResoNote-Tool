using System;
using System.DirectoryServices.AccountManagement;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace ResoNote_Tool_v2
{
    public partial class DurationWindow : Form
    {
        MainWindow ownerForm = null;

        public DurationWindow(MainWindow ownerForm)
        {
            InitializeComponent();
            this.ownerForm = ownerForm;
        }
        string expireDate = "";
        string closeApp = "";
        string userSamAccount = "";
        string analyst = Environment.UserName;

        private void DurationWindow_Load(object sender, EventArgs e)
        {
            dtPickerDuration.Value = DateTime.Today;
        }

        private void checkBoxPermanent_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPermanent.Checked == true)
            {
                checkBoxTemp.Checked = false;
            }
            checkBoxChange();
        }

        private void checkBoxTemp_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTemp.Checked == true)
            {
                checkBoxPermanent.Checked = false;
            }
            checkBoxChange();
        }

        void checkBoxChange()
        {
            if (checkBoxTemp.Checked == true || checkBoxPermanent.Checked == true)
            {
                userControlDeactivate();
                dtPickerDuration.Enabled = false;
            }
            else
            {
                dtPickerDuration.Enabled = true;
                if (dtPickerDuration.Value < DateTime.Today || dtPickerDuration.Value < DateTime.Today.AddDays(2))
                {
                }
                else
                    userControlActivate();
            }

        }

        private void dtPickerDuration_ValueChanged(object sender, EventArgs e)
        {
            if (dtPickerDuration.Value < DateTime.Today || dtPickerDuration.Value < DateTime.Today.AddDays(2))
            {
                userControlDeactivate();
                if (checkBoxTemp.Checked == true || checkBoxPermanent.Checked == true)
                {
                    userControlDeactivate();
                }
            }
            else
                userControlActivate();
        }

        void userControlActivate()
        {
            ucSamAccName ctrlUser = new ucSamAccName();

            panel2.SuspendLayout();
            panel2.Controls.Clear();
            panel2.Controls.Add(ctrlUser);
            panel2.ResumeLayout();
        }

        void userControlDeactivate()
        {
            panel2.SuspendLayout();
            panel2.Controls.Clear();
            panel2.ResumeLayout();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkBoxTemp.Checked == true || checkBoxPermanent.Checked == true)
            {
                expireDate = null;
                if (checkBoxTemp.Checked == true)
                {
                    expireDate = "Temp";
                    saveConfirm(expireDate);
                }
                else if (checkBoxPermanent.Checked == true)
                {
                    expireDate = "Permanent";
                    saveConfirm(expireDate);
                }
            }
            else
            {
                if (dtPickerDuration.Value < DateTime.Today)
                {
                    MessageBox.Show("Invalid date selected.", "Error!");
                    expireDate = null;
                    dtPickerDuration.Value = DateTime.Today;
                    return;
                }
                else if (dtPickerDuration.Value < DateTime.Today.AddDays(2))
                {
                    MessageBox.Show("For 1 day duration only, select/check Temp (1 day).", "Information");
                    expireDate = null;
                    return;
                }
                expireDate = dtPickerDuration.Text;
                validateInfo(expireDate);
            }

        }

        void validateInfo(string expDate)
        {
            string expire = expDate;
            string initialPath = Environment.CurrentDirectory;

            //get usersamaccount from txtbox
            ucSamAccName ctrlUser = (ucSamAccName)panel2.Controls[0];
            userSamAccount = ctrlUser.samValue;

            if (userSamAccount == "" || userSamAccount == null)
            {
                MessageBox.Show("Samaccountname is empty.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //check if samaccountname exist
            string targetDomain = initialPath + @"\config\Directory\AU Local Admin Rights\domain.txt";
            string[] dataDomain = File.ReadAllLines(targetDomain);
            string domain = dataDomain[0];

            bool userExists = false;
            if (domain == "NA" || domain == "" || domain == null)
            {
            }
            else
            {
                try
                {
                    using (var ctx = new PrincipalContext(ContextType.Domain, domain))
                    {
                        using (var user = UserPrincipal.FindByIdentity(ctx, userSamAccount))
                        {
                            if (user != null)
                            {
                                userExists = true;
                                user.Dispose();
                            }
                            else
                            {
                                MessageBox.Show("User does not exist.");
                                return;
                            }
                        }
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    throw;
                }
            }

            string pathSave = initialPath + @"\config\Directory\AU Local Admin Rights\save path.txt";
            if (!File.Exists(pathSave))
            {
                string pathFileName = pathSave.Split('\\').Last();
                MessageBox.Show("File " + pathFileName + " does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] dataSave = File.ReadAllLines(pathSave);
            string saveLocationCSV = dataSave[0];

            if (!File.Exists(saveLocationCSV))
            {
                MessageBox.Show("Save location does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string message = "Confirm request details: \nUser: \t   " + userSamAccount + "\nEnd Date:  " + expire;
            const string caption = "Confirmation";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OKCancel,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                string[] toSaveXLSX = { analyst, userSamAccount, expire, "PolLocalAdmin" };
                string csvLine = analyst + ", " + userSamAccount + ", " + expire + ", " + "PolLocalAdmin" + Environment.NewLine;

                //save to csv file
                saveToCsv(csvLine, saveLocationCSV);

                MessageBox.Show("Saved!");
            }
            else
                return;

            saveConfirm(expire);
        }

        void saveToCsv(string getcsvLine, string getsavelocation)
        {
            string csvLine = getcsvLine;
            string saveLocation = getsavelocation;

            byte[] csvLineBytes = Encoding.Default.GetBytes(csvLine);
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(csvLineBytes, 0, csvLineBytes.Length);
                using (FileStream file = new FileStream(saveLocation, FileMode.Open, FileAccess.Read))
                {
                    byte[] bytes = new byte[file.Length];
                    file.Read(bytes, 0, (int)file.Length);
                    ms.Write(bytes, 0, (int)file.Length);
                }

                using (FileStream file = new FileStream(saveLocation, FileMode.Open, FileAccess.Write))
                {
                    ms.WriteTo(file);
                }
            }
        }

        void saveConfirm(string expDate)
        {
            string expire = expDate;
            this.ownerForm.PassValue(expire);
            closeApp = "N";
            this.ownerForm.ifNotLocalAdmin(closeApp);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            expireDate = null;
            closeApp = "Y";
            this.ownerForm.ifNotLocalAdmin(closeApp);
            this.Close();
        }

        private void DurationWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closeApp != "N")
            {
                closeApp = "Y";
                this.ownerForm.ifNotLocalAdmin(closeApp);
            }
        }


    }
}
