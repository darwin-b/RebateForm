using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace RebateForm
{
    public partial class RebateForm : Form
    {

        bool validData = true;
        private bool firstTimeLoad = true;
        private DataSet dsRebates;
        private int intBackspaceCount=0;
        private bool fCharFlag=false;
        private string fCharTime;
        private string saveTime;
        private string strFName;
        private string strPhoneNo;

        //mode="neww" ==> saving new entry mode="Edit" ==> editing already existing entry
        private string strMode="new";


        public RebateForm()
        {
            InitializeComponent();
        }



        //--------------------defined functions------------------------------//
        private DataSet ReadDataset(string strFileName)
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
                //string strHeader = "";
                //foreach (DataColumn column in dsRebates.Tables["Rebates"].Columns)
                //{
                //    strHeader = strHeader + column + '\t';
                //}
                //swFile.WriteLine(strHeader);
                swFile.Close();
            }

            return dsRebates;

        }


        private void WriteDataset(string strFileName, DataSet dataSet)
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

        private void Refresh_listView(DataSet dataSet)
        {
            lstViewNamePhone.Items.Clear();
            foreach (DataRow dsRow in dataSet.Tables["Rebates"].Rows)
            {
                ListViewItem li = lstViewNamePhone.Items.Add((string)dsRow[0]);
                li.SubItems.Add((string)dsRow[9]);
            }
        }

        private void Clear_fields()
        {
            txtFirstName.Text = "";
            txtMiddleInitial.Text = "";
            txtLastName.Text = "";
            txtAddressLine1.Text = "";
            txtAddressLine2.Text = "";
            txtCity.Text = "";
            txtState.Text = "";
            txtZipCode.Text = "";
            txtGender.Text = "";
            txtPhoneNo.Text = "";
            txtEmail.Text = "";
            cboProofAttached.Text = "";
            dateReceived.Text = "";

            strPhoneNo = "";
            strMode = "new";
            strFName = "";
            btnDelete.Enabled = false;
        }

        //---------------------------end------------------------------------//



        private void RebateForm_Load(object sender, EventArgs e)
        {
            if(firstTimeLoad)
            {
                dsRebates = ReadDataset("CS6326Asg2.txt");
                firstTimeLoad = false;
            }

            Refresh_listView(dsRebates);
        }


        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }


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
            oData[11] = cboProofAttached.Text;
            oData[12] = dateReceived.Text;


            if (strMode == "new")
            {
                oData[13] = fCharTime;
                oData[14] = saveTime;
                oData[15] = intBackspaceCount;

                if (validData)
                {
                    dsRebates.Tables["Rebates"].Rows.Add(oData);
                    WriteDataset("CS6326Asg2.txt", dsRebates);
                    //Setting First charachter flag to false to record next first character input time.
                    fCharFlag = false;
                    intBackspaceCount = 0;
                    Refresh_listView(dsRebates);
                }
            }
            else
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
                        dsRow[11] = cboProofAttached.Text;
                        dsRow[12] = dateReceived.Text;
                        break;
                    }

                    // dsRebates.Tables["Rebates"].Rows.Remove[dsRow];
                }

                strFName = "";
                strPhoneNo = "";
                dsRebates.AcceptChanges();
                Console.WriteLine("............edited changes Saved..........");
                Clear_fields();
                Refresh_listView(dsRebates);

            }

            btnDelete.Enabled = false;


            //string strHeader = "";
            //foreach (DataColumn column in dsRebates.Tables["Rebates"].Columns)
            //{
            //    strHeader = strHeader + column + '\t';
            //}
            //swFile.WriteLine(strHeader);

            //swFile.Close();
        }


        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

            //------------ WIP : Valdations  -----------------------------//
            if(fCharFlag==false)
            {
                fCharTime = DateTime.Now.ToString("HH:mm:ss");
                fCharFlag = true;
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMiddleInitial_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGender_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhoneNo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddressLine1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddressLine2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtState_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtZipCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboProofAttached_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateReceived_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lstViewNamePhone_SelectedIndexChanged(object sender, EventArgs e)
        {
            //strFName = lstViewNamePhone.SelectedItems[0].SubItems[0].ToString();
            //strPhoneNo = lstViewNamePhone.SelectedItems[0].SubItems[1].ToString();
            strMode = "edit";
            foreach (ListViewItem item in lstViewNamePhone.SelectedItems)
            {
                strFName = item.SubItems[0].Text;
                strPhoneNo = item.SubItems[1].Text;
            }


            foreach (DataRow dsRow in dsRebates.Tables["Rebates"].Rows)
            {
                if ((dsRow[0].ToString() == strFName) && (dsRow[9].ToString() == strPhoneNo))
                {
                        txtFirstName.Text           = dsRow[0].ToString();
                        txtMiddleInitial.Text       = dsRow[1].ToString();
                        txtLastName.Text            = dsRow[2].ToString();
                        txtAddressLine1.Text        = dsRow[3].ToString();
                        txtAddressLine2.Text        = dsRow[4].ToString();
                        txtCity.Text                = dsRow[5].ToString();
                        txtState.Text               = dsRow[6].ToString();
                        txtZipCode.Text             = dsRow[7].ToString();
                        txtGender.Text              = dsRow[8].ToString();
                        txtPhoneNo.Text             = dsRow[9].ToString();
                        txtEmail.Text               = dsRow[10].ToString();
                        cboProofAttached.Text       = dsRow[11].ToString();
                        dateReceived.Text           = dsRow[12].ToString();
                        fCharTime                   = dsRow[13].ToString();
                        saveTime                    = dsRow[14].ToString();
                        intBackspaceCount           = int.Parse(dsRow[15].ToString());
                }

            }

            Console.WriteLine(strFName + strPhoneNo);
            btnDelete.Enabled = true;



        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            strMode = "new";
            Clear_fields();
            //Refresh_listView(dsRebates);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //

            foreach (DataRow dsRow in dsRebates.Tables["Rebates"].Rows)
            {
                if ((dsRow[0].ToString() == strFName)&&(dsRow[9].ToString() == strPhoneNo))
                {
                    dsRow.Delete();
                    break;
                }

               // dsRebates.Tables["Rebates"].Rows.Remove[dsRow];
            }
            dsRebates.AcceptChanges();
            //
            Clear_fields();
            btnDelete.Enabled = false;
            WriteDataset("CS6326Asg2.txt", dsRebates);
            strFName ="";
            strPhoneNo = "";
            Refresh_listView(dsRebates);
        }

        private void RebateForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                intBackspaceCount++;
        }


        //----WIP : needs Validation handling --------------------//
        private void Blank_Field(object sender,EventArgs s)
        {
            Console.WriteLine("Blank field: ");
            lblFirstName.ForeColor=System.Drawing.Color.Red;
        }
    }


}
