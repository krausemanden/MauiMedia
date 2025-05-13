namespace MauiMedia
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
      
        private void OnPlayClicked(object sender, EventArgs e)
        {
            mediaElement.Play();
        }

        private void OnPauseClicked(object sender, EventArgs e)
        {
            mediaElement.Pause();
        }

        private void OnStopClicked(object sender, EventArgs e)
        {
            mediaElement.Stop();
        }

        private void OnVolumeChanged(object sender, ValueChangedEventArgs e)
        {
            mediaElement.Volume = e.NewValue;
        }


    }

}
