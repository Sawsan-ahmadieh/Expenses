using incomeproj.Data;
using incomeproj.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace incomeproj
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        //MainContext dgvcontext = new MainContext();
        List<Expenditure> AllData = new List<Expenditure>();
        string fileName;

        private void cmdDetails_Click(object sender, EventArgs e)
        {
            if (gbPrice.Visible == true)
            {
                gbPrice.Visible = false;
                cmdDetails.Text = "Details";
            }
            else
            {
                gbPrice.Visible = true;
                cmdDetails.Text = "Hide";
            }
        }
        #region Accessing data using XML
        private void loadDataFromXML()
        {
            openFileDialog1.InitialDirectory = @"C:\Users\user\source\repos\incomeproj\incomeproj\bin\Debug\netcoreapp3.1";
            openFileDialog1.Filter = "XML files (*.xml)|*.xml";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                var streamreader = new StreamReader(fileName);
                XmlSerializer ser = new XmlSerializer(typeof(List<Expenditure>));
                AllData = ser.Deserialize(streamreader) as List<Expenditure>;
                streamreader.Close();
            }

            //Environment.GetEnvironmentVariable("HOMEDRIVE");
        }
        private List<Expenditure> returnListItems(List<Expenditure> lst)
        {

            var ex = lst.Distinct().ToList();
            return ex;
        }
        private List<Expenditure> returnExpenditures(List<Expenditure> lst)
        {
            var ex = lst;
            return ex;
        }
        private void SaveDataXml()
        {
            TextWriter txw = new StreamWriter(fileName);
            XmlSerializer ser = new XmlSerializer(typeof(List<Expenditure>));
            ser.Serialize(txw, AllData);
            txw.Close();
        }
        #endregion
        #region using sql database
        private List<Expenditure> loadItems()
        {
            using (var context = new MainContext())
            {
                IEnumerable<Expenditure> listExp = context.Expenditure.ToList();
                var noDup = listExp.Distinct().ToList();
                return noDup;
            }
        }
        #endregion
        private void cmdCalculate_Click(object sender, EventArgs e)
        {
            decimal price;
            int quantity;
            if (txtPrice.Text != "" && txtQuantity.Text != "")
            {
                if (decimal.TryParse(txtPrice.Text, out price) && int.TryParse(txtQuantity.Text, out quantity))
                {
                    var result = price * quantity;
                    txtAmount.Text = result.ToString();
                }
                else
                {
                    MessageBox.Show("Price should be in decimal and the quantity is only numbers");
                }

            }
        }
        #region user Interface upload data
        private void UIInitializeData()
        {
            var listItems = returnListItems(AllData);
            cboItem.Items.Clear();
            foreach (var item in listItems)
            {
                cboItem.Items.Add(item.ItemName);
            }
            //Load ItemName Filter
            cboFilterItem.Items.Clear();
            foreach (var item in listItems)
            {
                cboFilterItem.Items.Add(item.ItemName);
            }
            //Load table

            //var AllRecords = dgvcontext.Expenditure.ToList();     //for dbcontext
            var AllRecords = returnExpenditures(AllData);
            dgvExpense.DataSource = AllRecords;
            dgvExpense.Columns["Id"].Visible = false;

            var Expdgv = new BindingList<Expenditure>(AllRecords.ToList());
            Expdgv.AllowEdit = true;
            Expdgv.AllowRemove = true;
            Expdgv.AllowNew = false;

            BindingSource ExpSource = new BindingSource();
            ExpSource.DataSource = Expdgv;
            dgvExpense.DataSource = ExpSource;

        }
        #endregion
        private void cmdSave_Click(object sender, EventArgs e)
        {
            decimal price, totalamount;
            int quantity;
            DateTime orderDate;
            if (cboItem.Text == "" || txtAmount.Text == "" || txtDate.Text == "")
            {
                MessageBox.Show("Please type the Item name, total amount and date");
                this.cboItem.Focus();
                return;
            }
            //  using (var context = new MainContext())
            //{
            if (DateTime.TryParse(txtDate.Text, out orderDate) && decimal.TryParse(txtAmount.Text, out totalamount))
            {
                var expenditure = new Models.Expenditure
                {
                    ItemName = this.cboItem.Text,
                    ItemDesc = this.txtDesc.Text,
                    DateTaken = orderDate,
                    Price = null,
                    Qty = null,
                    TotalAmount = totalamount
                };
                if (txtPrice.Text != "")
                {
                    if (decimal.TryParse(txtPrice.Text, out price))
                    {
                        expenditure.Price = price;
                    }
                    else
                    {
                        MessageBox.Show("Price is only decimal");
                        txtPrice.Focus();
                        return;
                    }
                }
                if (txtQuantity.Text != "")
                {
                    if (int.TryParse(txtQuantity.Text, out quantity))
                    {
                        expenditure.Qty = quantity;
                    }
                    else
                    {
                        MessageBox.Show("quantity only number");
                        txtQuantity.Focus();
                        return;
                    }
                }
                AllData.Add(expenditure);
                SaveDataXml();
                //context.Expenditure.Add(expenditure);
                //context.SaveChanges();
                UIInitializeData();


                MessageBox.Show("Saved Successfully");
                txtAmount.Text = "";
                txtPrice.Text = "";
                txtQuantity.Text = "";
                txtDesc.Text = "";
            }
            else
            {
                MessageBox.Show("Type mismatch please check the formate of date and numbers");
                return;
            }
            //}
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Today.ToShortDateString();
            //Load ItemName from SQL Database
            ////var listItems = loadItems();


            //Load ItemName from XML file
            loadDataFromXML();

            UIInitializeData();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //using (var context = new MainContext())
            // {
            //     IEnumerable<Expenditure> AllRecords = context.Expenditure;
            IEnumerable<Expenditure> AllRecords = AllData;
            if (cboFilterItem.Text != "")
            {
                AllRecords = AllRecords.Where(exp => exp.ItemName == cboFilterItem.Text);
            }

            if (txtFilterStart.Text != "")
            {
                DateTime dt;
                if (DateTime.TryParse(txtFilterStart.Text, out dt))
                {
                    AllRecords = AllRecords.Where(exp => exp.DateTaken >= dt);
                }
                else
                {
                    MessageBox.Show("Please correct the format of date");
                    txtFilterStart.Focus();
                    return;
                }
            }
            if (txtFilterEnd.Text != "")
            {
                DateTime dtEnd;
                if (DateTime.TryParse(txtFilterEnd.Text, out dtEnd))
                {
                    AllRecords = AllRecords.Where(exp => exp.DateTaken <= dtEnd);
                }
                else
                {
                    MessageBox.Show("Please correct the format of date");
                    txtFilterEnd.Focus();
                    return;
                }
            }
            dgvExpense.Columns["Id"].Visible = false;
            dgvExpense.DataSource = AllRecords.ToList();

            decimal total;
            total = AllRecords.Sum(exp => exp.TotalAmount);
            lblTotal.Text = total.ToString("000,000.00");//or using ###,###.0#
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvExpense.Update();
            SaveDataXml();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
        
        }
    }
}
