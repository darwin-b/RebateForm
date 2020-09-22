using System;
using System.Data;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;

namespace RebateForm
{
    public partial class RebateForm : Form
    {
        bool saveEnable = true;
        bool validData = true;
        private DataSet dsRebates;


        public RebateForm()
        {
            InitializeComponent();
        }

        private DataSet ReadDataset(string strFileName)
        {
            DataSet dsRebates = new DataSet();
            dsRebates.Tables.Add("Rebates");
            dsRebates.Tables["Rebates"].Columns.Add("FName");
            dsRebates.Tables["Rebates"].Columns.Add("mInitial");
            dsRebates.Tables["Rebates"].Columns.Add("lName");
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


        private void WriteDataset(string strFileName, DataSet dataSet, object[] oData)
        {
            //Add data object to Dataset
            dsRebates.Tables["Rebates"].Rows.Add(oData);

            //Writing Dataset to File
            Console.WriteLine("Data Object Added.........Writing DataSet to file");
            //-----------------WIP---------------------------//
            foreach (DataRow dsRow in dataSet.Tables["Rebates"].Rows)
            {
                String dataEntry = "";
                foreach (object strRowitem in dsRow.ItemArray)
                {
                    if (strRowitem != DBNull.Value)
                        dataEntry = dataEntry + (string)strRowitem + '\t';
                }
                using (StreamWriter swFile = File.AppendText(strFileName))
                {
                    swFile.WriteLine(dataEntry);
                }
            }


        }

        private void RebateForm_Load(object sender, EventArgs e)
        {
            dsRebates=ReadDataset("CS6326Asg2.txt");

        }




        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }


        private void btnSave_Click(object sender, EventArgs e)
        {

            object[] oData = new object[dsRebates.Tables["Rebates"].Columns.Count];
            oData[0] = txtFirstName.Text;
            oData[1] = txtMiddleInitial.Text ;
            oData[2] = txtLastName.Text ;
            oData[3] = txtAddressLine1.Text ;
            oData[4] = txtAddressLine2.Text ;
            oData[5] = txtCity.Text ;
            oData[6] = txtState.Text ;
            oData[7] = txtZipCode.Text ;
            oData[8] = txtGender.Text ;
            oData[9] = txtPhoneNo.Text ;
            oData[10] = txtEmail.Text ;
            oData[11] = cboProofAttached.Text;
            oData[12] = dateReceived.Text;


            if(validData)
            {
                WriteDataset("CS6326Asg2.txt", dsRebates, oData);
            }




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
            ListViewItem li = lstViewNamePhone.Items.Add("Red");
            li.SubItems.Add("fruit");

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            RebateForm_Load(sender,e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }


    }


}
