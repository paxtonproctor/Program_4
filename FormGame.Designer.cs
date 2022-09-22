namespace Program_4
{
    partial class FormGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.groupBoxGame = new System.Windows.Forms.GroupBox();
            this.labelGameMap = new System.Windows.Forms.Label();
            this.buttonAction = new System.Windows.Forms.Button();
            this.labelRow = new System.Windows.Forms.Label();
            this.labelCol = new System.Windows.Forms.Label();
            this.textBoxRow = new System.Windows.Forms.TextBox();
            this.textBoxCol = new System.Windows.Forms.TextBox();
            this.groupBoxDescription = new System.Windows.Forms.GroupBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.groupBoxMenu.SuspendLayout();
            this.groupBoxGame.SuspendLayout();
            this.groupBoxDescription.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(5, 17);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(115, 32);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(5, 54);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(115, 32);
            this.buttonSettings.TabIndex = 1;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(7, 92);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(115, 32);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.buttonStart);
            this.groupBoxMenu.Controls.Add(this.buttonClose);
            this.groupBoxMenu.Controls.Add(this.buttonSettings);
            this.groupBoxMenu.Location = new System.Drawing.Point(442, 119);
            this.groupBoxMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxMenu.Size = new System.Drawing.Size(124, 135);
            this.groupBoxMenu.TabIndex = 3;
            this.groupBoxMenu.TabStop = false;
            this.groupBoxMenu.Text = "Menu";
            // 
            // groupBoxGame
            // 
            this.groupBoxGame.Controls.Add(this.labelGameMap);
            this.groupBoxGame.Location = new System.Drawing.Point(9, 11);
            this.groupBoxGame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxGame.Name = "groupBoxGame";
            this.groupBoxGame.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxGame.Size = new System.Drawing.Size(428, 243);
            this.groupBoxGame.TabIndex = 4;
            this.groupBoxGame.TabStop = false;
            this.groupBoxGame.Text = "Game";
            // 
            // labelGameMap
            // 
            this.labelGameMap.AutoSize = true;
            this.labelGameMap.Location = new System.Drawing.Point(4, 15);
            this.labelGameMap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGameMap.Name = "labelGameMap";
            this.labelGameMap.Size = new System.Drawing.Size(0, 13);
            this.labelGameMap.TabIndex = 0;
            // 
            // buttonAction
            // 
            this.buttonAction.Location = new System.Drawing.Point(4, 67);
            this.buttonAction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAction.Name = "buttonAction";
            this.buttonAction.Size = new System.Drawing.Size(113, 32);
            this.buttonAction.TabIndex = 5;
            this.buttonAction.Text = "Results";
            this.buttonAction.UseVisualStyleBackColor = true;
            // 
            // labelRow
            // 
            this.labelRow.AutoSize = true;
            this.labelRow.Location = new System.Drawing.Point(13, 19);
            this.labelRow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRow.Name = "labelRow";
            this.labelRow.Size = new System.Drawing.Size(32, 13);
            this.labelRow.TabIndex = 6;
            this.labelRow.Text = "Row:";
            // 
            // labelCol
            // 
            this.labelCol.AutoSize = true;
            this.labelCol.Location = new System.Drawing.Point(4, 41);
            this.labelCol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCol.Name = "labelCol";
            this.labelCol.Size = new System.Drawing.Size(45, 13);
            this.labelCol.TabIndex = 7;
            this.labelCol.Text = "Column:";
            // 
            // textBoxRow
            // 
            this.textBoxRow.Location = new System.Drawing.Point(45, 16);
            this.textBoxRow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxRow.Name = "textBoxRow";
            this.textBoxRow.Size = new System.Drawing.Size(76, 20);
            this.textBoxRow.TabIndex = 8;
            // 
            // textBoxCol
            // 
            this.textBoxCol.Location = new System.Drawing.Point(45, 39);
            this.textBoxCol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCol.Name = "textBoxCol";
            this.textBoxCol.Size = new System.Drawing.Size(76, 20);
            this.textBoxCol.TabIndex = 9;
            // 
            // groupBoxDescription
            // 
            this.groupBoxDescription.Controls.Add(this.labelDescription);
            this.groupBoxDescription.Location = new System.Drawing.Point(9, 259);
            this.groupBoxDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxDescription.Name = "groupBoxDescription";
            this.groupBoxDescription.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxDescription.Size = new System.Drawing.Size(557, 61);
            this.groupBoxDescription.TabIndex = 10;
            this.groupBoxDescription.TabStop = false;
            this.groupBoxDescription.Text = "Game Output";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(5, 18);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(384, 26);
            this.labelDescription.TabIndex = 0;
            this.labelDescription.Text = "Welcome to Treasure Island Game! \r\nYou can start the Game or you can click Settin" +
    "gs to change the size of the map.";
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.labelRow);
            this.groupBoxActions.Controls.Add(this.buttonAction);
            this.groupBoxActions.Controls.Add(this.textBoxCol);
            this.groupBoxActions.Controls.Add(this.labelCol);
            this.groupBoxActions.Controls.Add(this.textBoxRow);
            this.groupBoxActions.Location = new System.Drawing.Point(442, 11);
            this.groupBoxActions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxActions.Size = new System.Drawing.Size(124, 103);
            this.groupBoxActions.TabIndex = 1;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Actions";
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 330);
            this.Controls.Add(this.groupBoxActions);
            this.Controls.Add(this.groupBoxDescription);
            this.Controls.Add(this.groupBoxMenu);
            this.Controls.Add(this.groupBoxGame);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormGame";
            this.Text = "Treasure Island";
            this.groupBoxMenu.ResumeLayout(false);
            this.groupBoxGame.ResumeLayout(false);
            this.groupBoxGame.PerformLayout();
            this.groupBoxDescription.ResumeLayout(false);
            this.groupBoxDescription.PerformLayout();
            this.groupBoxActions.ResumeLayout(false);
            this.groupBoxActions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.GroupBox groupBoxGame;
        private System.Windows.Forms.Label labelGameMap;
        private System.Windows.Forms.Button buttonAction;
        private System.Windows.Forms.Label labelRow;
        private System.Windows.Forms.Label labelCol;
        private System.Windows.Forms.TextBox textBoxRow;
        private System.Windows.Forms.TextBox textBoxCol;
        private System.Windows.Forms.GroupBox groupBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.GroupBox groupBoxActions;
    }
}

