using System;
using System.Windows.Forms;

namespace ATM
{
    /// <summary>
    /// Класс для инкапсуляции сущности банкомата.
    /// </summary>
    public class ATM
    {
        /// <summary>
        /// Доступные средства в терминале.
        /// </summary>
        public int TotalSum { get; private set; }

        /// <summary>
        /// Сумма транзакции.
        /// </summary>
        public int SumTransaction { get; private set; }

        /// <summary>
        /// Конструктор терминала.
        /// </summary>
        public ATM()
        {
            TotalSum = 1000000;
            SumTransaction = 0;
        }
        
        /// <summary>
        /// Описание объекта.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format($"В терминале содержится сумма {TotalSum:C} рублей доступная для выдачи.");
        }

        /// <summary>
        /// Транзакция с денежными средствами.
        /// </summary>
        /// <param name="amount">Сумма транзакции.</param>
        /// <param name="action">True - списать, false - пополнить.</param>
        public void Transaction(int amount, bool action)
        {
            SumTransaction = amount;
            if (action) TotalSum -= SumTransaction;
            else TotalSum += SumTransaction;
        }

        /// <summary>
        /// Получить остаток по счету.
        /// </summary>
        public void GetState() => MessageBox.Show(ToString(), "ATM", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        /// <summary>
        /// Вывод ошибки в нерабочих модулях.
        /// </summary>
        /// <param name="opetation">Название операции.</param>
        public void GetError(string opetation) => MessageBox.Show($"Произошел технический сбой по операции {opetation}.", "ATM", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    /// <summary>
    /// Банковская карта клиента.
    /// </summary>
    public struct Card
    {
        /// <summary>
        /// Уникальный номер карты.
        /// </summary>
        private Guid CardID { get; set; }
        /// <summary>
        /// Сумма на карте.
        /// </summary>
        public int Summa { get; private set; }

        /// <summary>
        /// Сумма транзакции для банкомата.
        /// </summary>
        public int spisanie { get; private set; }
        /// <summary>
        /// Флаг проведения транзакции.
        /// </summary>
        public bool IsRemoval { get; private set; }

        /// <summary>
        /// Номинал для снятия.
        /// </summary>
        public enum Nominal { Сто = 100, Пятьсот = 500, Тысяча = 1000, Две_тысячи = 2000, Пять_тысяч = 5000, none }

        /// <summary>
        /// Конструктор карты.
        /// </summary>
        /// <param name="ID">Имитация номера карты.</param>
        public Card(Guid ID)
        {
            CardID = ID;
            Summa = 100000;
            IsRemoval = false;
            spisanie = 0;
        }

        /// <summary>
        /// Карта всталена в терминал.
        /// </summary>
        /// <param name="sender"></param>
        public void InsertCard(object sender)
        {
            PictureBox card = sender as PictureBox;
            if (card != null)
            {
                card.Enabled = false;
                card.BackColor = ProfessionalColors.ButtonSelectedGradientEnd;
            }
            MessageBox.Show($"Ваша карта № {CardID} готова к работе.", "ATM", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        /// <summary>
        /// Пополнение счета на карте.
        /// </summary>
        /// <param name="discont">Сумма внесения.</param>
        public void AddMomey(int discont)
        {
            Summa += discont;
            IsRemoval = false;
        }

        /// <summary>
        /// Снятие налички.
        /// </summary>
        /// <param name="nominal">Типовой номинал.</param>
        /// <param name="bidsummma">Сумма, заданная вручную.</param>
        public void RemovalMoney(Nominal nominal, int bidsummma = 0)
        {
            int money = 0;
            spisanie = 0;
            IsRemoval = false;

            if (bidsummma == 0)
            {
                money = (int)nominal;
                if (Result(money) & bidsummma == 0)
                {
                    switch (money)
                    {
                        case 100:
                            Summa -= 100;
                            break;
                        case 500:
                            Summa -= 500;
                            break;
                        case 1000:
                            Summa -= 1000;
                            break;
                        case 5000:
                            Summa -= 5000;
                            break;
                    }
                    IsRemoval = true;
                    spisanie = money;
                }
                else
                {
                    MessageBox.Show($"Недостаточно средств для совершения операции.\nНе хватает {(money - Summa):C}.", "ATM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (bidsummma > 0)
            {
                if (Result(bidsummma))
                {
                    Summa -= bidsummma;
                    IsRemoval = true;
                    spisanie = bidsummma;
                }
                else MessageBox.Show($"Недостаточно средств для совершения операции.\nНе хватает {(bidsummma - Summa):C}.", "ATM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Проверка, чтобы не уйти в овердрафт.
        /// </summary>
        /// <param name="sum">Cумма снятия с карты.</param>
        /// <returns></returns>
        private bool Result(decimal sum)
        {
            if ((Summa - sum) >= 0) return true;
            else return false;
        }

        /// <summary>
        /// Получить баланс по карте.
        /// </summary>
        public void GetBalans() => MessageBox.Show(string.Format($"Остаток на счете {Summa:C}."), "ATM", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
}
