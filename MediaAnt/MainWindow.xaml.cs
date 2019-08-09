using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Windows.Threading;
using System.IO;
namespace MediaAnt
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
           


        }
        private MediaState mediaState = MediaState.Stoped;
        internal MediaState MediaState
        {
            get
            {
                return mediaState;
            }
            set
            {
                mediaState = value;
                FirePropertyChanged("PlayButtonName");
            }

        }
        public string PlayButtonName
        {
            get
            {
                return (MediaState == MediaState.Playing) ? "Pause" : "Play";
            }
        }

        private void Slider_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            media.Pause();
            media.Position = TimeSpan.FromSeconds(slider.Value);
            media.Play();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new Microsoft.Win32.OpenFileDialog
            {
                DefaultExt = ".mp4",
                Filter = "Viedo Files (*.mp4)|*.mp4|All Files (*.*)|*.*",
                CheckFileExists = true
            };
            if (dlg.ShowDialog(this) == true)
            {
                var filename = dlg.FileName;
                if (MediaState == MediaState.Playing||MediaState == MediaState.Paused)
                {
                    Stop();
                }
                media.Source = new Uri(filename);
                media.Play();
              

            }
            
        }
        void Stop()
        {
            media.Stop();
            MediaState = MediaState.Stoped;
            media.Close();
        }
        void Play()
        {
            media.Play();
            MediaState = MediaState.Playing;
        }
        void Pause()
        {
            media.Pause();
            MediaState = MediaState.Paused;
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(media.Source != null)
                if(MediaState == MediaState.Playing && media.CanPause)
                {
                   
                    Pause();
                    
                }
            else if (MediaState == MediaState.Paused || MediaState == MediaState.Stoped)
            {
                    Play();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (MediaState == MediaState.Playing || MediaState == MediaState.Paused)
            {
                Stop();
            }
        }
         
        private void MediaElement1_Loaded(object sender, RoutedEventArgs e)
        {
            media.MediaOpened += new RoutedEventHandler(media_MediaOpened);
            media.MediaFailed += new EventHandler<ExceptionRoutedEventArgs>(media_MediaFailed);
            media.MediaEnded += new RoutedEventHandler(media_MediaEnded);


            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0,0,1);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            if(MediaState == MediaState.Playing)
            {
                slider.Value = media.Position.TotalSeconds;
            }
        }
        void media_MediaEnded(object sender, RoutedEventArgs e)
        {
            media.Stop();
        }
        void media_MediaOpened(object sender, RoutedEventArgs e)
        {
            
            slider.Maximum = media.NaturalDuration.TimeSpan.TotalSeconds;
            Play();
        }
        void media_MediaFailed(object sender, ExceptionRoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
        public event PropertyChangedEventHandler PropertyChanged;
            void FirePropertyChanged(string name)
            {
            if (PropertyChanged !=null)PropertyChanged(this,new PropertyChangedEventArgs(name));
            }

        

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
        }
        private bool fullScreen = false;
       
       

        private void Slaider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
           
        }

        private void Slider_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            media.Volume = sliders.Value;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
           // System.Diagnostics.Process.Start("https://www.youtube.com/");
            Form1 fr1 = new Form1();
            fr1.Show();
            //this.Hide();
        }

       

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://ru.savefrom.net/");
        }
        public bool IsFullscreen = false;
        public WindowState lastWindowState;
        
        private void Window_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            if (IsFullscreen)
            {
             ;
                this.WindowStyle = WindowStyle.SingleBorderWindow;
                this.WindowState = lastWindowState;
                IsFullscreen = false;
              
                

            }
            else
            {
                lastWindowState = this.WindowState;

                this.WindowStyle = WindowStyle.None;
                if (this.WindowState == WindowState.Maximized)
                    this.WindowState = WindowState.Minimized;
                this.WindowState = WindowState.Maximized;
                IsFullscreen = true;
             
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            var dlg = new Microsoft.Win32.OpenFileDialog
            {
                DefaultExt = ".mp4",
                Filter = "Viedo Files (*.mp4)|*.mp4|All Files (*.*)|*.*",
                CheckFileExists = true
            };
           
            
                var filename = dlg.FileName;
            
              
                if(mediaState == MediaState.Stoped)
                {
                    dlg.Multiselect = true;
                 
                }
               
            
        }
    }


}
