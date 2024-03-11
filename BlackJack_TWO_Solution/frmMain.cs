using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack_TWO_Solution
{
    public partial class frmMain : Form
    {
        #region /*Global Variables*/
        
        private string _face;
        private string _P = "Player";
        private string _D = "Dealer";
        private int _score = 0;
        private int _PhandIndex;
        private int _DhandIndex;
        private int Wins;
        private int Loss;

        #endregion

        public frmMain()
        {
            InitializeComponent();
        }

        #region /*Game Start Up*/
        // Build game board layout at beginnign of the game
        private void frmMain_Load(object sender, EventArgs e)
        {

            pnlPlayerRound.Visible = false;
            pnlDealerRound.Visible = false;
            pnlPlayerField.Visible = false;
            pnlDealerField.Visible = false;
            btnHit.Visible = false;
            btnStay.Visible = false;


            lblDealCardScoreTxt.Text = "0";
            lblPlayCardScoreTxt.Text = "0";
            lblDealRoundScr.Text = "0";
            lblPlayRoundScr.Text = "0";


            mnuFileReset.Enabled = false;
            mnuFileNew.Enabled = false;
            btnHit.Enabled = false;
            btnStay.Enabled = false;
        }
        #endregion

        #region /*Game Interactions*/
        //Builds new match on click of startup button
        private void btnNewMatch_Click(object sender, EventArgs e)
        {
            lblDealCardScoreTxt.Text = "0";
            lblPlayCardScoreTxt.Text = "0";

            Initialize();

            shuffleArray();

            dealHand(_P);
            dealHand(_D);

            btnHit.Enabled = true;
            btnHit.BackColor = Color.Teal;

            btnStay.Enabled = true;
            btnStay.BackColor = Color.Teal;
        }

        //Builds new match on click of file menu selection
        private void mnuFileNew_Click(object sender, EventArgs e)
        {
            lblDealCardScoreTxt.Text = "0";
            lblPlayCardScoreTxt.Text = "0";

            lblDealerName.Text = "Dealer";
            lblPlayerName.Text = "Player";


            clearHand(_P);
            clearHand(_D);

            Initialize();

            shuffleArray();

            dealHand(_P);
            dealHand(_D);

            btnHit.Enabled = true;
            btnHit.BackColor = Color.Teal;

            btnStay.Enabled = true;
            btnStay.BackColor = Color.Teal;
        }

        //Resets game on click of file menu selection
        private void mnuFileReset_Click(object sender, EventArgs e)
        {
            lblDealRoundScr.Text = "0";
            lblPlayRoundScr.Text = "0";

            lblDealCardScoreTxt.Text = "0";
            lblPlayCardScoreTxt.Text = "0";

            lblDealerName.Text = "Dealer";
            lblDealerName.ForeColor = Color.Black;

            lblPlayerName.Text = "Player";
            lblPlayerName.ForeColor = Color.Black;


            clearHand(_P);
            clearHand(_D);

            Initialize();

            shuffleArray();

            dealHand(_P);
            dealHand(_D);

            btnHit.Enabled = true;
            btnHit.BackColor = Color.Teal;

            btnStay.Enabled = true;
            btnStay.BackColor = Color.Teal;
        }

        //Adds card to player's hand if card score is under 21
        private void btnHit_Click(object sender, EventArgs e)
        {
            if (int.Parse(lblPlayCardScoreTxt.Text) < 21 && lbxPHand.Items.Count <= 4)
            {
                
                buildHand(_P, ref _score);


            }
            
            if (int.Parse(lblPlayCardScoreTxt.Text) == 21)
            {
                btnHit.Enabled = false;
                btnHit.BackColor = Color.DarkSlateGray;
            }

            if (int.Parse(lblPlayCardScoreTxt.Text) > 21)
            {
                btnHit.Enabled = false;
                btnHit.BackColor = Color.DarkSlateGray;

                btnStay.Enabled = false;
                btnStay.BackColor = Color.DarkSlateGray;

                lblPlayerName.Text = "BUST!!";
                lblPlayerName.ForeColor = Color.Red;

                lblPDeclaration.Visible = true;
                lblPDeclaration.Text = "LOSS";
                lblPDeclaration.ForeColor = Color.Red;

                lblDDeclaration.Visible = true;
                lblDDeclaration.Text = "WIN";
                lblDDeclaration.ForeColor = Color.Green;

                Loss++;
                lblDealRoundScr.Text = Loss.ToString(); //Add bust Lable to either field
            }
            


        }

        //Adds cards the dealer's hand if card score is under 21
        private void btnStay_Click(object sender, EventArgs e)
        {
            btnStay.Enabled = false;
            btnStay.BackColor= Color.DarkSlateGray;

            do
            {
                if (int.Parse(lblDealCardScoreTxt.Text) <= 21 &&
                    int.Parse(lblDealCardScoreTxt.Text) < int.Parse(lblPlayCardScoreTxt.Text))
                {
                    buildHand(_D, ref _score);
                    
                    if (int.Parse(lblPlayCardScoreTxt.Text) <= 21 && int.Parse(lblDealCardScoreTxt.Text) > 21)
                    {
                        lblDealerName.Text = "BUST!!";
                        lblDealerName.ForeColor = Color.Red;

                        btnHit.Enabled = false;
                        btnHit.BackColor = Color.DarkSlateGray;

                        lblPDeclaration.Visible = true;
                        lblPDeclaration.Text = "WIN";
                        lblPDeclaration.ForeColor = Color.Green;

                        lblDDeclaration.Visible = true;
                        lblDDeclaration.Text = "LOSS";
                        lblDDeclaration.ForeColor = Color.Red; ;

                        Wins++;
                        lblPlayRoundScr.Text = Wins.ToString();
                        return;
                    }
                    else if (int.Parse(lblPlayCardScoreTxt.Text) < 21 &&
                             int.Parse(lblDealCardScoreTxt.Text) < 21 &&
                             int.Parse(lblPlayCardScoreTxt.Text) > int.Parse(lblDealCardScoreTxt.Text) &&
                             lbxDHand.Items.Count == 5)
                    {
                        btnHit.Enabled = false;
                        btnHit.BackColor = Color.DarkSlateGray;

                        lblPDeclaration.Visible = true;
                        lblPDeclaration.Text = "WIN";
                        lblPDeclaration.ForeColor = Color.Green;

                        lblDDeclaration.Visible = true;
                        lblDDeclaration.Text = "LOSS";
                        lblDDeclaration.ForeColor = Color.Red;

                        Wins++;
                        lblPlayRoundScr.Text = Wins.ToString();
                        return;
                    }
                    else if (int.Parse(lblPlayCardScoreTxt.Text) < 21 &&
                             int.Parse(lblDealCardScoreTxt.Text) < 21 &&
                             int.Parse(lblDealCardScoreTxt.Text) > int.Parse(lblPlayCardScoreTxt.Text) &&
                             lbxDHand.Items.Count == 5)
                    {
                        btnHit.Enabled = false;
                        btnHit.BackColor = Color.DarkSlateGray;

                        lblPDeclaration.Visible = true;
                        lblPDeclaration.Text = "LOSS";
                        lblPDeclaration.ForeColor = Color.Red;

                        lblDDeclaration.Visible = true;
                        lblDDeclaration.Text = "WIN";
                        lblDDeclaration.ForeColor = Color.Green;

                        Loss++;
                        lblDealRoundScr.Text = Loss.ToString();
                        return;
                    }
                    else if (lbxPHand.Items.Count == 5 &&
                             int.Parse(lblPlayCardScoreTxt.Text) <= 21 &&
                             int.Parse(lblPlayCardScoreTxt.Text) > int.Parse(lblDealCardScoreTxt.Text) &&
                             lbxDHand.Items.Count == 5)
                    {
                        btnHit.Enabled = false;
                        btnHit.BackColor = Color.DarkSlateGray;

                        btnStay.Enabled = false;
                        btnStay.BackColor = Color.DarkSlateGray;

                        lblPDeclaration.Visible = true;
                        lblPDeclaration.Text = "WIN";
                        lblPDeclaration.ForeColor = Color.Green;

                        lblDDeclaration.Visible = true;
                        lblDDeclaration.Text = "LOSS";
                        lblDDeclaration.ForeColor = Color.Red;

                        Wins++;
                        lblPlayRoundScr.Text = Wins.ToString();
                    } 
                }

                if (int.Parse(lblDealCardScoreTxt.Text) > int.Parse(lblPlayCardScoreTxt.Text))
                {
                    btnHit.Enabled = false;
                    btnHit.BackColor = Color.DarkSlateGray;

                    lblPDeclaration.Visible = true;
                    lblPDeclaration.Text = "LOSS";
                    lblPDeclaration.ForeColor = Color.Red;

                    lblDDeclaration.Visible = true;
                    lblDDeclaration.Text = "WIN";
                    lblDDeclaration.ForeColor = Color.Green;

                    Loss++;
                    lblDealRoundScr.Text = Loss.ToString();
                    return;
                }


            } while (lbxDHand.Items.Count <= 5);

        }

        //Exits application
        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region /*Game Building*/

        //Builds fields and brings buttons into view
        public void Initialize()
        {
            _PhandIndex = 0;
            _DhandIndex = 0;

            btnNewMatch.Enabled = false;
            btnNewMatch.Visible = false;

            lblPDeclaration.Visible = false;
            lblDDeclaration.Visible = false;

            mnuFileReset.Enabled = true;
            mnuFileNew.Enabled = true; ;
            btnHit.Enabled = true;
            btnStay.Enabled = true;

            pnlPlayerRound.Visible = true;
            pnlDealerRound.Visible = true;
            pnlPlayerField.Visible = true;
            pnlDealerField.Visible = true;
            btnHit.Visible = true;
            btnStay.Visible = true;
        }

        //Shuffle the deck
        public void shuffleArray()
        {
            ListBox.ObjectCollection list = lbxDeck.Items;
            Random rng = new Random();
            int n = list.Count;

            lbxDeck.BeginUpdate();
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                object value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            lbxDeck.EndUpdate();
            lbxDeck.Invalidate();
        }

        //Deals Cards to hands
        public void dealHand(string a)
        {
            if (a == "Player")
            {
                do
                {                    
                    if (lbxPHand.Items.Count == 0 || _PhandIndex < 2)
                    {                        
                        buildHand(_P, ref _score);
                        _PhandIndex++;
                    }

                } while (_PhandIndex < 2);
            }

            if (a == "Dealer")
            {
                do
                {                    
                    if (lbxDHand.Items.Count == 0 || _DhandIndex < 2)
                    {                        
                        buildHand(_D, ref _score);
                        _DhandIndex++;
                    }
                } while (_DhandIndex < 2);
            }

            if (int.Parse(lblPlayCardScoreTxt.Text) == 21)
            {
                string first = lbxPHand.Items[0].ToString();
                string second = lbxPHand.Items[1].ToString();

                btnHit.Enabled = false;
                btnHit.BackColor = Color.DarkSlateGray;

                if (first.Contains("11") && second.Contains("AJ") ||
                    first.Contains("AJ") && second.Contains("11") ||
                    first.Contains("CJ") && second.Contains("11") ||
                    first.Contains("11") && second.Contains("CJ"))
                {
                    btnStay.Enabled = false;
                    btnStay.BackColor = Color.DarkSlateGray;

                    lblPDeclaration.Visible = true;
                    lblPDeclaration.Text = "WIN";
                    lblPDeclaration.ForeColor = Color.Green;

                    lblPDeclaration.Visible = true;
                    lblDDeclaration.Text = "LOSS";
                    lblDDeclaration.ForeColor = Color.Red;

                    Wins++;
                    lblPlayRoundScr.Text = Wins.ToString();
                }
            }

            //if (int.Parse(lblPlayCardScoreTxt.Text) > 11 && lbxPHand.Items.Count <= 4)
            //{

            //    for (int i = 0; i <= lbxPHand.Items.Count; i++)
            //    {
            //        string temp = lbxPHand.Items[i].ToString();
            //        if (temp.Contains("11"))
            //        {
            //            _score = 1;
            //        }
            //    }

            //}


        }

        //Clears cards in hand
        public void clearHand(string a)
        {
            if(a == "Player")
            {
                do
                {
                    if (_PhandIndex == 1 || _PhandIndex <= 5)
                    {
                        removeCard(_P);
                        _PhandIndex--;
                    }
                } while (lbxPHand.Items.Count > 0 && lbxDHand.Items.Count <= 5);
            }

            if (a == "Dealer")
            {
                do
                {
                    if (_DhandIndex == 1 || _DhandIndex <= 5)
                    {
                        removeCard(_D);
                        _DhandIndex--;
                    }
                } while (lbxDHand.Items.Count > 0 && lbxDHand.Items.Count <= 5);
            }
            
        }

        //Declares score
        public void declareScore(string a)
        {
            _face = string.Empty;

            _face = sortValue(_face, a); //determins rank value of card
            _score = evaluateCardScore(ref _face,  ref _score, a);

            if (a == "Player")
            {
                calcPScore(ref _score, _face);
            }
            else if (a == "Dealer")
            {
                calcDScore(ref _score, _face);
            }

        }

        #endregion

        #region /*Operator functions*/

        //Builds Operator hand
        public void buildHand(string a, ref int score)
        {
            if(a == "Player")
            {
                drawCard(_P);
                declareScore(_P);
            }
            if(a == "Dealer")
            {
                drawCard(_D);
                declareScore(_D);
            }
        }

        //Clears cards from hand
        public void removeCard(string a)
        {
            if(a == "Player")
            {
                lbxPHand.SelectedIndex = 0;
                lbxDeck.Items.Add(lbxPHand.SelectedItem);
                lbxPHand.Items.Remove(lbxPHand.SelectedItem); 
            }
            if(a == "Dealer")
            {
                lbxDHand.SelectedIndex = 0;
                lbxDeck.Items.Add(lbxDHand.SelectedItem);
                lbxDHand.Items.Remove(lbxDHand.SelectedItem);
            }
        }

        //Draws operator a card
        public void drawCard(string a)
        {
            if(a == "Player")
            {
                lbxDeck.SelectedIndex = 0;
                lbxPHand.Items.Add(lbxDeck.SelectedItem);
                lbxDeck.Items.Remove(lbxDeck.SelectedItem);
            }
            if(a == "Dealer")
            {
                lbxDeck.SelectedIndex = 0;
                lbxDHand.Items.Add(lbxDeck.SelectedItem);
                lbxDeck.Items.Remove(lbxDeck.SelectedItem);
            }
            

        }

        //Calculates card score
        public void calcPScore(ref int pcount, string face)
        {
            int pScore = int.Parse(lblPlayCardScoreTxt.Text);
            pcount = int.Parse(face);

            pScore = pcount + pScore;

            lblPlayCardScoreTxt.Text = pScore.ToString();
        }
        public void calcDScore(ref int dcount, string face)
        {
            int dScore = int.Parse(lblDealCardScoreTxt.Text);
            dcount = int.Parse(face);

            dScore = dcount + dScore;

            lblDealCardScoreTxt.Text = dScore.ToString();
        }



        #endregion

        #region /*Game Engine Functions*/

        //Filters value of card
        public string filterCard(string face, string a)
        {
            string trim = string.Empty;
            if (a == "Player")
            {
                face = lbxPHand.Items[_PhandIndex].ToString();
            }
            else if (a == "Dealer")
            {
                face = lbxDHand.Items[_DhandIndex].ToString();
            }

            char[] rank = { 'A', 'B', 'C', 'D', 'J', 'Q', 'K', 'S' };
            trim = face.Trim(rank);
            return face = trim;
        }

        //Catagorizes value into ranks
        public string sortValue(string face, string a)
        {
            string sCheck = string.Empty;
            if (a == "Player")
            {
                sCheck = lbxPHand.Items[_PhandIndex].ToString();
            }
            else if (a == "Dealer")
            {
                sCheck = lbxDHand.Items[_DhandIndex].ToString();
            }

            if (sCheck.StartsWith("AS") ||
                sCheck.StartsWith("BS") ||
                sCheck.StartsWith("CS") ||
                sCheck.StartsWith("DS"))
            {
                face = sCheck + "S";
            }
            else if (sCheck.StartsWith("AJ") ||
                     sCheck.StartsWith("BJ") ||
                     sCheck.StartsWith("CJ") ||
                     sCheck.StartsWith("DJ"))
            {
                face = sCheck + "J";
            }
            else if (sCheck.StartsWith("AQ") ||
                     sCheck.StartsWith("BQ") ||
                     sCheck.StartsWith("CQ") ||
                     sCheck.StartsWith("DQ"))
            {
                face = sCheck + "Q";
            }
            else if (sCheck.StartsWith("AK") ||
                     sCheck.StartsWith("BK") ||
                     sCheck.StartsWith("CK") ||
                     sCheck.StartsWith("DK"))
            {
                face = sCheck + "K";
            }
            return face;
        }

        //Evaluates the value based on ranking
        public int evaluateCardScore(ref string face, ref int score, string a)
        {
            if (a == "Player")
            {

                if (face.Contains("S"))
                {
                    face = "11";
                    score = 11;
                }
                else if (face.Contains("J") || face.Contains("Q") || face.Contains("K"))
                {
                    face = "10";
                    score = 10;
                }
                else
                {
                    face = filterCard(face, a);
                }

            }
            if (a == "Dealer")
            {
                if (face.Contains("S"))
                {
                    face = "11";
                    score = 11;
                }
                else if (face.Contains("J") || face.Contains("Q") || face.Contains("K"))
                {
                    face = "10";
                    score = 10;
                }
                else
                {
                    face = filterCard(face, a);
                }

            }
            score = int.Parse(face);
            return score;
        }

        #endregion

    }

}
