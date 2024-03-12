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
using System.Web;
using System.Windows.Forms;

namespace BlackJack_TWO_Solution
{
    //image.fromfile[]
    public partial class frmMain : Form
    {
        #region /*Global Variables*/
        
        private string _face;
        private string _P = "Player";
        private string _D = "Dealer";

        private string _draw;

        private int _score = 0;
        private int _PhandIndex;
        private int _DhandIndex;
        private int _Wins;
        private int _Loss;

        public const string imgPath = @"PNG-Cards/";

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
            btnNewMatch.Visible = false;

            pnlPlayerRound.BorderStyle = BorderStyle.Fixed3D;
            pnlPlayerField.BorderStyle = BorderStyle.Fixed3D;
            pnlDealerRound.BorderStyle = BorderStyle.Fixed3D;
            pnlDealerField.BorderStyle = BorderStyle.Fixed3D;

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

        //Grabs player name input
        private void btnContinue_Click(object sender, EventArgs e)
        {
            lblPNameTxt.Text = tbxName.Text;

            if(lblPNameTxt.Text != string.Empty)
            {
                pnlInputField.Visible = false;
                btnContinue.Visible = false;
                btnContinue.Enabled = false;
                tbxName.Visible = false;
                tbxName.Enabled = false;
                lblNameInput.Visible = false;
                lblNameFlavor.Visible = false;

                btnNewMatch.Visible = true;
            }  
        }

        //Builds new match on click of startup button
        private void btnNewMatch_Click(object sender, EventArgs e)
        {
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
            int temp1 = _Wins;
            int temp2 = _Loss;

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

                Loss(_Loss);
                _Loss++;
                lblDealRoundScr.Text = _Loss.ToString();
                return;
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

                        Win(_Wins);
                        _Wins++;
                        lblPlayRoundScr.Text = _Wins.ToString();
                        return;
                    }
                    else if (int.Parse(lblPlayCardScoreTxt.Text) < 21 &&
                             int.Parse(lblDealCardScoreTxt.Text) < 21 &&
                             int.Parse(lblPlayCardScoreTxt.Text) > int.Parse(lblDealCardScoreTxt.Text) &&
                             lbxDHand.Items.Count == 5)
                    {
                        btnHit.Enabled = false;
                        btnHit.BackColor = Color.DarkSlateGray;

                        Win(_Wins);
                        _Wins++;
                        lblPlayRoundScr.Text = _Wins.ToString();
                        return;
                    }
                    else if (int.Parse(lblPlayCardScoreTxt.Text) < 21 &&
                             int.Parse(lblDealCardScoreTxt.Text) < 21 &&
                             int.Parse(lblDealCardScoreTxt.Text) > int.Parse(lblPlayCardScoreTxt.Text) &&
                             lbxDHand.Items.Count == 5)
                    {
                        btnHit.Enabled = false;
                        btnHit.BackColor = Color.DarkSlateGray;

                        Loss(_Loss);
                        _Loss++;
                        lblDealRoundScr.Text = _Loss.ToString();
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

                        Win(_Wins);
                        _Wins++;
                        lblPlayRoundScr.Text = _Wins.ToString();
                        return;
                    } 
                }

