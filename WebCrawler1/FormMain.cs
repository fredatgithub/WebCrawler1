using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace WebCrawler1
{
  public partial class FormMain: Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      listBoxResult.Items.Clear();
      textBoxUrl.Text = "https://github.com/anthropics"; // Default URL for testing
    }

    private async void ButtonStart_Click(object sender, EventArgs e)
    {
      string url = textBoxUrl.Text;
      if (!string.IsNullOrEmpty(url))
      {
        webBrowser1.Navigate(url);
        List<string> links = await CrawlWebsite(url);
        listBoxResult.Items.Clear();
        foreach (var link in links)
        {
          listBoxResult.Items.Add(link);
        }
      }
    }

    private static async Task<List<string>> CrawlWebsite(string url)
    {
      List<string> links = new List<string>();
      using (HttpClient client = new HttpClient())
      {
        try
        {
          var response = await client.GetStringAsync(url);
          var htmlDoc = new HtmlDocument();
          htmlDoc.LoadHtml(response);

          foreach (var link in htmlDoc.DocumentNode.SelectNodes("//a[@href]"))
          {
            string hrefValue = link.GetAttributeValue("href", string.Empty);
            if (!string.IsNullOrEmpty(hrefValue))
            {
              links.Add(hrefValue);
            }
          }
        }
        catch (Exception exception)
        {
          MessageBox.Show($"Erreur lors du crawling : {exception.Message}");
        }
      }

      return links;
    }
  }
}
