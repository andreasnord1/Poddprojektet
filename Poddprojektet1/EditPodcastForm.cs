using Models;

namespace Poddprojektet1
{
    internal class EditPodcastForm
    {
        private Podcast selectedPodcast;

        public EditPodcastForm (Podcast selectedPodcast)
        {
            this.selectedPodcast = selectedPodcast;
        }

        public Podcast? UpdatedPodcast { get; internal set; }

        internal DialogResult ShowDialog(Startsida startsida)
        {
            throw new NotImplementedException();
        }
    }
}