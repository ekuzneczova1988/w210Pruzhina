using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace w210Pruzhina
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string temppruzh = "";
        string tempprostavka = "";
        private void refrash()
        {
            int front = 0;
            int rear = 0;
            
            if (comboBoxTipoRyad.Text == "210.003")
            {
                front = 33;
                rear = 20;
            }
            if (comboBoxTipoRyad.Text == "210.004")
            {
                front = 33;
                rear = 20;
            }
            if (comboBoxTipoRyad.Text == "210.006")
            {
                front = 56;
                rear = 23;
            }
            if (comboBoxTipoRyad.Text == "210.007")
            {
                front = 56;
                rear = 23;
            }
            if (comboBoxTipoRyad.Text == "210.010")
            {
                front = 43;
                rear = 20;
            }
            if (comboBoxTipoRyad.Text == "210.015")
            {
                front = 43;
                rear = 20;
            }
            if (comboBoxTipoRyad.Text == "210.017")
            {
                front = 48;
                rear = 23;
            }
            if (comboBoxTipoRyad.Text == "210.020")
            {
                front = 53;
                rear = 23;
            }
            if (comboBoxTipoRyad.Text == "210.025")
            {
                front = 63;
                rear = 28;
            }
            if (comboBoxTipoRyad.Text == "210.035")
            {
                front = 26;
                rear = 18;
            }
            if (comboBoxTipoRyad.Text == "210.037")
            {
                front = 28;
                rear = 18;
            }
            if (comboBoxTipoRyad.Text == "210.045")
            {
                front = 38;
                rear = 23;
            }
            if (comboBoxTipoRyad.Text == "210.053")
            {
                front = 45;
                rear = 28;
            }
            if (comboBoxTipoRyad.Text == "210.055")
            {
                front = 48;
                rear = 26;
            }
            if (comboBoxTipoRyad.Text == "210.061")
            {
                front = 28;
                rear = 25;
            }
            if (comboBoxTipoRyad.Text == "210.063")
            {
                front = 38;
                rear = 30;
            }
            if (comboBoxTipoRyad.Text == "210.065")
            {
                front = 40;
                rear = 33;
            }
            if (comboBoxTipoRyad.Text == "210.070")
            {
                front = 55;
                rear = 38;
            }
            if (comboBoxTipoRyad.Text == "210.072")
            {
                front = 70;
                rear = 33;
            }
            if (comboBoxTipoRyad.Text == "210.072 E50AMG")
            {
                front = 85;
                rear = 38;
            }
            if (comboBoxTipoRyad.Text == "210.074 E55AMG")
            {
                front = 78;
                rear = 33;
            }
            if (comboBoxTipoRyad.Text == "210.081")
            {
                front = 0;
                rear = 30;
            }
            if (comboBoxTipoRyad.Text == "210.082")
            {
                front = 0;
                rear = 33;
            }
            ///////////////////////////////////////////////////
            /// Таблица 2
            /// 
            if (comboBoxTipoRyad2.Text == "210.006")
            {
                front = 59;
                rear = 28;
            }
            if (comboBoxTipoRyad2.Text == "210.007")
            {
                front = 59;
                rear = 28;
            }
            if (comboBoxTipoRyad2.Text == "210.016")
            {
                front = 70;
                rear = 31;
            }
            if (comboBoxTipoRyad2.Text == "210.026")
            {
                front = 77;
                rear = 28;
            }
            if (comboBoxTipoRyad2.Text == "210.035")
            {
                front = 43;
                rear = 23;
            }
            if (comboBoxTipoRyad2.Text == "210.045")
            {
                front = 54;
                rear = 23;
            }
            if (comboBoxTipoRyad2.Text == "210.048")
            {
                front = 51;
                rear = 33;
            }
            if (comboBoxTipoRyad2.Text == "210.061")
            {
                front = 36;
                rear = 25;
            }
            if (comboBoxTipoRyad2.Text == "210.062")
            {
                front = 61;
                rear = 36;
            }
            if (comboBoxTipoRyad2.Text == "210.063")
            {
                front = 42;
                rear = 30;
            }
            if (comboBoxTipoRyad2.Text == "210.065")
            {
                front = 51;
                rear = 33;
            }
            if (comboBoxTipoRyad2.Text == "210.070")
            {
                front = 55;
                rear = 28;
            }
            if (comboBoxTipoRyad2.Text == "210.074")
            {
                front = 78;
                rear = 33;
            }
            if (comboBoxTipoRyad2.Text == "210.081")
            {
                front = 59;
                rear = 36;
            }
            if (comboBoxTipoRyad2.Text == "210.082")
            {
                front = 64;
                rear = 36;
            }
            if (comboBoxTipoRyad2.Text == "210.083")
            {
                front = 85;
                rear = 40;
            }
            ///////////////////////////////////////////////
            if (checkBoxKlimatPolozh.Checked)
            {
                front = front + 8;
                rear = rear + 0;
            }
            if (checkBoxAvtomat5.Checked)
            {
                front = front + 4;
                rear = rear + 2;
            }
            if (checkBoxAvtomat4.Checked)
            {
                front = front + 3;
                rear = rear + 1;
            }
            if (checkBoxADS.Checked)
            {
                front = front + 3;
                rear = rear + 3;
            }
            if (checkBoxLuk.Checked)
            {
                front = front + 3;
                rear = rear + 3;
            }
            if (checkBoxTaxi.Checked)
            {
                front = front + 3;
                rear = rear + 3;
            }
            if (checkBoxDopOtopl.Checked)
            {
                front = front + 2;
                rear = rear + 0;
            }
            if (checkBoxTaxyTrevoga.Checked)
            {
                front = front + 2;
                rear = rear + 1;
            }
            if (checkBoxZaschita.Checked)
            {
                front = front + 1;
                rear = rear + 0;
            }
            if (checkBoxProtivbuks.Checked)
            {
                front = front + 1;
                rear = rear + 0;
            }
            if (checkBoxESP.Checked)
            {
                front = front + 1;
                rear = rear + 0;
            }
            if (checkBoxRegulirUr.Checked)
            {
                front = front + 1;
                rear = rear + 1;
            }
            if (checkBoxAudio.Checked)
            {
                front = front + 1;
                rear = rear + 1;
            }
            if (checkBoxSidVodEl.Checked)
            {
                front = front + 1;
                rear = rear + 1;
            }
            if (checkBoxPamyat.Checked)
            {
                front = front + 1;
                rear = rear + 1;
            }
            if (checkBoxFaroOch.Checked)
            {
                front = front + 1;
                rear = rear + 0;
            }
            if (checkBoxTel.Checked)
            {
                front = front + 1;
                rear = rear + 1;
            }
            if (checkBoxOgnetush.Checked)
            {
                front = front + 1;
                rear = rear + 0;
            }
            if (checkBoxTyagovo.Checked)
            {
                front = front + 0;
                rear = rear + 3;
            }
            if (checkBoxAKB.Checked)
            {
                front = front + 0;
                rear = rear + 2;
            }
            if (checkBoxDetskSid.Checked)
            {
                front = front + 0;
                rear = rear + 2;
            }
            if (checkBoxCD.Checked)
            {
                front = front + 0;
                rear = rear + 1;
            }
            if (checkBoxShtorka.Checked)
            {
                front = front + 0;
                rear = rear + 1;
            }
            /////////////////////////////////////////////////////////////////
            ///////////////////////////////////
            ///////////////////////////////////
            textBoxProstavka.Text = "";
            textBoxProstavkaZhest.Text = "";
            textBoxPruzh.Text = "";
            textBoxPruzhZhest.Text = "";
            textBoxProstavkaZad.Text = "";
            textBoxProstavkaZhestZad.Text = "";
            textBoxPruzhZad.Text = "";
            textBoxPruzhZhestZad.Text = "";
            // Первая таблица перед нормальная
            ///////////////////////////
            if (front < 30)
                SetFront(1);
            if (front > 31 & front < 34)
                SetFront(2);
            if (front > 35 & front < 38)
                SetFront(3);
            if (front > 35 & front < 38)
                SetFront(4);
            if (front > 39 & front < 42)
                SetFront(5);
            if (front > 43 & front < 44)
                SetFront(6);
            if (front > 45 & front < 49)
                SetFront(7);
            if (front > 50 & front < 54)
                SetFront(8);
            if (front > 55 & front < 59)
                SetFront(9);
            if (front > 60 & front < 64)
                SetFront(10);
            if (front > 65 & front < 66)
                SetFront(11);
            if (front > 67 & front < 72)
                SetFront(12);
            if (front > 73 & front < 77)
                SetFront(13);
            if (front > 78 & front < 83)
                SetFront(14);
            if (front > 84 & front < 88)
                SetFront(15);
            if (front > 89 & front < 91)
                SetFront(16);
            if (front > 92 & front < 97)
                SetFront(17);
            if (front > 98 & front < 103)
                SetFront(18);
            if (front > 104 & front < 109)
                SetFront(19);
            if (front > 110)
                SetFront(20);
            textBoxPruzh.Text = temppruzh;
            textBoxProstavka.Text = tempprostavka;
            // Первая таблица перед жесть
            ///////////////////////////
            if (front < 25)
                SetFront(2);
            if (front > 26 & front < 29)
                SetFront(3);
            if (front > 26 & front < 29)
                SetFront(4);
            if (front > 30 & front < 33)
                SetFront(5);
            if (front > 34 & front < 35)
                SetFront(6);
            if (front > 36 & front < 39)
                SetFront(7);
            if (front > 40 & front < 44)
                SetFront(8);
            if (front > 45 & front < 49)
                SetFront(9);
            if (front > 50 & front < 54)
                SetFront(10);
            if (front > 54 & front < 55)
                SetFront(11);
            if (front > 56 & front < 61)
                SetFront(12);
            if (front > 62 & front < 66)
                SetFront(13);
            if (front > 67 & front < 72)
                SetFront(14);
            if (front > 73 & front < 77)
                SetFront(15);
            if (front > 77 & front < 78)
                SetFront(16);
            if (front > 79 & front < 84)
                SetFront(17);
            if (front > 85 & front < 90)
                SetFront(18);
            if (front > 91 & front < 97)
                SetFront(19);
            if (front > 98)
                SetFront(20);
            textBoxPruzhZhest.Text = temppruzh;
            textBoxProstavkaZhest.Text = tempprostavka;
            ////////////////////Если авангард
            if (checkBoxAvangard.Checked || checkBoxAvangardDemp.Checked)
            {
                if (front < 37)
                    SetFront(21);
                if (front > 37 & front < 43)
                    SetFront(22);
                if (front > 44 & front < 49)
                    SetFront(23);
                if (front > 50 & front < 55)
                    SetFront(24);
                if (front > 56 & front < 61)
                    SetFront(25);
                if (front > 62 & front < 68)
                    SetFront(26);
                if (front > 69 & front < 74)
                    SetFront(27);
                if (front > 75 & front < 81)
                    SetFront(28);
                if (front > 82 & front < 88)
                    SetFront(29);
                if (front > 89 & front < 96)
                    SetFront(30);
                if (front > 97 & front < 104)
                    SetFront(31);
                if (front > 105 & front < 111)
                    SetFront(32);
                if (front > 112)
                    SetFront(33);
                textBoxPruzh.Text = temppruzh;
                textBoxProstavka.Text = tempprostavka;
                textBoxPruzhZhest.Text = "НЕТ";
                textBoxProstavkaZhest.Text = "НЕТ";
            }
            ////////////////// Если 4matic
            ////////////////////Если авангард
            if (comboBoxTipoRyad2.SelectedIndex != -1)
            if (checkBox4matic.Checked)
            {
                if (front < 97)
                    SetFront(34);
                if (front > 98 & front < 103)
                    SetFront(35);
                if (front > 104 & front < 110)
                    SetFront(36);
                if (front > 111)
                    SetFront(37);
                textBoxPruzh.Text = temppruzh;
                textBoxProstavka.Text = tempprostavka;
                textBoxPruzhZhest.Text = "НЕТ";
                textBoxProstavkaZhest.Text = "НЕТ";
            }
            ///////////////////////////////////////
            ///////////////////////////////////////
            ///////////////////////////////////////
            //Zad
            if (rear < 21)
                SetRear(1);
            if (rear > 22 & rear < 27)
                SetRear(2);
            if (rear > 28 & rear < 34)
                SetRear(3);
            if (rear > 35 & rear < 40)
                SetRear(4);
            if (rear > 41 & rear < 47)
                SetRear(5);
            if (rear > 48 & rear < 54)
                SetRear(6);
            if (rear > 55 & rear < 60)
                SetRear(7);
            if (rear > 61)
                SetRear(8);
            textBoxPruzhZad.Text = temppruzh;
            textBoxProstavkaZad.Text = tempprostavka;
            ////////////zad zhest
            if (rear < 18)
                SetRear(5);
            if (rear > 19 & rear < 25)
                SetRear(6);
            if (rear > 26 & rear < 32)
                SetRear(7);
            if (rear > 33 & rear < 39)
                SetRear(8);
            if (rear > 40 & rear < 42)
                SetRear(9);
            if (rear > 43 & rear < 50)
                SetRear(10);
            if (rear > 51 & rear < 57)
                SetRear(11);
            if (rear > 58)
                SetRear(12);
            textBoxPruzhZhestZad.Text = temppruzh;
            textBoxProstavkaZhestZad.Text = tempprostavka;
            //////////////////regur
            if (checkBoxRegulirUr.Checked)
            {
                if (rear < 19)
                    SetRear(13);
                if (rear > 20 & rear < 25)
                    SetRear(14);
                if (rear > 26 & rear < 31)
                    SetRear(15);
                if (rear > 32 & rear < 37)
                    SetRear(16);
                if (rear > 38 & rear < 44)
                    SetRear(17);
                if (rear > 45 & rear < 50)
                    SetRear(18);
                if (rear > 51 & rear < 57)
                    SetRear(19);
                if (rear > 58)
                    SetRear(20);
                textBoxPruzhZad.Text = temppruzh;
                textBoxProstavkaZad.Text = tempprostavka;
                textBoxPruzhZhestZad.Text = "НЕТ";
                textBoxProstavkaZhestZad.Text = "НЕТ";
            }
            //////////////////avangard
            if (checkBoxAvangard.Checked)
            {
                if (rear < 20)
                    SetRear(21);
                if (rear > 21 & rear < 27)
                    SetRear(22);
                if (rear > 28 & rear < 35)
                    SetRear(23);
                if (rear > 36 & rear < 42)
                    SetRear(24);
                if (rear > 43 & rear < 50)
                    SetRear(25);
                if (rear > 51 & rear < 58)
                    SetRear(26);
                if (rear > 59 & rear < 66)
                    SetRear(27);
                if (rear > 67)
                    SetRear(28);
                textBoxPruzhZad.Text = temppruzh;
                textBoxProstavkaZad.Text = tempprostavka;
                textBoxPruzhZhestZad.Text = "НЕТ";
                textBoxProstavkaZhestZad.Text = "НЕТ";
            }
            //////////////////avangard demfer
            if (checkBoxAvangardDemp.Checked)
            {
                if (rear < 20)
                    SetRear(29);
                if (rear > 21 & rear < 27)
                    SetRear(30);
                if (rear > 28 & rear < 35)
                    SetRear(31);
                if (rear > 36)
                    SetRear(32);
                textBoxPruzhZad.Text = temppruzh;
                textBoxProstavkaZad.Text = tempprostavka;
                textBoxPruzhZhestZad.Text = "НЕТ";
                textBoxProstavkaZhestZad.Text = "НЕТ";
            }

        }
        private void comboBoxTipoRyad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTipoRyad.SelectedIndex == -1)
                return;
            comboBoxTipoRyad2.SelectedIndex = -1;
            refrash();
        }
        // index по таблице, начиная с 1 первая таблица норм, жесткая, вторая табл и тд
        private void SetFront(int index)
        {
            switch (index)
            {
                case 1:
                    temppruzh = "2103212804";
                    tempprostavka = "2103210284";
                    break;
                case 2:
                    temppruzh = "2103212804";
                    tempprostavka = "2103210384";
                    break;
                case 3:
                    temppruzh = "2103212804";
                    tempprostavka = "2103210484";
                    break;
                case 4:
                    temppruzh = "2103212804";
                    tempprostavka = "2103210484";
                    break;
                case 5:
                    temppruzh = "2103212804";
                    tempprostavka = "2103210584";
                    break;
                case 6:
                    temppruzh = "2103212904";
                    tempprostavka = "2103210184";
                    break;
                case 7:
                    temppruzh = "2103212904";
                    tempprostavka = "2103210284";
                    break;
                case 8:
                    temppruzh = "2103212904";
                    tempprostavka = "2103210384";
                    break;
                case 9:
                    temppruzh = "2103212904";
                    tempprostavka = "2103210484";
                    break;
                case 10:
                    temppruzh = "2103212904";
                    tempprostavka = "2103210584";
                    break;
                case 11:
                    temppruzh = "2103213004";
                    tempprostavka = "2103210184";
                    break;
                case 12:
                    temppruzh = "2103213004";
                    tempprostavka = "2103210284";
                    break;
                case 13:
                    temppruzh = "2103213004";
                    tempprostavka = "2103210384";
                    break;
                case 14:
                    temppruzh = "2103213004";
                    tempprostavka = "2103210484";
                    break;
                case 15:
                    temppruzh = "2103213004";
                    tempprostavka = "2103210584";
                    break;
                case 16:
                    temppruzh = "2103213104";
                    tempprostavka = "2103210184";
                    break;
                case 17:
                    temppruzh = "2103213104";
                    tempprostavka = "2103210284";
                    break;
                case 18:
                    temppruzh = "2103213104";
                    tempprostavka = "2103210384";
                    break;
                case 19:
                    temppruzh = "2103213104";
                    tempprostavka = "2103210484";
                    break;
                case 20:
                    temppruzh = "2103213104";
                    tempprostavka = "2103210584";
                    break;
                /////////avangard////////////////////////////////
                case 21:
                    temppruzh = "2103211604";
                    tempprostavka = "2103210184";
                    break;
                case 22:
                    temppruzh = "2103211604";
                    tempprostavka = "2103210284";
                    break;
                case 23:
                    temppruzh = "2103211604";
                    tempprostavka = "2103210384";
                    break;
                case 24:
                    temppruzh = "2103211604";
                    tempprostavka = "2103210484";
                    break;
                case 25:
                    temppruzh = "2103211604";
                    tempprostavka = "2103210584";
                    break;
                case 26:
                    temppruzh = "2103212104";
                    tempprostavka = "2103210284";
                    break;
                case 27:
                    temppruzh = "2103212104";
                    tempprostavka = "2103210384";
                    break;
                case 28:
                    temppruzh = "2103212104";
                    tempprostavka = "2103210484";
                    break;
                case 29:
                    temppruzh = "2103212104";
                    tempprostavka = "2103210584";
                    break;
                case 30:
                    temppruzh = "2103212204";
                    tempprostavka = "2103210284";
                    break;
                case 31:
                    temppruzh = "2103212204";
                    tempprostavka = "2103210384";
                    break;
                case 32:
                    temppruzh = "2103212204";
                    tempprostavka = "2103210484";
                    break;
                case 33:
                    temppruzh = "2103212204";
                    tempprostavka = "2103210584";
                    break;
                //////////////////////////////////////////
                case 34:
                    temppruzh = "2103213504";
                    tempprostavka = "2103210184";
                    break;
                case 35:
                    temppruzh = "2103213504";
                    tempprostavka = "2103210284";
                    break;
                case 36:
                    temppruzh = "2103213304";
                    tempprostavka = "2103210284";
                    break;
                case 37:
                    temppruzh = "2103213304";
                    tempprostavka = "2103210384";
                    break;
            }
        }
        // index по таблице, начиная с 1 первая таблица норм, жесткая, вторая табл и тд
        private void SetRear(int index)
        {
            switch (index)
            {
                case 1:
                    temppruzh = "2103243204";
                    tempprostavka = "2103250184";
                    break;
                case 2:
                    temppruzh = "2103243204";
                    tempprostavka = "2103250284";
                    break;
                case 3:
                    temppruzh = "2103243204";
                    tempprostavka = "2103250384";
                    break;
                case 4:
                    temppruzh = "2103243204";
                    tempprostavka = "2103250484";
                    break;
                case 5:
                    temppruzh = "2103243304";
                    tempprostavka = "2103250184";
                    break;
                case 6:
                    temppruzh = "2103243304";
                    tempprostavka = "2103250284";
                    break;
                case 7:
                    temppruzh = "2103243304";
                    tempprostavka = "2103250384";
                    break;
                case 8:
                    temppruzh = "2103243304";
                    tempprostavka = "2103250484";
                    break;
                case 9:
                    temppruzh = "2103241804";
                    tempprostavka = "2103250184";
                    break;
                case 10:
                    temppruzh = "2103241804";
                    tempprostavka = "2103250284";
                    break;
                case 11:
                    temppruzh = "2103241804";
                    tempprostavka = "2103250384";
                    break;
                case 12:
                    temppruzh = "2103241804";
                    tempprostavka = "2103250484";
                    break;
                ///////////////////////////////////
                case 13:
                    temppruzh = "2103243104";
                    tempprostavka = "2103250184";
                    break;
                case 14:
                    temppruzh = "2103243104";
                    tempprostavka = "2103250284";
                    break;
                case 15:
                    temppruzh = "2103243104";
                    tempprostavka = "2103250384";
                    break;
                case 16:
                    temppruzh = "2103243104";
                    tempprostavka = "2103250484";
                    break;
                case 17:
                    temppruzh = "2103241704";
                    tempprostavka = "2103250184";
                    break;
                case 18:
                    temppruzh = "2103241704";
                    tempprostavka = "2103250284";
                    break;
                case 19:
                    temppruzh = "2103241704";
                    tempprostavka = "2103250384";
                    break;
                case 20:
                    temppruzh = "2103241704";
                    tempprostavka = "2103250484";
                    break;
                /////////////////////////////////////////
                case 21:
                    temppruzh = "2103243404";
                    tempprostavka = "2103250184";
                    break;
                case 22:
                    temppruzh = "2103243404";
                    tempprostavka = "2103250284";
                    break;
                case 23:
                    temppruzh = "2103243404";
                    tempprostavka = "2103250384";
                    break;
                case 24:
                    temppruzh = "2103243404";
                    tempprostavka = "2103250484";
                    break;
                case 25:
                    temppruzh = "2103243604";
                    tempprostavka = "2103250184";
                    break;
                case 26:
                    temppruzh = "2103243604";
                    tempprostavka = "2103250284";
                    break;
                case 27:
                    temppruzh = "2103243604";
                    tempprostavka = "2103250384";
                    break;
                case 28:
                    temppruzh = "2103243604";
                    tempprostavka = "2103250484";
                    break;
                ///////////////////////////
                case 29:
                    temppruzh = "2103241704";
                    tempprostavka = "2103250184";
                    break;
                case 30:
                    temppruzh = "2103241704";
                    tempprostavka = "2103250284";
                    break;
                case 31:
                    temppruzh = "2103241704";
                    tempprostavka = "2103250384";
                    break;
                case 32:
                    temppruzh = "2103241704";
                    tempprostavka = "2103250484";
                    break;
            }
        }

        private void checkBoxKlimatPolozh_CheckedChanged(object sender, EventArgs e)
        {
            refrash();
        }

        private void checkBoxAvtomat5_CheckedChanged(object sender, EventArgs e)
        {
            refrash();
        }

        private void textBoxPruzh_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.autodoc.ru/Web/price/art/A" + textBoxPruzh.Text);
        }

        private void textBoxProstavka_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.autodoc.ru/Web/price/art/A" + textBoxProstavka.Text);
        }

        private void textBoxPruzhZhest_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.autodoc.ru/Web/price/art/A" + textBoxPruzhZhest.Text);
        }

        private void textBoxProstavkaZhest_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.autodoc.ru/Web/price/art/A" + textBoxProstavkaZhest.Text);
        }

        private void textBoxPruzhZad_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.autodoc.ru/Web/price/art/A" + textBoxPruzhZad.Text);
        }

        private void textBoxProstavkaZad_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.autodoc.ru/Web/price/art/A" + textBoxProstavkaZad.Text);
        }

        private void textBoxPruzhZhestZad_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.autodoc.ru/Web/price/art/A" + textBoxPruzhZhestZad.Text);
        }

        private void textBoxProstavkaZhestZad_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.autodoc.ru/Web/price/art/A" + textBoxProstavkaZhestZad.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void comboBoxTipoRyad2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTipoRyad2.SelectedIndex == -1)
                return;
            comboBoxTipoRyad.SelectedIndex = -1;
            refrash();
        }

        private void checkBox4matic_CheckedChanged(object sender, EventArgs e)
        {
            refrash();
        }
    }
}
