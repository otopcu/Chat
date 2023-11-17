namespace Chat
{
  partial class Form1
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.Button_enter = new System.Windows.Forms.Button();
      this.button_exit = new System.Windows.Forms.Button();
      this.textBox_send = new System.Windows.Forms.TextBox();
      this.TB_RaconMsg = new System.Windows.Forms.TextBox();
      this.button_send = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.BT_Clear = new System.Windows.Forms.Button();
      this.BT_Copy = new System.Windows.Forms.Button();
      this.RTB_Chat = new System.Windows.Forms.RichTextBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.cUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cUserBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // Button_enter
      // 
      this.Button_enter.Location = new System.Drawing.Point(2261, 775);
      this.Button_enter.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
      this.Button_enter.Name = "Button_enter";
      this.Button_enter.Size = new System.Drawing.Size(1018, 131);
      this.Button_enter.TabIndex = 0;
      this.Button_enter.Text = "Enter";
      this.Button_enter.UseVisualStyleBackColor = true;
      this.Button_enter.Click += new System.EventHandler(this.Button_enter_Click);
      // 
      // button_exit
      // 
      this.button_exit.Enabled = false;
      this.button_exit.Location = new System.Drawing.Point(2261, 921);
      this.button_exit.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
      this.button_exit.Name = "button_exit";
      this.button_exit.Size = new System.Drawing.Size(1018, 152);
      this.button_exit.TabIndex = 2;
      this.button_exit.Text = "Exit chat";
      this.button_exit.UseVisualStyleBackColor = true;
      this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
      // 
      // textBox_send
      // 
      this.textBox_send.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBox_send.Enabled = false;
      this.textBox_send.Location = new System.Drawing.Point(1680, 1166);
      this.textBox_send.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
      this.textBox_send.Name = "textBox_send";
      this.textBox_send.Size = new System.Drawing.Size(564, 44);
      this.textBox_send.TabIndex = 1;
      // 
      // TB_RaconMsg
      // 
      this.TB_RaconMsg.BackColor = System.Drawing.SystemColors.HighlightText;
      this.TB_RaconMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.TB_RaconMsg.Location = new System.Drawing.Point(30, 65);
      this.TB_RaconMsg.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
      this.TB_RaconMsg.Multiline = true;
      this.TB_RaconMsg.Name = "TB_RaconMsg";
      this.TB_RaconMsg.ReadOnly = true;
      this.TB_RaconMsg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.TB_RaconMsg.Size = new System.Drawing.Size(1636, 1027);
      this.TB_RaconMsg.TabIndex = 1;
      // 
      // button_send
      // 
      this.button_send.Enabled = false;
      this.button_send.Location = new System.Drawing.Point(2261, 1088);
      this.button_send.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
      this.button_send.Name = "button_send";
      this.button_send.Size = new System.Drawing.Size(1018, 152);
      this.button_send.TabIndex = 1;
      this.button_send.Text = "Send";
      this.button_send.UseVisualStyleBackColor = true;
      this.button_send.Click += new System.EventHandler(this.button_send_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(2335, 11);
      this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(105, 37);
      this.label1.TabIndex = 3;
      this.label1.Text = "Users";
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
      this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(2276, 65);
      this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.RowHeadersWidth = 123;
      this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.dataGridView1.RowTemplate.Height = 24;
      this.dataGridView1.Size = new System.Drawing.Size(1003, 570);
      this.dataGridView1.TabIndex = 4;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(30, 18);
      this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(276, 37);
      this.label2.TabIndex = 3;
      this.label2.Text = "Racon Messages";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(1674, 11);
      this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(251, 37);
      this.label3.TabIndex = 3;
      this.label3.Text = "Chat Messages";
      // 
      // BT_Clear
      // 
      this.BT_Clear.Location = new System.Drawing.Point(498, 1108);
      this.BT_Clear.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
      this.BT_Clear.Name = "BT_Clear";
      this.BT_Clear.Size = new System.Drawing.Size(471, 131);
      this.BT_Clear.TabIndex = 4;
      this.BT_Clear.Text = "Clear";
      this.BT_Clear.UseVisualStyleBackColor = true;
      this.BT_Clear.Click += new System.EventHandler(this.BT_Clear_Click);
      // 
      // BT_Copy
      // 
      this.BT_Copy.Location = new System.Drawing.Point(30, 1108);
      this.BT_Copy.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
      this.BT_Copy.Name = "BT_Copy";
      this.BT_Copy.Size = new System.Drawing.Size(471, 131);
      this.BT_Copy.TabIndex = 3;
      this.BT_Copy.Text = "Copy";
      this.BT_Copy.UseVisualStyleBackColor = true;
      this.BT_Copy.Click += new System.EventHandler(this.BT_Copy_Click);
      // 
      // RTB_Chat
      // 
      this.RTB_Chat.BackColor = System.Drawing.Color.FloralWhite;
      this.RTB_Chat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.RTB_Chat.Location = new System.Drawing.Point(1680, 65);
      this.RTB_Chat.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
      this.RTB_Chat.Name = "RTB_Chat";
      this.RTB_Chat.ReadOnly = true;
      this.RTB_Chat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
      this.RTB_Chat.Size = new System.Drawing.Size(559, 1023);
      this.RTB_Chat.TabIndex = 5;
      this.RTB_Chat.Text = "";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::Chat.Properties.Resources.Racon;
      this.pictureBox1.Location = new System.Drawing.Point(2295, 638);
      this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(382, 134);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 6;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
      // 
      // cUserBindingSource
      // 
      this.cUserBindingSource.DataSource = typeof(Chat.CUser);
      this.cUserBindingSource.CurrentChanged += new System.EventHandler(this.cUserBindingSource_CurrentChanged);
      // 
      // Form1
      // 
      this.AcceptButton = this.Button_enter;
      this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(3311, 1278);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.RTB_Chat);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.TB_RaconMsg);
      this.Controls.Add(this.textBox_send);
      this.Controls.Add(this.button_send);
      this.Controls.Add(this.button_exit);
      this.Controls.Add(this.BT_Copy);
      this.Controls.Add(this.BT_Clear);
      this.Controls.Add(this.Button_enter);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
      this.Name = "Form1";
      this.Text = "Chat Federate Application 0.0.2.3";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cUserBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button Button_enter;
    private System.Windows.Forms.Button button_exit;
    private System.Windows.Forms.TextBox textBox_send;
    private System.Windows.Forms.Button button_send;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.BindingSource cUserBindingSource;
    private System.Windows.Forms.DataGridView dataGridView1;
    public System.Windows.Forms.TextBox TB_RaconMsg;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button BT_Clear;
    private System.Windows.Forms.Button BT_Copy;
    public System.Windows.Forms.RichTextBox RTB_Chat;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}

