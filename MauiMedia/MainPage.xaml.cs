namespace MauiMedia
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
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
