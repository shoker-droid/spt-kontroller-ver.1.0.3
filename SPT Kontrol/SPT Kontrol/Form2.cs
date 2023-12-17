﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Resolvers;
using System.Xml.Serialization;

namespace SPT_Kontrol
{
    public partial class Form2 : Form
    {
        private bool isCollapsed;
        private bool isCollapsedSecond;
        private bool isCollapsedThird;
        private bool isCollapsedFourth;
        private bool isCollapsedFifth;
        private bool isCollapsedSixth;
        private bool isCollapsedSeventh;


        private TagList _xmlModel = new TagList();
        public Form2()
        {
            InitializeComponent();

            //panelElement.Hide();
            //tabControlElement.Hide();


        }
        // Добавьте конструктор, который принимает путь к файлу
        /* public Form2(string filePath) : this()
         {
             _filePath = filePath;
         }*/
        /*
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelDropDown.Height += 10;
                if (panelDropDown.Size == panelDropDown.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }



            else
            {
                panelDropDown.Height -= 10;
                if (panelDropDown.Size == panelDropDown.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }

            }
        }*/

        // private void button1_Click(object sender, EventArgs e)
        //{
        // timer1.Start();
        //}

        //private void panel1_Paint(object sender, PaintEventArgs e)
        //{

        //}
        //private void panelDropDownSecond_Click(object sender, PaintEventArgs e)
        //{

        // }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //   timer2.Start();
        //}
        /*
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsedSecond)
            {
                panelDropDownSecond.Height += 10;
                if (panelDropDownSecond.Size == panelDropDownSecond.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsedSecond = false;
                }
            }
            else
            {
                panelDropDownSecond.Height -= 10;
                if (panelDropDownSecond.Size == panelDropDownSecond.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsedSecond = true;
                }

            }
        }*/
        /*
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (isCollapsedThird)
            {
                panelDropDownThird.Height += 10;
                if (panelDropDownThird.Size == panelDropDownThird.MaximumSize)
                {
                    timer3.Stop();
                    isCollapsedThird = false;
                }
            }
            else
            {
                panelDropDownThird.Height -= 10;
                if (panelDropDownThird.Size == panelDropDownThird.MinimumSize)
                {
                    timer3.Stop();
                    isCollapsedThird = true;
                }

            }
        }
        */
        //private void button3_Click(object sender, EventArgs e)
        //{
        //timer3.Start();
        //}
        /*
        private void timer4_Tick(object sender, EventArgs e)
        {
            if (isCollapsedFourth)
            {
                panelDropDownFourth.Height += 10;
                if (panelDropDownFourth.Size == panelDropDownFourth.MaximumSize)
                {
                    timer4.Stop();
                    isCollapsedFourth = false;
                }
            }
            else
            {
                panelDropDownFourth.Height -= 10;
                if (panelDropDownFourth.Size == panelDropDownFourth.MinimumSize)
                {
                    timer4.Stop();
                    isCollapsedFourth = true;
                }

            }
        }
        */
        // private void button4_Click(object sender, EventArgs e)
        //{
        // timer4.Start();
        //}
        /*
        private void timer5_Tick(object sender, EventArgs e)
        {
            if (isCollapsedFifth)
            {
                panelDropDownFifth.Height += 10;
                if (panelDropDownFifth.Size == panelDropDownFifth.MaximumSize)
                {
                    timer5.Stop();
                    isCollapsedFifth = false;
                }
            }
            else
            {
                panelDropDownFifth.Height -= 10;
                if (panelDropDownFifth.Size == panelDropDownFifth.MinimumSize)
                {
                    timer5.Stop();
                    isCollapsedFifth = true;
                }

            }
        }
        */
        // private void button5_Click(object sender, EventArgs e)
        //{
        //  timer5.Start();
        // }

