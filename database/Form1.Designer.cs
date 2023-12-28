    namespace database
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customer_id = new System.Windows.Forms.Label();
            this.TxtCustomer = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TxtFirstName = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.TxtLastNmae = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.TxtPhone = new System.Windows.Forms.Label();
            this.TxtAddress = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.TxtCreated = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.TxtCountry = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.TxtCity = new System.Windows.Forms.Label();
            this.buttonListing = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(663, 457);
            this.dataGridView1.TabIndex = 0;
            // 
            // customer_id
            // 
            this.customer_id.AutoSize = true;
            this.customer_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customer_id.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customer_id.Location = new System.Drawing.Point(710, 33);
            this.customer_id.Name = "customer_id";
            this.customer_id.Size = new System.Drawing.Size(129, 22);
            this.customer_id.TabIndex = 1;
            this.customer_id.Text = "Customer İd :";
            // 
            // TxtCustomer
            // 
            this.TxtCustomer.Location = new System.Drawing.Point(862, 32);
            this.TxtCustomer.Name = "TxtCustomer";
            this.TxtCustomer.Size = new System.Drawing.Size(162, 26);
            this.TxtCustomer.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(862, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(162, 26);
            this.textBox2.TabIndex = 4;
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.AutoSize = true;
            this.TxtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtFirstName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtFirstName.Location = new System.Drawing.Point(710, 79);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(119, 22);
            this.TxtFirstName.TabIndex = 3;
            this.TxtFirstName.Text = "First Name :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(862, 128);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(162, 26);
            this.textBox3.TabIndex = 6;
            // 
            // TxtLastNmae
            // 
            this.TxtLastNmae.AutoSize = true;
            this.TxtLastNmae.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtLastNmae.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtLastNmae.Location = new System.Drawing.Point(710, 129);
            this.TxtLastNmae.Name = "TxtLastNmae";
            this.TxtLastNmae.Size = new System.Drawing.Size(117, 22);
            this.TxtLastNmae.TabIndex = 5;
            this.TxtLastNmae.Text = "Last Name :";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(862, 271);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(162, 26);
            this.textBox4.TabIndex = 8;
            // 
            // TxtPhone
            // 
            this.TxtPhone.AutoSize = true;
            this.TxtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPhone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtPhone.Location = new System.Drawing.Point(710, 275);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(79, 22);
            this.TxtPhone.TabIndex = 7;
            this.TxtPhone.Text = "Phone :";
            // 
            // TxtAddress
            // 
            this.TxtAddress.AutoSize = true;
            this.TxtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAddress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtAddress.Location = new System.Drawing.Point(710, 223);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(95, 22);
            this.TxtAddress.TabIndex = 9;
            this.TxtAddress.Text = "Address :";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(862, 176);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(162, 26);
            this.textBox6.TabIndex = 12;
            // 
            // TxtEmail
            // 
            this.TxtEmail.AutoSize = true;
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtEmail.Location = new System.Drawing.Point(710, 177);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(71, 22);
            this.TxtEmail.TabIndex = 11;
            this.TxtEmail.Text = "Email :";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(862, 223);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(162, 26);
            this.textBox5.TabIndex = 10;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(862, 318);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(162, 26);
            this.textBox7.TabIndex = 14;
            // 
            // TxtCreated
            // 
            this.TxtCreated.AutoSize = true;
            this.TxtCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtCreated.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtCreated.Location = new System.Drawing.Point(710, 322);
            this.TxtCreated.Name = "TxtCreated";
            this.TxtCreated.Size = new System.Drawing.Size(116, 22);
            this.TxtCreated.TabIndex = 13;
            this.TxtCreated.Text = "Created at :";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(862, 365);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(162, 26);
            this.textBox8.TabIndex = 16;
            // 
            // TxtCountry
            // 
            this.TxtCountry.AutoSize = true;
            this.TxtCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtCountry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtCountry.Location = new System.Drawing.Point(710, 369);
            this.TxtCountry.Name = "TxtCountry";
            this.TxtCountry.Size = new System.Drawing.Size(92, 22);
            this.TxtCountry.TabIndex = 15;
            this.TxtCountry.Text = "Country :";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(862, 414);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(162, 26);
            this.textBox9.TabIndex = 18;
            // 
            // TxtCity
            // 
            this.TxtCity.AutoSize = true;
            this.TxtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtCity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtCity.Location = new System.Drawing.Point(710, 418);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(57, 22);
            this.TxtCity.TabIndex = 17;
            this.TxtCity.Text = "City :";
            // 
            // buttonListing
            // 
            this.buttonListing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.buttonListing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonListing.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonListing.Location = new System.Drawing.Point(1050, 398);
            this.buttonListing.Name = "buttonListing";
            this.buttonListing.Size = new System.Drawing.Size(182, 71);
            this.buttonListing.TabIndex = 22;
            this.buttonListing.Text = "LİSTİNG";
            this.buttonListing.UseVisualStyleBackColor = false;
            this.buttonListing.Click += new System.EventHandler(this.buttonListing_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Location = new System.Drawing.Point(1050, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(182, 71);
            this.buttonAdd.TabIndex = 23;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDelete.Location = new System.Drawing.Point(1050, 110);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(182, 71);
            this.buttonDelete.TabIndex = 24;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUpdate.Location = new System.Drawing.Point(1050, 200);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(182, 71);
            this.buttonUpdate.TabIndex = 25;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSearch.Location = new System.Drawing.Point(1050, 299);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(182, 71);
            this.buttonSearch.TabIndex = 26;
            this.buttonSearch.Text = "SEARCH";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1267, 483);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonListing);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.TxtCity);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.TxtCountry);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.TxtCreated);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.TxtPhone);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.TxtLastNmae);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.TxtCustomer);
            this.Controls.Add(this.customer_id);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.AutoSizeChanged += new System.EventHandler(this.Form1_AutoSizeChanged);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label customer_id;
        private System.Windows.Forms.TextBox TxtCustomer;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label TxtFirstName;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label TxtLastNmae;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label TxtPhone;
        private System.Windows.Forms.Label TxtAddress;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label TxtEmail;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label TxtCreated;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label TxtCountry;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label TxtCity;
        private System.Windows.Forms.Button buttonListing;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSearch;
    }
}

