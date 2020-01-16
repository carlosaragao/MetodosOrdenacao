namespace APS4Semestre
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
            this.label1 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.btnInsertionSort = new System.Windows.Forms.Button();
            this.btnShellSort = new System.Windows.Forms.Button();
            this.btnSelectionSort = new System.Windows.Forms.Button();
            this.btnHeapSort = new System.Windows.Forms.Button();
            this.btnBubbleSort = new System.Windows.Forms.Button();
            this.btnCocktails = new System.Windows.Forms.Button();
            this.btnCombSort = new System.Windows.Forms.Button();
            this.btnGnomeSort = new System.Windows.Forms.Button();
            this.btnOddEvenSort = new System.Windows.Forms.Button();
            this.btnQuickSort = new System.Windows.Forms.Button();
            this.method = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(602, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "We have a vector with length equal to 500000 positions,\r\nclick on any button to s" +
    "ort it and see its ordering time!";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(139, 380);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(113, 33);
            this.time.TabIndex = 1;
            this.time.Text = "Time: 0";
            // 
            // btnInsertionSort
            // 
            this.btnInsertionSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertionSort.Location = new System.Drawing.Point(19, 171);
            this.btnInsertionSort.Name = "btnInsertionSort";
            this.btnInsertionSort.Size = new System.Drawing.Size(120, 35);
            this.btnInsertionSort.TabIndex = 2;
            this.btnInsertionSort.Text = "Insertion Sort";
            this.btnInsertionSort.UseVisualStyleBackColor = true;
            this.btnInsertionSort.Click += new System.EventHandler(this.btnInsertionSort_Click);
            // 
            // btnShellSort
            // 
            this.btnShellSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShellSort.Location = new System.Drawing.Point(145, 171);
            this.btnShellSort.Name = "btnShellSort";
            this.btnShellSort.Size = new System.Drawing.Size(120, 35);
            this.btnShellSort.TabIndex = 3;
            this.btnShellSort.Text = "Shell Sort";
            this.btnShellSort.UseVisualStyleBackColor = true;
            this.btnShellSort.Click += new System.EventHandler(this.btnShellSort_Click);
            // 
            // btnSelectionSort
            // 
            this.btnSelectionSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectionSort.Location = new System.Drawing.Point(271, 171);
            this.btnSelectionSort.Name = "btnSelectionSort";
            this.btnSelectionSort.Size = new System.Drawing.Size(120, 35);
            this.btnSelectionSort.TabIndex = 4;
            this.btnSelectionSort.Text = "Selection Sort";
            this.btnSelectionSort.UseVisualStyleBackColor = true;
            this.btnSelectionSort.Click += new System.EventHandler(this.btnSelectionSort_Click);
            // 
            // btnHeapSort
            // 
            this.btnHeapSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeapSort.Location = new System.Drawing.Point(397, 171);
            this.btnHeapSort.Name = "btnHeapSort";
            this.btnHeapSort.Size = new System.Drawing.Size(120, 35);
            this.btnHeapSort.TabIndex = 5;
            this.btnHeapSort.Text = "Heap Sort";
            this.btnHeapSort.UseVisualStyleBackColor = true;
            this.btnHeapSort.Click += new System.EventHandler(this.btnHeapSort_Click);
            // 
            // btnBubbleSort
            // 
            this.btnBubbleSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBubbleSort.Location = new System.Drawing.Point(523, 171);
            this.btnBubbleSort.Name = "btnBubbleSort";
            this.btnBubbleSort.Size = new System.Drawing.Size(120, 35);
            this.btnBubbleSort.TabIndex = 6;
            this.btnBubbleSort.Text = "Bubble Sort";
            this.btnBubbleSort.UseVisualStyleBackColor = true;
            this.btnBubbleSort.Click += new System.EventHandler(this.btnBubbleSort_Click);
            // 
            // btnCocktails
            // 
            this.btnCocktails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCocktails.Location = new System.Drawing.Point(19, 212);
            this.btnCocktails.Name = "btnCocktails";
            this.btnCocktails.Size = new System.Drawing.Size(120, 35);
            this.btnCocktails.TabIndex = 7;
            this.btnCocktails.Text = "Cocktails";
            this.btnCocktails.UseVisualStyleBackColor = true;
            this.btnCocktails.Click += new System.EventHandler(this.btnCocktails_Click);
            // 
            // btnCombSort
            // 
            this.btnCombSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCombSort.Location = new System.Drawing.Point(145, 212);
            this.btnCombSort.Name = "btnCombSort";
            this.btnCombSort.Size = new System.Drawing.Size(120, 35);
            this.btnCombSort.TabIndex = 8;
            this.btnCombSort.Text = "Comb Sort";
            this.btnCombSort.UseVisualStyleBackColor = true;
            this.btnCombSort.Click += new System.EventHandler(this.btnCombSort_Click);
            // 
            // btnGnomeSort
            // 
            this.btnGnomeSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGnomeSort.Location = new System.Drawing.Point(271, 212);
            this.btnGnomeSort.Name = "btnGnomeSort";
            this.btnGnomeSort.Size = new System.Drawing.Size(120, 35);
            this.btnGnomeSort.TabIndex = 9;
            this.btnGnomeSort.Text = "Gnome Sort";
            this.btnGnomeSort.UseVisualStyleBackColor = true;
            this.btnGnomeSort.Click += new System.EventHandler(this.btnGnomeSort_Click);
            // 
            // btnOddEvenSort
            // 
            this.btnOddEvenSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOddEvenSort.Location = new System.Drawing.Point(397, 212);
            this.btnOddEvenSort.Name = "btnOddEvenSort";
            this.btnOddEvenSort.Size = new System.Drawing.Size(120, 35);
            this.btnOddEvenSort.TabIndex = 10;
            this.btnOddEvenSort.Text = "Odd-Even Sort";
            this.btnOddEvenSort.UseVisualStyleBackColor = true;
            this.btnOddEvenSort.Click += new System.EventHandler(this.btnOddEvenSort_Click);
            // 
            // btnQuickSort
            // 
            this.btnQuickSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickSort.Location = new System.Drawing.Point(523, 212);
            this.btnQuickSort.Name = "btnQuickSort";
            this.btnQuickSort.Size = new System.Drawing.Size(120, 35);
            this.btnQuickSort.TabIndex = 11;
            this.btnQuickSort.Text = "Quick Sort";
            this.btnQuickSort.UseVisualStyleBackColor = true;
            this.btnQuickSort.Click += new System.EventHandler(this.btnQuickSort_Click);
            // 
            // method
            // 
            this.method.AutoSize = true;
            this.method.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.method.Location = new System.Drawing.Point(235, 318);
            this.method.Name = "method";
            this.method.Size = new System.Drawing.Size(0, 33);
            this.method.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(654, 447);
            this.Controls.Add(this.method);
            this.Controls.Add(this.btnQuickSort);
            this.Controls.Add(this.btnOddEvenSort);
            this.Controls.Add(this.btnGnomeSort);
            this.Controls.Add(this.btnCombSort);
            this.Controls.Add(this.btnCocktails);
            this.Controls.Add(this.btnBubbleSort);
            this.Controls.Add(this.btnHeapSort);
            this.Controls.Add(this.btnSelectionSort);
            this.Controls.Add(this.btnShellSort);
            this.Controls.Add(this.btnInsertionSort);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "APS 4° Semestre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Button btnInsertionSort;
        private System.Windows.Forms.Button btnShellSort;
        private System.Windows.Forms.Button btnSelectionSort;
        private System.Windows.Forms.Button btnHeapSort;
        private System.Windows.Forms.Button btnBubbleSort;
        private System.Windows.Forms.Button btnCocktails;
        private System.Windows.Forms.Button btnCombSort;
        private System.Windows.Forms.Button btnGnomeSort;
        private System.Windows.Forms.Button btnOddEvenSort;
        private System.Windows.Forms.Button btnQuickSort;
        private System.Windows.Forms.Label method;
    }
}

