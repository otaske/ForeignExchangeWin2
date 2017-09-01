using Xamarin.Forms;

[assembly: Dependency(typeof(ForeignExchangeWin2.Droid.Implementations.Config))]

namespace ForeignExchangeWin2.Droid.Implementations
{
    using System;
    using ForeignExchangeWin2.Interfaces;
    using SQLite.Net.Interop;

    public class Config : IConfig
    {
        string directoryDB;
        ISQLitePlatform platform;

        public string DirectoryDB
        {
            get
            {
                if (string.IsNullOrEmpty(directoryDB))
                {
                    directoryDB = System.Environment.GetFolderPath(
                        System.Environment.SpecialFolder.Personal);
                }

                return directoryDB;
            }
        }

        public ISQLitePlatform Platform
        {
            get
            {
                if (platform == null)
                {
                    platform = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
                }

                return platform;

            }
        }
    }
}