using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WIA;
using System.Runtime.InteropServices;
using System.IO;
using System.Net;

namespace storemedicals.allform.Records
{
    public partial class Form_Add_Records : Form
    {
        public Form_Add_Records()
        {
            InitializeComponent();
        }

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/"))
                    return true;
            }
            catch
            {
                return false;
            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            try
            {
                var deviceManager = new DeviceManager();

                DeviceInfo AvailableScanner = null;

                for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++) // Loop Through the get List Of Devices.
                {
                    if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType) // Skip device If it is not a scanner
                    {
                        continue;
                    }

                    AvailableScanner = deviceManager.DeviceInfos[i];

                    break;
                }

                var device = AvailableScanner.Connect(); //Connect to the available scanner.

                var ScanerItem = device.Items[1]; // select the scanner.

                var imgFile = (ImageFile)ScanerItem.Transfer(FormatID.wiaFormatJPEG); //Retrive an image in Jpg format and store it into a variable.

              

            }
            catch (COMException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog ofd = new OpenFileDialog();
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                ofd.Filter = "Image Files|*.jpg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(ofd.FileName))
                    {
                        textBox10.Text = ofd.FileName;
                        Bitmap bmp = new Bitmap(Image.FromFile(ofd.FileName));
                        pictureBox2.Image = bmp;
                    }


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_add_item_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                dgvcat.ColumnCount = 3;
                dgvcat.Columns[0].Name = "Product ID";
                dgvcat.Columns[1].Name = "Product Name";
                dgvcat.Columns[2].Name = "Product Price";

                string[] row = new string[] { "1", "Product 1", "1000" };
                dgvcat.Rows.Add(row);
                row = new string[] { "2", "Product 2", "2000" };
                dgvcat.Rows.Add(row);
                row = new string[] { "3", "Product 3", "3000" };
                dgvcat.Rows.Add(row);
                row = new string[] { "4", "Product 4", "4000" };
                dgvcat.Rows.Add(row);

                DataGridViewImageColumn img = new DataGridViewImageColumn();
                Image image = Image.FromFile("Image Path");
                img.Image = image;
                dgvcat.Columns.Add(img);
                img.HeaderText = "Image";
                img.Name = "img";

    */

              

                MemoryStream sm = new MemoryStream();
                  pictureBox2.Image.Save(sm, pictureBox2.Image.RawFormat);
                  byte[] img = sm.ToArray();
                  dgvcat.Rows.Add(img);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
           // Boolean ch = CheckForInternetConnection();

           // if (!ch)
           // {
               // MessageBox.Show("لا يوجد اتصال");
           // }
          //  else
          ///  {
               // MessageBox.Show("يوجد اتصال");
          //  }

        }

        private void Form_Add_Records_Load(object sender, EventArgs e)
        {
            try
            {
                var deviceManager = new DeviceManager();

                for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++) // Loop Through the get List Of Devices.
                {
                    if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType) // Skip device If it is not a scanner
                    {
                        continue;
                    }
                    lstListOfScanner.Items.Add(deviceManager.DeviceInfos[i].Properties["Name"].get_Value());
                }
            }
            catch (COMException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
