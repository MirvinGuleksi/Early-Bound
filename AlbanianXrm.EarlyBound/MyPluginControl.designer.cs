﻿namespace AlbanianXrm.EarlyBound
{
    partial class MyPluginControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo2 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
            Syncfusion.Windows.Forms.Tools.TreeViewAdvVisualStyle treeViewAdvVisualStyle2 = new Syncfusion.Windows.Forms.Tools.TreeViewAdvVisualStyle();
            this.metadataTree = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
            this.toolStripEx1 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.splitContainer = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.txtNamespace = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblNamespace = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtOutputPath = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblOutputPath = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.metadataTree)).BeginInit();
            this.toolStripEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamespace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOutputPath)).BeginInit();
            this.SuspendLayout();
            // 
            // metadataTree
            // 
            this.metadataTree.AllowMouseBasedSelection = true;
            treeNodeAdvStyleInfo2.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo2.EnsureDefaultOptionedChild = true;
            treeNodeAdvStyleInfo2.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo2.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo2.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.metadataTree.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo2)});
            this.metadataTree.BeforeTouchSize = new System.Drawing.Size(200, 275);
            this.metadataTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metadataTree.Enabled = false;
            // 
            // 
            // 
            this.metadataTree.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metadataTree.HelpTextControl.Location = new System.Drawing.Point(0, 0);
            this.metadataTree.HelpTextControl.Name = "helpText";
            this.metadataTree.HelpTextControl.Size = new System.Drawing.Size(49, 15);
            this.metadataTree.HelpTextControl.TabIndex = 0;
            this.metadataTree.HelpTextControl.Text = "help text";
            this.metadataTree.InactiveSelectedNodeForeColor = System.Drawing.SystemColors.ControlText;
            this.metadataTree.Indent = 24;
            this.metadataTree.ItemHeight = 27;
            this.metadataTree.LoadOnDemand = true;
            this.metadataTree.Location = new System.Drawing.Point(0, 0);
            this.metadataTree.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.metadataTree.Name = "metadataTree";
            this.metadataTree.SelectedNodeForeColor = System.Drawing.SystemColors.HighlightText;
            this.metadataTree.Size = new System.Drawing.Size(200, 275);
            this.metadataTree.TabIndex = 0;
            this.metadataTree.Text = "treeViewAdv1";
            treeViewAdvVisualStyle2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            treeViewAdvVisualStyle2.TreeNodeAdvStyle.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeViewAdvVisualStyle2.TreeNodeAdvStyle.EnsureDefaultOptionedChild = true;
            treeViewAdvVisualStyle2.TreeNodeAdvStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeViewAdvVisualStyle2.TreeNodeAdvStyle.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeViewAdvVisualStyle2.TreeNodeAdvStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.metadataTree.ThemeStyle = treeViewAdvVisualStyle2;
            // 
            // 
            // 
            this.metadataTree.ToolTipControl.BackColor = System.Drawing.SystemColors.Info;
            this.metadataTree.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metadataTree.ToolTipControl.Location = new System.Drawing.Point(0, 0);
            this.metadataTree.ToolTipControl.Name = "toolTip";
            this.metadataTree.ToolTipControl.Size = new System.Drawing.Size(41, 15);
            this.metadataTree.ToolTipControl.TabIndex = 1;
            this.metadataTree.ToolTipControl.Text = "toolTip";
            this.metadataTree.BeforeExpand += new Syncfusion.Windows.Forms.Tools.TreeViewAdvCancelableNodeEventHandler(this.treeViewAdv1_BeforeExpand);
            // 
            // toolStripEx1
            // 
            this.toolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx1.Image = null;
            this.toolStripEx1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStripEx1.Location = new System.Drawing.Point(0, 0);
            this.toolStripEx1.Name = "toolStripEx1";
            this.toolStripEx1.Office12Mode = false;
            this.toolStripEx1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripEx1.Size = new System.Drawing.Size(559, 25);
            this.toolStripEx1.TabIndex = 6;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(82, 22);
            this.toolStripButton1.Text = "Get Metadata";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(85, 22);
            this.toolStripButton2.Text = "Get CoreTools";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(58, 22);
            this.toolStripButton3.Text = "Generate";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.BeforeTouchSize = 7;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = Syncfusion.Windows.Forms.Tools.Enums.FixedPanel.Panel2;
            this.splitContainer.Location = new System.Drawing.Point(0, 25);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.metadataTree);
            this.splitContainer.Panel1.Margin = new System.Windows.Forms.Padding(2);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.txtNamespace);
            this.splitContainer.Panel2.Controls.Add(this.lblNamespace);
            this.splitContainer.Panel2.Controls.Add(this.txtOutputPath);
            this.splitContainer.Panel2.Controls.Add(this.lblOutputPath);
            this.splitContainer.Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer.PanelToBeCollapsed = Syncfusion.Windows.Forms.Tools.Enums.CollapsedPanel.Panel1;
            this.splitContainer.Size = new System.Drawing.Size(559, 275);
            this.splitContainer.SplitterDistance = 200;
            this.splitContainer.TabIndex = 7;
            this.splitContainer.Text = "splitContainer";
            this.splitContainer.ThemeName = "None";
            // 
            // txtNamespace
            // 
            this.txtNamespace.BeforeTouchSize = new System.Drawing.Size(150, 26);
            this.txtNamespace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamespace.Location = new System.Drawing.Point(100, 36);
            this.txtNamespace.Margin = new System.Windows.Forms.Padding(2);
            this.txtNamespace.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtNamespace.Name = "txtNamespace";
            this.txtNamespace.Size = new System.Drawing.Size(150, 26);
            this.txtNamespace.TabIndex = 3;
            this.txtNamespace.TextChanged += new System.EventHandler(this.txtNamespace_TextChanged);
            // 
            // lblNamespace
            // 
            this.lblNamespace.DX = -98;
            this.lblNamespace.DY = 3;
            this.lblNamespace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamespace.LabeledControl = this.txtNamespace;
            this.lblNamespace.Location = new System.Drawing.Point(2, 39);
            this.lblNamespace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNamespace.Name = "lblNamespace";
            this.lblNamespace.Size = new System.Drawing.Size(94, 20);
            this.lblNamespace.TabIndex = 2;
            this.lblNamespace.Text = "Namespace";
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.BeforeTouchSize = new System.Drawing.Size(150, 26);
            this.txtOutputPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputPath.Location = new System.Drawing.Point(100, 6);
            this.txtOutputPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtOutputPath.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.Size = new System.Drawing.Size(150, 26);
            this.txtOutputPath.TabIndex = 1;
            this.txtOutputPath.TextChanged += new System.EventHandler(this.txtOutputPath_TextChanged);
            // 
            // lblOutputPath
            // 
            this.lblOutputPath.DX = -99;
            this.lblOutputPath.DY = 3;
            this.lblOutputPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputPath.LabeledControl = this.txtOutputPath;
            this.lblOutputPath.Location = new System.Drawing.Point(1, 9);
            this.lblOutputPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutputPath.Name = "lblOutputPath";
            this.lblOutputPath.Size = new System.Drawing.Size(95, 20);
            this.lblOutputPath.TabIndex = 0;
            this.lblOutputPath.Text = "Output Path";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(80, 22);
            this.toolStripButton4.Text = "Save Settings";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // MyPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.toolStripEx1);
            this.Name = "MyPluginControl";
            this.Size = new System.Drawing.Size(559, 300);
            this.OnCloseTool += new System.EventHandler(this.MyPluginControl_OnCloseTool);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metadataTree)).EndInit();
            this.toolStripEx1.ResumeLayout(false);
            this.toolStripEx1.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtNamespace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOutputPath)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.TreeViewAdv metadataTree;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private Syncfusion.Windows.Forms.Tools.SplitContainerAdv splitContainer;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblOutputPath;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtOutputPath;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtNamespace;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblNamespace;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
    }
}