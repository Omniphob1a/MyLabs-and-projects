namespace СиАОД_18
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateQueue = new System.Windows.Forms.Button();
            this.ClearQueue = new System.Windows.Forms.Button();
            this.LargestElement = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.numericUpDownNew = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownBefore = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTo = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewArray = new System.Windows.Forms.DataGridView();
            this.Exit = new System.Windows.Forms.Button();
            this.dataGridViewTree = new System.Windows.Forms.DataGridView();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBefore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateQueue
            // 
            this.CreateQueue.Location = new System.Drawing.Point(12, 12);
            this.CreateQueue.Name = "CreateQueue";
            this.CreateQueue.Size = new System.Drawing.Size(215, 34);
            this.CreateQueue.TabIndex = 0;
            this.CreateQueue.Text = "Создать очередь";
            this.CreateQueue.UseVisualStyleBackColor = true;
            this.CreateQueue.Click += new System.EventHandler(this.CreateQueue_Click);
            // 
            // ClearQueue
            // 
            this.ClearQueue.Location = new System.Drawing.Point(534, 12);
            this.ClearQueue.Name = "ClearQueue";
            this.ClearQueue.Size = new System.Drawing.Size(215, 34);
            this.ClearQueue.TabIndex = 1;
            this.ClearQueue.Text = "Очистить очередь";
            this.ClearQueue.UseVisualStyleBackColor = true;
            this.ClearQueue.Click += new System.EventHandler(this.ClearQueue_Click);
            // 
            // LargestElement
            // 
            this.LargestElement.Location = new System.Drawing.Point(1001, 12);
            this.LargestElement.Name = "LargestElement";
            this.LargestElement.Size = new System.Drawing.Size(215, 34);
            this.LargestElement.TabIndex = 2;
            this.LargestElement.Text = "Извлечь наибольший";
            this.LargestElement.UseVisualStyleBackColor = true;
            this.LargestElement.Click += new System.EventHandler(this.LargestElement_Click);
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(12, 52);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(276, 34);
            this.Insert.TabIndex = 3;
            this.Insert.Text = "Вставить новый";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(503, 52);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(350, 34);
            this.Change.TabIndex = 4;
            this.Change.Text = "Изменить приоритет";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // numericUpDownNew
            // 
            this.numericUpDownNew.Location = new System.Drawing.Point(316, 61);
            this.numericUpDownNew.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNew.Name = "numericUpDownNew";
            this.numericUpDownNew.Size = new System.Drawing.Size(119, 22);
            this.numericUpDownNew.TabIndex = 5;
            this.numericUpDownNew.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(900, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "с";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1066, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "до";
            // 
            // numericUpDownBefore
            // 
            this.numericUpDownBefore.Location = new System.Drawing.Point(920, 59);
            this.numericUpDownBefore.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBefore.Name = "numericUpDownBefore";
            this.numericUpDownBefore.Size = new System.Drawing.Size(112, 22);
            this.numericUpDownBefore.TabIndex = 8;
            this.numericUpDownBefore.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownTo
            // 
            this.numericUpDownTo.Location = new System.Drawing.Point(1095, 59);
            this.numericUpDownTo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTo.Name = "numericUpDownTo";
            this.numericUpDownTo.Size = new System.Drawing.Size(121, 22);
            this.numericUpDownTo.TabIndex = 9;
            this.numericUpDownTo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(519, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Представление в виде массива";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(519, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Представление в виде дерева";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(541, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Результат выборки";
            // 
            // dataGridViewArray
            // 
            this.dataGridViewArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArray.ColumnHeadersVisible = false;
            this.dataGridViewArray.Location = new System.Drawing.Point(12, 116);
            this.dataGridViewArray.Name = "dataGridViewArray";
            this.dataGridViewArray.RowHeadersVisible = false;
            this.dataGridViewArray.RowHeadersWidth = 51;
            this.dataGridViewArray.RowTemplate.Height = 24;
            this.dataGridViewArray.Size = new System.Drawing.Size(1204, 30);
            this.dataGridViewArray.TabIndex = 13;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(577, 381);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 14;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // dataGridViewTree
            // 
            this.dataGridViewTree.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTree.ColumnHeadersVisible = false;
            this.dataGridViewTree.Location = new System.Drawing.Point(12, 189);
            this.dataGridViewTree.Name = "dataGridViewTree";
            this.dataGridViewTree.RowHeadersVisible = false;
            this.dataGridViewTree.RowHeadersWidth = 51;
            this.dataGridViewTree.RowTemplate.Height = 24;
            this.dataGridViewTree.Size = new System.Drawing.Size(1204, 123);
            this.dataGridViewTree.TabIndex = 15;
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.ColumnHeadersVisible = false;
            this.dataGridViewResult.Location = new System.Drawing.Point(12, 340);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.RowHeadersVisible = false;
            this.dataGridViewResult.RowHeadersWidth = 51;
            this.dataGridViewResult.RowTemplate.Height = 24;
            this.dataGridViewResult.Size = new System.Drawing.Size(1204, 35);
            this.dataGridViewResult.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1228, 410);
            this.Controls.Add(this.dataGridViewResult);
            this.Controls.Add(this.dataGridViewTree);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.dataGridViewArray);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownTo);
            this.Controls.Add(this.numericUpDownBefore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownNew);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.LargestElement);
            this.Controls.Add(this.ClearQueue);
            this.Controls.Add(this.CreateQueue);
            this.Name = "Form1";
            this.Text = "Шмоленко; ЛБ18-20";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBefore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateQueue;
        private System.Windows.Forms.Button ClearQueue;
        private System.Windows.Forms.Button LargestElement;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.NumericUpDown numericUpDownNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownBefore;
        private System.Windows.Forms.NumericUpDown numericUpDownTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewArray;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.DataGridView dataGridViewTree;
        private System.Windows.Forms.DataGridView dataGridViewResult;
    }
}

