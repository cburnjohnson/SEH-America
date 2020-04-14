namespace SEH_America_Code_Test
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.titleInput = new System.Windows.Forms.TextBox();
            this.bodyText = new System.Windows.Forms.TextBox();
            this.suggestImagesBtn = new System.Windows.Forms.Button();
            this.generateSlide = new System.Windows.Forms.Button();
            this.imageOne = new System.Windows.Forms.PictureBox();
            this.imageTwo = new System.Windows.Forms.PictureBox();
            this.imageThree = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageThree)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(632, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Power Point Slide Generator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Text:";
            // 
            // titleInput
            // 
            this.titleInput.Location = new System.Drawing.Point(192, 125);
            this.titleInput.Name = "titleInput";
            this.titleInput.Size = new System.Drawing.Size(562, 20);
            this.titleInput.TabIndex = 3;
            // 
            // bodyText
            // 
            this.bodyText.Location = new System.Drawing.Point(192, 186);
            this.bodyText.Multiline = true;
            this.bodyText.Name = "bodyText";
            this.bodyText.Size = new System.Drawing.Size(562, 82);
            this.bodyText.TabIndex = 4;
            this.bodyText.TextChanged += new System.EventHandler(this.bodyText_TextChanged);
            // 
            // suggestImagesBtn
            // 
            this.suggestImagesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.suggestImagesBtn.Location = new System.Drawing.Point(85, 287);
            this.suggestImagesBtn.Name = "suggestImagesBtn";
            this.suggestImagesBtn.Size = new System.Drawing.Size(100, 43);
            this.suggestImagesBtn.TabIndex = 5;
            this.suggestImagesBtn.Text = "Suggest Images";
            this.suggestImagesBtn.UseVisualStyleBackColor = true;
            this.suggestImagesBtn.Click += new System.EventHandler(this.suggestImagesBtn_Click);
            // 
            // generateSlide
            // 
            this.generateSlide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateSlide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateSlide.Location = new System.Drawing.Point(191, 489);
            this.generateSlide.Name = "generateSlide";
            this.generateSlide.Size = new System.Drawing.Size(562, 43);
            this.generateSlide.TabIndex = 7;
            this.generateSlide.Text = "GENERATE SLIDE";
            this.generateSlide.UseVisualStyleBackColor = true;
            this.generateSlide.Click += new System.EventHandler(this.generateSlide_Click);
            // 
            // imageOne
            // 
            this.imageOne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageOne.Location = new System.Drawing.Point(191, 287);
            this.imageOne.Name = "imageOne";
            this.imageOne.Size = new System.Drawing.Size(192, 173);
            this.imageOne.TabIndex = 0;
            this.imageOne.TabStop = false;
            this.imageOne.Click += new System.EventHandler(this.imageOne_Click);
            // 
            // imageTwo
            // 
            this.imageTwo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageTwo.Location = new System.Drawing.Point(390, 287);
            this.imageTwo.Name = "imageTwo";
            this.imageTwo.Size = new System.Drawing.Size(204, 173);
            this.imageTwo.TabIndex = 8;
            this.imageTwo.TabStop = false;
            this.imageTwo.Click += new System.EventHandler(this.imageTwo_Click);
            // 
            // imageThree
            // 
            this.imageThree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageThree.Location = new System.Drawing.Point(600, 287);
            this.imageThree.Name = "imageThree";
            this.imageThree.Size = new System.Drawing.Size(211, 173);
            this.imageThree.TabIndex = 9;
            this.imageThree.TabStop = false;
            this.imageThree.Click += new System.EventHandler(this.imageThree_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 572);
            this.Controls.Add(this.imageThree);
            this.Controls.Add(this.imageTwo);
            this.Controls.Add(this.imageOne);
            this.Controls.Add(this.generateSlide);
            this.Controls.Add(this.suggestImagesBtn);
            this.Controls.Add(this.bodyText);
            this.Controls.Add(this.titleInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageThree)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox titleInput;
        private System.Windows.Forms.TextBox bodyText;
        private System.Windows.Forms.Button suggestImagesBtn;
        private System.Windows.Forms.Button generateSlide;
        private System.Windows.Forms.PictureBox imageOne;
        private System.Windows.Forms.PictureBox imageTwo;
        private System.Windows.Forms.PictureBox imageThree;
    }
}