        /*
        private void timer6_Tick(object sender, EventArgs e)
        {
            if (isCollapsedSixth)
            {
                panelDropDownSixth.Height += 10;
                if (panelDropDownSixth.Size == panelDropDownSixth.MaximumSize)
                {
                    timer6.Stop();
                    isCollapsedSixth = false;
                }
            }
            else
            {
                panelDropDownSixth.Height -= 10;
                if (panelDropDownSixth.Size == panelDropDownSixth.MinimumSize)
                {
                    timer6.Stop();
                    isCollapsedSixth = true;
                }

            }
        }
        */
        // private void button6_Click(object sender, EventArgs e)
        //{
        // timer6.Start();
        //}

        /*
        private void timer7_Tick(object sender, EventArgs e)
        {
            if (isCollapsedSeventh)
            {
                panelDropDownSeventh.Height += 10;
                if (panelDropDownSeventh.Size == panelDropDownSeventh.MaximumSize)
                {
                    timer7.Stop();
                    isCollapsedSeventh = false;
                }
            }
            else
            {
                panelDropDownSeventh.Height -= 10;
                if (panelDropDownSeventh.Size == panelDropDownSeventh.MinimumSize)
                {
                    timer7.Stop();
                    isCollapsedSeventh = true;
                }

            }
        }
        */
        //private void button7_Click(object sender, EventArgs e)
        //{
        //timer7.Start();
        //}

        //private void label21_Click(object sender, EventArgs e)
        //{
        //panelElement.Show();
        //}

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ConvertTreeViewIntoDataGridView();

            // Загрузка данных при открытии формы

        }


        private void ConvertTreeViewIntoDataGridView()
        {
            //Создаем новый объект DataTable
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Канал", typeof(string));
            dataTable.Columns.Add("Параметр", typeof(string));
            dataTable.Columns.Add("Значение", typeof(string));

            // Получение корневых узлов из TreeView
            var rootNodes = treeView1.Nodes.Cast<TreeNode>().Where(node => node.Parent == null).ToList();
            //Создаем новую модель
            _xmlModel = new TagList();
            // Обход корневых узлов
            foreach (var rootNode in rootNodes)
            {
                Debug.WriteLine("Заполняем корневой узел");
                //Заполняем корневой узел
                _xmlModel.TargetDevice = rootNode.Text;
                _xmlModel.Id = 101010;
                _xmlModel.SerialNumber = "???";
                _xmlModel.Channel = new List<Channel>();
                // Получение всех дочерних узлов для текущего корневого узла
                var childNodes = GetChildNodes(rootNode);
                int channelNumber = 1;
                foreach (var node in childNodes)
                {
                    Debug.WriteLine("Для каждого дочернего объекта создаем объект Channel и заполняем его");
                    //Для каждого дочернего объекта создаем объект Channel и заполняем его
                    var currentChannel = new Channel();
                    currentChannel.No = channelNumber;
                    currentChannel.Name = node.Text;
                    currentChannel.Kind = "Channel";
                    currentChannel.Prefix = node.Text.Substring(0, 1);
                    currentChannel.Description = "???";
                    currentChannel.Tag = new List<BaseTag>();
                    // Добавляем к корневому
                    _xmlModel.Channel.Add(currentChannel);
                    // Получение всех дочерних узлов для node
                    var childrens = GetChildNodes(node);
                    foreach (var childNode in childrens)
                    {
                        Debug.WriteLine("Для каждого дочернего объекта проверяем есть ли у него дети");
                        //Для каждого дочернего объекта проверяем есть ли у него дети
                        if (childNode.Nodes.Count > 0)
                        {
                            Debug.WriteLine("Если дети есть то создаем для него объект TagGroup и заполняем");
                            //Если дети есть то создаем для него объект TagGroup и заполняем
                            var tagGroup = new TagGroup();
                            tagGroup.Ordinal = childNode.Text;
                            tagGroup.Name = "???";
                            tagGroup.Tag = new List<TagGroupTag>();
                            //Добавляем объекту Channel объект TagGroup
                            currentChannel.Tag.Add(tagGroup);
                            // Получение всех дочерних узлов для childNode
                            var childChildNodes = GetChildNodes(childNode);
                            int tagGroupIndex = 0;
                            foreach (var child in childChildNodes)
                            {
                                Debug.WriteLine("Для каждого дочернего объекта создаем объект TagGroupTag и заполняем");
                                //Для каждого дочернего объекта создаем объект TagGroupTag и заполняем
                                var tagGroupTag = new TagGroupTag();
                                tagGroupTag.Index = tagGroupIndex;
                                tagGroupTag.Id = child.Text;
                                tagGroupTag.Name = "???";
                                tagGroupTag.Value = string.Empty;
                                tagGroupTag.Eu = string.Empty;
                                // Добавляем объект TagGroupTag к объекту TagGroup
                                tagGroup.Tag.Add(tagGroupTag);
                                tagGroupIndex++;
                                //Добавляем строчку в dataTable 
                                dataTable.Rows.Add(node.Text, child.Text);
                            }
                            // Так как дети были то добавлять такую узел в DataTable не нужно, переходим к следующей итерации
                            continue;
                        }
                        //Если нет то создаем объект Tag и заполняем
                        var tag = new Tag();
                        tag.Ordinal = childNode.Text;
                        tag.Name = "???";
                        tag.Id = childNode.Text;
                        //После этого добавляем его к объекту Channel
                        currentChannel.Tag.Add(tag);
                        //Добавляем строчку в dataTable 
                        dataTable.Rows.Add(node.Text, childNode.Text);
                    }
                    channelNumber++;
                }
            }

            // Функция для получения всех дочерних узлов для указанного узла
            List<TreeNode> GetChildNodes(TreeNode node)
            {
                Debug.WriteLine("Получение всех дочерних узлов для node");
                List<TreeNode> childNodes = new List<TreeNode>();

                foreach (TreeNode childNode in node.Nodes)
                {
                    childNodes.Add(childNode);
                }

                return childNodes;
            }


            dataGridView1.DataSource = dataTable;

        }

