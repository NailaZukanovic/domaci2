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
using System.Windows.Threading;

namespace domaci2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int row { get; set; }

        public int column { get; set; }

        public TextBlock trenutniTextBlock { get; set; }
        public Top topC1 { get; set; }
        public Top topC2 { get; set; }
        public Kralj kraljC { get; set; }
        public Dama damaC { get; set; }
        public Skakac skakacC2 { get; set; }
        public Skakac skakacC1 { get; set; }


        public Top topB1 { get; set; }
        public Top topB2 { get; set; }
        public Kralj kraljB { get; set; }
        public Dama damaB { get; set; }
        public Skakac skakacB2 { get; set; }
        public Skakac skakacB1 { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            Top topC1 = new Top(new Polje("a", 1), "C");
            Top topC2 = new Top(new Polje("f", 1), "C");
            Skakac skakacC1 = new Skakac(new Polje("b", 1), "C");
            Dama damaC = new Dama(new Polje("c", 1), "C");
            Kralj kraljC = new Kralj(new Polje("d", 1), "C");
            Skakac skakacC2 = new Skakac(new Polje("e", 1), "C");


            Top topB1 = new Top(new Polje("a", 8), "C");
            Top topB2 = new Top(new Polje("f", 8), "C");
            Skakac skakacB1 = new Skakac(new Polje("b", 8), "C");
            Dama damaB = new Dama(new Polje("c", 8), "C");
            Kralj kraljB = new Kralj(new Polje("d", 8), "C");
            Skakac skakacB2 = new Skakac(new Polje("e", 8), "C");

            TopB1.Text = topB1.Oznaka;
            TopB2.Text = topB2.Oznaka;
            SkakacB1.Text = skakacB1.Oznaka;
            SkakacB2.Text = skakacB2.Oznaka;
            DamaB.Text = damaB.Oznaka;
            KraljB.Text = kraljB.Oznaka;

            
            TopC1.Text = topC1.Oznaka;
            TopC2.Text = topC2.Oznaka;
            SkakacC1.Text = skakacC1.Oznaka;
            SkakacC2.Text = skakacC2.Oznaka;
            DamaC.Text = damaC.Oznaka;
            KraljC.Text = kraljC.Oznaka;


            TopC1.SetValue(Grid.RowProperty, topC1.polje.red - 1);
            TopC2.SetValue(Grid.RowProperty, topC2.polje.red - 1);
            SkakacC1.SetValue(Grid.RowProperty, skakacC1.polje.red - 1);
            SkakacC2.SetValue(Grid.RowProperty, skakacC2.polje.red - 1);
            DamaC.SetValue(Grid.RowProperty, damaC.polje.red - 1);
            KraljC.SetValue(Grid.RowProperty, kraljC.polje.red - 1);


            TopB1.SetValue(Grid.RowProperty, topB1.polje.red - 1);
            TopB2.SetValue(Grid.RowProperty, topB2.polje.red - 1);
            SkakacB1.SetValue(Grid.RowProperty, skakacB1.polje.red - 1);
            SkakacB2.SetValue(Grid.RowProperty, skakacB2.polje.red - 1);
            DamaB.SetValue(Grid.RowProperty, damaB.polje.red - 1);
            KraljB.SetValue(Grid.RowProperty, kraljB.polje.red - 1);


            
            TopC1.SetValue(Grid.ColumnProperty, topC1.polje.DajKolonu() - 1);
            TopC2.SetValue(Grid.ColumnProperty, topC2.polje.DajKolonu() - 1);
            SkakacC1.SetValue(Grid.ColumnProperty, skakacC1.polje.DajKolonu() - 1);
            SkakacC2.SetValue(Grid.ColumnProperty, skakacC2.polje.DajKolonu() - 1);
            DamaC.SetValue(Grid.ColumnProperty, damaC.polje.DajKolonu() - 1);
            KraljC.SetValue(Grid.ColumnProperty, kraljC.polje.DajKolonu() - 1);


            TopB1.SetValue(Grid.ColumnProperty, topB1.polje.DajKolonu() - 1);
            TopB2.SetValue(Grid.ColumnProperty, topB2.polje.DajKolonu() - 1);
            SkakacB1.SetValue(Grid.ColumnProperty, skakacB1.polje.DajKolonu() - 1);
            SkakacB2.SetValue(Grid.ColumnProperty, skakacB2.polje.DajKolonu() - 1);
            DamaB.SetValue(Grid.ColumnProperty, damaB.polje.DajKolonu() - 1);
            KraljB.SetValue(Grid.ColumnProperty, kraljB.polje.DajKolonu() - 1);

            
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
            this.column = (int)ColumnComputation(MyGrid.ColumnDefinitions, e.GetPosition(MyGrid).X);

            this.row = (int)RowComputation(MyGrid.RowDefinitions, e.GetPosition(MyGrid).Y);
            // Do something with the row and column
            this.trenutniTextBlock.SetValue(Grid.RowProperty, int.Parse(row.ToString()));
                this.trenutniTextBlock.SetValue(Grid.ColumnProperty, int.Parse(column.ToString()));
           // MessageBox.Show(row.ToString() + column.ToString());

        }

        private double ColumnComputation(ColumnDefinitionCollection c, double YPosition)
        {
            var columnLeft = 0.0; var columnCount = 0;
            foreach (ColumnDefinition cd in c)
            {
                double actWidth = cd.ActualWidth;
                if (YPosition >= columnLeft && YPosition < (actWidth + columnLeft)) return columnCount;
                columnCount++;
                columnLeft += cd.ActualWidth;
            }
            return (c.Count + 1);
        }
        private double RowComputation(RowDefinitionCollection r, double XPosition)
        {
            var rowTop = 0.0; var rowCount = 0;
            foreach (RowDefinition rd in r)
            {
                double actHeight = rd.ActualHeight;
                if (XPosition >= rowTop && XPosition < (actHeight + rowTop)) return rowCount;
                rowCount++;
                rowTop += rd.ActualHeight;
            }
            return (r.Count + 1);
        }

        private void TopC1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.trenutniTextBlock= sender as TextBlock;
        /*    this.row = (int)textBlock.GetValue(Grid.RowProperty);
            this.column = (int)textBlock.GetValue(Grid.ColumnProperty);
            var mojaKolona = "";
            if (column == 0)
                mojaKolona = "a";
            else if (column == 1)
                mojaKolona = "b";
            else if (column == 2)
                mojaKolona = "c";
            else if (column == 3)
                mojaKolona = "d";
            else if (column == 4)
                mojaKolona = "e";
            else
                mojaKolona = "f";
            if (topC1.Pomeraj(new Polje(mojaKolona, row)))
            { 
                
                
            }

            */

        }

        private void SkakacC1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.trenutniTextBlock = sender as TextBlock;

        }

        private void DamaC_MouseDown(object sender, MouseButtonEventArgs e)
        {

            this.trenutniTextBlock = sender as TextBlock;
        }

        private void KraljC_MouseDown(object sender, MouseButtonEventArgs e)
        {

            this.trenutniTextBlock = sender as TextBlock;
        }

        private void SkakacC2_MouseDown(object sender, MouseButtonEventArgs e)
        {

            this.trenutniTextBlock = sender as TextBlock;
        }

        private void TopC2_MouseDown(object sender, MouseButtonEventArgs e)
        {

            this.trenutniTextBlock = sender as TextBlock;
        }

        private void TopB1_MouseDown(object sender, MouseButtonEventArgs e)
        {

            this.trenutniTextBlock = sender as TextBlock;
        }

        private void SkakacB1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.trenutniTextBlock = sender as TextBlock;

        }

        private void DamaB_MouseDown(object sender, MouseButtonEventArgs e)
        {

            this.trenutniTextBlock = sender as TextBlock;
        }

        private void KraljB_MouseDown(object sender, MouseButtonEventArgs e)
        {

            this.trenutniTextBlock = sender as TextBlock;
        }

        private void SkakacB2_MouseDown(object sender, MouseButtonEventArgs e)
        {

            this.trenutniTextBlock = sender as TextBlock;
        }

        private void TopB2_MouseDown(object sender, MouseButtonEventArgs e)
        {

            this.trenutniTextBlock = sender as TextBlock;
        }
    }
        
    }

