using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ArtSchoolApp
{
    public partial class Form1 : Form
    {
        // Коллекция для хранения всех учеников (требование методички)
        private List<Studentq> allStudents = new List<Studentq>();

        // Временная коллекция для отображения (нужна для поиска)
        private List<Studentq> displayedStudents = new List<Studentq>();

        public Form1()
        {
            InitializeComponent();

            // Привязка кнопок к методам
            this.btnAdd.Click += BtnAdd_Click;
            this.btnDelete.Click += BtnDelete_Click;
            this.btnSearch.Click += BtnSearch_Click;
            this.btnShowAll.Click += BtnShowAll_Click;

            RefreshList();
        }

        // --- ДОБАВЛЕНИЕ ---
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string ageText = txtAge.Text.Trim();
            string course = txtCourse.Text.Trim();

            // === ОБРАБОТКА ОШИБОК (Для Теста №3 и №5) ===
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Ошибка: Введите ФИО ученика.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка, что возраст - это число, и оно адекватное
            if (!int.TryParse(ageText, out int age) || age <= 0 || age > 120)
            {
                MessageBox.Show("Ошибка: Введите корректный возраст (целое число от 1 до 120).\nНельзя вводить буквы или отрицательные числа!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(course))
            {
                MessageBox.Show("Ошибка: Введите название курса.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Создание объекта и добавление в коллекцию
            Studentq newStudent = new Studentq
            {
                FullName = name,
                Age = age,
                CourseName = course
            };

            allStudents.Add(newStudent);

            // Очистка полей ввода
            txtName.Clear();
            txtAge.Clear();
            txtCourse.Clear();
            txtName.Focus();

            RefreshList();
        }

        // --- УДАЛЕНИЕ ---
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // === ОБРАБОТКА НЕСТАНДАРТНОЙ СИТУАЦИИ (Тест №5) ===
            if (lstStudents.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите ученика в списке для удаления.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Получаем выбранного студента
            Studentq selectedStudent = displayedStudents[lstStudents.SelectedIndex];

            // Удаляем из главной коллекции
            allStudents.Remove(selectedStudent);

            RefreshList();
        }

        // --- ПОИСК ---
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchQuery))
            {
                MessageBox.Show("Введите текст для поиска.", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Фильтрация коллекции (Тест №4)
            displayedStudents = allStudents
                .Where(s => s.FullName.ToLower().Contains(searchQuery))
                .ToList();

            RefreshList();
        }

        // --- СБРОС ПОИСКА ---
        private void BtnShowAll_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            RefreshList();
        }

        // --- ОБНОВЛЕНИЕ СПИСКА НА ЭКРАНЕ ---
        private void RefreshList()
        {
            lstStudents.Items.Clear();

            // Если поле поиска пустое, показываем всех
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                displayedStudents = allStudents.ToList();
            }

            foreach (var student in displayedStudents)
            {
                lstStudents.Items.Add(student.ToString());
            }
        }
    }
}