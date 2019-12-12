namespace FacialRecognition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CameraBox = new System.Windows.Forms.PictureBox();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.btnTrain = new System.Windows.Forms.Button();
            this.OutputBox = new System.Windows.Forms.RichTextBox();
            this.btnFaceSquare = new System.Windows.Forms.Button();
            this.btnEyeSquare = new System.Windows.Forms.Button();
            this.btnPredict = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CameraBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CameraBox
            // 
            this.CameraBox.Location = new System.Drawing.Point(11, 85);
            this.CameraBox.Name = "CameraBox";
            this.CameraBox.Size = new System.Drawing.Size(946, 760);
            this.CameraBox.TabIndex = 0;
            this.CameraBox.TabStop = false;
            // 
            // IdBox
            // 
            this.IdBox.Location = new System.Drawing.Point(984, 85);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(371, 26);
            this.IdBox.TabIndex = 1;
            // 
            // btnTrain
            // 
            this.btnTrain.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTrain.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTrain.ForeColor = System.Drawing.Color.Snow;
            this.btnTrain.Location = new System.Drawing.Point(984, 155);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(370, 46);
            this.btnTrain.TabIndex = 2;
            this.btnTrain.Text = "Train";
            this.btnTrain.UseVisualStyleBackColor = false;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(984, 263);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(369, 326);
            this.OutputBox.TabIndex = 3;
            this.OutputBox.Text = "";
            // 
            // btnFaceSquare
            // 
            this.btnFaceSquare.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFaceSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFaceSquare.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFaceSquare.Location = new System.Drawing.Point(991, 623);
            this.btnFaceSquare.Name = "btnFaceSquare";
            this.btnFaceSquare.Size = new System.Drawing.Size(178, 44);
            this.btnFaceSquare.TabIndex = 4;
            this.btnFaceSquare.Text = "Face Square: off";
            this.btnFaceSquare.UseVisualStyleBackColor = false;
            this.btnFaceSquare.Click += new System.EventHandler(this.btnFaceSquare_Click);
            // 
            // btnEyeSquare
            // 
            this.btnEyeSquare.BackColor = System.Drawing.Color.Teal;
            this.btnEyeSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEyeSquare.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEyeSquare.Location = new System.Drawing.Point(1181, 623);
            this.btnEyeSquare.Name = "btnEyeSquare";
            this.btnEyeSquare.Size = new System.Drawing.Size(172, 44);
            this.btnEyeSquare.TabIndex = 5;
            this.btnEyeSquare.Text = "Eye Squares: Off";
            this.btnEyeSquare.UseVisualStyleBackColor = false;
            this.btnEyeSquare.Click += new System.EventHandler(this.btnEyeSquare_Click);
            // 
            // btnPredict
            // 
            this.btnPredict.BackColor = System.Drawing.Color.Tomato;
            this.btnPredict.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPredict.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPredict.Location = new System.Drawing.Point(984, 721);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(369, 52);
            this.btnPredict.TabIndex = 6;
            this.btnPredict.Text = "Predict Face";
            this.btnPredict.UseVisualStyleBackColor = false;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "Camera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(986, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "UserId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(987, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1375, 862);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPredict);
            this.Controls.Add(this.btnEyeSquare);
            this.Controls.Add(this.btnFaceSquare);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.CameraBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CameraBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CameraBox;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.RichTextBox OutputBox;
        private System.Windows.Forms.Button btnFaceSquare;
        private System.Windows.Forms.Button btnEyeSquare;
        private System.Windows.Forms.Button btnPredict;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

