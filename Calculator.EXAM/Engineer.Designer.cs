using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Calculator;

namespace SimpleCalculator
{
    partial class Engineer : System.Windows.Forms.Form
    {
        private System.Windows.Forms.TextBox VersionInfo;
        private System.Windows.Forms.Button KeyExit;
        private System.Windows.Forms.Button KeyDate;
        private System.Windows.Forms.TextBox OutputDisplay;
        private System.Windows.Forms.Button KeyClear;
        private System.Windows.Forms.Button KeyMinus;
        private System.Windows.Forms.Button KeyPlus;
        private System.Windows.Forms.Button KeyEqual;
        private System.Windows.Forms.Button KeyMultiply;
        private System.Windows.Forms.Button KeyDivide;
        private System.Windows.Forms.Button KeyPoint;
        private System.Windows.Forms.Button KeySign;
        private System.Windows.Forms.Button KeyZero;
        private System.Windows.Forms.Button KeyNine;
        private System.Windows.Forms.Button KeyEight;
        private System.Windows.Forms.Button KeySeven;
        private System.Windows.Forms.Button KeySix;
        private System.Windows.Forms.Button KeyFive;
        private System.Windows.Forms.Button KeyFour;
        private System.Windows.Forms.Button KeyThree;
        private System.Windows.Forms.Button KeyTwo;
        private System.Windows.Forms.Button KeyOne;
        private System.Windows.Forms.Button KeyPow; // добавляю кнопку возведения в степень
        
        


