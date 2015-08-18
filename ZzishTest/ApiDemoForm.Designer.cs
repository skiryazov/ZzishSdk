namespace ZzishTest
{
    partial class ApiDemoForm
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
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnActivity = new System.Windows.Forms.Button();
            this.btnAction = new System.Windows.Forms.Button();
            this.lblGroupCode = new System.Windows.Forms.Label();
            this.txtGroupCode = new System.Windows.Forms.TextBox();
            this.pnlCommands = new System.Windows.Forms.Panel();
            this.pnlCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(0, 44);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(640, 523);
            this.txtResult.TabIndex = 8;
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(3, 6);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(75, 23);
            this.btnUser.TabIndex = 10;
            this.btnUser.Text = "User";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnActivity
            // 
            this.btnActivity.Location = new System.Drawing.Point(84, 6);
            this.btnActivity.Name = "btnActivity";
            this.btnActivity.Size = new System.Drawing.Size(75, 23);
            this.btnActivity.TabIndex = 12;
            this.btnActivity.Text = "Activity";
            this.btnActivity.UseVisualStyleBackColor = true;
            this.btnActivity.Click += new System.EventHandler(this.btnActivity_Click);
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(165, 6);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(75, 23);
            this.btnAction.TabIndex = 13;
            this.btnAction.Text = "Action";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // lblGroupCode
            // 
            this.lblGroupCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGroupCode.AutoSize = true;
            this.lblGroupCode.Location = new System.Drawing.Point(467, 11);
            this.lblGroupCode.Name = "lblGroupCode";
            this.lblGroupCode.Size = new System.Drawing.Size(64, 13);
            this.lblGroupCode.TabIndex = 14;
            this.lblGroupCode.Text = "GroupCode:";
            // 
            // txtGroupCode
            // 
            this.txtGroupCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGroupCode.Location = new System.Drawing.Point(537, 8);
            this.txtGroupCode.Name = "txtGroupCode";
            this.txtGroupCode.Size = new System.Drawing.Size(100, 20);
            this.txtGroupCode.TabIndex = 15;
            // 
            // pnlCommands
            // 
            this.pnlCommands.Controls.Add(this.lblGroupCode);
            this.pnlCommands.Controls.Add(this.btnAction);
            this.pnlCommands.Controls.Add(this.txtGroupCode);
            this.pnlCommands.Controls.Add(this.btnActivity);
            this.pnlCommands.Controls.Add(this.btnUser);
            this.pnlCommands.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCommands.Location = new System.Drawing.Point(0, 0);
            this.pnlCommands.Name = "pnlCommands";
            this.pnlCommands.Size = new System.Drawing.Size(640, 38);
            this.pnlCommands.TabIndex = 16;
            // 
            // ApiDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 567);
            this.Controls.Add(this.pnlCommands);
            this.Controls.Add(this.txtResult);
            this.Name = "ApiDemoForm";
            this.Text = "Zzish API Demo Form";
            this.Shown += new System.EventHandler(this.ApiDemoForm_Shown);
            this.pnlCommands.ResumeLayout(false);
            this.pnlCommands.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnActivity;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Label lblGroupCode;
        private System.Windows.Forms.TextBox txtGroupCode;
        private System.Windows.Forms.Panel pnlCommands;
    }
}