                if (int.Parse(lblDealCardScoreTxt.Text) > int.Parse(lblPlayCardScoreTxt.Text))
                {
                    btnHit.Enabled = false;
                    btnHit.BackColor = Color.DarkSlateGray;

                    Loss(_Loss);
                    _Loss++;
                    lblDealRoundScr.Text = _Loss.ToString();
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

            lblDealCardScoreTxt.Text = "0";
            lblPlayCardScoreTxt.Text = "0";

            btnNewMatch.Enabled = false;
            btnNewMatch.Visible = false;

            lblPDeclaration.Visible = false;
            lblDDeclaration.Visible = false;

            lblDealerName.Text = "Dealer";
            lblDealerName.ForeColor = Color.Black;

            lblPlayerName.Text = lblPNameTxt.Text;
            lblPlayerName.ForeColor = Color.Black;

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

            #region /*Rule of 21*/
            
            //Needs work
            //if (a == "Player")
            //{
            //    if (int.Parse(lblPlayCardScoreTxt.Text) == 21)
            //    {
            //        string first = lbxPHand.Items[0].ToString();
            //        string second = lbxPHand.Items[1].ToString();

            //        btnHit.Enabled = false;
            //        btnHit.BackColor = Color.DarkSlateGray;

            //        if (first.Contains("11") && second.Contains("AJ") ||
            //            first.Contains("AJ") && second.Contains("11") ||
            //            first.Contains("CJ") && second.Contains("11") ||
            //            first.Contains("11") && second.Contains("CJ"))
            //        {
            //            btnStay.Enabled = false;
            //            btnStay.BackColor = Color.DarkSlateGray;

            //            Win(_Wins);
            //            _Wins++;
            //            lblPlayRoundScr.Text = _Wins.ToString();
            //            return;
            //        }
            //    }
            //}
            //if (a == "Dealer")
            //{
            //    if (int.Parse(lblDealCardScoreTxt.Text) == 21)
            //    {
            //        string first = lbxDHand.Items[0].ToString();
            //        string second = lbxDHand.Items[1].ToString();

            //        btnHit.Enabled = false;
            //        btnHit.BackColor = Color.DarkSlateGray;

            //        if (first.Contains("11") && second.Contains("AJ") ||
            //            first.Contains("AJ") && second.Contains("11") ||
            //            first.Contains("CJ") && second.Contains("11") ||
            //            first.Contains("11") && second.Contains("CJ"))
            //        {
            //            btnStay.Enabled = false;
            //            btnStay.BackColor = Color.DarkSlateGray;

            //            Loss(_Loss);
            //            _Loss++;
            //            lblDealRoundScr.Text = _Loss.ToString();
            //            return;
            //        }
            //    }
            //}

            #endregion
        }

        //Clears cards from hand
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

            //_face = sortValue(_face, a); //determins rank value of card
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

