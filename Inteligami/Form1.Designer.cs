namespace Inteligami
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
            this.materialsGrid = new System.Windows.Forms.DataGridView();
            this.expensesGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.calcAmountNud = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.materialsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcAmountNud)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Todos os materiais:";
            // 
            // materialsGrid
            // 
            this.materialsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialsGrid.Location = new System.Drawing.Point(16, 31);
            this.materialsGrid.Name = "materialsGrid";
            this.materialsGrid.Size = new System.Drawing.Size(772, 108);
            this.materialsGrid.TabIndex = 1;
            // 
            // expensesGrid
            // 
            this.expensesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expensesGrid.Location = new System.Drawing.Point(16, 200);
            this.expensesGrid.Name = "expensesGrid";
            this.expensesGrid.Size = new System.Drawing.Size(772, 108);
            this.expensesGrid.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cálculo:";
            // 
            // calcAmountNud
            // 
            this.calcAmountNud.Location = new System.Drawing.Point(133, 312);
            this.calcAmountNud.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.calcAmountNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.calcAmountNud.Name = "calcAmountNud";
            this.calcAmountNud.Size = new System.Drawing.Size(120, 20);
            this.calcAmountNud.TabIndex = 4;
            this.calcAmountNud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantidade de vezes:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calcAmountNud);
            this.Controls.Add(this.expensesGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.materialsGrid);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.materialsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcAmountNud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView materialsGrid;
        private System.Windows.Forms.DataGridView expensesGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown calcAmountNud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

