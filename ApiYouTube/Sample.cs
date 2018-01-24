using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace YouTubeApi
{
    public partial class Form1
    {
        private object aTextId;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void aButtonGetData_Click(object sender, EventArgs e)
        {
            string videoId = aTextId.Text;
            YouTubeVideo video = new YouTubeVideo(videoId);
            aLabelTitle.Text = video.title;
            aLabelPublishedDate.Text = video.publishedDate.ToShortDateString();
        }
    }
}
