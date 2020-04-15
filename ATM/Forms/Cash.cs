using ATM.Forms;
using System;
using System.Windows.Forms;

namespace ATM
{
    public partial class Cash : Form
    {  
        public Cash()
        {
            InitializeComponent();           
        }

        private void Exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Списать 100.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Hundred_Click(object sender, EventArgs e)
        {
            MainForm owner = Owner as MainForm;
            if (IsDiscard(owner.ATM.TotalSum, (int)Card.Nominal.Сто))
            {
                owner.card.RemovalMoney(Card.Nominal.Сто, 0);
                owner.ATM.Transaction(owner.card.spisanie, owner.card.IsRemoval);
            }
        }

        /// <summary>
        /// Списать 500.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FiveHundred_Click(object sender, EventArgs e)
        {
            MainForm owner = Owner as MainForm;
            if (IsDiscard(owner.ATM.TotalSum, (int)Card.Nominal.Пятьсот))
            {
                owner.card.RemovalMoney(Card.Nominal.Пятьсот);
                owner.ATM.Transaction(owner.card.spisanie, owner.card.IsRemoval);
            }
        }

        /// <summary>
        /// Списать 1000.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OneThousand_Click(object sender, EventArgs e)
        {
            MainForm owner = Owner as MainForm;
            if (IsDiscard(owner.ATM.TotalSum, (int)Card.Nominal.Тысяча))
            {
                owner.card.RemovalMoney(Card.Nominal.Тысяча);
                owner.ATM.Transaction(owner.card.spisanie, owner.card.IsRemoval);
            }
        }

        /// <summary>
        /// Списать 2000.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TwoThousand_Click(object sender, EventArgs e)
        {
            MainForm owner = Owner as MainForm;
            if (IsDiscard(owner.ATM.TotalSum, (int)Card.Nominal.Две_тысячи))
            {
                owner.card.RemovalMoney(Card.Nominal.Две_тысячи);
                owner.ATM.Transaction(owner.card.spisanie, owner.card.IsRemoval);
            }
        }

        /// <summary>
        /// Списать 5000.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FiveThousand_Click(object sender, EventArgs e)
        {
            MainForm owner = Owner as MainForm;
            if (IsDiscard(owner.ATM.TotalSum, (int)Card.Nominal.Пять_тысяч))
            {
                owner.card.RemovalMoney(Card.Nominal.Пять_тысяч);
                owner.ATM.Transaction(owner.card.spisanie, owner.card.IsRemoval);
            }
        }

        /// <summary>
        /// Списать произвольную сумму.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetAmount_Click(object sender, EventArgs e)
        {
            int user_summa = 0;
            Nominal nominal = new Nominal();
            nominal.ShowDialog();
            user_summa = nominal.Sum;

            MainForm owner = Owner as MainForm;
            if (IsDiscard(owner.ATM.TotalSum, user_summa))
            {
                owner.card.RemovalMoney(Card.Nominal.none, user_summa);
                owner.ATM.Transaction(owner.card.spisanie, owner.card.IsRemoval);
            }
        }

        /// <summary>
        /// Проверить"емкость" банкомата.
        /// </summary>
        /// <returns></returns>
        private bool IsDiscard(int total, int sum_with_card)
        {
            if (sum_with_card > total)
            {
                MessageBox.Show($"Запрашиваемая сумма {sum_with_card} меньше доступного остатка {total} в терминале.", "ATM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else return true;
        }
    }
}
