﻿using DRApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DRApp.Services;
using DRApp.Utils;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace DRApp.Views {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RoomSelection : ContentPage {
        //public ObservableCollection<Room> Rooms { get; private set; }
        public MyRoomsVM RoomsVM { get; private set; }
        
        private List<RoomInfo> rooms;
        
        public RoomSelection() {
            
            RoomsVM = new MyRoomsVM(Navigation);
            InitializeComponent();
            Navigation.PushAsync(new Page());

            // testBtn.Clicked += testFunc;
        }

        // EventHandler testFunc = (s, e) => {
        //     //Console.WriteLine(listRoom.BindingContext.ToString());
        //     Log.Warning("fck", "what");
        //     Debug.Write("here ==================");
        // };
    }
}