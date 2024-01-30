using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using ExcelDataReader;
using System.Diagnostics;
using System.Linq;
using System.Drawing;
using static System.Collections.Specialized.BitVector32;
//using System.Diagnostics.Metrics;
using System.Configuration;
//using System.Diagnostics.Metrics;

namespace TestApp
{
    public partial class Form1 : Form
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
               this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
               this.button1 = new System.Windows.Forms.Button();
               this.textBox1 = new System.Windows.Forms.TextBox();
               this.dataSet1 = new System.Data.DataSet();
               this.Sheet = new System.Windows.Forms.Label();
               this.statusStrip1 = new System.Windows.Forms.StatusStrip();
               this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
               this.label1 = new System.Windows.Forms.Label();
               this.txtMaxSourcePoint = new System.Windows.Forms.TextBox();
               this.txtmaxcmp = new System.Windows.Forms.TextBox();
               this.txtmaxFieldFileNumber = new System.Windows.Forms.TextBox();
               this.txtMinSourcePoint = new System.Windows.Forms.TextBox();
               this.txtmincmp = new System.Windows.Forms.TextBox();
               this.txtminFieldFileNumber = new System.Windows.Forms.TextBox();
               this.label5 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.button3 = new System.Windows.Forms.Button();
               this.label6 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.txtstart = new System.Windows.Forms.TextBox();
               this.label7 = new System.Windows.Forms.Label();
               this.label8 = new System.Windows.Forms.Label();
               this.txtlongSourcePoint = new System.Windows.Forms.TextBox();
               this.txtlongcmp = new System.Windows.Forms.TextBox();
               this.txtlongFieldFileNumber = new System.Windows.Forms.TextBox();
               this.txtIniSourcePoint = new System.Windows.Forms.TextBox();
               this.txtInicmp = new System.Windows.Forms.TextBox();
               this.txtIniFieldFileNumber = new System.Windows.Forms.TextBox();
               this.txtLongTraceType = new System.Windows.Forms.TextBox();
               this.txtIniTraceType = new System.Windows.Forms.TextBox();
               this.txtMaxTraceType = new System.Windows.Forms.TextBox();
               this.txtMinTraceType = new System.Windows.Forms.TextBox();
               this.label9 = new System.Windows.Forms.Label();
               this.txtLongCmp1 = new System.Windows.Forms.TextBox();
               this.txtIniCmp1 = new System.Windows.Forms.TextBox();
               this.txtMaxCmp1 = new System.Windows.Forms.TextBox();
               this.txtMinCmp1 = new System.Windows.Forms.TextBox();
               this.label10 = new System.Windows.Forms.Label();
               this.txtLongOffset = new System.Windows.Forms.TextBox();
               this.txtIniOffset = new System.Windows.Forms.TextBox();
               this.txtMaxOffset = new System.Windows.Forms.TextBox();
               this.txtMinOffset = new System.Windows.Forms.TextBox();
               this.label11 = new System.Windows.Forms.Label();
               this.txtLongSourceX = new System.Windows.Forms.TextBox();
               this.txtIniSourceX = new System.Windows.Forms.TextBox();
               this.txtMaxSourceX = new System.Windows.Forms.TextBox();
               this.txtMinSourceX = new System.Windows.Forms.TextBox();
               this.label12 = new System.Windows.Forms.Label();
               this.txtLongSourceY = new System.Windows.Forms.TextBox();
               this.txtIniSourceY = new System.Windows.Forms.TextBox();
               this.txtMaxSourceY = new System.Windows.Forms.TextBox();
               this.txtMinSourceY = new System.Windows.Forms.TextBox();
               this.label13 = new System.Windows.Forms.Label();
               this.txtLongReceiverX = new System.Windows.Forms.TextBox();
               this.txtIniReceiverX = new System.Windows.Forms.TextBox();
               this.txtMaxReceiverX = new System.Windows.Forms.TextBox();
               this.txtMinReceiverX = new System.Windows.Forms.TextBox();
               this.label14 = new System.Windows.Forms.Label();
               this.txtLongReceiverY = new System.Windows.Forms.TextBox();
               this.txtIniReceiverY = new System.Windows.Forms.TextBox();
               this.txtMaxReceiverY = new System.Windows.Forms.TextBox();
               this.txtMinReceiverY = new System.Windows.Forms.TextBox();
               this.label15 = new System.Windows.Forms.Label();
               this.txtLongSourceStation = new System.Windows.Forms.TextBox();
               this.txtIniSourceStation = new System.Windows.Forms.TextBox();
               this.txtMaxSourceStation = new System.Windows.Forms.TextBox();
               this.txtMinSourceStation = new System.Windows.Forms.TextBox();
               this.label16 = new System.Windows.Forms.Label();
               this.txtLongComponetType = new System.Windows.Forms.TextBox();
               this.txtIniComponetType = new System.Windows.Forms.TextBox();
               this.txtMaxComponetType = new System.Windows.Forms.TextBox();
               this.txtMinComponetType = new System.Windows.Forms.TextBox();
               this.label17 = new System.Windows.Forms.Label();
               this.txtLongMainSourceType = new System.Windows.Forms.TextBox();
               this.txtIniMainSourceType = new System.Windows.Forms.TextBox();
               this.txtMaxMainSourceType = new System.Windows.Forms.TextBox();
               this.txtMinMainSourceType = new System.Windows.Forms.TextBox();
               this.label18 = new System.Windows.Forms.Label();
               this.txtLongCmpX = new System.Windows.Forms.TextBox();
               this.txtIniCmpX = new System.Windows.Forms.TextBox();
               this.txtMaxCmpX = new System.Windows.Forms.TextBox();
               this.txtMinCmpX = new System.Windows.Forms.TextBox();
               this.label19 = new System.Windows.Forms.Label();
               this.txtLongCmpY = new System.Windows.Forms.TextBox();
               this.txtIniCmpY = new System.Windows.Forms.TextBox();
               this.txtMaxCmpY = new System.Windows.Forms.TextBox();
               this.txtMinCmpY = new System.Windows.Forms.TextBox();
               this.label20 = new System.Windows.Forms.Label();
               this.txtLongFold = new System.Windows.Forms.TextBox();
               this.txtIniFold = new System.Windows.Forms.TextBox();
               this.txtMaxFold = new System.Windows.Forms.TextBox();
               this.txtMinFold = new System.Windows.Forms.TextBox();
               this.label21 = new System.Windows.Forms.Label();
               this.txtLongCCPNorthing = new System.Windows.Forms.TextBox();
               this.txtIniCCPNorthing = new System.Windows.Forms.TextBox();
               this.txtMaxCCPNorthing = new System.Windows.Forms.TextBox();
               this.txtMinCCPNorthing = new System.Windows.Forms.TextBox();
               this.label22 = new System.Windows.Forms.Label();
               this.txtLongCCPElevation = new System.Windows.Forms.TextBox();
               this.txtIniCCPElevation = new System.Windows.Forms.TextBox();
               this.txtMaxCCPElevation = new System.Windows.Forms.TextBox();
               this.txtMinCCPElevation = new System.Windows.Forms.TextBox();
               this.label23 = new System.Windows.Forms.Label();
               this.txtLongCCPEasting = new System.Windows.Forms.TextBox();
               this.txtIniCCPEasting = new System.Windows.Forms.TextBox();
               this.txtMaxCCPEasting = new System.Windows.Forms.TextBox();
               this.txtMinCCPEasting = new System.Windows.Forms.TextBox();
               this.label24 = new System.Windows.Forms.Label();
               this.txtLongSeq = new System.Windows.Forms.TextBox();
               this.txtIniSeq = new System.Windows.Forms.TextBox();
               this.txtMaxSeq = new System.Windows.Forms.TextBox();
               this.txtMinSeq = new System.Windows.Forms.TextBox();
               this.label25 = new System.Windows.Forms.Label();
               this.txtlongMainInstrumentType = new System.Windows.Forms.TextBox();
               this.txtiniMainInstrumentType = new System.Windows.Forms.TextBox();
               this.txtmaxMainInstrumentType = new System.Windows.Forms.TextBox();
               this.txtminMainInstrumentType = new System.Windows.Forms.TextBox();
               this.label26 = new System.Windows.Forms.Label();
               this.time = new System.Windows.Forms.Label();
               ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
               this.statusStrip1.SuspendLayout();
               this.SuspendLayout();
               // 
               // openFileDialog1
               // 
               this.openFileDialog1.FileName = "openFileDialog1";
               this.openFileDialog1.Filter = "Supported files|*.txt;*.xls;*.xlsx;*.xlsb;*.csv|xls|*.xls|xlsx|*.xlsx|xlsb|*.xlsb" +
    "|csv|*.csv|All|*.*";
               // 
               // button1
               // 
               this.button1.Location = new System.Drawing.Point(334, 5);
               this.button1.Margin = new System.Windows.Forms.Padding(2);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(66, 21);
               this.button1.TabIndex = 0;
               this.button1.Text = "Selecciona txt";
               this.button1.UseVisualStyleBackColor = true;
               this.button1.Click += new System.EventHandler(this.Button1Click);
               // 
               // textBox1
               // 
               this.textBox1.Location = new System.Drawing.Point(46, 6);
               this.textBox1.Margin = new System.Windows.Forms.Padding(2);
               this.textBox1.Name = "textBox1";
               this.textBox1.Size = new System.Drawing.Size(283, 20);
               this.textBox1.TabIndex = 1;
               // 
               // dataSet1
               // 
               this.dataSet1.DataSetName = "NewDataSet";
               // 
               // Sheet
               // 
               this.Sheet.AutoSize = true;
               this.Sheet.Location = new System.Drawing.Point(12, 92);
               this.Sheet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.Sheet.Name = "Sheet";
               this.Sheet.Size = new System.Drawing.Size(126, 13);
               this.Sheet.TabIndex = 5;
               this.Sheet.Text = "Comenzar desde la Linea";
               // 
               // statusStrip1
               // 
               this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
               this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
               this.statusStrip1.Location = new System.Drawing.Point(0, 693);
               this.statusStrip1.Name = "statusStrip1";
               this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
               this.statusStrip1.Size = new System.Drawing.Size(713, 22);
               this.statusStrip1.TabIndex = 7;
               this.statusStrip1.Text = "statusStrip1";
               // 
               // toolStripStatusLabel1
               // 
               this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
               this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(12, 9);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(30, 13);
               this.label1.TabIndex = 8;
               this.label1.Text = "Ruta";
               // 
               // txtMaxSourcePoint
               // 
               this.txtMaxSourcePoint.Location = new System.Drawing.Point(334, 251);
               this.txtMaxSourcePoint.Margin = new System.Windows.Forms.Padding(2);
               this.txtMaxSourcePoint.Name = "txtMaxSourcePoint";
               this.txtMaxSourcePoint.Size = new System.Drawing.Size(66, 20);
               this.txtMaxSourcePoint.TabIndex = 29;
               // 
               // txtmaxcmp
               // 
               this.txtmaxcmp.Location = new System.Drawing.Point(334, 203);
               this.txtmaxcmp.Margin = new System.Windows.Forms.Padding(2);
               this.txtmaxcmp.Name = "txtmaxcmp";
               this.txtmaxcmp.Size = new System.Drawing.Size(66, 20);
               this.txtmaxcmp.TabIndex = 28;
               // 
               // txtmaxFieldFileNumber
               // 
               this.txtmaxFieldFileNumber.Location = new System.Drawing.Point(334, 179);
               this.txtmaxFieldFileNumber.Margin = new System.Windows.Forms.Padding(2);
               this.txtmaxFieldFileNumber.Name = "txtmaxFieldFileNumber";
               this.txtmaxFieldFileNumber.Size = new System.Drawing.Size(66, 20);
               this.txtmaxFieldFileNumber.TabIndex = 27;
               // 
               // txtMinSourcePoint
               // 
               this.txtMinSourcePoint.Location = new System.Drawing.Point(264, 251);
               this.txtMinSourcePoint.Margin = new System.Windows.Forms.Padding(2);
               this.txtMinSourcePoint.Name = "txtMinSourcePoint";
               this.txtMinSourcePoint.Size = new System.Drawing.Size(66, 20);
               this.txtMinSourcePoint.TabIndex = 26;
               // 
               // txtmincmp
               // 
               this.txtmincmp.Location = new System.Drawing.Point(264, 203);
               this.txtmincmp.Margin = new System.Windows.Forms.Padding(2);
               this.txtmincmp.Name = "txtmincmp";
               this.txtmincmp.Size = new System.Drawing.Size(66, 20);
               this.txtmincmp.TabIndex = 25;
               // 
               // txtminFieldFileNumber
               // 
               this.txtminFieldFileNumber.Location = new System.Drawing.Point(264, 179);
               this.txtminFieldFileNumber.Margin = new System.Windows.Forms.Padding(2);
               this.txtminFieldFileNumber.Name = "txtminFieldFileNumber";
               this.txtminFieldFileNumber.Size = new System.Drawing.Size(66, 20);
               this.txtminFieldFileNumber.TabIndex = 24;
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Location = new System.Drawing.Point(14, 255);
               this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(67, 13);
               this.label5.TabIndex = 23;
               this.label5.Text = "Source point";
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Location = new System.Drawing.Point(14, 207);
               this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(30, 13);
               this.label4.TabIndex = 22;
               this.label4.Text = "CMP";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Location = new System.Drawing.Point(14, 183);
               this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(83, 13);
               this.label3.TabIndex = 21;
               this.label3.Text = "Field file number";
               // 
               // button3
               // 
               this.button3.Location = new System.Drawing.Point(15, 46);
               this.button3.Margin = new System.Windows.Forms.Padding(2);
               this.button3.Name = "button3";
               this.button3.Size = new System.Drawing.Size(73, 29);
               this.button3.TabIndex = 30;
               this.button3.Text = "Leer TXT";
               this.button3.UseVisualStyleBackColor = true;
               this.button3.Click += new System.EventHandler(this.button3_Click);
               // 
               // label6
               // 
               this.label6.AutoSize = true;
               this.label6.Location = new System.Drawing.Point(277, 127);
               this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(24, 13);
               this.label6.TabIndex = 31;
               this.label6.Text = "Min";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(344, 127);
               this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(27, 13);
               this.label2.TabIndex = 32;
               this.label2.Text = "Max";
               // 
               // txtstart
               // 
               this.txtstart.Location = new System.Drawing.Point(142, 85);
               this.txtstart.Margin = new System.Windows.Forms.Padding(2);
               this.txtstart.Name = "txtstart";
               this.txtstart.Size = new System.Drawing.Size(66, 20);
               this.txtstart.TabIndex = 33;
               // 
               // label7
               // 
               this.label7.AutoSize = true;
               this.label7.Location = new System.Drawing.Point(157, 127);
               this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label7.Name = "label7";
               this.label7.Size = new System.Drawing.Size(48, 13);
               this.label7.TabIndex = 41;
               this.label7.Text = "Longitud";
               // 
               // label8
               // 
               this.label8.AutoSize = true;
               this.label8.Location = new System.Drawing.Point(75, 127);
               this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label8.Name = "label8";
               this.label8.Size = new System.Drawing.Size(78, 13);
               this.label8.TabIndex = 40;
               this.label8.Text = "Columna Inicial";
               // 
               // txtlongSourcePoint
               // 
               this.txtlongSourcePoint.Location = new System.Drawing.Point(160, 251);
               this.txtlongSourcePoint.Margin = new System.Windows.Forms.Padding(2);
               this.txtlongSourcePoint.Name = "txtlongSourcePoint";
               this.txtlongSourcePoint.Size = new System.Drawing.Size(35, 20);
               this.txtlongSourcePoint.TabIndex = 39;
               // 
               // txtlongcmp
               // 
               this.txtlongcmp.Location = new System.Drawing.Point(160, 203);
               this.txtlongcmp.Margin = new System.Windows.Forms.Padding(2);
               this.txtlongcmp.Name = "txtlongcmp";
               this.txtlongcmp.Size = new System.Drawing.Size(35, 20);
               this.txtlongcmp.TabIndex = 38;
               // 
               // txtlongFieldFileNumber
               // 
               this.txtlongFieldFileNumber.Location = new System.Drawing.Point(160, 180);
               this.txtlongFieldFileNumber.Margin = new System.Windows.Forms.Padding(2);
               this.txtlongFieldFileNumber.Name = "txtlongFieldFileNumber";
               this.txtlongFieldFileNumber.Size = new System.Drawing.Size(35, 20);
               this.txtlongFieldFileNumber.TabIndex = 37;
               // 
               // txtIniSourcePoint
               // 
               this.txtIniSourcePoint.Location = new System.Drawing.Point(114, 251);
               this.txtIniSourcePoint.Margin = new System.Windows.Forms.Padding(2);
               this.txtIniSourcePoint.Name = "txtIniSourcePoint";
               this.txtIniSourcePoint.Size = new System.Drawing.Size(32, 20);
               this.txtIniSourcePoint.TabIndex = 36;
               // 
               // txtInicmp
               // 
               this.txtInicmp.Location = new System.Drawing.Point(114, 203);
               this.txtInicmp.Margin = new System.Windows.Forms.Padding(2);
               this.txtInicmp.Name = "txtInicmp";
               this.txtInicmp.Size = new System.Drawing.Size(32, 20);
               this.txtInicmp.TabIndex = 35;
               // 
               // txtIniFieldFileNumber
               // 
               this.txtIniFieldFileNumber.Location = new System.Drawing.Point(114, 179);
               this.txtIniFieldFileNumber.Margin = new System.Windows.Forms.Padding(2);
               this.txtIniFieldFileNumber.Name = "txtIniFieldFileNumber";
               this.txtIniFieldFileNumber.Size = new System.Drawing.Size(32, 20);
               this.txtIniFieldFileNumber.TabIndex = 34;
               // 
               // txtLongTraceType
               // 
               this.txtLongTraceType.Location = new System.Drawing.Point(160, 227);
               this.txtLongTraceType.Margin = new System.Windows.Forms.Padding(2);
               this.txtLongTraceType.Name = "txtLongTraceType";
               this.txtLongTraceType.Size = new System.Drawing.Size(35, 20);
               this.txtLongTraceType.TabIndex = 46;
               // 
               // txtIniTraceType
               // 
               this.txtIniTraceType.Location = new System.Drawing.Point(114, 227);
               this.txtIniTraceType.Margin = new System.Windows.Forms.Padding(2);
               this.txtIniTraceType.Name = "txtIniTraceType";
               this.txtIniTraceType.Size = new System.Drawing.Size(32, 20);
               this.txtIniTraceType.TabIndex = 45;
               // 
               // txtMaxTraceType
               // 
               this.txtMaxTraceType.Location = new System.Drawing.Point(334, 227);
               this.txtMaxTraceType.Margin = new System.Windows.Forms.Padding(2);
               this.txtMaxTraceType.Name = "txtMaxTraceType";
               this.txtMaxTraceType.Size = new System.Drawing.Size(66, 20);
               this.txtMaxTraceType.TabIndex = 44;
               // 
               // txtMinTraceType
               // 
               this.txtMinTraceType.Location = new System.Drawing.Point(264, 227);
               this.txtMinTraceType.Margin = new System.Windows.Forms.Padding(2);
               this.txtMinTraceType.Name = "txtMinTraceType";
               this.txtMinTraceType.Size = new System.Drawing.Size(66, 20);
               this.txtMinTraceType.TabIndex = 43;
               // 
               // label9
               // 
               this.label9.AutoSize = true;
               this.label9.Location = new System.Drawing.Point(14, 231);
               this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label9.Name = "label9";
               this.label9.Size = new System.Drawing.Size(58, 13);
               this.label9.TabIndex = 42;
               this.label9.Text = "Trace type";
               // 
               // txtLongCmp1
               // 
               this.txtLongCmp1.Location = new System.Drawing.Point(160, 275);
               this.txtLongCmp1.Margin = new System.Windows.Forms.Padding(2);
               this.txtLongCmp1.Name = "txtLongCmp1";
               this.txtLongCmp1.Size = new System.Drawing.Size(35, 20);
               this.txtLongCmp1.TabIndex = 51;
               // 
               // txtIniCmp1
               // 
               this.txtIniCmp1.Location = new System.Drawing.Point(114, 275);
               this.txtIniCmp1.Margin = new System.Windows.Forms.Padding(2);
               this.txtIniCmp1.Name = "txtIniCmp1";
               this.txtIniCmp1.Size = new System.Drawing.Size(32, 20);
               this.txtIniCmp1.TabIndex = 50;
               // 
               // txtMaxCmp1
               // 
               this.txtMaxCmp1.Location = new System.Drawing.Point(334, 275);
               this.txtMaxCmp1.Margin = new System.Windows.Forms.Padding(2);
               this.txtMaxCmp1.Name = "txtMaxCmp1";
               this.txtMaxCmp1.Size = new System.Drawing.Size(66, 20);
               this.txtMaxCmp1.TabIndex = 49;
               // 
               // txtMinCmp1
               // 
               this.txtMinCmp1.Location = new System.Drawing.Point(264, 275);
               this.txtMinCmp1.Margin = new System.Windows.Forms.Padding(2);
               this.txtMinCmp1.Name = "txtMinCmp1";
               this.txtMinCmp1.Size = new System.Drawing.Size(66, 20);
               this.txtMinCmp1.TabIndex = 48;
               // 
               // label10
               // 
               this.label10.AutoSize = true;
               this.label10.Location = new System.Drawing.Point(14, 279);
               this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label10.Name = "label10";
               this.label10.Size = new System.Drawing.Size(30, 13);
               this.label10.TabIndex = 47;
               this.label10.Text = "CMP";
               // 
               // txtLongOffset
               // 
               this.txtLongOffset.Location = new System.Drawing.Point(160, 299);
               this.txtLongOffset.Margin = new System.Windows.Forms.Padding(2);
               this.txtLongOffset.Name = "txtLongOffset";
               this.txtLongOffset.Size = new System.Drawing.Size(35, 20);
               this.txtLongOffset.TabIndex = 56;
               // 
               // txtIniOffset
               // 
               this.txtIniOffset.Location = new System.Drawing.Point(114, 299);
               this.txtIniOffset.Margin = new System.Windows.Forms.Padding(2);
               this.txtIniOffset.Name = "txtIniOffset";
               this.txtIniOffset.Size = new System.Drawing.Size(32, 20);
               this.txtIniOffset.TabIndex = 55;
               // 
               // txtMaxOffset
               // 
               this.txtMaxOffset.Location = new System.Drawing.Point(334, 299);
               this.txtMaxOffset.Margin = new System.Windows.Forms.Padding(2);
               this.txtMaxOffset.Name = "txtMaxOffset";
               this.txtMaxOffset.Size = new System.Drawing.Size(66, 20);
               this.txtMaxOffset.TabIndex = 54;
               // 
               // txtMinOffset
               // 
               this.txtMinOffset.Location = new System.Drawing.Point(264, 299);
               this.txtMinOffset.Margin = new System.Windows.Forms.Padding(2);
               this.txtMinOffset.Name = "txtMinOffset";
               this.txtMinOffset.Size = new System.Drawing.Size(66, 20);
               this.txtMinOffset.TabIndex = 53;
               // 
               // label11
               // 
               this.label11.AutoSize = true;
               this.label11.Location = new System.Drawing.Point(14, 303);
               this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label11.Name = "label11";
               this.label11.Size = new System.Drawing.Size(35, 13);
               this.label11.TabIndex = 52;
               this.label11.Text = "Offset";
               // 
               // txtLongSourceX
               // 
               this.txtLongSourceX.Location = new System.Drawing.Point(159, 324);
               this.txtLongSourceX.Margin = new System.Windows.Forms.Padding(2);
               this.txtLongSourceX.Name = "txtLongSourceX";
               this.txtLongSourceX.Size = new System.Drawing.Size(35, 20);
               this.txtLongSourceX.TabIndex = 61;
               // 
               // txtIniSourceX
               // 
               this.txtIniSourceX.Location = new System.Drawing.Point(113, 324);
               this.txtIniSourceX.Margin = new System.Windows.Forms.Padding(2);
               this.txtIniSourceX.Name = "txtIniSourceX";
               this.txtIniSourceX.Size = new System.Drawing.Size(32, 20);
               this.txtIniSourceX.TabIndex = 60;
               // 
               // txtMaxSourceX
               // 
               this.txtMaxSourceX.Location = new System.Drawing.Point(333, 324);
               this.txtMaxSourceX.Margin = new System.Windows.Forms.Padding(2);
               this.txtMaxSourceX.Name = "txtMaxSourceX";
               this.txtMaxSourceX.Size = new System.Drawing.Size(66, 20);
               this.txtMaxSourceX.TabIndex = 59;
               // 
               // txtMinSourceX
               // 
               this.txtMinSourceX.Location = new System.Drawing.Point(263, 324);
               this.txtMinSourceX.Margin = new System.Windows.Forms.Padding(2);
               this.txtMinSourceX.Name = "txtMinSourceX";
               this.txtMinSourceX.Size = new System.Drawing.Size(66, 20);
               this.txtMinSourceX.TabIndex = 58;
               // 
               // label12
               // 
               this.label12.AutoSize = true;
               this.label12.Location = new System.Drawing.Point(13, 328);
               this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label12.Name = "label12";
               this.label12.Size = new System.Drawing.Size(51, 13);
               this.label12.TabIndex = 57;
               this.label12.Text = "Source X";
               // 
               // txtLongSourceY
               // 
               this.txtLongSourceY.Location = new System.Drawing.Point(159, 348);
               this.txtLongSourceY.Margin = new System.Windows.Forms.Padding(2);
               this.txtLongSourceY.Name = "txtLongSourceY";
               this.txtLongSourceY.Size = new System.Drawing.Size(35, 20);
               this.txtLongSourceY.TabIndex = 66;
               // 
               // txtIniSourceY
               // 
               this.txtIniSourceY.Location = new System.Drawing.Point(113, 348);
               this.txtIniSourceY.Margin = new System.Windows.Forms.Padding(2);
               this.txtIniSourceY.Name = "txtIniSourceY";
               this.txtIniSourceY.Size = new System.Drawing.Size(32, 20);
               this.txtIniSourceY.TabIndex = 65;
               // 
               // txtMaxSourceY
               // 
               this.txtMaxSourceY.Location = new System.Drawing.Point(333, 348);
               this.txtMaxSourceY.Margin = new System.Windows.Forms.Padding(2);
               this.txtMaxSourceY.Name = "txtMaxSourceY";
               this.txtMaxSourceY.Size = new System.Drawing.Size(66, 20);
               this.txtMaxSourceY.TabIndex = 64;
               // 
               // txtMinSourceY
               // 
               this.txtMinSourceY.Location = new System.Drawing.Point(263, 348);
               this.txtMinSourceY.Margin = new System.Windows.Forms.Padding(2);
               this.txtMinSourceY.Name = "txtMinSourceY";
               this.txtMinSourceY.Size = new System.Drawing.Size(66, 20);
               this.txtMinSourceY.TabIndex = 63;
               // 
               // label13
               // 
               this.label13.AutoSize = true;
               this.label13.Location = new System.Drawing.Point(13, 352);
               this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label13.Name = "label13";
               this.label13.Size = new System.Drawing.Size(51, 13);
               this.label13.TabIndex = 62;
               this.label13.Text = "Source Y";
               // 
               // txtLongReceiverX
               // 
               this.txtLongReceiverX.Location = new System.Drawing.Point(159, 372);
               this.txtLongReceiverX.Margin = new System.Windows.Forms.Padding(2);
               this.txtLongReceiverX.Name = "txtLongReceiverX";
               this.txtLongReceiverX.Size = new System.Drawing.Size(35, 20);
               this.txtLongReceiverX.TabIndex = 71;
               // 
               // txtIniReceiverX
               // 
               this.txtIniReceiverX.Location = new System.Drawing.Point(113, 372);
               this.txtIniReceiverX.Margin = new System.Windows.Forms.Padding(2);
               this.txtIniReceiverX.Name = "txtIniReceiverX";
               this.txtIniReceiverX.Size = new System.Drawing.Size(32, 20);
               this.txtIniReceiverX.TabIndex = 70;
               // 
               // txtMaxReceiverX
               // 
               this.txtMaxReceiverX.Location = new System.Drawing.Point(333, 372);
               this.txtMaxReceiverX.Margin = new System.Windows.Forms.Padding(2);
               this.txtMaxReceiverX.Name = "txtMaxReceiverX";
               this.txtMaxReceiverX.Size = new System.Drawing.Size(66, 20);
               this.txtMaxReceiverX.TabIndex = 69;
               // 
               // txtMinReceiverX
               // 
               this.txtMinReceiverX.Location = new System.Drawing.Point(263, 372);
               this.txtMinReceiverX.Margin = new System.Windows.Forms.Padding(2);
               this.txtMinReceiverX.Name = "txtMinReceiverX";
               this.txtMinReceiverX.Size = new System.Drawing.Size(66, 20);
               this.txtMinReceiverX.TabIndex = 68;
               // 
               // label14
               // 
               this.label14.AutoSize = true;
               this.label14.Location = new System.Drawing.Point(13, 376);
               this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label14.Name = "label14";
               this.label14.Size = new System.Drawing.Size(60, 13);
               this.label14.TabIndex = 67;
               this.label14.Text = "Receiver X";
               // 
               // txtLongReceiverY
               // 
               this.txtLongReceiverY.Location = new System.Drawing.Point(159, 395);
               this.txtLongReceiverY.Margin = new System.Windows.Forms.Padding(2);
               this.txtLongReceiverY.Name = "txtLongReceiverY";
               this.txtLongReceiverY.Size = new System.Drawing.Size(35, 20);
               this.txtLongReceiverY.TabIndex = 76;
               // 
               // txtIniReceiverY
               // 
               this.txtIniReceiverY.Location = new System.Drawing.Point(113, 395);
               this.txtIniReceiverY.Margin = new System.Windows.Forms.Padding(2);
               this.txtIniReceiverY.Name = "txtIniReceiverY";
               this.txtIniReceiverY.Size = new System.Drawing.Size(32, 20);
               this.txtIniReceiverY.TabIndex = 75;
               // 
               // txtMaxReceiverY
               // 
               this.txtMaxReceiverY.Location = new System.Drawing.Point(333, 395);
               this.txtMaxReceiverY.Margin = new System.Windows.Forms.Padding(2);
               this.txtMaxReceiverY.Name = "txtMaxReceiverY";
               this.txtMaxReceiverY.Size = new System.Drawing.Size(66, 20);
               this.txtMaxReceiverY.TabIndex = 74;
               // 
               // txtMinReceiverY
               // 
               this.txtMinReceiverY.Location = new System.Drawing.Point(263, 395);
               this.txtMinReceiverY.Margin = new System.Windows.Forms.Padding(2);
               this.txtMinReceiverY.Name = "txtMinReceiverY";
               this.txtMinReceiverY.Size = new System.Drawing.Size(66, 20);
               this.txtMinReceiverY.TabIndex = 73;
               // 
               // label15
               // 
               this.label15.AutoSize = true;
               this.label15.Location = new System.Drawing.Point(13, 399);
               this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label15.Name = "label15";
               this.label15.Size = new System.Drawing.Size(60, 13);
               this.label15.TabIndex = 72;
               this.label15.Text = "Receiver Y";
               // 
               // txtLongSourceStation
               // 
               this.txtLongSourceStation.Location = new System.Drawing.Point(159, 418);
               this.txtLongSourceStation.Margin = new System.Windows.Forms.Padding(2);
               this.txtLongSourceStation.Name = "txtLongSourceStation";
               this.txtLongSourceStation.Size = new System.Drawing.Size(35, 20);
               this.txtLongSourceStation.TabIndex = 81;
               // 
               // txtIniSourceStation
               // 
               this.txtIniSourceStation.Location = new System.Drawing.Point(113, 418);
               this.txtIniSourceStation.Margin = new System.Windows.Forms.Padding(2);
               this.txtIniSourceStation.Name = "txtIniSourceStation";
               this.txtIniSourceStation.Size = new System.Drawing.Size(32, 20);
               this.txtIniSourceStation.TabIndex = 80;
               // 
               // txtMaxSourceStation
               // 
               this.txtMaxSourceStation.Location = new System.Drawing.Point(333, 418);
               this.txtMaxSourceStation.Margin = new System.Windows.Forms.Padding(2);
               this.txtMaxSourceStation.Name = "txtMaxSourceStation";
               this.txtMaxSourceStation.Size = new System.Drawing.Size(66, 20);
               this.txtMaxSourceStation.TabIndex = 79;
               // 
               // txtMinSourceStation
               // 
               this.txtMinSourceStation.Location = new System.Drawing.Point(263, 418);
               this.txtMinSourceStation.Margin = new System.Windows.Forms.Padding(2);
               this.txtMinSourceStation.Name = "txtMinSourceStation";
               this.txtMinSourceStation.Size = new System.Drawing.Size(66, 20);
               this.txtMinSourceStation.TabIndex = 78;
               // 
               // label16
               // 
               this.label16.AutoSize = true;
               this.label16.Location = new System.Drawing.Point(13, 422);
               this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label16.Name = "label16";
               this.label16.Size = new System.Drawing.Size(75, 13);
               this.label16.TabIndex = 77;
               this.label16.Text = "Source station";
               // 
               // txtLongComponetType
               // 
               this.txtLongComponetType.Location = new System.Drawing.Point(159, 442);
               this.txtLongComponetType.Margin = new System.Windows.Forms.Padding(2);
               this.txtLongComponetType.Name = "txtLongComponetType";
               this.txtLongComponetType.Size = new System.Drawing.Size(35, 20);
               this.txtLongComponetType.TabIndex = 86;
               // 
               // txtIniComponetType
               // 
               this.txtIniComponetType.Location = new System.Drawing.Point(113, 442);
               this.txtIniComponetType.Margin = new System.Windows.Forms.Padding(2);
               this.txtIniComponetType.Name = "txtIniComponetType";
               this.txtIniComponetType.Size = new System.Drawing.Size(32, 20);
               this.txtIniComponetType.TabIndex = 85;
               // 
               // txtMaxComponetType
               // 
               this.txtMaxComponetType.Location = new System.Drawing.Point(333, 442);
               this.txtMaxComponetType.Margin = new System.Windows.Forms.Padding(2);
               this.txtMaxComponetType.Name = "txtMaxComponetType";
               this.txtMaxComponetType.Size = new System.Drawing.Size(66, 20);
               this.txtMaxComponetType.TabIndex = 84;
               // 
               // txtMinComponetType
               // 
               this.txtMinComponetType.Location = new System.Drawing.Point(263, 442);
               this.txtMinComponetType.Margin = new System.Windows.Forms.Padding(2);
               this.txtMinComponetType.Name = "txtMinComponetType";
               this.txtMinComponetType.Size = new System.Drawing.Size(66, 20);
               this.txtMinComponetType.TabIndex = 83;
               // 
               // label17
               // 
               this.label17.AutoSize = true;
               this.label17.Location = new System.Drawing.Point(13, 446);
               this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label17.Name = "label17";
               this.label17.Size = new System.Drawing.Size(84, 13);
               this.label17.TabIndex = 82;
               this.label17.Text = "Component type";
               // 
               // txtLongMainSourceType
               // 
               this.txtLongMainSourceType.Location = new System.Drawing.Point(159, 466);
               this.txtLongMainSourceType.Margin = new System.Windows.Forms.Padding(2);
               this.txtLongMainSourceType.Name = "txtLongMainSourceType";
               this.txtLongMainSourceType.Size = new System.Drawing.Size(35, 20);
               this.txtLongMainSourceType.TabIndex = 91;
               // 
               // txtIniMainSourceType
               // 
               this.txtIniMainSourceType.Location = new System.Drawing.Point(113, 466);
               this.txtIniMainSourceType.Margin = new System.Windows.Forms.Padding(2);
               this.txtIniMainSourceType.Name = "txtIniMainSourceType";
               this.txtIniMainSourceType.Size = new System.Drawing.Size(32, 20);
               this.txtIniMainSourceType.TabIndex = 90;
               // 
               // txtMaxMainSourceType
               // 
               this.txtMaxMainSourceType.Location = new System.Drawing.Point(333, 466);
               this.txtMaxMainSourceType.Margin = new System.Windows.Forms.Padding(2);
               this.txtMaxMainSourceType.Name = "txtMaxMainSourceType";
               this.txtMaxMainSourceType.Size = new System.Drawing.Size(66, 20);
               this.txtMaxMainSourceType.TabIndex = 89;
               // 
               // txtMinMainSourceType
               // 
               this.txtMinMainSourceType.Location = new System.Drawing.Point(263, 466);
               this.txtMinMainSourceType.Margin = new System.Windows.Forms.Padding(2);
               this.txtMinMainSourceType.Name = "txtMinMainSourceType";
               this.txtMinMainSourceType.Size = new System.Drawing.Size(66, 20);
               this.txtMinMainSourceType.TabIndex = 88;
               // 
               // label18
               // 
               this.label18.AutoSize = true;
               this.label18.Location = new System.Drawing.Point(13, 470);
               this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label18.Name = "label18";
               this.label18.Size = new System.Drawing.Size(88, 13);
               this.label18.TabIndex = 87;
               this.label18.Text = "Main source type";
               // 
               // txtLongCmpX
               // 
               this.txtLongCmpX.Location = new System.Drawing.Point(159, 514);
               this.txtLongCmpX.Margin = new System.Windows.Forms.Padding(2);
               this.txtLongCmpX.Name = "txtLongCmpX";
               this.txtLongCmpX.Size = new System.Drawing.Size(35, 20);
               this.txtLongCmpX.TabIndex = 96;
               // 
               // txtIniCmpX
               // 
               this.txtIniCmpX.Location = new System.Drawing.Point(113, 514);
               this.txtIniCmpX.Margin = new System.Windows.Forms.Padding(2);
               this.txtIniCmpX.Name = "txtIniCmpX";
               this.txtIniCmpX.Size = new System.Drawing.Size(32, 20);
               this.txtIniCmpX.TabIndex = 95;
               // 
               // txtMaxCmpX
               // 
               this.txtMaxCmpX.Location = new System.Drawing.Point(333, 514);
               this.txtMaxCmpX.Margin = new System.Windows.Forms.Padding(2);
               this.txtMaxCmpX.Name = "txtMaxCmpX";
               this.txtMaxCmpX.Size = new System.Drawing.Size(66, 20);
               this.txtMaxCmpX.TabIndex = 94;
               // 
               // txtMinCmpX
               // 
               this.txtMinCmpX.Location = new System.Drawing.Point(263, 514);
               this.txtMinCmpX.Margin = new System.Windows.Forms.Padding(2);
               this.txtMinCmpX.Name = "txtMinCmpX";
               this.txtMinCmpX.Size = new System.Drawing.Size(66, 20);
               this.txtMinCmpX.TabIndex = 93;
               // 
               // label19
               // 
               this.label19.AutoSize = true;
               this.label19.Location = new System.Drawing.Point(13, 518);
               this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label19.Name = "label19";
               this.label19.Size = new System.Drawing.Size(40, 13);
               this.label19.TabIndex = 92;
               this.label19.Text = "CMP X";
               // 
               // txtLongCmpY
               // 
               this.txtLongCmpY.Location = new System.Drawing.Point(160, 538);
               this.txtLongCmpY.Margin = new System.Windows.Forms.Padding(2);
               this.txtLongCmpY.Name = "txtLongCmpY";
               this.txtLongCmpY.Size = new System.Drawing.Size(35, 20);
               this.txtLongCmpY.TabIndex = 101;
               // 
               // txtIniCmpY
               // 
               this.txtIniCmpY.Location = new System.Drawing.Point(114, 538);
               this.txtIniCmpY.Margin = new System.Windows.Forms.Padding(2);
               this.txtIniCmpY.Name = "txtIniCmpY";
               this.txtIniCmpY.Size = new System.Drawing.Size(32, 20);
               this.txtIniCmpY.TabIndex = 100;
               // 
               // txtMaxCmpY
               // 
               this.txtMaxCmpY.Location = new System.Drawing.Point(334, 538);
               this.txtMaxCmpY.Margin = new System.Windows.Forms.Padding(2);
               this.txtMaxCmpY.Name = "txtMaxCmpY";
               this.txtMaxCmpY.Size = new System.Drawing.Size(66, 20);
               this.txtMaxCmpY.TabIndex = 99;
               // 
               // txtMinCmpY
               // 
               this.txtMinCmpY.Location = new System.Drawing.Point(264, 538);
               this.txtMinCmpY.Margin = new System.Windows.Forms.Padding(2);
               this.txtMinCmpY.Name = "txtMinCmpY";
               this.txtMinCmpY.Size = new System.Drawing.Size(66, 20);
               this.txtMinCmpY.TabIndex = 98;
               // 
               // label20
               // 
               this.label20.AutoSize = true;
               this.label20.Location = new System.Drawing.Point(14, 542);
               this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label20.Name = "label20";
               this.label20.Size = new System.Drawing.Size(40, 13);
               this.label20.TabIndex = 97;
               this.label20.Text = "CMP Y";
               // 
               // txtLongFold
               // 
               this.txtLongFold.Location = new System.Drawing.Point(159, 562);
               this.txtLongFold.Margin = new System.Windows.Forms.Padding(2);
               this.txtLongFold.Name = "txtLongFold";
               this.txtLongFold.Size = new System.Drawing.Size(35, 20);
               this.txtLongFold.TabIndex = 106;
               // 
               // txtIniFold
               // 
               this.txtIniFold.Location = new System.Drawing.Point(113, 562);
               this.txtIniFold.Margin = new System.Windows.Forms.Padding(2);
               this.txtIniFold.Name = "txtIniFold";
               this.txtIniFold.Size = new System.Drawing.Size(32, 20);
               this.txtIniFold.TabIndex = 105;
               // 
               // txtMaxFold
               // 
               this.txtMaxFold.Location = new System.Drawing.Point(333, 562);
               this.txtMaxFold.Margin = new System.Windows.Forms.Padding(2);
               this.txtMaxFold.Name = "txtMaxFold";
               this.txtMaxFold.Size = new System.Drawing.Size(66, 20);
               this.txtMaxFold.TabIndex = 104;
               // 
               // txtMinFold
               // 
               this.txtMinFold.Location = new System.Drawing.Point(263, 562);
               this.txtMinFold.Margin = new System.Windows.Forms.Padding(2);
               this.txtMinFold.Name = "txtMinFold";
               this.txtMinFold.Size = new System.Drawing.Size(66, 20);
               this.txtMinFold.TabIndex = 103;
               // 
               // label21
               // 
               this.label21.AutoSize = true;
               this.label21.Location = new System.Drawing.Point(13, 566);
               this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label21.Name = "label21";
               this.label21.Size = new System.Drawing.Size(27, 13);
               this.label21.TabIndex = 102;
               this.label21.Text = "Fold";
               // 
               // txtLongCCPNorthing
               // 
               this.txtLongCCPNorthing.Location = new System.Drawing.Point(159, 586);
               this.txtLongCCPNorthing.Margin = new System.Windows.Forms.Padding(2);
               this.txtLongCCPNorthing.Name = "txtLongCCPNorthing";
               this.txtLongCCPNorthing.Size = new System.Drawing.Size(35, 20);
               this.txtLongCCPNorthing.TabIndex = 111;
               // 
               // txtIniCCPNorthing
               // 
               this.txtIniCCPNorthing.Location = new System.Drawing.Point(113, 586);
               this.txtIniCCPNorthing.Margin = new System.Windows.Forms.Padding(2);
               this.txtIniCCPNorthing.Name = "txtIniCCPNorthing";
               this.txtIniCCPNorthing.Size = new System.Drawing.Size(32, 20);
               this.txtIniCCPNorthing.TabIndex = 110;
               // 
               // txtMaxCCPNorthing
               // 
               this.txtMaxCCPNorthing.Location = new System.Drawing.Point(333, 586);
               this.txtMaxCCPNorthing.Margin = new System.Windows.Forms.Padding(2);
               this.txtMaxCCPNorthing.Name = "txtMaxCCPNorthing";
               this.txtMaxCCPNorthing.Size = new System.Drawing.Size(66, 20);
               this.txtMaxCCPNorthing.TabIndex = 109;
               // 
               // txtMinCCPNorthing
               // 
               this.txtMinCCPNorthing.Location = new System.Drawing.Point(263, 586);
               this.txtMinCCPNorthing.Margin = new System.Windows.Forms.Padding(2);
               this.txtMinCCPNorthing.Name = "txtMinCCPNorthing";
               this.txtMinCCPNorthing.Size = new System.Drawing.Size(66, 20);
               this.txtMinCCPNorthing.TabIndex = 108;
               // 
               // label22
               // 
               this.label22.AutoSize = true;
               this.label22.Location = new System.Drawing.Point(13, 590);
               this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label22.Name = "label22";
               this.label22.Size = new System.Drawing.Size(71, 13);
               this.label22.TabIndex = 107;
               this.label22.Text = "CCP Northing";
               // 
               // txtLongCCPElevation
               // 
               this.txtLongCCPElevation.Location = new System.Drawing.Point(159, 610);
               this.txtLongCCPElevation.Margin = new System.Windows.Forms.Padding(2);
               this.txtLongCCPElevation.Name = "txtLongCCPElevation";
               this.txtLongCCPElevation.Size = new System.Drawing.Size(35, 20);
               this.txtLongCCPElevation.TabIndex = 116;
               // 
               // txtIniCCPElevation
               // 
               this.txtIniCCPElevation.Location = new System.Drawing.Point(113, 610);
               this.txtIniCCPElevation.Margin = new System.Windows.Forms.Padding(2);
               this.txtIniCCPElevation.Name = "txtIniCCPElevation";
               this.txtIniCCPElevation.Size = new System.Drawing.Size(32, 20);
               this.txtIniCCPElevation.TabIndex = 115;
               // 
               // txtMaxCCPElevation
               // 
               this.txtMaxCCPElevation.Location = new System.Drawing.Point(333, 610);
               this.txtMaxCCPElevation.Margin = new System.Windows.Forms.Padding(2);
               this.txtMaxCCPElevation.Name = "txtMaxCCPElevation";
               this.txtMaxCCPElevation.Size = new System.Drawing.Size(66, 20);
               this.txtMaxCCPElevation.TabIndex = 114;
               // 
               // txtMinCCPElevation
               // 
               this.txtMinCCPElevation.Location = new System.Drawing.Point(263, 610);
               this.txtMinCCPElevation.Margin = new System.Windows.Forms.Padding(2);
               this.txtMinCCPElevation.Name = "txtMinCCPElevation";
               this.txtMinCCPElevation.Size = new System.Drawing.Size(66, 20);
               this.txtMinCCPElevation.TabIndex = 113;
               // 
               // label23
               // 
               this.label23.AutoSize = true;
               this.label23.Location = new System.Drawing.Point(13, 614);
               this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label23.Name = "label23";
               this.label23.Size = new System.Drawing.Size(74, 13);
               this.label23.TabIndex = 112;
               this.label23.Text = "CCP elevation";
               // 
               // txtLongCCPEasting
               // 
               this.txtLongCCPEasting.Location = new System.Drawing.Point(159, 634);
               this.txtLongCCPEasting.Margin = new System.Windows.Forms.Padding(2);
               this.txtLongCCPEasting.Name = "txtLongCCPEasting";
               this.txtLongCCPEasting.Size = new System.Drawing.Size(35, 20);
               this.txtLongCCPEasting.TabIndex = 121;
               // 
               // txtIniCCPEasting
               // 
               this.txtIniCCPEasting.Location = new System.Drawing.Point(113, 634);
               this.txtIniCCPEasting.Margin = new System.Windows.Forms.Padding(2);
               this.txtIniCCPEasting.Name = "txtIniCCPEasting";
               this.txtIniCCPEasting.Size = new System.Drawing.Size(32, 20);
               this.txtIniCCPEasting.TabIndex = 120;
               // 
               // txtMaxCCPEasting
               // 
               this.txtMaxCCPEasting.Location = new System.Drawing.Point(333, 634);
               this.txtMaxCCPEasting.Margin = new System.Windows.Forms.Padding(2);
               this.txtMaxCCPEasting.Name = "txtMaxCCPEasting";
               this.txtMaxCCPEasting.Size = new System.Drawing.Size(66, 20);
               this.txtMaxCCPEasting.TabIndex = 119;
               // 
               // txtMinCCPEasting
               // 
               this.txtMinCCPEasting.Location = new System.Drawing.Point(263, 634);
               this.txtMinCCPEasting.Margin = new System.Windows.Forms.Padding(2);
               this.txtMinCCPEasting.Name = "txtMinCCPEasting";
               this.txtMinCCPEasting.Size = new System.Drawing.Size(66, 20);
               this.txtMinCCPEasting.TabIndex = 118;
               // 
               // label24
               // 
               this.label24.AutoSize = true;
               this.label24.Location = new System.Drawing.Point(13, 638);
               this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label24.Name = "label24";
               this.label24.Size = new System.Drawing.Size(66, 13);
               this.label24.TabIndex = 117;
               this.label24.Text = "CCP Easting";
               // 
               // txtLongSeq
               // 
               this.txtLongSeq.Location = new System.Drawing.Point(159, 156);
               this.txtLongSeq.Margin = new System.Windows.Forms.Padding(2);
               this.txtLongSeq.Name = "txtLongSeq";
               this.txtLongSeq.Size = new System.Drawing.Size(35, 20);
               this.txtLongSeq.TabIndex = 126;
               // 
               // txtIniSeq
               // 
               this.txtIniSeq.Location = new System.Drawing.Point(113, 155);
               this.txtIniSeq.Margin = new System.Windows.Forms.Padding(2);
               this.txtIniSeq.Name = "txtIniSeq";
               this.txtIniSeq.Size = new System.Drawing.Size(32, 20);
               this.txtIniSeq.TabIndex = 125;
               // 
               // txtMaxSeq
               // 
               this.txtMaxSeq.Location = new System.Drawing.Point(333, 155);
               this.txtMaxSeq.Margin = new System.Windows.Forms.Padding(2);
               this.txtMaxSeq.Name = "txtMaxSeq";
               this.txtMaxSeq.Size = new System.Drawing.Size(66, 20);
               this.txtMaxSeq.TabIndex = 124;
               // 
               // txtMinSeq
               // 
               this.txtMinSeq.Location = new System.Drawing.Point(263, 155);
               this.txtMinSeq.Margin = new System.Windows.Forms.Padding(2);
               this.txtMinSeq.Name = "txtMinSeq";
               this.txtMinSeq.Size = new System.Drawing.Size(66, 20);
               this.txtMinSeq.TabIndex = 123;
               // 
               // label25
               // 
               this.label25.AutoSize = true;
               this.label25.Location = new System.Drawing.Point(13, 159);
               this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label25.Name = "label25";
               this.label25.Size = new System.Drawing.Size(26, 13);
               this.label25.TabIndex = 122;
               this.label25.Text = "Seq";
               this.label25.Click += new System.EventHandler(this.label25_Click);
               // 
               // txtlongMainInstrumentType
               // 
               this.txtlongMainInstrumentType.Location = new System.Drawing.Point(159, 490);
               this.txtlongMainInstrumentType.Margin = new System.Windows.Forms.Padding(2);
               this.txtlongMainInstrumentType.Name = "txtlongMainInstrumentType";
               this.txtlongMainInstrumentType.Size = new System.Drawing.Size(35, 20);
               this.txtlongMainInstrumentType.TabIndex = 131;
               // 
               // txtiniMainInstrumentType
               // 
               this.txtiniMainInstrumentType.Location = new System.Drawing.Point(113, 490);
               this.txtiniMainInstrumentType.Margin = new System.Windows.Forms.Padding(2);
               this.txtiniMainInstrumentType.Name = "txtiniMainInstrumentType";
               this.txtiniMainInstrumentType.Size = new System.Drawing.Size(32, 20);
               this.txtiniMainInstrumentType.TabIndex = 130;
               // 
               // txtmaxMainInstrumentType
               // 
               this.txtmaxMainInstrumentType.Location = new System.Drawing.Point(333, 490);
               this.txtmaxMainInstrumentType.Margin = new System.Windows.Forms.Padding(2);
               this.txtmaxMainInstrumentType.Name = "txtmaxMainInstrumentType";
               this.txtmaxMainInstrumentType.Size = new System.Drawing.Size(66, 20);
               this.txtmaxMainInstrumentType.TabIndex = 129;
               // 
               // txtminMainInstrumentType
               // 
               this.txtminMainInstrumentType.Location = new System.Drawing.Point(263, 490);
               this.txtminMainInstrumentType.Margin = new System.Windows.Forms.Padding(2);
               this.txtminMainInstrumentType.Name = "txtminMainInstrumentType";
               this.txtminMainInstrumentType.Size = new System.Drawing.Size(66, 20);
               this.txtminMainInstrumentType.TabIndex = 128;
               // 
               // label26
               // 
               this.label26.AutoSize = true;
               this.label26.Location = new System.Drawing.Point(13, 494);
               this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label26.Name = "label26";
               this.label26.Size = new System.Drawing.Size(105, 13);
               this.label26.TabIndex = 127;
               this.label26.Text = "Main Instrument type";
               // 
               // time
               // 
               this.time.AutoSize = true;
               this.time.Location = new System.Drawing.Point(111, 670);
               this.time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.time.Name = "time";
               this.time.Size = new System.Drawing.Size(0, 13);
               this.time.TabIndex = 132;
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(713, 715);
               this.Controls.Add(this.time);
               this.Controls.Add(this.txtlongMainInstrumentType);
               this.Controls.Add(this.txtiniMainInstrumentType);
               this.Controls.Add(this.txtmaxMainInstrumentType);
               this.Controls.Add(this.txtminMainInstrumentType);
               this.Controls.Add(this.label26);
               this.Controls.Add(this.txtLongSeq);
               this.Controls.Add(this.txtIniSeq);
               this.Controls.Add(this.txtMaxSeq);
               this.Controls.Add(this.txtMinSeq);
               this.Controls.Add(this.label25);
               this.Controls.Add(this.txtLongCCPEasting);
               this.Controls.Add(this.txtIniCCPEasting);
               this.Controls.Add(this.txtMaxCCPEasting);
               this.Controls.Add(this.txtMinCCPEasting);
               this.Controls.Add(this.label24);
               this.Controls.Add(this.txtLongCCPElevation);
               this.Controls.Add(this.txtIniCCPElevation);
               this.Controls.Add(this.txtMaxCCPElevation);
               this.Controls.Add(this.txtMinCCPElevation);
               this.Controls.Add(this.label23);
               this.Controls.Add(this.txtLongCCPNorthing);
               this.Controls.Add(this.txtIniCCPNorthing);
               this.Controls.Add(this.txtMaxCCPNorthing);
               this.Controls.Add(this.txtMinCCPNorthing);
               this.Controls.Add(this.label22);
               this.Controls.Add(this.txtLongFold);
               this.Controls.Add(this.txtIniFold);
               this.Controls.Add(this.txtMaxFold);
               this.Controls.Add(this.txtMinFold);
               this.Controls.Add(this.label21);
               this.Controls.Add(this.txtLongCmpY);
               this.Controls.Add(this.txtIniCmpY);
               this.Controls.Add(this.txtMaxCmpY);
               this.Controls.Add(this.txtMinCmpY);
               this.Controls.Add(this.label20);
               this.Controls.Add(this.txtLongCmpX);
               this.Controls.Add(this.txtIniCmpX);
               this.Controls.Add(this.txtMaxCmpX);
               this.Controls.Add(this.txtMinCmpX);
               this.Controls.Add(this.label19);
               this.Controls.Add(this.txtLongMainSourceType);
               this.Controls.Add(this.txtIniMainSourceType);
               this.Controls.Add(this.txtMaxMainSourceType);
               this.Controls.Add(this.txtMinMainSourceType);
               this.Controls.Add(this.label18);
               this.Controls.Add(this.txtLongComponetType);
               this.Controls.Add(this.txtIniComponetType);
               this.Controls.Add(this.txtMaxComponetType);
               this.Controls.Add(this.txtMinComponetType);
               this.Controls.Add(this.label17);
               this.Controls.Add(this.txtLongSourceStation);
               this.Controls.Add(this.txtIniSourceStation);
               this.Controls.Add(this.txtMaxSourceStation);
               this.Controls.Add(this.txtMinSourceStation);
               this.Controls.Add(this.label16);
               this.Controls.Add(this.txtLongReceiverY);
               this.Controls.Add(this.txtIniReceiverY);
               this.Controls.Add(this.txtMaxReceiverY);
               this.Controls.Add(this.txtMinReceiverY);
               this.Controls.Add(this.label15);
               this.Controls.Add(this.txtLongReceiverX);
               this.Controls.Add(this.txtIniReceiverX);
               this.Controls.Add(this.txtMaxReceiverX);
               this.Controls.Add(this.txtMinReceiverX);
               this.Controls.Add(this.label14);
               this.Controls.Add(this.txtLongSourceY);
               this.Controls.Add(this.txtIniSourceY);
               this.Controls.Add(this.txtMaxSourceY);
               this.Controls.Add(this.txtMinSourceY);
               this.Controls.Add(this.label13);
               this.Controls.Add(this.txtLongSourceX);
               this.Controls.Add(this.txtIniSourceX);
               this.Controls.Add(this.txtMaxSourceX);
               this.Controls.Add(this.txtMinSourceX);
               this.Controls.Add(this.label12);
               this.Controls.Add(this.txtLongOffset);
               this.Controls.Add(this.txtIniOffset);
               this.Controls.Add(this.txtMaxOffset);
               this.Controls.Add(this.txtMinOffset);
               this.Controls.Add(this.label11);
               this.Controls.Add(this.txtLongCmp1);
               this.Controls.Add(this.txtIniCmp1);
               this.Controls.Add(this.txtMaxCmp1);
               this.Controls.Add(this.txtMinCmp1);
               this.Controls.Add(this.label10);
               this.Controls.Add(this.txtLongTraceType);
               this.Controls.Add(this.txtIniTraceType);
               this.Controls.Add(this.txtMaxTraceType);
               this.Controls.Add(this.txtMinTraceType);
               this.Controls.Add(this.label9);
               this.Controls.Add(this.label7);
               this.Controls.Add(this.label8);
               this.Controls.Add(this.txtlongSourcePoint);
               this.Controls.Add(this.txtlongcmp);
               this.Controls.Add(this.txtlongFieldFileNumber);
               this.Controls.Add(this.txtIniSourcePoint);
               this.Controls.Add(this.txtInicmp);
               this.Controls.Add(this.txtIniFieldFileNumber);
               this.Controls.Add(this.txtstart);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label6);
               this.Controls.Add(this.button3);
               this.Controls.Add(this.txtMaxSourcePoint);
               this.Controls.Add(this.txtmaxcmp);
               this.Controls.Add(this.txtmaxFieldFileNumber);
               this.Controls.Add(this.txtMinSourcePoint);
               this.Controls.Add(this.txtmincmp);
               this.Controls.Add(this.txtminFieldFileNumber);
               this.Controls.Add(this.label5);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.statusStrip1);
               this.Controls.Add(this.Sheet);
               this.Controls.Add(this.textBox1);
               this.Controls.Add(this.button1);
               this.Margin = new System.Windows.Forms.Padding(2);
               this.Name = "Form1";
               this.Text = "Maximos y Minimos";
               ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
               this.statusStrip1.ResumeLayout(false);
               this.statusStrip1.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.Label Sheet;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Label label1;
        private TextBox txtMaxSourcePoint;
        private TextBox txtmaxcmp;
        private TextBox txtmaxFieldFileNumber;
        private TextBox txtMinSourcePoint;
        private TextBox txtmincmp;
        private TextBox txtminFieldFileNumber;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button3;
        private Label label6;
        private Label label2;
        private TextBox txtstart;
        private Label label7;
        private Label label8;
        private TextBox txtlongSourcePoint;
        private TextBox txtlongcmp;
        private TextBox txtlongFieldFileNumber;
        private TextBox txtIniSourcePoint;
        private TextBox txtInicmp;
        private TextBox txtIniFieldFileNumber;
        private TextBox txtLongTraceType;
        private TextBox txtIniTraceType;
        private TextBox txtMaxTraceType;
        private TextBox txtMinTraceType;
        private Label label9;
        private TextBox txtLongCmp1;
        private TextBox txtIniCmp1;
        private TextBox txtMaxCmp1;
        private TextBox txtMinCmp1;
        private Label label10;
        private TextBox txtLongOffset;
        private TextBox txtIniOffset;
        private TextBox txtMaxOffset;
        private TextBox txtMinOffset;
        private Label label11;
        private TextBox txtLongSourceX;
        private TextBox txtIniSourceX;
        private TextBox txtMaxSourceX;
        private TextBox txtMinSourceX;
        private Label label12;
        private TextBox txtLongSourceY;
        private TextBox txtIniSourceY;
        private TextBox txtMaxSourceY;
        private TextBox txtMinSourceY;
        private Label label13;
        private TextBox txtLongReceiverX;
        private TextBox txtIniReceiverX;
        private TextBox txtMaxReceiverX;
        private TextBox txtMinReceiverX;
        private Label label14;
        private TextBox txtLongReceiverY;
        private TextBox txtIniReceiverY;
        private TextBox txtMaxReceiverY;
        private TextBox txtMinReceiverY;
        private Label label15;
        private TextBox txtLongSourceStation;
        private TextBox txtIniSourceStation;
        private TextBox txtMaxSourceStation;
        private TextBox txtMinSourceStation;
        private Label label16;
        private TextBox txtLongComponetType;
        private TextBox txtIniComponetType;
        private TextBox txtMaxComponetType;
        private TextBox txtMinComponetType;
        private Label label17;
        private TextBox txtLongMainSourceType;
        private TextBox txtIniMainSourceType;
        private TextBox txtMaxMainSourceType;
        private TextBox txtMinMainSourceType;
        private Label label18;
        private TextBox txtLongCmpX;
        private TextBox txtIniCmpX;
        private TextBox txtMaxCmpX;
        private TextBox txtMinCmpX;
        private Label label19;
        private TextBox txtLongCmpY;
        private TextBox txtIniCmpY;
        private TextBox txtMaxCmpY;
        private TextBox txtMinCmpY;
        private Label label20;
        private TextBox txtLongFold;
        private TextBox txtIniFold;
        private TextBox txtMaxFold;
        private TextBox txtMinFold;
        private Label label21;
        private TextBox txtLongCCPNorthing;
        private TextBox txtIniCCPNorthing;
        private TextBox txtMaxCCPNorthing;
        private TextBox txtMinCCPNorthing;
        private Label label22;
        private TextBox txtLongCCPElevation;
        private TextBox txtIniCCPElevation;
        private TextBox txtMaxCCPElevation;
        private TextBox txtMinCCPElevation;
        private Label label23;
        private TextBox txtLongCCPEasting;
        private TextBox txtIniCCPEasting;
        private TextBox txtMaxCCPEasting;
        private TextBox txtMinCCPEasting;
        private Label label24;
        private TextBox txtLongSeq;
        private TextBox txtIniSeq;
        private TextBox txtMaxSeq;
        private TextBox txtMinSeq;
        private Label label25;
        private TextBox txtlongMainInstrumentType;
        private TextBox txtiniMainInstrumentType;
        private TextBox txtmaxMainInstrumentType;
        private TextBox txtminMainInstrumentType;
        private Label label26;
        private Label time;
        private DataSet ds;

              

        public Form1()
        {
            InitializeComponent();
            txtIniSeq.Text = Settings1.Default.userInputtxtIniSeq;
            txtLongSeq.Text = Settings1.Default.userInputtxtLongSeq;

            txtIniFieldFileNumber.Text = Settings1.Default.userInputtxtIniFieldFileNumber;
            txtlongFieldFileNumber.Text = Settings1.Default.userInputtxtLongFieldFileNumber;

            txtInicmp.Text = Settings1.Default.userInputtxtInicmp;
            txtlongcmp.Text = Settings1.Default.userInputtxtlongcmp;

            txtIniTraceType.Text = Settings1.Default.userInputtxtIniTraceType;
            txtLongTraceType.Text = Settings1.Default.userInputtxtLongTraceType;

            txtIniSourcePoint.Text = Settings1.Default.userInputtxtIniSourcePoint;
            txtlongSourcePoint.Text = Settings1.Default.userInputtxtlongSourcePoint;

            txtIniCmp1.Text = Settings1.Default.userInputtxtIniCmp1;
            txtLongCmp1.Text = Settings1.Default.userInputtxtLongCmp1;

            txtIniOffset.Text = Settings1.Default.userInputtxtIniOffset;
            txtLongOffset.Text = Settings1.Default.userInputtxtLongOffset;

            txtIniSourceX.Text = Settings1.Default.userInputtxtIniSourceX;
            txtLongSourceX.Text = Settings1.Default.userInputtxtLongSourceX;

            txtIniSourceY.Text = Settings1.Default.userInputtxtIniSourceY;
            txtLongSourceY.Text = Settings1.Default.userInputtxtLongSourceY;

            txtIniReceiverX.Text = Settings1.Default.userInputtxtIniReceiverX;
            txtLongReceiverX.Text = Settings1.Default.userInputtxtLongReceiverX;

            txtIniReceiverY.Text = Settings1.Default.userInputtxtIniReceiverY;
            txtLongReceiverY.Text = Settings1.Default.userInputtxtLongReceiverY;


            txtIniSourceStation.Text = Settings1.Default.userInputtxtIniSourceStation;
            txtLongSourceStation.Text = Settings1.Default.userInputtxtLongSourceStation;

            txtIniComponetType.Text = Settings1.Default.userInputtxtIniComponetType;
            txtLongComponetType.Text = Settings1.Default.userInputtxtLongComponetType;

            txtIniMainSourceType.Text = Settings1.Default.userInputtxtIniMainSourceType;
            txtLongMainSourceType.Text = Settings1.Default.userInputtxtLongMainSourceType;

            txtiniMainInstrumentType.Text = Settings1.Default.userInputtxtiniMainInstrumentType;
            txtlongMainInstrumentType.Text = Settings1.Default.userInputtxtlongMainInstrumentType;

            txtIniCmpX.Text = Settings1.Default.userInputtxtIniCmpX;
            txtLongCmpX.Text = Settings1.Default.userInputtxtLongCmpX;

            txtIniCmpY.Text = Settings1.Default.userInputtxtIniCmpY;
            txtLongCmpY.Text = Settings1.Default.userInputtxtLongCmpY;

            txtIniFold.Text = Settings1.Default.userInputtxtIniFold;
            txtLongFold.Text = Settings1.Default.userInputtxtLongFold;

            txtIniCCPNorthing.Text = Settings1.Default.userInputtxtIniCCPNorthing;
            txtLongCCPNorthing.Text = Settings1.Default.userInputtxtLongCCPNorthing;

            txtIniCCPElevation.Text = Settings1.Default.userInputtxtIniCCPElevation;
            txtLongCCPElevation.Text = Settings1.Default.userInputtxtLongCCPElevation;

            txtIniCCPEasting.Text = Settings1.Default.userInputtxtIniCCPEasting;
            txtLongCCPEasting.Text = Settings1.Default.userInputtxtLongCCPEasting;

            txtstart.Text = Settings1.Default.userInputtxtstart;



        }

        /*
        public static void GetValues(DataSet dataset, string sheetName)
        {
            foreach (DataRow row in dataset.Tables[sheetName].Rows)
            {
                foreach (var value in row.ItemArray)
                {
                    Console.WriteLine("{0}, {1}", value, value.GetType());
                }
            }
        }
        */

        private static IList<string> GetTablenames(DataTableCollection tables)
        {
            var tableList = new List<string>();
            foreach (var table in tables)
            {
                tableList.Add(table.ToString());
            }

            return tableList;
        }

        private void Button1Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void Button2Click(object sender, EventArgs e)
        {
            try
            {
                using var stream = new FileStream(textBox1.Text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

                var sw = new Stopwatch();
                sw.Start();

                using IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream);

                var openTiming = sw.ElapsedMilliseconds;
                // reader.IsFirstRowAsColumnNames = firstRowNamesCheckBox.Checked;
                ds = reader.AsDataSet(new ExcelDataSetConfiguration()
                {
                    UseColumnDataType = false,
                    ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                    {
                        //UseHeaderRow = firstRowNamesCheckBox.Checked
                    }
                });

                toolStripStatusLabel1.Text = "Elapsed: " + sw.ElapsedMilliseconds.ToString() + " ms (" + openTiming.ToString() + " ms to open)";

                var tablenames = GetTablenames(ds.Tables);
                //sheetCombo.DataSource = tablenames;

                //if (tablenames.Count > 0)
                    //sheetCombo.SelectedIndex = 0;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SelectTable()
        {
            //var tablename = sheetCombo.SelectedItem.ToString();

            //dataGridView1.AutoGenerateColumns = true;
            //dataGridView1.DataSource = ds; // dataset
            //dataGridView1.DataMember = tablename;

            // GetValues(ds, tablename);
        }

        private void SheetComboSelectedIndexChanged(object sender, EventArgs e)
        {
            SelectTable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                
                using (var reader = new System.IO.StreamReader(textBox1.Text))
                {
                    var sw = new Stopwatch();
                    sw.Start();

                    var openTiming = sw.ElapsedMilliseconds;

                    var dt = new DataTable();
                    dt.Columns.Add("Seq", typeof(int));
                    dt.Columns.Add("Field file number", typeof(int));
                    dt.Columns.Add("CMP", typeof(int));
                    dt.Columns.Add("Trace type", typeof(int));
                    dt.Columns.Add("Source point", typeof(double));
                    dt.Columns.Add("CMP1", typeof(int));
                    dt.Columns.Add("Offset", typeof(double));
                    dt.Columns.Add("Source X", typeof(double));
                    dt.Columns.Add("Source Y", typeof(double));                                       
                    dt.Columns.Add("Receiver X", typeof(double));
                    dt.Columns.Add("Receiver Y", typeof(double));
                    dt.Columns.Add("Source station", typeof(int));
                    dt.Columns.Add("Component type", typeof(int));
                    dt.Columns.Add("Main source type", typeof(int));
                    dt.Columns.Add("Main instrument type", typeof(int));
                    dt.Columns.Add("CMP X", typeof(double));
                    dt.Columns.Add("CMP Y", typeof(double));
                    dt.Columns.Add("Fold", typeof(int));
                    dt.Columns.Add("CCP Northing", typeof(double));
                    dt.Columns.Add("CCP elevation", typeof(double));
                    dt.Columns.Add("CCP Easting", typeof(double));

                    obtenercolumnas();
                    int startingLine = int.Parse(txtstart.Text);
                    for (int i = 1; i < startingLine; i++)
                    {
                        // Leer y descartar las líneas antes de la línea deseada
                        reader.ReadLine();
                    }

                   
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();

                        // Extraer los valores de cada columna utilizando Substring
                        var coltrazaSecuencial = line.Substring(int.Parse(txtIniSeq.Text), int.Parse(txtLongSeq.Text));
                        var colFieldfilenumber = line.Substring(int.Parse(txtIniFieldFileNumber.Text), int.Parse(txtlongFieldFileNumber.Text));
                        var colCMP = line.Substring(int.Parse(txtInicmp.Text), int.Parse(txtlongcmp.Text));
                        var colTracetype = line.Substring(int.Parse(txtIniTraceType.Text), int.Parse(txtLongTraceType.Text));
                        var colSourcepoint = line.Substring(int.Parse(txtIniSourcePoint.Text), int.Parse(txtlongSourcePoint.Text));
                        var colCMP1 = line.Substring(int.Parse(txtIniCmp1.Text), int.Parse(txtLongCmp1.Text));
                        var colOffset = line.Substring(int.Parse(txtIniOffset.Text), int.Parse(txtLongOffset.Text));
                        var colSourceX = line.Substring(int.Parse(txtIniSourceX.Text), int.Parse(txtLongSourceX.Text));
                        var colSourceY = line.Substring(int.Parse(txtIniSourceY.Text), int.Parse(txtLongSourceY.Text));
                        var colReceiverX = line.Substring(int.Parse(txtIniReceiverX.Text), int.Parse(txtLongReceiverX.Text));
                        var colReceiverY = line.Substring(int.Parse(txtIniReceiverY.Text), int.Parse(txtLongReceiverY.Text));
                        var colSourcestation = line.Substring(int.Parse(txtIniSourceStation.Text), int.Parse(txtLongSourceStation.Text));
                        var colComponenttype = line.Substring(int.Parse(txtIniComponetType.Text), int.Parse(txtLongComponetType.Text));
                        var colMainsourcetype = line.Substring(int.Parse(txtIniMainSourceType.Text), int.Parse(txtLongMainSourceType.Text));
                        var colMaininstrumenttype = line.Substring(int.Parse(txtiniMainInstrumentType.Text), int.Parse(txtlongMainInstrumentType.Text));
                        var colCMPX = line.Substring(int.Parse(txtIniCmpX.Text), int.Parse(txtLongCmpX.Text));
                        var colCMPY = line.Substring(int.Parse(txtIniCmpY.Text), int.Parse(txtLongCmpY.Text));
                        var colFold = line.Substring(int.Parse(txtIniFold.Text), int.Parse(txtLongFold.Text));
                        var colCCPNorthing = line.Substring(int.Parse(txtIniCCPNorthing.Text), int.Parse(txtLongCCPNorthing.Text));
                        var colCCPelevation = line.Substring(int.Parse(txtIniCCPElevation.Text), int.Parse(txtLongCCPElevation.Text));
                        var colCCPEasting = line.Substring(int.Parse(txtIniCCPEasting.Text), int.Parse(txtLongCCPEasting.Text));

                        // Crear un nuevo arreglo con los valores extraídos y agregarlos al DataTable
                        var values = new string[] { coltrazaSecuencial, colFieldfilenumber, colCMP, colTracetype, colSourcepoint, colCMP1, colOffset , colSourceX , colSourceY, colReceiverX, colReceiverY, colSourcestation , colComponenttype, colMainsourcetype,colMaininstrumenttype , colCMPX , colCMPY , colFold , colCCPNorthing, colCCPelevation, colCCPEasting };
                        dt.Rows.Add(values);
                       

                       
                    }
                    time.Text = "Elapsed: " + sw.ElapsedMilliseconds.ToString() + " ms (" + openTiming.ToString() + " ms to open)";
                    time.Text = "Elapsed: " + sw.Elapsed.TotalMinutes.ToString() + " ms (" + openTiming.ToString() + " ms to open)";
                    var columnaSeq = dt.Columns["Seq"];
                    // Obtener el valor máximo de la columna
                    var maximoSeq = dt.AsEnumerable().Max(row => row.Field<int?>(columnaSeq) ?? int.MinValue);
                    txtMaxSeq.Text = maximoSeq.ToString();
                    // Obtener el valor mínimo de la columna
                    var minimoSeq = dt.AsEnumerable().Min(row => row.Field<int?>(columnaSeq) ?? int.MaxValue);
                    txtMinSeq.Text = minimoSeq.ToString();

                    var columnaFieldfilenumber = dt.Columns["Field file number"];
                    // Obtener el valor máximo de la columna
                    var maximoFieldfilenumber = dt.AsEnumerable().Max(row => row.Field<int?>(columnaFieldfilenumber) ?? int.MinValue);
                    txtmaxFieldFileNumber.Text = maximoFieldfilenumber.ToString();
                    // Obtener el valor mínimo de la columna
                    var minimoFieldfilenumber = dt.AsEnumerable().Min(row => row.Field<int?>(columnaFieldfilenumber) ?? int.MaxValue);
                    txtminFieldFileNumber.Text = minimoFieldfilenumber.ToString();


                    var columnaCMP = dt.Columns["CMP"];
                    // Obtener el valor máximo de la columna
                    var maximoCMP = dt.AsEnumerable().Max(row => row.Field<int?>(columnaCMP) ?? int.MinValue);
                    txtmaxcmp.Text = maximoCMP.ToString();
                    // Obtener el valor mínimo de la columna
                    var minimoCMP = dt.AsEnumerable().Min(row => row.Field<int?>(columnaCMP) ?? int.MaxValue);
                    txtmincmp.Text = minimoCMP.ToString();

                    var columnaTracetype = dt.Columns["Trace type"];
                    // Obtener el valor máximo de la columna
                    var maximoTracetype = dt.AsEnumerable().Max(row => row.Field<int?>(columnaTracetype) ?? int.MinValue);
                    txtMaxTraceType.Text = maximoTracetype.ToString();
                    // Obtener el valor mínimo de la columna
                    var minimoTracetype = dt.AsEnumerable().Min(row => row.Field<int?>(columnaTracetype) ?? int.MaxValue);
                    txtMinTraceType.Text = minimoTracetype.ToString();

                    var columnaSourcepoint = dt.Columns["Source point"];
                    // Obtener el valor máximo de la columna
                    var maximoSourcepoint = dt.AsEnumerable().Max(row => row.Field<double?>(columnaSourcepoint) ?? double.MinValue);
                    txtMaxSourcePoint.Text = maximoSourcepoint.ToString();
                    // Obtener el valor mínimo de la columna
                    var minimoSourcepoint = dt.AsEnumerable().Min(row => row.Field<double?>(columnaSourcepoint) ?? double.MaxValue);
                    txtMinSourcePoint.Text = minimoSourcepoint.ToString();

                    var columnaCMP1 = dt.Columns["CMP"];
                    // Obtener el valor máximo de la columna
                    var maximoCMP1 = dt.AsEnumerable().Max(row => row.Field<int?>(columnaCMP1) ?? int.MinValue);
                    txtMaxCmp1.Text = maximoCMP.ToString();
                    // Obtener el valor mínimo de la columna
                    var minimoCMP1 = dt.AsEnumerable().Min(row => row.Field<int?>(columnaCMP1) ?? int.MaxValue);
                    txtMinCmp1.Text = minimoCMP1.ToString();

                    var columnaOffset = dt.Columns["Offset"];
                    // Obtener el valor máximo de la columna
                    var maximoOffset = dt.AsEnumerable().Max(row => row.Field<double?>(columnaOffset) ?? double.MinValue);
                    txtMaxOffset.Text = maximoOffset.ToString();
                    // Obtener el valor mínimo de la columna
                    var minimoOffset = dt.AsEnumerable().Min(row => row.Field<double?>(columnaOffset) ?? double.MaxValue);
                    txtMinOffset.Text = minimoOffset.ToString();

                    var columnaSourceX = dt.Columns["Source X"];
                    // Obtener el valor máximo de la columna
                    var maximoSourceX = dt.AsEnumerable().Max(row => row.Field<double?>(columnaSourceX) ?? double.MinValue);
                    txtMaxSourceX.Text = maximoSourceX.ToString();
                    // Obtener el valor mínimo de la columna
                    var minimoSourceX = dt.AsEnumerable().Min(row => row.Field<double?>(columnaSourceX) ?? double.MaxValue);
                    txtMinSourceX.Text = minimoSourceX.ToString();

                    var columnaSourceY = dt.Columns["Source Y"];
                    // Obtener el valor máximo de la columna
                    var maximoSourceY = dt.AsEnumerable().Max(row => row.Field<double?>(columnaSourceY) ?? double.MinValue);
                    txtMaxSourceY.Text = maximoSourceY.ToString();
                    // Obtener el valor mínimo de la columna
                    var minimoSourceY = dt.AsEnumerable().Min(row => row.Field<double?>(columnaSourceY) ?? double.MaxValue);
                    txtMinSourceY.Text = minimoSourceY.ToString();

                    var columnaReceiverX = dt.Columns["Receiver X"];
                    // Obtener el valor máximo de la columna
                    var maximoReceiverX = dt.AsEnumerable().Max(row => row.Field<double?>(columnaReceiverX) ?? double.MinValue);
                    txtMaxReceiverX.Text = maximoReceiverX.ToString();
                    // Obtener el valor mínimo de la columna
                    var minimoReceiverX = dt.AsEnumerable().Min(row => row.Field<double?>(columnaReceiverX) ?? double.MaxValue);
                    txtMinReceiverX.Text = minimoReceiverX.ToString();

                    var columnaReceiverY = dt.Columns["Receiver Y"];
                    // Obtener el valor máximo de la columna
                    var maximoReceiverY = dt.AsEnumerable().Max(row => row.Field<double?>(columnaReceiverY) ?? double.MinValue);
                    txtMaxReceiverY.Text = maximoReceiverY.ToString();
                    // Obtener el valor mínimo de la columna
                    var minimoReceiverY = dt.AsEnumerable().Min(row => row.Field<double?>(columnaReceiverY) ?? double.MaxValue);
                    txtMinReceiverY.Text = minimoReceiverY.ToString();

                    var columnaSourcestation = dt.Columns["Source station"];
                    // Obtener el valor máximo de la columna
                    var maximoSourcestation = dt.AsEnumerable().Max(row => row.Field<int?>(columnaSourcestation) ?? int.MinValue);
                    txtMaxSourceStation.Text = maximoSourcestation.ToString();
                    // Obtener el valor mínimo de la columna
                    var minimoSourcestation = dt.AsEnumerable().Min(row => row.Field<int?>(columnaSourcestation) ?? int.MaxValue);
                    txtMinSourceStation.Text = minimoSourcestation.ToString();

                    var columnaComponenttype = dt.Columns["Component type"];
                    // Obtener el valor máximo de la columna
                    var maximoComponenttype = dt.AsEnumerable().Max(row => row.Field<int?>(columnaComponenttype) ?? int.MinValue);
                    txtMaxComponetType.Text = maximoComponenttype.ToString();
                    // Obtener el valor mínimo de la columna
                    var minimoComponenttype = dt.AsEnumerable().Min(row => row.Field<int?>(columnaComponenttype) ?? int.MaxValue);
                    txtMinComponetType.Text = minimoComponenttype.ToString();

                    var columnaMainsourcetype = dt.Columns["Main source type"];
                    // Obtener el valor máximo de la columna
                    var maximoMainsourcetype = dt.AsEnumerable().Max(row => row.Field<int?>(columnaMainsourcetype) ?? int.MinValue);
                    txtMaxMainSourceType.Text = maximoMainsourcetype.ToString();
                    // Obtener el valor mínimo de la columna
                    var minimoMainsourcetype = dt.AsEnumerable().Min(row => row.Field<int?>(columnaMainsourcetype) ?? int.MaxValue);
                    txtMinMainSourceType.Text = minimoMainsourcetype.ToString();

                    var columnaMaininstrumenttype = dt.Columns["Main instrument type"];
                    // Obtener el valor máximo de la columna
                    var maximoMaininstrumenttype = dt.AsEnumerable().Max(row => row.Field<int?>(columnaMaininstrumenttype) ?? int.MinValue);
                    txtmaxMainInstrumentType.Text = maximoMaininstrumenttype.ToString();
                    // Obtener el valor mínimo de la columna
                    var minimoMaininstrumenttype = dt.AsEnumerable().Min(row => row.Field<int?>(columnaMaininstrumenttype) ?? int.MaxValue);
                    txtminMainInstrumentType.Text = minimoMaininstrumenttype.ToString();

                    var columnaCMPX = dt.Columns["CMP X"];
                    // Obtener el valor máximo de la columna
                    var maximoCMPX = dt.AsEnumerable().Max(row => row.Field<double?>(columnaCMPX) ?? double.MinValue);
                    txtMaxCmpX.Text = maximoCMPX.ToString();
                    // Obtener el valor mínimo de la columna
                    var minimoCMPX = dt.AsEnumerable().Min(row => row.Field<double?>(columnaCMPX) ?? double.MaxValue);
                    txtMinCmpX.Text = minimoCMPX.ToString();

                    var columnaCMPY = dt.Columns["CMP Y"];
                    // Obtener el valor máximo de la columna
                    var maximoCMPY = dt.AsEnumerable().Max(row => row.Field<double?>(columnaCMPY) ?? double.MinValue);
                    txtMaxCmpY.Text = maximoCMPY.ToString();
                    // Obtener el valor mínimo de la columna
                    var minimoCMPY = dt.AsEnumerable().Min(row => row.Field<double?>(columnaCMPY) ?? double.MaxValue);
                    txtMinCmpY.Text = minimoCMPY.ToString();

                    var columnaFold = dt.Columns["Fold"];
                    // Obtener el valor máximo de la columna
                    var maximoFold = dt.AsEnumerable().Max(row => row.Field<int?>(columnaFold) ?? int.MinValue);
                    txtMaxFold.Text = maximoFold.ToString();
                    // Obtener el valor mínimo de la columna
                    var minimoFold = dt.AsEnumerable().Min(row => row.Field<int?>(columnaFold) ?? int.MaxValue);
                    txtMinFold.Text = minimoFold.ToString();

                    var columnaCCPNorthing = dt.Columns["CCP Northing"];
                    // Obtener el valor máximo de la columna
                    var maximoCCPNorthing = dt.AsEnumerable().Max(row => row.Field<double?>(columnaCCPNorthing) ?? double.MinValue);
                    txtMaxCCPNorthing.Text = maximoCCPNorthing.ToString();
                    // Obtener el valor mínimo de la columna
                    var minimoCCPNorthing = dt.AsEnumerable().Min(row => row.Field<double?>(columnaCCPNorthing) ?? double.MaxValue);
                    txtMinCCPNorthing.Text = minimoCCPNorthing.ToString();

                    var columnaCCPelevation = dt.Columns["CCP elevation"];
                    // Obtener el valor máximo de la columna
                    var maximoCCPelevation = dt.AsEnumerable().Max(row => row.Field<double?>(columnaCCPelevation) ?? double.MinValue);
                    txtMaxCCPElevation.Text = maximoCCPelevation.ToString();
                    // Obtener el valor mínimo de la columna
                    var minimoCCPelevation = dt.AsEnumerable().Min(row => row.Field<double?>(columnaCCPelevation) ?? double.MaxValue);
                    txtMinCCPElevation.Text = minimoCCPelevation.ToString();

                    var columnaCCPEasting = dt.Columns["CCP Easting"];
                    // Obtener el valor máximo de la columna
                    var maximoCCPEasting = dt.AsEnumerable().Max(row => row.Field<double?>(columnaCCPEasting) ?? double.MinValue);
                    txtMaxCCPEasting.Text = maximoCCPEasting.ToString();
                    // Obtener el valor mínimo de la columna
                    var minimoCCPEasting = dt.AsEnumerable().Min(row => row.Field<double?>(columnaCCPEasting) ?? double.MaxValue);
                    txtMinCCPEasting.Text = minimoCCPEasting.ToString();
                                       
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void obtenercolumnas()
        {
            string userInputtxtIniSeq = txtIniSeq.Text;
            string userInputtxtLongSeq = txtLongSeq.Text;
            Settings1.Default.userInputtxtIniSeq = userInputtxtIniSeq;
            Settings1.Default.userInputtxtLongSeq = userInputtxtLongSeq;

            string userInputtxtIniFieldFileNumber = txtIniFieldFileNumber.Text;
            string userInputtxtLongFieldFileNumber = txtlongFieldFileNumber.Text;
            Settings1.Default.userInputtxtIniFieldFileNumber = userInputtxtIniFieldFileNumber;
            Settings1.Default.userInputtxtLongFieldFileNumber = userInputtxtLongFieldFileNumber;

            string userInputtxtInicmp = txtInicmp.Text;
            string userInputtxtlongcmp = txtlongcmp.Text;
            Settings1.Default.userInputtxtInicmp = userInputtxtInicmp;
            Settings1.Default.userInputtxtlongcmp = userInputtxtlongcmp;

            string userInputtxtIniTraceType = txtIniTraceType.Text;
            string userInputtxtLongTraceType = txtLongTraceType.Text;
            Settings1.Default.userInputtxtIniTraceType = userInputtxtIniTraceType;
            Settings1.Default.userInputtxtLongTraceType = userInputtxtLongTraceType;

            string userInputtxtIniSourcePoint = txtIniSourcePoint.Text;
            string userInputtxtlongSourcePoint = txtlongSourcePoint.Text;
            Settings1.Default.userInputtxtIniSourcePoint = userInputtxtIniSourcePoint;
            Settings1.Default.userInputtxtlongSourcePoint = userInputtxtlongSourcePoint;

            string userInputtxtIniCmp1 = txtIniCmp1.Text;
            string userInputtxtLongCmp1 = txtLongCmp1.Text;
            Settings1.Default.userInputtxtIniCmp1 = userInputtxtIniCmp1;
            Settings1.Default.userInputtxtLongCmp1 = userInputtxtLongCmp1;

            string userInputtxtIniOffset = txtIniOffset.Text;
            string userInputtxtLongOffset = txtLongOffset.Text;
            Settings1.Default.userInputtxtIniOffset = userInputtxtIniOffset;
            Settings1.Default.userInputtxtLongOffset = userInputtxtLongOffset;

            string userInputtxtIniSourceX = txtIniSourceX.Text;
            string userInputtxtLongSourceX = txtLongSourceX.Text;
            Settings1.Default.userInputtxtIniSourceX = userInputtxtIniSourceX;
            Settings1.Default.userInputtxtLongSourceX = userInputtxtLongSourceX;

            string userInputtxtIniSourceY = txtIniSourceY.Text;
            string userInputtxtLongSourceY = txtLongSourceY.Text;
            Settings1.Default.userInputtxtIniSourceY = userInputtxtIniSourceY;
            Settings1.Default.userInputtxtLongSourceY = userInputtxtLongSourceY;

            string userInputtxtIniReceiverX = txtIniReceiverX.Text;
            string userInputtxtLongReceiverX = txtLongReceiverX.Text;
            Settings1.Default.userInputtxtIniReceiverX = userInputtxtIniReceiverX;
            Settings1.Default.userInputtxtLongReceiverX = userInputtxtLongReceiverX;

            string userInputtxtIniReceiverY = txtIniReceiverY.Text;
            string userInputtxtLongReceiverY = txtLongReceiverY.Text;
            Settings1.Default.userInputtxtIniReceiverY = userInputtxtIniReceiverY;
            Settings1.Default.userInputtxtLongReceiverY = userInputtxtLongReceiverY;

            string userInputtxtIniSourceStation = txtIniSourceStation.Text;
            string userInputtxtLongSourceStation = txtLongSourceStation.Text;
            Settings1.Default.userInputtxtIniSourceStation = userInputtxtIniSourceStation;
            Settings1.Default.userInputtxtLongSourceStation = userInputtxtLongSourceStation;

            string userInputtxtIniComponetType = txtIniComponetType.Text;
            string userInputtxtLongComponetType = txtLongComponetType.Text;
            Settings1.Default.userInputtxtIniComponetType = userInputtxtIniComponetType;
            Settings1.Default.userInputtxtLongComponetType = userInputtxtLongComponetType;

            string userInputtxtIniMainSourceType = txtIniMainSourceType.Text;
            string userInputtxtLongMainSourceType = txtLongMainSourceType.Text;
            Settings1.Default.userInputtxtIniMainSourceType = userInputtxtIniMainSourceType;
            Settings1.Default.userInputtxtLongMainSourceType = userInputtxtLongMainSourceType;

            string userInputtxtiniMainInstrumentType = txtiniMainInstrumentType.Text;
            string userInputtxtlongMainInstrumentType = txtlongMainInstrumentType.Text;
            Settings1.Default.userInputtxtiniMainInstrumentType = userInputtxtiniMainInstrumentType;
            Settings1.Default.userInputtxtlongMainInstrumentType = userInputtxtlongMainInstrumentType;

            string userInputtxtIniCmpX = txtIniCmpX.Text;
            string userInputtxtLongCmpX = txtLongCmpX.Text;
            Settings1.Default.userInputtxtIniCmpX = userInputtxtIniCmpX;
            Settings1.Default.userInputtxtLongCmpX = userInputtxtLongCmpX;

            string userInputtxtIniCmpY = txtIniCmpY.Text;
            string userInputtxtLongCmpY = txtLongCmpY.Text;
            Settings1.Default.userInputtxtIniCmpY = userInputtxtIniCmpY;
            Settings1.Default.userInputtxtLongCmpY = userInputtxtLongCmpY;

            string userInputtxtIniFold = txtIniFold.Text;
            string userInputtxtLongFold = txtLongFold.Text;
            Settings1.Default.userInputtxtIniFold = userInputtxtIniFold;
            Settings1.Default.userInputtxtLongFold = userInputtxtLongFold;

            string userInputtxtIniCCPNorthing = txtIniCCPNorthing.Text;
            string userInputtxtLongCCPNorthing = txtLongCCPNorthing.Text;
            Settings1.Default.userInputtxtIniCCPNorthing = userInputtxtIniCCPNorthing;
            Settings1.Default.userInputtxtLongCCPNorthing = userInputtxtLongCCPNorthing;

            string userInputtxtIniCCPElevation = txtIniCCPElevation.Text;
            string userInputtxtLongCCPElevation = txtLongCCPElevation.Text;
            Settings1.Default.userInputtxtIniCCPElevation = userInputtxtIniCCPElevation;
            Settings1.Default.userInputtxtLongCCPElevation = userInputtxtLongCCPElevation;

            string userInputtxtIniCCPEasting = txtIniCCPEasting.Text;
            string userInputtxtLongCCPEasting = txtLongCCPEasting.Text;
            Settings1.Default.userInputtxtIniCCPEasting = userInputtxtIniCCPEasting;
            Settings1.Default.userInputtxtLongCCPEasting = userInputtxtLongCCPEasting;

            string userInputtxttxtstart = txtstart.Text;
            Settings1.Default.userInputtxtstart = userInputtxttxtstart;
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }
    }
}
