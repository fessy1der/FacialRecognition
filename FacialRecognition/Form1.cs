using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Face;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace FacialRecognition
{
    public partial class Form1 : Form
    {
        public VideoCapture Camera { get; set; }
        public EigenFaceRecognizer FacialRecognition { get; set; }
        public CascadeClassifier FaceDetection { get; set; }
        public CascadeClassifier EyeDetection { get; set; }

        public Mat Frame { get; set; }
        public List<Image<Gray, byte>> Faces { get; set; }
        public List<int> Ids { get; set; }

        public int ProcessedImageWidth { get; set; } = 128;
        public int ProcessedImageHeight { get; set; } = 150;
        public int TimerCounter { get; set; } = 0;
        public int TimeLimit { get; set; } = 30;
        public int ScanCounter { get; set; } = 0;
        public string YMLPath { get; set; } = @"../../Data/trainingData.yml";
        public Timer Timer { get; set; }
        public bool FaceSquare { get; set; } = false;
        public bool EyeSquare { get; set; } = false;

        public Form1()
        {
            InitializeComponent();
            FacialRecognition = new EigenFaceRecognizer(80, double.PositiveInfinity);
            FaceDetection = new CascadeClassifier(System.IO.Path.GetFullPath(@"../../Data/haarcascade_frontalface_default.xml"));
            EyeDetection = new CascadeClassifier(System.IO.Path.GetFullPath(@"../../Data/haarcascade_eye.xml"));
            Frame = new Mat();
            Faces = new List<Image<Gray, byte>>();
            Ids = new List<int>();
            BeginCamera();

        }

        private void BeginCamera()
        {
            if (Camera == null)
                Camera = new VideoCapture();

            Camera.ImageGrabbed += Camera_ImageGrabbed;
            Camera.Start();
            OutputBox.AppendText($"Camera Started...{Environment.NewLine}");
            
        }

        private void Camera_ImageGrabbed(object sender, EventArgs e)
        {
            Camera.Retrieve(Frame);
            var ImgFrame = Frame.ToImage<Bgr, byte>();

            if (ImgFrame != null)
            {
                var grayFrame = ImgFrame.Convert<Gray, byte>();
                var faces = FaceDetection.DetectMultiScale(grayFrame, 1.3, 5);
                var eyes = EyeDetection.DetectMultiScale(grayFrame, 1.3,5);

                if (FaceSquare)
                    foreach (var face in faces)
                        ImgFrame.Draw(face, new Bgr(Color.BurlyWood), 3);

                if (EyeSquare)
                    foreach (var eye in eyes)
                        ImgFrame.Draw(eye, new Bgr(Color.Yellow), 3);

                CameraBox.Image = ImgFrame.ToBitmap();
            }
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            if (IdBox.Text != string.Empty)
            {
                IdBox.Enabled = !IdBox.Enabled;
                Timer = new Timer();
                Timer.Interval = 500;
                Timer.Tick += Timer_Tick;
                Timer.Start();
                btnTrain.Enabled = !btnTrain.Enabled;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Camera.Retrieve(Frame);
            var ImgFrame = Frame.ToImage<Gray, byte>();
            if (TimerCounter < TimeLimit)
            {
                TimerCounter++;

                if (ImgFrame != null)
                {
                    var faces = FaceDetection.DetectMultiScale(ImgFrame, 1.3, 5);

                    if (faces.Count() > 0)
                    {
                        var processedImage = ImgFrame.Copy(faces[0]).Resize(ProcessedImageWidth, ProcessedImageHeight, Emgu.CV.CvEnum.Inter.Cubic);
                        Faces.Add(processedImage);
                        Ids.Add(Convert.ToInt32(IdBox.Text));
                        ScanCounter++;
                        OutputBox.AppendText($"{ScanCounter} Succesful Scans Taken...{Environment.NewLine}");
                        OutputBox.ScrollToCaret();
                    }
                }
            }
            else
            {
                FacialRecognition.Train(Faces.ToArray(), Ids.ToArray());
                FacialRecognition.Write(YMLPath);
                Timer.Stop();
                TimerCounter = 0;
                btnTrain.Enabled = !btnTrain.Enabled;
                IdBox.Enabled = !IdBox.Enabled;
                OutputBox.AppendText($"Training  Complete! {Environment.NewLine}");
                MessageBox.Show("Training Complete");
            }
        }

        private void btnFaceSquare_Click(object sender, EventArgs e)
        {
            if (FaceSquare)
                btnFaceSquare.Text = "Face Square: Off";
            else
                btnFaceSquare.Text = "Face Square: on";
            FaceSquare = !FaceSquare;
        }

        private void btnEyeSquare_Click(object sender, EventArgs e)
        {
            if (EyeSquare)
                btnEyeSquare.Text = "Eye Squares: Off";
            else
                btnEyeSquare.Text = "Eye Square: On";

            EyeSquare = !EyeSquare;
        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
            Camera.Retrieve(Frame);
            var ImgFrame = Frame.ToImage<Gray, byte>();

            if (ImgFrame != null)
            {
                var faces = FaceDetection.DetectMultiScale(ImgFrame, 1.3, 5);

                if (faces.Count() != 0)
                {
                    var processedImg = ImgFrame.Copy(faces[0]).Resize(ProcessedImageWidth, ProcessedImageHeight,Emgu.CV.CvEnum.Inter.Cubic);
                    var result = FacialRecognition.Predict(processedImg);

                    if (result.Label.ToString() == "15")
                        MessageBox.Show("FESTUS");
                    else
                        MessageBox.Show("Test Person");

                }
            }
        }
    }
}
