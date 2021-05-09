
namespace pomodoro_forms
{
    partial class FormPomodoro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPomodoro));
            this.nfyFinished = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabTimer = new System.Windows.Forms.TabPage();
            this.btnLongRestStart = new System.Windows.Forms.Button();
            this.lblLongRest = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLongRestSeconds = new System.Windows.Forms.TextBox();
            this.txtLongRestMinutes = new System.Windows.Forms.TextBox();
            this.txtCycles = new System.Windows.Forms.TextBox();
            this.txtCurrentCycle = new System.Windows.Forms.TextBox();
            this.txtActivityMinutes = new System.Windows.Forms.TextBox();
            this.txtActivitySeconds = new System.Windows.Forms.TextBox();
            this.txtRestSeconds = new System.Windows.Forms.TextBox();
            this.txtRestMinutes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActivityStart = new System.Windows.Forms.Button();
            this.btnRestStart = new System.Windows.Forms.Button();
            this.lblRest = new System.Windows.Forms.Label();
            this.lblActivity = new System.Windows.Forms.Label();
            this.lblActivityColon = new System.Windows.Forms.Label();
            this.lblRestColon = new System.Windows.Forms.Label();
            this.lblNotValid = new System.Windows.Forms.Label();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabDefaults = new System.Windows.Forms.TabPage();
            this.btnSet = new System.Windows.Forms.Button();
            this.lblDfLongRest = new System.Windows.Forms.Label();
            this.lblDfLongRestColon = new System.Windows.Forms.Label();
            this.txtDfLongRestSeconds = new System.Windows.Forms.TextBox();
            this.txtDfLongRestMinutes = new System.Windows.Forms.TextBox();
            this.txtDfCycles = new System.Windows.Forms.TextBox();
            this.txtDfActivityMinutes = new System.Windows.Forms.TextBox();
            this.txtDfActivitySeconds = new System.Windows.Forms.TextBox();
            this.txtDfRestSeconds = new System.Windows.Forms.TextBox();
            this.txtDfRestMinutes = new System.Windows.Forms.TextBox();
            this.lblDfCycles = new System.Windows.Forms.Label();
            this.lblDfRest = new System.Windows.Forms.Label();
            this.lblDfActivity = new System.Windows.Forms.Label();
            this.lblDfActivityColon = new System.Windows.Forms.Label();
            this.lblDfRestColon = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabTimer.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabDefaults.SuspendLayout();
            this.SuspendLayout();
            // 
            // nfyFinished
            // 
            this.nfyFinished.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.nfyFinished.BalloonTipText = "hello";
            this.nfyFinished.BalloonTipTitle = "yo";
            this.nfyFinished.Icon = ((System.Drawing.Icon)(resources.GetObject("nfyFinished.Icon")));
            this.nfyFinished.Text = "8";
            this.nfyFinished.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nfyFinished_Click);
            this.nfyFinished.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.nfyFinished_Click);
            // 
            // tabTimer
            // 
            this.tabTimer.Controls.Add(this.btnLongRestStart);
            this.tabTimer.Controls.Add(this.lblLongRest);
            this.tabTimer.Controls.Add(this.label4);
            this.tabTimer.Controls.Add(this.txtLongRestSeconds);
            this.tabTimer.Controls.Add(this.txtLongRestMinutes);
            this.tabTimer.Controls.Add(this.txtCycles);
            this.tabTimer.Controls.Add(this.txtCurrentCycle);
            this.tabTimer.Controls.Add(this.txtActivityMinutes);
            this.tabTimer.Controls.Add(this.txtActivitySeconds);
            this.tabTimer.Controls.Add(this.txtRestSeconds);
            this.tabTimer.Controls.Add(this.txtRestMinutes);
            this.tabTimer.Controls.Add(this.label2);
            this.tabTimer.Controls.Add(this.label1);
            this.tabTimer.Controls.Add(this.btnActivityStart);
            this.tabTimer.Controls.Add(this.btnRestStart);
            this.tabTimer.Controls.Add(this.lblRest);
            this.tabTimer.Controls.Add(this.lblActivity);
            this.tabTimer.Controls.Add(this.lblActivityColon);
            this.tabTimer.Controls.Add(this.lblRestColon);
            this.tabTimer.Controls.Add(this.lblNotValid);
            this.tabTimer.Location = new System.Drawing.Point(4, 22);
            this.tabTimer.Name = "tabTimer";
            this.tabTimer.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimer.Size = new System.Drawing.Size(378, 285);
            this.tabTimer.TabIndex = 0;
            this.tabTimer.Text = "Timer";
            this.tabTimer.UseVisualStyleBackColor = true;
            // 
            // btnLongRestStart
            // 
            this.btnLongRestStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLongRestStart.Location = new System.Drawing.Point(240, 148);
            this.btnLongRestStart.Name = "btnLongRestStart";
            this.btnLongRestStart.Size = new System.Drawing.Size(107, 35);
            this.btnLongRestStart.TabIndex = 19;
            this.btnLongRestStart.Text = "Start";
            this.btnLongRestStart.UseVisualStyleBackColor = true;
            this.btnLongRestStart.Click += new System.EventHandler(this.btnLongRestStart_Click);
            // 
            // lblLongRest
            // 
            this.lblLongRest.AutoSize = true;
            this.lblLongRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongRest.Location = new System.Drawing.Point(19, 153);
            this.lblLongRest.Name = "lblLongRest";
            this.lblLongRest.Size = new System.Drawing.Size(88, 24);
            this.lblLongRest.TabIndex = 21;
            this.lblLongRest.Text = "Long rest";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(165, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = ":";
            // 
            // txtLongRestSeconds
            // 
            this.txtLongRestSeconds.AcceptsTab = true;
            this.txtLongRestSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLongRestSeconds.Location = new System.Drawing.Point(184, 153);
            this.txtLongRestSeconds.Name = "txtLongRestSeconds";
            this.txtLongRestSeconds.Size = new System.Drawing.Size(41, 26);
            this.txtLongRestSeconds.TabIndex = 18;
            this.txtLongRestSeconds.Text = "00";
            // 
            // txtLongRestMinutes
            // 
            this.txtLongRestMinutes.AcceptsTab = true;
            this.txtLongRestMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLongRestMinutes.Location = new System.Drawing.Point(118, 153);
            this.txtLongRestMinutes.Name = "txtLongRestMinutes";
            this.txtLongRestMinutes.Size = new System.Drawing.Size(41, 26);
            this.txtLongRestMinutes.TabIndex = 17;
            this.txtLongRestMinutes.Text = "00";
            // 
            // txtCycles
            // 
            this.txtCycles.AcceptsTab = true;
            this.txtCycles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCycles.Location = new System.Drawing.Point(184, 210);
            this.txtCycles.Name = "txtCycles";
            this.txtCycles.Size = new System.Drawing.Size(41, 26);
            this.txtCycles.TabIndex = 14;
            this.txtCycles.Text = "0";
            // 
            // txtCurrentCycle
            // 
            this.txtCurrentCycle.AcceptsTab = true;
            this.txtCurrentCycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentCycle.Location = new System.Drawing.Point(118, 210);
            this.txtCurrentCycle.Name = "txtCurrentCycle";
            this.txtCurrentCycle.Size = new System.Drawing.Size(41, 26);
            this.txtCurrentCycle.TabIndex = 13;
            this.txtCurrentCycle.Text = "0";
            // 
            // txtActivityMinutes
            // 
            this.txtActivityMinutes.AcceptsTab = true;
            this.txtActivityMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivityMinutes.Location = new System.Drawing.Point(118, 50);
            this.txtActivityMinutes.Name = "txtActivityMinutes";
            this.txtActivityMinutes.Size = new System.Drawing.Size(41, 26);
            this.txtActivityMinutes.TabIndex = 0;
            this.txtActivityMinutes.Text = "00";
            this.txtActivityMinutes.TextChanged += new System.EventHandler(this.txtActivityMinutes_TextChanged);
            // 
            // txtActivitySeconds
            // 
            this.txtActivitySeconds.AcceptsTab = true;
            this.txtActivitySeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivitySeconds.Location = new System.Drawing.Point(184, 50);
            this.txtActivitySeconds.Name = "txtActivitySeconds";
            this.txtActivitySeconds.Size = new System.Drawing.Size(41, 26);
            this.txtActivitySeconds.TabIndex = 1;
            this.txtActivitySeconds.Text = "00";
            this.txtActivitySeconds.TextChanged += new System.EventHandler(this.txtActivitySeconds_TextChanged);
            // 
            // txtRestSeconds
            // 
            this.txtRestSeconds.AcceptsTab = true;
            this.txtRestSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRestSeconds.Location = new System.Drawing.Point(184, 112);
            this.txtRestSeconds.Name = "txtRestSeconds";
            this.txtRestSeconds.Size = new System.Drawing.Size(41, 26);
            this.txtRestSeconds.TabIndex = 4;
            this.txtRestSeconds.Text = "00";
            // 
            // txtRestMinutes
            // 
            this.txtRestMinutes.AcceptsTab = true;
            this.txtRestMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRestMinutes.Location = new System.Drawing.Point(118, 112);
            this.txtRestMinutes.Name = "txtRestMinutes";
            this.txtRestMinutes.Size = new System.Drawing.Size(41, 26);
            this.txtRestMinutes.TabIndex = 3;
            this.txtRestMinutes.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cycle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "/";
            // 
            // btnActivityStart
            // 
            this.btnActivityStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivityStart.Location = new System.Drawing.Point(240, 45);
            this.btnActivityStart.Name = "btnActivityStart";
            this.btnActivityStart.Size = new System.Drawing.Size(107, 35);
            this.btnActivityStart.TabIndex = 2;
            this.btnActivityStart.Text = "Start";
            this.btnActivityStart.UseVisualStyleBackColor = true;
            this.btnActivityStart.Click += new System.EventHandler(this.btnActivityStart_Click);
            // 
            // btnRestStart
            // 
            this.btnRestStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestStart.Location = new System.Drawing.Point(240, 107);
            this.btnRestStart.Name = "btnRestStart";
            this.btnRestStart.Size = new System.Drawing.Size(107, 35);
            this.btnRestStart.TabIndex = 5;
            this.btnRestStart.Text = "Start";
            this.btnRestStart.UseVisualStyleBackColor = true;
            this.btnRestStart.Click += new System.EventHandler(this.btnRestStart_Click);
            // 
            // lblRest
            // 
            this.lblRest.AutoSize = true;
            this.lblRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRest.Location = new System.Drawing.Point(60, 111);
            this.lblRest.Name = "lblRest";
            this.lblRest.Size = new System.Drawing.Size(47, 24);
            this.lblRest.TabIndex = 12;
            this.lblRest.Text = "Rest";
            // 
            // lblActivity
            // 
            this.lblActivity.AutoSize = true;
            this.lblActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivity.Location = new System.Drawing.Point(40, 49);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(67, 24);
            this.lblActivity.TabIndex = 11;
            this.lblActivity.Text = "Activity";
            // 
            // lblActivityColon
            // 
            this.lblActivityColon.AutoSize = true;
            this.lblActivityColon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivityColon.Location = new System.Drawing.Point(165, 53);
            this.lblActivityColon.Name = "lblActivityColon";
            this.lblActivityColon.Size = new System.Drawing.Size(13, 20);
            this.lblActivityColon.TabIndex = 6;
            this.lblActivityColon.Text = ":";
            // 
            // lblRestColon
            // 
            this.lblRestColon.AutoSize = true;
            this.lblRestColon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestColon.Location = new System.Drawing.Point(165, 115);
            this.lblRestColon.Name = "lblRestColon";
            this.lblRestColon.Size = new System.Drawing.Size(13, 20);
            this.lblRestColon.TabIndex = 10;
            this.lblRestColon.Text = ":";
            // 
            // lblNotValid
            // 
            this.lblNotValid.AutoSize = true;
            this.lblNotValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotValid.ForeColor = System.Drawing.Color.Maroon;
            this.lblNotValid.Location = new System.Drawing.Point(146, 253);
            this.lblNotValid.Name = "lblNotValid";
            this.lblNotValid.Size = new System.Drawing.Size(89, 16);
            this.lblNotValid.TabIndex = 7;
            this.lblNotValid.Text = "Input not valid";
            this.lblNotValid.Visible = false;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabTimer);
            this.tabMain.Controls.Add(this.tabDefaults);
            this.tabMain.Location = new System.Drawing.Point(12, 12);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(386, 311);
            this.tabMain.TabIndex = 14;
            // 
            // tabDefaults
            // 
            this.tabDefaults.Controls.Add(this.btnSave);
            this.tabDefaults.Controls.Add(this.btnSet);
            this.tabDefaults.Controls.Add(this.lblDfLongRest);
            this.tabDefaults.Controls.Add(this.lblDfLongRestColon);
            this.tabDefaults.Controls.Add(this.txtDfLongRestSeconds);
            this.tabDefaults.Controls.Add(this.txtDfLongRestMinutes);
            this.tabDefaults.Controls.Add(this.txtDfCycles);
            this.tabDefaults.Controls.Add(this.txtDfActivityMinutes);
            this.tabDefaults.Controls.Add(this.txtDfActivitySeconds);
            this.tabDefaults.Controls.Add(this.txtDfRestSeconds);
            this.tabDefaults.Controls.Add(this.txtDfRestMinutes);
            this.tabDefaults.Controls.Add(this.lblDfCycles);
            this.tabDefaults.Controls.Add(this.lblDfRest);
            this.tabDefaults.Controls.Add(this.lblDfActivity);
            this.tabDefaults.Controls.Add(this.lblDfActivityColon);
            this.tabDefaults.Controls.Add(this.lblDfRestColon);
            this.tabDefaults.Location = new System.Drawing.Point(4, 22);
            this.tabDefaults.Name = "tabDefaults";
            this.tabDefaults.Padding = new System.Windows.Forms.Padding(3);
            this.tabDefaults.Size = new System.Drawing.Size(378, 285);
            this.tabDefaults.TabIndex = 1;
            this.tabDefaults.Text = "Defaults";
            this.tabDefaults.UseVisualStyleBackColor = true;
            // 
            // btnSet
            // 
            this.btnSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSet.Location = new System.Drawing.Point(248, 49);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(107, 130);
            this.btnSet.TabIndex = 41;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // lblDfLongRest
            // 
            this.lblDfLongRest.AutoSize = true;
            this.lblDfLongRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDfLongRest.Location = new System.Drawing.Point(19, 153);
            this.lblDfLongRest.Name = "lblDfLongRest";
            this.lblDfLongRest.Size = new System.Drawing.Size(88, 24);
            this.lblDfLongRest.TabIndex = 40;
            this.lblDfLongRest.Text = "Long rest";
            // 
            // lblDfLongRestColon
            // 
            this.lblDfLongRestColon.AutoSize = true;
            this.lblDfLongRestColon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDfLongRestColon.Location = new System.Drawing.Point(165, 156);
            this.lblDfLongRestColon.Name = "lblDfLongRestColon";
            this.lblDfLongRestColon.Size = new System.Drawing.Size(13, 20);
            this.lblDfLongRestColon.TabIndex = 39;
            this.lblDfLongRestColon.Text = ":";
            // 
            // txtDfLongRestSeconds
            // 
            this.txtDfLongRestSeconds.AcceptsTab = true;
            this.txtDfLongRestSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDfLongRestSeconds.Location = new System.Drawing.Point(184, 153);
            this.txtDfLongRestSeconds.Name = "txtDfLongRestSeconds";
            this.txtDfLongRestSeconds.Size = new System.Drawing.Size(41, 26);
            this.txtDfLongRestSeconds.TabIndex = 37;
            this.txtDfLongRestSeconds.Text = "00";
            // 
            // txtDfLongRestMinutes
            // 
            this.txtDfLongRestMinutes.AcceptsTab = true;
            this.txtDfLongRestMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDfLongRestMinutes.Location = new System.Drawing.Point(118, 153);
            this.txtDfLongRestMinutes.Name = "txtDfLongRestMinutes";
            this.txtDfLongRestMinutes.Size = new System.Drawing.Size(41, 26);
            this.txtDfLongRestMinutes.TabIndex = 36;
            this.txtDfLongRestMinutes.Text = "00";
            // 
            // txtDfCycles
            // 
            this.txtDfCycles.AcceptsTab = true;
            this.txtDfCycles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDfCycles.Location = new System.Drawing.Point(118, 210);
            this.txtDfCycles.Name = "txtDfCycles";
            this.txtDfCycles.Size = new System.Drawing.Size(41, 26);
            this.txtDfCycles.TabIndex = 32;
            this.txtDfCycles.Text = "0";
            // 
            // txtDfActivityMinutes
            // 
            this.txtDfActivityMinutes.AcceptsTab = true;
            this.txtDfActivityMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDfActivityMinutes.Location = new System.Drawing.Point(118, 50);
            this.txtDfActivityMinutes.Name = "txtDfActivityMinutes";
            this.txtDfActivityMinutes.Size = new System.Drawing.Size(41, 26);
            this.txtDfActivityMinutes.TabIndex = 22;
            this.txtDfActivityMinutes.Text = "00";
            // 
            // txtDfActivitySeconds
            // 
            this.txtDfActivitySeconds.AcceptsTab = true;
            this.txtDfActivitySeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDfActivitySeconds.Location = new System.Drawing.Point(184, 50);
            this.txtDfActivitySeconds.Name = "txtDfActivitySeconds";
            this.txtDfActivitySeconds.Size = new System.Drawing.Size(41, 26);
            this.txtDfActivitySeconds.TabIndex = 23;
            this.txtDfActivitySeconds.Text = "00";
            // 
            // txtDfRestSeconds
            // 
            this.txtDfRestSeconds.AcceptsTab = true;
            this.txtDfRestSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDfRestSeconds.Location = new System.Drawing.Point(184, 112);
            this.txtDfRestSeconds.Name = "txtDfRestSeconds";
            this.txtDfRestSeconds.Size = new System.Drawing.Size(41, 26);
            this.txtDfRestSeconds.TabIndex = 26;
            this.txtDfRestSeconds.Text = "00";
            // 
            // txtDfRestMinutes
            // 
            this.txtDfRestMinutes.AcceptsTab = true;
            this.txtDfRestMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDfRestMinutes.Location = new System.Drawing.Point(118, 112);
            this.txtDfRestMinutes.Name = "txtDfRestMinutes";
            this.txtDfRestMinutes.Size = new System.Drawing.Size(41, 26);
            this.txtDfRestMinutes.TabIndex = 25;
            this.txtDfRestMinutes.Text = "00";
            // 
            // lblDfCycles
            // 
            this.lblDfCycles.AutoSize = true;
            this.lblDfCycles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDfCycles.Location = new System.Drawing.Point(41, 210);
            this.lblDfCycles.Name = "lblDfCycles";
            this.lblDfCycles.Size = new System.Drawing.Size(66, 24);
            this.lblDfCycles.TabIndex = 35;
            this.lblDfCycles.Text = "Cycles";
            // 
            // lblDfRest
            // 
            this.lblDfRest.AutoSize = true;
            this.lblDfRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDfRest.Location = new System.Drawing.Point(60, 111);
            this.lblDfRest.Name = "lblDfRest";
            this.lblDfRest.Size = new System.Drawing.Size(47, 24);
            this.lblDfRest.TabIndex = 31;
            this.lblDfRest.Text = "Rest";
            // 
            // lblDfActivity
            // 
            this.lblDfActivity.AutoSize = true;
            this.lblDfActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDfActivity.Location = new System.Drawing.Point(40, 49);
            this.lblDfActivity.Name = "lblDfActivity";
            this.lblDfActivity.Size = new System.Drawing.Size(67, 24);
            this.lblDfActivity.TabIndex = 30;
            this.lblDfActivity.Text = "Activity";
            // 
            // lblDfActivityColon
            // 
            this.lblDfActivityColon.AutoSize = true;
            this.lblDfActivityColon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDfActivityColon.Location = new System.Drawing.Point(165, 53);
            this.lblDfActivityColon.Name = "lblDfActivityColon";
            this.lblDfActivityColon.Size = new System.Drawing.Size(13, 20);
            this.lblDfActivityColon.TabIndex = 28;
            this.lblDfActivityColon.Text = ":";
            // 
            // lblDfRestColon
            // 
            this.lblDfRestColon.AutoSize = true;
            this.lblDfRestColon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDfRestColon.Location = new System.Drawing.Point(165, 115);
            this.lblDfRestColon.Name = "lblDfRestColon";
            this.lblDfRestColon.Size = new System.Drawing.Size(13, 20);
            this.lblDfRestColon.TabIndex = 29;
            this.lblDfRestColon.Text = ":";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(248, 205);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 35);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // FormPomodoro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 334);
            this.Controls.Add(this.tabMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPomodoro";
            this.Text = "Pomodoro";
            this.Load += new System.EventHandler(this.FormPomodoro_Load);
            this.Resize += new System.EventHandler(this.FormPomodoro_Resize);
            this.tabTimer.ResumeLayout(false);
            this.tabTimer.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tabDefaults.ResumeLayout(false);
            this.tabDefaults.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon nfyFinished;
        private System.Windows.Forms.TabPage tabTimer;
        private System.Windows.Forms.Button btnLongRestStart;
        private System.Windows.Forms.Label lblLongRest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLongRestSeconds;
        private System.Windows.Forms.TextBox txtLongRestMinutes;
        private System.Windows.Forms.TextBox txtCycles;
        private System.Windows.Forms.TextBox txtCurrentCycle;
        private System.Windows.Forms.TextBox txtActivityMinutes;
        private System.Windows.Forms.TextBox txtActivitySeconds;
        private System.Windows.Forms.TextBox txtRestSeconds;
        private System.Windows.Forms.TextBox txtRestMinutes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActivityStart;
        private System.Windows.Forms.Button btnRestStart;
        private System.Windows.Forms.Label lblRest;
        private System.Windows.Forms.Label lblActivity;
        private System.Windows.Forms.Label lblActivityColon;
        private System.Windows.Forms.Label lblRestColon;
        private System.Windows.Forms.Label lblNotValid;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabDefaults;
        private System.Windows.Forms.Label lblDfLongRest;
        private System.Windows.Forms.Label lblDfLongRestColon;
        private System.Windows.Forms.TextBox txtDfLongRestSeconds;
        private System.Windows.Forms.TextBox txtDfLongRestMinutes;
        private System.Windows.Forms.TextBox txtDfCycles;
        private System.Windows.Forms.TextBox txtDfActivityMinutes;
        private System.Windows.Forms.TextBox txtDfActivitySeconds;
        private System.Windows.Forms.TextBox txtDfRestSeconds;
        private System.Windows.Forms.TextBox txtDfRestMinutes;
        private System.Windows.Forms.Label lblDfCycles;
        private System.Windows.Forms.Label lblDfRest;
        private System.Windows.Forms.Label lblDfActivity;
        private System.Windows.Forms.Label lblDfActivityColon;
        private System.Windows.Forms.Label lblDfRestColon;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnSave;
    }
}

