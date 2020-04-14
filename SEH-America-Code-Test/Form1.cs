using System;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Presentation;
using System.Net.Http;

namespace SEH_America_Code_Test
{
    public partial class Form1 : Form
    {
        string imageUrlOne = "";
        string imageUrlTwo = "";
        string imageUrlThree = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void suggestImagesBtn_Click(object sender, EventArgs e)
        {
            string titleText = titleInput.Text;
            string[] titleTextArr = titleText.Split(null);

            string queryString = string.Join("+", titleTextArr);



            string url = "https://pixabay.com/api/?key=16044426-244c292e5e138059720ae50ee&q=" + queryString;



            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string content = new StreamReader(response.GetResponseStream()).ReadToEnd();
         

            var jo = JObject.Parse(content);

            
            if (Convert.ToInt32(jo["totalHits"]) == 0)
            {
                MessageBox.Show("No available images");
            } else
            {
                var imageOneUrl = jo["hits"][0]["webformatURL"].ToString();
                var imageTwoUrl = jo["hits"][1]["webformatURL"].ToString();
                var imageThreeUrl = jo["hits"][2]["webformatURL"].ToString();





                imageOne.Load(imageOneUrl);
                imageTwo.Load(imageTwoUrl);
                imageThree.Load(imageThreeUrl);

                imageOne.SizeMode = PictureBoxSizeMode.StretchImage;
                imageTwo.SizeMode = PictureBoxSizeMode.StretchImage;
                imageThree.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            

        }

        private void generateSlide_Click(object sender, EventArgs e)
        {
            //Creates PowerPoint Presentation
            IPresentation pptxDoc = Presentation.Create();
            //Adds slide to the PowerPoint
            ISlide slide = pptxDoc.Slides.Add(SlideLayoutType.Blank);
            //Adds textbox to the slide
            IShape textboxShape = slide.AddTextBox(0, 0, 1024, 100);
            IShape textboxShape2 = slide.AddTextBox(0, 101, 1024, 200);
            

            if (imageUrlOne != "") 
            {
                WebClient myWebClient = new WebClient();
                byte[] bytes = myWebClient.DownloadData(imageUrlOne);

                Stream pictureStream = new MemoryStream(bytes);

                IPicture picture = slide.Pictures.AddPicture(pictureStream, 50, 301, 150, 150);

                pptxDoc.Save(titleInput.Text + ".pptx");

                pictureStream.Dispose();
            }

            if (imageUrlTwo != "")
            {
                WebClient myWebClient = new WebClient();
                byte[] bytes = myWebClient.DownloadData(imageUrlTwo);

                Stream pictureStream = new MemoryStream(bytes);

                IPicture picture = slide.Pictures.AddPicture(pictureStream, 250, 301, 150, 150);

                pptxDoc.Save(titleInput.Text + ".pptx");

                pictureStream.Dispose();
            }

            if (imageUrlThree != "")
            {
                WebClient myWebClient = new WebClient();
                byte[] bytes = myWebClient.DownloadData(imageUrlThree);

                Stream pictureStream = new MemoryStream(bytes);

                IPicture picture = slide.Pictures.AddPicture(pictureStream, 450, 301, 150, 150);

                pptxDoc.Save(titleInput.Text + ".pptx");

                pictureStream.Dispose();
            }

            //Adds paragraph to the textbody of text box
            IParagraph title = textboxShape.TextBody.AddParagraph();
            IParagraph body = textboxShape2.TextBody.AddParagraph();
            //Adds a TextPart to the paragraph
            ITextPart textPart = title.AddTextPart();
            ITextPart textPart2 = body.AddTextPart();
            //Adds text to the TextPart
            textPart.Text = titleInput.Text;
            textPart2.Text = bodyText.Text;
            // Formatting
            title.HorizontalAlignment = HorizontalAlignmentType.Center;
            body.HorizontalAlignment = HorizontalAlignmentType.Center;
            IFont titleFont = title.Font;
            titleFont.Bold = true;
            titleFont.FontSize = 40;


            //Saves the Presentation
            pptxDoc.Save(titleInput.Text + ".pptx");
            //Closes the Presentation
            pptxDoc.Close();




        }

        private void bodyText_TextChanged(object sender, EventArgs e)
        {

        }

        private void imageOne_Click(object sender, EventArgs e)
        {
            if (imageOne.BorderStyle == BorderStyle.Fixed3D)
            {
                imageUrlOne = "";
                imageOne.BorderStyle = BorderStyle.None;
            } else
            {
                imageUrlOne = Convert.ToString(imageOne.ImageLocation);
                imageOne.BorderStyle = BorderStyle.Fixed3D;
            }
            
            

        }

       


        private void imageTwo_Click(object sender, EventArgs e)
        {
            

            if (imageTwo.BorderStyle == BorderStyle.Fixed3D)
            {
                imageUrlTwo = "";
                imageTwo.BorderStyle = BorderStyle.None;
            }
            else
            {
                imageUrlTwo = Convert.ToString(imageTwo.ImageLocation);
                imageTwo.BorderStyle = BorderStyle.Fixed3D;
            }
        }

        private void imageThree_Click(object sender, EventArgs e)
        {
            if (imageThree.BorderStyle == BorderStyle.Fixed3D)
            {
                imageUrlThree = "";
                imageThree.BorderStyle = BorderStyle.None;
            }
            else
            {
                imageUrlThree = Convert.ToString(imageThree.ImageLocation);
                imageThree.BorderStyle = BorderStyle.Fixed3D;
            }
        }
    }
}
