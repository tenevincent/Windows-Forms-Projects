using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;
using Newtonsoft.Json;
using StockAnalyzer.Core.Domain;

namespace StockAnalyzer.Windows
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public class StockData
        {

            public List<StockPrice> A { get; set; }
        }

        private async void Search_Click(object sender, RoutedEventArgs e)
        {
            //#region Before loading stock data
            //var watch = new Stopwatch();
            //watch.Start();
            //StockProgress.Visibility = Visibility.Visible;
            //StockProgress.IsIndeterminate = true;
            //#endregion

            Stocks.ItemsSource = new List<StockPrice>();

            try
            {
               await  this.GetStocksAsync();
            }
            catch (Exception ex)
            {
                Notes.Text += ex.Message;
                StocksStatus.Text += ex.Message;
            }


 
        }


        public async Task GetStocksAsync()
        {


            #region Before loading stock data
            var watch = new Stopwatch();
            watch.Start();
            StockProgress.Visibility = Visibility.Visible;
            StockProgress.IsIndeterminate = true;
            #endregion



            using (var client = new HttpClient())
            {
                var response = await client.GetAsync($"http://localhost:61363/api/stocks/{Ticker.Text}"); ;
                if (string.IsNullOrEmpty(Ticker.Text))
                    response = await client.GetAsync($"http://localhost:61363/api/stocks");


                //try
                //{ 
                    response.EnsureSuccessStatusCode();
                    var resultContent = await response.Content.ReadAsStringAsync();

                    if (string.IsNullOrEmpty(Ticker.Text))
                    {
                        var data = JsonConvert.DeserializeObject<StockData>(resultContent);
                        Stocks.ItemsSource = data.A;
                    }
                    else
                    {
                        var data = JsonConvert.DeserializeObject<IEnumerable<StockPrice>>(resultContent);
                        Stocks.ItemsSource = data;
                    }

                    #region After stock data is loaded
                    StocksStatus.Text = $"Loaded stocks for {Ticker.Text} in {watch.ElapsedMilliseconds}ms";
                    StockProgress.Visibility = Visibility.Hidden;
                //}
                //catch (Exception ex)
                //{
                //    Notes.Text = ex.Message;
                //    StocksStatus.Text = ex.Message;
                //}

   
            }

            #endregion

        }

        private void Hyperlink_OnRequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));

            e.Handled = true;
        }

        private void Close_OnClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
