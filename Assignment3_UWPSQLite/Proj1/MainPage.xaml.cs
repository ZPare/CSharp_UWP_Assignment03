using System;
using System.Collections.Generic;
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
//need to add the following namespace
using Microsoft.EntityFrameworkCore;
//need to add the following namespace for ObservableCollection<T>
using System.Collections.ObjectModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Proj1
{
    //********************DATA MODEL CODE BEGINS****************************


    //Fruit entity class
    public class Fruit
    {
        //By convention, a property named Id or <type name>Id will be  
        //configured as the key of an entity.
        public int FruitId { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        //If you do not provide a ToString method here,
        //every item in a ComboBox will be displayed as 
        //some wrong string
        public override string ToString()
        {
            return Name + " " + " " + Color;
        }
    }


    public class Planet
    {
        //By convention, a property named Id or <type name>Id will be  
        //configured as the key of an entity.
        public int PlanetId { get; set; }
        public string Name2 { get; set; }
        public string Color2 { get; set; }

        //If you do not provide a ToString method here,
        //every item in a ComboBox will be displayed as 
        //some wrong string
        public override string ToString()
        {
            return Name2 + " " + " " + Color2;
        }
    }

    public class DataGrid3
    {
        public string Name3 { get; set; }
        public override string ToString()
        {
            return Name3;
        }
    }




    public class MyDbContext : DbContext
    {
        //FruitDbSet
        public DbSet<Fruit> FruitDbSet { get; set; }

        public DbSet<Planet> PlanetDbSet { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=myDatabaseForUWP.db");
        }
    }

    //********************DATA MODEL CODE ENDS****************************



    public sealed partial class MainPage : Page
    {
        //collections for comboBox1
        ObservableCollection<Fruit> comboBox1Items = new ObservableCollection<Fruit>();
        //collection for dataGrid1
        ObservableCollection<Fruit> dataGrid1Items = new ObservableCollection<Fruit>();


        //collections for comboBox2
        ObservableCollection<Planet> comboBox2Items = new ObservableCollection<Planet>();
        //collection for dataGrid2
        ObservableCollection<Planet> dataGrid2Items = new ObservableCollection<Planet>();

        //collection for dataGrid3
        ObservableCollection<DataGrid3> dataGrid3Items = new ObservableCollection<DataGrid3>();

        public MainPage()
        {
            this.InitializeComponent();
            doMyCustomWork();
        }

        //When a user launches the app, the Application.OnLaunched method is
        //invoked > The OnLaunched method creates a Frame and navigates to 
        //MainPage >  Mainpage constructor calls InitializeComponent >
        //MainPage.xaml is parsed and relevant objects are created. Thus, 
        //on parsing MainPage.xaml, Page object is created > "Loaded" event 
        //encapsulates the method call_page_loaded (given below) > Next, 
        //"Loaded" event is fired > Consequently, call_page_loaded method
        //is invoked
        private void call_page_loaded(object sender, RoutedEventArgs e)
        {
            using (var context = new MyDbContext())
            {
                //Ensure that the database (i.e. the SQLite file myDatabaseForUWP.db)
                //for the context exists. The database includes the DbSets (in this 
                //assignment, the DbSets are FruitDbSet and PlanetDbSet). If the 
                //database does not exist then the database and all its relation 
                //schema are created. Initially, the database tables are empty. 
                //If the database already exists, no action is taken and no effort 
                //is made to ensure if the database is compatible with the data model 
                //for this context.
                bool created = context.Database.EnsureCreated();


                //Get the existing tuples from the FruitDbSet table (of the 
                //database) as a list of Fruit objects (or empty list if no 
                //tuple exists) 
                var fruitList = context.FruitDbSet.ToList();

                //populate dataGrid1Items using the list above
                foreach (var f in fruitList)
                {
                    dataGrid1Items.Add(f);
                }

                //Get the existing tuples from the PlanetDbSet table (of the 
                //database) as a list of Planet objects (or empty list if no 
                //tuple exists)  
                var planetList = context.PlanetDbSet.ToList();

                //populate dataGrid2Items using the list above
                foreach (var p in planetList)
                {
                    dataGrid2Items.Add(p);
                }

            }
        }

        public void doMyCustomWork()
        {
            prepareComboBoxes();
        }

        public void prepareComboBoxes()
        {
            //add Fruit objects to the Collection for comboBox1
            comboBox1Items.Add(new Fruit { Name = "kiwi", Color = "red" });
            comboBox1Items.Add(new Fruit { Name = "grape", Color = "blue" });
            comboBox1Items.Add(new Fruit { Name = "dates", Color = "red" });
            comboBox1Items.Add(new Fruit { Name = "pear", Color = "blue" });

            //add planets to the Collection for comboBox2
            comboBox2Items.Add(new Planet { Name2 = "Earth", Color2 = "red" });
            comboBox2Items.Add(new Planet { Name2 = "Jupiter", Color2 = "blue" });
        }

        private void call_ComboBox_fruitSelection(object sender, SelectionChangedEventArgs e)
        {
            //get the item (Fruit object) selected in comboBox1
            var item = (sender as ComboBox).SelectedItem as Fruit;
            if (item == null) return;

            //Item selected in the comboBox1 is a Fruit object.
            Fruit theFruit = new Fruit();
            //theFruit.FruitId = item.FruitId;
            theFruit.Name = item.Name;
            theFruit.Color = item.Color;

            using (var context = new MyDbContext())
            {
                //Write the above deep copied Fruit object to the database
                context.FruitDbSet.Add(theFruit);

                //save changes made in the context to the database
                context.SaveChanges();
            }

            using (var context = new MyDbContext())
            {
                //empty the collection dataGrid1Items
                dataGrid1Items.Clear();


                //get the list of Fruit objects that are currently
                //present as tuples in the FruitDbSet table of the database
                var fruitList = context.FruitDbSet.ToList();


                //populate the emptied collection dataGrid1Items  
                //using the current Fruit objects obtained from database
                foreach (var f in fruitList)
                {
                    dataGrid1Items.Add(f);
                }

            }
        }
        private void call_ComboBox_planetSelection(object sender, SelectionChangedEventArgs e)
        {
            //get the item (Fruit object) selected in comboBox1
            var item = (sender as ComboBox).SelectedItem as Planet;
            if (item == null) return;

            //Item selected in the comboBox1 is a Fruit object.
            Planet thePlanet = new Planet();
            // thePlanet.PlanetId = item.PlanetId;
            thePlanet.Name2 = item.Name2;
            thePlanet.Color2 = item.Color2;


            using (var context = new MyDbContext())
            {
                //Write the above deep copied Fruit object to the database
                context.PlanetDbSet.Add(thePlanet);

                //save changes made in the context to the database
                context.SaveChanges();
            }

            using (var context = new MyDbContext())
            {
                //empty the collection dataGrid2Items
                dataGrid2Items.Clear();


                //get the list of Fruit objects that are currently
                //present as tuples in the FruitDbSet table of the database
                var planetList = context.PlanetDbSet.ToList();


                //populate the emptied collection dataGrid1Items  
                //using the current Fruit objects obtained from database
                foreach (var p in planetList)
                {
                    dataGrid2Items.Add(p);
                }

            }
        }



        private void call_DataGrid_fruitSelection(object sender, SelectionChangedEventArgs e)
        {
            //When you select an item (a Fruit object) in dataGrid1,
            //the selection, if any, in dataGrid2 should be unselected.
            Fruit f = (Fruit)dataGrid1.SelectedItem;


            //Planet p = (Planet)dataGrid2.SelectedItem;
            //p = null;
            dataGrid2.SelectedItem = null;
            //dataGrid2Items.Clear();
        }

        private void call_DataGrid_planetSelection(object sender, SelectionChangedEventArgs e)
        {
            //When you select an item (a Planet object) in dataGrid2,
            //the selection, if any, in dataGrid1 should be unselected.
            Planet p = (Planet)dataGrid2.SelectedItem;


            //Fruit f = (Fruit)dataGrid1.SelectedItem;
            //f = null;
            dataGrid1.SelectedItem = null; 
            //dataGrid1Items.Clear();
        }

        private void call_Clear_Button_Click(object sender, RoutedEventArgs e)
        {
            //next, empty (clear) the Sqlite database
            using (var context = new MyDbContext())
            {
                //remove all tuples from FruitDbSet of database
                context.FruitDbSet.RemoveRange(context.FruitDbSet.ToList());

                //remove all tuples from PlanetDbSet of database
                context.PlanetDbSet.RemoveRange(context.PlanetDbSet.ToList());

                //save changes made in the context to the database
                context.SaveChanges();
            }

            //empty dataGrid1Items collection and consequently dataGrid1
            //(The left DataGrid is named dataGrid1 in MainPage.xaml)
            dataGrid1Items.Clear();

            //empty dataGrid2Items collection and consequently dataGrid2
            //(The middle DataGrid is named dataGrid2 in MainPage.xaml)
            dataGrid2Items.Clear();

            //empty dataGrid3
            //(The right DataGrid is named dataGrid3 in MainPage.xaml)
            dataGrid3.ItemsSource = null;


            //reset the ComboBoxes
            //(The Fruit ComboBox is named comboBox1 in MainPage.xaml)
            fruitComboBox.SelectedItem = null;
            //(The Planet ComboBox is named comboBox2 in MainPage.xaml)
            planetComboBox.SelectedItem = null;
        }

        private void call_delete_selected_row_Button_Click(object sender, RoutedEventArgs e)
        {
            //get the Fruit object selected in dataGrid1
            Fruit fruit = (Fruit)dataGrid1.SelectedItem;

            //get the Planet object selected in dataGrid2
            Planet planet = (Planet)dataGrid2.SelectedItem;


            using (var context = new MyDbContext())
            {
                if (fruit != null)
                {
                    //remove the selected fruit from Sqlite database
                    context.FruitDbSet.Remove(fruit);

                    //save changes made in the context to the database
                    context.SaveChanges();

                    //remove the selected fruit from dataGrid1Items collection
                    dataGrid1Items.Remove(fruit);

                    //reset selected item of dataGrid1
                    dataGrid1.SelectedItem = null;

                    //reset selected item of comboBox1
                    fruitComboBox.SelectedItem = null;
                }

                if (planet != null)
                {
                    //remove the selected planet from Sqlite database
                    context.PlanetDbSet.Remove(planet);

                    //save changes made in the context to the database
                    context.SaveChanges();

                    //remove the selected fruit from dataGrid1Items collection
                    dataGrid2Items.Remove(planet);

                    //reset selected item of dataGrid2
                    dataGrid2.SelectedItem = null;

                    //reset selected item of comboBox2
                    planetComboBox.SelectedItem = null;

                }
            }
        }

        private void call_LINQ_Project_QS_Button_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new MyDbContext())
            {
                //selects names across all rows. The result type is IEnumerable<string>
                var query = from f in context.FruitDbSet
                            select new { FruitName = f.Name };


                //add the items to dataGrid3
                dataGrid3.ItemsSource = query.ToList();
            }
        }

        private void call_LINQ_Filter_QS_Button_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new MyDbContext())
            {
                //selects names across all rows. The result type is IEnumerable<string>
                var query = from f in context.FruitDbSet
                            where f.Color == "red"
                            select new { FruitName = f.Name };


                //add the items to dataGrid3
                dataGrid3.ItemsSource = query.ToList();

            }
        }

        private void call_LINQ_Order_Ascending_QS_Button_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new MyDbContext())
            {
                var query = from f in context.FruitDbSet
                            orderby f.Name
                            select new { FruitName = f.Name };
                dataGrid3.ItemsSource = query.ToList();

            }
        }

        private void call_LINQ_Inner_Join_QS_Button_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new MyDbContext())
            {
                var query = from f in context.FruitDbSet
                            join p in context.PlanetDbSet
                            on f.Color equals p.Color2
                            select new { FruitName = f.Name, PlanetName = p.Name2 };

                dataGrid3.ItemsSource = query.ToList();

            }
        }
    }
}
