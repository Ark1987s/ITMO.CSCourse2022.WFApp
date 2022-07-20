using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITMO.CSCourse2022.WFApp.Lab02.Ex09
{
    class Magazine : Item, IPubs
    {
        private String volume_mag;    // том
        private int number_mag;        // номер
        private String title_mag;       // название
        private int year_mag;      // дата выпуска
        private bool returnSrok_mag;

        public bool IfSubs { get; set; } // подписка на журнал

        public Magazine(String volume_mag, int number_mag, String title_mag, int year_mag, long invNumber_mag, bool taken_mag)
            : base(invNumber_mag, taken_mag)
        {
            this.volume_mag = volume_mag;
            this.number_mag = number_mag;
            this.title_mag = title_mag;
            this.year_mag = year_mag;
        }

        public void ReturnSrok_mag()
        {
            returnSrok_mag = true;
        }

        public override void Return()    // операция "вернуть"
       {
            if (returnSrok_mag == true)
                taken = true;
            else
                taken = false;
        }

        // реализация интерфейса

      

      public void Subs()
      {
          // действия при оформлении подписки на журнал
      }


       public override string ToString()
       {
           if (IfSubs)
           return "\nЖурнал:\n Название: " + title_mag + "\nТом: " + volume_mag +
           "\n Номер: " + number_mag + "\nГод выпуска: " + year_mag + "\n Подписка оформлена";
           else
               return "\nЖурнал:\n Название: " + title_mag + "\nТом: " + volume_mag +
           "\n Номер: " + number_mag + "\nГод выпуска: " + year_mag + "\n Подписка не оформлена"; ;
       }
    }
}
