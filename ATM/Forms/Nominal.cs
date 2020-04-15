using System;
using System.Windows.Forms;

namespace ATM.Forms
{
    public partial class Nominal : Form
    {
        /// <summary>
        /// Введенная сумма для использования в родительской форме.
        /// </summary>
        public int Sum { get; set; } = 0;
        public Nominal()
        {
            InitializeComponent();
        }

        
        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Подтвердить сумму для снятия.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ok_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "")
            {
                Sum = Convert.ToInt32(maskedTextBox1.Text);
                Close();
            }
            else MessageBox.Show("Укажите сумму для снятия.", "ATM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
