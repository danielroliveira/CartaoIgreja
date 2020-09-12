﻿namespace CamadaUI.Main
{
    partial class frmPrincipal
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
			this.pnlTop = new System.Windows.Forms.Panel();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnMinimizer = new System.Windows.Forms.Button();
			this.btnConfig = new System.Windows.Forms.Button();
			this.mnuPrincipal = new System.Windows.Forms.ToolStrip();
			this.btnSair = new System.Windows.Forms.ToolStripButton();
			this.btnCadastros = new System.Windows.Forms.ToolStripSplitButton();
			this.mnuCadastroAdicionar = new System.Windows.Forms.ToolStripMenuItem();
			this.editarMembroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.cadastroDeFunçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cadstrosDeCongregaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnImprimir = new System.Windows.Forms.ToolStripSplitButton();
			this.mnuImpressaoInserir = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuContribuicaoProcurar = new System.Windows.Forms.ToolStripMenuItem();
			this.pnlTop.SuspendLayout();
			this.mnuPrincipal.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlTop
			// 
			this.pnlTop.BackColor = System.Drawing.Color.SlateGray;
			this.pnlTop.Controls.Add(this.lblTitulo);
			this.pnlTop.Controls.Add(this.btnClose);
			this.pnlTop.Controls.Add(this.btnMinimizer);
			this.pnlTop.Controls.Add(this.btnConfig);
			this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTop.Location = new System.Drawing.Point(0, 0);
			this.pnlTop.Name = "pnlTop";
			this.pnlTop.Size = new System.Drawing.Size(1110, 40);
			this.pnlTop.TabIndex = 0;
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblTitulo.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.lblTitulo.Location = new System.Drawing.Point(0, 0);
			this.lblTitulo.Margin = new System.Windows.Forms.Padding(0);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
			this.lblTitulo.Size = new System.Drawing.Size(167, 32);
			this.lblTitulo.TabIndex = 12;
			this.lblTitulo.Text = "Titulo da Igreja";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.Transparent;
			this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = global::CamadaUI.Properties.Resources.CloseIcon;
			this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnClose.Location = new System.Drawing.Point(1070, 0);
			this.btnClose.Margin = new System.Windows.Forms.Padding(0);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(40, 40);
			this.btnClose.TabIndex = 11;
			this.btnClose.TabStop = false;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// btnMinimizer
			// 
			this.btnMinimizer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMinimizer.BackColor = System.Drawing.Color.Transparent;
			this.btnMinimizer.FlatAppearance.BorderSize = 0;
			this.btnMinimizer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.btnMinimizer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
			this.btnMinimizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimizer.Image = global::CamadaUI.Properties.Resources.DropdownIcon;
			this.btnMinimizer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnMinimizer.Location = new System.Drawing.Point(1030, 0);
			this.btnMinimizer.Margin = new System.Windows.Forms.Padding(0);
			this.btnMinimizer.Name = "btnMinimizer";
			this.btnMinimizer.Size = new System.Drawing.Size(40, 40);
			this.btnMinimizer.TabIndex = 11;
			this.btnMinimizer.TabStop = false;
			this.btnMinimizer.UseVisualStyleBackColor = false;
			this.btnMinimizer.Click += new System.EventHandler(this.btnMinimizer_Click);
			// 
			// btnConfig
			// 
			this.btnConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnConfig.BackColor = System.Drawing.Color.Transparent;
			this.btnConfig.FlatAppearance.BorderSize = 0;
			this.btnConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.btnConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
			this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConfig.Image = ((System.Drawing.Image)(resources.GetObject("btnConfig.Image")));
			this.btnConfig.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnConfig.Location = new System.Drawing.Point(990, 0);
			this.btnConfig.Margin = new System.Windows.Forms.Padding(0);
			this.btnConfig.Name = "btnConfig";
			this.btnConfig.Size = new System.Drawing.Size(40, 40);
			this.btnConfig.TabIndex = 11;
			this.btnConfig.TabStop = false;
			this.btnConfig.UseVisualStyleBackColor = false;
			this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
			// 
			// mnuPrincipal
			// 
			this.mnuPrincipal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSair,
            this.btnCadastros,
            this.btnImprimir});
			this.mnuPrincipal.Location = new System.Drawing.Point(0, 40);
			this.mnuPrincipal.Name = "mnuPrincipal";
			this.mnuPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.mnuPrincipal.Size = new System.Drawing.Size(1110, 56);
			this.mnuPrincipal.TabIndex = 2;
			this.mnuPrincipal.Text = "Menu Principal";
			// 
			// btnSair
			// 
			this.btnSair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.btnSair.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSair.Image = global::CamadaUI.Properties.Resources.sair_32;
			this.btnSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSair.Margin = new System.Windows.Forms.Padding(5);
			this.btnSair.Name = "btnSair";
			this.btnSair.Padding = new System.Windows.Forms.Padding(5);
			this.btnSair.Size = new System.Drawing.Size(85, 46);
			this.btnSair.Text = "&Sair";
			this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSair.ToolTipText = "Sair do Aplicativo";
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// btnCadastros
			// 
			this.btnCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadastroAdicionar,
            this.editarMembroToolStripMenuItem,
            this.toolStripSeparator1,
            this.cadastroDeFunçõesToolStripMenuItem,
            this.cadstrosDeCongregaçõesToolStripMenuItem});
			this.btnCadastros.Image = global::CamadaUI.Properties.Resources.contribuinte_32;
			this.btnCadastros.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnCadastros.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnCadastros.Margin = new System.Windows.Forms.Padding(5);
			this.btnCadastros.Name = "btnCadastros";
			this.btnCadastros.Size = new System.Drawing.Size(138, 46);
			this.btnCadastros.Text = "Cadastros";
			// 
			// mnuCadastroAdicionar
			// 
			this.mnuCadastroAdicionar.Font = new System.Drawing.Font("Calibri", 12F);
			this.mnuCadastroAdicionar.Image = global::CamadaUI.Properties.Resources.add_user;
			this.mnuCadastroAdicionar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.mnuCadastroAdicionar.Name = "mnuCadastroAdicionar";
			this.mnuCadastroAdicionar.Padding = new System.Windows.Forms.Padding(0);
			this.mnuCadastroAdicionar.Size = new System.Drawing.Size(266, 36);
			this.mnuCadastroAdicionar.Text = "Adicionar Membro";
			// 
			// editarMembroToolStripMenuItem
			// 
			this.editarMembroToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F);
			this.editarMembroToolStripMenuItem.Image = global::CamadaUI.Properties.Resources.edit_profile;
			this.editarMembroToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.editarMembroToolStripMenuItem.Name = "editarMembroToolStripMenuItem";
			this.editarMembroToolStripMenuItem.Size = new System.Drawing.Size(266, 38);
			this.editarMembroToolStripMenuItem.Text = "Editar Membro";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(263, 6);
			// 
			// cadastroDeFunçõesToolStripMenuItem
			// 
			this.cadastroDeFunçõesToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F);
			this.cadastroDeFunçõesToolStripMenuItem.Image = global::CamadaUI.Properties.Resources.funcoes_32;
			this.cadastroDeFunçõesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.cadastroDeFunçõesToolStripMenuItem.Name = "cadastroDeFunçõesToolStripMenuItem";
			this.cadastroDeFunçõesToolStripMenuItem.Size = new System.Drawing.Size(266, 38);
			this.cadastroDeFunçõesToolStripMenuItem.Text = "Cadastro de Funções";
			// 
			// cadstrosDeCongregaçõesToolStripMenuItem
			// 
			this.cadstrosDeCongregaçõesToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F);
			this.cadstrosDeCongregaçõesToolStripMenuItem.Image = global::CamadaUI.Properties.Resources.igreja_32;
			this.cadstrosDeCongregaçõesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.cadstrosDeCongregaçõesToolStripMenuItem.Name = "cadstrosDeCongregaçõesToolStripMenuItem";
			this.cadstrosDeCongregaçõesToolStripMenuItem.Size = new System.Drawing.Size(266, 38);
			this.cadstrosDeCongregaçõesToolStripMenuItem.Text = "Cadstros de Congregações";
			// 
			// btnImprimir
			// 
			this.btnImprimir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuImpressaoInserir,
            this.mnuContribuicaoProcurar});
			this.btnImprimir.Image = global::CamadaUI.Properties.Resources.Imprimir;
			this.btnImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnImprimir.Margin = new System.Windows.Forms.Padding(5);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
			this.btnImprimir.Padding = new System.Windows.Forms.Padding(5);
			this.btnImprimir.Size = new System.Drawing.Size(143, 46);
			this.btnImprimir.Text = "Imprimir";
			this.btnImprimir.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
			// 
			// mnuImpressaoInserir
			// 
			this.mnuImpressaoInserir.Font = new System.Drawing.Font("Calibri", 12F);
			this.mnuImpressaoInserir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.mnuImpressaoInserir.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.mnuImpressaoInserir.Name = "mnuImpressaoInserir";
			this.mnuImpressaoInserir.Padding = new System.Windows.Forms.Padding(0);
			this.mnuImpressaoInserir.Size = new System.Drawing.Size(217, 22);
			this.mnuImpressaoInserir.Text = "Inserir Impressão";
			// 
			// mnuContribuicaoProcurar
			// 
			this.mnuContribuicaoProcurar.Font = new System.Drawing.Font("Calibri", 12F);
			this.mnuContribuicaoProcurar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.mnuContribuicaoProcurar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.mnuContribuicaoProcurar.Name = "mnuContribuicaoProcurar";
			this.mnuContribuicaoProcurar.Size = new System.Drawing.Size(217, 24);
			this.mnuContribuicaoProcurar.Text = "Procurar Contribuição";
			// 
			// frmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1110, 732);
			this.Controls.Add(this.mnuPrincipal);
			this.Controls.Add(this.pnlTop);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "frmPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Principal";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmPrincipal_Load);
			this.pnlTop.ResumeLayout(false);
			this.pnlTop.PerformLayout();
			this.mnuPrincipal.ResumeLayout(false);
			this.mnuPrincipal.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button btnConfig;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnMinimizer;
		private System.Windows.Forms.Label lblTitulo;
		public System.Windows.Forms.Panel pnlTop;
		public System.Windows.Forms.ToolStrip mnuPrincipal;
		private System.Windows.Forms.ToolStripButton btnSair;
		private System.Windows.Forms.ToolStripSplitButton btnCadastros;
		private System.Windows.Forms.ToolStripMenuItem mnuCadastroAdicionar;
		private System.Windows.Forms.ToolStripSplitButton btnImprimir;
		private System.Windows.Forms.ToolStripMenuItem mnuImpressaoInserir;
		private System.Windows.Forms.ToolStripMenuItem mnuContribuicaoProcurar;
		private System.Windows.Forms.ToolStripMenuItem editarMembroToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem cadastroDeFunçõesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cadstrosDeCongregaçõesToolStripMenuItem;
	}
}

