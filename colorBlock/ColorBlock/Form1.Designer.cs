﻿namespace ColorBlock;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        gameButton = new System.Windows.Forms.Button();
        scoreLabel = new System.Windows.Forms.Label();
        highScoreLabel = new System.Windows.Forms.Label();
        playTimeBar = new System.Windows.Forms.ProgressBar();
        gameBackGroundLabel = new System.Windows.Forms.Label();
        borderButton = new System.Windows.Forms.Button();
        themeButton = new System.Windows.Forms.Button();
        muteCheckBox = new System.Windows.Forms.CheckBox();
        backColorButton = new System.Windows.Forms.Button();
        highScoreTextLabel = new System.Windows.Forms.Label();
        scoreTextLabel = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // gameButton
        // 
        gameButton.BackColor = System.Drawing.Color.Gainsboro;
        gameButton.Cursor = System.Windows.Forms.Cursors.Hand;
        gameButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
        gameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        gameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        gameButton.ForeColor = System.Drawing.Color.Black;
        gameButton.Location = new System.Drawing.Point(307, 480);
        gameButton.Name = "gameButton";
        gameButton.Size = new System.Drawing.Size(100, 40);
        gameButton.TabIndex = 2;
        gameButton.Text = "gameButton";
        gameButton.UseVisualStyleBackColor = false;
        gameButton.Visible = false;
        gameButton.Click += gameButton_Click;
        // 
        // scoreLabel
        // 
        scoreLabel.BackColor = System.Drawing.Color.Gray;
        scoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)129));
        scoreLabel.ForeColor = System.Drawing.Color.Black;
        scoreLabel.Location = new System.Drawing.Point(706, 142);
        scoreLabel.Name = "scoreLabel";
        scoreLabel.Size = new System.Drawing.Size(170, 70);
        scoreLabel.TabIndex = 3;
        scoreLabel.Text = "scoreLabel";
        scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        scoreLabel.Visible = false;
        // 
        // highScoreLabel
        // 
        highScoreLabel.BackColor = System.Drawing.Color.Gray;
        highScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        highScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)129));
        highScoreLabel.ForeColor = System.Drawing.Color.Black;
        highScoreLabel.Location = new System.Drawing.Point(706, 35);
        highScoreLabel.Name = "highScoreLabel";
        highScoreLabel.Size = new System.Drawing.Size(170, 70);
        highScoreLabel.TabIndex = 4;
        highScoreLabel.Text = "highScoreLabel";
        highScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        highScoreLabel.Visible = false;
        // 
        // playTimeBar
        // 
        playTimeBar.BackColor = System.Drawing.Color.Silver;
        playTimeBar.Location = new System.Drawing.Point(5, 459);
        playTimeBar.Name = "playTimeBar";
        playTimeBar.Size = new System.Drawing.Size(695, 13);
        playTimeBar.TabIndex = 5;
        // 
        // gameBackGroundLabel
        // 
        gameBackGroundLabel.BackColor = System.Drawing.Color.WhiteSmoke;
        gameBackGroundLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        gameBackGroundLabel.Enabled = false;
        gameBackGroundLabel.Location = new System.Drawing.Point(5, 5);
        gameBackGroundLabel.Name = "gameBackGroundLabel";
        gameBackGroundLabel.Size = new System.Drawing.Size(695, 467);
        gameBackGroundLabel.TabIndex = 7;
        // 
        // borderButton
        // 
        borderButton.BackColor = System.Drawing.Color.Gainsboro;
        borderButton.Cursor = System.Windows.Forms.Cursors.Hand;
        borderButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
        borderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        borderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)129));
        borderButton.ForeColor = System.Drawing.Color.Black;
        borderButton.Location = new System.Drawing.Point(706, 351);
        borderButton.Name = "borderButton";
        borderButton.Size = new System.Drawing.Size(170, 30);
        borderButton.TabIndex = 8;
        borderButton.Text = "borderButton";
        borderButton.UseVisualStyleBackColor = false;
        borderButton.Visible = false;
        borderButton.Click += borderButton_Click;
        // 
        // themeButton
        // 
        themeButton.BackColor = System.Drawing.Color.Gainsboro;
        themeButton.Cursor = System.Windows.Forms.Cursors.Hand;
        themeButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
        themeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        themeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)129));
        themeButton.ForeColor = System.Drawing.Color.Black;
        themeButton.Location = new System.Drawing.Point(706, 387);
        themeButton.Name = "themeButton";
        themeButton.Size = new System.Drawing.Size(170, 30);
        themeButton.TabIndex = 9;
        themeButton.Text = "themeButton";
        themeButton.UseVisualStyleBackColor = false;
        themeButton.Visible = false;
        themeButton.Click += themeButton_Click;
        // 
        // muteCheckBox
        // 
        muteCheckBox.BackColor = System.Drawing.Color.Transparent;
        muteCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
        muteCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
        muteCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        muteCheckBox.Location = new System.Drawing.Point(750, 285);
        muteCheckBox.Name = "muteCheckBox";
        muteCheckBox.Size = new System.Drawing.Size(80, 60);
        muteCheckBox.TabIndex = 10;
        muteCheckBox.Text = "muteCheckBox";
        muteCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        muteCheckBox.UseVisualStyleBackColor = false;
        // 
        // backColorButton
        // 
        backColorButton.BackColor = System.Drawing.Color.Gainsboro;
        backColorButton.Cursor = System.Windows.Forms.Cursors.Hand;
        backColorButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
        backColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        backColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)129));
        backColorButton.ForeColor = System.Drawing.Color.Black;
        backColorButton.Location = new System.Drawing.Point(706, 423);
        backColorButton.Name = "backColorButton";
        backColorButton.Size = new System.Drawing.Size(170, 30);
        backColorButton.TabIndex = 11;
        backColorButton.Text = "backColorButton";
        backColorButton.UseVisualStyleBackColor = false;
        backColorButton.Visible = false;
        backColorButton.Click += backColorButton_Click;
        // 
        // highScoreTextLabel
        // 
        highScoreTextLabel.Location = new System.Drawing.Point(706, 5);
        highScoreTextLabel.Name = "highScoreTextLabel";
        highScoreTextLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
        highScoreTextLabel.Size = new System.Drawing.Size(170, 30);
        highScoreTextLabel.TabIndex = 12;
        highScoreTextLabel.Text = "highScoreTextLabel";
        highScoreTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // scoreTextLabel
        // 
        scoreTextLabel.Location = new System.Drawing.Point(706, 112);
        scoreTextLabel.Name = "scoreTextLabel";
        scoreTextLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
        scoreTextLabel.Size = new System.Drawing.Size(170, 30);
        scoreTextLabel.TabIndex = 13;
        scoreTextLabel.Text = "scoreTextLabel";
        scoreTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // Form1
        // 
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        BackColor = System.Drawing.Color.Silver;
        ClientSize = new System.Drawing.Size(884, 526);
        Controls.Add(scoreTextLabel);
        Controls.Add(highScoreTextLabel);
        Controls.Add(backColorButton);
        Controls.Add(muteCheckBox);
        Controls.Add(themeButton);
        Controls.Add(borderButton);
        Controls.Add(playTimeBar);
        Controls.Add(highScoreLabel);
        Controls.Add(scoreLabel);
        Controls.Add(gameButton);
        Controls.Add(gameBackGroundLabel);
        Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)129));
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        Location = new System.Drawing.Point(15, 15);
        MaximizeBox = false;
        MinimizeBox = false;
        SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "ColorBlock";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label highScoreTextLabel;

    private System.Windows.Forms.Label scoreTextLabel;

    private System.Windows.Forms.Button backColorButton;

    private System.Windows.Forms.CheckBox muteCheckBox;

    private System.Windows.Forms.Button themeButton;

    private System.Windows.Forms.Button borderButton;

    private System.Windows.Forms.Label gameBackGroundLabel;

    private System.Windows.Forms.ProgressBar playTimeBar;

    private System.Windows.Forms.Label highScoreLabel;

    private System.Windows.Forms.Label scoreLabel;

    private System.Windows.Forms.Button gameButton;

    #endregion
}