        private void CreateXdb()
        {
            //Перебираем все строки из datagridView
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                //Получаем значения каждого столбца
                var channel = dataGridView1[0, i].Value.ToString();
                Debug.WriteLine("Channel = " + channel);
                var parametr = dataGridView1[1, i].Value.ToString();
                Debug.WriteLine("parametr = " + parametr);
                var value = dataGridView1[2, i].Value.ToString();
                Debug.WriteLine("value = " + value);
                //Если это узел без детей (типа Tag) то находим его
                var result = _xmlModel
                    .Channel.Where(x => x.Name == channel).FirstOrDefault()
                    ?.Tag.Where(x => (x as Tag)?.Ordinal == parametr).FirstOrDefault();

                if (result != null)
                {
                    //Если такой узел есть, то его значение делаем равным value
                    (result as Tag).Value = value;

                }
                //Если такого узла нет, то значит это узел с детьми типа TagGroup
                else
                {
                    //Находим такой узел
                    var tagGroup = _xmlModel
                        .Channel.Where(x => x.Name == channel).FirstOrDefault()
                        ?.Tag.Where(x => x.GetType() == typeof(TagGroup) && parametr.StartsWith((x as TagGroup).Ordinal)).FirstOrDefault() as TagGroup;
                    //Находим у него нужный нам объект типа Tag
                    var tag = tagGroup?.Tag.Where(x => x.Id.Replace(channel, "") == parametr).FirstOrDefault();
                    //var tag = tagGroup?.Tag.Where(x => x.Id.Remove(x.Id.IndexOf("Параметры")) == parametr).FirstOrDefault();
                    //Если нашли, то устанавливаем значение
                    if (tag != null)
                        tag.Value = value;
                }
            }
            //Создаем XmlSerializer и убираем все неймспейсы, делая их пустыми
            XmlSerializer serializer = new XmlSerializer(typeof(TagList));
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Xdb Files (*.xdb)|*.xdb";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Создаем FileStream и серилизуем нашу модель xml в файл output.xdb
                using (FileStream fileStream = new FileStream(sfd.FileName, FileMode.Create))
                {
                    serializer.Serialize(fileStream, _xmlModel, namespaces);
                    //StreamWriter sw = new StreamWriter(fileStream);
                    //sw.Close();

                }

            }


        }

        //private void button8_Click(object sender, EventArgs e)
        //{
        //
        //}

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();


            dataGridView1.Columns.Add("Column1", "Канал");
            dataGridView1.Columns.Add("Column2", "Параметр");
            dataGridView1.Columns.Add("Column3", "Значение");

            string parent = e.Node.Text;
            dataGridView1.Rows.Add(parent, "");

            foreach (var childNode in e.Node.Nodes.Cast<TreeNode>())
            {
                AddChildNodeToDataGridView(parent, childNode);
            }

            if (dataGridView1.Rows.Count > 2)
            {
                dataGridView1.Rows.RemoveAt(0);
            }
        }

        //private void UpdateDataGridView(TreeNode selectedNode)
        //{


        //    // Если у узла нет дочерних элементов, добавляем его в DataGridView
        //    //if (selectedNode.Nodes.Count == 0)
        //    //{
        //    //    dataGridView1.Rows.Add(selectedNode.Text, "");
        //    //}
        //    //else
        //    //{
        //    //    foreach (var item in selectedNode.Nodes)
        //    //    {
        //    //        if (item is TreeNode node)
        //    //        {

        //    //            if (node.Parent != null)
        //    //            {
        //    //                dataGridView1.Rows.Add(node.Parent.Text, node.Text, "");
        //    //            }
        //    //            else
        //    //            {
        //    //                dataGridView1.Rows.Add("", node.Text, "");
        //    //            }

        //    //        }
        //    //    }
        //    //}
        //}

        private void AddChildNodeToDataGridView(string parent, TreeNode node)
        {
            dataGridView1.Rows.Add(parent, node.Text);
            foreach (var childNode in node.Nodes.Cast<TreeNode>())
            {
                AddChildNodeToDataGridView(parent, childNode);
            }
        }

        private void buttonXdbOutput_Click(object sender, EventArgs e)
        {
            
                CreateXdb();
           
           

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SPT963ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 spt963form = new Form3();
            spt963form.Show();
        }

        private void SPT962ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 spt962form = new Form2();
            spt962form.Show();
        }

        private void ExitMainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainform = new Form1();
            mainform.Show();
        }

        private void SpravkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Создание и отображение модальной формы Form4
            using (Form4 spravkaForm = new Form4())
            {
                spravkaForm.StartPosition = FormStartPosition.CenterParent;
                spravkaForm.ShowDialog();
            }
        }


        // метод для загрузки данных
        public void LoadXdb(string filePath)
        {
            // Очищаем существующие данные
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // Создаем новый объект DataTable
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Канал", typeof(string));
            dataTable.Columns.Add("Параметр", typeof(string));
            dataTable.Columns.Add("Значение", typeof(string));

            // Загружаем данные из файла в _xmlModel
            XmlSerializer serializer = new XmlSerializer(typeof(TagList));
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                _xmlModel = (TagList)serializer.Deserialize(fileStream);
            }

            // Проверка значения параметра SerialNumber
            if (_xmlModel.TargetDevice == "СПТ962")
            {



                // Заполняем DataGridView данными из _xmlModel
                foreach (var channel in _xmlModel.Channel)
                {
                    foreach (var tagOrGroup in channel.Tag)
                    {
                        if (tagOrGroup is Tag tag)
                        {
                            dataTable.Rows.Add(channel.Name, tag.Ordinal, tag.Value);
                        }
                        else if (tagOrGroup is TagGroup tagGroup)
                        {
                            foreach (var tagGroupTag in tagGroup.Tag)
                            {
                                dataTable.Rows.Add(channel.Name, tagGroupTag.Id, tagGroupTag.Value);
                            }
                        }
                    }
                }

                // Устанавливаем источник данных для DataGridView
                dataGridView1.DataSource = dataTable;
            }
            else
            {
                string errorText = "Вы загружаете базу для СПТ963, попробуйте еще раз.";

                // Выводим MessageBox с текстом ошибки
                MessageBox.Show(errorText, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Xdb Files (*.xdb)|*.xdb";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                LoadXdb(ofd.FileName);
            }
        }




    }







    /* private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
     {
         if (comboBox1.SelectedIndex == 0)
         {
             tabControlElement.Show();
         }
     }

     */

}
