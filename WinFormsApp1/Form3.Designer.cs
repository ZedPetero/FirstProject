namespace WinFormsApp1
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            imageList1 = new ImageList(components);
            materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            materialTabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPage1);
            materialTabControl1.Controls.Add(tabPage2);
            materialTabControl1.Controls.Add(tabPage3);
            materialTabControl1.Controls.Add(tabPage4);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.ImageList = imageList1;
            materialTabControl1.Location = new Point(3, 64);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(794, 383);
            materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Transparent;
            tabPage1.ImageKey = "dashboard.png";
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(786, 355);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dashboard";
            // 
            // tabPage2
            // 
            tabPage2.ImageKey = "box.png";
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(786, 355);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Products";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(786, 355);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Services";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(786, 355);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Contact";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "box.png");
            imageList1.Images.SetKeyName(1, "dashboard.png");
            // 
            // materialSwitch1
            // 
            materialSwitch1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            materialSwitch1.AutoSize = true;
            materialSwitch1.BackColor = Color.Transparent;
            materialSwitch1.Cursor = Cursors.Hand;
            materialSwitch1.Depth = 0;
            materialSwitch1.FlatAppearance.BorderSize = 0;
            materialSwitch1.FlatStyle = FlatStyle.Popup;
            materialSwitch1.Location = new Point(686, 24);
            materialSwitch1.Margin = new Padding(0);
            materialSwitch1.MouseLocation = new Point(-1, -1);
            materialSwitch1.MouseState = MaterialSkin.MouseState.HOVER;
            materialSwitch1.Name = "materialSwitch1";
            materialSwitch1.Ripple = true;
            materialSwitch1.Size = new Size(107, 37);
            materialSwitch1.TabIndex = 1;
            materialSwitch1.Text = "DARK  ";
            materialSwitch1.UseVisualStyleBackColor = false;
            materialSwitch1.CheckedChanged += materialSwitch1_CheckedChanged;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(materialSwitch1);
            Controls.Add(materialTabControl1);
            DrawerAutoShow = true;
            DrawerIsOpen = true;
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            materialTabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch1;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private ImageList imageList1;
    }
}