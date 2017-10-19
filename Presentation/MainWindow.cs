using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Logic;
using System.IO;

namespace Presentation
{
    public partial class MainWindow : Form
    {
        Category cat = new Category();

        public MainWindow()
        {
            InitializeComponent();
            fillCategoryList();
        }

        private void btn_delete_category_Click(object sender, EventArgs e)
        {
            var folderToDelete = lb_category.SelectedItem.ToString();
            cat.remove(folderToDelete);

            lb_category.Items.Clear();
            cb_category.Items.Clear();
            fillCategoryList();
        }




        

        private void btn_add_category_Click(object sender, EventArgs e)
        {
            lb_category.Items.Clear();
            cb_category.Items.Clear();
            var categoryName = txtBox_new_category.Text;
            cat.newFolder(categoryName);
            fillCategoryList();
        }

        public void fillCategoryList()
        {
            string[] catArray = Directory.GetDirectories(Directory.GetCurrentDirectory() + @"\categories");

            foreach (String cat in catArray)
            {
                string[] trimmedCat = cat.Split('\\');
                int length = trimmedCat.Length - 1;
                string fixedCat = trimmedCat[length];
                lb_category.Items.Add(fixedCat);
                cb_category.Items.Add(fixedCat);
            }
        }
    }
}
