using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace soril2_1
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=ADMIN\\SQLEXPRESS; Initial Catalog=Shagai; Integrated Security=True;";
        int remainingDice = 2025;
        bool isPlayer1Turn = true;
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            StartGame();
        }

        private void StartGame()
        {
            remainingDice = 30;
            isPlayer1Turn = true;
            txtLog.Clear();
            Log("Тоглоом эхэллээ. Эхний шоо авалт...");
            PlayerMove(1); // 1-р тоглогч үргэлж 1 шоо авна
        }

        private void PlayerMove(int numDice)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            if (remainingDice <= 0) return;

            remainingDice -= numDice;
            Log($"1-р тоглогч {numDice} шоо авлаа. Үлдсэн: {remainingDice}");

            CheckForWin();
            string query = "Insert Into ShagaiGame (playerName, taken, [left]) values (@playerName, @taken, @left)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@playerName", "1-r toglogch");
            cmd.Parameters.AddWithValue("@taken", numDice);
            cmd.Parameters.AddWithValue("left", remainingDice);
            cmd.ExecuteNonQuery();
            con.Close();
            if (remainingDice > 0)
            {
                isPlayer1Turn = false;
                UpdateUI();
                ComputerMove();
            }
        }

        private void ComputerMove()
        {
            int maxTake = Math.Min(7, remainingDice);
            int compTake = rand.Next(1, maxTake + 1);

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            remainingDice -= compTake;
            Log($"2-р тоглогч {compTake} шоо авлаа. Үлдсэн: {remainingDice}");

            string query = "Insert Into ShagaiGame (playerName, taken, [left]) values (@playerName, @taken, @left)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@playerName", "2-r toglogch");
            cmd.Parameters.AddWithValue("@taken", compTake);
            cmd.Parameters.AddWithValue("left", remainingDice);
            cmd.ExecuteNonQuery();
            con.Close();

            if (remainingDice > 7)
            {
                richTextBox1.Text = $"8 - {compTake} = {8 - compTake}";
            }
            else
            {
                richTextBox1.Text = $"{compTake}";
            }

            CheckForWin();

            if (remainingDice > 0)
            {
                isPlayer1Turn = true;
                UpdateUI();
            }
        }


        private void CheckForWin()
        {
            if (remainingDice <= 0)
            {
                string winner = isPlayer1Turn ? "1-р тоглогч" : "2-р тоглогч";
                Log($"{winner} хожлоо!");
                DisableButtons();
            }
        }

        private void UpdateUI()
        {
            lblRemainingDice.Text = $"Үлдсэн шоо: {remainingDice}";
            lblTurn.Text = isPlayer1Turn ? "1-р тоглогчийн ээлж" : "2-р тоглогчийн ээлж";
        }

        private void Log(string message)
        {
            txtLog.AppendText(message + Environment.NewLine);
        }



        private void DisableButtons()
        {
            btnTake1.Enabled = false;
            btnTake2.Enabled = false;
            btnTake3.Enabled = false;
            btnTake4.Enabled = false;
            btnTake5.Enabled = false;
            btnTake6.Enabled = false;
            btnTake7.Enabled = false;
        }

        private void EnableButtons()
        {
            btnTake1.Enabled = true;
            btnTake2.Enabled = true;
            btnTake3.Enabled = true;
            btnTake4.Enabled = true;
            btnTake5.Enabled = true;
            btnTake6.Enabled = true;
            btnTake7.Enabled = true;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            EnableButtons();
            StartGame();
        }

        private void btnTake1_Click(object sender, EventArgs e) => PlayerMove(1);
        private void btnTake2_Click(object sender, EventArgs e) => PlayerMove(2);
        private void btnTake3_Click(object sender, EventArgs e) => PlayerMove(3);
        private void btnTake4_Click(object sender, EventArgs e) => PlayerMove(4);
        private void btnTake5_Click(object sender, EventArgs e) => PlayerMove(5);
        private void btnTake6_Click(object sender, EventArgs e) => PlayerMove(6);
        private void btnTake7_Click(object sender, EventArgs e) => PlayerMove(7);

        private void lblRemainingDice_Click(object sender, EventArgs e) { }
        private void lblTurn_Click(object sender, EventArgs e) { }
        private void btnTake_Click(object sender, EventArgs e) { }
        private void txtLog_TextChanged(object sender, EventArgs e) { }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

    
  
}
