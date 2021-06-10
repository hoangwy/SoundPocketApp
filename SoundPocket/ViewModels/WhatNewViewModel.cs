using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using SoundPocket.Models;
using SoundPocket.Views;
using Xamarin.Forms;

namespace SoundPocket.ViewModels
{
    public class WhatNewViewModel : BaseViewModel
    {
        public ObservableCollection<ShowcaseModel> Items { get; set; }
        public ObservableCollection<NewSongModel> NewSongs { get; set; }
        public ObservableCollection<PlaylistModel> Playlists { get; set; }

        public ICommand ItemPlaylistCommand { get; set; }

        private INavigation navigation;

        public WhatNewViewModel(INavigation navigation)
        {
            this.navigation = navigation;

            ItemPlaylistCommand = new Command<PlaylistModel>(OnItemPlaylistCommand);
            if (Items == null)
            {
                Items = new ObservableCollection<ShowcaseModel>();
                OnPropertyChanged(nameof(Items));
            }

            if (NewSongs == null)
            {
                NewSongs = new ObservableCollection<NewSongModel>();
                OnPropertyChanged(nameof(NewSongs));
            }

            if (Playlists == null)
            {
                Playlists = new ObservableCollection<PlaylistModel>();
                OnPropertyChanged(nameof(Playlists));
            }

            SetupShowcase();
            SetupNewSong();
            SetupPlaylist();

            CurrentIndex = 1;
        }

        private void OnItemPlaylistCommand(PlaylistModel p)
        {
            this.navigation.PushAsync(new PlaylistDetailPage());
        }

        private int currentIndex;
        public int CurrentIndex
        {
            get { return currentIndex; }
            set { SetProperty(ref currentIndex, value); }
        }

        private void SetupPlaylist()
        {
            var p = new PlaylistModel()
            {
                Image = "img_playlist_1.png",
                Title = "Tomorrowland - Secret Kin...",
                Artist = "John Doe",
                IconHeart = "ic_heart_fiiled.png"
            };
            Playlists.Add(p);

            p = new PlaylistModel()
            {
                Image = "img_playlist_2.png",
                Title = "Proximity 2019",
                Artist = "John Doe",
                IconHeart = "ic_heart.png"
            };
            Playlists.Add(p);

            p = new PlaylistModel()
            {
                Image = "img_playlist_3.png",
                Title = "Trap Nation 2019",
                Artist = "John Doe",
                IconHeart = "ic_heart.png"
            };
            Playlists.Add(p);
        }

        private void SetupNewSong()
        {
            var s = new NewSongModel()
            {
                Image = "img_song_1.png",
                Title = "Sacrifice",
                Artist = "Black Atlass"
            };
            NewSongs.Add(s);

            s = new NewSongModel()
            {
                Image = "img_song_2.png",
                Title = "Disarm You",
                Artist = "Illenium"
            };
            NewSongs.Add(s);

            s = new NewSongModel()
            {
                Image = "img_song_3.png",
                Title = "Yellow",
                Artist = "Coldplay"
            };
            NewSongs.Add(s);

            s = new NewSongModel()
            {
                Image = "img_song_4.png",
                Title = "The Scie...",
                Artist = "Boyce Avenue"
            };
            NewSongs.Add(s);
        }

        private void SetupShowcase()
        {
            var s = new ShowcaseModel()
            {
                Image = "img_showcase_1.png"
            };
            Items.Add(s);

            s = new ShowcaseModel()
            {
                Image = "img_showcase_2.png"
            };
            Items.Add(s);

            s = new ShowcaseModel()
            {
                Image = "img_showcase_3.png"
            };
            Items.Add(s);

            s = new ShowcaseModel()
            {
                Image = "img_showcase_1.png"
            };
            Items.Add(s);

            s = new ShowcaseModel()
            {
                Image = "img_showcase_2.png"
            };
            Items.Add(s);

            s = new ShowcaseModel()
            {
                Image = "img_showcase_3.png"
            };
            Items.Add(s);
        }
    }
}
