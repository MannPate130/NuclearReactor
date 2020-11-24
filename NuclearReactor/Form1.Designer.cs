
namespace NuclearReactor
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.reactorLabel1 = new System.Windows.Forms.Label();
            this.reactorLabel2 = new System.Windows.Forms.Label();
            this.reactor1StateLabel = new System.Windows.Forms.Label();
            this.reactor2StateLabel = new System.Windows.Forms.Label();
            this.enableButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(292, 55);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(474, 46);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Nuclear Reactor Control";
            // 
            // reactorLabel1
            // 
            this.reactorLabel1.AutoSize = true;
            this.reactorLabel1.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold);
            this.reactorLabel1.Location = new System.Drawing.Point(244, 173);
            this.reactorLabel1.Name = "reactorLabel1";
            this.reactorLabel1.Size = new System.Drawing.Size(148, 34);
            this.reactorLabel1.TabIndex = 1;
            this.reactorLabel1.Text = "Reactor 1";
            // 
            // reactorLabel2
            // 
            this.reactorLabel2.AutoSize = true;
            this.reactorLabel2.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold);
            this.reactorLabel2.Location = new System.Drawing.Point(683, 173);
            this.reactorLabel2.Name = "reactorLabel2";
            this.reactorLabel2.Size = new System.Drawing.Size(148, 34);
            this.reactorLabel2.TabIndex = 2;
            this.reactorLabel2.Text = "Reactor 2";
            // 
            // reactor1StateLabel
            // 
            this.reactor1StateLabel.BackColor = System.Drawing.Color.Green;
            this.reactor1StateLabel.Location = new System.Drawing.Point(245, 232);
            this.reactor1StateLabel.Name = "reactor1StateLabel";
            this.reactor1StateLabel.Size = new System.Drawing.Size(147, 157);
            this.reactor1StateLabel.TabIndex = 3;
            // 
            // reactor2StateLabel
            // 
            this.reactor2StateLabel.BackColor = System.Drawing.Color.Green;
            this.reactor2StateLabel.Location = new System.Drawing.Point(684, 232);
            this.reactor2StateLabel.Name = "reactor2StateLabel";
            this.reactor2StateLabel.Size = new System.Drawing.Size(147, 157);
            this.reactor2StateLabel.TabIndex = 4;
            // 
            // enableButton
            // 
            this.enableButton.BackColor = System.Drawing.Color.Tan;
            this.enableButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.enableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableButton.Location = new System.Drawing.Point(419, 408);
            this.enableButton.Name = "enableButton";
            this.enableButton.Size = new System.Drawing.Size(231, 61);
            this.enableButton.TabIndex = 5;
            this.enableButton.Text = "Enable";
            this.enableButton.UseVisualStyleBackColor = false;
            this.enableButton.Click += new System.EventHandler(this.enableButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.White;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.outputLabel.Location = new System.Drawing.Point(343, 517);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(383, 63);
            this.outputLabel.TabIndex = 6;
            this.outputLabel.Text = "Reactors Stable";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1069, 611);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.enableButton);
            this.Controls.Add(this.reactor2StateLabel);
            this.Controls.Add(this.reactor1StateLabel);
            this.Controls.Add(this.reactorLabel2);
            this.Controls.Add(this.reactorLabel1);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Control Panel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label reactorLabel1;
        private System.Windows.Forms.Label reactorLabel2;
        private System.Windows.Forms.Label reactor1StateLabel;
        private System.Windows.Forms.Label reactor2StateLabel;
        private System.Windows.Forms.Button enableButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

