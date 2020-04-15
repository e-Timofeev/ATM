namespace ATM
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Cash = new System.Windows.Forms.Button();
            this.layoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.StateATM = new System.Windows.Forms.LinkLabel();
            this.logotip = new System.Windows.Forms.PictureBox();
            this.welcome = new System.Windows.Forms.Label();
            this.operations = new System.Windows.Forms.Label();
            this.Balans = new System.Windows.Forms.Button();
            this.Deposit = new System.Windows.Forms.Button();
            this.Services = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.LinkLabel();
            this.bankName = new System.Windows.Forms.Label();
            this.LK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.CardReceiver = new System.Windows.Forms.PictureBox();
            this.layoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logotip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardReceiver)).BeginInit();
            this.SuspendLayout();
            // 
            // Cash
            // 
            this.Cash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Cash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cash.Enabled = false;
            this.Cash.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cash.Location = new System.Drawing.Point(131, 75);
            this.Cash.Name = "Cash";
            this.Cash.Size = new System.Drawing.Size(250, 122);
            this.Cash.TabIndex = 4;
            this.Cash.Text = "СНЯТЬ НАЛИЧНЫЕ";
            this.Cash.UseVisualStyleBackColor = false;
            this.Cash.Click += new System.EventHandler(this.Cash_Click);
            // 
            // layoutPanel
            // 
            this.layoutPanel.BackColor = System.Drawing.SystemColors.Info;
            this.layoutPanel.ColumnCount = 3;
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.layoutPanel.Controls.Add(this.StateATM, 0, 2);
            this.layoutPanel.Controls.Add(this.logotip, 0, 0);
            this.layoutPanel.Controls.Add(this.welcome, 1, 0);
            this.layoutPanel.Controls.Add(this.operations, 2, 0);
            this.layoutPanel.Controls.Add(this.Balans, 1, 2);
            this.layoutPanel.Controls.Add(this.Deposit, 2, 1);
            this.layoutPanel.Controls.Add(this.Services, 1, 3);
            this.layoutPanel.Controls.Add(this.Cash, 1, 1);
            this.layoutPanel.Controls.Add(this.Exit, 0, 4);
            this.layoutPanel.Controls.Add(this.bankName, 0, 1);
            this.layoutPanel.Controls.Add(this.LK, 2, 2);
            this.layoutPanel.Controls.Add(this.Cancel, 2, 3);
            this.layoutPanel.Controls.Add(this.CardReceiver, 0, 3);
            this.layoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutPanel.Location = new System.Drawing.Point(0, 0);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.RowCount = 5;
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.04076F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.73244F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.73244F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.73244F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutPanel.Size = new System.Drawing.Size(640, 480);
            this.layoutPanel.TabIndex = 0;
            // 
            // StateATM
            // 
            this.StateATM.AutoSize = true;
            this.StateATM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StateATM.Location = new System.Drawing.Point(3, 200);
            this.StateATM.Name = "StateATM";
            this.StateATM.Size = new System.Drawing.Size(122, 128);
            this.StateATM.TabIndex = 22;
            this.StateATM.TabStop = true;
            this.StateATM.Text = "Состояние терминала";
            this.StateATM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StateATM.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.StateATM_LinkClicked);
            // 
            // logotip
            // 
            this.logotip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logotip.Image = ((System.Drawing.Image)(resources.GetObject("logotip.Image")));
            this.logotip.Location = new System.Drawing.Point(3, 3);
            this.logotip.Name = "logotip";
            this.logotip.Size = new System.Drawing.Size(122, 66);
            this.logotip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logotip.TabIndex = 1;
            this.logotip.TabStop = false;
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
            this.welcome.TabIndex = 2;
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
            this.operations.TabIndex = 3;
            this.operations.Text = "ВЫБЕРИТЕ ДАЛЬНЕЙШУЮ ОПЕРАЦИЮ";
            this.operations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Balans
            // 
            this.Balans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Balans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Balans.Enabled = false;
            this.Balans.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Balans.Location = new System.Drawing.Point(131, 203);
            this.Balans.Name = "Balans";
            this.Balans.Size = new System.Drawing.Size(250, 122);
            this.Balans.TabIndex = 6;
            this.Balans.Text = "ЗАПРОСИТЬ БАЛАНС";
            this.Balans.UseVisualStyleBackColor = false;
            this.Balans.Click += new System.EventHandler(this.Balans_Click);
            // 
            // Deposit
            // 
            this.Deposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Deposit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Deposit.Enabled = false;
            this.Deposit.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Deposit.Location = new System.Drawing.Point(387, 75);
            this.Deposit.Name = "Deposit";
            this.Deposit.Size = new System.Drawing.Size(250, 122);
            this.Deposit.TabIndex = 5;
            this.Deposit.Text = "ПОПОЛНЕНИЕ";
            this.Deposit.UseVisualStyleBackColor = false;
            this.Deposit.Click += new System.EventHandler(this.Deposit_Click);
            // 
            // Services
            // 
            this.Services.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Services.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Services.Enabled = false;
            this.Services.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Services.Location = new System.Drawing.Point(131, 331);
            this.Services.Name = "Services";
            this.Services.Size = new System.Drawing.Size(250, 122);
            this.Services.TabIndex = 8;
            this.Services.Text = "УСЛУГИ БАНКА";
            this.Services.UseVisualStyleBackColor = false;
            this.Services.Click += new System.EventHandler(this.Services_Click);
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.layoutPanel.SetColumnSpan(this.Exit, 3);
            this.Exit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Exit.Location = new System.Drawing.Point(3, 456);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(634, 24);
            this.Exit.TabIndex = 0;
            this.Exit.TabStop = true;
            this.Exit.Text = "ВЫЙТИ";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Exit_LinkClicked);
            // 
            // bankName
            // 
            this.bankName.AutoSize = true;
            this.bankName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bankName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.bankName.Location = new System.Drawing.Point(3, 72);
            this.bankName.Name = "bankName";
            this.bankName.Size = new System.Drawing.Size(122, 128);
            this.bankName.TabIndex = 10;
            this.bankName.Text = "ПАО \"Денег нет, но вы держитесь\"";
            this.bankName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LK
            // 
            this.LK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LK.Enabled = false;
            this.LK.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LK.Location = new System.Drawing.Point(387, 203);
            this.LK.Name = "LK";
            this.LK.Size = new System.Drawing.Size(250, 122);
            this.LK.TabIndex = 9;
            this.LK.Text = "ЛИЧНЫЙ КАБИНЕТ";
            this.LK.UseVisualStyleBackColor = false;
            this.LK.Click += new System.EventHandler(this.LK_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cancel.Enabled = false;
            this.Cancel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.Location = new System.Drawing.Point(387, 331);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(250, 122);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "ОТМЕНА И ВЫХОД";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // CardReceiver
            // 
            this.CardReceiver.Image = ((System.Drawing.Image)(resources.GetObject("CardReceiver.Image")));
            this.CardReceiver.Location = new System.Drawing.Point(3, 331);
            this.CardReceiver.Name = "CardReceiver";
            this.CardReceiver.Size = new System.Drawing.Size(122, 122);
            this.CardReceiver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CardReceiver.TabIndex = 23;
            this.CardReceiver.TabStop = false;
            this.CardReceiver.Click += new System.EventHandler(this.CardReceiver_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.ControlBox = false;
            this.Controls.Add(this.layoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM";
            this.layoutPanel.ResumeLayout(false);
            this.layoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logotip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardReceiver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Button LK;
        protected System.Windows.Forms.Button Deposit;
        protected System.Windows.Forms.Button Balans;
        protected System.Windows.Forms.Button Cancel;
        protected System.Windows.Forms.Button Services;
        protected System.Windows.Forms.Button Cash;
        protected System.Windows.Forms.PictureBox logotip;
        protected System.Windows.Forms.Label welcome;
        protected System.Windows.Forms.Label operations;
        protected System.Windows.Forms.Label bankName;
        protected System.Windows.Forms.TableLayoutPanel layoutPanel;
        protected System.Windows.Forms.LinkLabel Exit;
        private System.Windows.Forms.LinkLabel StateATM;
        private System.Windows.Forms.PictureBox CardReceiver;
    }
}

