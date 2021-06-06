using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Khidmat
{
    public partial class SearchScreen : Form
    {

        public class Filters
        {
            public Label filterByText;
            public ComboBox filterDropDown;
            public Label searchByText;
            public TextBox searchByTextbox;

            public Filters(Label FilterByText, ComboBox FilterDropDown, Label SearchByText, TextBox SearchByTextbox)
            {
                this.filterByText = FilterByText;
                this.filterDropDown = FilterDropDown;
                this.searchByText = SearchByText;
                this.searchByTextbox = SearchByTextbox;
            }

            public Filters()
            {
                this.searchByTextbox = new TextBox();
                this.filterDropDown = new ComboBox();
                this.searchByText = new Label();
                this.filterByText = new Label();
            }


        }
        


        public List<Filters> FilterOptions = new List<Filters>();

        System.Object[] ComboList = new System.Object[5] { "Name", "Age", "Sex", "Date of Procedure", "Diagnosis" };


        public MainScreen mainscreenReference;
        private int sizeX = 736;
        private int sizeY = 670;
        private int numberOfAdditions;

        public SearchScreen(MainScreen mainScreen)
        {
            InitializeComponent();
            mainscreenReference = mainScreen;
            numberOfAdditions = 0;

            Filters first = new Filters(FilterByText, FilterDropDown, SearchByText, SearchByTextbox);
            FilterOptions.Add(first);
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

        }

        public static void CloneControl(Control SourceControl, Control DestinationControl)
        {
            String[] PropertiesToClone = new String[] { "Size", "Font","Items","ForeColor","BackColor", "Location", "Text", "Tag", "BackColor", "BorderStyle", "TextAlign", "Width", "Margin" };
            PropertyInfo[] controlProperties = SourceControl.GetType().GetProperties();

            foreach (String Property in PropertiesToClone)
            {
                try
                {
                    PropertyInfo ObjPropertyInfo = controlProperties.First(a => a.Name == Property);
                    ObjPropertyInfo.SetValue(DestinationControl, ObjPropertyInfo.GetValue(SourceControl));
                }
                catch
                {
                    Console.WriteLine(Property);
                }
            }
        }

        private void AddButton_Click_1(object sender, EventArgs e)
        {

            numberOfAdditions += 1;
            this.Size = new Size(sizeX, sizeY);
            SubmitButton.Location = new Point(SubmitButton.Location.X, SubmitButton.Location.Y + 100);
            ClearButton.Location = new Point(ClearButton.Location.X, ClearButton.Location.Y + 100);
            DeleteButton.Location = new Point(DeleteButton.Location.X, DeleteButton.Location.Y + 100);
            ViewButton.Location = new Point(ViewButton.Location.X, ViewButton.Location.Y + 100);
            EditButton.Location = new Point(EditButton.Location.X, EditButton.Location.Y + 100);
            SearchResultsList.Location = new Point(SearchResultsList.Location.X, SearchResultsList.Location.Y + 100);
            SearchResultsText.Location = new Point(SearchResultsText.Location.X, SearchResultsText.Location.Y + 100);
            AddButton.Location = new Point(AddButton.Location.X, AddButton.Location.Y + 100);

            Filters NewSearch = new Filters();

            

            CloneControl(FilterOptions[numberOfAdditions - 1].filterByText, NewSearch.filterByText);
            CloneControl(FilterOptions[numberOfAdditions - 1].filterDropDown, NewSearch.filterDropDown);
            CloneControl(FilterOptions[numberOfAdditions - 1].searchByText, NewSearch.searchByText);
            CloneControl(FilterOptions[numberOfAdditions - 1].searchByTextbox, NewSearch.searchByTextbox);

            NewSearch.filterDropDown.Items.AddRange(ComboList);

            this.Controls.Add(NewSearch.filterByText) ;
            this.Controls.Add(NewSearch.filterDropDown);
            this.Controls.Add(NewSearch.searchByText);
            this.Controls.Add(NewSearch.searchByTextbox);


            NewSearch.filterByText.Location = new Point(NewSearch.filterByText.Location.X, NewSearch.filterByText.Location.Y +  200);
            NewSearch.filterDropDown.Location = new Point(NewSearch.filterDropDown.Location.X, NewSearch.filterDropDown.Location.Y + 200); ;
            NewSearch.searchByText.Location = new Point(NewSearch.searchByText.Location.X, NewSearch.searchByText.Location.Y + 200); ;
            NewSearch.searchByTextbox.Location = new Point(NewSearch.searchByTextbox.Location.X, NewSearch.searchByTextbox.Location.Y +  200);

            FilterOptions.Add(NewSearch);
        }

        private void ClearButton_Click_1(object sender, EventArgs e)
        {

            if (numberOfAdditions != 0)
            {
                for (var i = 1; i < FilterOptions.Count; i++)
                {
                    Filters NewSearch = FilterOptions[i];

                    this.Controls.Remove(NewSearch.filterByText);
                    this.Controls.Remove(NewSearch.filterDropDown);
                    this.Controls.Remove(NewSearch.searchByText);
                    this.Controls.Remove(NewSearch.searchByTextbox);

                    NewSearch.filterByText.Dispose();
                    NewSearch.filterDropDown.Dispose();
                    NewSearch.searchByText.Dispose();
                    NewSearch.searchByTextbox.Dispose();
                   
                    
                    
                }


                SubmitButton.Location = new Point(SubmitButton.Location.X, SubmitButton.Location.Y - (100 * numberOfAdditions));
                ClearButton.Location = new Point(ClearButton.Location.X, ClearButton.Location.Y - (100 * numberOfAdditions));
                DeleteButton.Location = new Point(DeleteButton.Location.X, DeleteButton.Location.Y - (100 * numberOfAdditions));
                ViewButton.Location = new Point(ViewButton.Location.X, ViewButton.Location.Y - (100 * numberOfAdditions));
                EditButton.Location = new Point(EditButton.Location.X, EditButton.Location.Y - (100 * numberOfAdditions));
                SearchResultsList.Location = new Point(SearchResultsList.Location.X, SearchResultsList.Location.Y - (100 * numberOfAdditions));
                SearchResultsText.Location = new Point(SearchResultsText.Location.X, SearchResultsText.Location.Y - (100 * numberOfAdditions));
                AddButton.Location = new Point(AddButton.Location.X, AddButton.Location.Y - (100 * numberOfAdditions));
                this.Size = new Size(sizeX, sizeY);


                numberOfAdditions = 0;
            }

        }

        private void BackButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
            mainscreenReference.Show();
        }
    }

}
