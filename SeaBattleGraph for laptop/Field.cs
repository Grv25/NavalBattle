namespace SeaBattleGraph_for_laptop
{
    internal class Field
    {
        public int x;  // столбцы
        public int y;  // строки
        public int status;  // 0 - пусто, 1 - корабль, 2 - бито, 3 - подбит корабль.

        public Field(int x, int y, int status = 0)  // Конструктор.
        {
            this.x = x;
            this.y = y;
            this.status = status;
        }
    }
}