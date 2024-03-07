using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack_TWO_Solution
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           
            this.pnlPlayerRound.Visible = false;
            this.pnlDealerRound.Visible = false;
            this.pnlPlayerField.Visible = false;
            this.pnlDealerField.Visible = false;
            this.btnHit.Visible = false;
            this.btnStay.Visible = false;


            this.lblDealCardScoreTxt.Text = "0";
            this.lblPlayCardScoreTxt.Text = "0";
            this.lblDealRoundScr.Text = "0";
            this.lblPlayRoundScr.Text = "0";


            this.mnuFileReset.Enabled = false;
            this.btnHit.Enabled = false;
            this.btnStay.Enabled = false;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnNewMatch_Click(object sender, EventArgs e)
        {
            Initialize();
        }

        private void mnuFileNew_Click(object sender, EventArgs e)
        {
            Initialize();
        }

        private void mnuFileReset_Click(object sender, EventArgs e)
        {

        }

        private void btnHit_Click(object sender, EventArgs e)
        {

        }

        private void btnStay_Click(object sender, EventArgs e)
        {

        }



        public void Initialize()
        {
            this.btnNewMatch.Enabled = false;
            this.btnNewMatch.Visible = false;

            this.mnuFileReset.Enabled = true;
            this.btnHit.Enabled = true;
            this.btnStay.Enabled = true;
        }

        public void Deck()
        {
            string[] Deck = new string[52];

            Deck[0] = "A1";
            Deck[1] = "A2";
            Deck[2] = "A3";
            Deck[3] = "A4";
            Deck[4] = "A5";
            Deck[5] = "A6";
            Deck[6] = "A7";
            Deck[7] = "A8";
            Deck[8] = "A9";
            Deck[9] = "A10";
            Deck[10] = "A11";
            Deck[11] = "A12";
            Deck[12] = "A13";
            Deck[13] = "B1";
            Deck[14] = "B2";
            Deck[15] = "B3";
            Deck[16] = "B4";
            Deck[17] = "B5";
            Deck[18] = "B6";
            Deck[19] = "B7";
            Deck[20] = "B8";
            Deck[21] = "B9";
            Deck[22] = "B10";
            Deck[23] = "B11";
            Deck[24] = "B12";
            Deck[25] = "B13";
            Deck[26] = "C1";
            Deck[27] = "C2";
            Deck[28] = "C3";
            Deck[29] = "C4";
            Deck[30] = "C5";
            Deck[31] = "C6";
            Deck[32] = "C7";
            Deck[33] = "C8";
            Deck[34] = "C9";
            Deck[35] = "C10";
            Deck[36] = "C11";
            Deck[37] = "C12";
            Deck[38] = "C13";
            Deck[39] = "D1";
            Deck[40] = "D2";
            Deck[41] = "D3";
            Deck[42] = "D4";
            Deck[43] = "D5";
            Deck[44] = "D6";
            Deck[45] = "D7";
            Deck[46] = "D8";
            Deck[47] = "D9";
            Deck[48] = "D10";
            Deck[49] = "D11";
            Deck[50] = "D12";
            Deck[51] = "D13";
        }

        public void Shuffle()
        {
            Deck();


        }
    }
}
