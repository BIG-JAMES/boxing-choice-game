using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Media;

namespace boxing_choice_game
{
    public partial class Form1 : Form
    {
        int page = 1;
        SoundPlayer soundPlayer = new SoundPlayer();


        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 4;
            }
            else if(page == 5)
            {
                page = 8;
            }
            else if (page == 3)
            {
                page = 10;
            }
            else if (page == 4)
            {
                page = 6;
            }
            else if (page == 6)
            {
                page = 1;
            }
            else if (page == 11)
            {
                page = 15;
            }
            else if (page == 7)
            {
                page = 1;
            }
            else if (page == 8)
            {
                page = 1;
            }
            else if (page == 9)
            {
                page = 1;
            }
            else if (page == 12)
            {
                page = 1;
            }
            else if (page == 10)
            {
                page = 13;
            }
            else if (page == 13)
            {
                page = 1;
            }
            else if (page == 14)
            {
                page = 1;
            }
            else if (page == 15)
            {
                page = 1;
            }


            DisplayPage();
        }

        private void no_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 4)
            {
                page = 7;
            }
            else if (page == 10)
            {
                page = 12;
            }
            else if(page == 2)
            {
                page = 5;
            }
            else if(page == 5)
            {
                page = 9;
            }
            else if (page == 11)
            {
                page = 14;
            }
            else if (page == 3)
            {
                page = 11;
            }
            else if (page == 11)
            {
                page = 15;
            }
            else if (page == 6)
            {
                Refresh();
                Thread.Sleep(200);
                Application.Exit();
            }
            else if (page == 7)
            {
                Refresh();
                Thread.Sleep(200);
                Application.Exit();
            }
            else if (page == 8)
            {
                Refresh();
                Thread.Sleep(200);
                Application.Exit();
            }
            else if (page == 9)
            {
                Refresh();
                Thread.Sleep(200);
                Application.Exit();
            }
            else if (page == 12)
            {
                Refresh();
                Thread.Sleep(200);
                Application.Exit();
            }
            else if (page == 13)
            {
                Refresh();
                Thread.Sleep(200);
                Application.Exit();
            }
            else if (page == 14)
            {
                Refresh();
                Thread.Sleep(200);
                Application.Exit();
            }
            else if (page == 15)
            {
                Refresh();
                Thread.Sleep(200);
                Application.Exit();
            }

            DisplayPage();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        public void DisplayPage()
        {
            switch (page)
            {
                case 1:
                    pagetxt.Text = "the bell rings and your opponent is standing there your in a boxing ring";
                    picture.Image = Properties.Resources.mikey;
                    QandA.Text = "should you uppercut or right hook him?";
                    yes.Text = "uppercut";
                    no.Text = "right hook ";

                    break;

                case 2:
                    pagetxt.Text = "you uppercut him he falls down?";
                    picture.Image = Properties.Resources.upercut;
                    QandA.Text = "should you kick him while he down?";
                    yes.Text = "yes";
                    no.Text = "no";


                    soundPlayer = new SoundPlayer(Properties.Resources.Epic_Cinematic_Action_Trailer_Background_Music_No_Copyright_Intense_Teaser_Bgm___ezmp3_cc__);
                    soundPlayer.Play();
                    break;

                case 3:
                    pagetxt.Text = "right hook lands but it doesn't effect him";
                    picture.Image = Properties.Resources.hook;
                    QandA.Text = "continue punching or block?";
                    yes.Text = "block";
                    no.Text = "punching";
                    break;

                case 4:
                    pagetxt.Text = "you kick and stomp on him the ref tries to pull you away";
                    picture.Image = Properties.Resources.kick;
                    QandA.Text = "should you fight the ref yes or no?";
                    yes.Text = "yes";
                    no.Text = "no";
                    break;

                case 5:

                    yes.Enabled = false;
                    no.Enabled = false;

                    pagetxt.Text = "you wait for him to get up  the count starts";
                    picture.Image = Properties.Resources.down;
                    QandA.Text = " ";
                    yes.Text = " ";
                    no.Text = " ";
                    Refresh();
                    Thread.Sleep(2000);

                    pagetxt.Text = "1!";
                    Refresh();
                    Thread.Sleep(550);

                    pagetxt.Text = "2!";
                    Refresh();
                    Thread.Sleep(600);

                    pagetxt.Text = "3!";
                    Refresh();
                    Thread.Sleep(650);

                    pagetxt.Text = "4!";
                    Refresh();
                    Thread.Sleep(700);

                    pagetxt.Text = "5!";
                    Refresh();
                    Thread.Sleep(750);

                    yes.Enabled = true;
                    no.Enabled = true;

                    pagetxt.Text = "he gets back up";
                    picture.Image = Properties.Resources.mikey;
                    QandA.Text = "should you kick him while he down?";
                    yes.Text = "yes";
                    no.Text = "no";
                    break;

                case 6:
                    pagetxt.Text = "you decide to fight the ref you lose your boxing courier and die alone and sad. Thanks for playing!!!";
                    picture.Image = Properties.Resources.grave;
                    QandA.Text = "try again?";
                    yes.Text = "yes";
                    no.Text = "no";
                    break;

                case 7:
                    pagetxt.Text = "the ref tackles you and your courier end and you end up homeless and hated. Thanks for playing!!!";
                    picture.Text = "";
                    QandA.Text = "try again?";
                    yes.Text = "yes";
                    no.Text = "no";
                    break;

                case 8:
                    pagetxt.Text = "you continue the fight and win the championship and your life is happy your opponent never recovers and ends up in prison for running over people drunk killing 5. Thanks for playing!!!";
                    picture.Image = Properties.Resources.priz;
                    QandA.Text = "try again?";
                    yes.Text = "yes";
                    no.Text = "no";
                    break;

                case 9:
                    pagetxt.Text = "you give up and ends up living a normal life being friends with your opponent. Thanks for playing!!!";
                    picture.Image = Properties.Resources.happy;
                    QandA.Text = "try again?";
                    yes.Text = "yes";
                    no.Text = "no";
                    break;

                case 10:
                    pagetxt.Text = "you block as he punches as he loses his energy";
                    picture.Image = Properties.Resources.block;
                    QandA.Text = "should you fight back";
                    yes.Text = "yes";
                    no.Text = "no";
                    break;

                case 11:
                    pagetxt.Text = "you continue punching he doesn't look so good";
                    picture.Image = Properties.Resources.ededed;
                    QandA.Text = "should you tell the ref";
                    yes.Text = "yes";
                    no.Text = "no";
                    break;

                case 12:
                    pagetxt.Text = "you don't fight back and lose people think your a coward and you are hated for the rest of your life. Thanks for playing!!!";
                    picture.Image = Properties.Resources.downhill;
                    QandA.Visible = false;
                    QandA.Text = "try again?";
                    yes.Text = "yes";
                    no.Text = "no";
                    break;

                case 13:
                    pagetxt.Text = "you hit him in the side breaking his ribs and wining. Thanks for playing!!!";
                    picture.Image = Properties.Resources.win;
                    QandA.Text = "try again?";
                    yes.Text = "yes";
                    no.Text = "no";
                    break;

                case 14:
                    pagetxt.Text = "you knock him out seeing that he isn't going back up you dont find out untill years later but after that fight theft him in a vegetative state. Thanks for playing!!!";
                    picture.Image = Properties.Resources.weelend;
                    QandA.Text = "try again?";
                    yes.Text = "yes"; 
                    no.Text = "no";
                    break;

                case 15:
                    pagetxt.Text = "you tell the ref and he steps in you win and never see your opponent again. Thanks for playing!!!";
                    picture.Image = Properties.Resources.win;
                    QandA.Text = "try again?";
                    yes.Text = "yes";
                    no.Text = "no";
                    break;
            }
        }

        private void picture_Click(object sender, EventArgs e)
        {

        }
    }
}
