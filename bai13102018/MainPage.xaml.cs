﻿using bai13102018.DataAccessLibrary;
using bai13102018.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace bai13102018
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
       
             private ObservableCollection<Song> listSong;
        internal ObservableCollection<Song> ListSong { get => listSong; set => listSong = value; }
        public MainPage()
        {
            this.ListSong = new ObservableCollection<Song>();
            this.ListSong.Add(new Song()
            {
                name = "aiaia",
                thumbnail = "http://knfcafe.com/wp-content/uploads/2018/05/cea05d97539720c5efe2658d7272364c.jpg"
            });
            this.ListSong.Add(new Song()
            {
                name = "hehe",
                thumbnail = "http://knfcafe.com/wp-content/uploads/2018/05/cea05d97539720c5efe2658d7272364c.jpg"
            });
            this.ListSong.Add(new Song()
            {
                name = "kaka",
                thumbnail = "http://knfcafe.com/wp-content/uploads/2018/05/cea05d97539720c5efe2658d7272364c.jpg"
            });
            this.InitializeComponent();
        }


        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            //this.ListSong.Add(new Song()
            Song song = new Song()
            {
                name = this.SongName.Text,
                thumbnail = this.SongThumbnail.Text
            };
            this.ListSong.Add(song);
            this.SongName.Text = string.Empty;
            this.SongThumbnail.Text = string.Empty;
            SongModel.Add(song);

        }
    }
}
