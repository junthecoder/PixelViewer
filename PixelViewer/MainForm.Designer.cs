namespace PixelViewer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.ColorLabel = new System.Windows.Forms.Label();
            this.RGBHexLabel = new System.Windows.Forms.Label();
            this.RGBDecimalLabel = new System.Windows.Forms.Label();
            this.RGB0to1Label = new System.Windows.Forms.Label();
            this.HSVLabel = new System.Windows.Forms.Label();
            this.CMYKLabel = new System.Windows.Forms.Label();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.RGB16Button = new System.Windows.Forms.ToolStripButton();
            this.RGB10Button = new System.Windows.Forms.ToolStripButton();
            this.RGB0to1Button = new System.Windows.Forms.ToolStripButton();
            this.HsvButton = new System.Windows.Forms.ToolStripButton();
            this.CmykButton = new System.Windows.Forms.ToolStripButton();
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Panel = new System.Windows.Forms.Panel();
            this.ToolStrip.SuspendLayout();
            this.TableLayoutPanel.SuspendLayout();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Enabled = true;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // ColorLabel
            // 
            this.ColorLabel.BackColor = System.Drawing.Color.White;
            this.ColorLabel.Location = new System.Drawing.Point(20, 20);
            this.ColorLabel.Margin = new System.Windows.Forms.Padding(20);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(48, 48);
            this.ColorLabel.TabIndex = 0;
            // 
            // RGBHexLabel
            // 
            this.RGBHexLabel.AutoSize = true;
            this.RGBHexLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RGBHexLabel.Location = new System.Drawing.Point(3, 3);
            this.RGBHexLabel.Margin = new System.Windows.Forms.Padding(3);
            this.RGBHexLabel.Name = "RGBHexLabel";
            this.RGBHexLabel.Size = new System.Drawing.Size(77, 15);
            this.RGBHexLabel.TabIndex = 1;
            this.RGBHexLabel.Text = "RGBHexLabel";
            // 
            // RGBDecimalLabel
            // 
            this.RGBDecimalLabel.AutoSize = true;
            this.RGBDecimalLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RGBDecimalLabel.Location = new System.Drawing.Point(3, 24);
            this.RGBDecimalLabel.Margin = new System.Windows.Forms.Padding(3);
            this.RGBDecimalLabel.Name = "RGBDecimalLabel";
            this.RGBDecimalLabel.Size = new System.Drawing.Size(100, 15);
            this.RGBDecimalLabel.TabIndex = 2;
            this.RGBDecimalLabel.Text = "RGBDecimalLabel";
            // 
            // RGB0to1Label
            // 
            this.RGB0to1Label.AutoSize = true;
            this.RGB0to1Label.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RGB0to1Label.Location = new System.Drawing.Point(3, 45);
            this.RGB0to1Label.Margin = new System.Windows.Forms.Padding(3);
            this.RGB0to1Label.Name = "RGB0to1Label";
            this.RGB0to1Label.Size = new System.Drawing.Size(80, 15);
            this.RGB0to1Label.TabIndex = 3;
            this.RGB0to1Label.Text = "RGB0to1Label";
            // 
            // HSVLabel
            // 
            this.HSVLabel.AutoSize = true;
            this.HSVLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.HSVLabel.Location = new System.Drawing.Point(3, 66);
            this.HSVLabel.Margin = new System.Windows.Forms.Padding(3);
            this.HSVLabel.Name = "HSVLabel";
            this.HSVLabel.Size = new System.Drawing.Size(57, 15);
            this.HSVLabel.TabIndex = 4;
            this.HSVLabel.Text = "HSVLabel";
            // 
            // CMYKLabel
            // 
            this.CMYKLabel.AutoSize = true;
            this.CMYKLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CMYKLabel.Location = new System.Drawing.Point(3, 87);
            this.CMYKLabel.Margin = new System.Windows.Forms.Padding(3);
            this.CMYKLabel.Name = "CMYKLabel";
            this.CMYKLabel.Size = new System.Drawing.Size(68, 15);
            this.CMYKLabel.TabIndex = 5;
            this.CMYKLabel.Text = "CMYKLabel";
            // 
            // ToolStrip
            // 
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RGB16Button,
            this.RGB10Button,
            this.RGB0to1Button,
            this.HsvButton,
            this.CmykButton});
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(344, 25);
            this.ToolStrip.TabIndex = 7;
            this.ToolStrip.Text = "ToolStrip";
            this.ToolStrip.VisibleChanged += new System.EventHandler(this.ToolStrip_VisibleChanged);
            // 
            // RGB16Button
            // 
            this.RGB16Button.CheckOnClick = true;
            this.RGB16Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RGB16Button.Image = ((System.Drawing.Image)(resources.GetObject("RGB16Button.Image")));
            this.RGB16Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RGB16Button.Name = "RGB16Button";
            this.RGB16Button.Size = new System.Drawing.Size(53, 22);
            this.RGB16Button.Text = "RGB(16)";
            this.RGB16Button.CheckedChanged += new System.EventHandler(this.UpdateLabelVisibilities);
            this.RGB16Button.Click += new System.EventHandler(this.RGB16Button_Click);
            // 
            // RGB10Button
            // 
            this.RGB10Button.CheckOnClick = true;
            this.RGB10Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RGB10Button.Image = ((System.Drawing.Image)(resources.GetObject("RGB10Button.Image")));
            this.RGB10Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RGB10Button.Name = "RGB10Button";
            this.RGB10Button.Size = new System.Drawing.Size(53, 22);
            this.RGB10Button.Text = "RGB(10)";
            this.RGB10Button.CheckedChanged += new System.EventHandler(this.UpdateLabelVisibilities);
            // 
            // RGB0to1Button
            // 
            this.RGB0to1Button.CheckOnClick = true;
            this.RGB0to1Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RGB0to1Button.Image = ((System.Drawing.Image)(resources.GetObject("RGB0to1Button.Image")));
            this.RGB0to1Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RGB0to1Button.Name = "RGB0to1Button";
            this.RGB0to1Button.Size = new System.Drawing.Size(56, 22);
            this.RGB0to1Button.Text = "RGB[0,1]";
            this.RGB0to1Button.CheckedChanged += new System.EventHandler(this.UpdateLabelVisibilities);
            // 
            // HsvButton
            // 
            this.HsvButton.CheckOnClick = true;
            this.HsvButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.HsvButton.Image = ((System.Drawing.Image)(resources.GetObject("HsvButton.Image")));
            this.HsvButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HsvButton.Name = "HsvButton";
            this.HsvButton.Size = new System.Drawing.Size(33, 22);
            this.HsvButton.Text = "HSV";
            this.HsvButton.CheckedChanged += new System.EventHandler(this.UpdateLabelVisibilities);
            // 
            // CmykButton
            // 
            this.CmykButton.CheckOnClick = true;
            this.CmykButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CmykButton.Image = ((System.Drawing.Image)(resources.GetObject("CmykButton.Image")));
            this.CmykButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmykButton.Name = "CmykButton";
            this.CmykButton.Size = new System.Drawing.Size(44, 22);
            this.CmykButton.Text = "CMYK";
            this.CmykButton.CheckedChanged += new System.EventHandler(this.UpdateLabelVisibilities);
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.AutoSize = true;
            this.TableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TableLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
            this.TableLayoutPanel.ColumnCount = 1;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel.Controls.Add(this.RGBDecimalLabel, 0, 1);
            this.TableLayoutPanel.Controls.Add(this.RGB0to1Label, 0, 2);
            this.TableLayoutPanel.Controls.Add(this.HSVLabel, 0, 3);
            this.TableLayoutPanel.Controls.Add(this.CMYKLabel, 0, 4);
            this.TableLayoutPanel.Controls.Add(this.RGBHexLabel, 0, 0);
            this.TableLayoutPanel.Location = new System.Drawing.Point(88, 16);
            this.TableLayoutPanel.Margin = new System.Windows.Forms.Padding(0, 16, 0, 16);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 5;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel.Size = new System.Drawing.Size(106, 105);
            this.TableLayoutPanel.TabIndex = 8;
            // 
            // Panel
            // 
            this.Panel.AutoSize = true;
            this.Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Panel.Controls.Add(this.ColorLabel);
            this.Panel.Controls.Add(this.TableLayoutPanel);
            this.Panel.Location = new System.Drawing.Point(0, 25);
            this.Panel.Margin = new System.Windows.Forms.Padding(0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(194, 137);
            this.Panel.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(344, 170);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.ToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(360, 0);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Pixel Viewer";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.TableLayoutPanel.ResumeLayout(false);
            this.TableLayoutPanel.PerformLayout();
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Label RGBHexLabel;
        private System.Windows.Forms.Label RGBDecimalLabel;
        private System.Windows.Forms.Label RGB0to1Label;
        private System.Windows.Forms.Label HSVLabel;
        private System.Windows.Forms.Label CMYKLabel;
        private System.Windows.Forms.ToolStripButton RGB16Button;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripButton RGB10Button;
        private System.Windows.Forms.ToolStripButton RGB0to1Button;
        private System.Windows.Forms.ToolStripButton HsvButton;
        private System.Windows.Forms.ToolStripButton CmykButton;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.Panel Panel;
    }
}