        //Build image deck array
        public string drawImgDeck(string a)
        {
            var img = new List<KeyValuePair<string, string>>();//creating stings of keyvalue pairs.
            img.Add(new KeyValuePair<string, string>("AA2","/PNG-cards/AA2.png"));
            img.Add(new KeyValuePair<string, string>("AA3","/PNG-cards/AA3.png"));
            img.Add(new KeyValuePair<string, string>("AA4","/PNG-cards/AA4.png"));
            img.Add(new KeyValuePair<string, string>("AA5","/PNG-cards/AA5.png"));
            img.Add(new KeyValuePair<string, string>("AA6","/PNG-cards/AA6.png"));
            img.Add(new KeyValuePair<string, string>("AA7","/PNG-cards/AA7.png"));
            img.Add(new KeyValuePair<string, string>("AA8","/PNG-cards/AA8.png"));
            img.Add(new KeyValuePair<string, string>("AA9","/PNG-cards/AA9.png"));
            img.Add(new KeyValuePair<string, string>("AA10","/PNG-cards/AA10.png"));
            img.Add(new KeyValuePair<string, string>("AJ10","/PNG-cards/AJ10.png"));
            img.Add(new KeyValuePair<string, string>("AQ10","/PNG-cards/AQ10.png"));
            img.Add(new KeyValuePair<string, string>("AK10","/PNG-cards/AK10.png"));
            img.Add(new KeyValuePair<string, string>("AS11","/PNG-cards/AS11.png"));
            img.Add(new KeyValuePair<string, string>("BB2","/PNG-cards/BB2.png"));
            img.Add(new KeyValuePair<string, string>("BB3","/PNG-cards/BB3.png"));
            img.Add(new KeyValuePair<string, string>("BB4","/PNG-cards/BB4.png"));
            img.Add(new KeyValuePair<string, string>("BB5","/PNG-cards/BB5.png"));
            img.Add(new KeyValuePair<string, string>("BB6","/PNG-cards/BB6.png"));
            img.Add(new KeyValuePair<string, string>("BB7","/PNG-cards/BB7.png"));
            img.Add(new KeyValuePair<string, string>("BB8","/PNG-cards/BB8.png"));
            img.Add(new KeyValuePair<string, string>("BB9","/PNG-cards/BB9.png"));
            img.Add(new KeyValuePair<string, string>("BB10","/PNG-cards/BB10.png"));
            img.Add(new KeyValuePair<string, string>("BJ10","/PNG-cards/BJ10.png"));
            img.Add(new KeyValuePair<string, string>("BQ10","/PNG-cards/BQ10.png"));
            img.Add(new KeyValuePair<string, string>("BK10","/PNG-cards/BK10.png"));
            img.Add(new KeyValuePair<string, string>("BS11","/PNG-cards/BS11.png"));
            img.Add(new KeyValuePair<string, string>("CC2","/PNG-cards/CC2.png"));
            img.Add(new KeyValuePair<string, string>("CC3","/PNG-cards/CC3.png"));
            img.Add(new KeyValuePair<string, string>("CC4","/PNG-cards/CC4.png"));
            img.Add(new KeyValuePair<string, string>("CC5","/PNG-cards/CC5.png"));
            img.Add(new KeyValuePair<string, string>("CC6","/PNG-cards/CC6.png"));
            img.Add(new KeyValuePair<string, string>("CC7","/PNG-cards/CC7.png"));
            img.Add(new KeyValuePair<string, string>("CC8","/PNG-cards/CC8.png"));
            img.Add(new KeyValuePair<string, string>("CC9","/PNG-cards/CC9.png"));
            img.Add(new KeyValuePair<string, string>("CC10","/PNG-cards/CC10.png"));
            img.Add(new KeyValuePair<string, string>("CJ10","/PNG-cards/CJ10.png"));
            img.Add(new KeyValuePair<string, string>("CQ10","/PNG-cards/CQ10.png"));
            img.Add(new KeyValuePair<string, string>("CK10","/PNG-cards/CK10.png"));
            img.Add(new KeyValuePair<string, string>("CS11","/PNG-cards/CS11.png"));
            img.Add(new KeyValuePair<string, string>("DD2","/PNG-cards/DD2.png"));
            img.Add(new KeyValuePair<string, string>("DD3","/PNG-cards/DD3.png"));
            img.Add(new KeyValuePair<string, string>("DD4","/PNG-cards/DD4.png"));
            img.Add(new KeyValuePair<string, string>("DD5","/PNG-cards/DD5.png"));
            img.Add(new KeyValuePair<string, string>("DD6","/PNG-cards/DD6.png"));
            img.Add(new KeyValuePair<string, string>("DD7","/PNG-cards/DD7.png"));
            img.Add(new KeyValuePair<string, string>("DD8","/PNG-cards/DD8.png"));
            img.Add(new KeyValuePair<string, string>("DD9","/PNG-cards/DD9.png"));
            img.Add(new KeyValuePair<string, string>("DD10","/PNG-cards/DD10.png"));
            img.Add(new KeyValuePair<string, string>("DJ10","/PNG-cards/DJ10.png"));
            img.Add(new KeyValuePair<string, string>("DQ10","/PNG-cards/DQ10.png"));
            img.Add(new KeyValuePair<string, string>("DK10","/PNG-cards/DK10.png"));
            img.Add(new KeyValuePair<string, string>("DS11","/PNG-cards/DS11.png"));

            var match = img.Find(kvp => kvp.Key == a);
            //match[1] /*= img.Where(kvp => kvp.Value == match)*/;
            //a = match.ToString();
            return match.Value.ToString();

        }

