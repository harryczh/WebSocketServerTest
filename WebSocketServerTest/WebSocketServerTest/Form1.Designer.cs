namespace WebSocketServerTest
{
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lb_title = new Label();
            lb_msgTitle = new Label();
            btn_start = new Button();
            btn_clear = new Button();
            lBox_clientMsg = new ListBox();
            label1 = new Label();
            tbx_ip = new TextBox();
            label2 = new Label();
            tbx_port = new TextBox();
            cbx_protocol = new ComboBox();
            label3 = new Label();
            btn_stop = new Button();
            btn_default = new Button();
            SuspendLayout();
            // 
            // lb_title
            // 
            lb_title.AutoSize = true;
            lb_title.Font = new Font("Microsoft JhengHei UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lb_title.Location = new Point(12, 9);
            lb_title.Name = "lb_title";
            lb_title.Size = new Size(316, 43);
            lb_title.TabIndex = 0;
            lb_title.Text = "WebSocket Server";
            // 
            // lb_msgTitle
            // 
            lb_msgTitle.AutoSize = true;
            lb_msgTitle.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lb_msgTitle.Location = new Point(12, 110);
            lb_msgTitle.Name = "lb_msgTitle";
            lb_msgTitle.Size = new Size(249, 29);
            lb_msgTitle.TabIndex = 1;
            lb_msgTitle.Text = "Get Client Message：";
            // 
            // btn_start
            // 
            btn_start.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 136);
            btn_start.Location = new Point(893, 67);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(94, 38);
            btn_start.TabIndex = 3;
            btn_start.Text = "Start";
            btn_start.UseVisualStyleBackColor = true;
            btn_start.Click += btn_start_Click;
            // 
            // btn_clear
            // 
            btn_clear.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 136);
            btn_clear.Location = new Point(993, 406);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(94, 38);
            btn_clear.TabIndex = 4;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // lBox_clientMsg
            // 
            lBox_clientMsg.FormattingEnabled = true;
            lBox_clientMsg.HorizontalScrollbar = true;
            lBox_clientMsg.ItemHeight = 19;
            lBox_clientMsg.Location = new Point(12, 143);
            lBox_clientMsg.Name = "lBox_clientMsg";
            lBox_clientMsg.Size = new Size(1075, 251);
            lBox_clientMsg.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label1.Location = new Point(221, 67);
            label1.Name = "label1";
            label1.Size = new Size(57, 29);
            label1.TabIndex = 6;
            label1.Text = "IP：";
            // 
            // tbx_ip
            // 
            tbx_ip.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            tbx_ip.Location = new Point(284, 64);
            tbx_ip.Name = "tbx_ip";
            tbx_ip.Size = new Size(186, 37);
            tbx_ip.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label2.Location = new Point(478, 67);
            label2.Name = "label2";
            label2.Size = new Size(83, 29);
            label2.TabIndex = 8;
            label2.Text = "Port：";
            // 
            // tbx_port
            // 
            tbx_port.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            tbx_port.Location = new Point(567, 64);
            tbx_port.Name = "tbx_port";
            tbx_port.Size = new Size(94, 37);
            tbx_port.TabIndex = 9;
            // 
            // cbx_protocol
            // 
            cbx_protocol.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_protocol.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cbx_protocol.FormattingEnabled = true;
            cbx_protocol.Items.AddRange(new object[] { "ws", "wss" });
            cbx_protocol.Location = new Point(150, 64);
            cbx_protocol.Name = "cbx_protocol";
            cbx_protocol.Size = new Size(65, 37);
            cbx_protocol.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label3.Location = new Point(13, 67);
            label3.Name = "label3";
            label3.Size = new Size(131, 29);
            label3.TabIndex = 11;
            label3.Text = "Protocol：";
            // 
            // btn_stop
            // 
            btn_stop.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 136);
            btn_stop.Location = new Point(993, 67);
            btn_stop.Name = "btn_stop";
            btn_stop.Size = new Size(94, 38);
            btn_stop.TabIndex = 12;
            btn_stop.Text = "Stop";
            btn_stop.UseVisualStyleBackColor = true;
            btn_stop.Click += btn_stop_Click;
            // 
            // btn_default
            // 
            btn_default.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 136);
            btn_default.Location = new Point(667, 64);
            btn_default.Name = "btn_default";
            btn_default.Size = new Size(110, 38);
            btn_default.TabIndex = 13;
            btn_default.Text = "Default";
            btn_default.UseVisualStyleBackColor = true;
            btn_default.Click += btn_default_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 456);
            Controls.Add(btn_default);
            Controls.Add(btn_stop);
            Controls.Add(label3);
            Controls.Add(cbx_protocol);
            Controls.Add(tbx_port);
            Controls.Add(label2);
            Controls.Add(tbx_ip);
            Controls.Add(label1);
            Controls.Add(lBox_clientMsg);
            Controls.Add(btn_clear);
            Controls.Add(btn_start);
            Controls.Add(lb_msgTitle);
            Controls.Add(lb_title);
            MaximumSize = new Size(1117, 503);
            MinimumSize = new Size(1117, 503);
            Name = "Form1";
            Text = "WebSocket Test";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_title;
        private Label lb_msgTitle;
        private ListView lView_clientMsg;
        private Button btn_start;
        private Button btn_clear;
        private ListBox lBox_clientMsg;
        private Label label1;
        private TextBox tbx_ip;
        private Label label2;
        private TextBox tbx_port;
        private ComboBox cbx_protocol;
        private Label label3;
        private Button btn_stop;
        private Button btn_default;
    }
}
