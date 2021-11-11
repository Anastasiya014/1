using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
	public class Class1
	{
		/// <summary>
		////расчёт функции 
		/// </summary>
		/// <param name="k"></param>
		/// <param name="str">строка с генерирированнными числами</param>
		/// <param name="raznost">разность</param>
		/// <param name="kol">количество</param>
		public static void Start(int k, out string str, out int raznost, out int kol)
		{
			int zn = 0; // число
			str = ""; // строка с генерирированнными числами
			raznost = 0; //Разность
			kol = 0; //Количество
			Random rnd = new Random();
			
				while (raznost > k)
				{
					//диапазон от 2 до 10 
					zn = rnd.Next(2, 10);
					kol++; //увеличиваем счетчик
					raznost = raznost - zn; //вычисление разности
					str += Convert.ToString(zn) + "  "; //заполнение строки с геннерированными числами
				}
			
			
		}
	}
}