        //Ties image to drawn card
        public void makeCard(string a, string b)
        {
            if(b == "Player")
            {
                if (_PhandIndex == 0)
                {
                    picPlayCard1.Image = Image.FromFile(a);
                    
                }
                if (_PhandIndex == 1)
                {
                    picPlayCard2.Image = Image.FromFile(a);
                }
                if (_PhandIndex == 2)
                {
                    picPlayCard3.Image = Image.FromFile(a);
                }
                if (_PhandIndex == 3)
                {
                    picPlayCard4.Image = Image.FromFile(a);
                }
                if (_PhandIndex == 4)
                {
                    picPlayCard5.Image = Image.FromFile(a);
                }

            }
            if(b == "Dealer")
            {
                if(_DhandIndex == 0)
                {
                   picDealCard1.Image = Image.FromFile(a);
                }
                if (_DhandIndex == 1)
                {
                    picDealCard2.Image = Image.FromFile(a);
                }
                if (_DhandIndex == 2)
                {
                    picDealCard3.Image = Image.FromFile(a);
                }
                if (_DhandIndex == 3)
                {
                    picDealCard4.Image = Image.FromFile(a);
                }
                if (_DhandIndex == 4)
                {
                    picDealCard5.Image = Image.FromFile(a);
                }
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

            char[] rank = { 'A', 'B', 'C', 'D', 'J', 'Q', 'K', 'S' };
            trim = face.Trim(rank);
            return face = trim;
        }

        //Catagorizes value into ranks
        //public string sortValue(string face, string a) // REwork into picture variable list
        //{
        //    string sCheck = string.Empty;

        //    if (sCheck.StartsWith("AS") ||
        //        sCheck.StartsWith("BS") ||
        //        sCheck.StartsWith("CS") ||
        //        sCheck.StartsWith("DS"))
        //    {
        //        face = sCheck + "S";
        //    }
        //    else if (sCheck.StartsWith("AJ") ||
        //             sCheck.StartsWith("BJ") ||
        //             sCheck.StartsWith("CJ") ||
        //             sCheck.StartsWith("DJ"))
        //    {
        //        face = sCheck + "J";
        //    }
        //    else if (sCheck.StartsWith("AQ") ||
        //             sCheck.StartsWith("BQ") ||
        //             sCheck.StartsWith("CQ") ||
        //             sCheck.StartsWith("DQ"))
        //    {
        //        face = sCheck + "Q";
        //    }
        //    else if (sCheck.StartsWith("AK") ||
        //             sCheck.StartsWith("BK") ||
        //             sCheck.StartsWith("CK") ||
        //             sCheck.StartsWith("DK"))
        //    {
        //        face = sCheck + "K";
        //    }
        //    return face;
        //}

        //Evaluates the value based on ranking
        public int evaluateCardScore(ref string face, ref int score, string a)
        {
             
            if (a == "Player")
            {
                face = lbxPHand.Items[_PhandIndex].ToString();

                int temp = int.Parse(lblPlayCardScoreTxt.Text); 
                if (face.Contains("S"))
                {
                    _draw =  drawImgDeck(face);
                    makeCard(_draw, _P);

                    face = "11";
                    score = 11;

                    if (temp > 11 && face == "11")
                    {
                        score = 1;
                    }
                    
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
                face = lbxDHand.Items[_DhandIndex].ToString();
                _draw = face;

                int temp = int.Parse(lblDealCardScoreTxt.Text);
                if (face.Contains("S"))
                {                    
                    face = "11";
                    score = 11;

                    if (temp > 11 && face == "11")
                    {
                        score = 1;
                    }

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

        #region /*Misc Methods*/

        //Changes declarations and applies tallies to the winners round score
        public void Win(int a)
        {
            lblPDeclaration.Visible = true;
            lblPDeclaration.Text = "WIN";
            lblPDeclaration.ForeColor = Color.Green;

            lblDDeclaration.Visible = true;
            lblDDeclaration.Text = "LOSS";
            lblDDeclaration.ForeColor = Color.Red; 
        }

        public void Loss(int a)
        {
            lblPDeclaration.Visible = true;
            lblPDeclaration.Text = "LOSS";
            lblPDeclaration.ForeColor = Color.Red;

            lblDDeclaration.Visible = true;
            lblDDeclaration.Text = "WIN";
            lblDDeclaration.ForeColor = Color.Green;            
        }

        #endregion


    }

}
