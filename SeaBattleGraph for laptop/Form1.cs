using System.Windows.Forms;
using SeaBattleGraph_for_laptop.Properties;
using System;
using System.Drawing;

namespace SeaBattleGraph_for_laptop
{
    public partial class Form1 : Form
    {
        bool IsChoosingYourShips = true;  // Расставляем ли мы сейчас свои корабли? (начало игры)
        int QuantityBuiltShips = 0;  // Счетчик твоих уже установленных кораблей.
        int ShipCoordinates;  // Номер клетки, где находится корабль.
        int TargetCoordinates;  // Поле, по которому стреляем.
        int BreakEnemyShips = 0;  // Количество подбитых вражеских кораблей.
        int BreakYourShips = 0;   // Количество подбитых врагом твоих кораблей.  
        Random rand = new Random();

        Field[] ArrayEnemyFields = new Field[100];  // Объявляем массив клеточек поля боя для вражьих кораблей.
        Field[] ArrayYourFields = new Field[100];  // Объявляем массив клеточек поля боя для своих кораблей.


        public Form1()
        {
            InitializeComponent();

            CreateFields(ArrayEnemyFields);  // Прописываем клеточкам вражьего поля координаты.
            CreateFields(ArrayYourFields);  // Прописываем клеточкам своего поля координаты.
            CreateEnemyShips(ArrayEnemyFields);  // Прописываем каждому вражьему кораблю координаты.
        }


