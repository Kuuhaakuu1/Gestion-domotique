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

namespace Gestion_Domotique
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Canvas c = new Canvas();
        public MainWindow()
        {
            InitializeComponent();
            
		
        }

		

		

        private void RedRectangle_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragDrop.DoDragDrop(RedRectangle, RedRectangle, DragDropEffects.Move);
            }
        }

        private void Canvas_Drop(object sender, DragEventArgs e)
        {
            Point p= e.GetPosition(canvas);

            Rectangle rectangle = new Rectangle();
            rectangle.Width = RedRectangle.Width;
            rectangle.Height = RedRectangle.Height;
            rectangle.Fill = RedRectangle.Fill;

          
            Canvas.SetLeft(rectangle,p.X);
            Canvas.SetTop(rectangle,p.Y);
            canvas.Children.Add(rectangle);
            rectangle.MouseRightButtonDown += rectangle_MouseRightButtonDown;

        }
        void rectangle_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            canvas.Children.Remove((Rectangle) sender);
        }




    }
}
