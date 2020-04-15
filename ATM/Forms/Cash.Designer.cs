namespace ATM
{
    partial class Cash
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cash));
            this.LayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SetAmount = new System.Windows.Forms.Button();
            this.FiveThousand = new System.Windows.Forms.Button();
            this.TwoThousand = new System.Windows.Forms.Button();
            this.OneThousand = new System.Windows.Forms.Button();
            this.FiveHundred = new System.Windows.Forms.Button();
            this.Hundred = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.LinkLabel();
            this.logotip = new System.Windows.Forms.PictureBox();
            this.bankName = new System.Windows.Forms.Label();
            this.welcome = new System.Windows.Forms.Label();
            this.operations = new System.Windows.Forms.Label();
            this.LayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logotip)).BeginInit();
            this.SuspendLayout();
            // 
            // LayoutPanel
            // 
            this.LayoutPanel.BackColor = System.Drawing.SystemColors.Info;
            this.LayoutPanel.ColumnCount = 3;
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.LayoutPanel.Controls.Add(this.SetAmount, 2, 3);
            this.LayoutPanel.Controls.Add(this.FiveThousand, 1, 3);
            this.LayoutPanel.Controls.Add(this.TwoThousand, 2, 2);
            this.LayoutPanel.Controls.Add(this.OneThousand, 1, 2);
            this.LayoutPanel.Controls.Add(this.FiveHundred, 2, 1);
            this.LayoutPanel.Controls.Add(this.Hundred, 1, 1);
            this.LayoutPanel.Controls.Add(this.Exit, 0, 4);
            this.LayoutPanel.Controls.Add(this.logotip, 0, 0);
            this.LayoutPanel.Controls.Add(this.bankName, 0, 1);
            this.LayoutPanel.Controls.Add(this.welcome, 1, 0);
            this.LayoutPanel.Controls.Add(this.operations, 2, 0);
            this.LayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.LayoutPanel.Name = "LayoutPanel";
            this.LayoutPanel.RowCount = 5;
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.003F));
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.66533F));
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.66533F));
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.66533F));
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001F));
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LayoutPanel.Size = new System.Drawing.Size(640, 480);
            this.LayoutPanel.TabIndex = 0;
            // 
            // SetAmount
            // 
            this.SetAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SetAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetAmount.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SetAmount.Location = new System.Drawing.Point(387, 329);
            this.SetAmount.Name = "SetAmount";
            this.SetAmount.Size = new System.Drawing.Size(250, 121);
            this.SetAmount.TabIndex = 20;
            this.SetAmount.Text = "ЗАДАТЬ СУММУ";
            this.SetAmount.UseVisualStyleBackColor = false;
            this.SetAmount.Click += new System.EventHandler(this.SetAmount_Click);
            // 
            // FiveThousand
            // 
            this.FiveThousand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.FiveThousand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiveThousand.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FiveThousand.Location = new System.Drawing.Point(131, 329);
            this.FiveThousand.Name = "FiveThousand";
            this.FiveThousand.Size = new System.Drawing.Size(250, 121);
            this.FiveThousand.TabIndex = 19;
            this.FiveThousand.Text = "5000";
            this.FiveThousand.UseVisualStyleBackColor = false;
            this.FiveThousand.Click += new System.EventHandler(this.FiveThousand_Click);
            // 
            // TwoThousand
            // 
            this.TwoThousand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TwoThousand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TwoThousand.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TwoThousand.Location = new System.Drawing.Point(387, 202);
            this.TwoThousand.Name = "TwoThousand";
            this.TwoThousand.Size = new System.Drawing.Size(250, 121);
            this.TwoThousand.TabIndex = 18;
            this.TwoThousand.Text = "2000";
            this.TwoThousand.UseVisualStyleBackColor = false;
            this.TwoThousand.Click += new System.EventHandler(this.TwoThousand_Click);
            // 
            // OneThousand
            // 
            this.OneThousand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.OneThousand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OneThousand.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OneThousand.Location = new System.Drawing.Point(131, 202);
            this.OneThousand.Name = "OneThousand";
            this.OneThousand.Size = new System.Drawing.Size(250, 121);
            this.OneThousand.TabIndex = 17;
            this.OneThousand.Text = "1000";
            this.OneThousand.UseVisualStyleBackColor = false;
            this.OneThousand.Click += new System.EventHandler(this.OneThousand_Click);
            // 
            // FiveHundred
            // 
            this.FiveHundred.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.FiveHundred.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiveHundred.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FiveHundred.Location = new System.Drawing.Point(387, 75);
            this.FiveHundred.Name = "FiveHundred";
            this.FiveHundred.Size = new System.Drawing.Size(250, 121);
            this.FiveHundred.TabIndex = 16;
            this.FiveHundred.Text = "500";
            this.FiveHundred.UseVisualStyleBackColor = false;
            this.FiveHundred.Click += new System.EventHandler(this.FiveHundred_Click);
            // 
            // Hundred
            // 
            this.Hundred.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Hundred.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Hundred.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Hundred.Location = new System.Drawing.Point(131, 75);
            this.Hundred.Name = "Hundred";
            this.Hundred.Size = new System.Drawing.Size(250, 121);
            this.Hundred.TabIndex = 15;
            this.Hundred.Text = "100";
            this.Hundred.UseVisualStyleBackColor = false;
            this.Hundred.Click += new System.EventHandler(this.Hundred_Click);
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.LayoutPanel.SetColumnSpan(this.Exit, 3);
            this.Exit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Exit.Location = new System.Drawing.Point(3, 453);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(634, 27);
            this.Exit.TabIndex = 14;
            this.Exit.TabStop = true;
            this.Exit.Text = "НАЗАД";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Exit_LinkClicked);
            // 
            // logotip
            // 
            this.logotip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logotip.Image = ((System.Drawing.Image)(resources.GetObject("logotip.Image")));
            this.logotip.Location = new System.Drawing.Point(3, 3);
            this.logotip.Name = "logotip";
            this.logotip.Size = new System.Drawing.Size(122, 66);
            this.logotip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logotip.TabIndex = 2;
            this.logotip.TabStop = false;
            // 
            // bankName
            // 
            this.bankName.AutoSize = true;
            this.bankName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bankName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.bankName.Location = new System.Drawing.Point(3, 72);
            this.bankName.Name = "bankName";
            this.bankName.Size = new System.Drawing.Size(122, 127);
            this.bankName.TabIndex = 11;
            this.bankName.Text = "ПАО \"Денег нет, но вы держитесь\"";
            this.bankName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcome.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.welcome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.welcome.Location = new System.Drawing.Point(131, 0);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(250, 72);
            this.welcome.TabIndex = 12;
            this.welcome.Text = "ГЛАВНОЕ МЕНЮ";
            this.welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // operations
            // 
            this.operations.AutoSize = true;
            this.operations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operations.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.operations.Location = new System.Drawing.Point(387, 0);
            this.operations.Name = "operations";
            this.operations.Size = new System.Drawing.Size(250, 72);
            this.operations.TabIndex = 13;
            this.operations.Text = "ВЫБЕРИТЕ СУММУ СНЯТИЯ В РУБЛЯХ";
            this.operations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Cash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.ControlBox = false;
            this.Controls.Add(this.LayoutPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ATM";
            this.LayoutPanel.ResumeLayout(false);
            this.LayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logotip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.PictureBox logotip;
        protected System.Windows.Forms.Label bankName;
        protected System.Windows.Forms.Label welcome;
        protected System.Windows.Forms.Label operations;
        protected System.Windows.Forms.LinkLabel Exit;
        protected System.Windows.Forms.TableLayoutPanel LayoutPanel;
        protected System.Windows.Forms.Button FiveThousand;
        protected System.Windows.Forms.Button TwoThousand;
        protected System.Windows.Forms.Button OneThousand;
        protected System.Windows.Forms.Button FiveHundred;
        protected System.Windows.Forms.Button Hundred;
        protected System.Windows.Forms.Button SetAmount;
    }
}
