using NeoDrawable;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
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

namespace Neo_Paint_DS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private List<NeoDrawable.Drawing>  drawings = new List<NeoDrawable.Drawing>();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var shapes = new BindingList<DrawableObject>();

            // Get list of DLL files in main executable folder
            string exePath = Assembly.GetExecutingAssembly().Location;
            string folder = System.IO.Path.GetDirectoryName(exePath);
            FileInfo[] fis = new DirectoryInfo(folder).GetFiles("*.dll");

            // Load all assemblies from current working directory
            foreach (FileInfo fileInfo in fis)
            {
                var domain = AppDomain.CurrentDomain;
                Assembly assembly = domain.Load(AssemblyName.GetAssemblyName(fileInfo.FullName));

                // Get all of the types in the dll
                Type[] types = assembly.GetTypes();

                // Only create instance of concrete class that inherits from IGUI, IBus or IDao
                foreach (var type in types)
                {
                    if (type.IsClass && !type.IsAbstract)
                    {
                        if (typeof(DrawableObject).IsAssignableFrom(type))
                            shapes.Add(Activator.CreateInstance(type) as DrawableObject);
                        if (typeof(NeoDrawable.Drawing).IsAssignableFrom(type))
                            drawings.Add(Activator.CreateInstance(type) as NeoDrawable.Drawing);
                    }
                }
            }

            cbxShapes.ItemsSource = shapes;
        }

        DrawableObject _drawingObject;
        NeoDrawable.Drawing _suitableDrawing;
        bool _isDrawing = false;

        private void canvas_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (cbxShapes.SelectedIndex == -1)
                return;

            Point p = e.GetPosition(canvas);
            DrawableObject obj = (DrawableObject)(cbxShapes.SelectedItem as DrawableObject).Clone();
            obj.StartPoint = new Point2D(p.X, p.Y);
            obj.EndPoint = new Point2D(p.X, p.Y);
            _drawingObject = obj;

            _suitableDrawing = GetSuitableDrawing(obj);
            if (_suitableDrawing != null)
            {
                _suitableDrawing.Draw(canvas, obj);
                _isDrawing = true;
            }
        }

        private void canvas_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (!_isDrawing)
                return;

            Point p = e.GetPosition(canvas);
            _drawingObject.EndPoint = new Point2D(p.X, p.Y);
            if (_suitableDrawing != null)
            {
                canvas.Children.RemoveAt(canvas.Children.Count - 1);
                _suitableDrawing.Draw(canvas, _drawingObject);
            }
        }

        private void canvas_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            _drawingObject = null;
            _suitableDrawing = null;
            _isDrawing = false;
        }

        private NeoDrawable.Drawing GetSuitableDrawing(DrawableObject obj)
        {
            string type = obj.GetDrawableType();
            string objShape = type.Split(new char[] { ' ' }, 2)[1];

            foreach (NeoDrawable.Drawing dr in drawings)
            {
                string drtype = dr.ToString();
                string drShape = drtype.Split(new char[] { ' ' }, 2)[1];
                if (drShape == objShape)
                    return dr;
            }
            return null;
        }

        
    }
}
