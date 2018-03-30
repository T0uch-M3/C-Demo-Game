using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGame
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        Button[] allButton = new Button[6];
        int[] allPostion = new int[6];
        String[] content = {"+","+","*","*","=","="};
        public Form1()
        {
            InitializeComponent();
            //Random rdm = new Random();
            //System.Console.WriteLine(rdm.Next(0, 7));
            int i=0;
            foreach (Button btn in mtPanel.Controls.OfType<Button>())
            {

                btn.Text = generate();

                btn.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
                allButton[i] = btn;
                allPostion[i] = 0;
                i++;
                
            }
            
        }

        private String generate()
        {
            int x;
            String s = "";
            Boolean leave = false;
            Random rdm = new Random();
            do
            {
                x = rdm.Next(0, 6);
                if (content[x] != null)
                {
                    s = content[x];
                    content[x] = null;
                    leave = true;
                }
                    

            } while (leave==false);
            return s;
        }


        String[] tab = new string[2];//array of buttons for saving the last modified buttons, this will help more while trying to revert the color without changing all the button's color (YEY)
        Button[] btnArray = new Button[2];
        String[] btnHashCode = new String[2];//for saving buttons hash code, for preventing the use of the same button more than once
        System.Drawing.Color dark = System.Drawing.Color.FromArgb(255,64, 64, 64);
        System.Drawing.Color light = System.Drawing.Color.FromArgb(255,224,224,224);
        Boolean testStart = false;
        int count = 5;           //this for game start countdown
        int currentPos = 0;      //this for tracking how many button got pressed
        Boolean jackPot = true;  //tracking if a chain achieved 
        string temp;
        Boolean advance = true;
        int duplicate = 0;
        Boolean reset = false;

        //************note*************
        //try to randomize the button text (+ or =)



        private void change(object sender, EventArgs e)
        {

            reset = false;

            Button btn = (Button)sender;//cast to the wanted type of obj
            if (isDown(btn))
            {
                if (!isUp(btn))
                {
                    System.Console.WriteLine(btn.Text.ToString());

                    btnHashCode[currentPos] = sender.GetHashCode().ToString();
                    btnArray[currentPos] = btn;

                    System.Console.WriteLine("Hash code 0 = " + btnHashCode[0]);
                    System.Console.WriteLine("Hash code 1 = " + btnHashCode[1]);
                    //System.Console.WriteLine("Hash code 2 = " + btnHashCode[2]);

                    if (currentPos == 0)
                        tab[currentPos] = btn.Text.ToString();//get the btn text put it in an array
                    else
                        //if(currentPos>0)
                        for (int i = 0; i < currentPos; i++)
                        {
                            if (btnHashCode[i].Equals(sender.GetHashCode().ToString()))
                            {//will check if there's a button with the same hash code as the current pressing button, in the array, it should find just one, more is wrong
                                System.Console.WriteLine("ONE SPOTED");
                                duplicate++;
                                System.Console.WriteLine(duplicate.ToString());
                                advance = false;
                            }
                        }
                    if (advance == true)
                        tab[currentPos] = btn.Text.ToString();//get the btn text put it in an array
                    //****************************************************************
                    switch (currentPos)
                    {
                        case 0:
                            lab1.Text = btn.Text.ToString();
                            break;
                        case 1:
                            lab2.Text = btn.Text.ToString();
                            break;
                        case 2:
                            lab3.Text = btn.Text.ToString();
                            break;
                    }
                    //*****************************************************************
                    //currentPos++;//1 after pressing the first button, 2 after pressing the second ...
                    temp = tab[0];//assign the first spot for later comparisons 
                    if (currentPos > 0 && advance == true)
                    {
                        //System.Console.WriteLine("entered");
                        //******************************************************
                        for (int i = 0; i < currentPos + 1; i++)
                        {
                            //System.Console.WriteLine("nothing founded");
                            if (!temp.Equals(tab[i]))
                            {
                                jackPot = false;
                                System.Console.WriteLine("false");
                            }
                        }
                        //*****************************************************

                        //*****************************************************
                        if (jackPot == true)
                        {
                            saveButton(btnArray);
                            if (currentPos == 1)
                            {
                                labState.Text = "Good";
                                System.Console.WriteLine("reset");
                                reset = true;
                                //if (currentPos == 3 || currentPos == 2)
                                //{
                                tab = new string[2];//empty the array
                                btnArray = new Button[2];
                                btnHashCode = new String[2];
                                //}
                                currentPos = 0;//restart the button pressed counter to 0

                            }

                        }
                        //====================================================    
                        else
                        {
                            labState.Text = "Wrong";

                            System.Console.WriteLine("reset");
                            reset = true;
                            hide(btnArray);
                            //if (currentPos == 3 || currentPos == 2)
                            //{
                            tab = new string[2];
                            btnArray = new Button[2];
                            btnHashCode = new String[2];
                            //}

                            currentPos = 0;
                            jackPot = true;

                        }
                        //***************************************************
                    }

                    if (btn.ForeColor.Equals(light))//this for a single button, it change it's color with every click
                    {
                        //btn.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
                        //System.Console.WriteLine("to dark");
                        //btnHashCode = new string[3];
                    }
                    else//change to light
                    {
                        btn.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
                    }
                    //if (currentPos == 1){
                    //    currentPos = 0;
                    //    System.Console.WriteLine("current pos set to 0");
                    //}

                    //else
                    if (reset == false)
                    {
                        currentPos++;//1 after pressing the first button, 2 after pressing the second ...
                        System.Console.WriteLine("curent pot ++");
                    }
                }
            }
        }

        private void saveButton(Array ar)
        {
            for (int j = 0; j < btnArray.Length; j++)
            {
                for (int i = 0; i < allButton.Length; i++)
                {
                    if (btnArray[j].GetHashCode().Equals(allButton[i].GetHashCode()))
                    {
                        allPostion[i] = 1;
                        System.Console.WriteLine("found it fuck yeah");
                        System.Console.WriteLine(btnArray[j].GetHashCode());
                        System.Console.WriteLine(allButton[i].GetHashCode());
                        System.Console.WriteLine(i);
                    }
                }
            }
                
        }

        private Boolean isDown(Button bt)
        {
            for (int i = 0; i < allButton.Length; i++)
            {
                if (bt.GetHashCode().Equals(allButton[i].GetHashCode()))
                {
                    if (allPostion[i] == 0)
                        return true;
                }
            }
            return false;
        }

        private Boolean isUp(Button bt)
        {
            for (int i = 0; i < btnArray.Length ; i++){
                if (btnArray[i] != null)
                {
                    if (btnArray[i].GetHashCode().Equals(bt.GetHashCode()))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private void hide(Array ar)
        {
            Task.Delay(1000).ContinueWith(t =>
            {
                foreach (Button button in ar)//this will go through all the buttons in the group
                {
                    if(button!=null)
                    button.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);//hide them up
                }
            });
        }


        private void startGame(object sender, EventArgs e)
        {
            System.Console.WriteLine(labCounter.Text.ToString());
            
            startTimer.Start();
            if (testStart == false)
            {
                foreach (Button btn in mtPanel.Controls.OfType<Button>())
                {
                    btn.ForeColor = System.Drawing.Color.FromArgb(255, 224, 224, 224);//show them up
                    testStart = true;
                }
            }
        }
        


        private void quitGame(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }



        private void startTimer_Tick(object sender, EventArgs e)
        {
            System.Console.WriteLine("test with timer");
            count--;
            labCounter.Text = (count).ToString();
            if (count == 0)
            {
                startTimer.Stop();
                
                foreach (Button btn in mtPanel.Controls.OfType<Button>())
                {
                    btn.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);//hide them up
                    count = 5;
                    labCounter.Text = (count).ToString();
                    testStart = false;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Console.WriteLine("0" + " " + tab[0]);
            System.Console.WriteLine("1" + " " + tab[1]);
            if(tab.Length==2)
            //System.Console.WriteLine("2" + " " + tab[2]);
            System.Console.WriteLine("curreny pos" + " " + currentPos);
            System.Console.WriteLine("tab lengh " + tab.Length);
            System.Console.WriteLine("temp = "+temp );
            System.Console.WriteLine("Hash code 0 = " + btnHashCode[0]);
            System.Console.WriteLine("Hash code 1 = " + btnHashCode[1]);
            //System.Console.WriteLine("Hash code 2 = " + btnHashCode[2]);
            foreach(int i in allPostion)
                System.Console.WriteLine(allPostion[i]);
        }

    }
}
