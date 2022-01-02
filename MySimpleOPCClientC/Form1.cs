using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OPCAutomation;


namespace MySimpleOPCClientC
{

    public partial class Form1 : Form
    {

        public OPCServer MyOPCServer = new OPCServer();
        public OPCGroup My_OPCGroup = null;
        OPCItem MyOPCItem;
        int[] MyServerHandles = new int[2];
        object[] MyValues = new object[2];
        public Array MyErrors ;

        public Form1()
        {
            InitializeComponent();

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try 
            {
                MyOPCServer.Connect(txtServerName.Text, txtServer.Text);
                My_OPCGroup = MyOPCServer.OPCGroups.Add("MyOPCGroup");
                My_OPCGroup.IsActive = true;
                My_OPCGroup.IsSubscribed = true;
                My_OPCGroup.UpdateRate = 1000;    //1 second
                My_OPCGroup.DataChange += new DIOPCGroupEvent_DataChangeEventHandler(My_OPCGroup_DataChange);
                My_OPCGroup.AsyncWriteComplete += new DIOPCGroupEvent_AsyncWriteCompleteEventHandler(My_OPCGroup_AsyncWriteComplete);
                My_OPCGroup.AsyncReadComplete += new DIOPCGroupEvent_AsyncReadCompleteEventHandler(My_OPCGroup_AsyncReadComplete);
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
            } catch (Exception ex) {
                MessageBox.Show("Error Connect! \r\n" + ex.Message);
            }
        }

        private void My_OPCGroup_DataChange(int TransactionID, int NumItems, ref Array ClientHandles, ref Array ItemValues, ref Array Qualities, ref Array TimeStamps)
        {
            txtReadVal.Text = ItemValues.GetValue(1).ToString();
        }

        private void My_OPCGroup_AsyncReadComplete(int TransactionID, int NumItems, ref Array ClientHandles, ref Array ItemValues, ref Array Qualities, ref Array TimeStamps, ref Array Errors)
        {
            txtReadVal.Text = ItemValues.GetValue(1).ToString();
        }

        private void My_OPCGroup_AsyncWriteComplete(int TransactionID, int NumItems, ref System.Array ClientHandles, ref System.Array Errors)
        {
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            My_OPCGroup.IsSubscribed = false;
            My_OPCGroup.IsActive = false;
            MyOPCServer.OPCGroups.RemoveAll();
            btnDisconnect.Enabled = false;
            btnConnect.Enabled = true;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            MyOPCItem = My_OPCGroup.OPCItems.AddItem(txtItem.Text, 1);
            MyServerHandles[1] = MyOPCItem.ServerHandle;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            int transID;
            My_OPCGroup.AsyncRead(1, MyServerHandles, out MyErrors, DateTime.Now.Second, out transID);
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            MyValues[1] = txtWriteVal.Text;
            int transID;
            My_OPCGroup.AsyncWrite(1, MyServerHandles, MyValues, out MyErrors, DateTime.Now.Second, out transID);
        }
    }
}
