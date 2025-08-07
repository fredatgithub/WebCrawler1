namespace WebCrawler1
{
  partial class FormMain
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

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
      this.textBoxUrl = new System.Windows.Forms.TextBox();
      this.buttonStart = new System.Windows.Forms.Button();
      this.listBoxResult = new System.Windows.Forms.ListBox();
      this.webBrowser1 = new System.Windows.Forms.WebBrowser();
      this.SuspendLayout();
      // 
      // textBoxUrl
      // 
      this.textBoxUrl.Location = new System.Drawing.Point(13, 24);
      this.textBoxUrl.Name = "textBoxUrl";
      this.textBoxUrl.Size = new System.Drawing.Size(700, 20);
      this.textBoxUrl.TabIndex = 0;
      // 
      // buttonStart
      // 
      this.buttonStart.Location = new System.Drawing.Point(720, 20);
      this.buttonStart.Name = "buttonStart";
      this.buttonStart.Size = new System.Drawing.Size(75, 23);
      this.buttonStart.TabIndex = 1;
      this.buttonStart.Text = "Start";
      this.buttonStart.UseVisualStyleBackColor = true;
      this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
      // 
      // listBoxResult
      // 
      this.listBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.listBoxResult.FormattingEnabled = true;
      this.listBoxResult.Location = new System.Drawing.Point(572, 61);
      this.listBoxResult.Name = "listBoxResult";
      this.listBoxResult.Size = new System.Drawing.Size(223, 576);
      this.listBoxResult.TabIndex = 2;
      // 
      // webBrowser1
      // 
      this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.webBrowser1.Location = new System.Drawing.Point(13, 61);
      this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
      this.webBrowser1.Name = "webBrowser1";
      this.webBrowser1.Size = new System.Drawing.Size(540, 585);
      this.webBrowser1.TabIndex = 3;
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(823, 658);
      this.Controls.Add(this.webBrowser1);
      this.Controls.Add(this.listBoxResult);
      this.Controls.Add(this.buttonStart);
      this.Controls.Add(this.textBoxUrl);
      this.Name = "FormMain";
      this.Text = "Web crawler";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBoxUrl;
    private System.Windows.Forms.Button buttonStart;
    private System.Windows.Forms.ListBox listBoxResult;
    private System.Windows.Forms.WebBrowser webBrowser1;
  }
}