        void CreateFields(Field[] ArrayFields)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    ArrayFields[Convert.ToInt32($"{i}{j}")] = new Field(i, j);
                }
            }
        }


        void CreateEnemyShips(Field[] ArrayFields)
        {
            int i = 0;
            while (i < 10)
            {
                Random rand = new Random();
                ShipCoordinates = rand.Next(0, 100);  // Корабль выбирает для себя конкретную клеточку.

                if (ArrayFields[ShipCoordinates].status == 0)
                {
                    ArrayFields[ShipCoordinates].status = 1;
                    i++;
                }
            }
        }


        private void PictureYourField_MouseClick(object sender, MouseEventArgs e)  // Чтобы установить свои корабли.
        {
            int x = (e.X - 1) / 50;  // столбцы
            int y = (e.Y - 1) / 50;  // строки

            label1.Text = $"{x}{y}";

            if (IsChoosingYourShips == true)  // Режим выбора координат своих кораблей.
            {
                ShipCoordinates = Convert.ToInt32($"{x}{y}");
                if (ArrayYourFields[ShipCoordinates].status == 0)
                {
                    ArrayYourFields[ShipCoordinates].status = 1; 

                    PictureBox pic = new PictureBox();  // Графическая составляющая установки кораблей.
                    this.Controls.Add(pic);
                    pic.Width = 49;
                    pic.Height = 49;
                    pic.Location = new Point(PictureYourField.Location.X + x * 50 + 1, PictureYourField.Location.Y + y * 50 + 1);
                    pic.BringToFront();
                    pic.Image = Resources.Ship;

                    QuantityBuiltShips++;
                }
                if (QuantityBuiltShips == 10)
                {
                    IsChoosingYourShips = false;
                    label4.Text = "Выбери поле, по которому стреляем";
                }
            }
        }


        private void PictureEnemyField_MouseClick(object sender, MouseEventArgs e)  // Стреляем по вражьим кораблям.
        {
            int x = (e.X - 1) / 50;  // столбцы
            int y = (e.Y - 1) / 50;  // строки

            label1.Text = $"{x}{y}";

            if (IsChoosingYourShips == false)
            {
                TargetCoordinates = Convert.ToInt32($"{x}{y}");

                switch (ArrayEnemyFields[TargetCoordinates].status)
                {
                    case 0:
                        ArrayEnemyFields[TargetCoordinates].status = 2;
                        Console.WriteLine("Мимо");

                        PictureBox pic4 = new PictureBox();  // Графическая составляющая - добавляем картинку "Мимо".
                        this.Controls.Add(pic4);
                        pic4.Width = 49;
                        pic4.Height = 49;
                        pic4.Location = new Point(PictureEnemyField.Location.X + x * 50 + 1, PictureEnemyField.Location.Y + y * 50 + 1);
                        pic4.BringToFront();
                        pic4.Image = Resources.Strike;

                        EnemyStrike();

                        break;

                    case 1:
                        ArrayEnemyFields[TargetCoordinates].status = 3;
                        Console.WriteLine("Подбили корабль!");

                        PictureBox pic3 = new PictureBox();  // Графическая составляющая - добавляем картинку "Подбит корабль".
                        this.Controls.Add(pic3);
                        pic3.Width = 49;
                        pic3.Height = 49;
                        pic3.Location = new Point(PictureEnemyField.Location.X + x * 50 + 1, PictureEnemyField.Location.Y + y * 50 + 1);
                        pic3.BringToFront();
                        pic3.Image = Resources.FireShip;

                        BreakEnemyShips += 1;
                        Win();
                        break;

                    default:
                        Console.WriteLine("Уже стреляли туда");
                        break;
                }
            }
        }


        void EnemyStrike()  // Удар противника...
        {
            TargetCoordinates = rand.Next(0, 100);
            string ZeroBegin = "";  // Нужно, чтобы в числах меньше 10 в начале был ноль.
            if (TargetCoordinates < 10) { ZeroBegin = "0"; }

            switch (ArrayYourFields[TargetCoordinates].status)
            {
                case 0:
                    ArrayYourFields[TargetCoordinates].status = 2;
                    Console.WriteLine($"Противник: {ZeroBegin}{TargetCoordinates} - Мимо");

                    PictureBox pic5 = new PictureBox();  // Графическая составляющая - добавляем картинку "Мимо".
                    this.Controls.Add(pic5);
                    pic5.Width = 49;
                    pic5.Height = 49;
                    int PictureLocationX = PictureYourField.Location.X + Convert.ToInt32($"{ZeroBegin}{TargetCoordinates}".Substring(0, 1)) * 50 + 1;
                    int PictureLocationY = PictureYourField.Location.Y + Convert.ToInt32($"{ZeroBegin}{TargetCoordinates}".Substring(1)) * 50 + 1;
                    pic5.Location = new Point(PictureLocationX, PictureLocationY);
                    pic5.BringToFront();
                    pic5.Image = Resources.Strike;

                    break;

                case 1:
                    ArrayYourFields[TargetCoordinates].status = 3;
                    Console.WriteLine($"Противник: {ZeroBegin}{TargetCoordinates} - Подбит ваш корабль!");

                    PictureBox pic2 = new PictureBox();  // Графическая составляющая - добавляем картинку "Подбит корабль".
                    this.Controls.Add(pic2);
                    pic2.Width = 49;
                    pic2.Height = 49;
                    int PictureLocationX2 = PictureYourField.Location.X + Convert.ToInt32($"{ZeroBegin}{TargetCoordinates}".Substring(0, 1)) * 50 + 1;
                    int PictureLocationY2 = PictureYourField.Location.Y + Convert.ToInt32($"{ZeroBegin}{TargetCoordinates}".Substring(1)) * 50 + 1;
                    pic2.Location = new Point(PictureLocationX2, PictureLocationY2);
                    pic2.BringToFront();
                    pic2.Image = Resources.FireShip;

                    BreakYourShips += 1;
                    Win();
                    if (BreakYourShips < 10) { EnemyStrike(); }
                    break;

                default:
                    EnemyStrike();
                    break;
            }
        }


        void Win()  // Проверка выигрыша кого-либо.
        {
            if (BreakEnemyShips == 10)   ///10
            {
                label4.Text = "Все корабли противника подбиты. Вы победили!";
                PictureEnemyField.Enabled = false;
            }

            if (BreakYourShips == 10)   ///10
            {
                label4.Text = "Все ваши корабли подбиты. Вы проиграли.";
                PictureEnemyField.Enabled = false;
            }
        }
    }
}