﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_4
{
    public partial class FormGame : Form
    {
        int Row = 0; 
        int Col = 0;
        byte rowGuess = 0;
        byte columnGuess = 0;
        string answer = " ";
        ClassGameMechanics game;

        public FormGame()
        {
            InitializeComponent();

            // disable all actions except menu when starting
            labelCol.Enabled = false;
            labelRow.Enabled = false;
            labelGameMap.Enabled = false;
            groupBoxGame.Enabled = false;
            groupBoxActions.Enabled = false;
            buttonAction.Enabled = false;
            textBoxRow.Enabled = false;
            textBoxCol.Enabled = false;

            // buttons
            buttonClose.Click += ButtonClose_Click;
            buttonSettings.Click += ButtonSettings_Click;
            buttonStart.Click += ButtonStart_Click;
            buttonAction.Click += ButtonAction_Click;

            // textbox
            textBoxCol.KeyPress += TextBoxCol_KeyPress;
            textBoxRow.KeyPress += TextBoxRow_KeyPress;
            textBoxCol.TextChanged += TextBoxCol_TextChanged;
            textBoxRow.TextChanged += TextBoxRow_TextChanged;

        }

        #region textbox Events
        private void TextBoxRow_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allow only numbers and backspace
            if ((char.IsNumber(e.KeyChar) == false) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void TextBoxCol_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allow only numbers and backspace
            if ((char.IsNumber(e.KeyChar) == false) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// TextChanged events just make it where the user can't put a unrealistic value in the box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxRow_TextChanged(object sender, EventArgs e)
        {
            string value = textBoxRow.Text;
            if (textBoxRow.Text != "")
            {
                if (int.Parse(value) > 15)
                {
                    textBoxRow.Text = "15";
                }
            }
        }

        private void TextBoxCol_TextChanged(object sender, EventArgs e)
        {
            string value = textBoxCol.Text;
            if (textBoxCol.Text != "")
            {
                if (int.Parse(value) > 15)
                {
                    textBoxCol.Text = "15";
                }
            }
        }
        #endregion

        #region button Events
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            #region Enablers
            labelCol.Enabled = true;
            labelRow.Enabled = true;
            labelGameMap.Enabled = true;
            groupBoxGame.Enabled = true;
            groupBoxActions.Enabled = true;
            buttonAction.Enabled = true;
            textBoxRow.Enabled = true;
            textBoxCol.Enabled = true;
            buttonSettings.Enabled = false;
            #endregion
            labelDescription.Text = "Type a row and column value and click Guess to see if you found the treasure.";

        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            #region Enablers
            groupBoxActions.Enabled = true;
            buttonAction.Enabled = true;
            textBoxRow.Enabled = true;
            textBoxCol.Enabled = true;
            labelCol.Enabled = true;
            labelRow.Enabled = true;
            buttonStart.Enabled = false;
            #endregion
            labelDescription.Text = "To change the size of the map type in the row and column then click change.";
            buttonAction.Text = "Change";
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAction_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBoxRow.Text) != 0 ||
                Convert.ToInt32(textBoxCol.Text) != 0)
                {
                    if (buttonAction.Text == "Guess")
                    {
                        game.EvaluateGuess(rowGuess, columnGuess);
                    }
                    else
                    {
                        labelGameMap.Text = string.Empty;
                        Row = Convert.ToInt32(textBoxRow.Text);
                        Col = Convert.ToInt32(textBoxCol.Text);
                        game = new ClassGameMechanics(Row, Col);
                        labelGameMap.Enabled = true;
                        //labelGameMap.Text = "Here";
                        //game.PrintMap(answer);
                        labelGameMap.Text += game.PrintMap();
                        buttonAction.Text = "Guess";
                        buttonStart.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Sorry but the map must be at least a " +
                        "1x1 Try again\n", "Map Size error", 
                        MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Sorry but the map must be at least a " +
                    "1x1 Try again\n", "Map Size error", 
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
