using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List_App
{
    public partial class ToDoList : Form
    {
        public ToDoList()
        {
            InitializeComponent();
        }
        DataTable todoList = new DataTable();
        bool isEditing = false;
        private void ToDoList_Load(object sender, EventArgs e)
        {
            todoList.Columns.Add("Title");
            todoList.Columns.Add("Description");
            toDoListView.DataSource = todoList;

        }

        private void new_button_Click(object sender, EventArgs e)
        {
            titleTextBox.Text = "";
            descriptionTextbox.Text = "";
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            isEditing = true;
            titleTextBox.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
            descriptionTextbox.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[1].ToString();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                todoList.Rows[toDoListView.CurrentCell.RowIndex].Delete();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                todoList.Rows[toDoListView.CurrentCell.RowIndex]["Title"] = titleTextBox.Text;
                todoList.Rows[toDoListView.CurrentCell.RowIndex]["Description"] = descriptionTextbox.Text;

            }
            else
            {
                todoList.Rows.Add(titleTextBox.Text, descriptionTextbox.Text);
            }
            titleTextBox.Text = "";
            descriptionTextbox.Text= "";
            isEditing = false;

        }
    }
}
