using System;
using System.Windows.Forms;

namespace ATM.Forms
{
    public partial class Deposit : Form
    {
        /// <summary>
        /// Введенная сумма для использования в родительской форме.
        /// </summary>
        public int Sum { get; set; } = 0;
        public Deposit()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Подтвердить сумму для внесения.
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
            else MessageBox.Show("Укажите сумму для внесения на карту.", "ATM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
