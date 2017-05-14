using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KT
{
    
    public partial class Form1 : Form
    {
        /**************************** Vars ****************************/
        List<Button> btns = new List<Button>();
        int[] visited = new int[65];
        int clickedbtn = -1, cnt = 0, prevbtn;
        List<int> solution;
        /**************************** Function ****************************/
        //Get Position (row & col)
        int getRow(int pos)
        {
            int row = (int)Math.Ceiling(pos / 8.0);
            return row;
        }
        int getCol(int pos)
        {
            int col = pos;
            while (col > 8)
            {
                col -= 8;
            }
            return col;
        }
        string setw(int x){
            if (x < 10) return string.Format("0" + x);
            return x.ToString();
        }
        /*
         * Move
         * 
         * UpRight
         * UpLeft
         * DownRight
         * DownLeft
         * RightDown
         * RightUp
         * LeftDown
         * LeftUp
         */
        int UpRight(int pos)
        {
            int newpos;
            int col = getCol(pos) + 1;
            int row = getRow(pos) - 3;
            if (col > 8 || row < 0) return -1;
            newpos = (row * 8) + col;
            return newpos;
        }
        int UpLeft(int pos)
        {
            int newpos;
            int col = getCol(pos) - 1;
            int row = getRow(pos) - 3;
            
            newpos = (row * 8) + col;
            if (col < 0 || row < 0 || getCol(newpos) > getCol(pos) || getRow(newpos) > getRow(pos)) return -1;
            return newpos;
        }
        int DownLeft(int pos)
        {
            int newpos;
            int col = getCol(pos) - 1;
            int row = getRow(pos) + 1;

            if (!((col > 0 && col <= 8) && (row > 0 && row <= 8))) return -1;

            newpos = (row * 8) + col;

            return newpos;
        }
        int DownRight(int pos)
        {
            int newpos;
            int col = getCol(pos) + 1;
            int row = getRow(pos) + 1;
            if (!((col > 0 && col <= 8) && (row > 0 && row <= 8))) return -1;
            newpos = (row * 8) + col;
            return newpos;
        }
        int RightDown(int pos)
        {
            int newpos;
            int col = getCol(pos) + 2;
            int row = getRow(pos);
            if (col > 8 || row >= 8) return -1;
            newpos = (row * 8) + col;
            return newpos;
        }
        int RightUp(int pos)
        {
            int newpos;
            int col = getCol(pos) + 2;
            int row = getRow(pos) - 2;
            if (col > 8 || row >= 8) return -1;
            newpos = (row * 8) + col;
            return newpos;
        }
        int LeftUp(int pos)
        {
            int newpos;
            int col = getCol(pos) - 2;
            int row = getRow(pos) - 2;
            if (col <= 0 || row < 0) return -1;
            newpos = (row * 8) + col;
            return newpos;
        }
        int LeftDown(int pos)
        {
            int newpos;
            int col = getCol(pos) - 2;
            int row = getRow(pos);
            if (col <= 0 || row >= 8) return -1;
            newpos = (row * 8) + col;
            return newpos;
        }
        //Adding Buttons to List
        void init()
        {
            btns.Add(button1);
            btns.Add(button2);
            btns.Add(button3);
            btns.Add(button4);
            btns.Add(button5);
            btns.Add(button6);
            btns.Add(button7);
            btns.Add(button8);
            btns.Add(button9);
            btns.Add(button10);
            btns.Add(button11);
            btns.Add(button12);
            btns.Add(button13);
            btns.Add(button14);
            btns.Add(button15);
            btns.Add(button16);
            btns.Add(button17);
            btns.Add(button18);
            btns.Add(button19);
            btns.Add(button20);
            btns.Add(button21);
            btns.Add(button22);
            btns.Add(button23);
            btns.Add(button24);
            btns.Add(button25);
            btns.Add(button26);
            btns.Add(button27);
            btns.Add(button28);
            btns.Add(button29);
            btns.Add(button30);
            btns.Add(button31);
            btns.Add(button32);
            btns.Add(button33);
            btns.Add(button34);
            btns.Add(button35);
            btns.Add(button36);
            btns.Add(button37);
            btns.Add(button38);
            btns.Add(button39);
            btns.Add(button40);
            btns.Add(button41);
            btns.Add(button42);
            btns.Add(button43);
            btns.Add(button44);
            btns.Add(button45);
            btns.Add(button46);
            btns.Add(button47);
            btns.Add(button48);
            btns.Add(button49);
            btns.Add(button50);
            btns.Add(button51);
            btns.Add(button52);
            btns.Add(button53);
            btns.Add(button54);
            btns.Add(button55);
            btns.Add(button56);
            btns.Add(button57);
            btns.Add(button58);
            btns.Add(button59);
            btns.Add(button60);
            btns.Add(button61);
            btns.Add(button62);
            btns.Add(button63);
            btns.Add(button64);
        }
        //initial board coloring
        void coloring()
        {
            for (int i = 0; i < btns.Count; i++)
            {
                btns[i].Text = (i + 1).ToString();
                btns[i].TabIndex = 110;
                int colum = (int)(i / 8.0);
                if (colum % 2 == 1)
                {
                    if (i % 2 == 1) btns[i].BackColor = Color.White;
                    else btns[i].BackColor = Color.LightGray;
                }
                else if (colum % 2 == 0)
                {
                    if (i % 2 == 0) btns[i].BackColor = Color.White;
                    else btns[i].BackColor = Color.LightGray;
                }
            }
        }
        //Highlighting certain position
        void highlight(int pos)
        {
            /*
             * Green  : Current position
             * Red    : visited position
             * Violet : position you can visit (allowed move)
             * Purple : visited position that can be visited again (visited && allowed move)
             */
            enableBtns();
            int UR = UpRight(pos);
            int UL = UpLeft(pos);
            int DR = DownLeft(pos);
            int DL = DownRight(pos);
            int RD = RightDown(pos);
            int RU = RightUp(pos);
            int LD = LeftUp(pos);
            int LU = LeftDown(pos);
            for (int i = 1; i <= btns.Count; i++)
            {
                if (visited[i] == 1) btns[i - 1].BackColor = Color.Red;
                if (i == UR || i == UL || i == DR || i == DL || i == RD || i == RU || i == LD || i == LU)
                {
                    if (visited[i] == 1) btns[i - 1].BackColor = Color.Purple;
                    else btns[i - 1].BackColor = Color.Violet;
                }
                else
                {
                    btns[i-1].Enabled = false;
                }
                if (i == clickedbtn) btns[i - 1].BackColor = Color.Green;
            }
        }
        void highlight(int pos, bool t)
        {
            for (int i = 1; i <= btns.Count; i++)
            {
                if (visited[i] == 1) btns[i - 1].BackColor = Color.Red;
                if (i == clickedbtn) btns[i - 1].BackColor = Color.Green;
            }
        }
        //Remove unnecessary Highlighting
        void remmoveHighlight()
        {
            for (int i = 0; i < btns.Count; i++)
            {
                int colum = (int)(i / 8.0);
                if (colum % 2 == 1 && btns[i].BackColor != Color.Red)
                {
                    if (i % 2 == 1) btns[i].BackColor = Color.White;
                    else btns[i].BackColor = Color.LightGray;
                }
                else if (colum % 2 == 0 && btns[i].BackColor != Color.Red)
                {
                    if (i % 2 == 0) btns[i].BackColor = Color.White;
                    else btns[i].BackColor = Color.LightGray;
                }
            }
        }
        //Enable All buttons after each move
        void enableBtns()
        {
            for (int i = 0; i < btns.Count; i++)
                btns[i].Enabled = true;
        }
        //check win 
        bool checkWin()
        {
            for (int i = 1; i < visited.Length; i++)
                if(visited[i] != 1) return false;
            return true;
        }



        void Clicked(Object sender, EventArgs e)
        {
            //Get Button name
            Button clickedButton = (Button)sender;
            int i = int.Parse(clickedButton.Text);

            //Mark as visited
            visited[i] = 1;

            prevbtn = clickedbtn;
            clickedbtn = i;

            //Update moves Count
            cnt++;

            //Remove All Prevous Highlighted Buttons
            remmoveHighlight();

            //Highlight the current Button
            highlight(i);

            //Update lbl_log with moves Count && Log rtb1 with latest move
            lbl_log.Text = "Moves Count = " + cnt;
            if (cnt > 1)
                rtb1.Text = setw(prevbtn) + " ==> " + setw(clickedbtn) + "\n" + rtb1.Text;

            //Check if WIN OR EXCEEDED 64 move count
            if (checkWin())
                MessageBox.Show("Congratulations, YOU WIN");
            else if (cnt > 64)
                MessageBox.Show("LOSER, Try Again");

            //Once Any button clicked Disable Auto Generate && Simulate Buttons
            btn_gen.Enabled = false;
            btn_sim.Enabled = false;
        }

        public Form1()
        {
            InitializeComponent();
            init();
            coloring();
            rtb1.Text = "";
            lbl_log.Text = "Moves Count = 0";
            btn_gen.Enabled = true;
            btn_sim.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < btns.Count; i++)
            {
                btns[i].Click += new EventHandler(Clicked);
            }
            
        }

        private void button65_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_gen_Click(object sender, EventArgs e)
        {
            btn_gen.Enabled = false;
            UninformedSearch search = new UninformedSearch();
            search.IDS(58, 64, 1);
            solution = search.GetFinalSolution();
            btn_gen.Enabled = false;
            btn_sim.Enabled = true;
            MessageBox.Show("Alright Alright Alright! Ready for Simulation");
        }

        private void btn_sim_Click(object sender, EventArgs e)
        {
            rtb1.Text = "";
            for (int i = 0, cnt = 0 ; i < solution.Count; i++, cnt++)
            {
                visited[solution[i]] = 1;

                remmoveHighlight();

                if (cnt > 1)
                    rtb1.Text = setw(solution[i-1]) + " ==> " + setw(solution[i]) + "\n" + rtb1.Text;
                lbl_log.Text = "Moves Count = " + cnt;

                System.Threading.Thread.Sleep(1000);

                highlight(solution[i]);
            }
            btn_sim.Enabled = false;
        }
    }
}