        // Output Display Constants.
        private const string oneOut = "1";
        private const string twoOut = "2";
        private const string threeOut = "3";
        private const string fourOut = "4";
        private const string fiveOut = "5";
        private const string sixOut = "6";
        private const string sevenOut = "7";
        private const string eightOut = "8";
        private const string nineOut = "9";
        private const string zeroOut = "0";
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem обычныйToolStripMenuItem;
        private ToolStripMenuItem инженерныйToolStripMenuItem;
        private ToolStripMenuItem пОстроениеГрафиковToolStripMenuItem;
        private ToolStripMenuItem программистToolStripMenuItem;
        private ToolStripMenuItem вычислениеДатыToolStripMenuItem;
        private ToolStripMenuItem фунцииToolStripMenuItem;
        private ToolStripMenuItem обычныйToolStripMenuItem1;
        private ToolStripMenuItem инженерныйToolStripMenuItem1;
        private ToolStripMenuItem построениеГрафиковToolStripMenuItem1;
        private ToolStripMenuItem программистToolStripMenuItem1;
        private ToolStripMenuItem вычислениеДатыToolStripMenuItem1;
        
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Engineer));
            this.KeyDate = new System.Windows.Forms.Button();
            this.KeyOne = new System.Windows.Forms.Button();
            this.VersionInfo = new System.Windows.Forms.TextBox();
            this.KeySix = new System.Windows.Forms.Button();
            this.KeyFive = new System.Windows.Forms.Button();
            this.KeyEqual = new System.Windows.Forms.Button();
            this.KeyTwo = new System.Windows.Forms.Button();
            this.KeyZero = new System.Windows.Forms.Button();
            this.KeyThree = new System.Windows.Forms.Button();
            this.KeyPlus = new System.Windows.Forms.Button();
            this.KeyExit = new System.Windows.Forms.Button();
            this.KeySign = new System.Windows.Forms.Button();
            this.KeySeven = new System.Windows.Forms.Button();
            this.KeyPoint = new System.Windows.Forms.Button();
            this.KeyNine = new System.Windows.Forms.Button();
            this.OutputDisplay = new System.Windows.Forms.TextBox();
            this.KeyMinus = new System.Windows.Forms.Button();
            this.KeyEight = new System.Windows.Forms.Button();
            this.KeyMultiply = new System.Windows.Forms.Button();
            this.KeyFour = new System.Windows.Forms.Button();
            this.KeyClear = new System.Windows.Forms.Button();
            this.KeyDivide = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.обычныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инженерныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пОстроениеГрафиковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.программистToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вычислениеДатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фунцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обычныйToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.инженерныйToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.построениеГрафиковToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.программистToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вычислениеДатыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.KeyPow = new System.Windows.Forms.Button();
            this.KeySqrt = new System.Windows.Forms.Button();
            this.KeyInv = new System.Windows.Forms.Button();
            this.KeyGetSquare = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // KeyDate
            // 
            this.KeyDate.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyDate.ForeColor = System.Drawing.Color.Blue;
            this.KeyDate.Location = new System.Drawing.Point(240, 138);
            this.KeyDate.Name = "KeyDate";
            this.KeyDate.Size = new System.Drawing.Size(67, 47);
            this.KeyDate.TabIndex = 19;
            this.KeyDate.TabStop = false;
            this.KeyDate.Text = "Date";
            this.KeyDate.Click += new System.EventHandler(this.KeyDate_Click);
            this.KeyDate.MouseMove += new System.Windows.Forms.MouseEventHandler(this.KeyDate_MouseMove);
            // 
            // KeyOne
            // 
            this.KeyOne.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyOne.ForeColor = System.Drawing.Color.Blue;
            this.KeyOne.Location = new System.Drawing.Point(10, 194);
            this.KeyOne.Name = "KeyOne";
            this.KeyOne.Size = new System.Drawing.Size(48, 46);
            this.KeyOne.TabIndex = 2;
            this.KeyOne.TabStop = false;
            this.KeyOne.Text = "1";
            this.KeyOne.Click += new System.EventHandler(this.KeyOne_Click);
            // 
            // VersionInfo
            // 
            this.VersionInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.VersionInfo.Cursor = System.Windows.Forms.Cursors.No;
            this.VersionInfo.Font = new System.Drawing.Font("Verdana", 8F);
            this.VersionInfo.Location = new System.Drawing.Point(10, 27);
            this.VersionInfo.Name = "VersionInfo";
            this.VersionInfo.ReadOnly = true;
            this.VersionInfo.Size = new System.Drawing.Size(297, 20);
            this.VersionInfo.TabIndex = 0;
            this.VersionInfo.TabStop = false;
            this.VersionInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KeySix
            // 
            this.KeySix.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeySix.ForeColor = System.Drawing.Color.Blue;
            this.KeySix.Location = new System.Drawing.Point(125, 138);
            this.KeySix.Name = "KeySix";
            this.KeySix.Size = new System.Drawing.Size(48, 47);
            this.KeySix.TabIndex = 7;
            this.KeySix.TabStop = false;
            this.KeySix.Text = "6";
            this.KeySix.Click += new System.EventHandler(this.KeySix_Click);
            // 
            // KeyFive
            // 
            this.KeyFive.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyFive.ForeColor = System.Drawing.Color.Blue;
            this.KeyFive.Location = new System.Drawing.Point(67, 138);
            this.KeyFive.Name = "KeyFive";
            this.KeyFive.Size = new System.Drawing.Size(48, 47);
            this.KeyFive.TabIndex = 6;
            this.KeyFive.TabStop = false;
            this.KeyFive.Text = "5";
            this.KeyFive.Click += new System.EventHandler(this.KeyFive_Click);
            // 
            // KeyEqual
            // 
            this.KeyEqual.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyEqual.ForeColor = System.Drawing.Color.Red;
            this.KeyEqual.Location = new System.Drawing.Point(240, 249);
            this.KeyEqual.Name = "KeyEqual";
            this.KeyEqual.Size = new System.Drawing.Size(67, 46);
            this.KeyEqual.TabIndex = 18;
            this.KeyEqual.TabStop = false;
            this.KeyEqual.Text = "=";
            this.KeyEqual.Click += new System.EventHandler(this.KeyEqual_Click);
            this.KeyEqual.MouseMove += new System.Windows.Forms.MouseEventHandler(this.KeyEqual_MouseMove);
            // 
            // KeyTwo
            // 
            this.KeyTwo.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyTwo.ForeColor = System.Drawing.Color.Blue;
            this.KeyTwo.Location = new System.Drawing.Point(67, 194);
            this.KeyTwo.Name = "KeyTwo";
            this.KeyTwo.Size = new System.Drawing.Size(48, 46);
            this.KeyTwo.TabIndex = 3;
            this.KeyTwo.TabStop = false;
            this.KeyTwo.Text = "2";
            this.KeyTwo.Click += new System.EventHandler(this.KeyTwo_Click);
            // 
            // KeyZero
            // 
            this.KeyZero.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyZero.ForeColor = System.Drawing.Color.Blue;
            this.KeyZero.Location = new System.Drawing.Point(10, 249);
            this.KeyZero.Name = "KeyZero";
            this.KeyZero.Size = new System.Drawing.Size(48, 46);
            this.KeyZero.TabIndex = 11;
            this.KeyZero.TabStop = false;
            this.KeyZero.Text = "0";
            this.KeyZero.Click += new System.EventHandler(this.KeyZero_Click);
            // 
            // KeyThree
            // 
            this.KeyThree.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyThree.ForeColor = System.Drawing.Color.Blue;
            this.KeyThree.Location = new System.Drawing.Point(125, 194);
            this.KeyThree.Name = "KeyThree";
            this.KeyThree.Size = new System.Drawing.Size(48, 46);
            this.KeyThree.TabIndex = 4;
            this.KeyThree.TabStop = false;
            this.KeyThree.Text = "3";
            this.KeyThree.Click += new System.EventHandler(this.KeyThree_Click);
            // 
            // KeyPlus
            // 
            this.KeyPlus.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyPlus.ForeColor = System.Drawing.Color.Red;
            this.KeyPlus.Location = new System.Drawing.Point(182, 249);
            this.KeyPlus.Name = "KeyPlus";
            this.KeyPlus.Size = new System.Drawing.Size(48, 46);
            this.KeyPlus.TabIndex = 12;
            this.KeyPlus.TabStop = false;
            this.KeyPlus.Text = "+";
            this.KeyPlus.Click += new System.EventHandler(this.KeyPlus_Click);
            this.KeyPlus.MouseMove += new System.Windows.Forms.MouseEventHandler(this.KeyPlus_MouseMove);
            // 
            // KeyExit
            // 
            this.KeyExit.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyExit.ForeColor = System.Drawing.Color.Red;
            this.KeyExit.Location = new System.Drawing.Point(240, 194);
            this.KeyExit.Name = "KeyExit";
            this.KeyExit.Size = new System.Drawing.Size(67, 46);
            this.KeyExit.TabIndex = 21;
            this.KeyExit.TabStop = false;
            this.KeyExit.Text = "Exit";
            this.KeyExit.Click += new System.EventHandler(this.KeyExit_Click);
            this.KeyExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.KeyExit_MouseMove);
            // 
            // KeySign
            // 
            this.KeySign.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
            this.KeySign.ForeColor = System.Drawing.Color.Blue;
            this.KeySign.Location = new System.Drawing.Point(125, 249);
            this.KeySign.Name = "KeySign";
            this.KeySign.Size = new System.Drawing.Size(48, 46);
            this.KeySign.TabIndex = 16;
            this.KeySign.TabStop = false;
            this.KeySign.Text = "+/-";
            this.KeySign.Click += new System.EventHandler(this.KeySign_Click);
            // 
            // KeySeven
            // 
            this.KeySeven.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeySeven.ForeColor = System.Drawing.Color.Blue;
            this.KeySeven.Location = new System.Drawing.Point(10, 83);
            this.KeySeven.Name = "KeySeven";
            this.KeySeven.Size = new System.Drawing.Size(48, 46);
            this.KeySeven.TabIndex = 8;
            this.KeySeven.TabStop = false;
            this.KeySeven.Text = "7";
            this.KeySeven.Click += new System.EventHandler(this.KeySeven_Click);
            // 
            // KeyPoint
            // 
            this.KeyPoint.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyPoint.ForeColor = System.Drawing.Color.Blue;
            this.KeyPoint.Location = new System.Drawing.Point(67, 249);
            this.KeyPoint.Name = "KeyPoint";
            this.KeyPoint.Size = new System.Drawing.Size(48, 46);
            this.KeyPoint.TabIndex = 17;
            this.KeyPoint.TabStop = false;
            this.KeyPoint.Text = ".";
            this.KeyPoint.Click += new System.EventHandler(this.KeyPoint_Click);
            // 
            // KeyNine
            // 
            this.KeyNine.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyNine.ForeColor = System.Drawing.Color.Blue;
            this.KeyNine.Location = new System.Drawing.Point(125, 83);
            this.KeyNine.Name = "KeyNine";
            this.KeyNine.Size = new System.Drawing.Size(48, 46);
            this.KeyNine.TabIndex = 10;
            this.KeyNine.TabStop = false;
            this.KeyNine.Text = "9";
            this.KeyNine.Click += new System.EventHandler(this.KeyNine_Click);
            // 
            // OutputDisplay
            // 
            this.OutputDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.OutputDisplay.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.OutputDisplay.Location = new System.Drawing.Point(10, 51);
            this.OutputDisplay.Name = "OutputDisplay";
            this.OutputDisplay.ReadOnly = true;
            this.OutputDisplay.Size = new System.Drawing.Size(297, 26);
            this.OutputDisplay.TabIndex = 1;
            this.OutputDisplay.TabStop = false;
            this.OutputDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // KeyMinus
            // 
            this.KeyMinus.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyMinus.ForeColor = System.Drawing.Color.Red;
            this.KeyMinus.Location = new System.Drawing.Point(182, 194);
            this.KeyMinus.Name = "KeyMinus";
            this.KeyMinus.Size = new System.Drawing.Size(48, 46);
            this.KeyMinus.TabIndex = 13;
            this.KeyMinus.TabStop = false;
            this.KeyMinus.Text = "-";
            this.KeyMinus.Click += new System.EventHandler(this.KeyMinus_Click);
            this.KeyMinus.MouseMove += new System.Windows.Forms.MouseEventHandler(this.KeyMinus_MouseMove);
            // 
            // KeyEight
            // 
            this.KeyEight.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyEight.ForeColor = System.Drawing.Color.Blue;
            this.KeyEight.Location = new System.Drawing.Point(67, 83);
            this.KeyEight.Name = "KeyEight";
            this.KeyEight.Size = new System.Drawing.Size(48, 46);
            this.KeyEight.TabIndex = 9;
            this.KeyEight.TabStop = false;
            this.KeyEight.Text = "8";
            this.KeyEight.Click += new System.EventHandler(this.KeyEight_Click);
            // 
            // KeyMultiply
            // 
            this.KeyMultiply.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyMultiply.ForeColor = System.Drawing.Color.Red;
            this.KeyMultiply.Location = new System.Drawing.Point(182, 138);
            this.KeyMultiply.Name = "KeyMultiply";
            this.KeyMultiply.Size = new System.Drawing.Size(48, 47);
            this.KeyMultiply.TabIndex = 14;
            this.KeyMultiply.TabStop = false;
            this.KeyMultiply.Text = "*";
            this.KeyMultiply.Click += new System.EventHandler(this.KeyMultiply_Click);
            this.KeyMultiply.MouseMove += new System.Windows.Forms.MouseEventHandler(this.KeyMultiply_MouseMove);
            // 
            // KeyFour
            // 
            this.KeyFour.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyFour.ForeColor = System.Drawing.Color.Blue;
            this.KeyFour.Location = new System.Drawing.Point(10, 138);
            this.KeyFour.Name = "KeyFour";
            this.KeyFour.Size = new System.Drawing.Size(48, 47);
            this.KeyFour.TabIndex = 5;
            this.KeyFour.TabStop = false;
            this.KeyFour.Text = "4";
            this.KeyFour.Click += new System.EventHandler(this.KeyFour_Click);
            // 
            // KeyClear
            // 
            this.KeyClear.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyClear.ForeColor = System.Drawing.Color.Red;
            this.KeyClear.Location = new System.Drawing.Point(240, 83);
            this.KeyClear.Name = "KeyClear";
            this.KeyClear.Size = new System.Drawing.Size(67, 46);
            this.KeyClear.TabIndex = 20;
            this.KeyClear.TabStop = false;
            this.KeyClear.Text = "C";
            this.KeyClear.Click += new System.EventHandler(this.KeyClear_Click);
            this.KeyClear.MouseMove += new System.Windows.Forms.MouseEventHandler(this.KeyClear_MouseMove);
            // 
            // KeyDivide
            // 
            this.KeyDivide.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyDivide.ForeColor = System.Drawing.Color.Red;
            this.KeyDivide.Location = new System.Drawing.Point(182, 83);
            this.KeyDivide.Name = "KeyDivide";
            this.KeyDivide.Size = new System.Drawing.Size(48, 46);
            this.KeyDivide.TabIndex = 15;
            this.KeyDivide.TabStop = false;
            this.KeyDivide.Text = "/";
            this.KeyDivide.Click += new System.EventHandler(this.KeyDivide_Click);
            this.KeyDivide.MouseMove += new System.Windows.Forms.MouseEventHandler(this.KeyDivide_MouseMove);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.фунцииToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(386, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обычныйToolStripMenuItem,
            this.инженерныйToolStripMenuItem,
            this.пОстроениеГрафиковToolStripMenuItem,
            this.программистToolStripMenuItem,
            this.вычислениеДатыToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // обычныйToolStripMenuItem
            // 
            this.обычныйToolStripMenuItem.Name = "обычныйToolStripMenuItem";
            this.обычныйToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.обычныйToolStripMenuItem.Text = "Обычный";
            // 
            // инженерныйToolStripMenuItem
            // 
            this.инженерныйToolStripMenuItem.Name = "инженерныйToolStripMenuItem";
            this.инженерныйToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.инженерныйToolStripMenuItem.Text = "Инженерный";
            // 
            // пОстроениеГрафиковToolStripMenuItem
            // 
            this.пОстроениеГрафиковToolStripMenuItem.Name = "пОстроениеГрафиковToolStripMenuItem";
            this.пОстроениеГрафиковToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.пОстроениеГрафиковToolStripMenuItem.Text = "Построение графиков";
            // 
            // программистToolStripMenuItem
            // 
            this.программистToolStripMenuItem.Name = "программистToolStripMenuItem";
            this.программистToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.программистToolStripMenuItem.Text = "Программист  </>";
            // 
            // вычислениеДатыToolStripMenuItem
            // 
            this.вычислениеДатыToolStripMenuItem.Name = "вычислениеДатыToolStripMenuItem";
            this.вычислениеДатыToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.вычислениеДатыToolStripMenuItem.Text = "Вычисление даты";
            // 
            // фунцииToolStripMenuItem
            // 
            this.фунцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обычныйToolStripMenuItem1,
            this.инженерныйToolStripMenuItem1,
            this.построениеГрафиковToolStripMenuItem1,
            this.программистToolStripMenuItem1,
            this.вычислениеДатыToolStripMenuItem1});
            this.фунцииToolStripMenuItem.Name = "фунцииToolStripMenuItem";
            this.фунцииToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.фунцииToolStripMenuItem.Text = "Фунции";
            // 
            // обычныйToolStripMenuItem1
            // 
            this.обычныйToolStripMenuItem1.Name = "обычныйToolStripMenuItem1";
            this.обычныйToolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.обычныйToolStripMenuItem1.Text = "Обычный";
            // 
            // инженерныйToolStripMenuItem1
            // 
            this.инженерныйToolStripMenuItem1.Name = "инженерныйToolStripMenuItem1";
            this.инженерныйToolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.инженерныйToolStripMenuItem1.Text = "Инженерный";
            this.инженерныйToolStripMenuItem1.Click += new System.EventHandler(this.инженерныйToolStripMenuItem1_Click);
            // 
            // построениеГрафиковToolStripMenuItem1
            // 
            this.построениеГрафиковToolStripMenuItem1.Name = "построениеГрафиковToolStripMenuItem1";
            this.построениеГрафиковToolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.построениеГрафиковToolStripMenuItem1.Text = "Построение графиков";
            // 
            // программистToolStripMenuItem1
            // 
            this.программистToolStripMenuItem1.Name = "программистToolStripMenuItem1";
            this.программистToolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.программистToolStripMenuItem1.Text = "Программист </>";
            // 
            // вычислениеДатыToolStripMenuItem1
            // 
            this.вычислениеДатыToolStripMenuItem1.Name = "вычислениеДатыToolStripMenuItem1";
            this.вычислениеДатыToolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.вычислениеДатыToolStripMenuItem1.Text = "Вычисление даты";
            // 
            // KeyPow
            // 
            this.KeyPow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.KeyPow.Image = ((System.Drawing.Image)(resources.GetObject("KeyPow.Image")));
            this.KeyPow.Location = new System.Drawing.Point(327, 83);
            this.KeyPow.Name = "KeyPow";
            this.KeyPow.Size = new System.Drawing.Size(48, 47);
            this.KeyPow.TabIndex = 23;
            this.KeyPow.UseVisualStyleBackColor = false;
            this.KeyPow.Click += new System.EventHandler(this.btnPow_Click);
            this.KeyPow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.KeyPow_MouseMove);
            // 
            // KeySqrt
            // 
            this.KeySqrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.KeySqrt.Image = ((System.Drawing.Image)(resources.GetObject("KeySqrt.Image")));
            this.KeySqrt.Location = new System.Drawing.Point(327, 138);
            this.KeySqrt.Name = "KeySqrt";
            this.KeySqrt.Size = new System.Drawing.Size(48, 47);
            this.KeySqrt.TabIndex = 24;
            this.KeySqrt.UseVisualStyleBackColor = false;
            this.KeySqrt.Click += new System.EventHandler(this.KeySqrt_Click);
            this.KeySqrt.MouseMove += new System.Windows.Forms.MouseEventHandler(this.KeySqrt_MouseMove);
            // 
            // KeyInv
            // 
            this.KeyInv.Image = ((System.Drawing.Image)(resources.GetObject("KeyInv.Image")));
            this.KeyInv.Location = new System.Drawing.Point(327, 194);
            this.KeyInv.Name = "KeyInv";
            this.KeyInv.Size = new System.Drawing.Size(48, 47);
            this.KeyInv.TabIndex = 25;
            this.KeyInv.UseVisualStyleBackColor = true;
            this.KeyInv.Click += new System.EventHandler(this.KeyInv_Click);
            this.KeyInv.MouseMove += new System.Windows.Forms.MouseEventHandler(this.KeyInv_MouseMove);
            // 
            // KeyGetSquare
            // 
            this.KeyGetSquare.Image = ((System.Drawing.Image)(resources.GetObject("KeyGetSquare.Image")));
            this.KeyGetSquare.Location = new System.Drawing.Point(327, 248);
            this.KeyGetSquare.Name = "KeyGetSquare";
            this.KeyGetSquare.Size = new System.Drawing.Size(48, 47);
            this.KeyGetSquare.TabIndex = 26;
            this.KeyGetSquare.UseVisualStyleBackColor = true;
            this.KeyGetSquare.Click += new System.EventHandler(this.KeyGetSquare_Click);
            this.KeyGetSquare.MouseMove += new System.Windows.Forms.MouseEventHandler(this.KeyGetSquare_MouseMove);
            // 
            // Engineer
            // 
            this.AcceptButton = this.KeyZero;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(386, 302);
            this.Controls.Add(this.KeyGetSquare);
            this.Controls.Add(this.KeyInv);
            this.Controls.Add(this.KeySqrt);
            this.Controls.Add(this.KeyPow);
            this.Controls.Add(this.KeyOne);
            this.Controls.Add(this.KeyTwo);
            this.Controls.Add(this.KeyThree);
            this.Controls.Add(this.KeyFour);
            this.Controls.Add(this.KeyFive);
            this.Controls.Add(this.KeySix);
            this.Controls.Add(this.KeySeven);
            this.Controls.Add(this.KeyEight);
            this.Controls.Add(this.KeyNine);
            this.Controls.Add(this.KeyZero);
            this.Controls.Add(this.KeyPlus);
            this.Controls.Add(this.KeyMinus);
            this.Controls.Add(this.KeyMultiply);
            this.Controls.Add(this.KeyDivide);
            this.Controls.Add(this.KeySign);
            this.Controls.Add(this.KeyPoint);
            this.Controls.Add(this.KeyEqual);
            this.Controls.Add(this.KeyDate);
            this.Controls.Add(this.KeyClear);
            this.Controls.Add(this.KeyExit);
            this.Controls.Add(this.OutputDisplay);
            this.Controls.Add(this.VersionInfo);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Engineer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Engineering Calculator";
            this.TopMost = true;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button KeySqrt;
        private Button KeyInv;
        private Button KeyGetSquare;
    }
}