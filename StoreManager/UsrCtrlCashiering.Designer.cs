﻿namespace StoreManager
{
    partial class UsrCtrlCashiering
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelPOS = new System.Windows.Forms.Panel();
            this.materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            this.TbPosSearch = new CustomComponents.CustomMaterialMaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.crownComboBox2 = new ReaLTaiizor.Controls.CrownComboBox();
            this.crownComboBox3 = new ReaLTaiizor.Controls.CrownComboBox();
            this.CmbSizes = new ReaLTaiizor.Controls.CrownComboBox();
            this.BtnPrevPage = new System.Windows.Forms.Button();
            this.BtnNextPage = new System.Windows.Forms.Button();
            this.PnlCheckout = new System.Windows.Forms.Panel();
            this.BtnCheckout = new ReaLTaiizor.Controls.Button();
            this.LblTaxOutput = new ReaLTaiizor.Controls.HeaderLabel();
            this.LblSubtotalOutput = new ReaLTaiizor.Controls.HeaderLabel();
            this.LblTotalOutput = new ReaLTaiizor.Controls.HeaderLabel();
            this.LblSubtotal = new ReaLTaiizor.Controls.HeaderLabel();
            this.LblTax = new ReaLTaiizor.Controls.HeaderLabel();
            this.LblTotal = new ReaLTaiizor.Controls.HeaderLabel();
            this.PnlProductsPanel = new CustomComponents.ProductsPanel();
            this.PnlOrdersPanel = new CustomComponents.OrdersPanel();
            this.PanelPOS.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.PnlCheckout.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelPOS
            // 
            this.PanelPOS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelPOS.BackColor = System.Drawing.Color.Silver;
            this.PanelPOS.Controls.Add(this.materialCard1);
            this.PanelPOS.Controls.Add(this.label3);
            this.PanelPOS.Controls.Add(this.label2);
            this.PanelPOS.Controls.Add(this.label1);
            this.PanelPOS.Controls.Add(this.crownComboBox2);
            this.PanelPOS.Controls.Add(this.crownComboBox3);
            this.PanelPOS.Controls.Add(this.CmbSizes);
            this.PanelPOS.Controls.Add(this.BtnPrevPage);
            this.PanelPOS.Controls.Add(this.BtnNextPage);
            this.PanelPOS.Controls.Add(this.PnlCheckout);
            this.PanelPOS.Controls.Add(this.PnlProductsPanel);
            this.PanelPOS.Controls.Add(this.PnlOrdersPanel);
            this.PanelPOS.Location = new System.Drawing.Point(0, 0);
            this.PanelPOS.Margin = new System.Windows.Forms.Padding(0);
            this.PanelPOS.Name = "PanelPOS";
            this.PanelPOS.Size = new System.Drawing.Size(1067, 645);
            this.PanelPOS.TabIndex = 1;
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.TbPosSearch);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(7, 7);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(652, 47);
            this.materialCard1.TabIndex = 9;
            // 
            // TbPosSearch
            // 
            this.TbPosSearch.AllowPromptAsInput = true;
            this.TbPosSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbPosSearch.AnimateReadOnly = false;
            this.TbPosSearch.AsciiOnly = false;
            this.TbPosSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TbPosSearch.BeepOnError = false;
            this.TbPosSearch.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.TbPosSearch.Depth = 0;
            this.TbPosSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TbPosSearch.HidePromptOnLeave = false;
            this.TbPosSearch.HideSelection = true;
            this.TbPosSearch.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.TbPosSearch.LeadingIcon = null;
            this.TbPosSearch.Location = new System.Drawing.Point(0, -1);
            this.TbPosSearch.Margin = new System.Windows.Forms.Padding(0);
            this.TbPosSearch.Mask = "";
            this.TbPosSearch.MaxLength = 32767;
            this.TbPosSearch.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.TbPosSearch.Name = "TbPosSearch";
            this.TbPosSearch.PasswordChar = '\0';
            this.TbPosSearch.PrefixSuffixText = null;
            this.TbPosSearch.PromptChar = '_';
            this.TbPosSearch.ReadOnly = false;
            this.TbPosSearch.RejectInputOnFirstFailure = false;
            this.TbPosSearch.ResetOnPrompt = true;
            this.TbPosSearch.ResetOnSpace = true;
            this.TbPosSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TbPosSearch.SelectedText = "";
            this.TbPosSearch.SelectionLength = 0;
            this.TbPosSearch.SelectionStart = 0;
            this.TbPosSearch.ShortcutsEnabled = true;
            this.TbPosSearch.Size = new System.Drawing.Size(655, 48);
            this.TbPosSearch.SkipLiterals = true;
            this.TbPosSearch.TabIndex = 0;
            this.TbPosSearch.TabStop = false;
            this.TbPosSearch.Text = "Search";
            this.TbPosSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TbPosSearch.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.TbPosSearch.TrailingIcon = null;
            this.TbPosSearch.UnderlineColor = System.Drawing.Color.Black;
            this.TbPosSearch.UseSystemPasswordChar = false;
            this.TbPosSearch.ValidatingType = null;
            this.TbPosSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbPosSearch_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(923, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "SIZE:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(796, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "TYPE:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(669, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "SIZE:";
            // 
            // crownComboBox2
            // 
            this.crownComboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.crownComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.crownComboBox2.FormattingEnabled = true;
            this.crownComboBox2.Location = new System.Drawing.Point(799, 31);
            this.crownComboBox2.Name = "crownComboBox2";
            this.crownComboBox2.Size = new System.Drawing.Size(121, 21);
            this.crownComboBox2.TabIndex = 5;
            // 
            // crownComboBox3
            // 
            this.crownComboBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.crownComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.crownComboBox3.FormattingEnabled = true;
            this.crownComboBox3.Location = new System.Drawing.Point(926, 31);
            this.crownComboBox3.Name = "crownComboBox3";
            this.crownComboBox3.Size = new System.Drawing.Size(121, 21);
            this.crownComboBox3.TabIndex = 6;
            // 
            // CmbSizes
            // 
            this.CmbSizes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbSizes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CmbSizes.FormattingEnabled = true;
            this.CmbSizes.Location = new System.Drawing.Point(672, 31);
            this.CmbSizes.Name = "CmbSizes";
            this.CmbSizes.Size = new System.Drawing.Size(121, 21);
            this.CmbSizes.TabIndex = 5;
            // 
            // BtnPrevPage
            // 
            this.BtnPrevPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnPrevPage.Location = new System.Drawing.Point(115, 619);
            this.BtnPrevPage.Name = "BtnPrevPage";
            this.BtnPrevPage.Size = new System.Drawing.Size(130, 23);
            this.BtnPrevPage.TabIndex = 4;
            this.BtnPrevPage.Text = "Previous Page";
            this.BtnPrevPage.UseVisualStyleBackColor = true;
            this.BtnPrevPage.Click += new System.EventHandler(this.BtnPrevPage_Click);
            // 
            // BtnNextPage
            // 
            this.BtnNextPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnNextPage.Location = new System.Drawing.Point(251, 619);
            this.BtnNextPage.Name = "BtnNextPage";
            this.BtnNextPage.Size = new System.Drawing.Size(129, 23);
            this.BtnNextPage.TabIndex = 3;
            this.BtnNextPage.Text = "Next Page";
            this.BtnNextPage.UseVisualStyleBackColor = true;
            this.BtnNextPage.Click += new System.EventHandler(this.BtnNextPage_Click);
            // 
            // PnlCheckout
            // 
            this.PnlCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlCheckout.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PnlCheckout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlCheckout.Controls.Add(this.BtnCheckout);
            this.PnlCheckout.Controls.Add(this.LblTaxOutput);
            this.PnlCheckout.Controls.Add(this.LblSubtotalOutput);
            this.PnlCheckout.Controls.Add(this.LblTotalOutput);
            this.PnlCheckout.Controls.Add(this.LblSubtotal);
            this.PnlCheckout.Controls.Add(this.LblTax);
            this.PnlCheckout.Controls.Add(this.LblTotal);
            this.PnlCheckout.Location = new System.Drawing.Point(672, 427);
            this.PnlCheckout.Name = "PnlCheckout";
            this.PnlCheckout.Size = new System.Drawing.Size(392, 215);
            this.PnlCheckout.TabIndex = 0;
            // 
            // BtnCheckout
            // 
            this.BtnCheckout.BackColor = System.Drawing.Color.Transparent;
            this.BtnCheckout.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.BtnCheckout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCheckout.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnCheckout.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.BtnCheckout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCheckout.Image = null;
            this.BtnCheckout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCheckout.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.BtnCheckout.Location = new System.Drawing.Point(12, 106);
            this.BtnCheckout.Name = "BtnCheckout";
            this.BtnCheckout.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnCheckout.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnCheckout.Size = new System.Drawing.Size(363, 97);
            this.BtnCheckout.TabIndex = 1;
            this.BtnCheckout.Text = "CHECKOUT";
            this.BtnCheckout.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // LblTaxOutput
            // 
            this.LblTaxOutput.BackColor = System.Drawing.Color.Transparent;
            this.LblTaxOutput.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTaxOutput.ForeColor = System.Drawing.Color.White;
            this.LblTaxOutput.Location = new System.Drawing.Point(227, 71);
            this.LblTaxOutput.Name = "LblTaxOutput";
            this.LblTaxOutput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblTaxOutput.Size = new System.Drawing.Size(143, 24);
            this.LblTaxOutput.TabIndex = 0;
            this.LblTaxOutput.Text = "0";
            // 
            // LblSubtotalOutput
            // 
            this.LblSubtotalOutput.BackColor = System.Drawing.Color.Transparent;
            this.LblSubtotalOutput.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubtotalOutput.ForeColor = System.Drawing.Color.White;
            this.LblSubtotalOutput.Location = new System.Drawing.Point(227, 48);
            this.LblSubtotalOutput.Name = "LblSubtotalOutput";
            this.LblSubtotalOutput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblSubtotalOutput.Size = new System.Drawing.Size(143, 24);
            this.LblSubtotalOutput.TabIndex = 0;
            this.LblSubtotalOutput.Text = "0";
            // 
            // LblTotalOutput
            // 
            this.LblTotalOutput.BackColor = System.Drawing.Color.Transparent;
            this.LblTotalOutput.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalOutput.ForeColor = System.Drawing.Color.White;
            this.LblTotalOutput.Location = new System.Drawing.Point(227, 14);
            this.LblTotalOutput.Name = "LblTotalOutput";
            this.LblTotalOutput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblTotalOutput.Size = new System.Drawing.Size(143, 24);
            this.LblTotalOutput.TabIndex = 0;
            this.LblTotalOutput.Text = "0";
            // 
            // LblSubtotal
            // 
            this.LblSubtotal.AutoSize = true;
            this.LblSubtotal.BackColor = System.Drawing.Color.Transparent;
            this.LblSubtotal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubtotal.ForeColor = System.Drawing.Color.White;
            this.LblSubtotal.Location = new System.Drawing.Point(14, 48);
            this.LblSubtotal.Name = "LblSubtotal";
            this.LblSubtotal.Size = new System.Drawing.Size(79, 22);
            this.LblSubtotal.TabIndex = 0;
            this.LblSubtotal.Text = "Subtotal";
            // 
            // LblTax
            // 
            this.LblTax.AutoSize = true;
            this.LblTax.BackColor = System.Drawing.Color.Transparent;
            this.LblTax.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTax.ForeColor = System.Drawing.Color.White;
            this.LblTax.Location = new System.Drawing.Point(14, 71);
            this.LblTax.Name = "LblTax";
            this.LblTax.Size = new System.Drawing.Size(39, 22);
            this.LblTax.TabIndex = 0;
            this.LblTax.Text = "Tax";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.BackColor = System.Drawing.Color.Transparent;
            this.LblTotal.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.ForeColor = System.Drawing.Color.White;
            this.LblTotal.Location = new System.Drawing.Point(14, 14);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(78, 24);
            this.LblTotal.TabIndex = 0;
            this.LblTotal.Text = "TOTAL";
            // 
            // PnlProductsPanel
            // 
            this.PnlProductsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlProductsPanel.Location = new System.Drawing.Point(3, 68);
            this.PnlProductsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.PnlProductsPanel.Name = "PnlProductsPanel";
            this.PnlProductsPanel.Size = new System.Drawing.Size(663, 544);
            this.PnlProductsPanel.TabIndex = 0;
            // 
            // PnlOrdersPanel
            // 
            this.PnlOrdersPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlOrdersPanel.AutoScroll = true;
            this.PnlOrdersPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PnlOrdersPanel.Location = new System.Drawing.Point(672, 68);
            this.PnlOrdersPanel.Name = "PnlOrdersPanel";
            this.PnlOrdersPanel.Size = new System.Drawing.Size(392, 353);
            this.PnlOrdersPanel.TabIndex = 0;
            // 
            // UsrCtrlCashiering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelPOS);
            this.Name = "UsrCtrlCashiering";
            this.Size = new System.Drawing.Size(1067, 645);
            this.PanelPOS.ResumeLayout(false);
            this.PanelPOS.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.PnlCheckout.ResumeLayout(false);
            this.PnlCheckout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPOS;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private CustomComponents.CustomMaterialMaskedTextBox TbPosSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.CrownComboBox crownComboBox2;
        private ReaLTaiizor.Controls.CrownComboBox crownComboBox3;
        private ReaLTaiizor.Controls.CrownComboBox CmbSizes;
        private System.Windows.Forms.Button BtnPrevPage;
        private System.Windows.Forms.Button BtnNextPage;
        private System.Windows.Forms.Panel PnlCheckout;
        private ReaLTaiizor.Controls.Button BtnCheckout;
        private ReaLTaiizor.Controls.HeaderLabel LblTaxOutput;
        private ReaLTaiizor.Controls.HeaderLabel LblSubtotalOutput;
        private ReaLTaiizor.Controls.HeaderLabel LblTotalOutput;
        private ReaLTaiizor.Controls.HeaderLabel LblSubtotal;
        private ReaLTaiizor.Controls.HeaderLabel LblTax;
        private ReaLTaiizor.Controls.HeaderLabel LblTotal;
        private CustomComponents.ProductsPanel PnlProductsPanel;
        private CustomComponents.OrdersPanel PnlOrdersPanel;
    }
}
