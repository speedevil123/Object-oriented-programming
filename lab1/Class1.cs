using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Var 21

namespace lab1
{
    public class Class1
    {
        static bool isRightFirtsLetter(string ish, string s)
        {
            string letter = s.Substring(0, 1);
            if (ish == letter)
                return false;
            else return true;
        }

        static void Main()
        {
            Console.Write("Введите букву для удаления начинающихся с неё строк: ");
            string ishod = Console.ReadLine();

            string input = "В данном примере count выполняет роль переменной управления циклом.\n" +
                "В инициализирующей части оператора цикла for задается нулевое значение этой переменной.\n" +
                "В начале каждого шага цикла, включая и первый, проверяется условие count < 5.\n" +
                "Если эта проверка дает истинный результат, то выполняется оператор, содержащий метод WriteLine().\n" +
                "Далее выполняется часть оператора цикла for,где значение переменной count увеличивается на 1.\n" +
                "Этот процесс повторяется до тех пор, пока значение переменной count не достигнет величины 5.\n" +
                "Если в данном коде значение переменной значение переменной h = 12, то это отлично.";
            string[] mas = input.Split(new[] { "\n" }, StringSplitOptions.None);

            mas = mas.Where(val => isRightFirtsLetter(ishod,val)).ToArray();
            input = string.Join("\n", mas);
            Console.WriteLine(input);
        }
    }
}
