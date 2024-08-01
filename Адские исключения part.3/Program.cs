class Program
{
    static void Main()
    {
        try
        { 
            Console.Write("Здравствуйте. Мы поможем вам найти вашу квартиру! Введите количество этажей в home: "); // Определяем количество этажей в сарае
            int N = Convert.ToInt32(Console.ReadLine());
            if (N <= 0)
            {
                throw new Exception("Аа?");
            }

            Console.Write("Введите количество подъездов в home: "); // Определяем количество падиков
            int M = Convert.ToInt32(Console.ReadLine());
            if (M <= 0)
            {
                throw new Exception("Аа?");
            }


            Console.Write("Введите количество квартир на лестничной клетке: "); // Какое кол-во квартир на одну лестничную клетку. Т.к. это клетка, то вероятно они плодятся путём митоза
            int K = Convert.ToInt32(Console.ReadLine());
            if (K <= 0)
            {
                throw new Exception("Аа?");
            }


            Console.Write("Введите номер квартиры: "); // Пытаемся с будуна вспомнить номер квартиры
            int apartment = Convert.ToInt32(Console.ReadLine());
            if (apartment <= 0 || apartment > N * M * K) // Проверка на кол-во квартир на дом, а то если у вас 1 подъезд, 1 этаж и 3 квартиры на клетку, то как у вас будет в общей сложности стомиллионов комнат?
            {
                throw new Exception("Номер квартиры не найден. Кажется вы чот бубылдите");
            } 
            int entrance = (apartment - 1) / (N * K) + 1; // Вычисляем номер подъезда
            int floor = ((apartment - 1) % (N * K)) / K + 1; // Вычисляем номер этажа

            Console.WriteLine($"Квартира {apartment} находится в подъезде {entrance} на этаже {floor}"); // Квартира с будуна найдена! Поздравляю, вы не бездомный!
        }
        // С днём ошибок!
        catch (FormatException)
        {
            Console.WriteLine("Советую меньше выпивать, ибо ещё пару таких вводов данных и я буду жаловаться в соотвествующие органы =D");
        }
        catch (Exception ex) { Console.WriteLine($"Ошибка: {ex.Message}"); }
    }
}
