using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace database
{
    public partial class Form1 : Form
    {
        private string connectionString = "Host=localhost;Port=5432;Database=dbproje;Username=postgres;Password=2002";
        public Form1()
        {
            InitializeComponent();
        }

        NpgsqlConnection connect = new NpgsqlConnection("Host=localhost;Port=5432;Database=dbproje;Username=postgres;Password=Yunus.2002");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_AutoSizeChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            connect.Open();
            NpgsqlCommand addCustomer = new NpgsqlCommand("insert into customers (customer_id,first_name,last_name,email,address,phone,created_at,country,city) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", connect);
            addCustomer.Parameters.AddWithValue("@p1", int.Parse(TxtCustomer.Text));
            addCustomer.Parameters.AddWithValue("@p2", TxtFirstName.Text);
            addCustomer.Parameters.AddWithValue("qp3", TxtLastNmae.Text);
            addCustomer.Parameters.AddWithValue("@p4", TxtEmail.Text);
            addCustomer.Parameters.AddWithValue("@P5", TxtAddress.Text);
            addCustomer.Parameters.AddWithValue("@p6", int.Parse(TxtPhone.Text));
            addCustomer.Parameters.AddWithValue("@p7", TxtCreated.Text);
            addCustomer.Parameters.AddWithValue("@p8", TxtCountry.Text);
            addCustomer.Parameters.AddWithValue("@p9", TxtCity.Text);
            addCustomer.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("customer added");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            connect.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("DELETE from customers where customer_id=@p1", connect);
            cmd.Parameters.AddWithValue("@p1 ", int.Parse(TxtCustomer.Text));
            if (!string.IsNullOrWhiteSpace(TxtCustomer.Text))
            {
                DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (result == DialogResult.Yes)
                {
                    // Silme işlemi için gerekli kodlar buraya gelecek
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("Ürün silme işlemi başarılı");
                }
                else
                {
                    connect.Close();
                    MessageBox.Show("Ürün silme işlemi iptal edildi veya başarısız oldu.");
                }
            }

        }

        private void buttonListing_Click(object sender, EventArgs e)
        {
            string k = "select * from customers";
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(k, connect);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            connect.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update customers set first_name=@p2,last_name=@p3,email=@p4,address=@p5,phone=@p6,created_at=@p7,country=@p8,city=@p9  where customer_id=@p1");
            komut3.Parameters.AddWithValue("@p1", int.Parse(TxtCustomer.Text));
            komut3.Parameters.AddWithValue("@p2", TxtFirstName.Text);
            komut3.Parameters.AddWithValue("qp3", TxtLastNmae.Text);
            komut3.Parameters.AddWithValue("@p4", TxtEmail.Text);
            komut3.Parameters.AddWithValue("@P5", TxtAddress.Text);
            komut3.Parameters.AddWithValue("@p6", int.Parse(TxtPhone.Text));
            komut3.Parameters.AddWithValue("@p7", TxtCreated.Text);
            komut3.Parameters.AddWithValue("@p8", TxtCountry.Text);
            komut3.Parameters.AddWithValue("@p9", TxtCity.Text);
            komut3.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("customer updated");
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchText = buttonSearch.Text;

            try
            {
                // Bağlantı zaten tanımlı olduğu varsayılarak kullanılıyor.
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }

                using (NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = connect;
                    command.CommandText = "SELECT * FROM customers WHERE customer_id = @searchText OR phone::TEXT LIKE @searchText OR first_name ILIKE @searchText OR last_name ILIKE @searchText OR email ILIKE @searchText OR address ILIKE @searchText OR country ILIKE @searchText OR city ILIKE @searchText";



                    command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet);

                        if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
                        {
                            // DataGridView veya ListView gibi bir kontrolü kullanarak verileri göstermek istiyorsanız:
                             dataGridView1.DataSource = dataSet.Tables[0];

                            // Eğer sadece bir MessageBox ile göstermek istiyorsanız:
                            string message = "";
                            foreach (DataRow row in dataSet.Tables[0].Rows)
                            {
                                message += $"Customer ID: {row["customer_id"]}\nFirst Name: {row["first_name"]}\nLast Name: {row["last_name"]}\nEmail: {row["email"]}\nAddress: {row["address"]}\nPhone: {row["phone"]}\nCountry: {row["country"]}\nCity: {row["city"]}\n\n";
                            }
                            MessageBox.Show(message);
                        }
                        else
                        {
                            MessageBox.Show("Veri bulunamadı.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }

        }
    }
}
