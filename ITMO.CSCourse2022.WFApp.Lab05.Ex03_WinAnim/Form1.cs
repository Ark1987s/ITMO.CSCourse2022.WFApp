using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CSCourse2022.WFApp.Lab05.Ex03_WinAnim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnAW_BLEND_Click_1(object sender, EventArgs e)
        {
            // Скрываем окно
            this.Hide();
            // Запускаем анимацию. Второй параметр в скобках — время анимации в миллисекундах.
            AnimatedWindow.WinAPIClass.AnimateWindow(this, 3000, AnimatedWindow.WinAPIClass.AnimateWindowFlags.AW_ACTIVATE |
            AnimatedWindow.WinAPIClass.AnimateWindowFlags.AW_BLEND);
            // Отображаем кнопки после анимации
            this.btnAW_BLEND.Invalidate();
            this.btnHOR_AW_SLIDE.Invalidate();
            this.btnCenter_AW_SLIDE.Invalidate();
        }

        private void btnHOR_AW_SLIDE_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnimatedWindow.WinAPIClass.AnimateWindow(this, 3000, AnimatedWindow.WinAPIClass.AnimateWindowFlags.AW_HOR_POSITIVE |
            AnimatedWindow.WinAPIClass.AnimateWindowFlags.AW_SLIDE);
            this.btnAW_BLEND.Invalidate();
            this.btnHOR_AW_SLIDE.Invalidate();
            this.btnCenter_AW_SLIDE.Invalidate();
        }

        private void btnCenter_AW_SLIDE_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnimatedWindow.WinAPIClass.AnimateWindow(this, 3000, AnimatedWindow.WinAPIClass.AnimateWindowFlags.AW_CENTER |
            AnimatedWindow.WinAPIClass.AnimateWindowFlags.AW_SLIDE);
            this.btnAW_BLEND.Invalidate();
            this.btnHOR_AW_SLIDE.Invalidate();
            this.btnCenter_AW_SLIDE.Invalidate();
        }
    }
}
