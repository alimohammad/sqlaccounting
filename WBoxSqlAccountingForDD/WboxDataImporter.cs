using System;
using System.Windows.Forms;

namespace WBoxSqlAccountingForDD
{
    public partial class WboxDataImporter : Form
    {
        dynamic sqlAccountingCom;
        public WboxDataImporter()
        {
            InitializeComponent();
        }

        private void CheckLogin()
        {
            sqlAccountingCom = CreateSqlAccServer();
            if (sqlAccountingCom.IsLogin)
            {
                sqlAccountingCom.Login(txtUN.Text.Trim(), txtPW.Text.Trim(), textDBPath.Text.Trim(), txtDBName.Text.Trim());
                sqlAccountingCom.Minimize();
            }
        }

        public dynamic CreateSqlAccServer()
        {
            Type sqlAccounting = Type.GetTypeFromProgID("SQLAcc.BizApp");
            return Activator.CreateInstance(sqlAccounting);
        }

        private void importFromWbox_Click(object sender, EventArgs e)
        {

        }

        private void exportToSqlAccounting_Click(object sender, EventArgs e)
        {
            CheckLogin();

            var bizObject = sqlAccountingCom.BizObjects.Find("AR_IV");

            var mainDataSet = bizObject.DataSets.Find("MainDataSet");
            var detailDataSet = bizObject.DataSets.Find("cdsDocDetail");

            var date = new DateTime(2018, 12, 28);

            bizObject.New();
            mainDataSet.FindField("DocDate").value = date;
            mainDataSet.FindField("PostDate").value = date;
            mainDataSet.FindField("Code").value = "300-A0003";
            mainDataSet.FindField("Description").value = "Test Sales";
            detailDataSet.Append();
            detailDataSet.FindField("Account").value = "500-000";
            detailDataSet.FindField("Description").value = "Test";
            detailDataSet.FindField("TaxInclusive").value = 0;
            detailDataSet.FindField("Amount").value = 410.37;

            //detailDataSet.DisableControl();
            detailDataSet.FindField("TaxInclusive").value = 1;
            detailDataSet.EnableControls();
            detailDataSet.Post();

            bizObject.Save();
            bizObject.Close();
            MessageBox.Show("Done");
        }
    }
}
