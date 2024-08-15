namespace OOPLaba1
{
    partial class Window
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.OutputButton = new System.Windows.Forms.Button();
            this.ChangeFieldButton = new System.Windows.Forms.Button();
            this._FlightCountTextBox = new System.Windows.Forms.NumericUpDown();
            this._TicketsSoldTextBox = new System.Windows.Forms.NumericUpDown();
            this._OpeningYearTextBox = new System.Windows.Forms.NumericUpDown();
            this._AirportAreaTextBox = new System.Windows.Forms.NumericUpDown();
            this._AirportRatingTextBox = new System.Windows.Forms.NumericUpDown();
            this._AirportNameTextBox = new System.Windows.Forms.TextBox();
            this._CountryCodeTextBox = new System.Windows.Forms.TextBox();
            this.output_TextBox = new System.Windows.Forms.RichTextBox();
            this.AddObject = new System.Windows.Forms.Button();
            this.ChangeFieldsLabel = new System.Windows.Forms.Label();
            this._AirportNameLabel = new System.Windows.Forms.Label();
            this._FlightCountLabel = new System.Windows.Forms.Label();
            this._TicketsSoldLabel = new System.Windows.Forms.Label();
            this._CountryCodeLabel = new System.Windows.Forms.Label();
            this._OpeningYearLabel = new System.Windows.Forms.Label();
            this._AirportAreaLabel = new System.Windows.Forms.Label();
            this._AirportRatingLabel = new System.Windows.Forms.Label();
            this.ConstructorDefaultRadio = new System.Windows.Forms.RadioButton();
            this.Constructor1Radio = new System.Windows.Forms.RadioButton();
            this.Constructor2Radio = new System.Windows.Forms.RadioButton();
            this.ConstructorAllRadio = new System.Windows.Forms.RadioButton();
            this.ConstructorGroupBox = new System.Windows.Forms.GroupBox();
            this._AirportNameTextBoxConstructor = new System.Windows.Forms.TextBox();
            this._CountryCodeTextBoxConstructor = new System.Windows.Forms.TextBox();
            this._FlightCountTextBoxConstructor = new System.Windows.Forms.NumericUpDown();
            this._TicketsSoldTextBoxConstructor = new System.Windows.Forms.NumericUpDown();
            this._OpeningYearTextBoxConstructor = new System.Windows.Forms.NumericUpDown();
            this._AirportAreaTextBoxConstructor = new System.Windows.Forms.NumericUpDown();
            this._AirportRatingTextBoxConstructor = new System.Windows.Forms.NumericUpDown();
            this._AirportNameLabelConstructor = new System.Windows.Forms.Label();
            this._FlightCountLabelConstructor = new System.Windows.Forms.Label();
            this._TicketsSoldLabelConstructor = new System.Windows.Forms.Label();
            this._CountryCodeLabelConstructor = new System.Windows.Forms.Label();
            this._OpeningYearLabelConstructor = new System.Windows.Forms.Label();
            this._AirportAreaLabelConstructor = new System.Windows.Forms.Label();
            this._AirportRatingLabelConstructor = new System.Windows.Forms.Label();
            this.PerformanceResultsListView = new System.Windows.Forms.ListView();
            this.PerformanceTestButton = new System.Windows.Forms.Button();
            this.CollectionOutputTextBox = new System.Windows.Forms.RichTextBox();
            this.CollectionOutputButton = new System.Windows.Forms.Button();
            this.AddToCollectionButton = new System.Windows.Forms.Button();
            this.DeleteFromCollectionButton = new System.Windows.Forms.Button();
            this.InputDataLabel = new System.Windows.Forms.Label();
            this.AirportTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.CivilAirportTypeRadioButton = new System.Windows.Forms.RadioButton();
            this.MilitaryAirportTypeRadioButton = new System.Windows.Forms.RadioButton();
            this.UnknownAirportTypeRadioButton = new System.Windows.Forms.RadioButton();
            this.SearchByCountryCodeButton = new System.Windows.Forms.Button();
            this._CountryCodeSearchTextBox = new System.Windows.Forms.TextBox();
            this.CreateSnapshotButton = new System.Windows.Forms.Button();
            this.RestoreSnapshotButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._FlightCountTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._TicketsSoldTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._OpeningYearTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._AirportAreaTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._AirportRatingTextBox)).BeginInit();
            this.ConstructorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._FlightCountTextBoxConstructor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._TicketsSoldTextBoxConstructor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._OpeningYearTextBoxConstructor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._AirportAreaTextBoxConstructor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._AirportRatingTextBoxConstructor)).BeginInit();
            this.AirportTypeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputButton
            // 
            this.OutputButton.Location = new System.Drawing.Point(1217, 332);
            this.OutputButton.Margin = new System.Windows.Forms.Padding(4);
            this.OutputButton.Name = "OutputButton";
            this.OutputButton.Size = new System.Drawing.Size(220, 55);
            this.OutputButton.TabIndex = 0;
            this.OutputButton.Text = "Вывести значения полей";
            this.OutputButton.UseVisualStyleBackColor = true;
            this.OutputButton.Click += new System.EventHandler(this.output_Click);
            // 
            // ChangeFieldButton
            // 
            this.ChangeFieldButton.Location = new System.Drawing.Point(989, 332);
            this.ChangeFieldButton.Margin = new System.Windows.Forms.Padding(4);
            this.ChangeFieldButton.Name = "ChangeFieldButton";
            this.ChangeFieldButton.Size = new System.Drawing.Size(220, 55);
            this.ChangeFieldButton.TabIndex = 6;
            this.ChangeFieldButton.Text = "Изменить значения полей";
            this.ChangeFieldButton.UseVisualStyleBackColor = true;
            this.ChangeFieldButton.Click += new System.EventHandler(this.changeField_Click);
            // 
            // _FlightCountTextBox
            // 
            this._FlightCountTextBox.Location = new System.Drawing.Point(15, 550);
            this._FlightCountTextBox.Margin = new System.Windows.Forms.Padding(4);
            this._FlightCountTextBox.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this._FlightCountTextBox.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this._FlightCountTextBox.Name = "_FlightCountTextBox";
            this._FlightCountTextBox.Size = new System.Drawing.Size(651, 22);
            this._FlightCountTextBox.TabIndex = 17;
            // 
            // _TicketsSoldTextBox
            // 
            this._TicketsSoldTextBox.Location = new System.Drawing.Point(15, 602);
            this._TicketsSoldTextBox.Margin = new System.Windows.Forms.Padding(4);
            this._TicketsSoldTextBox.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this._TicketsSoldTextBox.Minimum = new decimal(new int[] {
            1410065408,
            2,
            0,
            -2147483648});
            this._TicketsSoldTextBox.Name = "_TicketsSoldTextBox";
            this._TicketsSoldTextBox.Size = new System.Drawing.Size(651, 22);
            this._TicketsSoldTextBox.TabIndex = 18;
            // 
            // _OpeningYearTextBox
            // 
            this._OpeningYearTextBox.Location = new System.Drawing.Point(16, 703);
            this._OpeningYearTextBox.Margin = new System.Windows.Forms.Padding(4);
            this._OpeningYearTextBox.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this._OpeningYearTextBox.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this._OpeningYearTextBox.Name = "_OpeningYearTextBox";
            this._OpeningYearTextBox.Size = new System.Drawing.Size(649, 22);
            this._OpeningYearTextBox.TabIndex = 20;
            this._OpeningYearTextBox.Value = new decimal(new int[] {
            1910,
            0,
            0,
            0});
            // 
            // _AirportAreaTextBox
            // 
            this._AirportAreaTextBox.DecimalPlaces = 2;
            this._AirportAreaTextBox.Location = new System.Drawing.Point(20, 758);
            this._AirportAreaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this._AirportAreaTextBox.Name = "_AirportAreaTextBox";
            this._AirportAreaTextBox.Size = new System.Drawing.Size(645, 22);
            this._AirportAreaTextBox.TabIndex = 21;
            // 
            // _AirportRatingTextBox
            // 
            this._AirportRatingTextBox.DecimalPlaces = 2;
            this._AirportRatingTextBox.Location = new System.Drawing.Point(20, 810);
            this._AirportRatingTextBox.Margin = new System.Windows.Forms.Padding(4);
            this._AirportRatingTextBox.Name = "_AirportRatingTextBox";
            this._AirportRatingTextBox.Size = new System.Drawing.Size(645, 22);
            this._AirportRatingTextBox.TabIndex = 22;
            // 
            // _AirportNameTextBox
            // 
            this._AirportNameTextBox.Location = new System.Drawing.Point(16, 496);
            this._AirportNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this._AirportNameTextBox.Name = "_AirportNameTextBox";
            this._AirportNameTextBox.Size = new System.Drawing.Size(648, 22);
            this._AirportNameTextBox.TabIndex = 23;
            // 
            // _CountryCodeTextBox
            // 
            this._CountryCodeTextBox.Location = new System.Drawing.Point(13, 649);
            this._CountryCodeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this._CountryCodeTextBox.Name = "_CountryCodeTextBox";
            this._CountryCodeTextBox.Size = new System.Drawing.Size(651, 22);
            this._CountryCodeTextBox.TabIndex = 24;
            // 
            // output_TextBox
            // 
            this.output_TextBox.Location = new System.Drawing.Point(676, 18);
            this.output_TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.output_TextBox.Name = "output_TextBox";
            this.output_TextBox.ReadOnly = true;
            this.output_TextBox.Size = new System.Drawing.Size(823, 306);
            this.output_TextBox.TabIndex = 25;
            this.output_TextBox.Text = "";
            // 
            // AddObject
            // 
            this.AddObject.Location = new System.Drawing.Point(768, 332);
            this.AddObject.Margin = new System.Windows.Forms.Padding(4);
            this.AddObject.Name = "AddObject";
            this.AddObject.Size = new System.Drawing.Size(213, 55);
            this.AddObject.TabIndex = 26;
            this.AddObject.Text = "Добавить новый объект";
            this.AddObject.UseVisualStyleBackColor = true;
            this.AddObject.Click += new System.EventHandler(this.AddObject_Click);
            // 
            // ChangeFieldsLabel
            // 
            this.ChangeFieldsLabel.AutoSize = true;
            this.ChangeFieldsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeFieldsLabel.Location = new System.Drawing.Point(196, 11);
            this.ChangeFieldsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ChangeFieldsLabel.Name = "ChangeFieldsLabel";
            this.ChangeFieldsLabel.Size = new System.Drawing.Size(247, 31);
            this.ChangeFieldsLabel.TabIndex = 27;
            this.ChangeFieldsLabel.Text = "Изменение полей:";
            // 
            // _AirportNameLabel
            // 
            this._AirportNameLabel.AutoSize = true;
            this._AirportNameLabel.Location = new System.Drawing.Point(16, 474);
            this._AirportNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._AirportNameLabel.Name = "_AirportNameLabel";
            this._AirportNameLabel.Size = new System.Drawing.Size(86, 16);
            this._AirportNameLabel.TabIndex = 28;
            this._AirportNameLabel.Text = "Airport Name";
            // 
            // _FlightCountLabel
            // 
            this._FlightCountLabel.AutoSize = true;
            this._FlightCountLabel.Location = new System.Drawing.Point(15, 527);
            this._FlightCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._FlightCountLabel.Name = "_FlightCountLabel";
            this._FlightCountLabel.Size = new System.Drawing.Size(76, 16);
            this._FlightCountLabel.TabIndex = 29;
            this._FlightCountLabel.Text = "Flight Count";
            // 
            // _TicketsSoldLabel
            // 
            this._TicketsSoldLabel.AutoSize = true;
            this._TicketsSoldLabel.Location = new System.Drawing.Point(15, 582);
            this._TicketsSoldLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._TicketsSoldLabel.Name = "_TicketsSoldLabel";
            this._TicketsSoldLabel.Size = new System.Drawing.Size(82, 16);
            this._TicketsSoldLabel.TabIndex = 30;
            this._TicketsSoldLabel.Text = "Tickets Sold";
            // 
            // _CountryCodeLabel
            // 
            this._CountryCodeLabel.AutoSize = true;
            this._CountryCodeLabel.Location = new System.Drawing.Point(13, 629);
            this._CountryCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._CountryCodeLabel.Name = "_CountryCodeLabel";
            this._CountryCodeLabel.Size = new System.Drawing.Size(88, 16);
            this._CountryCodeLabel.TabIndex = 31;
            this._CountryCodeLabel.Text = "Country Code";
            // 
            // _OpeningYearLabel
            // 
            this._OpeningYearLabel.AutoSize = true;
            this._OpeningYearLabel.Location = new System.Drawing.Point(16, 681);
            this._OpeningYearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._OpeningYearLabel.Name = "_OpeningYearLabel";
            this._OpeningYearLabel.Size = new System.Drawing.Size(90, 16);
            this._OpeningYearLabel.TabIndex = 32;
            this._OpeningYearLabel.Text = "Opening Year";
            // 
            // _AirportAreaLabel
            // 
            this._AirportAreaLabel.AutoSize = true;
            this._AirportAreaLabel.Location = new System.Drawing.Point(23, 735);
            this._AirportAreaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._AirportAreaLabel.Name = "_AirportAreaLabel";
            this._AirportAreaLabel.Size = new System.Drawing.Size(78, 16);
            this._AirportAreaLabel.TabIndex = 33;
            this._AirportAreaLabel.Text = "Airport Area";
            // 
            // _AirportRatingLabel
            // 
            this._AirportRatingLabel.AutoSize = true;
            this._AirportRatingLabel.Location = new System.Drawing.Point(23, 788);
            this._AirportRatingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._AirportRatingLabel.Name = "_AirportRatingLabel";
            this._AirportRatingLabel.Size = new System.Drawing.Size(88, 16);
            this._AirportRatingLabel.TabIndex = 34;
            this._AirportRatingLabel.Text = "Airport Rating";
            // 
            // ConstructorDefaultRadio
            // 
            this.ConstructorDefaultRadio.AutoSize = true;
            this.ConstructorDefaultRadio.Location = new System.Drawing.Point(0, 21);
            this.ConstructorDefaultRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConstructorDefaultRadio.Name = "ConstructorDefaultRadio";
            this.ConstructorDefaultRadio.Size = new System.Drawing.Size(222, 20);
            this.ConstructorDefaultRadio.TabIndex = 35;
            this.ConstructorDefaultRadio.TabStop = true;
            this.ConstructorDefaultRadio.Text = "Конструктор без параметров";
            this.ConstructorDefaultRadio.UseVisualStyleBackColor = true;
            this.ConstructorDefaultRadio.CheckedChanged += new System.EventHandler(this.ConstructorDefaultRadio_CheckedChanged);
            // 
            // Constructor1Radio
            // 
            this.Constructor1Radio.AutoSize = true;
            this.Constructor1Radio.Location = new System.Drawing.Point(0, 47);
            this.Constructor1Radio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Constructor1Radio.Name = "Constructor1Radio";
            this.Constructor1Radio.Size = new System.Drawing.Size(216, 20);
            this.Constructor1Radio.TabIndex = 36;
            this.Constructor1Radio.TabStop = true;
            this.Constructor1Radio.Text = "Конструктор с 1 параметром";
            this.Constructor1Radio.UseVisualStyleBackColor = true;
            this.Constructor1Radio.CheckedChanged += new System.EventHandler(this.Constructor1Radio_CheckedChanged);
            // 
            // Constructor2Radio
            // 
            this.Constructor2Radio.AutoSize = true;
            this.Constructor2Radio.Location = new System.Drawing.Point(0, 73);
            this.Constructor2Radio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Constructor2Radio.Name = "Constructor2Radio";
            this.Constructor2Radio.Size = new System.Drawing.Size(224, 20);
            this.Constructor2Radio.TabIndex = 37;
            this.Constructor2Radio.TabStop = true;
            this.Constructor2Radio.Text = "Конструктор с 2 параметрами";
            this.Constructor2Radio.UseVisualStyleBackColor = true;
            this.Constructor2Radio.CheckedChanged += new System.EventHandler(this.Constructor2Radio_CheckedChanged);
            // 
            // ConstructorAllRadio
            // 
            this.ConstructorAllRadio.AutoSize = true;
            this.ConstructorAllRadio.Location = new System.Drawing.Point(0, 98);
            this.ConstructorAllRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConstructorAllRadio.Name = "ConstructorAllRadio";
            this.ConstructorAllRadio.Size = new System.Drawing.Size(265, 20);
            this.ConstructorAllRadio.TabIndex = 38;
            this.ConstructorAllRadio.TabStop = true;
            this.ConstructorAllRadio.Text = "Конструктор со всеми параметрами";
            this.ConstructorAllRadio.UseVisualStyleBackColor = true;
            this.ConstructorAllRadio.CheckedChanged += new System.EventHandler(this.ConstructorAllRadio_CheckedChanged);
            // 
            // ConstructorGroupBox
            // 
            this.ConstructorGroupBox.Controls.Add(this.ConstructorAllRadio);
            this.ConstructorGroupBox.Controls.Add(this.ConstructorDefaultRadio);
            this.ConstructorGroupBox.Controls.Add(this.Constructor1Radio);
            this.ConstructorGroupBox.Controls.Add(this.Constructor2Radio);
            this.ConstructorGroupBox.Location = new System.Drawing.Point(13, 155);
            this.ConstructorGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConstructorGroupBox.Name = "ConstructorGroupBox";
            this.ConstructorGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConstructorGroupBox.Size = new System.Drawing.Size(267, 133);
            this.ConstructorGroupBox.TabIndex = 39;
            this.ConstructorGroupBox.TabStop = false;
            this.ConstructorGroupBox.Text = "Выбор конструктора";
            // 
            // _AirportNameTextBoxConstructor
            // 
            this._AirportNameTextBoxConstructor.Location = new System.Drawing.Point(313, 70);
            this._AirportNameTextBoxConstructor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._AirportNameTextBoxConstructor.Name = "_AirportNameTextBoxConstructor";
            this._AirportNameTextBoxConstructor.Size = new System.Drawing.Size(351, 22);
            this._AirportNameTextBoxConstructor.TabIndex = 40;
            this._AirportNameTextBoxConstructor.Visible = false;
            this._AirportNameTextBoxConstructor.TextChanged += new System.EventHandler(this.Field1TB_TextChanged);
            // 
            // _CountryCodeTextBoxConstructor
            // 
            this._CountryCodeTextBoxConstructor.Location = new System.Drawing.Point(313, 222);
            this._CountryCodeTextBoxConstructor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._CountryCodeTextBoxConstructor.Name = "_CountryCodeTextBoxConstructor";
            this._CountryCodeTextBoxConstructor.Size = new System.Drawing.Size(351, 22);
            this._CountryCodeTextBoxConstructor.TabIndex = 41;
            this._CountryCodeTextBoxConstructor.Visible = false;
            this._CountryCodeTextBoxConstructor.TextChanged += new System.EventHandler(this.Field4TB_TextChanged);
            // 
            // _FlightCountTextBoxConstructor
            // 
            this._FlightCountTextBoxConstructor.Location = new System.Drawing.Point(313, 117);
            this._FlightCountTextBoxConstructor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._FlightCountTextBoxConstructor.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this._FlightCountTextBoxConstructor.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this._FlightCountTextBoxConstructor.Name = "_FlightCountTextBoxConstructor";
            this._FlightCountTextBoxConstructor.Size = new System.Drawing.Size(351, 22);
            this._FlightCountTextBoxConstructor.TabIndex = 42;
            this._FlightCountTextBoxConstructor.Visible = false;
            this._FlightCountTextBoxConstructor.ValueChanged += new System.EventHandler(this.Field2TB_ValueChanged);
            // 
            // _TicketsSoldTextBoxConstructor
            // 
            this._TicketsSoldTextBoxConstructor.Location = new System.Drawing.Point(313, 167);
            this._TicketsSoldTextBoxConstructor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._TicketsSoldTextBoxConstructor.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this._TicketsSoldTextBoxConstructor.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this._TicketsSoldTextBoxConstructor.Name = "_TicketsSoldTextBoxConstructor";
            this._TicketsSoldTextBoxConstructor.Size = new System.Drawing.Size(351, 22);
            this._TicketsSoldTextBoxConstructor.TabIndex = 43;
            this._TicketsSoldTextBoxConstructor.Visible = false;
            this._TicketsSoldTextBoxConstructor.ValueChanged += new System.EventHandler(this.Field3TB_ValueChanged);
            // 
            // _OpeningYearTextBoxConstructor
            // 
            this._OpeningYearTextBoxConstructor.Location = new System.Drawing.Point(313, 266);
            this._OpeningYearTextBoxConstructor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._OpeningYearTextBoxConstructor.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this._OpeningYearTextBoxConstructor.Minimum = new decimal(new int[] {
            1910,
            0,
            0,
            0});
            this._OpeningYearTextBoxConstructor.Name = "_OpeningYearTextBoxConstructor";
            this._OpeningYearTextBoxConstructor.Size = new System.Drawing.Size(351, 22);
            this._OpeningYearTextBoxConstructor.TabIndex = 44;
            this._OpeningYearTextBoxConstructor.Value = new decimal(new int[] {
            1910,
            0,
            0,
            0});
            this._OpeningYearTextBoxConstructor.Visible = false;
            this._OpeningYearTextBoxConstructor.ValueChanged += new System.EventHandler(this.Field5TB_ValueChanged);
            // 
            // _AirportAreaTextBoxConstructor
            // 
            this._AirportAreaTextBoxConstructor.Location = new System.Drawing.Point(313, 321);
            this._AirportAreaTextBoxConstructor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._AirportAreaTextBoxConstructor.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this._AirportAreaTextBoxConstructor.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this._AirportAreaTextBoxConstructor.Name = "_AirportAreaTextBoxConstructor";
            this._AirportAreaTextBoxConstructor.Size = new System.Drawing.Size(351, 22);
            this._AirportAreaTextBoxConstructor.TabIndex = 45;
            this._AirportAreaTextBoxConstructor.Visible = false;
            this._AirportAreaTextBoxConstructor.ValueChanged += new System.EventHandler(this.Field6TB_ValueChanged);
            // 
            // _AirportRatingTextBoxConstructor
            // 
            this._AirportRatingTextBoxConstructor.Location = new System.Drawing.Point(313, 370);
            this._AirportRatingTextBoxConstructor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._AirportRatingTextBoxConstructor.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this._AirportRatingTextBoxConstructor.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this._AirportRatingTextBoxConstructor.Name = "_AirportRatingTextBoxConstructor";
            this._AirportRatingTextBoxConstructor.Size = new System.Drawing.Size(351, 22);
            this._AirportRatingTextBoxConstructor.TabIndex = 46;
            this._AirportRatingTextBoxConstructor.Visible = false;
            this._AirportRatingTextBoxConstructor.ValueChanged += new System.EventHandler(this.Field7TB_ValueChanged);
            // 
            // _AirportNameLabelConstructor
            // 
            this._AirportNameLabelConstructor.AutoSize = true;
            this._AirportNameLabelConstructor.Location = new System.Drawing.Point(309, 50);
            this._AirportNameLabelConstructor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._AirportNameLabelConstructor.Name = "_AirportNameLabelConstructor";
            this._AirportNameLabelConstructor.Size = new System.Drawing.Size(86, 16);
            this._AirportNameLabelConstructor.TabIndex = 47;
            this._AirportNameLabelConstructor.Text = "Airport Name";
            this._AirportNameLabelConstructor.Visible = false;
            // 
            // _FlightCountLabelConstructor
            // 
            this._FlightCountLabelConstructor.AutoSize = true;
            this._FlightCountLabelConstructor.Location = new System.Drawing.Point(309, 98);
            this._FlightCountLabelConstructor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._FlightCountLabelConstructor.Name = "_FlightCountLabelConstructor";
            this._FlightCountLabelConstructor.Size = new System.Drawing.Size(76, 16);
            this._FlightCountLabelConstructor.TabIndex = 48;
            this._FlightCountLabelConstructor.Text = "Flight Count";
            this._FlightCountLabelConstructor.Visible = false;
            // 
            // _TicketsSoldLabelConstructor
            // 
            this._TicketsSoldLabelConstructor.AutoSize = true;
            this._TicketsSoldLabelConstructor.Location = new System.Drawing.Point(309, 146);
            this._TicketsSoldLabelConstructor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._TicketsSoldLabelConstructor.Name = "_TicketsSoldLabelConstructor";
            this._TicketsSoldLabelConstructor.Size = new System.Drawing.Size(82, 16);
            this._TicketsSoldLabelConstructor.TabIndex = 49;
            this._TicketsSoldLabelConstructor.Text = "Tickets Sold";
            this._TicketsSoldLabelConstructor.Visible = false;
            // 
            // _CountryCodeLabelConstructor
            // 
            this._CountryCodeLabelConstructor.AutoSize = true;
            this._CountryCodeLabelConstructor.Location = new System.Drawing.Point(309, 193);
            this._CountryCodeLabelConstructor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._CountryCodeLabelConstructor.Name = "_CountryCodeLabelConstructor";
            this._CountryCodeLabelConstructor.Size = new System.Drawing.Size(88, 16);
            this._CountryCodeLabelConstructor.TabIndex = 50;
            this._CountryCodeLabelConstructor.Text = "Country Code";
            this._CountryCodeLabelConstructor.Visible = false;
            // 
            // _OpeningYearLabelConstructor
            // 
            this._OpeningYearLabelConstructor.AutoSize = true;
            this._OpeningYearLabelConstructor.Location = new System.Drawing.Point(309, 247);
            this._OpeningYearLabelConstructor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._OpeningYearLabelConstructor.Name = "_OpeningYearLabelConstructor";
            this._OpeningYearLabelConstructor.Size = new System.Drawing.Size(90, 16);
            this._OpeningYearLabelConstructor.TabIndex = 51;
            this._OpeningYearLabelConstructor.Text = "Opening Year";
            this._OpeningYearLabelConstructor.Visible = false;
            // 
            // _AirportAreaLabelConstructor
            // 
            this._AirportAreaLabelConstructor.AutoSize = true;
            this._AirportAreaLabelConstructor.Location = new System.Drawing.Point(309, 302);
            this._AirportAreaLabelConstructor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._AirportAreaLabelConstructor.Name = "_AirportAreaLabelConstructor";
            this._AirportAreaLabelConstructor.Size = new System.Drawing.Size(78, 16);
            this._AirportAreaLabelConstructor.TabIndex = 52;
            this._AirportAreaLabelConstructor.Text = "Airport Area";
            this._AirportAreaLabelConstructor.Visible = false;
            // 
            // _AirportRatingLabelConstructor
            // 
            this._AirportRatingLabelConstructor.AutoSize = true;
            this._AirportRatingLabelConstructor.Location = new System.Drawing.Point(312, 352);
            this._AirportRatingLabelConstructor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._AirportRatingLabelConstructor.Name = "_AirportRatingLabelConstructor";
            this._AirportRatingLabelConstructor.Size = new System.Drawing.Size(88, 16);
            this._AirportRatingLabelConstructor.TabIndex = 53;
            this._AirportRatingLabelConstructor.Text = "Airport Rating";
            this._AirportRatingLabelConstructor.Visible = false;
            // 
            // PerformanceResultsListView
            // 
            this.PerformanceResultsListView.HideSelection = false;
            this.PerformanceResultsListView.Location = new System.Drawing.Point(1111, 414);
            this.PerformanceResultsListView.Margin = new System.Windows.Forms.Padding(4);
            this.PerformanceResultsListView.Name = "PerformanceResultsListView";
            this.PerformanceResultsListView.Size = new System.Drawing.Size(396, 360);
            this.PerformanceResultsListView.TabIndex = 54;
            this.PerformanceResultsListView.UseCompatibleStateImageBehavior = false;
            // 
            // PerformanceTestButton
            // 
            this.PerformanceTestButton.Location = new System.Drawing.Point(1217, 782);
            this.PerformanceTestButton.Margin = new System.Windows.Forms.Padding(4);
            this.PerformanceTestButton.Name = "PerformanceTestButton";
            this.PerformanceTestButton.Size = new System.Drawing.Size(220, 55);
            this.PerformanceTestButton.TabIndex = 55;
            this.PerformanceTestButton.Text = "Тест производительности";
            this.PerformanceTestButton.UseVisualStyleBackColor = true;
            this.PerformanceTestButton.Click += new System.EventHandler(this.PerformanceTestButton_Click);
            // 
            // CollectionOutputTextBox
            // 
            this.CollectionOutputTextBox.Location = new System.Drawing.Point(676, 414);
            this.CollectionOutputTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CollectionOutputTextBox.Name = "CollectionOutputTextBox";
            this.CollectionOutputTextBox.ReadOnly = true;
            this.CollectionOutputTextBox.Size = new System.Drawing.Size(408, 311);
            this.CollectionOutputTextBox.TabIndex = 56;
            this.CollectionOutputTextBox.Text = "";
            // 
            // CollectionOutputButton
            // 
            this.CollectionOutputButton.Location = new System.Drawing.Point(931, 782);
            this.CollectionOutputButton.Margin = new System.Windows.Forms.Padding(4);
            this.CollectionOutputButton.Name = "CollectionOutputButton";
            this.CollectionOutputButton.Size = new System.Drawing.Size(155, 55);
            this.CollectionOutputButton.TabIndex = 57;
            this.CollectionOutputButton.Text = "Вывести элементы коллекции";
            this.CollectionOutputButton.UseVisualStyleBackColor = true;
            this.CollectionOutputButton.Click += new System.EventHandler(this.CollectionOutputButton_Click);
            // 
            // AddToCollectionButton
            // 
            this.AddToCollectionButton.Location = new System.Drawing.Point(676, 782);
            this.AddToCollectionButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddToCollectionButton.Name = "AddToCollectionButton";
            this.AddToCollectionButton.Size = new System.Drawing.Size(124, 55);
            this.AddToCollectionButton.TabIndex = 58;
            this.AddToCollectionButton.Text = "Добавить элемент";
            this.AddToCollectionButton.UseVisualStyleBackColor = true;
            this.AddToCollectionButton.Click += new System.EventHandler(this.AddToCollectionButton_Click);
            // 
            // DeleteFromCollectionButton
            // 
            this.DeleteFromCollectionButton.Location = new System.Drawing.Point(808, 782);
            this.DeleteFromCollectionButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteFromCollectionButton.Name = "DeleteFromCollectionButton";
            this.DeleteFromCollectionButton.Size = new System.Drawing.Size(115, 55);
            this.DeleteFromCollectionButton.TabIndex = 59;
            this.DeleteFromCollectionButton.Text = "Удалить элемент";
            this.DeleteFromCollectionButton.UseVisualStyleBackColor = true;
            this.DeleteFromCollectionButton.Click += new System.EventHandler(this.DeleteFromCollectionButton_Click);
            // 
            // InputDataLabel
            // 
            this.InputDataLabel.AutoSize = true;
            this.InputDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputDataLabel.Location = new System.Drawing.Point(196, 414);
            this.InputDataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InputDataLabel.Name = "InputDataLabel";
            this.InputDataLabel.Size = new System.Drawing.Size(185, 31);
            this.InputDataLabel.TabIndex = 60;
            this.InputDataLabel.Text = "Ввод данных:";
            // 
            // AirportTypeGroupBox
            // 
            this.AirportTypeGroupBox.Controls.Add(this.CivilAirportTypeRadioButton);
            this.AirportTypeGroupBox.Controls.Add(this.MilitaryAirportTypeRadioButton);
            this.AirportTypeGroupBox.Controls.Add(this.UnknownAirportTypeRadioButton);
            this.AirportTypeGroupBox.Location = new System.Drawing.Point(676, 722);
            this.AirportTypeGroupBox.Name = "AirportTypeGroupBox";
            this.AirportTypeGroupBox.Size = new System.Drawing.Size(408, 52);
            this.AirportTypeGroupBox.TabIndex = 61;
            this.AirportTypeGroupBox.TabStop = false;
            this.AirportTypeGroupBox.Text = "Выбор типа аэропорта";
            // 
            // CivilAirportTypeRadioButton
            // 
            this.CivilAirportTypeRadioButton.AutoSize = true;
            this.CivilAirportTypeRadioButton.Location = new System.Drawing.Point(288, 21);
            this.CivilAirportTypeRadioButton.Name = "CivilAirportTypeRadioButton";
            this.CivilAirportTypeRadioButton.Size = new System.Drawing.Size(114, 20);
            this.CivilAirportTypeRadioButton.TabIndex = 2;
            this.CivilAirportTypeRadioButton.TabStop = true;
            this.CivilAirportTypeRadioButton.Text = "Гражданский";
            this.CivilAirportTypeRadioButton.UseVisualStyleBackColor = true;
            // 
            // MilitaryAirportTypeRadioButton
            // 
            this.MilitaryAirportTypeRadioButton.AutoSize = true;
            this.MilitaryAirportTypeRadioButton.Location = new System.Drawing.Point(161, 21);
            this.MilitaryAirportTypeRadioButton.Name = "MilitaryAirportTypeRadioButton";
            this.MilitaryAirportTypeRadioButton.Size = new System.Drawing.Size(86, 20);
            this.MilitaryAirportTypeRadioButton.TabIndex = 1;
            this.MilitaryAirportTypeRadioButton.TabStop = true;
            this.MilitaryAirportTypeRadioButton.Text = "Военный";
            this.MilitaryAirportTypeRadioButton.UseVisualStyleBackColor = true;
            // 
            // UnknownAirportTypeRadioButton
            // 
            this.UnknownAirportTypeRadioButton.AutoSize = true;
            this.UnknownAirportTypeRadioButton.Checked = true;
            this.UnknownAirportTypeRadioButton.Location = new System.Drawing.Point(6, 21);
            this.UnknownAirportTypeRadioButton.Name = "UnknownAirportTypeRadioButton";
            this.UnknownAirportTypeRadioButton.Size = new System.Drawing.Size(108, 20);
            this.UnknownAirportTypeRadioButton.TabIndex = 0;
            this.UnknownAirportTypeRadioButton.TabStop = true;
            this.UnknownAirportTypeRadioButton.Text = "Неизвестно";
            this.UnknownAirportTypeRadioButton.UseVisualStyleBackColor = true;
            // 
            // SearchByCountryCodeButton
            // 
            this.SearchByCountryCodeButton.Location = new System.Drawing.Point(676, 844);
            this.SearchByCountryCodeButton.Name = "SearchByCountryCodeButton";
            this.SearchByCountryCodeButton.Size = new System.Drawing.Size(185, 58);
            this.SearchByCountryCodeButton.TabIndex = 62;
            this.SearchByCountryCodeButton.Text = "Поиск по коду страны";
            this.SearchByCountryCodeButton.UseVisualStyleBackColor = true;
            this.SearchByCountryCodeButton.Click += new System.EventHandler(this.SearchByCountryCodeButton_Click);
            // 
            // _CountryCodeSearchTextBox
            // 
            this._CountryCodeSearchTextBox.Location = new System.Drawing.Point(676, 908);
            this._CountryCodeSearchTextBox.Name = "_CountryCodeSearchTextBox";
            this._CountryCodeSearchTextBox.Size = new System.Drawing.Size(185, 22);
            this._CountryCodeSearchTextBox.TabIndex = 63;
            // 
            // CreateSnapshotButton
            // 
            this.CreateSnapshotButton.Location = new System.Drawing.Point(867, 844);
            this.CreateSnapshotButton.Name = "CreateSnapshotButton";
            this.CreateSnapshotButton.Size = new System.Drawing.Size(104, 58);
            this.CreateSnapshotButton.TabIndex = 64;
            this.CreateSnapshotButton.Text = "Создать снапшот";
            this.CreateSnapshotButton.UseVisualStyleBackColor = true;
            this.CreateSnapshotButton.Click += new System.EventHandler(this.CreateSnapshotButton_Click);
            // 
            // RestoreSnapshotButton
            // 
            this.RestoreSnapshotButton.Location = new System.Drawing.Point(977, 844);
            this.RestoreSnapshotButton.Name = "RestoreSnapshotButton";
            this.RestoreSnapshotButton.Size = new System.Drawing.Size(109, 58);
            this.RestoreSnapshotButton.TabIndex = 65;
            this.RestoreSnapshotButton.Text = "Восстановить снапшот";
            this.RestoreSnapshotButton.UseVisualStyleBackColor = true;
            this.RestoreSnapshotButton.Click += new System.EventHandler(this.RestoreSnapshotButton_Click);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1516, 969);
            this.Controls.Add(this.RestoreSnapshotButton);
            this.Controls.Add(this.CreateSnapshotButton);
            this.Controls.Add(this._CountryCodeSearchTextBox);
            this.Controls.Add(this.SearchByCountryCodeButton);
            this.Controls.Add(this.AirportTypeGroupBox);
            this.Controls.Add(this.InputDataLabel);
            this.Controls.Add(this.DeleteFromCollectionButton);
            this.Controls.Add(this.AddToCollectionButton);
            this.Controls.Add(this.CollectionOutputButton);
            this.Controls.Add(this.CollectionOutputTextBox);
            this.Controls.Add(this.PerformanceTestButton);
            this.Controls.Add(this.PerformanceResultsListView);
            this.Controls.Add(this._AirportRatingLabelConstructor);
            this.Controls.Add(this._AirportAreaLabelConstructor);
            this.Controls.Add(this._OpeningYearLabelConstructor);
            this.Controls.Add(this._CountryCodeLabelConstructor);
            this.Controls.Add(this._TicketsSoldLabelConstructor);
            this.Controls.Add(this._FlightCountLabelConstructor);
            this.Controls.Add(this._AirportNameLabelConstructor);
            this.Controls.Add(this._AirportRatingTextBoxConstructor);
            this.Controls.Add(this._AirportAreaTextBoxConstructor);
            this.Controls.Add(this._OpeningYearTextBoxConstructor);
            this.Controls.Add(this._TicketsSoldTextBoxConstructor);
            this.Controls.Add(this._FlightCountTextBoxConstructor);
            this.Controls.Add(this._CountryCodeTextBoxConstructor);
            this.Controls.Add(this._AirportNameTextBoxConstructor);
            this.Controls.Add(this.ConstructorGroupBox);
            this.Controls.Add(this._AirportRatingLabel);
            this.Controls.Add(this._AirportAreaLabel);
            this.Controls.Add(this._OpeningYearLabel);
            this.Controls.Add(this._CountryCodeLabel);
            this.Controls.Add(this._TicketsSoldLabel);
            this.Controls.Add(this._FlightCountLabel);
            this.Controls.Add(this._AirportNameLabel);
            this.Controls.Add(this.ChangeFieldsLabel);
            this.Controls.Add(this.AddObject);
            this.Controls.Add(this.output_TextBox);
            this.Controls.Add(this._CountryCodeTextBox);
            this.Controls.Add(this._AirportNameTextBox);
            this.Controls.Add(this._AirportRatingTextBox);
            this.Controls.Add(this._AirportAreaTextBox);
            this.Controls.Add(this._OpeningYearTextBox);
            this.Controls.Add(this._TicketsSoldTextBox);
            this.Controls.Add(this._FlightCountTextBox);
            this.Controls.Add(this.ChangeFieldButton);
            this.Controls.Add(this.OutputButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Шмоленко;Васильев;22ВП1;ЛБ-1";
            this.Load += new System.EventHandler(this.Window_Load);
            ((System.ComponentModel.ISupportInitialize)(this._FlightCountTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._TicketsSoldTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._OpeningYearTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._AirportAreaTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._AirportRatingTextBox)).EndInit();
            this.ConstructorGroupBox.ResumeLayout(false);
            this.ConstructorGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._FlightCountTextBoxConstructor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._TicketsSoldTextBoxConstructor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._OpeningYearTextBoxConstructor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._AirportAreaTextBoxConstructor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._AirportRatingTextBoxConstructor)).EndInit();
            this.AirportTypeGroupBox.ResumeLayout(false);
            this.AirportTypeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OutputButton;
        private System.Windows.Forms.Button ChangeFieldButton;
        private System.Windows.Forms.NumericUpDown _FlightCountTextBox;
        private System.Windows.Forms.NumericUpDown _TicketsSoldTextBox;
        private System.Windows.Forms.NumericUpDown _OpeningYearTextBox;
        private System.Windows.Forms.NumericUpDown _AirportAreaTextBox;
        private System.Windows.Forms.NumericUpDown _AirportRatingTextBox;
        private System.Windows.Forms.TextBox _AirportNameTextBox;
        private System.Windows.Forms.TextBox _CountryCodeTextBox;
        private System.Windows.Forms.RichTextBox output_TextBox;
        private System.Windows.Forms.Button AddObject;
        private System.Windows.Forms.Label ChangeFieldsLabel;
        private System.Windows.Forms.Label _AirportNameLabel;
        private System.Windows.Forms.Label _FlightCountLabel;
        private System.Windows.Forms.Label _TicketsSoldLabel;
        private System.Windows.Forms.Label _CountryCodeLabel;
        private System.Windows.Forms.Label _OpeningYearLabel;
        private System.Windows.Forms.Label _AirportAreaLabel;
        private System.Windows.Forms.Label _AirportRatingLabel;
        private System.Windows.Forms.RadioButton ConstructorDefaultRadio;
        private System.Windows.Forms.RadioButton Constructor1Radio;
        private System.Windows.Forms.RadioButton Constructor2Radio;
        private System.Windows.Forms.RadioButton ConstructorAllRadio;
        private System.Windows.Forms.GroupBox ConstructorGroupBox;
        private System.Windows.Forms.TextBox _AirportNameTextBoxConstructor;
        private System.Windows.Forms.TextBox _CountryCodeTextBoxConstructor;
        private System.Windows.Forms.NumericUpDown _FlightCountTextBoxConstructor;
        private System.Windows.Forms.NumericUpDown _TicketsSoldTextBoxConstructor;
        private System.Windows.Forms.NumericUpDown _OpeningYearTextBoxConstructor;
        private System.Windows.Forms.NumericUpDown _AirportAreaTextBoxConstructor;
        private System.Windows.Forms.NumericUpDown _AirportRatingTextBoxConstructor;
        private System.Windows.Forms.Label _AirportNameLabelConstructor;
        private System.Windows.Forms.Label _FlightCountLabelConstructor;
        private System.Windows.Forms.Label _TicketsSoldLabelConstructor;
        private System.Windows.Forms.Label _CountryCodeLabelConstructor;
        private System.Windows.Forms.Label _OpeningYearLabelConstructor;
        private System.Windows.Forms.Label _AirportAreaLabelConstructor;
        private System.Windows.Forms.Label _AirportRatingLabelConstructor;
        private System.Windows.Forms.ListView PerformanceResultsListView;
        private System.Windows.Forms.Button PerformanceTestButton;
        private System.Windows.Forms.RichTextBox CollectionOutputTextBox;
        private System.Windows.Forms.Button CollectionOutputButton;
        private System.Windows.Forms.Button AddToCollectionButton;
        private System.Windows.Forms.Button DeleteFromCollectionButton;
        private System.Windows.Forms.Label InputDataLabel;
        private System.Windows.Forms.GroupBox AirportTypeGroupBox;
        private System.Windows.Forms.RadioButton CivilAirportTypeRadioButton;
        private System.Windows.Forms.RadioButton MilitaryAirportTypeRadioButton;
        private System.Windows.Forms.RadioButton UnknownAirportTypeRadioButton;
        private System.Windows.Forms.Button SearchByCountryCodeButton;
        private System.Windows.Forms.TextBox _CountryCodeSearchTextBox;
        private System.Windows.Forms.Button CreateSnapshotButton;
        private System.Windows.Forms.Button RestoreSnapshotButton;
    }
}

