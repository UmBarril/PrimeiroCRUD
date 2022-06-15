using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRUD
{
    public partial class RegisterEditForm : Form
    {
        private SmartText nameST;
        private SmartText phoneST;
        private SmartText emailST;
        public MainForm mainf;
        private Image photo;
        private bool isImageSelected = false;
        private bool isEditing = false;
        private Int32 rowID;

        //REGISTER MODE
        public RegisterEditForm(MainForm mainf)
        {
            InitializeComponent();
            this.mainf = mainf;            
            nameST = new SmartText("Name", nameText);
            phoneST = new SmartText("Phone Number", mobileText);
            emailST = new SmartText("Email", emailText);         
        }
        //EDITOR MODE
        public RegisterEditForm(MainForm mainf, Int32 rowID)
        {
            InitializeComponent();
            this.mainf = mainf;
            this.isEditing = true;
            this.rowID = rowID;
            nameST = new SmartText("Name", nameText);
            phoneST = new SmartText("Phone Number", mobileText);
            emailST = new SmartText("Email", emailText);

            addEditBtn.Text = "Edit";
        }
        private void addEditBtn_Click(object sender, EventArgs e)
        {
            //Data recebida do dateTimePicker formatada para o tipo de dado MySql Date  
            string date = $"{dateTimePicker.Value.Year}-{dateTimePicker.Value.Month}-{dateTimePicker.Value.Day}";

            byte[] blob = null;

            if (isImageSelected)
            {
                try
                {
                    using (MemoryStream m = new MemoryStream())
                    {
                        photo.Save(m, photo.RawFormat);
                        blob = new byte[m.Length];
                        blob = m.ToArray();
                    }
                } catch(SystemException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            MySqlCommand cmd;

            //Se estiver editanto usa o comando UPDATE, caso o contrário, INSERT
            if (isEditing)
            {
                cmd = new MySqlCommand(
                    "UPDATE people SET " +
                    "person_name = @person_name," +
                    "phone_number = @phone_number," +
                    "email = @email," +
                    "birth_date = @birth_date," +
                    $"photo = @photo WHERE person_id = { rowID };",  Db.connection);
            } else {
                cmd = new MySqlCommand(
                    "insert into people" +
                    "(person_name,phone_number, email, birth_date, photo) " +
                    "values (@person_name,@phone_number, @email, @birth_date, @photo);", Db.connection); 
            }            
            
            //Definindo os parametros
            cmd.Parameters.Add("@person_name", MySqlDbType.VarChar).Value = nameText.Text;
            cmd.Parameters.Add("@phone_number", MySqlDbType.VarChar).Value = mobileText.Text;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = emailText.Text;
            cmd.Parameters.Add("@birth_date", MySqlDbType.Date).Value = date;
            cmd.Parameters.Add("@photo", MySqlDbType.MediumBlob).Value = blob;


            try
            {
                Db.Connect();
                cmd.Connection = Db.connection;
                cmd.ExecuteNonQuery();

                mainf.RefreshGrid();

                this.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void changePhotoBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "image files (*.png; *.jpg; *.gif;)|*.png;*.jpg;*.gif|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var image = Image.FromFile(ofd.FileName);
                if (image.Width != 150 || image.Height != 150)
                {
                    DialogResult dialogResult = MessageBox.Show("Wrong image size(it should be 150x150 pixels). The selected image will be resized, do you want to continue?", "Warning", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        photoBox.Image = (Image)new Bitmap(image, new Size(150, 150));

                        photo = image;

                        isImageSelected = true;
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }
            }
        }
        private void nameText_Enter(object sender, EventArgs e)
        {
            nameST.WritingState();
        }

        private void nameText_Leave(object sender, EventArgs e)
        {
            nameST.InicialState();
        }

        private void mobileText_Enter(object sender, EventArgs e)
        {
            phoneST.WritingState();
        }

        private void mobileText_Leave(object sender, EventArgs e)
        {
            phoneST.InicialState();
        }

        private void emailText_Enter(object sender, EventArgs e)
        {
            emailST.WritingState();
        }

        private void emailText_Leave(object sender, EventArgs e)
        {
            emailST.InicialState();
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}
