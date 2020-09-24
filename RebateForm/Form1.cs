using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace RebateForm
{

    public partial class RebateForm : Form
    {
        IO io = new IO();
        bool validData = false;
        private bool firstTimeLoad = true;
        private DataSet dsRebates;
        private int intBackspaceCount = 0;
        private bool fCharFlag = false;
        private string fCharTime;
        private string saveTime;
        private string strFName;
        private string strPhoneNo;
        //private string strLName;
        System.Drawing.Color colorGreen = System.Drawing.Color.Green;
        System.Drawing.Color colorRed = System.Drawing.Color.Red;
        System.Drawing.Color colorBlack = System.Drawing.Color.Black;

        //mode="neww" ==> saving new entry. mode="Edit" ==> editing already existing entry
        private string strMode = "new";


        public RebateForm()
        {
            InitializeComponent();
        }

        private void RebateForm_Load(object sender, EventArgs e)
        {
            if (firstTimeLoad)
            {
                dsRebates = io.ReadDataset("CS6326Asg2.txt");
                firstTimeLoad = false;
            }
            Refresh_listView(dsRebates);
        }


        //--------------------defined form Methods------------------------------//

        private void Refresh_listView(DataSet dataSet)
        {
            lstViewNamePhone.Items.Clear();
            foreach (DataRow dsRow in dataSet.Tables["Rebates"].Rows)
            {
                ListViewItem li = lstViewNamePhone.Items.Add((string)dsRow[0]);
                li.SubItems.Add((string)dsRow[9]);
                li.SubItems.Add((string)dsRow[2]);
            }
        }

        private void Clear_fields()
        {
            lstViewNamePhone.SelectedItems.Clear();

            txtFirstName.Text = "";
            lblFirstName.ForeColor = colorBlack;

            txtMiddleInitial.Text = "";


            txtLastName.Text = "";
            lblLastName.ForeColor = colorBlack;

            txtAddressLine1.Text = "";
            lblAddressLine1.ForeColor = colorBlack;

            txtAddressLine2.Text = "";
            lblAddressLine2.ForeColor = colorBlack;

            txtCity.Text = "";
            lblCity.ForeColor = colorBlack;

            txtState.Text = "";
            lblState.ForeColor = colorBlack;

            txtZipCode.Text = "";
            lblZipCode.ForeColor = colorBlack;

            txtGender.Text = "";
            lblGender.ForeColor = colorBlack;

            txtPhoneNo.Text = "";
            lblPhoneNo.ForeColor = colorBlack;

            txtEmail.Text = "";
            lblEmailId.ForeColor = colorBlack;

            cbProofAttached.Text = "";
            lblProofAttached.ForeColor = colorBlack;

            dateReceived.Text = "";
            lblDateReceived.ForeColor = colorBlack;

            strPhoneNo = "";
            strMode = "new";
            strFName = "";
            //btnSave.Enabled = false;
            btnDelete.Enabled = false;

            displayMessage("Discarded Changes! ", true, colorGreen);

        }

        private bool Validate_Data()
        {
            bool valid = txtFirstName.TextLength > 0 &&
                txtLastName.TextLength > 0 &&
                txtGender.TextLength > 0 &&
                txtEmail.TextLength > 0 &&
                txtAddressLine1.TextLength > 0 &&
                txtCity.TextLength > 0 &&
                txtState.TextLength > 0 &&
                txtZipCode.TextLength > 0;

            return valid;
        }

        private void displayMessage(string strStatusMsg, bool boolVisible, System.Drawing.Color color)
        {
            lblErrorMsg.Text = strStatusMsg;
            lblErrorMsg.ForeColor = color;
            lblErrorMsg.Visible = boolVisible;
        }

        //---------------------------end------------------------------------//


        //-----------------------Button Click events------------------------//

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveTime = DateTime.Now.ToString("HH:mm:ss");

            object[] oData = new object[dsRebates.Tables["Rebates"].Columns.Count];
            oData[0] = txtFirstName.Text;
            oData[1] = txtMiddleInitial.Text;
            oData[2] = txtLastName.Text;
            oData[3] = txtAddressLine1.Text;
            oData[4] = txtAddressLine2.Text;
            oData[5] = txtCity.Text;
            oData[6] = txtState.Text;
            oData[7] = txtZipCode.Text;
            oData[8] = txtGender.Text;
            oData[9] = txtPhoneNo.Text;
            oData[10] = txtEmail.Text;
            if (cbProofAttached.Checked)
                oData[11] = "Yes";
            else
                oData[11] = "No";
            //oData[11] = cboProofAttached.Text;
            oData[12] = dateReceived.Text;

            validData = Validate_Data();
            if (validData == false)
            {
                displayMessage("Required Data fields missing", true, colorRed);
                return;
            }

            if (strMode == "new")
            {

                foreach (DataRow dsRow in dsRebates.Tables["Rebates"].Rows)
                {
                    //----Check if Entry with Fname,Lname, phNo already exist------//
                    if ((dsRow[0].ToString() == txtFirstName.Text) && (dsRow[2].ToString() == txtLastName.Text) && (dsRow[9].ToString() == txtPhoneNo.Text))
                    {
                        validData = false;
                        //lblErrorMsg.ForeColor = System.Drawing.Color.Red;
                        //lblErrorMsg.Text = "Data already exists";
                        //lblErrorMsg.Visible = true;
                        displayMessage("Data already exists", true, colorRed);
                    }
                }

                if (validData)
                {

                    oData[13] = fCharTime;
                    oData[14] = saveTime;
                    oData[15] = intBackspaceCount;

                    dsRebates.Tables["Rebates"].Rows.Add(oData);
                    io.WriteDataset("CS6326Asg2.txt", dsRebates);
                    //Setting First charachter flag to false to record next first character input time.
                    fCharFlag = false;
                    intBackspaceCount = 0;
                    //lblErrorMsg.ForeColor = System.Drawing.Color.Green;
                    //lblErrorMsg.Text = "New Data Saved! ";
                    //lblErrorMsg.Visible = true;
                    Clear_fields();
                    displayMessage("New Data Saved! ", true, colorGreen);
                    Refresh_listView(dsRebates);
                    btnDelete.Enabled = false;

                }
            }
            else
            {

                if (validData)
                {
                    foreach (DataRow dsRow in dsRebates.Tables["Rebates"].Rows)
                    {
                        //----Check if Entry with Fname,Lname, phNo already exist------//
                        if ((dsRow[0].ToString() == txtFirstName.Text) &&
                            (dsRow[2].ToString() == txtLastName.Text) &&
                            (dsRow[9].ToString() == txtPhoneNo.Text))
                        {
                            validData = false;
                            //lblErrorMsg.ForeColor = System.Drawing.Color.Red;
                            //lblErrorMsg.Text = "Data already exists";
                            //lblErrorMsg.Visible = true;
                            displayMessage("Data already exists", true, colorRed);
                        }
                    }
                }

                if (validData)
                {
                    foreach (DataRow dsRow in dsRebates.Tables["Rebates"].Rows)
                    {
                        if ((dsRow[0].ToString() == strFName) && (dsRow[9].ToString() == strPhoneNo))
                        {
                            dsRow[0] = txtFirstName.Text;
                            dsRow[1] = txtMiddleInitial.Text;
                            dsRow[2] = txtLastName.Text;
                            dsRow[3] = txtAddressLine1.Text;
                            dsRow[4] = txtAddressLine2.Text;
                            dsRow[5] = txtCity.Text;
                            dsRow[6] = txtState.Text;
                            dsRow[7] = txtZipCode.Text;
                            dsRow[8] = txtGender.Text;
                            dsRow[9] = txtPhoneNo.Text;
                            dsRow[10] = txtEmail.Text;
                            if (cbProofAttached.Checked)
                                dsRow[11] = "Yes";
                            else
                                dsRow[11] = "No";
                            dsRow[12] = dateReceived.Text;
                            break;
                        }
                    }

                    //lblErrorMsg.ForeColor = System.Drawing.Color.Green;
                    //lblErrorMsg.Text = "Editted Data Saved! ";
                    //lblErrorMsg.Visible = true;

                    strFName = "";
                    strPhoneNo = "";
                    dsRebates.AcceptChanges();
                    io.WriteDataset("CS6326Asg2.txt", dsRebates);
                    Console.WriteLine("............edited changes Saved..........");
                    Clear_fields();
                    displayMessage("Editted Data Saved! ", true, colorGreen);
                    Refresh_listView(dsRebates);
                    btnDelete.Enabled = false;
                }


            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear_fields();
            //Refresh_listView(dsRebates);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataRow dsRow in dsRebates.Tables["Rebates"].Rows)
            {
                if ((dsRow[0].ToString() == strFName) && (dsRow[9].ToString() == strPhoneNo))
                {
                    dsRow.Delete();
                    //lblErrorMsg.ForeColor = System.Drawing.Color.Green;
                    //lblErrorMsg.Text = "Data Deleted! ";
                    //lblErrorMsg.Visible = true;

                    break;
                }
            }
            dsRebates.AcceptChanges();

            Clear_fields();
            displayMessage("Data Deleted! ", true, colorGreen);
            btnDelete.Enabled = false;
            io.WriteDataset("CS6326Asg2.txt", dsRebates);
            Refresh_listView(dsRebates);
        }

        //----------------------Click Events End----------------------------//



        private void lstViewNamePhone_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblErrorMsg.Visible = false;
            strMode = "edit";
            foreach (ListViewItem item in lstViewNamePhone.SelectedItems)
            {
                strFName = item.SubItems[0].Text;
                strPhoneNo = item.SubItems[1].Text;
                //strLName = item.SubItems[2].Text; 
            }

            foreach (DataRow dsRow in dsRebates.Tables["Rebates"].Rows)
            {
                if ((dsRow[0].ToString() == strFName) && (dsRow[9].ToString() == strPhoneNo))
                {
                    txtFirstName.Text = dsRow[0].ToString();
                    txtMiddleInitial.Text = dsRow[1].ToString();
                    txtLastName.Text = dsRow[2].ToString();
                    txtAddressLine1.Text = dsRow[3].ToString();
                    txtAddressLine2.Text = dsRow[4].ToString();
                    txtCity.Text = dsRow[5].ToString();
                    txtState.Text = dsRow[6].ToString();
                    txtZipCode.Text = dsRow[7].ToString();
                    txtGender.Text = dsRow[8].ToString();
                    txtPhoneNo.Text = dsRow[9].ToString();
                    txtEmail.Text = dsRow[10].ToString();
                    if (dsRow[11].ToString() == "Yes")
                        cbProofAttached.Checked = true;
                    else
                        cbProofAttached.Checked = false;

                    //cboProofAttached.Text = dsRow[11].ToString();
                    dateReceived.Text = dsRow[12].ToString();
                    fCharTime = dsRow[13].ToString();
                    saveTime = dsRow[14].ToString();
                    intBackspaceCount = int.Parse(dsRow[15].ToString());
                }

            }
            btnDelete.Enabled = true;

        }


        private void RebateForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (Validate_Data())
            //    btnSave.Enabled = true;
            //else
            //    btnSave.Enabled = false;
            //lblErrorMsg.Visible = false;
            if (e.KeyChar == '\b')
                intBackspaceCount++;
        }


        //------------------------Validations--------------------------------//


        //----WIP : needs Validation handling --------------------//
        private void txtBoxValidations(object sender, EventArgs s)
        {
            Console.WriteLine("Blank field: " + sender.ToString());
            //lblFirstName.ForeColor=System.Drawing.Color.Red;

            string txtBox = ((TextBox)sender).Name;
            string txtValue = ((TextBox)sender).Text;
            System.Drawing.Color color;
            if (txtValue == "")
            {
                color = System.Drawing.Color.Red;
                validData = false;
                lblErrorMsg.ForeColor = color;
                lblErrorMsg.Text = "Highlighted Field cannot be empty";
                lblErrorMsg.Visible = true;
            }
            else
            {
                validData = true;
                color = System.Drawing.Color.Black;
                lblErrorMsg.Visible = false;
            }
            switch (txtBox)
            {
                case "txtFirstName":
                    lblFirstName.ForeColor = color;
                    break;

                case "txtGender":
                    lblGender.ForeColor = color;
                    break;

                case "txtLastName":
                    lblLastName.ForeColor = color;
                    break;

                case "txtPhoneNo":
                    lblPhoneNo.ForeColor = color;
                    break;

                case "txtEmail":
                    lblEmailId.ForeColor = color;
                    break;

                case "txtAddressLine1":
                    lblAddressLine1.ForeColor = color;
                    break;

                case "txtCity":
                    lblCity.ForeColor = color;
                    break;

                case "txtState":
                    lblState.ForeColor = color;
                    break;

                case "txtZipCode":
                    lblZipCode.ForeColor = color;
                    break;


                default:
                    break;
            }
        }
        //-------------------------------------------------------//


        //----allows only numbers to be entered into zipcode------//
        private void txtZipCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        //----allows only Letters to be entered into State------//
        private void txtState_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //---allows only M/m F/f X/x Gender codes ------------//
        private void txtGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !(e.KeyChar == 'M' || e.KeyChar == 'm' || e.KeyChar == 'F' || e.KeyChar == 'f' || e.KeyChar == 'X' || e.KeyChar == 'x'))
            {
                e.Handled = true;
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

            //Enable save button on non empty 
            //btnSave.Enabled = txtFirstName.TextLength > 0 &&
            //                txtLastName.TextLength > 0 &&
            //                txtGender.TextLength > 0 &&
            //                txtEmail.TextLength > 0 &&
            //                txtAddressLine1.TextLength > 0 &&
            //                txtCity.TextLength > 0 &&
            //                txtState.TextLength > 0 &&
            //                txtZipCode.TextLength > 0;

            // log time when first char entered in FirstName field
            if (fCharFlag == false)
            {
                fCharTime = DateTime.Now.ToString("HH:mm:ss");
                fCharFlag = true;
            }

            //Dynamic Check
            if (txtFirstName.TextLength == 0)
            {
                validData = false;
                lblFirstName.ForeColor = colorRed;
                displayMessage("First Name Field cannot be empty", true, colorRed);
            }
            else
            {
                validData = true;
                lblFirstName.ForeColor = colorBlack;
                displayMessage("", false, colorRed);
            }

        }

        //--------------------Dynamic text change Check-------------------------//
        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (txtLastName.TextLength == 0)
            {
                validData = false;
                lblLastName.ForeColor = colorRed;
                displayMessage("Last Name cannot be empty", true, colorRed);
            }
            else
            {
                validData = true;
                lblLastName.ForeColor = colorBlack;
                displayMessage("", false, colorRed);
            }
        }

        private void txtGender_TextChanged(object sender, EventArgs e)
        {
            if (txtGender.TextLength == 0)
            {
                validData = false;
                lblGender.ForeColor = colorRed;
                displayMessage("Gender Field cannot be empty", true, colorRed);
            }
            else
            {
                validData = true;
                lblGender.ForeColor = colorBlack;
                displayMessage("", false, colorRed);
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.TextLength == 0)
            {
                validData = false;
                lblEmailId.ForeColor = colorRed;
                displayMessage("Email Field cannot be empty", true, colorRed);
            }
            else
            {
                validData = true;
                lblEmailId.ForeColor = colorBlack;
                displayMessage("", false, colorRed);
            }
        }

        private void txtAddressLine1_TextChanged(object sender, EventArgs e)
        {
            if (txtAddressLine1.TextLength == 0)
            {
                validData = false;
                lblAddressLine1.ForeColor = colorRed;
                displayMessage("Address Line1 cannot be empty", true, colorRed);
            }
            else
            {
                validData = true;
                lblAddressLine1.ForeColor = colorBlack;
                displayMessage("", false, colorRed);
            }
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            if (txtCity.TextLength == 0)
            {
                validData = false;
                lblCity.ForeColor = colorRed;
                displayMessage("City cannot be empty", true, colorRed);
            }
            else
            {
                validData = true;
                lblCity.ForeColor = colorBlack;
                displayMessage("", false, colorRed);
            }
        }

        private void txtState_TextChanged(object sender, EventArgs e)
        {
            if (txtState.TextLength == 0)
            {
                validData = false;
                lblState.ForeColor = colorRed;
                displayMessage("State cannot be empty", true, colorRed);
            }
            else
            {
                validData = true;
                lblState.ForeColor = colorBlack;
                displayMessage("", false, colorRed);
            }
        }

        private void txtZipCode_TextChanged(object sender, EventArgs e)
        {
            if (txtZipCode.TextLength == 0)
            {
                validData = false;
                lblZipCode.ForeColor = colorRed;
                displayMessage("Zip Code cannot be empty", true, colorRed);
            }
            else
            {
                validData = true;
                lblZipCode.ForeColor = colorBlack;
                displayMessage("", false, colorRed);
            }
        }

        private void txtPhoneNo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cbProofAttached_CheckedChanged(object sender, EventArgs e)
        {

        }

        //--------------------Dynamic Check End-------------------------//






    }

    //------------Class for Reading & writing Data-----------------------//
    public class IO
    {
        public IO()
        {

        }

        public DataSet ReadDataset(string strFileName)
        {
            DataSet dsRebates = new DataSet();
            dsRebates.Tables.Add("Rebates");
            dsRebates.Tables["Rebates"].Columns.Add("FName");
            dsRebates.Tables["Rebates"].Columns.Add("MInitial");
            dsRebates.Tables["Rebates"].Columns.Add("LName");
            dsRebates.Tables["Rebates"].Columns.Add("AddrLine1");
            dsRebates.Tables["Rebates"].Columns.Add("AddrLine2");
            dsRebates.Tables["Rebates"].Columns.Add("City");
            dsRebates.Tables["Rebates"].Columns.Add("State");
            dsRebates.Tables["Rebates"].Columns.Add("ZipCode");
            dsRebates.Tables["Rebates"].Columns.Add("Gender");
            dsRebates.Tables["Rebates"].Columns.Add("PhoneNo");
            dsRebates.Tables["Rebates"].Columns.Add("Email");
            dsRebates.Tables["Rebates"].Columns.Add("PurchaseProof");
            dsRebates.Tables["Rebates"].Columns.Add("DateReceived");
            dsRebates.Tables["Rebates"].Columns.Add("FCharTime");
            dsRebates.Tables["Rebates"].Columns.Add("SaveTime");
            dsRebates.Tables["Rebates"].Columns.Add("BackspaceCount");


            if (File.Exists(strFileName))
            {

                //int rowId = 0;
                StreamReader srFile = new StreamReader(strFileName);
                while (!srFile.EndOfStream)
                {
                    //Reading Linewise from text file -- trims any whitespace at start & end
                    string strLine = srFile.ReadLine().Trim();


                    //Adding Data read to Rebates Dataset
                    dsRebates.Tables["Rebates"].Rows.Add(strLine.Split('\t'));

                }
                srFile.Close();

            }
            else
            {
                StreamWriter swFile = new StreamWriter(strFileName);
                swFile.Close();
            }

            return dsRebates;

        }


        public void WriteDataset(string strFileName, DataSet dataSet)
        {

            Console.WriteLine("Data Object Added.........Writing DataSet to file");
            String dataEntry = "";
            foreach (DataRow dsRow in dataSet.Tables["Rebates"].Rows)
            {
                //Adding new line if not the first line of text
                if (dataEntry != "")
                    dataEntry = dataEntry + '\n';
                foreach (object strRowitem in dsRow.ItemArray)
                {
                    if (strRowitem != DBNull.Value)
                        dataEntry = dataEntry + (string)strRowitem + '\t';
                }
            }
            using (StreamWriter swFile = File.CreateText(strFileName))
            {
                swFile.WriteLine(dataEntry);
            }
        }

    }

    //------------Class IO End-----------------------//
}
