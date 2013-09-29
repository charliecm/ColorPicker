namespace ColorPicker
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtHexFull = new System.Windows.Forms.TextBox();
            this.txtHexShort = new System.Windows.Forms.TextBox();
            this.txtRgbShort = new System.Windows.Forms.TextBox();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPickColor = new System.Windows.Forms.Button();
            this.chkPin = new System.Windows.Forms.CheckBox();
            this.btnOpenColorPicker = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHexFull
            // 
            this.txtHexFull.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtHexFull.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHexFull.ForeColor = System.Drawing.Color.White;
            this.txtHexFull.Location = new System.Drawing.Point(100, 40);
            this.txtHexFull.Margin = new System.Windows.Forms.Padding(5);
            this.txtHexFull.Name = "txtHexFull";
            this.txtHexFull.Size = new System.Drawing.Size(100, 20);
            this.txtHexFull.TabIndex = 2;
            this.txtHexFull.Text = "#000000";
            this.tooltip.SetToolTip(this.txtHexFull, "Double-click to copy");
            this.txtHexFull.Click += new System.EventHandler(this.TextBoxSelectAll);
            this.txtHexFull.TextChanged += new System.EventHandler(this.txtHexFull_TextChanged);
            this.txtHexFull.DoubleClick += new System.EventHandler(this.TextBoxCopyToClipboard);
            this.txtHexFull.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHexFull_KeyPress);
            this.txtHexFull.Leave += new System.EventHandler(this.txtHexFull_Leave);
            // 
            // txtHexShort
            // 
            this.txtHexShort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtHexShort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHexShort.ForeColor = System.Drawing.Color.White;
            this.txtHexShort.Location = new System.Drawing.Point(100, 70);
            this.txtHexShort.Margin = new System.Windows.Forms.Padding(5);
            this.txtHexShort.Name = "txtHexShort";
            this.txtHexShort.Size = new System.Drawing.Size(100, 20);
            this.txtHexShort.TabIndex = 3;
            this.txtHexShort.Text = "000000";
            this.tooltip.SetToolTip(this.txtHexShort, "Double-click to copy");
            this.txtHexShort.Click += new System.EventHandler(this.TextBoxSelectAll);
            this.txtHexShort.TextChanged += new System.EventHandler(this.txtHexShort_TextChanged);
            this.txtHexShort.DoubleClick += new System.EventHandler(this.TextBoxCopyToClipboard);
            this.txtHexShort.Leave += new System.EventHandler(this.txtHexShort_Leave);
            // 
            // txtRgbShort
            // 
            this.txtRgbShort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtRgbShort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRgbShort.ForeColor = System.Drawing.Color.White;
            this.txtRgbShort.Location = new System.Drawing.Point(100, 100);
            this.txtRgbShort.Margin = new System.Windows.Forms.Padding(5);
            this.txtRgbShort.Name = "txtRgbShort";
            this.txtRgbShort.ReadOnly = true;
            this.txtRgbShort.Size = new System.Drawing.Size(100, 20);
            this.txtRgbShort.TabIndex = 4;
            this.txtRgbShort.Text = "0, 0, 0";
            this.tooltip.SetToolTip(this.txtRgbShort, "Double-click to copy");
            this.txtRgbShort.Click += new System.EventHandler(this.TextBoxSelectAll);
            this.txtRgbShort.DoubleClick += new System.EventHandler(this.TextBoxCopyToClipboard);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::ColorPicker.Properties.Resources.appbar_close;
            this.btnClose.Location = new System.Drawing.Point(210, -1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 25);
            this.btnClose.TabIndex = 7;
            this.tooltip.SetToolTip(this.btnClose, "Close (ESC)");
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPickColor
            // 
            this.btnPickColor.BackColor = System.Drawing.Color.Transparent;
            this.btnPickColor.BackgroundImage = global::ColorPicker.Properties.Resources.appbar_dropper;
            this.btnPickColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPickColor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnPickColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPickColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPickColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPickColor.Location = new System.Drawing.Point(10, 40);
            this.btnPickColor.Margin = new System.Windows.Forms.Padding(5);
            this.btnPickColor.Name = "btnPickColor";
            this.btnPickColor.Size = new System.Drawing.Size(80, 80);
            this.btnPickColor.TabIndex = 6;
            this.tooltip.SetToolTip(this.btnPickColor, "Press and drag to sample color");
            this.btnPickColor.UseVisualStyleBackColor = false;
            this.btnPickColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPickColor_MouseDown);
            this.btnPickColor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnPickColor_MouseUp);
            // 
            // chkPin
            // 
            this.chkPin.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkPin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.chkPin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.chkPin.FlatAppearance.BorderSize = 0;
            this.chkPin.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.chkPin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkPin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkPin.Image = global::ColorPicker.Properties.Resources.appbar_pin;
            this.chkPin.Location = new System.Drawing.Point(210, 86);
            this.chkPin.Margin = new System.Windows.Forms.Padding(5);
            this.chkPin.Name = "chkPin";
            this.chkPin.Size = new System.Drawing.Size(36, 36);
            this.chkPin.TabIndex = 1;
            this.tooltip.SetToolTip(this.chkPin, "Always on top");
            this.chkPin.UseVisualStyleBackColor = false;
            this.chkPin.CheckedChanged += new System.EventHandler(this.chkPin_CheckedChanged);
            // 
            // btnOpenColorPicker
            // 
            this.btnOpenColorPicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnOpenColorPicker.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnOpenColorPicker.FlatAppearance.BorderSize = 0;
            this.btnOpenColorPicker.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOpenColorPicker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOpenColorPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenColorPicker.Image = global::ColorPicker.Properties.Resources.appbar_draw_pixel_fill_grid;
            this.btnOpenColorPicker.Location = new System.Drawing.Point(210, 40);
            this.btnOpenColorPicker.Margin = new System.Windows.Forms.Padding(5);
            this.btnOpenColorPicker.Name = "btnOpenColorPicker";
            this.btnOpenColorPicker.Size = new System.Drawing.Size(36, 36);
            this.btnOpenColorPicker.TabIndex = 0;
            this.tooltip.SetToolTip(this.btnOpenColorPicker, "Choose color");
            this.btnOpenColorPicker.UseVisualStyleBackColor = false;
            this.btnOpenColorPicker.Click += new System.EventHandler(this.btnOpenColorChooser_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(5, 6);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(5, 0, 0, 10);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(94, 21);
            this.lbTitle.TabIndex = 9;
            this.lbTitle.Text = "Color Picker";
            this.lbTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(255, 131);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPickColor);
            this.Controls.Add(this.txtRgbShort);
            this.Controls.Add(this.txtHexShort);
            this.Controls.Add(this.txtHexFull);
            this.Controls.Add(this.chkPin);
            this.Controls.Add(this.btnOpenColorPicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = global::ColorPicker.Properties.Resources.dropper;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Picker";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenColorPicker;
        private System.Windows.Forms.CheckBox chkPin;
        private System.Windows.Forms.TextBox txtHexFull;
        private System.Windows.Forms.TextBox txtHexShort;
        private System.Windows.Forms.TextBox txtRgbShort;
        private System.Windows.Forms.Button btnPickColor;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbTitle;
    }
}

