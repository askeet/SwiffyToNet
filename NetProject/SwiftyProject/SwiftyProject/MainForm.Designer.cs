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
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(32, 23);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(136, 62);
            this.OpenFile.TabIndex = 0;
            this.OpenFile.Text = "Open File HTML";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(218, 23);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.ScrollBarsEnabled = false;
            this.webBrowser.Size = new System.Drawing.Size(350, 250);
            this.webBrowser.TabIndex = 1;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "HTML files|*.html";
            // 
            // ExampleSetVariable
            // 
            this.ExampleSetVariable.Location = new System.Drawing.Point(32, 102);
            this.ExampleSetVariable.Name = "ExampleSetVariable";
            this.ExampleSetVariable.Size = new System.Drawing.Size(136, 62);
            this.ExampleSetVariable.TabIndex = 2;
            this.ExampleSetVariable.Text = "Set Var";
            this.ExampleSetVariable.UseVisualStyleBackColor = true;
            this.ExampleSetVariable.Click += new System.EventHandler(this.ExampleSetVariable_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 62);
            this.button1.TabIndex = 3;
            this.button1.Text = "Set Var";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 62);
            this.button2.TabIndex = 4;
            this.button2.Text = "Set Var";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(628, 309);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ExampleSetVariable);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.OpenFile);
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
        private System.Windows.Forms.Button button2;
    }
}

