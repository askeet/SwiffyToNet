namespace SwiftyProject
{
    partial class MainForm
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
            this.OpenFile = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ExampleSetVariable = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(21, 15);
            this.OpenFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(91, 40);
            this.OpenFile.TabIndex = 0;
            this.OpenFile.Text = "Open File HTML";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(145, 15);
            this.webBrowser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.webBrowser.MinimumSize = new System.Drawing.Size(13, 13);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Size = new System.Drawing.Size(246, 178);
            this.webBrowser.TabIndex = 1;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "HTML files|*.html";
            // 
            // ExampleSetVariable
            // 
            this.ExampleSetVariable.Location = new System.Drawing.Point(21, 66);
            this.ExampleSetVariable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExampleSetVariable.Name = "ExampleSetVariable";
            this.ExampleSetVariable.Size = new System.Drawing.Size(91, 40);
            this.ExampleSetVariable.TabIndex = 2;
            this.ExampleSetVariable.Text = "Set Var";
            this.ExampleSetVariable.UseVisualStyleBackColor = true;
            this.ExampleSetVariable.Click += new System.EventHandler(this.ExampleSetVariable_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 110);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Set Var";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 201);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ExampleSetVariable);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.OpenFile);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button ExampleSetVariable;
        private System.Windows.Forms.Button button1;
    }
}

