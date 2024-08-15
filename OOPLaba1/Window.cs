using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;



namespace OOPLaba1
{
    public partial class Window : Form
    {
        private MilitaryAirport militaryAirport;
        private CivilAirport civilAirport;
        private Airport airport;
        private AirportCollection<IAirport> airports = new AirportCollection<IAirport>();
        private AirportListener listener = new AirportListener();

        public Window()
        {
            airport = new Airport();  
            InitializeComponent();
            airports.AirportAdded += listener.AirportAddedHandler;
            airports.AirportRemoved += listener.AirportRemovedHandler;

        }

        private void Window_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Лабораторная работа №3. Порождающие паттерны.\r\nШмоленко,Васильев;22ВП1;Вариант 5", "Hello!");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldName">имя поля класса Airport</param>
        /// <param name="value">значение поля класса</param>
        /// <param name="richTextBox">элементы формы</param>
        private void DisplayFieldInHex(string fieldName, int value, System.Windows.Forms.RichTextBox richTextBox)
        {
            // Convert the value to hexadecimal representation
            string hexValue = value.ToString("X");

            // Display the field name and its hexadecimal value
            richTextBox.AppendText($"{fieldName}: {hexValue}\n\n");
        }

        private void output_Click(object sender, EventArgs e)
        {
            output_TextBox.AppendText("Вывод используя переопределенный ToString():\n");
            output_TextBox.AppendText(airport.ToString());
            output_TextBox.AppendText("\n");

            output_TextBox.AppendText("Вывод, обращаясь к полям напрямую:\n");
            output_TextBox.AppendText($"Airport Name: {airport.GetAirportName()}\n");
            output_TextBox.AppendText($"Flight Count: {airport.GetFlightCount()}\n");
            output_TextBox.AppendText($"Tickets Sold: {airport.GetTicketsSold()}\n");
            output_TextBox.AppendText($"Country Code: {airport.GetCountryCode()}\n");
            output_TextBox.AppendText($"Opening Year: {airport.GetOpeningYear()}\n");
            output_TextBox.AppendText($"Airport Area: {airport.GetAirportArea()}\n");
            output_TextBox.AppendText($"Airport Rating: {airport.GetAirportRating()}\n\n");

            output_TextBox.AppendText("Вывод одного из полей в шестнадцатеричном представлении:\n");
            DisplayFieldInHex("OpeningYear", airport.GetOpeningYear(), output_TextBox);
            output_TextBox.AppendText($"Количество созданных объектов: {airport.GetObjectCount()}\n\n");
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int MessageBox(int hWnd, string text, string caption, int type);
        private void changeField_Click(object sender, EventArgs e)
        { 
            try
            {
                airport.SetAirportName(_AirportNameTextBox.Text);
                airport.SetFlightCount(int.Parse(_FlightCountTextBox.Text));
                if (_FlightCountTextBox.Value < 0) { System.Windows.Forms.MessageBox.Show("Значение FlightCount не должно быть отрицательным", "Ошибка"); _FlightCountTextBox.Value = 0; }
                airport.SetTicketsSold(int.Parse(_TicketsSoldTextBox.Text));
                if (_TicketsSoldTextBox.Value < 0) { System.Windows.Forms.MessageBox.Show("Значение TicketsSold не должно быть отрицательным", "Ошибка"); _TicketsSoldTextBox.Value = 0; }
                airport.SetCountryCode(_CountryCodeTextBox.Text);
                airport.SetOpeningYear(int.Parse(_OpeningYearTextBox.Text));
                if (_OpeningYearTextBox.Value < 1910) { System.Windows.Forms.MessageBox.Show("Значение OpeningYear не может быть меньше 1910", "Ошибка"); _OpeningYearTextBox.Value = 1910; }
                if (_OpeningYearTextBox.Value > 2024) { System.Windows.Forms.MessageBox.Show("Значение OpeningYear не может быть больше 2024", "Ошибка"); _OpeningYearTextBox.Value = 2024; }
                airport.SetAirportArea(double.Parse(_AirportAreaTextBox.Text));
                if (_AirportAreaTextBox.Value < 0) { System.Windows.Forms.MessageBox.Show("Значение AirportArea не должно быть отрицательным", "Ошибка"); _AirportAreaTextBox.Value = 0; }
                double rating = double.Parse(_AirportRatingTextBox.Text);
                if (rating < 1 || rating > 5)
                {
                    throw new CustomInvalidCastException("Неправильное значение. Рейтинг должен быть между 1 и 5.", _AirportRatingTextBox.Text);
                }
                airport.SetAirportRating(rating);
            }
            catch (CustomInvalidCastException ex)
            {
                MessageBox(0, ex.Message, "Ошибка", 0);
                output_TextBox.AppendText("Данные исключения: " + ex.CustomData + "\n");
            }
            catch (InvalidCastException ex)
            {
                MessageBox(0, ex.Message, "Ошибка", 0);
            }
            catch (Exception ex)
            {
                ex.Data.Add("Field7Value", _AirportRatingTextBox.Text);
                string errorMessage = $"{ex.Message}\n\nДанные исключения: {ex.Data["Field7Value"]}";

                output_TextBox.AppendText("Ошибка:\n");
                output_TextBox.AppendText(errorMessage);

                System.Windows.Forms.MessageBox.Show(errorMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddObject_Click(object sender, EventArgs e)
        {
            airport = new Airport();
        }

        private void ConstructorDefaultRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton ConstructorDefaultRadio = (RadioButton)sender;
            if (ConstructorDefaultRadio.Checked)
            {
                showFields(0);
            }
        }

        private void showFields(int numberArguments)
        {
            clearAllFields();
            switch (numberArguments)
            {
                case 0:
                    _AirportNameTextBoxConstructor.Visible = false;
                    _FlightCountTextBoxConstructor.Visible = false;
                    _CountryCodeTextBoxConstructor.Visible = false;
                    _TicketsSoldTextBoxConstructor.Visible = false;
                    _OpeningYearTextBoxConstructor.Visible = false;
                    _AirportAreaTextBoxConstructor.Visible = false;
                    _AirportRatingTextBoxConstructor.Visible = false;
                    _AirportNameLabelConstructor.Visible = false;
                    _FlightCountLabelConstructor.Visible = false;
                    _TicketsSoldLabelConstructor.Visible = false;
                    _CountryCodeLabelConstructor.Visible = false;
                    _OpeningYearLabelConstructor.Visible = false;
                    _AirportAreaLabelConstructor.Visible = false;
                    _AirportRatingLabelConstructor.Visible = false;
                    break;
                case 1:
                    _AirportNameTextBoxConstructor.Visible = true;
                    _FlightCountTextBoxConstructor.Visible = false;
                    _CountryCodeTextBoxConstructor.Visible = false;
                    _TicketsSoldTextBoxConstructor.Visible = false;
                    _OpeningYearTextBoxConstructor.Visible = false;
                    _AirportAreaTextBoxConstructor.Visible = false;
                    _AirportRatingTextBoxConstructor.Visible = false;
                    _AirportNameLabelConstructor.Visible = true;
                    _FlightCountLabelConstructor.Visible = false;
                    _TicketsSoldLabelConstructor.Visible = false;
                    _CountryCodeLabelConstructor.Visible = false;
                    _OpeningYearLabelConstructor.Visible = false;
                    _AirportAreaLabelConstructor.Visible = false;
                    _AirportRatingLabelConstructor.Visible = false;
                    break;
                case 2:
                    _AirportNameTextBoxConstructor.Visible = true;
                    _FlightCountTextBoxConstructor.Visible = true;
                    _CountryCodeTextBoxConstructor.Visible = false;
                    _TicketsSoldTextBoxConstructor.Visible = false;
                    _OpeningYearTextBoxConstructor.Visible = false;
                    _AirportAreaTextBoxConstructor.Visible = false;
                    _AirportRatingTextBoxConstructor.Visible = false;
                    _AirportNameLabelConstructor.Visible = true;
                    _FlightCountLabelConstructor.Visible = true;
                    _TicketsSoldLabelConstructor.Visible = false;
                    _CountryCodeLabelConstructor.Visible = false;
                    _OpeningYearLabelConstructor.Visible = false;
                    _AirportAreaLabelConstructor.Visible = false;
                    _AirportRatingLabelConstructor.Visible = false;
                    break;
                case 7:
                    _AirportNameTextBoxConstructor.Visible = true;
                    _FlightCountTextBoxConstructor.Visible = true;
                    _CountryCodeTextBoxConstructor.Visible = true;
                    _TicketsSoldTextBoxConstructor.Visible = true;
                    _OpeningYearTextBoxConstructor.Visible = true;
                    _AirportAreaTextBoxConstructor.Visible = true;
                    _AirportRatingTextBoxConstructor.Visible = true;
                    _AirportNameLabelConstructor.Visible = true;
                    _FlightCountLabelConstructor.Visible = true;
                    _TicketsSoldLabelConstructor.Visible = true;
                    _CountryCodeLabelConstructor.Visible = true;
                    _OpeningYearLabelConstructor.Visible = true;
                    _AirportAreaLabelConstructor.Visible = true;
                    _AirportRatingLabelConstructor.Visible = true;
                    break;
            }
        }

        private void Constructor1Radio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton Constructor1Radio = (RadioButton)sender;
            if (Constructor1Radio.Checked)
            {
                showFields(1);
            }
        }

        private void Constructor2Radio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton Constructor2Radio = (RadioButton)sender;
            if (Constructor2Radio.Checked)
            {
                showFields(2);
            }
        }

        private void ConstructorAllRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton ConstructorAllRadio = (RadioButton)sender;
            if (ConstructorAllRadio.Checked)
            {
                showFields(7);
            }
            try
            {
                airport.SetCountryCode(_CountryCodeTextBoxConstructor.Text);
                airport.SetOpeningYear(int.Parse(_OpeningYearTextBoxConstructor.Text));
                if (_OpeningYearTextBoxConstructor.Value < 1910) { System.Windows.Forms.MessageBox.Show("Значение OpeningYear не может быть меньше 1910", "Ошибка"); _OpeningYearTextBoxConstructor.Value = 1910; }
                if (_OpeningYearTextBoxConstructor.Value > 2024) { System.Windows.Forms.MessageBox.Show("Значение OpeningYear не может быть больше 2024", "Ошибка"); _OpeningYearTextBoxConstructor.Value = 2024; }
                airport.SetAirportArea(double.Parse(_AirportAreaTextBoxConstructor.Text));
                if (_AirportAreaTextBoxConstructor.Value < 0) { System.Windows.Forms.MessageBox.Show("Значение AirportArea не должно быть отрицательным", "Ошибка"); _AirportAreaTextBoxConstructor.Value = 0; }
                double rating = double.Parse(_AirportRatingTextBoxConstructor.Text);
                if (rating < 1 || rating > 5)
                {
                    throw new CustomInvalidCastException("Неправильное значение. Рейтинг должен быть между 1 и 5.", _AirportRatingTextBoxConstructor.Text);
                }
                airport.SetAirportRating(rating);
            }
            catch (CustomInvalidCastException ex)
            {
                MessageBox(0, ex.Message, "Ошибка", 0);
                output_TextBox.AppendText("Данные исключения: " + ex.CustomData + "\n");
            }
            catch (InvalidCastException ex)
            {
                MessageBox(0, ex.Message, "Ошибка", 0);
            }
            catch (Exception ex)
            {
                ex.Data.Add("Field7Value", _AirportRatingTextBoxConstructor.Text);
                string errorMessage = $"{ex.Message}\n\nДанные исключения: {ex.Data["Field7Value"]}";

                output_TextBox.AppendText("Ошибка:\n");
                output_TextBox.AppendText(errorMessage);

                System.Windows.Forms.MessageBox.Show(errorMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void clearAllFields()
        {
            _AirportNameTextBoxConstructor.Text = " ";
            _FlightCountTextBoxConstructor.Value = 0;
            _TicketsSoldTextBoxConstructor.Value = 0;
            _CountryCodeTextBoxConstructor.Text = " ";
            _OpeningYearTextBoxConstructor.Value = 1910;
            _AirportAreaTextBoxConstructor.Value = 0;
            _AirportRatingTextBoxConstructor.Value = 1;
        }

        private void Field1TB_TextChanged(object sender, EventArgs e)
        {
            airport.SetAirportName(Convert.ToString(_AirportNameTextBoxConstructor.Text));
        }

        private void Field2TB_ValueChanged(object sender, EventArgs e)
        {
            airport.SetFlightCount(int.Parse(_FlightCountTextBoxConstructor.Text));
            if (_FlightCountTextBoxConstructor.Value < 0) { System.Windows.Forms.MessageBox.Show("Значение FlightCount не должно быть отрицательным", "Ошибка"); _FlightCountTextBoxConstructor.Value = 0; }
        }

        private void Field3TB_ValueChanged(object sender, EventArgs e)
        {
            airport.SetTicketsSold(int.Parse(_TicketsSoldTextBoxConstructor.Text));
            if (_TicketsSoldTextBoxConstructor.Value < 0) { System.Windows.Forms.MessageBox.Show("Значение TicketsSold не должно быть отрицательным", "Ошибка"); _TicketsSoldTextBoxConstructor.Value = 0; }
        }

        private void Field4TB_TextChanged(object sender, EventArgs e)
        {
            airport.SetCountryCode(_CountryCodeTextBoxConstructor.Text);
        }

        private void Field5TB_ValueChanged(object sender, EventArgs e)
        {
            airport.SetOpeningYear(int.Parse(_OpeningYearTextBoxConstructor.Text));
            if (_OpeningYearTextBoxConstructor.Value < 1910) { System.Windows.Forms.MessageBox.Show("Значение OpeningYear не может быть меньше 1910", "Ошибка"); _OpeningYearTextBoxConstructor.Value = 1910; }
            if (_OpeningYearTextBoxConstructor.Value > 2024) { System.Windows.Forms.MessageBox.Show("Значение OpeningYear не может быть больше 2024", "Ошибка"); _OpeningYearTextBoxConstructor.Value = 2024; }
        }

        private void Field6TB_ValueChanged(object sender, EventArgs e)
        {
            airport.SetAirportArea(double.Parse(_AirportAreaTextBoxConstructor.Text));
            if (_AirportAreaTextBoxConstructor.Value < 0) { System.Windows.Forms.MessageBox.Show("Значение AirportArea не должно быть отрицательным", "Ошибка"); _AirportAreaTextBoxConstructor.Value = 0; }
        }

        private void Field7TB_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                double rating = double.Parse(_AirportRatingTextBoxConstructor.Text);
                if (rating < 1 || rating > 5)
                {
                    throw new CustomInvalidCastException("Неправильное значение. Рейтинг должен быть между 1 и 5.", _AirportRatingTextBoxConstructor.Text);
                }
                airport.SetAirportRating(rating);
            }
            catch (CustomInvalidCastException ex)
            {
                MessageBox(0, ex.Message, "Ошибка", 0);
                output_TextBox.AppendText("Данные исключения: " + ex.CustomData + "\n");
            }
            catch (InvalidCastException ex)
            {
                MessageBox(0, ex.Message, "Ошибка", 0);
            }
            catch (Exception ex)
            {
                ex.Data.Add("Field7Value", _AirportRatingTextBoxConstructor.Text);
                string errorMessage = $"{ex.Message}\n\nДанные исключения: {ex.Data["Field7Value"]}";

                output_TextBox.AppendText("Ошибка:\n");
                output_TextBox.AppendText(errorMessage);

                System.Windows.Forms.MessageBox.Show(errorMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void UpdateAirportList()
        {
            CollectionOutputTextBox.Clear();
            foreach (IAirport airport in airports.GetAirports())
            {
                CollectionOutputTextBox.AppendText(airport.ToString());
            }
        }

        private void AddToCollectionButton_Click(object sender, EventArgs e)
        {
            IAirport airportObject;
            if (UnknownAirportTypeRadioButton.Checked)
            {
                airportObject = new Airport("Неизвестно",
                                                     _AirportNameTextBox.Text,
                                                     int.Parse(_FlightCountTextBox.Text),
                                                     int.Parse(_TicketsSoldTextBox.Text),
                                                     _CountryCodeTextBox.Text,
                                                     int.Parse(_OpeningYearTextBox.Text),
                                                     double.Parse(_AirportAreaTextBox.Text),
                                                     double.Parse(_AirportRatingTextBox.Text));
            }
            else if (MilitaryAirportTypeRadioButton.Checked)
            {
                airportObject = new MilitaryAirport(0, "Военный",
                                                     _AirportNameTextBox.Text,
                                                     int.Parse(_FlightCountTextBox.Text),
                                                     _CountryCodeTextBox.Text,
                                                     int.Parse(_OpeningYearTextBox.Text),
                                                     double.Parse(_AirportAreaTextBox.Text));
            }
            else
            {
                airportObject = new CivilAirport(0, "Гражданский",
                                                   _AirportNameTextBox.Text,
                                                   int.Parse(_FlightCountTextBox.Text),
                                                   int.Parse(_TicketsSoldTextBox.Text),
                                                   _CountryCodeTextBox.Text,
                                                   int.Parse(_OpeningYearTextBox.Text),
                                                   double.Parse(_AirportAreaTextBox.Text),
                                                   double.Parse(_AirportRatingTextBox.Text));
            }
            airports.AddAirport(airportObject);  // Add the IAirport object
            UpdateAirportList();
        }

        private void DeleteFromCollectionButton_Click(object sender, EventArgs e)
        {
            if (airports.GetAirports().Count() > 0)
            {
                airports.RemoveAirport(airports.GetAirports().Last());
                UpdateAirportList();
            }

        }

        private void CollectionOutputButton_Click(object sender, EventArgs e)
        {
            UpdateAirportList();
        }

        private void PerformanceTestButton_Click(object sender, EventArgs e)
        {
            // Создание 10000 элементов
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
            {
                airports.AddAirport(new Airport());
            }
            stopwatch.Stop();
            long insertTime = stopwatch.ElapsedMilliseconds;

            // Тестовая выборка 10000 элементов
            stopwatch.Restart();
            for (int i = 0; i < 1000; i++)
            {
                airports.GetAirports().ToList(); // Извлечение всех элементов в список
            }
            stopwatch.Stop();
            long selectTime = stopwatch.ElapsedMilliseconds;

            // Тестовая выборка 10000 элементов в случайном порядке
            stopwatch.Restart();
            Random random = new Random();
            for (int i = 0; i < 1000; i++)
            {
                airports.GetAirports().ToList(); // Извлечение всех элементов в список
            }
            stopwatch.Stop();
            long selectRandomTime = stopwatch.ElapsedMilliseconds;

            // Отображение результатов в ListView таблице
            PerformanceResultsListView.View = View.Details;
            PerformanceResultsListView.GridLines = true;
            PerformanceResultsListView.Columns.Add("Тип операции", 120);
            PerformanceResultsListView.Columns.Add("Время (мс)", 100);
            ListViewItem insertItem = new ListViewItem("Вставка");
            insertItem.SubItems.Add(insertTime.ToString());
            ListViewItem selectItem = new ListViewItem("Последовательная выборка");
            selectItem.SubItems.Add(selectTime.ToString());
            ListViewItem selectRandomItem = new ListViewItem("Случайная выборка");
            selectRandomItem.SubItems.Add(selectRandomTime.ToString());

            PerformanceResultsListView.Items.AddRange(new ListViewItem[] { insertItem, selectItem, selectRandomItem });
        }

        private void SearchByCountryCodeButton_Click(object sender, EventArgs e)
        {
            string countryCode = _CountryCodeSearchTextBox.Text;
            List<IAirport> matchingAirports = new List<IAirport>();

            foreach (IAirport airport in airports.GetAirports())
            {
                IAirportSearch searchAdapter = new CountrySearchAdapter(airport);
                matchingAirports.AddRange(searchAdapter.SearchByCountryCode(countryCode));
            }

            if (matchingAirports.Count > 0)
            {
                output_TextBox.Clear();
                output_TextBox.AppendText("Найденные аэропорты по коду страны: " + countryCode + "\n");
                foreach (IAirport airport in matchingAirports)
                {
                    output_TextBox.AppendText(airport.ToString() + "\n");
                }
            }
            else
            {
                output_TextBox.Clear();
                output_TextBox.AppendText("Аэропортов по коду страны: " + countryCode + " не найдено\n");
            }
        }

        private Stack<Memento> mementoStack = new Stack<Memento>();

        private void CreateSnapshotButton_Click(object sender, EventArgs e)
        {
            CreateMemento();
        }
        private void CreateMemento()
        {
            Memento memento = new Memento(airport.GetAirportName(),
                                          airport.GetFlightCount(),
                                          airport.GetTicketsSold(),
                                          airport.GetCountryCode(),
                                          airport.GetOpeningYear(),
                                          airport.GetAirportArea(),
                                          airport.GetAirportRating());
            mementoStack.Push(memento);
            System.Windows.Forms.MessageBox.Show("Snapshot created successfully!");
        }

        private void RestoreFromMemento()
        {
            if (mementoStack.Count > 0)
            {
                Memento memento = mementoStack.Pop();
                airport.SetAirportName(memento.AirportName);
                airport.SetFlightCount(memento.FlightCount);
                // ... остальные свойства ...
                UpdateControlsWithAirportData(); // Обновление элементов управления формы
                System.Windows.Forms.MessageBox.Show("Restored from snapshot successfully!");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("No snapshots available to restore!");
            }
        }

        private void UpdateControlsWithAirportData()
        {
            // Обновление элементов управления формы с текущими данными аэропорта
            _AirportNameTextBox.Text = airport.GetAirportName();
            _FlightCountTextBox.Value = airport.GetFlightCount();
            // ... остальные элементы управления ...
        }

        private void RestoreSnapshotButton_Click(object sender, EventArgs e)
        {
            RestoreFromMemento();
        }
    }
}

