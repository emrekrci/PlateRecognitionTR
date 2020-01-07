using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.OCR;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlateRecognitionTR
{
    public partial class Form1 : Form
    {
        public static Tesseract _ocr;
        public Form1()
        {
            _ocr = new Tesseract(@"C:\Users\Emrek\source\repos\PlateRecognitionFinal\PlateRecognitionFinal\tesseract\", "eng", OcrEngineMode.TesseractLstmCombined);
            _ocr.SetVariable("tessedit_char_whitelist", "ABCDEFGHIJKLMNOPRSTUVXYZ-1234567890");
            
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    _ocr = new Tesseract(@"C:\Users\Emrek\source\repos\PlateRecognitionFinal\PlateRecognitionFinal\tesseract\", "tur", OcrEngineMode.TesseractLstmCombined);
        //    //_ocr.SetVariable("tessedit_char_whitelist", "ABCDEFGHIJKLMNOPQRSTUVWXYZ-1234567890");
        //    OpenFileDialog dialog = new OpenFileDialog();
        //    if (dialog.ShowDialog() == DialogResult.OK)
        //    {
        //        //Image<Bgr, byte> image = new Image<Bgr, byte>(dialog.FileName);
        //        //imgOriginal.Image = image;
                
        //        //CvInvoke.BilateralFilter(image.Clone(), image, 11, 17, 17);
        //        //Mat gray = new Mat();
        //        //Mat canny = new Mat();
        //        //Mat filtered = new Mat();
        //        //Mat hierarcy = new Mat();
        //        //VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
        //        //CvInvoke.CvtColor(image, gray, ColorConversion.Bgr2Gray);
        //        //imgClone.Image = image;
        //        //CvInvoke.BilateralFilter(gray, filtered, 11, 17, 17, BorderType.Constant);
        //        //CvInvoke.Canny(filtered, canny, 30, 200);
        //        //imageBox3.Image = canny;
        //        //CvInvoke.FindContours(canny.Clone(), contours, hierarcy, RetrType.List, ChainApproxMethod.ChainApproxSimple);
        //        //List<VectorOfPoint> screenCnt = new List<VectorOfPoint>();
        //        //Dictionary<int, double> dict = new Dictionary<int, double>();
        //        //if (contours.Size > 0 )
        //        //{
        //        //    for (int i = 0; i < contours.Size; i++)
        //        //    {
        //        //        double area = CvInvoke.ContourArea(contours[i]);
        //        //        dict.Add(i, area);
        //        //    }
        //        //}
        //        //var item = dict.OrderByDescending(v => v.Value);
        //        //foreach (var it in item)
        //        //{
        //        //    if (it.Value > 400)
        //        //    {
        //        //        int key = it.Key;
        //        //        Rectangle rect = CvInvoke.BoundingRectangle(contours[key]);
        //        //        Rectangle rect2 = new Rectangle(rect.X, rect.Y, rect.Width, rect.Height);
                        
        //        //        var oran = ((double)rect.Width / (double)rect.Height);
        //        //        if (oran <= 5 && oran >= 4)
        //        //        {
        //        //            //CvInvoke.Rectangle(image, rect2, new MCvScalar(255.0, 0, 255.0), 5);
        //        //            Image<Bgr, byte> img = image.Clone();
        //        //            img.ROI = rect2;
        //        //            imgClone.Image = img;
        //        //            CvInvoke.Threshold(img.Clone(), img, 50, 25, ThresholdType.Binary);
        //        //            _ocr.SetImage(img);
        //        //            _ocr.Recognize();
        //        //            var words = _ocr.GetCharacters();
        //        //            string text = "";
        //        //            foreach (var ass in words)
        //        //            {
        //        //                text += ass.Text;
        //        //            }
        //        //            MessageBox.Show(text);
        //        //        }
        //        //    }

        //        //}
        //    }
        //}

        private static int GetNumberOfChildren(int[,] hierachy, int idx)
        {
            //first child
            idx = hierachy[idx, 2];
            if (idx < 0)
                return 0;

            int count = 1;
            while (hierachy[idx, 0] > 0)
            {
                count++;
                idx = hierachy[idx, 0];
            }
            return count;
        }

        private void btnGetImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                imgOriginal.Image = new Image<Bgr, byte>(fileDialog.FileName);
            }
        }

        private void btnSetGray_Click(object sender, EventArgs e)
        {
            Mat gray = new Mat();
            CvInvoke.CvtColor(imgOriginal.Image, gray, ColorConversion.Bgr2Gray);
            imgClone.Image = gray;
        }

        private void btnSetFilter_Click(object sender, EventArgs e)
        {
            Mat filtered = new Mat();
            CvInvoke.BilateralFilter(imgClone.Image, filtered, 11, 17, 17);
            imgClone.Image = filtered;
        }

        private void btnGetCanny_Click(object sender, EventArgs e)
        {
            Mat canny = new Mat();
            CvInvoke.Canny(imgClone.Image, canny, 30, 200);
            imgClone.Image = canny;
        }

        private void btnCropPlate_Click(object sender, EventArgs e)
        {
            VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
            Mat hierarcy = new Mat();
            Dictionary<int, double> dict = new Dictionary<int, double>();
            Mat cannyImage = (Mat)imgClone.Image;
            int[,] hierachy = CvInvoke.FindContourTree(cannyImage, contours, ChainApproxMethod.ChainApproxSimple);
            if (contours.Size > 0 )
            {
                for (int i = 0; i < contours.Size; i++)
                {
                    double area = CvInvoke.ContourArea(contours[i]);
                    dict.Add(i, area);
                }
            }
            var orderedDict = dict.OrderByDescending(v => v.Value);
            foreach (var dictItem in orderedDict)
            {
                if (dictItem.Value > 400)
                {
                    if (GetNumberOfChildren(hierachy, dictItem.Key) > 3)
                    {
                        Rectangle rect = CvInvoke.BoundingRectangle(contours[dictItem.Key]);
                        Rectangle rect2 = new Rectangle(rect.X, rect.Y, rect.Width, rect.Height);
                        var oran = ((double)rect.Width / (double)rect.Height);
                        if (oran <= 5 && oran >= 4)
                        {
                            Image<Bgr, byte> image = (Image<Bgr,byte>)imgOriginal.Image;
                            image.ROI = rect2;
                            imgPlate.Image = image;
                        }
                    }
                }
            }
        }

        private void btnDetectPlate_Click(object sender, EventArgs e)
        {
            Image<Bgr, byte> image = (Image<Bgr, byte>)imgPlate.Image;
            Mat thresh = new Mat();
            Mat gray = new Mat();
            CvInvoke.CvtColor(image, gray, ColorConversion.Bgr2Gray);
            CvInvoke.Threshold(gray, thresh, 120, 255, ThresholdType.Otsu);
            imgCannyPlate.Image = thresh;
            _ocr.SetImage(thresh);
            _ocr.Recognize();
            var words = _ocr.GetCharacters();
            string text = "";
            foreach (var ass in words)
            {
                text += ass.Text;
            }
            richTextBox1.Text = text;
        }
    }
}
