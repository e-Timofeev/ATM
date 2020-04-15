using ATM.Forms;

using System;
using System.Drawing;
using System.Windows.Forms;

namespace ATM
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Текущая карточка.
        /// </summary>
        public Card card;

        /// <summary>
        /// Терминал.
        /// </summary>
        public ATM ATM  = new ATM();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Выйти из приложения?", "ATM", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Снятие.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cash_Click(object sender, EventArgs e)
        {
            Cash cash = new Cash
            {
                Owner = this
            };
            cash.ShowDialog();
        }

        /// <summary>
        /// Пополнение.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Deposit_Click(object sender, EventArgs e)
        {
            int user_summa = 0;
            Deposit depos = new Deposit();
            depos.ShowDialog();
            user_summa = depos.Sum;

            Cash cash = new Cash();
            {
                card.AddMomey(user_summa);
                ATM.Transaction(user_summa, card.IsRemoval);
            }
        }

        /// <summary>
        /// Запросить состояние терминала.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StateATM_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => ATM.GetState();

        /// <summary>
        /// "Вставляет" карту для работы. На карте исходная сумма 10 000 р.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CardReceiver_Click(object sender, EventArgs e)
        {
            card = new Card(Guid.NewGuid());
            Block(true);
            card.InsertCard(sender);          
        }

        /// <summary>
        /// "Включить" или выключить кнопки, в зависимости от действия.
        /// </summary>
        /// <param name="action"></param>
        private void Block(bool action)
        {
            foreach (Control item in layoutPanel.Controls)
            {
                if ((item as Button) != null) ((Button)item).Enabled = action;
            }
        }

        /// <summary>
        /// Извлекает карту, завершение работы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel_Click(object sender, EventArgs e)
        {
            CardReceiver.Enabled = true;
            CardReceiver.BackColor = SystemColors.Info;
            Block(false);
        }

        /// <summary>
        /// Запросить баланс по карте.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Balans_Click(object sender, EventArgs e) => card.GetBalans();

        /// <summary>
        /// Перейти в личный кабинет.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LK_Click(object sender, EventArgs e) => ATM.GetError("доступа в личный кабинет");

        /// <summary>
        /// Перейти в услуги банка.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Services_Click(object sender, EventArgs e) => ATM.GetError("получения перечня услуг банка");
    }
}
