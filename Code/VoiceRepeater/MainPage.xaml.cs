using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.BackgroundAudio;

namespace VoiceRepeater
{
    public partial class MainPage : PhoneApplicationPage
    {
        private DateTime? startTime = null;

        private DateTime? endTime = null;

        private bool isRepeating = false;

        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnA_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Record time of point A
        }

        private void btnB_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Record time of point B

            listBoxSections.Items.Add("Part " + listBoxSections.Items.Count.ToString());

            if (startTime != null)
            {
                isRepeating = true;

                btnPlay.Content = "Resume";
            }
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            //BackgroundAudioPlayer.Instance.Track = new AudioTrack("test.mp3");
            //BackgroundAudioPlayer.Instance.Play();


            if (btnPlay.Content.ToString() == "Play")
            {
                btnPlay.Content = "Pause";
            }
            else if (btnPlay.Content.ToString() == "Pause")
            {
                btnPlay.Content = "Play";
            }
            else
            {
                btnPlay.Content = "Play";
            }
        }
    }
}